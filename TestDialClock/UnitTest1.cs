using LAB_9_1;
namespace TestDialClock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            DialClock expected = new DialClock(1, 15);
            //Act
            DialClock actual = new DialClock(0, 75);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            DialClock expected = new DialClock(-1, -1);
            //Act
            DialClock actual = new DialClock(22, 59);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            DialClock expected = new DialClock(-1, -1);
            //Act
            DialClock actual = new DialClock(22, 59);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            DialClock expected = new DialClock();
            //Act
            DialClock actual = new DialClock(0, 0);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            DialClock expected = new DialClock(4, 4);
            //Act
            DialClock actual = new DialClock(expected);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string expected = new DialClock(25, 61).Show();
            //Act
            string actual = "2 ч. 1 мин.";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            double expected = new DialClock(0, 0).Corner();
            //Act
            double actual = 0;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            double expected = new DialClock(0, 35).Corner();
            //Act
            double actual = 167.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            double expected = new DialClock(16, 15).Corner();
            //Act
            double actual = 37.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            double expected =  DialClock.Corner(new DialClock(0, 0));
            //Act
            double actual = 0;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            double expected = DialClock.Corner(new DialClock(0, 35));
            //Act
            double actual = 167.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            double expected = DialClock.Corner(new DialClock(16, 15));
            //Act
            double actual = 37.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            DialClock DC1 = new DialClock(1, 1);
            DialClock DC2 = new DialClock(2, 2);
            int expected = DialClock.GetCount();
            //Act
            int actual = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            DialClock expected = new DialClock(1, 1);
            expected++;
            //Act
            DialClock actual = new DialClock(1, 2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            DialClock expected = new DialClock(2, 0);
            expected--;
            //Act
            DialClock actual = new DialClock(1, 59);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod16()
        {
            //Arrange
            DialClock DC = new DialClock(1, 25);
            bool expected = (bool)DC;
            //Act
            bool actual = true;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod17()
        {
            //Arrange
            DialClock DC = new DialClock(1, 24);
            bool expected = (bool)DC;
            //Act
            bool actual = false;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod18()
        {
            //Arrange
            DialClock DC = new DialClock(1, 25);
            int expected = DC;
            //Act
            int actual = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod19()
        {
            //Arrange
            DialClock DC1 = new DialClock(0, 0);
            DialClock DC2 = new DialClock(1, 2);
            DialClock expected = DC1 + DC2;
            //Act
            DialClock actual = new DialClock(1, 2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod20()
        {
            //Arrange
            int min = 21;
            DialClock DC1 = new DialClock(2, 35);
            DialClock expected = min + DC1;
            //Act
            DialClock actual = new DialClock(2, 56);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod21()
        {
            //Arrange
            int min = 21;
            DialClock DC1 = new DialClock(1, 40);
            DialClock expected = DC1 + min;
            //Act
            DialClock actual = new DialClock(2, 1);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod22()
        {
            //Arrange
            int min = 5;
            DialClock DC1 = new DialClock(2, 40);
            DialClock expected = DC1 - min;
            //Act
            DialClock actual = new DialClock(2, 35);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod23()
        {
            //Arrange
            int min = 5;
            DialClock DC1 = new DialClock(2, 5);
            DialClock expected = min - DC1;
            //Act
            DialClock actual = new DialClock(22, 0);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod24()
        {
            //Arrange
            DialClock DC1 = new DialClock(2, 35);
            DialClock DC2 = new DialClock(2, 35);
            DialClock expected = DC1 - DC2;
            //Act
            DialClock actual = new DialClock(0, 0);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod25()
        {
            //Arrange
            DialClock expected = new DialClock(0, -125);
            //Act
            DialClock actual = new DialClock(21, 55);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod26()
        {
            //Arrange
            DialClock expected = new DialClock(15, -60);
            //Act
            DialClock actual = new DialClock(14, 0);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod27()
        {
            //Arrange
            DialClock DC1 = new DialClock(11, 12);
            double DC2 = 0;
            bool expected = DC1.Equals(DC2);
            //Act
            bool actual = false;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod28()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray(1);
            DCA1[0] = new DialClock(0, 0);
            //Act
            DialClockArray DCA2 = new DialClockArray(1);
            DCA2[0] = new DialClock(0, 0);
            //Assert
            Assert.AreEqual(DCA1[0], DCA2[0]);
        }

        [TestMethod]
        public void TestMethod29()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray(2);
            int expected = DCA1.Lenght();
            //Act
            int actual = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod30()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray(new int[,] { { 1, 2}, { 3, 4} });
            string expected = DCA1.Show();
            //Act
            string actual = "1 ч. 2 мин." + "\n" + "3 ч. 4 мин." + "\n";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod31()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray(new int[,] { });
            string expected = DCA1.Show();
            //Act
            string actual = "В массиве нет элементов";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod32()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray(new int[,] { {1, 2}, {3, 4} });
            int expected = DialClockArray.GetCountObject();
            //Act
            int actual = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod33()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray(new int[,] { { 1, 2 }, { 3, 4 } });
            DialClockArray DCA2 = new DialClockArray(new int[,] { { 1, 2 }, { 3, 4 } });
            int expected = DialClockArray.GetCountCollection();
            //Act
            int actual = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod34()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray(new int[,] { { 1, 2 }, { 3, 4 } });
            DialClockArray DCA2 = new DialClockArray(DCA1);
            bool expected = (DCA1[0].Show() == DCA2[0].Show());
            //Act
            bool actual = true;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod35()
        {
            //Arrange
            DialClockArray DCA1 = new DialClockArray();
            bool expected = (DCA1.Lenght() == 0);
            //Act
            bool actual = true;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}