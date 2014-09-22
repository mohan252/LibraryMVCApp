using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace LibraryApp.Migrations
{
    [Migration(1)]
    public class M01_AddBookTable : Migration
    {
        public override void Up()
        {
            Create.Table("BOOK").WithColumn("TITLE").AsAnsiString(1000);
        }

        public override void Down()
        {
            
        }
    }
}