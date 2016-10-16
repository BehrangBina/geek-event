namespace GeekEvent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertSampleGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres(Id,Name) values (1,'Rock')");
            Sql("Insert Into Genres(Id,Name) values (2,'Blues')");


        }
        
        public override void Down()
        {
            Sql("delete from Genre where Id IN (1,2)");
        }
    }
}
