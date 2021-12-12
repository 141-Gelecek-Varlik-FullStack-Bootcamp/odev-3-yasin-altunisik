﻿using Roommate.Model;
using Roommate.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roommate.Service.User
{
    public interface IUserService
    {
        public General<LoginViewModel> Login(LoginViewModel user);
        public General<UserViewModel> GetUsers();
        public General<UserViewModel> Insert(UserViewModel newUser);
        public General<UserViewModel> Update(int id, UserViewModel user);
        public General<UserViewModel> Delete(int id);
    }
}
