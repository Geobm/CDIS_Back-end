using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_DA;
using System.Data;
using System.Data.SqlClient;


namespace School_BLL
{
   public class UserBLL{

        public DataTable CheckUser(string Name, string Password) {

            User_DAL user = new User_DAL();
            return user.CheckUser(Name,Password);
        }
    }
}
