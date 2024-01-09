using SignInLib;
using System.Net.Security;
namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {
         
        [TestMethod]
        public void SucessMethod()
        {
            string expResult = "valid user";
            Assert.AreEqual(expResult,SignIn.Authenticate("sam","sam@1256"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "Invalid user credential";
            Assert.AreEqual(expResult, SignIn.Authenticate("ravi", "raj@124"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "You must provide username and password ";

            Assert.AreEqual(expResult, SignIn.Authenticate(null, null));
        }
    }
}