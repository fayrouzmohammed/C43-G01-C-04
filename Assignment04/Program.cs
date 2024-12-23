// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //1
            #region 

            /*
                      Console.Write("Enter the number: ");
                      bool isparsed = int.TryParse(Console.ReadLine(), out int number );

                      if( isparsed )
                      {
                          while ( number >= 1 )
                          {
                              Console.WriteLine(number);
                              number--;
                          }
                      }
                      */
            #endregion
            //2
            #region
            //2
            /*    Console.Write("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i <= 12 ; i++) { 
                    Console.WriteLine(number*i);
                }*/

            #endregion
            //3
            #region

            /*    Console.Write("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= number; i++) {
                    if(i % 2== 0)
                    {
                        Console.WriteLine(i);
                    }

                }*/
            #endregion
            //4
            #region

            /*   int result = 1;
               Console.Write("enter the number: ");
               int number = Convert.ToInt32(Console.ReadLine());

               Console.Write("enter the power: ");
               int power = Convert.ToInt32(Console.ReadLine());

               for(int i= power; i > 0; i --)
               {
                   result = result * number;
               }

               Console.WriteLine(result);*/

            #endregion
            //5
            #region
            /*Console.Write("Enter Marks of five subjects: ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            int sub2 = Convert.ToInt32(Console.ReadLine());
            int sub3 = Convert.ToInt32(Console.ReadLine());
            int sub4 = Convert.ToInt32(Console.ReadLine());
            int sub5 = Convert.ToInt32(Console.ReadLine());


           
            int total = sub1 + sub2 + sub3 + sub4 + sub5;
            int avg = total / 5;
            float percentage = (total / 500) * 100 ;
            Console.WriteLine("total= " + total);
            Console.WriteLine("avg= " + avg);
            Console.WriteLine("percentage= " + percentage + "%");
*/





            #endregion
            //6
            #region

            /*Console.WriteLine("entet your String: ");
            string User_string = Convert.ToString(Console.ReadLine());

            char[] charArray = User_string.ToCharArray();
            Array.Reverse(charArray);
            string Reversed_string = new string(charArray);

            Console.WriteLine("Reversed: "+ Reversed_string);
*/

            #endregion
            //7
            #region
            /* Console.WriteLine("entet your Intger: ");
             int User_int = Convert.ToInt32(Console.ReadLine());

             int Reversed_int = 0 ;
             while(User_int!=0)
             {
                 int Digit = User_int % 10; //input=524 digit=4
                 Reversed_int = Reversed_int * 10 + Digit; //4
                 User_int = User_int / 10; //52 only
             }


             Console.WriteLine("Reversed: " + Reversed_int);*/


            #endregion
            //8
            #region

            /* Console.WriteLine("enter your range/n start: ");
             int start = Convert.ToInt32(Console.ReadLine());
             Console.Write("end: ");
             int end = Convert.ToInt32(Console.ReadLine());*/

            /*int start = 1;
            int end = 10;

            while (start <= end)
            {

                int n = 0;

                for (int i = 1; i < end; i++)
                {
                    for (int j = 1; j < end; j++)
                    {
                        if (start % j == 0)
                        { n++; } //1 - 2 - 
                    }
                    start++;
                }
                if(n==2)
                {
                    Console.WriteLine(start);
                }


            }*/


            //Console.WriteLine("Input the start of range");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input the End of range");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("The prime numbers between " + start + " and " + end + " are:");

            //for (int i = start; i <= end; i++)
            //{
            //    if (i > 1) 
            //    {
            //        int CountPrime = 0;

            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                CountPrime++;
            //                break;
            //            }
            //        }
            //        if(CountPrime == 0)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //}
            #endregion
            //9
            #region

            //Console.Write("Enter the decimal Number");
            //int Num = int.Parse(Console.ReadLine());
            //int reminder;
            //int BinaryNum = 0;
            //int pc = 1;
            //int Reverse = 0;
            //Console.WriteLine(Num);
            //while (Num != 0)
            //{

            //    reminder = Num % 2;
            //    BinaryNum = BinaryNum  + reminder*pc;
            //    Num = Num / 2;
            //    pc *= 10;

            //}

            //Console.WriteLine("BinaryNum: " + BinaryNum);

            #endregion
            //10
            #region
            //        Console.WriteLine("Enter 3 Points");
            //        Point p1 = new Point() { x = int.Parse(Console.ReadLine()) 
            //            , y = int.Parse(Console.ReadLine()) };
            //        Point p2 = new Point()
            //        {
            //            x = int.Parse(Console.ReadLine())
            //,
            //            y = int.Parse(Console.ReadLine())
            //        };
            //        Point p3 = new Point()
            //        {
            //            x = int.Parse(Console.ReadLine())
            //,
            //            y = int.Parse(Console.ReadLine())
            //        };
            //        Console.WriteLine("p1=("+p1.x+","+p1.y+")");
            //        Console.WriteLine("p2=("+p2.x+","+p2.y+")");
            //        Console.WriteLine("p3=("+p3.x+","+p3.y+"");
            //        double Slope1 = ((p3.y - p2.y) / (p3.x - p2.x));
            //        double Slope2 = ((p2.y - p1.y) / (p2.x - p1.x));
            //        Console.WriteLine("Slope1 " + Slope1);
            //        Console.WriteLine("Slope2 " + Slope2);
            //        if (Slope1 == Slope2)
            //        {

            //            Console.WriteLine("The 3 Points lie on a straight line");
            //        }
            //        else
            //        {
            //            Console.WriteLine("The 3 Points don't lie on a straight line");

            //        }
            #endregion
            //11
            #region
            //Console.WriteLine("Enter The Number of n for identity matrix");
            //int num =int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++) 
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(" 1 ");

            //        }
            //        else { 
            //        Console.Write(" 0 ");
            //        }

            //    }
            //    Console.WriteLine();

            //}

            #endregion
            //12
            #region
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int sum = 0;
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    sum+= Numbers[i];   
            //}
            //Console.WriteLine("Sum of elements of array= "+sum);
            #endregion
            //13
            #region
            //Console.WriteLine("Enter size");
            //int size=int.Parse(Console.ReadLine());
            //int []arr1=new int[size];
            //int counter = 1;
            //int []duplicate = new int[size];
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < size; i++) 
            //{
            //    if (duplicate[i] == 1) {
            //        continue;
            //    }
            //    for (int j = i+1; j < size; j++)
            //    {
            //        if (arr1[i] == arr1[j]) 
            //       {
            //            duplicate[j] = 1;
            //            counter++;
            //        }

            //    }
            //    Console.WriteLine("the element= "+arr1[i] +" appear " +counter+" times");
            //    counter = 1;

            //}


            #endregion
            //14
            #region
            //Console.WriteLine("Enter size");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size];
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr1[0],
            //min = arr1[0];
            //for (int i = 0;i < size; i++) 
            //{
            //    if (max < arr1[i])
            //    {
            //        max = arr1[i];
            //    }

            //    if (min > arr1[i])
            //    {
            //        min = arr1[i];
            //    }
            //}
            //Console.WriteLine("Max Number = "+max+" and Min Number = "+min);
            #endregion
            //15
            #region 

            //Console.WriteLine("Enter size");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size];
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr1[0],
            //min = arr1[0];
            //for (int i = 0;i < size; i++) 
            //{
            //    if (max < arr1[i])
            //    {
            //        max = arr1[i];
            //    }

            //    if (min > arr1[i])
            //    {
            //        min = arr1[i];
            //    }
            //}
            //Console.WriteLine("Max Number = "+max+" and Min Number = "+min);

            #endregion
            //18
            #region
            //Console.WriteLine("Enter String");
            //string input = Console.ReadLine();
            //string[] SplitInput = input.Split(' ');
            //string[] Reverse = new string[SplitInput.Length];
            //for (int i = 0; i < SplitInput.Length; i++) 
            //{
            //    Reverse[i] = SplitInput[SplitInput.Length - 1-i];
            //}
            //foreach (string s in Reverse)
            //{
            //    Console.Write(" "+s+" ");
            //}
            #endregion



        }
    }
}

