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
    public Search get(int id) {
        return searches.First(s=> s.SearchId == id);
    }
    public Search update(int id, Search s){
        Search toUpdate = searches.First(x => x.SearchId == id);
        if(toUpdate != null){
            searches.Remove(toUpdate);
            searches.Add(s);
            return s;
        }
        return null;
    }
    public void delete(int id){
        Search s = searches.First(x => x.SearchId == id);
        if(s != null){
            searches.Remove(s);
        }
    }
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
