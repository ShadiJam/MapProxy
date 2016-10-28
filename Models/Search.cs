using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


public interface IBizzSearch {
    void add(Search s);
    IEnumerable<Search> getAll();
    Search get(int id);
    Search update(int id, Search s);
    void delete(int id);
}

public class Search {
    public int SearchId;
    public string imageUrl;
    public string timeStamp;
    public string searchTerm;
    public int zoomLevel;
    public int width;
    public int height;
    public double lat;
    public double lng;
    public string Location = "{lat},{lng}";
    public string color;
    public string label;
    public Search() {
        SearchId = new Random().Next();
    }
}

public class BizzSearch : IBizzSearch {
    private List<Search> searches = new List<Search>();
    public BizzSearch() {
        searches.Add(new Search { SearchId = 1, searchTerm = "Woodbar"});
        
    }
    public void add(Search s){
        searches.Add(s);
    }
    public IEnumerable<Search> getAll() {
        return searches;
    }
    public Search get(int SearchId) {
        return searches.First(s=> s.SearchId == id);
    }
    public Search update(int SearchId, Search s){
        Search toUpdate = searches.First(x => x.SearchId == id);
        if(toUpdate != null){
            searches.Remove(toUpdate);
            searches.Add(s);
            return s;
        }
        return null;
    }
    public void delete(int SearchId){
        Search s = searches.First(x => x.SearchId == id);
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