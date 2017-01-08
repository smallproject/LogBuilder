using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1.Repositories
{
    internal class InputOutputTextManipulation:IInputOutputTextManipulation
    {

        public void CreateLogTextByFilename(StringBuilder text, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(text);
            }
        }

        public void CreateLogTextByPath(StringBuilder text, string path)
        {
            using (StreamWriter sw = new StreamWriter($@"{path}"))
            {
                sw.WriteLine($@"{text}");
            }
        }




        private StringBuilder Introduction()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(@"Hello and Welcome to string builder program");
            builder.AppendLine(@"");
            builder.AppendLine(DateTime.Now.ToString());

            return builder;
        }




    }
}
