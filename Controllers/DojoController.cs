using System;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey
{
    public class DojoController : Controller
    {
        [HttpGet("")]
        public IActionResult Form()
        {
            return View();
        }

        //--------------------------------result
        [HttpPost("result")]
        public IActionResult Result(Survey newForm)
        // string Name, string Location, string Language, string Comment
        {
            if(ModelState.IsValid)
            {
            Console.WriteLine(newForm.Location);
                // met validations
                return View("Result", newForm);
            }
            else
            {
            Console.WriteLine(newForm.Language);
                return View("Form");
            }

            //   name*from cshtml = arguement 
            // ViewBag.name = Name;
            // ViewBag.location = Location;
            // ViewBag.language = Language;
            // ViewBag.comment = Comment;

        // var survey = new Survey()
        // {
        //     // Model = Arguement
        //     Name = Name,
        //     Location = Location,
        //     Language = Language,
        //     Comment = Comment
        // };
        //     return View(survey);

        }
    }
}