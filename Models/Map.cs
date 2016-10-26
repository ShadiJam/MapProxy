using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

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
