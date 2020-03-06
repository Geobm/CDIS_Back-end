using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School_DA
{
    public class Subject_DAL {

        SchoolEntities model;

        public Subject_DAL(){
            model = new SchoolEntities();
        }
            public List<Subject> LoadSubjects() {

                var subjects = from mSubjects in model.Subject
                               select mSubjects;

                return subjects.ToList();
            
            }


        
        }

    }

