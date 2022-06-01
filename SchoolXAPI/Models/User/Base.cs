using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolXAPI.Models.User
{
    public class Base
    {
        public long Id { get; set; }
 
        public DateTime DateCreate { get; set; }


    }
}
