using System.Threading.Tasks;

namespace Profile.Services
{
    public interface IProfileService
    {
        Task<CV.Contracts.Profile.Profile> GetProfile();
    }
}