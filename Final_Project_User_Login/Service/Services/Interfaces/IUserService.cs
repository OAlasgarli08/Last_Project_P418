using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IUserService
    {
        void SignUp(string name, string surname, string email, int age, string password, string confrimpassword);
        List<User> LoginIn(string name, string surname, string email, int age, string password);
    }
}
