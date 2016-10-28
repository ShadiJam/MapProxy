using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

[RouteAttribute("/searches")]
public class SearchController : Controller {
    private IBizzSearch bizzSearch;
    public SearchController(IBizzSearch b){
        bizzSearch = b;
    }
[HttpGet]
public IActionResult ReadAll(){
    return View(bizzSearch);
    }
[HttpGetAttribute("{id}")]
public IActionResult ReadOne(int id){
    var search = bizzSearch.get(id);
    if(search == null)
    return NotFound();

    return View(search);
    }
[HttpGetAttribute("{id}/edit")]
public IActionResult Edit(int id){
    var s = bizzSearch.get(id);
    if(s == null)
    return Redirect("/searches");
    return View(s);
    }
    
}
