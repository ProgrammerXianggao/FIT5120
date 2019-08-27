namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class quiz2 : DbContext
    {
        // Your context has been configured to use a 'quiz2' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'withU.Models.quiz2' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'quiz2' 
        // connection string in the application configuration file.
        public quiz2()
            : base("name=quiz2")
        {
            Quiz2 = new HashSet<quiz2>();
        }
        public bool first { get; set; }
        public bool second { get; set; }
        public bool third { get; set; }
        public bool forth { get; set; }
        public bool fifth { get; set; }
        public bool sixth { get; set; }
        public bool seventh { get; set; }
        public virtual ICollection<quiz2> Quiz2 { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}