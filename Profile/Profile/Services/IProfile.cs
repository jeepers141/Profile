using System;

namespace Profile.Services
{
    public interface IProfile
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Services.ContactDetails ContactDetails { get; set; }
        DateTime DateOfBirth { get; set; }
        SocialMedia SocialMedia { get; set; }
    }
}