using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    internal class InputTagDisplay
    {
        public void Input()
        {
            FileStream fileStream = new FileStream(@"F:\NC4\mydata.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            while(reader.Peek() > 0)
            {
                string tag = reader.ReadLine();
                if(tag.Contains("<input"))
                {
                    Console.WriteLine(tag);
                }
            }
            Console.ReadLine();
            reader.Close();
            fileStream.Close();
        }
    }
}
