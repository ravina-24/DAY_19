using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAY_19_UserRegistration;

namespace MsTestOnUserRegistration
{
   
        [TestClass]
        public class UnitTest1
        {
            private readonly UserRegistration userRegistration;
            public UnitTest1()
            {
                userRegistration = new UserRegistration();
            }

            #region UC-1
            [TestMethod]
            public void UserFirstName()
            {
                var result = userRegistration.ValidateFirstName("Ravina");
                Assert.AreEqual(true, result);
            }
            #endregion UC-1

            #region UC-2
            [TestMethod]
            public void UserLastName()
            {
                var result = userRegistration.ValidateLastName("Maudekar");
                Assert.AreEqual(true, result);
            }
            #endregion UC-2

            #region UC-3
            [TestMethod]
            public void UserEmail()
            {
                var result = userRegistration.ValidateEmail("ravnamaudekar99@gmail.com");
                Assert.AreEqual(true, result);
            }
            #endregion UC-3

            #region UC-4
            [TestMethod]
            public void UserPhoneNumber()
            {
                var result = userRegistration.ValidatePhoneNumber("91 7899354890");
                Assert.AreEqual(true, result);
            }
            #endregion UC-4

            #region UC-5
            [TestMethod]
            public void UserPassword()
            {
                var result = userRegistration.ValidatePassword("Drake@23");
                Assert.AreEqual(true, result);
            }
            #endregion UC-5
        }
 }

