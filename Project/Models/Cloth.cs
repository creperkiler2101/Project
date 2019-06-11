using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Cloth
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string For { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}