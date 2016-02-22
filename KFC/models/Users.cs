using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KFC.models
{
  public  class Users
    {
      [Key]
      long id_user{get; set;}
      string user { set; get; }
      string password { set; get; }
    }
}
