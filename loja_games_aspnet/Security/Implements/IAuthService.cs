using loja_games.Model;

namespace loja_games.Security.Implements
{
    public interface IAuthService
    {
        Task<UserLogin?> Autenticar(UserLogin userlogin);
    }

}
