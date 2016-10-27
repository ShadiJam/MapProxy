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
namespace ResultLine { 


// class structure for result 
    public class Size
        {
        public int width { get; set; } = 800;
        public int height { get; set; } = 600;
        }

    public class LocationMap
    {
        public double lat { get; set; } = 29.736554;
        public double lng { get; set; } = -95.389975;
    }

    public class Marker
    {
        public string color { get; set; } = "red";
        public string label { get; set; } = "X";
        public LocationMap locationmap { get; set; } 
    }

    public class MapRObject
    {
        public string imageUrl { get; set; } = "https://maps.googleapis.com/maps/api/staticmap?zoom=16&size=600x300&maptype=roadmap&markers=color:red|label:X|29.736554,-95.389975";
        public string timestamp { get; set; } = DateTime.Now.ToString();
        public string searchTerm { get; set; } = "woodbar";
        public int zoomLevel { get; set; } = 13;
        public Size size { get; set; } 
        public List<Marker> markers { get; set; }
    }

}




