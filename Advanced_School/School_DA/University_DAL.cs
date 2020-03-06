using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

//Data Acces Layer to load University
//Class working over entities model
namespace School_DA
{
    public class University_DAL {

        SchoolEntities model;

        public University_DAL() {

            model = new SchoolEntities();
        
        }
        public List<University> Load_University(){

            var universities = from mUniversities in model.University
                               select mUniversities;
            //returning my list objects type universities
            return universities.ToList();
        }

    }
}
