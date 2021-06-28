using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Витрина
{
    public class Log
    {
        public static void Logger(string text)
        {
			// казываем путь для записи
            string path = "C:\\loggirovanie.txt";
            File.AppendAllText(path, text + " " + DateTime.Now + "\n");

        }
    }
}