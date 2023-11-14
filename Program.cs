namespace Functional_programming;
class Program
{
    static void Main(string[] args)
    {
        int dieRollOOP = DieRoll.Roll(6);
        int dieRollFunct = 6.FunctionalDieRoll();
        Console.WriteLine(dieRollFunct);
        Console.WriteLine(dieRollFunct.Addtwo(dieRollOOP));

        Item iphone = new Item("iphone 15", 50, 1300.0);
  //      int dieRoll = 16;
  //      int[] countOfNumbers = new int[dieRoll];
  //      int currentnumber;
  //      for (int i = 0; i < 50000; i++)
  //      {
  //          currentnumber = DieRoll.Roll(dieRoll);
		//	Console.WriteLine($"Roll the die: {currentnumber}");
  //          countOfNumbers[currentnumber - 1]++;
		//}
  //      for (int i = 0; i < countOfNumbers.Length; i++)
  //      {
  //          Console.WriteLine($"Rolled {i + 1} - {countOfNumbers[i]} times.");
  //      }
    }
}
