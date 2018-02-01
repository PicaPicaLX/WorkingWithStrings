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
            string myString = " That summer we took threes across the board ";

            // 方法"Substring"能够按照在字符串中提取字符
            //myString = myString.Substring(6);  // 把第六个字符（包含空格）之后的字符提取
            //myString = myString.Substring(6,14); // 14表示把第六位之后的一共14个字符提取

            // 方法"ToUpper"能够将字符全部换成大写的
            //myString = myString.ToUpper();

            // 方法"Replace"能够将选定的字符换成你指定的字符
            //myString = myString.Replace(" ", "--"); // 这个表示将空格换成两个连字符

            // 方法"Remove"能移除特定的一些字符串
            //myString = myString.Remove(6); // 这段表示将第六个字符之后的所有字符串移除
            //myString = myString.Remove(6, 14); // 这段表示将第六个字符之后的14个字符移除

            // 方法"Trim"能移除特定的一些字符串

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
