namespace OldPhoneKeypadChallenge
{
    public class InputNumber9: KeypadInputNumber
    {
        private string[] Letter = new string[] { "W", "X", "Y","Z" };
        public override string Print(int pressCount)
        {
            if (pressCount == 1) return Letter[0];
            if (pressCount == 2) return Letter[1];
            if (pressCount == 3) return Letter[2];
            if (pressCount == 4) return Letter[3];
            return "";
        }
    }
}
