using System;
using Microsoft.EntityFrameworkCore;

namespace RESTAPI
{
    public abstract class  BaseModel 
    {
        public string contextString { get; set; }

        // public BaseModel(DbContext DbContext){
        //     this.DbContext = DbContext;
        // } 

    }
}