using SV21T1020725.DomainModels;

namespace SV21T1020725.DataLayers.SQLServer
{
    public class CustomerAccountDAL : BaseDAL, IUserAccountDAL
    {
        public CustomerAccountDAL(string connectString) : base(connectString)
        {
        }

        public UserAccount? Authorize(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(string username, string oldPassword, string newPassWord)
        {
            throw new NotImplementedException();
        }
    }
}
