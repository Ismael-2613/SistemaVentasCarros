using DataAccess;
using Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class ClsRegisterUsers
    {
        public ClsResponse Register(ClsRequest obj_users)
        {
            ClsDataAccess ClsDataAccess = new ClsDataAccess();
            var db = ClsDataAccess.Registrar(obj_users);
            return db;
        }
    }
}
