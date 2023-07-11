using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string userName;
            Again:
            Console.WriteLine("Enter UserName");
            userName=Console.ReadLine();
            if(userName.Length>=6) 
            {
                Console.WriteLine("Welcome : \t" + userName);

            }
            else
            {
                Console.WriteLine("Invalid UserName");
                goto Again;
            }
            StringBuilder stringBuilder= new StringBuilder("Welcome");
            stringBuilder.Append("To C#");
            stringBuilder.Append("I am string Builder");
            Console.WriteLine(stringBuilder);
            Console.ReadKey();*/

            /* for(int i=1;i<10;i++)
             {
                 if(i == 6)
                 {
                     goto end;
                 }
                 Console.WriteLine("i value:{0}", i);

             }
         end: Console.WriteLine("The end");
             Console.ReadKey();
            */

            DateTime matchDate = new DateTime(day: 12, month: 08, year: 2025);
            DateTime currentDate=DateTime.Now;
            TimeSpan ts=matchDate.Subtract(currentDate);
            Console.WriteLine("Days Remain :" +ts.Days);
            Console.WriteLine("Hours Remain :" + ts.Hours);
            Console.WriteLine(ts.ToString());
            Console.ReadKey();
        }
    }
}
