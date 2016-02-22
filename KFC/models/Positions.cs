using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
  public  class Positions
    {
      [Key]
      long id_position { get; set; }
      string position { get; set; }
    }
}
