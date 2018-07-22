// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using dotnetapi.Models;

// namespace dotnetapi.Controllers
// {
//     // [ApiController]
//     public class ApiController : Controller
//     {
//         // [Produces("application/json")]  
//         // [Route("api")]    
        
        
//         [HttpGet]
//         public JsonResult retrieve([FromRoute] string model, [FromQuery] string id)
//         {   
//             string[] responseString = new string[] { model, id };
//             TestDBContext context = HttpContext.RequestServices.GetService(typeof(dotnetapi.Models.TestDBContext)) as TestDBContext;
//             if(id == null){
//                 return Json(context.GetAllTest()) ;
//             }
//             else{
//                 return Json(model);
//             }
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
