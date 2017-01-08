using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interfaces
{
    internal interface ITextManipulation
    {
        void ConsoleWrite(string text);
        void ConsoleWriteLine(string text);
        string ConsoleRead();
        string ConsoleReadLine();
    }
}
