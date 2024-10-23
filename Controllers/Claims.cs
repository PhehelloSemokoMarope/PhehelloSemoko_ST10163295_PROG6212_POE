using Microsoft.AspNetCore.Mvc;
using PhehelloSemoko_ST10163295_PROG6212_POE.Models;
using PhehelloSemoko_ST10163295_PROG6212_POE.Services;
using System;

namespace PhehelloSemoko_ST10163295_PROG6212_POE.Controllers
{
    public class Claims1 : Controller
    {
        private readonly ApplicationDbcontext context;

        public Claims1(ApplicationDbcontext context)
        {
            this.context = context;
        }
        public IActionResult MakeClaim()
        {
            var claims = context.Claims.ToList();
            return View(claims);
        }
        [HttpPost]
        public IActionResult SubmitClaim(NewClaims newClaims)
        {
            if(newClaims.FileName == null)
            {
                ModelState.AddModelError("FileName", "The file name is required");
            }
            if (!ModelState.IsValid) {
            return View(newClaims);
            }
            

           string newFileName = Path.GetExtension(newClaims.FileName!.FileName);
        string imageFullPath = Environment.WebRootPath +"/Documents/"+
            return RedirectToAction("MakeClaim", "Claims1");
        }
    }
}
