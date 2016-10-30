using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

[RouteAttribute("/maps")]
    public class MapController : Controller {
    public IBizzSearch bizzSearch;
    public MapController(IBizzSearch b){
        bizzSearch = b;
    }
    [HttpGet]
        public IActionResult ReadAll(){
            return View(bizzSearch);
        }
    [HttpGet("{MapId}")]
        public IActionResult ReadOne(int MapId){
            var map = bizzSearch.get(MapId);
            if(map == null)
            return NotFound();

            return View(map);
        }
    [HttpGet("{MapId}/edit")]
        public IActionResult Edit(int MapId){
            var s = bizzSearch.get(MapId);
            if(s == null)
            return Redirect("/maps");
            return View(s);
        }
    [HttpPost("{MapId}/edit")]
    [ValidateAntiForgeryToken]
        public IActionResult Upsert([FromForm] Map map, int MapId){
            var s = bizzSearch.get(MapId);
            if(s != null) {
                bizzSearch.delete(MapId);
        }
            map.MapId = MapId;
            bizzSearch.add(map);
            return RedirectToAction("ReadAll");
        }
    [HttpGet("new")]
        public IActionResult Create(){
            return View();
        }
    [HttpPost("new")]
    [ValidateAntiForgeryToken]
        public IActionResult HandleCreate([FromForm] Map s){
            bizzSearch.add(s);
            return RedirectToAction("ReadAll");
    }
    [HttpPost("delete/{MapId}")]
        public IActionResult Delete(int MapId){
            bizzSearch.delete(MapId);
            return RedirectToAction("ReadAll");
     }
    
}
