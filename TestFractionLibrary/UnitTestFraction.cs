using LibraryFractions;

namespace TestFractionLibrary
{
    public class UnitTestFraction
    {
        [Fact]
        public void TestAdd()
        {


            Fraction fraction1 = new Fraction(4, 2);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction result = fraction1.Add(fraction2);

            Fraction ExpectedFrac = new Fraction(5,2);
            Assert.Equal(ExpectedFrac.Result(), result.Result());

        }
        [Fact]
        public void TestSubtract()
        {

            Fraction fraction1 = new Fraction(4, 2);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction result = fraction1.Subtract(fraction2);

            Fraction ExpectedFrac = new Fraction(3,2);
            Assert.Equal(ExpectedFrac.Result(), result.Result());

        }
        [Fact]
        public void TestMultiply()
        {

            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction result = fraction1.Multiply(fraction2);

            Fraction ExpectedFrac = new Fraction(1,4);
            Assert.Equal(ExpectedFrac.Result(), result.Result());
        }
        [Fact]
        public void TestDivide()
        {

            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction result = fraction1.Divide(fraction2);

            Fraction ExpectedFrac = new Fraction(1,1);
            Assert.Equal(ExpectedFrac.Result(), result.Result());


        }
        [Fact]
        public void TestReciprocal()
        {

            Fraction fraction1 = new Fraction(1, 2);
            Fraction result = fraction1.Reciprocal();

            Fraction ExpectedFrac = new Fraction(2,1);
            Assert.Equal(ExpectedFrac.Result(), result.Result());
        }
        [Fact]
        public void TestNumerator()
        {
            Fraction fraction = new Fraction();
            fraction.Numerator = 8;
            Assert.Equal(8, fraction.Numerator);

            Fraction fraction1 = new Fraction(8, 2);
            Assert.Equal(8, fraction1.Numerator);

        }
        [Fact]
        public void TestDenominator()
        {
            Fraction fraction = new Fraction();
            fraction.Denominator = 8;
            Assert.Equal(8, fraction.Denominator);

            Fraction fraction1 = new Fraction(8, 2);
            Assert.Equal(2, fraction1.Denominator);
        }
        [Fact]
        public void TestResult()
        {
            Fraction fraction = new Fraction(1, 2);
            Assert.Equal(0.5, fraction.Result());

            Fraction fraction1 = new Fraction(8, 2);
            Assert.Equal(4, fraction1.Result());

        }
        [Fact]
        public void TestToString()
        {
            Fraction fraction = new Fraction(1, 2);
            Assert.Equal("1/2", fraction.ToString());

            Fraction fraction1 = new Fraction(8, 2);
            Assert.Equal("8/2", fraction1.ToString());
        }
        [Fact]
        public void TestFraction()
        {
            Fraction fraction = new Fraction();
            Assert.Equal(0, fraction.Numerator);
            Assert.Equal(1, fraction.Denominator);

            Fraction fraction1 = new Fraction(8, 2);
            Assert.Equal(8, fraction1.Numerator);
            Assert.Equal(2, fraction1.Denominator);

        }


        [Fact]
        public void TestFractionIntInt()
        {
            Assert.Equal(0, new Fraction().Numerator);
            Assert.Equal(1, new Fraction().Denominator);
        }

    }
}