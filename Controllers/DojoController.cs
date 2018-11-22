using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using DojoDachi.Models;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
namespace DojoDachi
{
    public class DojoDachiController:Controller
    {
        
        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult index(){
            if (HttpContext.Session.GetObjectFromJson<Pet>("pet")==null)
            {
                Pet dachi=new Pet();   
                HttpContext.Session.SetObjectAsJson("pet",dachi);
                Console.WriteLine("************************new pet**********");
                return View("index",dachi);
            }
            Console.WriteLine("************************saved pet**********");
            Pet savedDachi=HttpContext.Session.GetObjectFromJson<Pet>("pet");
            return View("index",savedDachi);
            
        }
        [HttpGet("restart")]
        public IActionResult Restart(){
            HttpContext.Session.Clear();
            return RedirectToAction("index");
        }

        
        [HttpGet("play")]
        public IActionResult Play(){
            
            Dictionary<string, object> response= new Dictionary<string, object>();
            Pet dachi=HttpContext.Session.GetObjectFromJson<Pet>("pet");
      
            
            response.Add("text",dachi.Play());
            response.Add("happiness",dachi.happiness);
            response.Add("energy",dachi.energy);
            response.Add("meal",dachi.meals);
            response.Add("fullness",dachi.fullness);
            response.Add("petHandler",dachi.PetHandler);
            HttpContext.Session.SetObjectAsJson("pet",dachi);
            return Json(response);
        }

        [HttpGet("feed")]
        public IActionResult Feed(){
            Dictionary<string, object> response= new Dictionary<string, object>();
            Pet dachi=HttpContext.Session.GetObjectFromJson<Pet>("pet");
      
            
            response.Add("text",dachi.Feed());
            response.Add("happiness",dachi.happiness);
            response.Add("energy",dachi.energy);
            response.Add("meal",dachi.meals);
            response.Add("fullness",dachi.fullness);
            HttpContext.Session.SetObjectAsJson("pet",dachi);
            response.Add("petHandler",dachi.PetHandler);
            return Json(response);
        }

        [HttpGet("sleep")]
        public IActionResult Sleep(){
            Dictionary<string, object> response= new Dictionary<string, object>();
            Pet dachi=HttpContext.Session.GetObjectFromJson<Pet>("pet");
      
            
            response.Add("text",dachi.Sleep());
            response.Add("happiness",dachi.happiness);
            response.Add("energy",dachi.energy);
            response.Add("meal",dachi.meals);
            response.Add("fullness",dachi.fullness);
            HttpContext.Session.SetObjectAsJson("pet",dachi);
            response.Add("petHandler",dachi.PetHandler);
            return Json(response);
        }

        [HttpGet("work")]
        public IActionResult Work(){
            Dictionary<string, object> response= new Dictionary<string, object>();
            Pet dachi=HttpContext.Session.GetObjectFromJson<Pet>("pet");
      
            
            response.Add("text",dachi.Work());
            response.Add("happiness",dachi.happiness);
            response.Add("energy",dachi.energy);
            response.Add("meal",dachi.meals);
            response.Add("fullness",dachi.fullness);
            HttpContext.Session.SetObjectAsJson("pet",dachi);
            response.Add("petHandler",dachi.PetHandler);
            return Json(response);
        }

        

        [HttpGet("petStatus")]
        public IActionResult PetStatus(){
            Pet dachi=HttpContext.Session.GetObjectFromJson<Pet>("pet");
           
            return Json(dachi.PetHandler);
        }
    
    }
    public static class SessionExtension
    {
        public static void SetObjectAsJson(this ISession session,string key,object value)
        {
            session.SetString(key,JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession session,string key)
        {
            string value=session.GetString(key);
            return value==null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}