using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using MySql.Data.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;


namespace RESTAPI
{
    public class MySqlEFDBContext : DbContext
    {
        // #region properties
        private string connectionString {get; set;}

        private string schemaName { get; set; }

        private int currentPage {get; set;}

        private int itemsPerPage;


        // #endregion properties



        public MySqlEFDBContext(string connectionString, string schemaName){
            this.connectionString = connectionString;
            this.schemaName = schemaName;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(this.connectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(this.schemaName);
        }   

        





    }

}