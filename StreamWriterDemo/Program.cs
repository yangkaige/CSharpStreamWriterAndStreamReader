using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("readme.txt"))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine(i);
                }
            }
            Console.WriteLine("写入成功！！");
            Console.ReadKey();
        }
    }
}
