using TwistedFizzBuzz;

class BizzarreProgram
{
  static void Main()
  {
    string input = "0-127";
    List<int> multiples = new() { 5, 9, 27 };
    List<string> tokens = new() { "Fizz", "Buzz", "Bar" };

    List<string> output = FizzBuzz.GetFizzBuzzOutput(input, multiples, tokens);

    foreach (string value in output)
    {
      Console.WriteLine(value);
    }
  }
}