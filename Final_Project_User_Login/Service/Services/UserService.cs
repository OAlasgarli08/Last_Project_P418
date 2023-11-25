using Domain.Models;
using Repository.Datas;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {

        public void SignUp(string name, string surname, string email, int age, string password, string confrimpassword)
        {
            DbContext<User>.Datas.Add(new User { Name = name, Age = age, Password = password, ConfirmPassword= confrimpassword, Email = email });
        }

        List<User> IUserService.LoginIn(string name, string surname, string email, int age, string password)
        {
            throw new NotImplementedException();
        }
    }
}
