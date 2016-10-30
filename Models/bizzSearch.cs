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
        int MapId = new Random().Next();
    }
}


public class BizzSearch : IBizzSearch {
    private List<Map> maps = new List<Map>();
    public BizzSearch() {
        maps.Add(new Map{ searchTerm = "Woodbar"});
    }
    public void add(Map s){
        maps.Add(s);
    }
    public IEnumerable<Map> getAll() {
        return maps;
    }
    public Map get(int MapId) {
        return maps.First(s=> s.MapId == MapId);
    }
    public Map update(int MapId, Map s){
        Map toUpdate = maps.First(x => x.MapId == MapId);
        if(toUpdate != null){
            maps.Remove(toUpdate);
            maps.Add(s);
            return s;
        }
        return null;
    }
    public void delete(int MapId){
        Map s = maps.First(x => x.MapId == MapId);
        if(s != null){
            maps.Remove(s);
        }
    }
}

