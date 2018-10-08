using System.Threading.Tasks;
using CV.Contracts.Profile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Profile.Services;
using Shouldly;

namespace Profile.UnitTests
{
    [TestClass]
    public class ProfileServiceUnitTests
    {
        [TestMethod]
        public async Task ReturnProfile()
        {
            var profileService = new ProfileService();
            var profile = await profileService.GetProfile();

            profile.ShouldBeAssignableTo<IProfile>();
            profile.ContactDetails.ShouldNotBeNull();
            profile.SocialMedia.ShouldNotBeNull();
        }
    }
}
