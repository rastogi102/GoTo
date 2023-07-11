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
            string userName;
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
            Console.ReadKey();
        }
    }
}
