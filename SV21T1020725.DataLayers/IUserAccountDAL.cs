using SV21T1020725.DomainModels;

namespace SV21T1020725.DataLayers
{
    public interface IUserAccountDAL
    {
        UserAccount? Authorize(string username, string password);
        bool ChangePassword(string userName, string oldPassword, string newPassword);
    }
}
