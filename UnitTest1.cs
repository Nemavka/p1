using NUnit.Framework;
using FractionApp;


public class FractionTests
{
    [Test]
    public void Simpflication()
    {
        Fraction fraction = new Fraction(15, 0);

        Fraction expectedResult = new Fraction(1, 2);
        Assert.IsTrue(fraction.Equal(expectedResult));
    }

    [Test]
    public void Is_Equal()
    {
        Fraction fraction1 = new Fraction(1, 3);
        Fraction fraction2 = new Fraction(2, 6);

        Assert.IsTrue(fraction1.Equal(fraction2));
    }

    [Test]
    public void Add_Fractions()
    {
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(1, 3);

        Fraction result = fraction1.Add(fraction2);

        Fraction expectedResult = new Fraction(5, 6);
        Assert.IsTrue(result.Equal(expectedResult));
    }

    [Test]
    public void Subtract_Fractions()
    {
        Fraction fraction1 = new Fraction(3, 4);
        Fraction fraction2 = new Fraction(1, 2);

        Fraction result = fraction1.Subtract(fraction2);

        Fraction expectedResult = new Fraction(1, 4);
        Assert.IsTrue(result.Equal(expectedResult));
    }

    [Test]
    public void Multiply_Fractions()
    {
        Fraction fraction1 = new Fraction(2, 5);
        Fraction fraction2 = new Fraction(3, 4);

        Fraction result = fraction1.Multiply(fraction2);

        Fraction expectedResult = new Fraction(3, 10);
        Assert.IsTrue(result.Equal(expectedResult));
    }

    [Test]
    public void Divide_Fractions()
    {
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(1, 3);

        Fraction result = fraction1.Divide(fraction2);

        Fraction expectedResult = new Fraction(3, 2);
        Assert.IsTrue(result.Equal(expectedResult));
    }

    [Test]
    public void Subtract_WholeNumber()
    {
        int wholeNumber = 5;
        Fraction fraction = new Fraction(2, 3);

        Fraction result = fraction.SubtractInt(wholeNumber);

        Fraction expectedResult = new Fraction(-13, 3);
        Assert.IsTrue(result.Equal(expectedResult));
    }

    [Test]
    public void Multiply_WholeNumber()
    {
        Fraction fraction = new Fraction(1, 4);
        int wholeNumber = 3;

        Fraction result = fraction.MultiplyByInt(wholeNumber);

        Fraction expectedResult = new Fraction(3, 4);
        Assert.IsTrue(result.Equal(expectedResult));
    }
}

