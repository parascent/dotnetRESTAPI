using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace RESTAPI
{
    public  class RestController: Controller
    {
        private static object  CreateClassInstance(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().First(t => t.Name == className);
            return Activator.CreateInstance(type);
        }


        private static string GenerateModelName(string modelName)
        {
            return modelName.First().ToString().ToUpper() + modelName.Substring(1);
        }


        public static bool HasMethod( object objectToCheck, string methodName)
        {
            var type = objectToCheck.GetType();
            var method = type.GetMethod(methodName);
            var property = type.GetProperty(methodName);
            if(method != null || property != null){
                return true;
            }

            return false;
        } 




        [HttpGet]
        public string[] Get([FromRoute] string model)
        {
            var modelName = GenerateModelName(model);
            object Model = CreateClassInstance(modelName);

            if(HasMethod(Model, "contextString") == true){
               return new string[]
                {
                    Model.contextString
                };
            }

            // string[] result = new string[]{};

            //            using (var context = CreateClassInstance(Model.contextString))
            //            {
            //                result = context.Model.ToList();
            //            }

            //            return Model.contextString;

            return new string[]
            {
                "Shaffaaf"
            };
        }

    }
}