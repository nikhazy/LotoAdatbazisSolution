using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoAdatbazis
{
    public class JelekPDFre
    {
        public string FileName { get; set; }
        public List<string> Jelek = new List<string>();
        private static int meret;
        public static int Meret
        {
            get { return meret; }
            set
            {
                meret = value;
                switch(value)
                {
                    case 1:
                        EgysegPerSor = 20;
                        break;
                    case 2:
                        EgysegPerSor = 10;
                        break;
                    case 3:
                        EgysegPerSor = 6;
                        break;
                    case 4:
                        EgysegPerSor = 5;
                        break;
                    case 5:
                        EgysegPerSor = 4;
                        break;
                }
            }
        }
        public static int EgysegPerSor { get; set; }
        //1,2,3,4,5 cm

        //Széltében
        //10 mm esből 1 sorban 20 fér el --200
        //20 mm esből egy sorban 10 fér el --200
        //30 mm esből egy sorban 6 fér el --180
        //40 mm esből egy sorban 5 fér el --200
        //50 mm esből egy sorban 4 fér el --200
        //Hosszában
        //10 - 25db -250
        //20 - 12db -240
        //30 - 8db -240
        //40 - 6db -240
        //50 - 5db -250

        public JelekPDFre(string fileName)
        {
            FileName = fileName;
        }
        public int SorokSzama()
        {
            int egySorban = 0;
            switch (Meret)
            {
                case 1:
                    egySorban = 20;
                    break;
                case 2:
                    egySorban = 10;
                    break;
                case 3:
                    egySorban = 6;
                    break;
                case 4:
                    egySorban = 5;
                    break;
                case 5:
                    egySorban = 4;
                    break;
            }
            double ideiglenes = Math.Ceiling((double)Jelek.Count / egySorban);
            int eredmeny = (int)ideiglenes;
            return eredmeny;
        }
        public static int SorPerOldalMethod()
        {
            int egySorban = 0;
            switch (Meret)
            {
                case 1:
                    egySorban = 25;
                    break;
                case 2:
                    egySorban = 12;
                    break;
                case 3:
                    egySorban = 8;
                    break;
                case 4:
                    egySorban = 6;
                    break;
                case 5:
                    egySorban = 5;
                    break;
            }
            return egySorban;
        }
    }
}
