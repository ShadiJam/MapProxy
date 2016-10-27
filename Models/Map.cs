using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


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



/*

// defines elements of each search term
public class BizzSearch {
    public int BusinessID;
    public string searchTerm;
    public string name;
    public string imageUrl;
}


// creates link between search results and search result controller
public interface IBizzSearch {
    void add(Business b); // create
    IEnumerable<Business> getAll(); //read
    Business get(int id); //read
    IEnumerable<business> search(string name); //look up if ID unknown
    Business Update(int id, Business b); // edit
    void delete(int id); // delete
}


// NEED TO IMPLEMENT THESE METHODS!
//implements methods of BizzSearch 
/*
 public class BizzSearch : IBizzSearch {

     private List<BizzSearch> bizzsearch = new List<BizzSearch>;
     public BizzSearch() {
         bizzsearch.Add(new BizzSearch {businessID = 0, searchTerm = "", name = "", imageUrl = "" });
     }
     public void add {
         public IEnumerable<bizzsearch> getAll()
     }
     public bizzSearch get {
         public IEnumerable<bizzSearch> search()
     }
 }
*/
