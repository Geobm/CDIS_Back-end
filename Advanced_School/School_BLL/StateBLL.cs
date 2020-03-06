using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using School_DA;

namespace School_BLL
{
    public class StateBLL{

        public DataTable LoadState()
        {
            StateDAL state = new StateDAL();
            return state.LoadState();

        }
       

    }
}
