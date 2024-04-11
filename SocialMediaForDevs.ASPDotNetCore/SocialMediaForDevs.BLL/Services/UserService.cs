using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.BLL.Services;

public class UserService(IUserRepository _repo) : IUserService
{

}
