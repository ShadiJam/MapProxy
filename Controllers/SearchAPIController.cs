using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;


[Route("/api/searches")]
public class SearchAPIController : Controller {
    private IBizzSearch bizzSearch;
    public SearchAPIController(IBizzSearch b) {
        bizzSearch = b;
    }



    [HttpGet("{search}")]
    // http://localhost:5000/api/map/Woodbar?size=800x600
    
    public async Task<IActionResult> GetData(string searchTerm){ // equivalent to create
        string key = "AIzaSyBRBZtk0JyJrAzmp2i9DklBHhjvKwoI0JE";
        string searchTerm = "woodbar";
        GeoLocator.SearchRO result = await API.GetData<GeoLocator.SearchRO>($"https://maps.googleapis.com/maps/api/geocode/json?address={searchTerm}&key={key}");
        bizzSearch.add(s);
        return Ok();
    }

    
}

        
        


     //   double[] latlng = {result.results.ElementAt(0).geometry.location.lat, result.results.ElementAt(0).geometry.location.lng};
       
        
        

    //    MapRObject view = await API.GetData<MapRObject>($"https://maps.googleapis.com/maps/api/staticmap?zoom=16&size=600x300&maptype=roadmap&markers=color%3Ared&markers=label%3AX&markers={29.736554%2C-95.389975}");
    //    return Ok(view);
    
    
   

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