using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;


[Route("/api/maps")]
public class MapAPIController : Controller {
   


    [HttpGet("{searchTerm}")]
    // http://localhost:5000/api/maps/Woodbar?size=800x600
    
    public async Task<IActionResult> Get(string url){ 
        string address = "woodbar";
        string key = "AIzaSyBRBZtk0JyJrAzmp2i9DklBHhjvKwoI0JE";
        GeoLocator.SearchRO result = await API.GetData<GeoLocator.SearchRO>($"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={key}");
        
        return Ok(result);
    }
    private IBizzSearch bizzSearch;
    public MapAPIController(IBizzSearch b) {
        bizzSearch = b;
    }
    [HttpGetAttribute("{MapId?}")] // handles /maps and /maps/:id:
    public IActionResult Read(int MapId){
        if(MapId == default(int))
            return Ok(bizzSearch.getAll());
        
        return Ok(bizzSearch.get(MapId));
    }
    [HttpPost]
    public IActionResult Create([FromBody]Map s){
        bizzSearch.add(s);
        return Ok();
    }
    [HttpDelete("{MapId}")]
    public IActionResult Delete(int MapId){
        bizzSearch.delete(MapId);
        return Ok();
    }
    [HttpPutAttribute("{MapId}")]
    public IActionResult Update([FromBody]Map s, int MapId){
        if(bizzSearch.update(MapId, s) == null){
            return NotFound();
        }
        return Ok();
        }
    }
}
