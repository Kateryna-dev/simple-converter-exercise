using FluentAssertions;
using NUnit.Framework; 

namespace RomanConverter.Tests;
public class SimpleConverterTest
{

    [Test]
    public void ConvertFromRoman_Shoud_Return_Correct_Numeral_For_Different_Inputs()
    {
        SimpleConverter.ConvertFromRoman("I").Should().Be(1);
        SimpleConverter.ConvertFromRoman("II").Should().Be(2);
        SimpleConverter.ConvertFromRoman("X").Should().Be(10);
    }

    [Test]
    public void ConvertFromRoman_Shoud_Return_Zero_For_Invalid_Input()
    {
        SimpleConverter.ConvertFromRoman("Hello").Should().Be(0);
    }
}