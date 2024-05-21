using System;

namespace FractionNamespace
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            Denominator = denominator; 
        }

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.");
                }
                _denominator = value;
            }
        }

        public int GetNumerator()
        {
            return _numerator;
        }

        public void SetNumerator(int value)
        {
            _numerator = value;
        }

        public int GetDenominator()
        {
            return _denominator;
        }

        public void SetDenominator(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _denominator = value;
        }

        public string GetFractionString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public double GetDecimalValue()
        {
            return (double)Numerator / Denominator;
        }
    }
}
