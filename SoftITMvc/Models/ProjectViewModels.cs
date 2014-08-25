using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftITMvc.Models
{
    public class ShortProjectViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public LogoSize Size { get; set; }


        public ShortProjectViewModel(string name, string description, string logo, LogoSize size)
        {
            Name = name;
            Description = description;
            Logo = logo;
            Size = size;
        }
    }
}