using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCApp.Controllers
{
    public class ProductsController : Controller
    {
        //public int GetProducts(string id)
        //{
        //    return int.Parse(id);
        //}

        //public List<string> GetProducts(string data1, string data2)
        //{
        //    return new List<string> { data1, data2 };
        //}

        //public JsonResult GetProducts(string id, string name, string price)
        //{
        //    //this.ViewBag.Id = id;
        //    //this.ViewBag.Name = name;
        //    //this.ViewBag.Price = price;
        //    //return this.View();
        //    return this.Json(new { Id = int.Parse(id), Name = name, Price = decimal.Parse(price) });
        //}

        public IActionResult GetProducts(string id, string name, string price)
        {
            //this.ViewBag.Id = id;
            //this.ViewBag.Name = name;
            //this.ViewBag.Price = price;
            //return this.View();
            // return this.Json(new { Id = int.Parse(id), Name = name, Price = decimal.Parse(price) });
            return this.Ok(new { Id = int.Parse(id), Name = name, Price = decimal.Parse(price) });
        }
    }
}
