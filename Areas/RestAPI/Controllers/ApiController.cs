// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using RestApi.Models;

// namespace RestApi.Controllers
// {
//     // [ApiController]
//     public class ApiController : Controller
//     {
//         // GET api/values
//         // [HttpGet("{model},{page}")]
   
//         public JsonResult Retrieve([FromRoute] string model, [FromQuery] string id = "0")
//         {   
//             string[] responseString = new string[] { model, id };
//             // TestDBContext context = HttpContext.RequestServices.GetService(typeof(dotnetapi.Models.TestDBContext)) as TestDBContext;
//             return Json(context.GetAllTest()) ;
//         }

//         public JsonResult RetrieveById([FromRoute] string model, string id = "0")
//         {
//             string[] responseString = new string[] { model, id };
//             return Json(responseString);
//         }


//         // POST api/values
//         [HttpPost]
//         public void Add([FromBody] string value)
//         {
//         }

//         // PUT api/values/5
//         [HttpPut("{id}")]
//         public void Update(int id, [FromBody] string value)
//         {
//         }

//         // DELETE api/values/5
//         [HttpDelete("{id}")]
//         public void Delete(int id)
//         {
//         }
//     }
// }
