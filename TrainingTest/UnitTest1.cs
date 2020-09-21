using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrainingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testplus_proche_de_zero_true()
        {
            int[] tab_int = { -1, 1, 2, 3, -5, 5, 3, 4 };
            var a = Training_codingame.Training.plus_proche_de_zero(tab_int);
            //expected 1 
            Assert.AreEqual(a,1);
        }

       

        [TestMethod]
        public void TestApprox()
        {
            var rands = new Training_codingame.Training.Point[10000];
            Random random = new Random();
            for (int i = 0; i < rands.Length; i++)
            {
                Training_codingame.Training.Point p = new Training_codingame.Training.Point();
                p.x = random.NextDouble();
                p.y = random.NextDouble();
                rands[i] = p;
            }

            Assert.AreEqual(3,Math.Floor(Training_codingame.Training.Pi.Approx(rands)));
        }

        [TestMethod]
        public void TestfindMinDiff()
        {
            int[] tab = { 1, 6, 4, 8, 2 };


            Assert.AreEqual(1,Training_codingame.Training.findMinDiff(tab,tab.Length));

        }

        [TestMethod]
        public void TestSum()
        {
            var a = Training_codingame.Training.Sum("-1.001","1.01");
            string t = "0.009";
            string aa = t.ToString();
            StringAssert.Equals(a.ToString(), "0.009");  
        }

        [TestMethod]
        public void TestTwins()
        {

            var a = Training_codingame.Training.Twins("Hello","world");//false
            var b = Training_codingame.Training.Twins("acb","bca"); //True
            var c= Training_codingame.Training.Twins("Lookout","Outlook");//True
            Assert.IsFalse(a);
            Assert.IsTrue(b);
           // Assert.IsTrue(c);

        }

        [TestMethod]
        public void TestnumberOfWays()
        {

            var a = Training_codingame.Training.numberOfWays(3);
            
            Assert.AreEqual(4, a);

        }


        [TestMethod]
        public void TestGetBinCoeff()
        {

            var a = Training_codingame.Training.GetBinCoeff(4);
            var b = Training_codingame.Training.GetBinCoeff(10000);
            Assert.AreEqual(6,a);
            Assert.AreEqual(49995000, b);

        }

        [TestMethod]
        public void TestCalculateTotalPrice()
        {
            int[] prices = new int[] { 11,23,30,40,80,110,22 };
            
            var a = Training_codingame.Training.CalculateTotalPrice(prices, 20);
            
            Assert.AreEqual(294, a);

        }


        [TestMethod]
        public void TestComputeMultipleSum()
        {
             
            var a = Training_codingame.Training.ComputeMultipleSum(11);

            Assert.AreEqual(40,a);

        }

        [TestMethod]
        public void Testcalculate_sum_from_a()
        {

            var a = Training_codingame.Training.calculate_sum_from_a(7,49);

            Assert.AreEqual(196, a);

        }

        [TestMethod]
        public void Testcalc()
        {
            int[] array = {0,1,2,3,4,5,3 };
            var a = Training_codingame.Training.calc(array,0, 6);

            Assert.AreEqual(18, a);

        }

        [TestMethod]
        public void TestCheck()
        {
             
            
            var a = Training_codingame.Training.Check("{{[[(())]]}}");//true
            var b = Training_codingame.Training.Check("[()]");//true
            var c = Training_codingame.Training.Check("(()[])");//true
            var e = Training_codingame.Training.Check("((");//false

            Assert.IsFalse(e);
            Assert.IsTrue(a);
            Assert.IsTrue(b);
            Assert.IsTrue(c);

        }

        [TestMethod]
        public void TestFindLargest()
        {


             int[] tab = { 1, 2, 3, 12 };
            var a = Training_codingame.Training.FindLargest(tab);//true

            Assert.AreEqual(a,12);
             

        }

        [TestMethod]
        public void Testfraction()
        {
             
             var a = Training_codingame.Training.fraction_r(2,2);//true

            Assert.AreEqual(a,1);


        }

        [TestMethod]
        public void TestLocateUniverseFormula()
        {

            var a = Training_codingame.Training.LocateUniverseFormula();//true

            Assert.IsNotNull(a);


        }

        [TestMethod]
        public void TestWebnet()
        {
            var values = new[] {1,4,3,7,5,11,15};
            var res = "14Web7Net11WebNet";
            var a = Training_codingame.Training.Webnet(values);

            StringAssert.Equals(res,a); 

        }

        [TestMethod]
        public void TestReshape()
        {
            var str1 = "abc\ndef\nghi\nj";
            var str2 = "12\n34\n56\n";
            var a = Training_codingame.Training.Reshape(3,str1);
            var b = Training_codingame.Training.Reshape(2, str2);
            StringAssert.Equals(a, b);

        }




    }
}
