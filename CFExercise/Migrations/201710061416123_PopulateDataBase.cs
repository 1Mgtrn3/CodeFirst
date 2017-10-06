namespace CFExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDataBase : DbMigration
    {
        public override void Up()
        {
            //string Date = new System.DateTime(2009, 7, 10).ToString();


            Sql("INSERT INTO Videos (Name, ReleaseDate) VALUES ('TestVideo', '2012-06-01 00:00:00.000')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy') ");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller') ");
           

        }

        public override void Down()
        {
        }
    }
}
