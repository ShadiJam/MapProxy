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
  
   
    
    public async Task<IActionResult> Get(string search = "", string size = "800x600"){
        SearchRO result = await API.GetData<SearchRO>($"https://maps.googleapis.com/maps/api/geocode/json?address={search}&key=AIzaSyBpB11kqRshs-VhrcePC-NP_i_QCej7m-c");
        double[] latlng = {result.results.ElementAt(0).geometry.location.lat, result.results.ElementAt(0).geometry.location.lng};
   //     return Ok(new {search = search, size = size});
        // string result = await client.GetStringAsync()
        // JSON...
       
        MapRO mapView = await API.GetData<MapRO>($"https://maps.googleapis.com/maps/api/staticmap?zoom=13&size=600x800&maptype=roadmap&latlng={latlng}");
        return View(mapView);
    }

    
}

