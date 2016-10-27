using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


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

    public class Size
        {
        public int width { get; set; }
        public int height { get; set; }
        }

    public class LocationMap
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Marker
    {
        public string color { get; set; }
        public string label { get; set; }
        public LocationMap locationmap { get; set; }
    }

    public class MapRObject
    {
        public string imageUrl { get; set; }
        public string timestamp { get; set; }
        public string searchTerm { get; set; }
        public int zoomLevel { get; set; }
        public Size size { get; set; }
        public List<Marker> markers { get; set; }
    }









