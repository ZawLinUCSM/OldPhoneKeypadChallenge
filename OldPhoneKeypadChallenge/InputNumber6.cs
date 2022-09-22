namespace OldPhoneKeypadChallenge
{
    public class InputNumber6 : KeypadInputNumber
    {
        private string[] Letter = new string[] { "M", "N", "O" };
        public override string Print( int pressCount)
        {
            if (pressCount == 1) return Letter[0];
            if (pressCount == 2) return Letter[1];
            if (pressCount == 3) return Letter[2];
            return "";
        }
    }
}
