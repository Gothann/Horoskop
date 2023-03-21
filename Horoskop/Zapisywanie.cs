using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace Horoskop
{
    internal class Zapisywanie
    {
        public static void ZapiszDoPliku(DateTime data) {
            string content = UstalZnak.GetDaily(data);
            string path= "C:\\Incel\\DziennyHoroskop.txt";
            if (!File.Exists(path)) File.Create(path);
            File.AppendAllText(path,content);
            MessageBox.Show("gejuch");
            
        }
    }
}
