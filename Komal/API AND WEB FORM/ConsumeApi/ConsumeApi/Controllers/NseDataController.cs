using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumeApi.Models;
using ConsumeApi.Controllers;
using System.Net.Http;

namespace ConsumeApi.Controllers
{
    public class NseDataController : Controller
    {
        // GET: NseData
        public ActionResult Index()
        {
            IEnumerable<SMAT> NseData = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44370/api/");
                var responseTask = client.GetAsync("NseData");
                responseTask.Wait();
                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<SMAT>>();
                    readJob.Wait();
                    NseData = readJob.Result;


                }
                else
                {
                    NseData = Enumerable.Empty<SMAT>();
                    ModelState.AddModelError(string.Empty, "server error");

                }

            }
            return View(NseData);
        }
    }
}