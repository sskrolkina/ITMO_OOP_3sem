using FluentMigrator;

namespace Lab5.DataAccess.Migrations;

[Migration(1)]
public class DefaultUserAddMigration : Migration
{
    public override void Up()
    {
        Insert.IntoTable("bank").Row(new
            { id = 1, name = "mama", balance = 50, password = 12345, role = "User", });
        Insert.IntoTable("bank").Row(new { id = 2, name = "Mayatin", balance = 228, password = 2239, role = "Admin", });
    }

    public override void Down()
    {
        Delete.FromTable("bank").Row(new
            { id = 1, name = "mama", balance = 24755498, password = 12345, role = "User", });
        Delete.FromTable("bank").Row(new { id = 2, name = "Mayatin", balance = 228, password = 2239, role = "Admin", });
    }
}