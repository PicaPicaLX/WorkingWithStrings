using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 访问下面的网站可以了解更多有关数字格式的知识
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 转义符和换行符
            //string myString = "My \"so-callde\" life"; // "\"是转义字符，如果你想输入特殊字符如双引号，必须在它前面加转义符
            //string myString = "What if I need a \nnew line?"; // "\n"是换行符，在它之后的字符串都会在下一行显示
            //string myString = "Go to your c:\\ drive"; // 这里使用了两个反斜杠，因为如果只加一个反斜杠则会报错，第一个反斜杠为第二个转义
            //string myString = @"Go to your c:\ drive"; // "@"表示后面的一串话是纯字符，避免频繁使用转义符

            // "Format"方法，即格式化字符串
            //string myString = string.Format("{0} = {1}", "First", "Second"); // "Format"方法使用即使用替换字符，修改花括号内的数字即可得到不同的内容
            //string myString = string.Format("{0:c}", 123.45); // 在替换码的后面跟上":c"表示这是一个货币值(大小写c无所谓，下同)
            //string myString = string.Format("{0:n}", 1234567890); // 在替换码的后面跟上":n"会在大数字中加上千位分隔符
            //string myString = string.Format("{0:p}", 0.123); // 在替换码的后面跟上":p",会将数字变成百分数
            string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890); // 在替换码的后面跟上":一堆#号"是自定义格式，比如这个(区号)加电话号,若区号外的位数超过你的规定位数，则区号的范围会变大

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
