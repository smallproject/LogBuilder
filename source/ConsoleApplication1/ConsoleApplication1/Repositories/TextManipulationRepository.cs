using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1.Repositories
{
    internal class TextManipulationRepository : ITextManipulation
    {
        public void ConsoleWrite(string text)
        {
            throw new NotImplementedException();
        }

        public void ConsoleWriteLine(string text)
        {
            Console.WriteLine($@"{text}");
        }

        public string ConsoleRead()
        {
            throw new NotImplementedException();
        }

        public string ConsoleReadLine()
        {
            string text = Console.ReadLine();

            return $@"{text}";
        }
    }
}
