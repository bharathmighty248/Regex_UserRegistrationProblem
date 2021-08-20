using NUnit.Framework;
using UserRegistrationProblem;

namespace UserEntryTest
{
    public class Tests
    {
        Validation validation = new Validation();
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// TestCase For FirstName Validation Return Happy
        /// </summary>
        [Test]
        public void GivenFirstName_WhenValidateFirstName_ShouldReturnHappy()
        {
            string firstName = "Bharath";
            bool fnresult = validation.ValidateFirstName(firstName);
            Assert.AreEqual(true, fnresult);
        }

        /// <summary>
        /// TestCase For FirstName Validation Return Sad
        /// </summary>
        [Test]
        public void GivenFirstName_WhenValidateFirstName_ShouldReturnSad()
        {
            string firstName = "bharath";
            bool fnresult = validation.ValidateFirstName(firstName);
            Assert.AreEqual(false, fnresult);
        }

        /// <summary>
        /// TestCase For LastName Validation Return Happy
        /// </summary>
        [Test]
        public void GivenLastName_WhenValidateLastName_ShouldReturnHappy()
        {
            string LastName = "Pasumarthi";
            bool lnresult = validation.ValidateLastName(LastName);
            Assert.AreEqual(true, lnresult);
        }

        /// <summary>
        /// TestCase For LastName Validation Return Sad
        /// </summary>
        [Test]
        public void GivenLastName_WhenValidateLastName_ShouldReturnSad()
        {
            string LastName = "pasumarthi";
            bool lnresult = validation.ValidateLastName(LastName);
            Assert.AreEqual(false, lnresult);
        }

        /// <summary>
        /// TestCase For Email Validation Return Happy
        /// </summary>
        [Test]
        public void GivenEmail_WhenValidateEmail_ShouldReturnHappy()
        {
            string email = "bharathmighty248@gmail.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(true, emresult);
        }

        /// <summary>
        /// TestCase For Email Validation Return Sad
        /// </summary>
        [Test]
        public void GivenEmail_WhenValidateEmail_ShouldReturnSad()
        {
            string email = "bharath@mighty248@gmail.com";
            bool emresult = validation.ValidateEmail(email);
            Assert.AreEqual(false, emresult);
        }

        /// <summary>
        /// TestCase For MobileNum Validation Return Happy
        /// </summary>
        [Test]
        public void GivenMobileNum_WhenValidateMobileNum_ShouldReturnHappy()
        {
            string mobileNum = "91 8498017061";
            bool mresult = validation.ValidateMobileNum(mobileNum);
            Assert.AreEqual(true, mresult);
        }

        /// <summary>
        /// TestCase For MobileNum Validation Return Sad
        /// </summary>
        [Test]
        public void GivenMobileNum_WhenValidateMobileNum_ShouldReturnSad()
        {
            string mobileNum = "918498017061";
            bool mresult = validation.ValidateMobileNum(mobileNum);
            Assert.AreEqual(false, mresult);
        }

        /// <summary>
        /// TestCase For Password Validation Return Happy
        /// </summary>
        [Test]
        public void GivenPassword_WhenValidatePassword_ShouldReturnHappy()
        {
            string password = "@Bhara4Th";
            bool presult = validation.ValidatePassword(password);
            Assert.AreEqual(true, presult);
        }

        /// <summary>
        /// TestCase For Password Validation Return sad
        /// </summary>
        [Test]
        public void GivenPassword_WhenValidatePassword_ShouldReturnSad()
        {
            string password = "bharathhh";
            bool presult = validation.ValidatePassword(password);
            Assert.AreEqual(false, presult);
        }
    }
}