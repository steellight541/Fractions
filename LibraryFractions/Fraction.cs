namespace LibraryFractions
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction Add(Fraction other)
        {
            int leftNumerator = Numerator * other.Denominator;
            int rightNumerator = other.Numerator * Denominator;
            int newNumerator = leftNumerator + rightNumerator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator).Simplify();


        }

        public Fraction Subtract(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator).Simplify();
        }

        public Fraction Multiply(Fraction other)
        {
            int newNumerator = Numerator * other.Numerator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator).Simplify();
        }

        public Fraction Divide(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator;
            int newDenominator = Denominator * other.Numerator;
            return new Fraction(newNumerator, newDenominator).Simplify();
        }

        public Fraction Reciprocal()
        {
            return new Fraction(Denominator, Numerator);
        }

        public Fraction Invert()
        {
            return new Fraction(-Numerator, Denominator);
        }

        public Fraction Simplify()
        { 
            return new Fraction(Numerator / GCD(Numerator, Denominator), Denominator / GCD(Numerator, Denominator));
        }
        private static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        public double Result()
        {
            return (double)Numerator / (double)Denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
