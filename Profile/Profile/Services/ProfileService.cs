using System;
using System.Threading.Tasks;
using CV.Contracts.Profile;

namespace Profile.Services
{
    public class ProfileService : IProfileService
    {
        public async Task<CV.Contracts.Profile.Profile> GetProfile()
        {
            return await Task.Run(() => new CV.Contracts.Profile.Profile
            {
                FirstName = "Gareth",
                LastName = "Knight",
                DateOfBirth = new DateTime(1980, 11, 27),
                ContactDetails = new ContactDetails {Mobile = "+41797105291", Email = "gareth.knight@outlook.com"},
                SocialMedia = new SocialMedia {LinkedIn = @"https://www.linkedin.com/in/gareth-knight-86173742/"}
            });

        }
    }
}