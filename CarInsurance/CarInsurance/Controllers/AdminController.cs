using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //instantiate InsuranceEntities object that gives access to database
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                //new list of view models
                var insureeVms = new List<InsureeVM>();
                //map view models from model to view model then pass that list to the view
                foreach (var insuree in insurees)
                {
                    var insureeVm = new InsureeVM();
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote.ToString();
                    insureeVms.Add(insureeVm);
                }

                return View(insureeVms);
            }
        }   
    }
}