using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandling f = new FileHandling();
            f.ReadFile();
            f.Success();
            f.Failed();
            f.Missed();
            f.Dialed();
            Console.ReadLine();
        }
    }
}
