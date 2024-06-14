namespace ClassesExample;

internal class Program
{
    static void Main(string[] args)
    {
        TQL tql = new TQL();
        tql.SecretNumber = 1;
        tql.DisplayClassname();
        var newSecretNumber = tql.RandomizeSecretNumber(321);
        Console.WriteLine($"The new secret number is {newSecretNumber}.");
        tql.DisplayClassname();
    }
}
//best practice to put the = additional class in another file, not the same code page (see TQL.cs file).
//to add this additional class file, right click project file in solution explorer, add, class. Name it the same name as the class in the code. 


   