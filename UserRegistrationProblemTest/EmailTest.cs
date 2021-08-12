using NUnit.Framework;
using UserRegistrationProblem;

namespace UserRegistrationProblemTest
{
    public class Tests
    {
        Validation validation = new Validation();
        [Test]
        public void GivenEmail1_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc@yahoo.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail2_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc-100@yahoo.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail3_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc.100@yahoo.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail4_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc111@abc.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail5_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc-100@abc.net";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail6_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc.100@abc.com.au";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail7_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc@1.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail8_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc@gmail.com.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail9_WhenValidateEmail_ShouldReturnTrue()
        {
            string email = "abc+100@gmail.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        [Test]
        public void GivenEmail1_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail2_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc@.com.my";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail3_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc123@gmail.a";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail4_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc123@.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail5_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc123@.com.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail6_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = ".abc@abc.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail7_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc()*@gmail.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail8_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc@%*.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail9_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc..2002@gmail.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail10_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc.@gmail.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail11_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc@abc@gmail.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail12_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc@gmail.com.1a";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        [Test]
        public void GivenEmail13_WhenValidateEmail_ShouldReturnFalse()
        {
            string email = "abc@gmail.com.aa.au";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }
    }
}