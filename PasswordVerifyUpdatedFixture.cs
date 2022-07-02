using PasswordVerifyUpdated;

namespace PasswordTestUpdated
{
    public class PasswordVerifyUpdatedFixture
    {
        [Theory]
        [InlineData("solaris", false)]
        [InlineData("sol34SOL", true)]

        public void PasswordTesting(string target, bool expected)
        {
            var actual = Password.VerifyPassword(target);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void PasswordTestingOne()
        {
            string pass = "sol34SOL";
            var actual = Password.VerifyPassword(pass);
            Assert.True(actual);
        }


        [Theory]
        [InlineData("SolLAHFF556")]
        [InlineData("solaris")]
        [InlineData("SOLARISS")]
        [InlineData("12345678")]
        [InlineData("SoLaRiS2")]
        [InlineData("sol34SOL")]

        public void Password_IsInvalid_ThrowsException(string target)
        {
            //arrange
            Password user = new Password();
            //act and assert

            Assert.Throws<Exception>(() => Password.VerifyPassword(target));

        }





    }
}