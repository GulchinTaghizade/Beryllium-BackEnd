using Beryllium_ASP.Net.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium_ASP.Net.ViewModels
{
    public class HomeViewModel
    {
        public List<WorkBlogs> WorkBlogs { get; set; }
        public List<Slider> Slider { get; set; }
        public List<News> News { get; set; }
        public List<Testimonials> Testimonials { get; set; }


    }
}
