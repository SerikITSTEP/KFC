using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
  public  class Employees
    {
      [Key]
      long id_employee{get; set;}
      long id_position { get; set; }
      string fName { get; set; }
      string sName { get; set; }
      string mName { get; set; }
      long iin { get; set; }
      bool sex { get; set; }
      DateTime birthDate { get; set; }
      string adress { get; set; }
      int experience { get; set }


    }
}
