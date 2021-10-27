using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day22ExerciseOne.Data
{
    public class Day22ExerciseOneContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Day22ExerciseOneContext() : base("name=Day22ExerciseOneContext")
        {
        }

        public System.Data.Entity.DbSet<Day22ExerciseOne.Models.Emp> Emps { get; set; }
    }
}
