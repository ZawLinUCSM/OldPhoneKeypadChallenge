using System;

namespace OldPhoneKeypadChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "8 88777444666*664#";
            var outputLetter= KeypadManager.OldPhonePad(inputString);
            Console.WriteLine(outputLetter);
            Console.ReadKey();
        }
    }
}
