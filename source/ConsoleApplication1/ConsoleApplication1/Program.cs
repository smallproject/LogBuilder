using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Interfaces;
using ConsoleApplication1.Repositories;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            appendLine("Hello and welcome to string builder program");
            appendLine("");

            appendLine(DateTime.Now.ToString());

            string filename = @"log.txt";
            IInputOutputTextManipulation IOText = new InputOutputTextManipulation();

            IOText.CreateLogTextByFilename(textBuilder, filename);
        }

        private static StringBuilder textBuilder = new StringBuilder();

        private static void appendLine(string text)
        {
            textBuilder.AppendLine($@"{text}");
        }

        
    }
}
