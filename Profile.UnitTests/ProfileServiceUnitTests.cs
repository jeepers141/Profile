using System.Threading.Tasks;
using CV.Contracts.Profile;
using Profile.Services;
using Shouldly;
using Xunit;

namespace Profile.UnitTests
{
    public class ProfileServiceUnitTests
    {
        [Fact]
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
