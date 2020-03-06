using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_DA;



namespace School_BLL
{
    public class Subject_BLL{

        public List <Subject> LoadSubjects(){

            Subject_DAL subject = new Subject_DAL();
            return subject.LoadSubjects();
        }

     
    }
}
