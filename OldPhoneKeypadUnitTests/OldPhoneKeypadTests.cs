using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldPhoneKeypadChallenge;

namespace OldPhoneKeypadUnitTests
{
    [TestClass]
    public class OldPhoneKeypadTests
    {
        [TestMethod]
        public void CAB_Test()
        {
            var inputString = "222 2 22";
            var outputLetter = KeypadManager.OldPhonePad(inputString);
            Assert.AreEqual("CAB", outputLetter);
        }

        [TestMethod]
        public void E_Test()
        {
            var inputString = "33#";
            var outputLetter = KeypadManager.OldPhonePad(inputString);
            Assert.AreEqual("E", outputLetter);
        }

        [TestMethod]
        public void B_Test()
        {
            var inputString = "227*#";
            var outputLetter = KeypadManager.OldPhonePad(inputString);
            Assert.AreEqual("B", outputLetter);
        }

        [TestMethod]
        public void HELLO_Test()
        {
            var inputString = "4433555 555666#";
            var outputLetter = KeypadManager.OldPhonePad(inputString);
            Assert.AreEqual("HELLO", outputLetter);
        }
        [TestMethod]
        public void Scenario5Test()
        {
            var inputString = "8 88777444666*664#";
            var outputLetter = KeypadManager.OldPhonePad(inputString);
            Assert.AreEqual("TURING", outputLetter);
        }


    }
}
