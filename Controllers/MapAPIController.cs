using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;


[Route("/api/map")]
public class MapAPIController : Controller {

    [HttpGet("{search}")]
    // http://localhost:5000/api/map/Woodbar?size=800x600
  
    public async Task<IActionResult> Get(string search, string dimension, string zoom){
        string key = "AIzaSyBRBZtk0JyJrAzmp2i9DklBHhjvKwoI0JE";
        var json = await API.GetData<SearchRO>($"https://maps.googleapis.com/maps/api/geocode/json?address={search}&key={key}");
        
        SearchRO result = JsonConvert.DeserializeObject<SearchRO>(json.ToString());
        var lat = json.results[0].geometry.location.lat;
        var lng = json.results[0].geometry.location.lng;
        string imageUrl = "https://maps.googleapis.com/api/maps/{search}zoom={zoom}&size={mapSize}&maptype=roadmap&markers=color:{color}|label:{label}|29.736554,-95.389975";
        string timeStamp = DateTime.Now.ToString();
        string searchTerm = search;
        string zoomLevel = zoom;
        string width = "800";
        string height = "600";
        string size = "{width}"+"x"+"{height}";
        string latlng = "{lat},{lng}";
        List<Marker> markers = new List<Marker> {
            new Marker {
                color = "red",
                label = "X",
            }
        };
        string Location = latlng;

        return 
    }

        
        


     //   double[] latlng = {result.results.ElementAt(0).geometry.location.lat, result.results.ElementAt(0).geometry.location.lng};
       
        
        

    //    MapRObject view = await API.GetData<MapRObject>($"https://maps.googleapis.com/maps/api/staticmap?zoom=16&size=600x300&maptype=roadmap&markers=color%3Ared&markers=label%3AX&markers={29.736554%2C-95.389975}");
    //    return Ok(view);
    }
    
   
}
     //   string result = @"{}
   //     return Ok(new {search = search, size = size});
        // string result = await client.GetStringAsync()
        // JSON...
 /*      int zoom = 13;
       string mapSize = "800x600";
       string color = "green";
       MapRO mapView = await API.GetData<MapRO>($"https://maps.googleapis.com/maps/api/staticmap?zoom={zoom}&size={mapSize}&maptype=roadmap&markers=color:{color}|label:X|{latlng}");
        return View(mapView);
    }

    
}
//all classes go under models
*/