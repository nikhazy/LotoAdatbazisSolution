using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.ExceptionServices;
using System.IO;

namespace LotoAdatbazis
{
    class FindImage
    {
        public static Bitmap kep;
        public static List<JelTerkeprol> jelek = new List<JelTerkeprol>();
        public static void Search(Image input, int Ymax)
        {
            if(File.Exists(Directory.GetCurrentDirectory() + "\\Adat\\log.txt"))
            {
                File.Delete(Directory.GetCurrentDirectory() + "\\Adat\\log.txt");
            }
            File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", DateTime.Now.ToString()+"\n");
            kep = (Bitmap)input;
            jelek.Clear();
            for (int j = 0; j < 4000; j = j + 100) //Szélesség X
            {
                for (int i = 650; i < Ymax; i = i + 10) //Magasság Y
                {
                    if(!OccupiedArea(j,i))
                    {
                        Color pixel = kep.GetPixel(j, i);
                        if (pixel.R < 185 && pixel.G < 10 && pixel.B < 10 && pixel.R > 160) //Piros keresés
                        {
                            JelTerkeprol found = GoAround(j, i);
                            bool match = false;
                            for (int k = 0; k < jelek.Count; k++)
                            {
                                if (jelek[k].Area == found.Area)
                                {
                                    match = true;
                                }
                            }
                            if (!match)
                            {
                                jelek.Add(found);
                                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Jel értékei: Area(x,y,w,h):" + found.Area.X + "," + found.Area.Y + "," + found.Area.Width + "," + found.Area.Height + ", points:" + found.Points.Count + "\n");
                            }
                        }
                        if (pixel.R > 245 && pixel.G > 160 && pixel.B > 35 && pixel.B < 55 && pixel.G < 180) //Sárga keresés //pixel.R > 245 && pixel.G > 160 && pixel.B > 35 && pixel.B < 55 && pixel.G < 180
                        {
                            JelTerkeprol found = GoAround(j, i);
                            bool match = false;
                            for (int k = 0; k < jelek.Count; k++)
                            {
                                if (jelek[k].Area == found.Area)
                                {
                                    match = true;
                                }
                            }
                            if (!match && found.Points.Count > 500)
                            {
                                jelek.Add(found);
                                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Jel értékei: Area(x,y,w,h):" + found.Area.X + "," + found.Area.Y + "," + found.Area.Width + "," + found.Area.Height + ", points:" + found.Points.Count + "\n");
                            }
                        }
                        //kep.SetPixel(j, i, Color.Red);
                    }
                }
            }

            //kep.Save(Path.GetDirectoryName(SpireConvert.pathGlobal) + "\\" + SpireConvert.Index + "zoom_uj" + ".jpg");
            SaveSignImage();
        }
        private static void SaveSignImage()
        {
            Bitmap signImage = new Bitmap(100,100);
            int rahagyas = 36; //két oldalt ennyit hagyok az alakzatra
            for (int i = 0; i < jelek.Count; i++)
            {
                try
                {
                    if (jelek[i].Area.Width > 150 && jelek[i].Area.Height > 150)
                    {
                        //Ellenőrizzük az alakzatot, hogy megvan-e teljesen
                        int maxY = 0;
                        int maxX1 = 5000;
                        int maxX2 = 0;
                        int hossz = 0;

                        bool piros = false;

                        bool teljes = false; //ezt vissza true-ra

                        for (int j = 0; j < jelek[i].Points.Count; j++)
                        {

                            int y = jelek[i].Points[j].Y;
                            List<int> sorvegek = new List<int>();
                            for (int k = 0; k < jelek[i].Points.Count; k++)
                            {
                                if (jelek[i].Points[k].Y == y)
                                {
                                    sorvegek.Add(jelek[i].Points[k].X);
                                }
                            }
                            if (sorvegek.Min() < maxX1 && sorvegek.Max() > maxX2)
                            {
                                maxY = y;
                                maxX1 = sorvegek.Min();
                                maxX2 = sorvegek.Max();
                            }
                        }
                        hossz = Math.Abs(maxX2 - maxX1);
                        if (hossz < 230)
                        {
                            piros = true;
                        }
                        if (Math.Abs(Math.Abs(jelek[i].Yvalues.Max() - maxY) - Math.Abs(jelek[i].Yvalues.Min() - maxY)) > 3 && !piros)
                        {
                            teljes = false;
                        }
                        if (teljes)
                        {
                            signImage = new Bitmap(jelek[i].Area.Width + rahagyas, jelek[i].Area.Height + rahagyas); //32 volt rahagyas helyen
                        }
                        else
                        {
                            signImage = new Bitmap(hossz + rahagyas, hossz + rahagyas); //32 volt rahagyas helyen
                        }
                        //Keret rajzolás
                        if (jelek[i].Area.Width > 230) //polygon rajzoolás sárgának
                        {

                            Point[] pontok = new Point[] { new Point((signImage.Width) / 2, 2), new Point(signImage.Width - 2, (signImage.Height) / 2), new Point((signImage.Width) / 2, signImage.Height - 2), new Point(2, (signImage.Height) / 2) }; //Itt eltoltam a kerettől kicsit

                            using (Graphics gr = Graphics.FromImage(signImage))
                            {
                                gr.SmoothingMode = SmoothingMode.AntiAlias;
                                gr.FillPolygon(Brushes.Black, pontok);
                            }
                        }
                        else //Kör rajzolás pirosnak
                        {
                            Rectangle rect = new Rectangle(new Point(10, 10), new Size(jelek[i].Area.Width + rahagyas - 20, jelek[i].Area.Height + rahagyas - 20)); //0,0,+32,+32 volt
                            using (Graphics gr = Graphics.FromImage(signImage))
                            {
                                gr.SmoothingMode = SmoothingMode.AntiAlias;
                                gr.FillEllipse(Brushes.Black, rect);
                            }
                        }
                        //Alakzat kirajzolása
                        if (teljes || piros)
                        {
                            try
                            {
                                for (int j = 0; j < jelek[i].Points.Count; j++)
                                {

                                    int y = jelek[i].Points[j].Y;
                                    List<int> sorvegek = new List<int>();
                                    for (int k = 0; k < jelek[i].Points.Count; k++)
                                    {
                                        if (jelek[i].Points[k].Y == y)
                                        {
                                            sorvegek.Add(jelek[i].Points[k].X);
                                        }
                                    }
                                    for (int k = sorvegek.Min(); k <= sorvegek.Max(); k++)
                                    {
                                        Color pixel = kep.GetPixel(k, y);
                                        try
                                        {
                                            signImage.SetPixel(k - jelek[i].Area.X + rahagyas / 2, y - jelek[i].Area.Y + rahagyas / 2, pixel); //12 lett 16 ról //Valszeg itt van a hiba //Utoljára 16 volt
                                        }
                                        catch
                                        {
                                            File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Hibás pixel:" + k + "," + y);
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Hibás alakzat:" + i);
                            }
                        }
                        else
                        {
                            Rectangle cropRect = new Rectangle(new Point(maxX1 - rahagyas / 2, maxY - hossz / 2 - rahagyas / 2), new Size(hossz + rahagyas+10, hossz + rahagyas+10)); //16,16,+32,+32
                            signImage = cropImage(kep, cropRect);

                            //Letisztítom a tábla körüli dolgokat
                            try
                            {
                                for (int k = 0; k < cropRect.Height / 2; k++)//Bal felső sarkot tisztítja
                                {
                                    for (int l = 0; l < k; l++)
                                    {
                                        signImage.SetPixel(l, cropRect.Height / 2 - k - 1, Color.White);
                                    }
                                }
                            }
                            catch
                            {
                                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Első törlésnél" + i + "\n");
                            }
                            try
                            {

                                for (int k = 0; k < cropRect.Height / 2; k++)//Jobb felső sarkot tisztítja
                                {
                                    for (int l = 0; l < k; l++)
                                    {
                                        signImage.SetPixel(cropRect.Width - 1 - l, cropRect.Height / 2 - k - 1, Color.White);
                                    }
                                }
                            }
                            catch
                            {
                                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Második törlésnél" + i + "\n");
                            }
                            try
                            {

                                for (int k = 0; k < cropRect.Height / 2; k++)//Bal alsó sarkot tisztítja
                                {
                                    for (int l = 0; l < k; l++)
                                    {
                                        signImage.SetPixel(l, cropRect.Height / 2 + k + 1, Color.White);
                                    }
                                }
                            }
                            catch
                            {
                                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Harmadik törlésnél" + i + "\n");
                            }
                            try
                            {
                                for (int k = 0; k < cropRect.Height / 2; k++)//Jobb alsó sarkot tisztítja
                                {
                                    for (int l = 0; l < k; l++)
                                    {
                                        signImage.SetPixel(cropRect.Width - 1 - l, cropRect.Height / 2 + k + 1, Color.White);
                                    }
                                }
                            }
                            catch
                            {
                                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Negyedik törlésnél" + i + "\n");
                            }
                        }

                        //Jel mentése képként
                        if (!Directory.Exists(Path.GetDirectoryName(SpireConvert.pathGlobal) + "\\Jelek"))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(SpireConvert.pathGlobal) + "\\Jelek");
                        }
                        signImage.Save(Path.GetDirectoryName(SpireConvert.pathGlobal) + "\\Jelek\\" + i + ".jpg");
                    }
                }
                catch (Exception e)
                {
                    File.AppendAllText(Directory.GetCurrentDirectory() + "\\Adat\\log.txt", "Hibás alakzat:" + i + e + "\n");
                }
            }
        }
        private static Bitmap cropImage(Bitmap bmpImage, Rectangle cropArea)
        {
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return bmpCrop;
        }
        private static bool OccupiedArea(int x, int y)
        {
            bool result = false;
            for (int i = 0; i < jelek.Count; i++)
            {
                if(jelek[i].Area.Contains(new Point(x, y)))
                {
                    result = true;
                }
            }
            return result;
        }
        public static JelTerkeprol GoAround(int x, int y)
        {
            JelTerkeprol talaltJel = new JelTerkeprol();
            int firstY = 0;
            for(int i = y-10; i <= y; i++) //Megkeresem az első pontját az alakzatnak.
            {
                Color pixel = kep.GetPixel(x, i);
                if (pixel.R < 185 && pixel.G < 10 && pixel.B < 10 && pixel.R > 100) //Piros keresés
                {
                    firstY = i;
                    talaltJel.Xvalues.Add(x);
                    talaltJel.Yvalues.Add(i);
                    talaltJel.Points.Add(new Point(x, i));
                    break;
                }
                if (pixel.R > 50 && pixel.G > 30 && pixel.B > 5) //Sárga keresés
                {
                    firstY = i;
                    talaltJel.Xvalues.Add(x);
                    talaltJel.Yvalues.Add(i);
                    talaltJel.Points.Add(new Point(x, i));
                    break;
                }
            }
            bool startPosAgain = false;
            int steps = 0;
            while(!startPosAgain)
            {
                steps++;
                if(steps == 1)
                {
                    talaltJel.Points.Add(NextPoint(talaltJel.Points.Last(), 1));
                    talaltJel.Xvalues.Add(talaltJel.Points.Last().X);
                    talaltJel.Yvalues.Add(talaltJel.Points.Last().Y);
                    //kep.SetPixel(talaltJel.Points.Last().X, talaltJel.Points.Last().Y, Color.Green);
                }
                else
                {
                    Point next = NextPoint(talaltJel.Points.Last(), DirFromPoint(talaltJel.Points.Last(), talaltJel.Points[talaltJel.Points.Count - 2]));
                    if(!talaltJel.Points.Contains(next))
                    {
                        talaltJel.Points.Add(next);
                        talaltJel.Xvalues.Add(talaltJel.Points.Last().X);
                        talaltJel.Yvalues.Add(talaltJel.Points.Last().Y);
                        //kep.SetPixel(talaltJel.Points.Last().X, talaltJel.Points.Last().Y, Color.Green);
                    }
                    else
                    {
                        startPosAgain = true;
                    }
                }
                if(steps > 10000) //timeout
                {
                    startPosAgain = true;
                }
            }
            talaltJel.CreateArea();
            //kep.Save(Path.GetDirectoryName(SpireConvert.pathGlobal) + "\\" + SpireConvert.Index + "zoom_uj_teszt.jpg");
            return talaltJel;

        }
        private static Point NextPoint(Point lastPoint, int first)
        {
            Color[] colorsAround = new Color[8]; //Bal felső a 0, és megy körbe
            Point next = lastPoint;
            colorsAround[0] = kep.GetPixel(lastPoint.X - 1, lastPoint.Y - 1);
            colorsAround[1] = kep.GetPixel(lastPoint.X, lastPoint.Y - 1);
            colorsAround[2] = kep.GetPixel(lastPoint.X + 1, lastPoint.Y - 1);
            colorsAround[3] = kep.GetPixel(lastPoint.X + 1, lastPoint.Y);
            colorsAround[4] = kep.GetPixel(lastPoint.X + 1, lastPoint.Y + 1);
            colorsAround[5] = kep.GetPixel(lastPoint.X, lastPoint.Y + 1);
            colorsAround[6] = kep.GetPixel(lastPoint.X - 1, lastPoint.Y + 1);
            colorsAround[7] = kep.GetPixel(lastPoint.X - 1, lastPoint.Y);
            int current = first;
            for (int i = 0; i < 8; i++)
            {
                if(current < 8)
                {
                    if (colorsAround[current].R < 185 && colorsAround[current].G < 10 && colorsAround[current].B < 10 && colorsAround[current].R > 100) //Piros keresés
                    {
                        next = PointFromDir(lastPoint, current);
                        break;
                    }
                    if(colorsAround[current].R > 50 && colorsAround[current].G > 30 && colorsAround[current].B > 5) //Sárga keresés
                    {
                        next = PointFromDir(lastPoint, current);
                        break;
                    }
                }
                else
                {
                    current = 0;
                    if (colorsAround[current].R < 185 && colorsAround[current].G < 10 && colorsAround[current].B < 10 && colorsAround[current].R > 100) //Piros keresés
                    {
                        next = PointFromDir(lastPoint, current);
                        break;
                    }
                    if (colorsAround[current].R > 50 && colorsAround[current].G > 30 && colorsAround[current].B > 5) //Sárga keresés
                    {
                        next = PointFromDir(lastPoint, current);
                        break;
                    }
                }
                current++;
            }
            return next;
        }
        private static Point PointFromDir(Point lastPoint, int dir)
        {
            switch (dir)
            {
                case 0:
                    return new Point(lastPoint.X - 1, lastPoint.Y - 1);
                case 1:
                    return new Point(lastPoint.X, lastPoint.Y - 1);
                case 2:
                    return new Point(lastPoint.X + 1, lastPoint.Y - 1);
                case 3:
                    return new Point(lastPoint.X + 1, lastPoint.Y);
                case 4:
                    return new Point(lastPoint.X + 1, lastPoint.Y + 1);
                case 5:
                    return new Point(lastPoint.X, lastPoint.Y + 1);
                case 6:
                    return new Point(lastPoint.X - 1, lastPoint.Y + 1);
                case 7:
                    return new Point(lastPoint.X - 1, lastPoint.Y);
                default:
                    return lastPoint;
            }
        }
        private static int DirFromPoint(Point curr, Point last)
        {
            int deltaX = curr.X - last.X;
            int deltaY = curr.Y - last.Y;
            if (deltaX == 1 && deltaY == 1)
            {
                return 1;
            }
            else if (deltaX == 0 && deltaY == 1)
            {
                return 2;
            }
            else if (deltaX == -1 && deltaY == 1)
            {
                return 3;
            }
            else if (deltaX == -1 && deltaY == 0)
            {
                return 4;
            }
            else if (deltaX == -1 && deltaY == -1)
            {
                return 5;
            }
            else if (deltaX == 0 && deltaY == -1)
            {
                return 6;
            }
            else if (deltaX == 1 && deltaY == -1)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }
    }
}
