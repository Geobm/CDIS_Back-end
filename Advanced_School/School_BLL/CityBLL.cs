using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using School_DA;

namespace School_BLL
{
    public class CityBLL
    {

        public DataTable Load_CityState(int State)
        {

            CityDAL city = new CityDAL();

            return city.Load_CityState(State);

        }
    }
}
