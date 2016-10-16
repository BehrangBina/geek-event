namespace GeekEvent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverRideconvensionsForGigAndGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres (id,name) values (1, 'Rock')");
            Sql("insert into genres (id,name) values (2, 'Blues')");
            Sql("insert into genres (id,name) values (3, 'Metal')");
            Sql("insert into genres (id,name) values (4, 'Country')");
        }
        
        public override void Down()
        {
            Sql("delete from genres where id in(1,2,3,4)");
        }
    }
}
