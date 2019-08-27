namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    public class quizz : DbContext
    {
        // Your context has been configured to use a 'quizz' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'withU.Models.quizz' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'quizz' 
        // connection string in the application configuration file.
        public quizz()
            : base("name=quizz")
        {
            Quizz = new HashSet<quizz>();

        }
        public bool firstt { get; set; }
        public bool secondd { get; set; }
        public bool thirdd { get; set; }
        public bool forthh { get; set; }
        public bool fifthh { get; set; }
        public bool sixthh { get; set; }
        public bool seventhh { get; set; }
        public bool eighthh { get; set; }
        public bool nighthh { get; set; }
        public virtual ICollection<quizz> Quizz { get; set; }
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