using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Spire.Pdf;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Org.BouncyCastle.Bcpg.Sig;

namespace LotoAdatbazis
{
    class SpireConvert
    {
        public static int Index { get; set; }
        public static string file { get; set; }
        public static string pathGlobal { get; set; }
        public static void Convert(string path)
        {
            Index = 0;
            pathGlobal = path;
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(path);
            for (int i = 0; i < doc.Pages.Count; i++)
            {
                if(BackEnd.cbJelMod2_SelectedIndex == 0)
                {
                    if (i == 0 && BackEnd.VanAzElsoOldalon(path))
                    {
                        Image emf = doc.SaveAsImage(i, Spire.Pdf.Graphics.PdfImageType.Metafile);
                        Image zoomImg = new Bitmap((int)(emf.Size.Width * 5), (int)(emf.Size.Height * 5));
                        using (Graphics g = Graphics.FromImage(zoomImg))
                        {
                            g.ScaleTransform(5.0f, 5.0f);
                            g.DrawImage(emf, new Rectangle(new Point(0, 0), emf.Size), new Rectangle(new Point(0, 0), emf.Size), GraphicsUnit.Pixel); //ez ne pixel legyen
                        }
                        //zoomImg.Save(Path.GetDirectoryName(path) + "\\" + Index + "zoom" + ".jpg");

                        JelekKeszitese(zoomImg, true);
                    }
                    else if (i != 0)
                    {
                        Image emf = doc.SaveAsImage(i, Spire.Pdf.Graphics.PdfImageType.Metafile);
                        Image zoomImg = new Bitmap((int)(emf.Size.Width * 5), (int)(emf.Size.Height * 5));
                        using (Graphics g = Graphics.FromImage(zoomImg))
                        {
                            g.ScaleTransform(5.0f, 5.0f);
                            g.DrawImage(emf, new Rectangle(new Point(0, 0), emf.Size), new Rectangle(new Point(0, 0), emf.Size), GraphicsUnit.Pixel);//ez nem pixel
                        }
                        //zoomImg.Save(Path.GetDirectoryName(path) + "\\" + Index + "zoom" + ".jpg");

                        JelekKeszitese(zoomImg, false);
                    }
                }
                else
                {
                    Image emf = doc.SaveAsImage(i, Spire.Pdf.Graphics.PdfImageType.Metafile);
                    Image zoomImg = new Bitmap((int)(emf.Size.Width * 5), (int)(emf.Size.Height * 5));
                    using (Graphics g = Graphics.FromImage(zoomImg))
                    {
                        g.ScaleTransform(5.0f, 5.0f);
                        g.DrawImage(emf, new Rectangle(new Point(0, 0), emf.Size), new Rectangle(new Point(0, 0), emf.Size), GraphicsUnit.Pixel);
                    }
                    //zoomImg.Save(Path.GetDirectoryName(path) + "\\" + Index + "zoom" + ".jpg");

                    JelekKesziteseKepbol(zoomImg);
                    break;
                }
            }
            //ConvertImagesToPDF();
        }

