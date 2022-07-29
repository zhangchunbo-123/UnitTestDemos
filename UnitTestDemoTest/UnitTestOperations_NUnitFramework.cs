using System;
using System.Collections;
using NUnit.Framework;

namespace UnitTestDemoTest
{
    [TestFixture]
    [Explicit]
    public class UnitTestOperations_NUnitFramework
    {
        //Arrange
        double numberA = 1;
        double numberB = 2;

        [TestFixtureSetUp]
        public void RunBeforeAllTests()
        {
            Console.WriteLine("TestFixtureSetUp");
        }

        [SetUp]
        public void RunBeforeEachTest()
        {
            Console.WriteLine("SetUp");
        }

        [Test]
        [Category("TestMethod")]
        public void Test_AddMethod()
        {
            //Act
            var result = UnitTestDemo.UnitTestHelper.Add(numberA, numberB);

            //Assert
            Assert.AreEqual(result, 3);
        }

        [Test]
        [Category("Exception")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ExpectAnException()
        {
            double zero = 0;
            double infinity = numberA / zero;
            Assert.Fail("Should have gotten an exception");

        }

        [Test]
        [Category("Ignore")]
        [Ignore("Multiplication is ignored")]
        public void Test_MultiplyMethod()
        {
            double product = numberA * numberB;
            Assert.AreEqual(2, product);
        }

        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void Test_DivideMethod(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [TestCase(12, 3, Result = 4,TestName ="12345")]
        [TestCase(12, 2, Result = 6)]
        [TestCase(12, 4, Result = 3)]
        public int Test_DivideMethod(int n, int d)
        {
            return (n / d);
        }

        [TearDown]
        public void RunAfterEachTest()
        {
            Console.WriteLine("TearDown");
        }

        [TestFixtureTearDown]
        public void RunAfterAllTests()
        {
            Console.WriteLine("TestFixtureTearDown");
        }

        #region [ # Suite # ]
        [Suite]
        public static IEnumerable Suite
        {
            get
            {
                ArrayList suite = new ArrayList();
                suite.Add(new UnitTestOperations_NUnitFramework());
                suite.Add(new UnitTestOperations());
                suite.Add(typeof(UnitTestOperations));
                return suite;
            }
        }
        [Test]
        public void Test_SuiteMethod()
        {
            foreach (var item in Suite)
            {
                Console.WriteLine(item.ToString());
            }
        }
        #endregion


        #region For White Box Test
        public void Test_WhiteBoxMethod(int loopCount, int specialNumber)
        {
            int x, y = 0;
            while (loopCount-->0)
            {
                if (specialNumber==0)
                {
                    x = y + 2;
                    break;
                }
                else
                {
                    if (specialNumber==1)
                    {
                        x = y + 10;
                    }
                    else
                    {
                        x = y + 20;
                    }
                }
            }
        }
        #endregion
    }
}
