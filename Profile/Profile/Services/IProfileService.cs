using System.Threading.Tasks;

namespace Profile.Services
{
    public interface IProfileService
    {
        Task<Profile> GetProfile();
    }
}