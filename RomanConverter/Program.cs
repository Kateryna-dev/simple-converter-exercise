using RomanConverter;

Console.WriteLine("Please enter a Roman Numeral from I to X");
int romanNumeral = SimpleConverter.ConvertFromRoman(Console.ReadLine());
string outputString = romanNumeral == 0 ?
    "Incorrect input" : $"The equivalent Arabic Numeral is {romanNumeral}";
Console.WriteLine(outputString);
Console.ReadKey();
