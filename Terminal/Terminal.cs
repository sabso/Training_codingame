using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Training_codingame.Training;

namespace Terminal
{
    class Terminal
    {
        static void Main(string[] args)
        {
            int[] tab_int = { -1, 1, 2, 3, -5, 5, 3, 4 };
            Console.WriteLine(plus_proche_de_zero(tab_int));


            //string s;
            // Console.WriteLine(2 << 1);// 2 = 2exp1 , décalé de 1 bit donne 2exp2
            // Console.WriteLine(2 >> 1); /**/


            //Console.WriteLine(LocateUniverseFormula());

            /*
                        List<int> list = new List<int>(1);

                        list.Add(1);
                        list.Add(2);
                        list.Add(3);
                        list.Add(5);
                        list.Add(9);
                        list.Add(0);
                        //list.Add("Bob");
                        int a = list[5];
                        Console.WriteLine(a);
                        Console.WriteLine(list.Count);*/
            /* Console.WriteLine(1 << 2);

             string a = "ab";
             string b = "ab";
             Console.WriteLine(a.GetHashCode());
             Console.WriteLine(b.GetHashCode());*/
            // Console.WriteLine(factorial_Recursion(0));
            //Console.WriteLine(factorial_Recursion(100));//marche pas  mettre 10
            //Console.WriteLine(GetBinCoeff(10));
            //Console.WriteLine(GetBinCoeff(4));
            //Console.WriteLine(GetBinCoeff(10000));
            /*double r = default;
           r = factorial_WhileLoop(100);
           Console.WriteLine(r);*/

            /* var m = new Dictionary<object, int>();
             var o1 = new object();
             var o2 = o1;
             m[o1] = 1;
             m[o2] = 2;
             Console.WriteLine(m[o1]); */

            /*A a = new A();
            A b = new B();*/

            /*
            try
            {
                 
                    bool s;
                   int a ;
                    int b ;
                    Console.WriteLine("a");
                    a=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("b");
                    b= Int32.Parse(Console.ReadLine());
                    s = (b % 2 == 0);//impair
                    Console.WriteLine(s);
                    fraction(2, 3);
                
               
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine("{0}: {1} pas de nombre impair ", e.GetType().Name, e.Message);
            }

            */

            /* int[] tab = {1,2,3,12};
             Console.WriteLine( FindLargest(tab));*/




            //var strings = new List<string>();

            //strings.Add("Gurt");
            //strings.Add("Lobster");
            //strings.Add("Litchi");
            //strings.Add("Der");
            //var filteredStrings = new Answer().Filter(strings).OrderBy(x => x);
            //foreach (var str in filteredStrings)
            //{
            //    Console.WriteLine(str);
            //}


            //var a = Check("{{[[(())]]}}");
            //var b = Check("[()]");
            //var c = Check("(()[])");
            //var d = Check("([)]");
            //var e = Check("((");






            // Struct struct1;
            //struct1.foo = 5;

            //Struct struct2 = struct1;
            //struct2.foo = 10;
            //Console.WriteLine("foo");
            //Console.WriteLine(struct1.foo); // renvoie 5 car struct est un type valeur , obj est un type reference, var type reference aussi

            //int[] arr = new int[] { 1 ,2, 3 ,4, 5, 3 };
            //int res = calc(arr, 0, 1);
            //int res1 = calc(arr, 0, 5);
            //int res2 = calc(arr, 0, 0);
            //int res3 = calc(arr, 0, 6);

            //var eul = euler(11);
            //var calc = calculate_sum_from_a(7,49);

            // int[] prices = new int[] { 11,23,30,40,80,110,22 };
            //var resultat = CalculateTotalPrice(prices, 20);


            // Console.WriteLine(Sumwithcomma("1,001", "1,01"));
            // Console.WriteLine(Sum("1.001", "1.01"));

            //Console.WriteLine(getNextNumber(34));
            //Console.WriteLine(computeJoinPoint(471, 480));




            //char c = scanChar("S");
            //Console.WriteLine("corresp to " + c);

            //A a = new A();
            //A b = new B();
            //a.affiche();
            //b.affiche();

            //Derived obj = new Base();
            //obj.Show();

            //foreach (int i in Power(2, 8))
            //{
            //    Console.Write("{0} ", i);
            //}


            var rands = new Point[10000];
            Random random = new Random();
            for (int i = 0; i < rands.Length; i++)
            {
                Point p = new Point();
                p.x = random.NextDouble();
                p.y = random.NextDouble();
                rands[i] = p;
            }

            var resultat = Pi.Approx(rands);


            Console.ReadLine();
        }
    }
}
