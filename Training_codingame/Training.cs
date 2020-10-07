using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Training_codingame
{
    public class Training
    {
        public static int getpos(int n)
        {
            int[] l = { 0, 1, -1, -4, -5, -3 };
            return l[n % 6];
        }
        public static int getstep(int n)
        {
            /* if (n < 2)
             {
                 throw new Exception("n doit etre superieur ou egal à 2");
             }*/
            int[] l = { 3, 1, -2, -3, -1, 2 };
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return l[n % 6];
            }
        }
        public static int dance(int n)
        {
            int resultat = default;
            if (n == 0)
            {
                resultat = 0;
            }
            else if (n == 1)
            {
                resultat = 1;
            }
            else
            {
                resultat = getpos(n - 1) + getstep(n);
            }
            return resultat;
        }


        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        public static string Reshape(int n, String str)
        {

            string modifStr;
            if (str == null)
            {
                return str;
            }
            var strs = str.Trim().Split(null);
            var strBuilder = new StringBuilder(strs.Length);
            for (int i = 0; i < strs.Length; i++)
            {
                strBuilder.Append(strs[i]);
            }
            modifStr = strBuilder.ToString();

            int nbChar = modifStr.Length;
            Console.WriteLine(nbChar);
            if (nbChar <= n)
            {
                return modifStr;
            }

            int newStrLength = modifStr.Length;
            Console.WriteLine(newStrLength);
            string whiteSpace = "\n";
            for (int i = n; i <= newStrLength; i += n)
            {
                modifStr = modifStr.Insert(i, whiteSpace);
                i++;
                newStrLength++;
            }
            return modifStr;

        }

        public class Base
        {
            public void Show()
            {
                Console.WriteLine("Show from Base Class");
            }
        }
        public class Derived : Base
        {
            public void Show() 
            {
                Console.WriteLine("Show from Derived class");
            }
        }
        public static int plus_proche_de_zero(int[] n)
        {


            int lowestTempOutput = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (i == 0)
                {
                    lowestTempOutput = n[i];
                }
                else if (Math.Abs(n[i]) < Math.Abs(lowestTempOutput))
                {
                    lowestTempOutput = n[i];
                }
                else if (Math.Abs(n[i]) == Math.Abs(lowestTempOutput) && n[i] > lowestTempOutput)
                {
                    lowestTempOutput = n[i];
                }

            }

            return lowestTempOutput;



        }


        public static string Webnet(int[] values)
        {
            string s="";
           

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == 0 || values[i] < 0 || values[i] > 0)//.GetType().Equals(Type.Equals(Int32)))
                {
                    if (values[i] % 3 == 0)
                    {
                        s += "Web";
                    }
                    if (values[i] % 5 == 0)
                    {
                        s += "Net";
                    }
                    else
                    {
                        s += values[i];
                    }
                }
               
            }

            return s;
        }


        public class A
        {
            public void affiche()
            {
                Console.WriteLine("a");
            }

        }

        public class B : A
        {
            public void affiche()
            {
                Console.WriteLine("b");
            }

        }

        public class Point
        {
            public double x, y;
        }
        public class Pi
        {

            public static double Approx(Point[] pts)
            {
                int compteur = 0;
                //int circle
                double ppi = default;
                // int total=1;
                for (int i = 0; i < pts.Length; i++)
                {
                    if (Math.Sqrt((pts[i].x * pts[i].x) + (pts[i].y * pts[i].y)) <= 1.0)
                    {
                        compteur++;
                    }

                }
                ppi = (double)4 * ((double)compteur / (double)pts.Length); 
                return ppi;
            }
        }

        class Order
        {
            public string Customer { get; set; }
            public decimal Price { get; set; }
        }

        //public static IEnumerable<string> GetSuperCustomers(List<Order> orders)
        //{
        //    var res = orders.Where(x => x.Price >= 100);
        //    var res2 = new List<string>();
        //    foreach (var a in res)
        //    {
        //        res2.Add(a.Customer);
        //    }
        //    return res2;
        //}
        public static int findMinDiff(int[] arr, int n)
        {

            // Initialize difference as infinite 
            int diff = int.MaxValue;

            // Find the min diff by comparing difference 
            // of all possible pairs in given array 
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (Math.Abs((arr[i] - arr[j])) < diff)
                        diff = Math.Abs((arr[i] - arr[j]));

            // Return min diff  
            return diff;
        }

        public static string Sum(params string[] numbers)
        {
            decimal total = 0.0M;
            var cultureInfo = new System.Globalization.CultureInfo("en-US");
            foreach (string number in numbers)
            {
                total = total + decimal.Parse(number, cultureInfo);
            }
            return total.ToString();
        }

        public static string Sumwithcomma(params string[] numbers)
        {
            decimal total = 0.0M;

            foreach (string number in numbers)
            {
                total = total + decimal.Parse(number);
            }
            return total.ToString();
        }

        public static bool Twins(String str1,
                               String str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;

            // Return false if both are not of 
            // equal length 
            if (len1 != len2)
                return false;

            // To store indexes of previously 
            // mismatched characters 
            int prev = -1, curr = -1;

            int count = 0;
            for (int i = 0; i < len1; i++)
            {

                // If current character  
                // doesn't match 
                if (str1[i] != str2[i])
                {

                    // Count number of unmatched 
                    // character 
                    count++;

                    // If unmatched are greater 
                    // than 2, then return false 
                    if (count > 2)
                        return false;

                    // Store both unmatched 
                    // characters of both strings 
                    prev = curr;
                    curr = i;
                }
            }

            // Check if previous unmatched of 
            // string1 is equal to curr unmatched 
            // of string2 and also check for curr  
            // unmatched character, if both are 
            // same, then return true 
            return (count == 2 &&
                     str1[prev] == str2[curr] &&
                       str1[curr] == str2[prev]);
        }


        public static int numberOfWays(int x)
        {

            //// Base condition  
            //if (x == 0 || x == 1)
            //    return 1;


            //else
            //    return numberOfWays(x - 1) +
            //    (x - 1) * numberOfWays(x - 2);
            int[] dp = new int[x + 1];
            dp[0] = dp[1] = 1;

            for (int i = 2; i <= x; i++)
                dp[i] = dp[i - 1] +
                     (i - 1) * dp[i - 2];

            return dp[x];
        }


        public static int CalculateTotalPrice(int[] prices, int discount)
        {
            var prix_max = prices.Max(x => x);
            var reduction = prix_max * discount / 100.0;//(int)( prix_max * (discount/100.0));
            var prix_de_vente_total = Math.Round(prices.Sum(x => x) - reduction);

            return (int)prix_de_vente_total;
        }



        public static int ComputeMultipleSum(int n)
        {
            int[] array = new int[] { };

            int sum = 0;
            var liste = Enumerable.Range(0, n);
            var t = liste.ToArray();
            var res3 = liste.Where(x => x % 3 == 0);
            var res5 = liste.Where(x => x % 5 == 0);
           // var res2 = liste.Where(x => x % 2 == 0);
            var res7 = liste.Where(x => x % 7 == 0);
            var total = res3.Union(res7).Union(res5);// Union(res5).Union(res2);
            //var euler_t = liste.Where(x => x % 3 == 0).Where(x => x % 5 == 0).Where(x => x % 7 == 0).Sum(x => x);

            //var total2 =total.Distinct();
            var total3 = total.Sum(x => x);
            //var total3 = total.Count();
            return total3;

        }

        public static int calculate_sum_from_a(int a, int n)
        {
            var liste = Enumerable.Range(0, n + 1);
            var liste_bis = liste.Where(x => x % a == 0).Sum(y => y);
            return liste_bis;
        }

        // renvoie la somme des entiers entre les indices n1 et n2 
        public static int calc(int[] array, int n1, int n2)
        {
            int res = 0;
            for (int i = n1; i <= n2; i++)
            {
                res += array[i];
            }

            return res;
        }


        struct Struct
        {
            public int foo;
        }
        class Answer
        {
            public IEnumerable<string> Filter(List<string> Strings)
            {
                return Strings.Where(x => x.StartsWith("L")).AsEnumerable();
            }

        }

        public static bool Check(string str)
        {
            Stack<char> s = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '{') s.Push('}');
                else if (c == '(') s.Push(')');
                else if (c == '[') s.Push(']');
                else
                {
                    if (s.Count == 0 || c != (char)s.Peek())
                        return false;// "NO";
                    s.Pop();
                }
            }
            return s.Count == 0 ? true : false;//"YES" : "NO";
        }

        public static int FindLargest(int[] numbers)
        {

            int t = 0;
            foreach (int n in numbers)
            {
                if (n > t)
                {
                    t = n;
                }
            }
            return t;
        }
        public static void fraction(int a, int b)
        {

            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else if ((b % 2 == 0) == false)
            {
                throw new ArgumentException();
            }

            else
            {
                Console.WriteLine(a / b);
            }


        }
        public static decimal fraction_r(int a, int b)
        {

            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else if ((b % 2 == 0) == false)
            {
                throw new ArgumentException();
            }

            else
            {
                return a / b;
            }


        }


        //public class A
        //{
        //}
        //public class B : A
        //{
        //}

        public static string LocateUniverseFormula()
        {
            // string a;
            try
            {

                //C:\Users\Lenovo\Documents\work\create_ad_users  "Get-ProductKey"
                string[] dirs = Directory.GetFiles(@"c:\Users\Lenovo\Documents\work", "makecert", SearchOption.AllDirectories);
                string[] d = Directory.GetFiles(@"c:\Users\Lenovo\Documents\work\", "makecert.exe");

                int n = dirs.GetLength(1);


                return dirs[0];

            }
            catch
            {
                return "null";
            }
        }

        public static int factorial_WhileLoop(int number)
        {
            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
        public static int factorial_Recursion(int number)
        {

            try
            {
                if (number == 0)
                {
                    return 1;
                }
                else
                {
                    if (number == 1)
                        return 1;
                    else
                        return number * factorial_Recursion(number - 1);
                }

            }
            catch (StackOverflowException s)
            {
                return 0;
            }

        }
        public static long GetBinCoeff(long N)
        {

            long r = 1;
            long K = 2;
            long d;
            if (K > N) return 0;
            for (d = 1; d <= K; d++)
            {
                r *= N--;
                r /= d;
            }
            return r;
        }
        /// <summary>
        /// Calculates the binomial coefficient (nCk) (N items, choose k)
        /// </summary>
        /// <param name="n">the number items</param>
        /// <param name="k">the number to choose</param>
        /// <returns>the binomial coefficient</returns>
        public static long BinomCoefficient(long n, long k)
        {
            if (k > n) { return 0; }
            if (n == k) { return 1; } // only one way to chose when n == k
            if (k > n - k) { k = n - k; } // Everything is symmetric around n-k, so it is quicker to iterate over a smaller k than a larger one.
            long c = 1;
            for (long i = 1; i <= k; i++)
            {
                c *= n--;
                c /= i;
            }
            return c;
        }

        //public Node Find(int v)
        //{
        //    Node current = this;
        //    // Keep navigating down the tree until either we've run
        //    // out of nodes to look at, or we've found the right value.
        //    while (current != null && current.value != v)
        //    {
        //        current = v < current.value ? current.left : current.right;
        //    }
        //    return current;
        //}

        public static int count(int n)
        {
            /*Si(p = n) Alors Comb_1← 1
Sinon Si(p= 1) Alors Comb_1 ← n
Sinon Comb_1← (n / p) * Comb_1(n - 1, p - 1)*/

            int res;
            int p = 2;
            if (p > n)
            {
                res = 0;
            }
            else if (n == p)
            {
                res = 1;
            }

            else
            {
                if (p > (n / 2))
                {
                    p = n - p;
                }
                //res = factorial_Recursion(n) / (factorial_Recursion(p) * factorial_Recursion(n - 2)); factorial_WhileLoop
                res = factorial_WhileLoop(n) / (factorial_WhileLoop(p) * factorial_WhileLoop(n - 2));
            }

            //C= n! / k!(n-k)!
            return res;
        }
        public class Stack
        {
            private Object[] elements;
            private int size = 0;

            public Stack(int initialCapacity)
            {
                elements = new Object[initialCapacity];
            }

            public void push(Object o)
            {
                ensureCapacity();
                elements[size++] = o;
            }

            public Object pop()
            {
                if (size == 0)
                {
                    throw new InvalidOperationException(); // Ensures object consistency
                }
                Object result = elements[--size];
                elements[size] = null; // Eliminate obsolete reference
                return result;
            }

            /*
             * Ensure space for at least one more element, roughly
             * doubling the capacity each time the array needs to grow.
             */
            private void ensureCapacity()
            {
                if (elements.Length == size)
                {
                    Object[] oldElements = elements;
                    elements = new Object[2 * elements.Length + 1];
                    oldElements.CopyTo(elements, 0);
                }
            }
        }
        /*
        public static int computeJoinPoint(int s1, int s2)
        {


            if (s1 <= 0 || s2 <= 0 || s1 >= 20000000 || s2 >= 20000000)
            {
                return default;
            }
            while (s1 != s2)
            {
                if (s1 < s2)
                {
                    s1 = getNextNumber(s1);
                }
                else
                {
                    s2 = getNextNumber(s2);
                }
            }
            return s1;
        }

        public static int getNextNumber(int s)
        {
            var sumDigitsInNumber = 0;
            var toStringS = s + "";
            for (int i = 0; i < toStringS.Length; i++)
            {
                sumDigitsInNumber += Convert.ToInt32(toStringS[i]);
            }
            return s + sumDigitsInNumber;
        }*/


        public static char scanChar(String s)
        {

            for (char c = 'A'; c <= 'Z'; c++)
            {

                if (AsciiArt.printChar(c) == s)
                {

                    return c;
                }
            }

            return '?';

        }


        class AsciiArt
        {
            public static String printChar(char s)
            {
                // return "S";
                return "A";
            }
        }

        public class Competition
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public IEnumerable<Equipe> Equipes { get; set; }
        }
        public class Equipe
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public IEnumerable<Joueur> Equipes { get; set; }
        }
        public class Joueur
        {
            public int Id { get; set; }
            public string Nom { get; set; }
           
        }
        //public void test()
        //{
             

        //    c.Equipes.SelectMany(e => e.Equipes.SelectMany(x => x.Joeurs);
        //    //c.Select(e => e.Equipes.SelectMany(d => d.joueurs);

        //}
    }
}
