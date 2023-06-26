using TwistedFizzBuzz;

class Program
{
  static void Main()
  {
    string input = "1-100";
    List<int> multiples = new() { 3, 5 };
    List<string> tokens = new() { "Fizz", "Buzz" };

    List<string> output = FizzBuzz.GetFizzBuzzOutput(input, multiples, tokens);

    foreach (string value in output)
    {
      Console.WriteLine(value);
    }
  }
}