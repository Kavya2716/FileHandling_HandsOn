using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    internal class FileHandling
    {
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"F:\NC4\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("All Details:\n");
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\t\tNetwork");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            while (reader.Peek()>0)
            {
                var netid = reader.ReadLine();
                string[] str = netid.Split(':');
                int id = Convert.ToInt32(str[1]);

                var netsource = reader.ReadLine();
                string[] ns = netsource.Split(':');
                int source = Convert.ToInt32(ns[1]);

                var netdest = reader.ReadLine();
                string[] nd = netdest.Split(':');
                int dest = Convert.ToInt32(nd[1]);

                var netdate = reader.ReadLine();
                string[] d = netdate.Split(' ');
                string date = d[0];
                string[] d1 = date.Split(':');
                string date1 = d1[1];
                string time = d[1];
                string time2 = d[2];

                var netstatus = reader.ReadLine();
                string[] s = netstatus.Split(':');
                string status = s[1];

                var net = reader.ReadLine();
                string[] n = net.Split(':');
                string network = n[1];
                
                
                Console.WriteLine(id+"\t"+source+"\t"+dest+"\t"+date1+"\t"+time+"\t"+time2+"\t"+status+ "\t\t" + network);
                reader.ReadLine();
            }
            fileStream.Close();
        }
        public void Success()
        {
            FileStream fileStream = new FileStream(@"F:\NC4\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("\nSuccess Status:\n");
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\t\tNetwork");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            while (reader.Peek() > 0)
            {
                var netid = reader.ReadLine();
                string[] str = netid.Split(':');
                int id = Convert.ToInt32(str[1]);

                var netsource = reader.ReadLine();
                string[] ns = netsource.Split(':');
                int source = Convert.ToInt32(ns[1]);

                var netdest = reader.ReadLine();
                string[] nd = netdest.Split(':');
                int dest = Convert.ToInt32(nd[1]);

                var netdate = reader.ReadLine();
                string[] d = netdate.Split(' ');
                string date = d[0];
                string[] d1 = date.Split(':');
                string date1 = d1[1];
                string time = d[1];
                string time2 = d[2];

                var netstatus = reader.ReadLine();
                string[] s = netstatus.Split(':');
                string status = s[1];

                var net = reader.ReadLine();
                string[] n = net.Split(':');
                string network = n[1];
                
                if(status.Equals("Success"))
                {
                    Console.WriteLine(id + "\t" + source + "\t" + dest + "\t" + date1 + "\t" + time + "\t" + time2 + "\t" + status + "\t\t" + network);
                }
               
                reader.ReadLine();   
            }
            fileStream.Close();
        }
        public void Failed()
        {
            FileStream fileStream = new FileStream(@"F:\NC4\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("\nFailed Status:\n");
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\t\tNetwork");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            while (reader.Peek() > 0)
            {
                var netid = reader.ReadLine();
                string[] str = netid.Split(':');
                int id = Convert.ToInt32(str[1]);

                var netsource = reader.ReadLine();
                string[] ns = netsource.Split(':');
                int source = Convert.ToInt32(ns[1]);

                var netdest = reader.ReadLine();
                string[] nd = netdest.Split(':');
                int dest = Convert.ToInt32(nd[1]);

                var netdate = reader.ReadLine();
                string[] d = netdate.Split(' ');
                string date = d[0];
                string[] d1 = date.Split(':');
                string date1 = d1[1];
                string time = d[1];
                string time2 = d[2];

                var netstatus = reader.ReadLine();
                string[] s = netstatus.Split(':');
                string status = s[1];

                var net = reader.ReadLine();
                string[] n = net.Split(':');
                string network = n[1];

                if (status.Equals("Failed"))
                {
                    Console.WriteLine(id + "\t" + source + "\t" + dest + "\t" + date1 + "\t" + time + "\t" + time2 + "\t" + status + "\t\t" + network);
                }

                reader.ReadLine();
            }
            fileStream.Close();
        }
        public void Missed()
        {
            FileStream fileStream = new FileStream(@"F:\NC4\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("\nMissed Status:\n");
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\t\tNetwork");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            while (reader.Peek() > 0)
            {
                var netid = reader.ReadLine();
                string[] str = netid.Split(':');
                int id = Convert.ToInt32(str[1]);

                var netsource = reader.ReadLine();
                string[] ns = netsource.Split(':');
                int source = Convert.ToInt32(ns[1]);

                var netdest = reader.ReadLine();
                string[] nd = netdest.Split(':');
                int dest = Convert.ToInt32(nd[1]);

                var netdate = reader.ReadLine();
                string[] d = netdate.Split(' ');
                string date = d[0];
                string[] d1 = date.Split(':');
                string date1 = d1[1];
                string time = d[1];
                string time2 = d[2];

                var netstatus = reader.ReadLine();
                string[] s = netstatus.Split(':');
                string status = s[1];

                var net = reader.ReadLine();
                string[] n = net.Split(':');
                string network = n[1];

                if (status.Equals("Missed"))
                {
                    Console.WriteLine(id + "\t" + source + "\t" + dest + "\t" + date1 + "\t" + time + "\t" + time2 + "\t" + status + "\t\t" + network);
                }
                reader.ReadLine();
            }
            fileStream.Close();
        }
        public void Dialed()
        {
            FileStream fileStream = new FileStream(@"F:\NC4\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("\nDialed Status:\n");
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\t\tNetwork");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            while (reader.Peek() > 0)
            {
                var netid = reader.ReadLine();
                string[] str = netid.Split(':');
                int id = Convert.ToInt32(str[1]);

                var netsource = reader.ReadLine();
                string[] ns = netsource.Split(':');
                int source = Convert.ToInt32(ns[1]);

                var netdest = reader.ReadLine();
                string[] nd = netdest.Split(':');
                int dest = Convert.ToInt32(nd[1]);

                var netdate = reader.ReadLine();
                string[] d = netdate.Split(' ');
                string date = d[0];
                string[] d1 = date.Split(':');
                string date1 = d1[1];
                string time = d[1];
                string time2 = d[2];

                var netstatus = reader.ReadLine();
                string[] s = netstatus.Split(':');
                string status = s[1];

                var net = reader.ReadLine();
                string[] n = net.Split(':');
                string network = n[1];

                if (status.Equals("Dialled"))
                {
                    Console.WriteLine(id + "\t" + source + "\t" + dest + "\t" + date1 + "\t" + time + "\t" + time2 + "\t" + status + "\t\t" + network);
                }
                reader.ReadLine();
            }
            fileStream.Close();
        }
    }
}
