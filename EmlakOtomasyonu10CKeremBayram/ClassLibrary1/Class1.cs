﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public class DosyaIslemleri
        {
            public static void LogKayit(Exception exception)
            {
                if (!File.Exists("../../log.txt"))
                {
                    File.Create("../../log.txt");
                }
                FileStream fs = new FileStream("../../log.txt", FileMode.Append, FileAccess.Read);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(exception.ToString());
                sw.Close();
                fs.Close();
            }
        }
    }
}
