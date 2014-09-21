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
        public int Height { get; set; }
        public int Width { get; set; }


        public ShortProjectViewModel(string name, string description, string logo, LogoSize size)
        {
            Name = name;
            Description = description;
            Logo = logo;

            switch (size)
            { 
                case LogoSize.Small:
                    Height = 50;
                    Width = 50;
                    break;
                case LogoSize.Medium:
                    Height = 105;
                    Width = 105;
                    break;
                case LogoSize.Wide:
                    Height = 215;
                    Width = 215;
                    break;
            }
        }
    }
}