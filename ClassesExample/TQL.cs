using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample;
internal class TQL
{
 public int SecretNumber {get;set;}
    public void DisplayClassname() {
        Console.WriteLine($"Classname is TQL; Secret Number is {SecretNumber}.");
        }

    public int RandomizeSecretNumber(int RandomNumber) {
        SecretNumber *= RandomNumber;
        return SecretNumber;
    }
}
