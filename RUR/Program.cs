using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace RUR
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int num;
//            Console.WriteLine("Введите количество ступенек: ");
//            num = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < num; i++)
//            {
//                Console.WriteLine("***");
//                for (int e = -1; e < i; e++)
//                {
//                    Console.Write("  ");
//                }
//                Console.WriteLine("*");
//                for (int e = -1; e < i; e++)
//                {
//                    Console.Write("  ");
//                }
//            }
//            System.Threading.Thread.Sleep(10000);
//        }
//    }
//}

namespace RUR
{
    internal class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();
            for (int i = 0; i < num.Length; i++)
            {
                PrintNum(num[i]);
            }
            System.Threading.Thread.Sleep(10000);
        }
        public static void PrintNum(char a)
        {
            switch (a)
            {
                case '0':
                    Console.Write(@" 
****
*  *
*  *
*  * 
****");
                    break;

                case '1':
                    Console.Write(@" 
  *
 **
* * 
  *
 ***");
                    break;

                case '2':
                    Console.Write(@" 
  ****
**  *
  * 
 *
*****");
                    break;

                case '3':
                    Console.Write(@" 
****
   *
 **
   * 
****");
                    break;

                case '4':
                    Console.Write(@" 
    *
  * *
 *  *
******
    *");
                    break;

                case '5':
                    Console.Write(@" 
  ****
  *
  *** 
*   *
 ****");
                    break;

                case '6':
                    Console.Write(@" 
  *
 * 
**** 
*  *
****");
                    break;

                case '7':
                    Console.Write(@" 
 ****
*   *
  *** 
  *
 *");
                    break;

                case '8':
                    Console.Write(@" 
  **
**  **
 **** 
**  **
  **");
                    break;

                case '9':
                    Console.Write(@" 
  *****
 **  **
 *****
    *
***");
                    break;
            }
        }
    }
}