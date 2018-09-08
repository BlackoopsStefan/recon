# recon
search and explore
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Web_Api_Service.Controllers
{
    public class CustomersController : ApiController
    {
        public void ProcessRequest(HttpContext context)
        {
            string CustomerID = context.Request["ID"];
            Models.NorthwindEntities dc = new Models.NorthwindEntities();
            bool bExists = dc.Customers.Any(c => c.CustomerID == CustomerID);

            context.Response.ContentType = "text/plain";
            context.Response.Write(bExists ? "True" : "False");
        }
    }
}
