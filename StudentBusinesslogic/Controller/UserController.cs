using StudentBusinesslogic.Repository;
using StudentModel;

namespace StudentBusinesslogic.Controller
{
    public class UserController
    {
        private readonly UserRepository repo = new UserRepository();

        public UserModel Login(string username, string password)
        {
            return repo.ValidateUser(username, password);
        }
    }
}
