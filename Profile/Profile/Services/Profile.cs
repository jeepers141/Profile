using System;

namespace Profile.Services
{
    public class Profile : Services.IProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Services.ContactDetails ContactDetails { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}