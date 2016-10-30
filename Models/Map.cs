using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


public interface IBizzSearch { //this is how you interact with the bizzsearch dictionary
    void add(Map s);
    IEnumerable<Map> getAll();
    Map get(int MapId);
    Map update(int MapId, Map s);
    void delete(int MapId);
}

public class Map {
    public int MapId { get; set; }
    public string imageUrl { get; set; } = "https://maps.googleapis.com/maps/api/staticmap?zoom=16&size=600x300&maptype=roadmap&markers=color:red|label:X|29.736554,-95.389975";
    public string timeStamp { get; set; } = DateTime.Now.ToString();
    public string searchTerm { get; set; } = "woodbar";
    public int zoomLevel { get; set; } = 13;
    public int width { get; set; } = 800;
    public int height { get; set; } = 600;
    public string Size { get; set; } = ("Map.width"+"x"+"Map.height");
    public double lat { get; set; } = 29.736554;
    public double lng { get; set; } = -95.389975;
    public string LocationMap = "{lat},{lng}";
    public string color { get; set; } = "red";
    public string label { get; set; } = "X";

    public string markers { get; set; } = 
        ("color = (Map.color)"+
         "label = (Map.label)"+
         "locationmap = (Map.locationmap)");
    public Map() {
        MapId = new Random().Next();
    }
}


public class BizzSearch : IBizzSearch {
    private List<Search> searches = new List<Search>();
    public BizzSearch() {
        searches.Add(new Search { searchTerm = "Woodbar"});
    }
    public void add(Search s){
        searches.Add(s);
    }
    public IEnumerable<Search> getAll() {
        return searches;
    }
    public Search get(int SearchId) {
        return searches.First(s=> s.SearchId == SearchId);
    }
    public Search update(int SearchId, Search s){
        Search toUpdate = searches.First(x => x.SearchId == SearchId);
        if(toUpdate != null){
            searches.Remove(toUpdate);
            searches.Add(s);
            return s;
        }
        return null;
    }
    public void delete(int SearchId){
        Search s = searches.First(x => x.SearchId == SearchId);
        if(s != null){
            searches.Remove(s);
        }
    }
}
/*







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
