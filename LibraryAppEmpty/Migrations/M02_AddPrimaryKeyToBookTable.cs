using FluentMigrator;

namespace LibraryApp.Migrations
{
    [Migration(2)]
    public class M02_AddPrimaryKeyToBookTable : Migration
    {
        public override void Up()
        {
            Alter.Table("BOOK").AddColumn("BOOK_ID").AsDecimal(19, 0).NotNullable();
            Create.Sequence("SEQ_BOOK_ID").StartWith(1000);
            Create.PrimaryKey("PK_BOOK")
                  .OnTable("BOOK")
                  .Column("BOOK_ID");
            Execute.Sql(@"
                create or replace trigger system_book_ibt
                    BEFORE INSERT ON BOOK
                    FOR EACH ROW

                BEGIN
                   IF inserting THEN
                      IF :NEW.book_id IS NULL OR :NEW.book_id = 0 THEN
                         :NEW.book_id := seq_book_id.nextval;
                      END IF;
                   END IF;
                END;");
        }

        public override void Down()
        {
            
        }
    }
}