        public static List<Jel> Jelek = new List<Jel>();
        public static void JelekKeszitese(Image input, bool elsoOldal)
        {
            System.Drawing.Bitmap kep = (Bitmap)input;
            int kezdoErtek = 800; //Ez Y ban a keresés kezdete
            if (elsoOldal)
            {
                kezdoErtek = KezdoYKereses(input);
            }
            int kezdoX = KezdoXKereses(input, kezdoErtek);

            List<int[]> RedXY = RedYValues(input, kezdoErtek, kezdoX);
            List<int> RedX = new List<int>();
            List<int> RedY = new List<int>();
            for (int i = 0; i < RedXY.Count; i++)
            {
                RedY.Add(RedXY[i][0]);
                RedX.Add(RedXY[i][1]);
            }
            List<int[]> YellowXY = YellowYValues(input, kezdoErtek, kezdoX);
            List<int> YellowX = new List<int>();
            List<int> YellowY = new List<int>();
            for (int i = 0; i < YellowXY.Count; i++)
            {
                YellowY.Add(YellowXY[i][0]);
                YellowX.Add(YellowXY[i][1]);
            }
            Jelek.Clear();

            for (int i = 0; i < RedY.Count; i++)
            {
                Jelek.Add(new Jel(RedX[i] - 15, 240, RedY[i] - 118, 240, true));
            }
            for (int i = 0; i < YellowY.Count; i++)
            {
                Jelek.Add(new Jel(YellowX[i] - 15, 295, YellowY[i] - 148, 295, true));
            }
            for (int i = 0; i < Jelek.Count; i++)
            {
                if(!Directory.Exists(Path.GetDirectoryName(file) + "\\Jelek"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(file) + "\\Jelek");
                }
                CropAnImage(kep, Jelek[i].BefoglaloMezo, Path.GetDirectoryName(file) + "\\Jelek\\" + (Index + 1).ToString() + ".jpg");
                Index++;
            }
        }
        public static void JelekKesziteseKepbol(Image input) //Ez amikor a térképből gyűjti a jelet
        {
            System.Drawing.Bitmap kep = (Bitmap)input;
            int kezdoErtek = 5200; //Ez Y ban a keresés kezdete
            try
            {
                kezdoErtek = KezdoYKereses(input);
            }
            catch
            {

            }
            FindImage.Search(input, kezdoErtek);
        }
        public static List<int[]> RedYValues(Image input, int kezdoY, int posX)
        {
            System.Drawing.Bitmap kep = (Bitmap)input;
            List<int[]> eredmenyek = new List<int[]>();
            List<int> reszEredmenyekX = new List<int>();
            List<int> reszEredmenyekY = new List<int>();
            //int min = posX;
            for (int j = kezdoY; j < kep.Height; j++)
            {
                for (int i = 0; i < posX; i++)
                {
                    Color pixel = kep.GetPixel(i, j);
                    if (pixel.R < 185 && pixel.G < 10 && pixel.B < 10 && pixel.R > 160)
                    {
                        reszEredmenyekX.Add(i);
                        reszEredmenyekY.Add(j);
                        /*
                        if (i < min)
                        {
                            min = i;
                        }*/
                        break;
                    }
                }
            }
            List<int[]> reszeredmeny = new List<int[]>();
            for (int i = 1; i < reszEredmenyekY.Count; i++)
            {
                if (Math.Abs(reszEredmenyekY[i]-reszEredmenyekY[i-1])>2)
                {
                    List<int> ideiglenesReszeredmenyX = new List<int>(); //Ez csak a rész X értékek
                    for (int j = 0; j < reszeredmeny.Count; j++)
                    {
                        ideiglenesReszeredmenyX.Add(reszeredmeny[j][1]);
                    }
                    eredmenyek.Add(new int[] { Math.Abs(reszeredmeny.First().First() + reszeredmeny.Last().First()) / 2, ideiglenesReszeredmenyX.Min()});
                    reszeredmeny.Clear();
                }
                else
                {
                    reszeredmeny.Add(new int[] { reszEredmenyekY[i], reszEredmenyekX[i] });
                }
                if(i == reszEredmenyekY.Count-1)
                {
                    List<int> ideiglenesReszeredmenyX = new List<int>(); //Ez csak a rész X értékek
                    for (int j = 0; j < reszeredmeny.Count; j++)
                    {
                        ideiglenesReszeredmenyX.Add(reszeredmeny[j][1]);
                    }
                    eredmenyek.Add(new int[] { Math.Abs(reszeredmeny.First().First() + reszeredmeny.Last().First()) / 2, ideiglenesReszeredmenyX.Min() });
                    reszeredmeny.Clear();
                }
            }
            return eredmenyek;
        }
        public static List<int[]> YellowYValues(Image input, int kezdoY, int posX)
        {
            System.Drawing.Bitmap kep = (Bitmap)input;
            List<int[]> eredmenyek = new List<int[]>();
            List<int> reszEredmenyekX = new List<int>();
            List<int> reszEredmenyekY = new List<int>();
            //int min = posX;
            for (int j = kezdoY; j < kep.Height; j++)
            {
                for (int i = 0; i < posX; i++)
                {
                    Color pixel = kep.GetPixel(i, j);
                    if (pixel.R > 245 && pixel.G > 160 && pixel.B > 35 && pixel.B < 55 && pixel.G < 180)
                    {
                        reszEredmenyekX.Add(i);
                        reszEredmenyekY.Add(j);
                        /*
                        if (i < min)
                        {
                            min = i;
                        }*/
                        break;
                    }
                }
            }
            List<int[]> reszeredmeny = new List<int[]>();
            for (int i = 1; i < reszEredmenyekY.Count; i++)
            {
                if (Math.Abs(reszEredmenyekY[i] - reszEredmenyekY[i - 1]) > 2)
                {
                    List<int> ideiglenesReszeredmenyX = new List<int>(); //Ez csak a rész X értékek
                    for (int j = 0; j < reszeredmeny.Count; j++)
                    {
                        ideiglenesReszeredmenyX.Add(reszeredmeny[j][1]);
                    }
                    eredmenyek.Add(new int[] { Math.Abs(reszeredmeny.First().First() + reszeredmeny.Last().First()) / 2, ideiglenesReszeredmenyX.Min()});
                    reszeredmeny.Clear();
                }
                else
                {
                    reszeredmeny.Add(new int[] { reszEredmenyekY[i], reszEredmenyekX[i] });
                }
                if (i == reszEredmenyekY.Count - 1)
                {
                    List<int> ideiglenesReszeredmenyX = new List<int>(); //Ez csak a rész X értékek
                    for (int j = 0; j < reszeredmeny.Count; j++)
                    {
                        ideiglenesReszeredmenyX.Add(reszeredmeny[j][1]);
                    }
                    eredmenyek.Add(new int[] { Math.Abs(reszeredmeny.First().First() + reszeredmeny.Last().First()) / 2, ideiglenesReszeredmenyX.Min() });
                    reszeredmeny.Clear();
                }
            }
            return eredmenyek;
        }
        public static int KezdoYKereses(Image input)
        {
            string _file = file;
            System.Drawing.Bitmap kep = (Bitmap)input;
            List<int> posBlack = new List<int>();
            List<int> posBlackLines = new List<int>();
            int keretSzele = 0;
            for (int i = 0; i < 1000; i++)
            {
                Color pixel = kep.GetPixel(i, 1000);
                if(pixel.R <10 && pixel.G <10 && pixel.B < 10)
                {
                    keretSzele = i;
                    break;
                }
            }
            for(int i = 0; i < 4750; i++) //régi határ kep.Height
            {
                Color pixel = kep.GetPixel(keretSzele + 20, i);
                if (pixel.R < 5 && pixel.G < 5 && pixel.B < 5)
                {
                    posBlack.Add(i);   
                }
            }
            for (int i = 0; i < posBlack.Count; i++)
            {
                if(i==0)
                {
                    posBlackLines.Add(posBlack[0]);
                }
                else
                {
                    if(Math.Abs(posBlack[i-1]-posBlack[i])>1)
                    {
                        posBlackLines.Add(posBlack[i]);
                    }
                }
            }
            List<int> eredmenyLista = new List<int>();
            for (int i = 1; i < posBlackLines.Count; i++)
            {
                if(Math.Abs(posBlackLines[i]-posBlackLines[i-1])>140 && Math.Abs(posBlackLines[i] - posBlackLines[i - 1]) < 180)
                {
                    eredmenyLista.Add(posBlackLines[i - 1]);
                }
            }
            return eredmenyLista.Last();
        }
        public static int KezdoXKereses(Image input, int kezdoY)
        {
            System.Drawing.Bitmap kep = (Bitmap)input;
            int eredmeny = kep.Height;
            int pozicio = 0;
            for (int j = 600; j < 1200; j++)
            {
                for (int i = kezdoY; i < kep.Height; i++)
                {
                    int aktualisEredmeny = 0;
                    Color pixel = kep.GetPixel(j, i);
                    if (pixel.R < 185 && pixel.G < 10 && pixel.B < 10 && pixel.R > 160) //Piros keresés
                    {
                        aktualisEredmeny = i;
                    }
                    if (pixel.R > 245 && pixel.G > 160 && pixel.B > 35 && pixel.B < 55 && pixel.G < 180) //Sárga keresés
                    {
                        aktualisEredmeny = i;
                    }
                    if(aktualisEredmeny != 0)
                    {
                        if(i < eredmeny)
                        {
                            eredmeny = i;
                            pozicio = j;
                        }
                        break;
                    }
                    //kep.SetPixel(j, i, Color.Red);
                }
            }
            //kep.Save(@"C:\Users\nikha\Desktop\LotoAdatbazisSolution\LotoAdatbazis\bin\Debug\Adatbázis\COMET\SZÓSZRENDSZER\T027\v201\teszt.jpg");
            return pozicio;
        }
        public static void CropAnImage(Bitmap input, Rectangle cropRect, string name)
        {
            int[] ujnegyzet = new int[4];
            for (int i = cropRect.X + 30; i > cropRect.X; i--) //X ben vágok
            {
                Color pixel = input.GetPixel(i, cropRect.Y+30);
                if (pixel.R < 220 && pixel.G < 220 && pixel.B < 220)
                {
                    ujnegyzet[0] = i; //x0
                    break;
                }
            }
            if (ujnegyzet[0] == 0)
            {
                ujnegyzet[0] = cropRect.X;
            }
            for (int i = cropRect.Y + 30; i > cropRect.Y; i--) //Y ben vágok
            {
                Color pixel = input.GetPixel(cropRect.X + 30, i);
                if (pixel.R < 220 && pixel.G < 220 && pixel.B < 220)
                {
                    ujnegyzet[1] = i; //y0
                    break;
                }
            }
            if (ujnegyzet[1] == 0)
            {
                ujnegyzet[1] = cropRect.Y;
            }
            for (int i = cropRect.X + cropRect.Width-30; i < cropRect.X + cropRect.Width; i++) //X ben vágok
            {
                Color pixel = input.GetPixel(i, cropRect.Y + cropRect.Height - 30);
                if (pixel.R < 220 && pixel.G < 220 && pixel.B < 220)
                {
                    ujnegyzet[2] = i; //x1
                    break;
                }
            }
            if (ujnegyzet[2] == 0)
            {
                ujnegyzet[2] = cropRect.X + cropRect.Width;
            }
            for (int i = cropRect.Y + cropRect.Height - 30; i < cropRect.Y + cropRect.Height; i++) //Y ben vágok
            {
                Color pixel = input.GetPixel(cropRect.X + cropRect.Width - 30, i);
                if (pixel.R < 220 && pixel.G < 220 && pixel.B < 220)
                {
                    ujnegyzet[3] = i; //y1
                    break;
                }
            }
            if (ujnegyzet[3]== 0)
            {
                ujnegyzet[3] = cropRect.Y + cropRect.Height;
            }
            Rectangle ujNegyzet = new Rectangle(ujnegyzet[0]+1, ujnegyzet[1]+1, ujnegyzet[2]-ujnegyzet[0]-1, ujnegyzet[3]-ujnegyzet[1]-1);

            Bitmap target = new Bitmap(ujNegyzet.Width, ujNegyzet.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(input, new Rectangle(0, 0, target.Width, target.Height),
                                 ujNegyzet,
                                 GraphicsUnit.Pixel);
            }
            target.Save(name);
        }
        public static void FindArea(Image input, int Ymax)
        {
            System.Drawing.Bitmap kep = (Bitmap)input;
            List<int> Ylist = new List<int>();
            List<int> Xlist = new List<int>();
            for (int j = 0; j < 4000; j=j+100) //Szélesség X
            {
                for (int i = 650; i < Ymax; i=i+10) //Magasság Y
                {
                    Color pixel = kep.GetPixel(j, i);
                    if (pixel.R < 185 && pixel.G < 10 && pixel.B < 10 && pixel.R > 160) //Piros keresés
                    {
                        Ylist.Add(i);
                        Xlist.Add(j);
                    }
                    if (pixel.R > 245 && pixel.G > 160 && pixel.B > 35 && pixel.B < 55 && pixel.G < 180) //Sárga keresés
                    {
                        Ylist.Add(i);
                        Xlist.Add(j);
                    }
                    kep.SetPixel(j, i, Color.Red);
                }
            }
            kep.Save(Path.GetDirectoryName(pathGlobal) + "\\" + Index + "zoom_uj" + ".jpg");
            Rectangle area = new Rectangle(new Point(Xlist.Min()-100, Ylist.Min()-100), new Size(Xlist.Max() - Xlist.Min()+200, Ylist.Max() - Ylist.Min()+200));
        }
        private static void JelekMenteseTeruletrol(Image input, Rectangle area)
        {
            
        }
        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
        public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
            }
        }
    }
}
