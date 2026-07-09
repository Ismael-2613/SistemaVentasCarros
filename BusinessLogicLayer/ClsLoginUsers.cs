using DataAccess;
using Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class ClsLoginUsers
    {
        public ClsResponse Login(ClsRequest obj_users)
        {
            ClsDataAccess clsDataAccess = new ClsDataAccess();
            var db = clsDataAccess.Login(obj_users);
            return db;
        }
    }
}
