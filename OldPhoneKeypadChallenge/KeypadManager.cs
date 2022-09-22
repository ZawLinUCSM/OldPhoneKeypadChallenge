using System;
using System.Text;

namespace OldPhoneKeypadChallenge
{
    public class KeypadManager
    {

        public static String OldPhonePad(string input)
        {
            return ConvertToLetter(input);
        }

        static string ConvertToLetter(string input)
        {
            var inputCharArray = input.ToCharArray();

            StringBuilder outputLetter = new StringBuilder();
            var index = 0;

            //int i = 0;
            while (index < inputCharArray.Length)
            {
                var currentInputChar = inputCharArray[index];
                // If the current character is space ' ', then continue to the
                // next iteration
                if (currentInputChar == ' ')
                {
                    index++;
                    continue;
                }

                // To store the number of continuous clicks
                int pressCount = 1;

                if (currentInputChar == '#')
                    break;

                if (currentInputChar == '*')
                {
                    outputLetter.Remove(outputLetter.Length - 1, 1);
                    index++;
                    continue;
                }

                // Iterate a loop to find the count of same characters
                while (index + 1 < inputCharArray.Length
                       && inputCharArray[index] == inputCharArray[index + 1])
                {
                    pressCount++;
                    index++;

                    // To handle the end condition
                    if (index == inputCharArray.Length)
                        break;
                }
                KeypadInputNumber keypadInput = InputNumberResolver.MapType(currentInputChar);
                if (keypadInput != null)
                    outputLetter.Append(keypadInput.Print(pressCount));
                index++;
            }


            return outputLetter.ToString();
        }

    }
}
