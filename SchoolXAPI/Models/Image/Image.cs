using SchoolXAPI.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolXAPI.Models.Image
{
    public class Image:Base
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }

    }
}
