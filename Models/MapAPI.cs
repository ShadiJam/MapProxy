using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace GeoLocator
{
    

// geo locator latlng 

   public class Location
        {
        public double lat { get; set; }
        public double lng { get; set; }
        }       
    public class Geometry
        {
        public Location location { get; set; }
        }
    public class Result
        {
        public Geometry geometry { get; set; }
        }
    public class SearchRO
        {
        public List<Result> results { get; set; }
        }

}







