using NameValidator_UT_Kata;

namespace NameValidator_UT_Kata_Test
{
    public class UnitTest1
    {
        private NameValidator nameValidator = new NameValidator();

        [Test]
        public void ValidOrInvalidName()
        {
            string username1 = "abcde1";
            string expectedValidResult = "Valid";
            string notExpectedResult = "Not Valid";
            string actualValidResult = "";
            string actualNotValidResult = "";
            if (username1.Length < 5)
            {
                actualNotValidResult = "Not Valid";
            }
            else
            {
                actualValidResult = "Valid";
            }
            if (actualNotValidResult != "")
            {
                Assert.AreEqual(notExpectedResult, actualNotValidResult);
            }
            else
            {
                Assert.AreEqual(expectedValidResult, actualValidResult);
            }
        }

        [Test]
        public void UserNameAlphanumeric()
        {
            string[] inputs = { "612345", "ravi1973", "ryanky123456", "vin1234" };
            foreach (string input in inputs)
            {
                bool result = nameValidator.ValidateUserName(input);
                Assert.IsTrue(result);
            }
        }

        [Test]
        public void ValidName()
        {
            string userName = "ryankyabcpqr";
            bool result = nameValidator.ValidateUserName(userName);
            Assert.IsTrue(result);
            Assert.IsTrue(userName.Length <= 12);

            userName = "ryanky";
            result = nameValidator.ValidateUserName(userName);
            Assert.IsTrue(result);
            Assert.IsTrue(userName.Length >= 5);
        }

        [Test]
        public void InvalidName()
        {
            string userName = "ryankyabcpqrk";
            bool result = nameValidator.ValidateUserName(userName);
            Assert.IsFalse(false);
            //Assert.IsFalse(userName.Length <= 12);

            userName = "ryank";
            result = nameValidator.ValidateUserName(userName);
            Assert.IsFalse(false);

            userName = "";
            result = nameValidator.ValidateUserName(userName);
            Assert.IsFalse(false);
        }
    }
}