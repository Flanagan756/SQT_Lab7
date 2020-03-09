using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SQT_Lab7;

namespace SQT_Lab7.test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void test1()
        {
            //Arrange
            SQT_Lab7.Program p1 = new Program();

            //Act
            double actualResult = p1.Q1(0);

            //Asser
            Assert.That(actualResult, Is.EqualTo(0));
        }
        [Test]
        public static void test2()
        {
            //Arrange
            SQT_Lab7.Program p2 = new Program();

            //Act
            double actualResult = p2.Q1(1);

            //Asser
            Assert.That(actualResult, Is.EqualTo(15));
        }
        [Test]
        public static void test3()
        {
            //Arrange
            SQT_Lab7.Program p3 = new Program();

            //Act
            double actualResult = p3.Q1(2);

            //Asser
            Assert.That(actualResult, Is.EqualTo(20));
        }
        [Test]
        public static void test4()
        {
            //Arrange
            SQT_Lab7.Program p4 = new Program();

            //Act
            double actualResult = p4.Q1(3);

            //Asser
            Assert.That(actualResult, Is.EqualTo(30));
        }
        [Test]
        public static void test5()
        {
            //Arrange
            SQT_Lab7.Program p5 = new Program();

            //Act
            double actualResult = p5.Q1(4);

            //Asser
            Assert.That(actualResult, Is.EqualTo(40));
        }
        [Test]
        public static void test6()
        {
            //Arrange
            SQT_Lab7.Program p6 = new Program();

            //Act
            double actualResult = p6.Q1(5);

            //Asser
            Assert.That(actualResult, Is.EqualTo(50));
        }
        [Test]
        public static void test7()
        {
            //Arrange
            SQT_Lab7.Program p7 = new Program();

            //Act
            double actualResult = p7.Q1(6);

            //Asser
            Assert.That(actualResult, Is.EqualTo(58));
        }
        public static void test8()
        {
            //Arrange
            SQT_Lab7.Program p8 = new Program();

            //Act
            double actualResult = p8.Q1(-8);

            //Asser
            Assert.That(actualResult, Is.EqualTo(0));
        }
    }
    public class Class2
    {
        [Test]
        public static void test1()
        {
            //Arrange
            SQT_Lab7.Program p1 = new Program();

            //Act
            double actualResult = p1.Q2(100,2);

            //Asser
            Assert.That(actualResult, Is.EqualTo(25));
        }
 
    }
}
