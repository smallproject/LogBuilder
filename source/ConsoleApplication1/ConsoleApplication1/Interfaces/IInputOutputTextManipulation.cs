using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interfaces
{
    interface IInputOutputTextManipulation
    {
        void CreateLogTextByFilename(StringBuilder text, string filename);
        void CreateLogTextByPath(StringBuilder text, string path);
    }
}
