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
   


    [HttpGet("{searchTerm}")]
    // http://localhost:5000/api/maps/Woodbar?size=800x600
    
    public async Task<IActionResult> Get(string url){ // equivalent to create
        string address = "woodbar";
        string key = "AIzaSyBRBZtk0JyJrAzmp2i9DklBHhjvKwoI0JE";
        GeoLocator.SearchRO result = await API.GetData<GeoLocator.SearchRO>($"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={key}");
        
        return Ok(result);
    }
}
