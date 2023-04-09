using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class class1
    {
       static  void Myname()
        {
            Console.WriteLine("Le Duc");
        }
        static int sumnumber(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void caculator()
        {
            Console.WriteLine(-1+4*6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2+15/6*1-7%2);
        }
        static void Swaptwonumber()
        {
            Console.WriteLine("Enter number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number a={0}", a);
            Console.WriteLine("number b= " + b);
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Number a then swap= {0}", a);
            Console.WriteLine("Number b then Swap= " + b);
        }
        static void Mutilphication()
        {
            Console.WriteLine("Input the first number to multiply:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the seconds number to multiply:");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the three number to multiply:");
            int c=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} * {1} *{2} = {3} ",a,b,c, (a * b * c));
        }
        static void Caculator2()
        {
            Console.WriteLine("Input the first number: ");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the seconds number: ");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
            Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
            Console.WriteLine("{0} % {1} = {2}", a, b, (a % b));
        }
        static void MutiphicationFive()
        {
            Console.WriteLine("Enter number : ");
            int number=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, (number * i));
            }
        }
        static void AvgNumber()
        {
            Console.WriteLine("Enter number 1,2,3,4: ");
            int one= Convert.ToInt32(Console.ReadLine());
            int two= Convert.ToInt32(Console.ReadLine());
            int three= Convert.ToInt32(Console.ReadLine());
            int four= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((one +two +three+four)/4);
        }

        static void Main(string[] args)
        {
            // Myname();
            //  Console.WriteLine(sumnumber(1, 2));
            // caculator();
            //Swaptwonumber();
            // Mutilphication();
            //Caculator2();
            //MutiphicationFive();
            AvgNumber();
        }

        
    }
}
