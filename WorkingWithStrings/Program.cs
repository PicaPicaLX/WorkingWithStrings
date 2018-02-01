using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 下面使用一种方法将初始的没有字符的变量"myString"变成由"--"连接的，从0到99的长字符串
            /*
            string myString = null;
            for (int i = 0; i < 1000000; i++)
            {
                myString += "--" + i.ToString();
            }
            */
            // 这种方法重复操作了很多次读取和赋值，创建了很多临时变量，非常占用资源，若将i设为1000000，需要工作20秒才能完成迭代


            // 下面使用一种新的类"StringBuilder"来进行同样的工作

            StringBuilder myString = new StringBuilder(); // 表示将变量"myString"初始化为新的使用类（class）"StringBuilder"的变量

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--"); // 方法"Append"是类（class）"StringBuilder"下的一个方法，在其他类下不可用
                myString.Append(i);
            }

            // 这种方法非常高效，使用0.18秒即可完成1000000次迭代

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
