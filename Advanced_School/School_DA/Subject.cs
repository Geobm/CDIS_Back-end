//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public Subject()
        {
            this.SubjectFaculty = new HashSet<SubjectFaculty>();
        }
    
        public int ID_Subject { get; set; }
        public string SubjectName { get; set; }
    
        public virtual ICollection<SubjectFaculty> SubjectFaculty { get; set; }
    }
}
