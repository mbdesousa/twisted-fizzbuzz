namespace TwistedFizzBuzz;
public class FizzBuzz
{
  public static List<string> GetFizzBuzzOutput(string input, List<int> multiples, List<string> tokens)
  {
    int[] numbers = ParseNumbers(input);
    List<string> output = new();

    foreach (int number in numbers)
    {
      string value = GetFizzBuzzValue(number, multiples, tokens);
      output.Add(value);
    }

    return output;
  }

  private static int[] ParseNumbers(string input)
  {
    string[] tokens = input.Split(',');

    List<int> numbers = new();

    foreach (string token in tokens)
    {
      string trimmedToken = token.Trim();

      if (trimmedToken.Contains('-'))
      {
        string[] range = trimmedToken.Split('-');

        int start = int.Parse(range[0]);
        int end = int.Parse(range[1]);

        for (int i = start; i <= end; i++)
        {
          numbers.Add(i);
        }
      }
      else if (int.TryParse(trimmedToken, out int number))
      {
        numbers.Add(number);
      }
    }

    return numbers.ToArray();
  }

  private static string GetFizzBuzzValue(int number, List<int> multiples, List<string> tokens)
  {
    string value = "";

    for (int i = 0; i < multiples.Count; i++)
    {
      if (number % multiples[i] == 0)
      {
        value += tokens[i];
      }
    }

    if (string.IsNullOrEmpty(value))
    {
      value = number.ToString();
    }

    return value;
  }
}
