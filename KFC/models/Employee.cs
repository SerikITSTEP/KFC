using System;
using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class Employee
    {
        [Key]
        public long id_employee { get; set; }
        public long position_id { get; set; }
        public long user_id { get; set; }
        public string fName { get; set; }
        public string sName { get; set; }
        public string mName { get; set; }
        public long iin { get; set; }
        public bool sex { get; set; }
        public DateTime birthDate { get; set; }
        public string adress { get; set; }
        public int experience { get; set; }
    }
}
