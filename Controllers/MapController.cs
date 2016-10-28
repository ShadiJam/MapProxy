using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

[RouteAttribute("/map")]
public class MapController : Controller {
    public IBizzSearch bizzSearch;
    public MapController(IBizzSearch b){
        bizzSearch = b;
    }
[HttpGet]
public IActionResult ReadAll(){
    return View(bizzSearch);
    }
[HttpGetAttribute("{SearchId}")]
public IActionResult ReadOne(int SearchId){
    var search = bizzSearch.get(SearchId);
    if(search == null)
    return NotFound();

    return View(search);
    }
[HttpGetAttribute("{SearchId}/edit")]
public IActionResult Edit(int SearchId){
    var s = bizzSearch.get(SearchId);
    if(s == null)
    return Redirect("/searches");
    return View(s);
    }
    
}
