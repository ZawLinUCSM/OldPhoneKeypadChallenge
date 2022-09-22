using System;

namespace OldPhoneKeypadChallenge
{
    public class InputNumberResolver
    {
        public static KeypadInputNumber MapType(char inputChar)
        {
            KeypadInputType inputNumberKeypad;
            Enum.TryParse(inputChar.ToString(), out inputNumberKeypad);

            switch (inputNumberKeypad)
            {
                case KeypadInputType.Number2:
                    return new InputNumber2();
                case KeypadInputType.Number3:
                    return new InputNumber3();
                case KeypadInputType.Number4:
                    return new InputNumber4();
                case KeypadInputType.Number5:
                    return new InputNumber5();
                case KeypadInputType.Number6:
                    return new InputNumber6();
                case KeypadInputType.Number7:
                    return new InputNumber7();
                case KeypadInputType.Number8:
                    return new InputNumber8();
                case KeypadInputType.Number9:
                    return new InputNumber9();
                default: return null;
            }
        }
    }
}
