using Mars.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Utils
{
    public class Start
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            [System.Obsolete]
            public void ShareSkillTest()
            {
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.EnterShareSkill();

                bool Result = shareSkill.ValidateShareSkill(Global.GlobalDefinitions.driver);
                Assert.IsTrue(Result);
            }

            [Test]
            [System.Obsolete]
            public void EditListingTest()
            {
                ManageListings manageListings = new ManageListings();
                manageListings.EditListings();

                bool EditResult = manageListings.ValidateEdit(Global.GlobalDefinitions.driver);
                Assert.IsTrue(EditResult);
            }

            [Test]
            [System.Obsolete]
            public void DeleteListingTest()
            {
                ManageListings manageListings = new ManageListings();
                manageListings.DeleteListings();

                bool DelResult = manageListings.ValidateDelete(Global.GlobalDefinitions.driver);
                Assert.IsTrue(DelResult);
            }

            [Test]
            [System.Obsolete]
            public void ChangePassword()
            {
                Profile profile = new Profile();
                profile.ChangePassword();

                bool PwdChgResult = profile.ValidateChangePassword(Global.GlobalDefinitions.driver);
                Assert.IsTrue(PwdChgResult);
            }


        }

    }
}
