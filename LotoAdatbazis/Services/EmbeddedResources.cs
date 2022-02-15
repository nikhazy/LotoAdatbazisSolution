using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LotoAdatbazis.Services
{
    class EmbeddedResources
    {
        public static Bitmap Hatter2;
        public static Bitmap Hatter;
        public static Bitmap Loading;
        public static Bitmap LotoGif;
        public static Bitmap MegjelenGif;
        public static Bitmap NikkoGif;
        public static FontFamily LotoFont;

        public static void Init()
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            string[] names = ass.GetManifestResourceNames();

            Stream stream = ass.GetManifestResourceStream("LotoAdatbazis.Files.hatter2.jpg");
            Hatter2 = new Bitmap(stream);

            stream = ass.GetManifestResourceStream("LotoAdatbazis.Files.hatter.jpg");
            Hatter = new Bitmap(stream);

            stream = ass.GetManifestResourceStream("LotoAdatbazis.Files.loading.gif");
            Loading = new Bitmap(stream);

            stream = ass.GetManifestResourceStream("LotoAdatbazis.Files.loto_gif.gif");
            LotoGif = new Bitmap(stream);

            stream = ass.GetManifestResourceStream("LotoAdatbazis.Files.megjelen_gif.gif");
            MegjelenGif = new Bitmap(stream);

            stream = ass.GetManifestResourceStream("LotoAdatbazis.Files.nikko_gif.gif");
            NikkoGif = new Bitmap(stream);

            LotoFont = LoadFontFamily();
        }

        private static FontFamily LoadFontFamily()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile(Directory.GetCurrentDirectory() + "\\Adat\\GEInspRg.TTF");
            string resource = "LotoAdatbazis.Files.GEInspRg.TTF";
            Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
            System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
            pfc.AddMemoryFont(data, (int)fontStream.Length);
            fontStream.Close();
            Marshal.FreeCoTaskMem(data);

            return pfc.Families[0];
        }
    }
}
