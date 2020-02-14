using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using School_DA;
using System.Data.SqlClient;
using System.Threading.Tasks;

//Business Logic Layer

namespace School_BLL
{
    public class University_BLL{

        public DataTable Load_University() {

            University_DAL university = new University_DAL();
            return university.Load_University();

        }
    }
}
