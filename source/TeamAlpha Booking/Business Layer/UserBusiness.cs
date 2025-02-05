﻿using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Data_Layer;

namespace Business_Layer
{
    public class UserBusiness : IUserBusiness
    {
        readonly IUserRepository userRepo;

        public UserBusiness(IUserRepository _userRepo)
        {
            userRepo = _userRepo;
        }

        public  int RegisterUser(User user) // pass validated instance
        {
            String email = user.Email;

            if (!userRepo.EmailExists(email))
            { // check if entered email is unique  
                return userRepo.InsertUser(user); //insert new user into db
            }

            return -1;
        }

        
        public Boolean CheckPassword(string email, string password)
        {
            if (userRepo.EmailExists(email))
            {
                return password.Equals(userRepo.GetPassByEmail(email));
            }
            return false;
        }

        public List<User> GetAllUsers()
        {
            return userRepo.GetAllUsers();
        }

        public int UpdateUserData(User UpdatedUser)
        {
            return userRepo.UpdateUserData(UpdatedUser);
        }

        public int RemoveUser(int UserId)
        {
            return userRepo.RemoveUser(UserId);
        }

        public User GetUserByEmail(string email)
        {
            return userRepo.GetUserByEmail(email);
        }

        public int GetUserCount()
        {
            return userRepo.GetUserCount();
        }

        public string GetUserNameById(int userId)
        {
            return userRepo.GetUserNameById(userId);
        }
    }
}
