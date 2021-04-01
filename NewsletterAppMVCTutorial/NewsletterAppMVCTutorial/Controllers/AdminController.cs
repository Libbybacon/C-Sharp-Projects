using NewsletterAppMVCTutorial.Models;
using NewsletterAppMVCTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVCTutorial.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //instantiate NewsletterEntities object that gives access to database
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signups = db.SignUps;
                //new list of view models
                var signupVms = new List<SignupVM>();
                //map view models from model to view model then pass that list to the view
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVM();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }

        //Remove user from signup list using Id
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}