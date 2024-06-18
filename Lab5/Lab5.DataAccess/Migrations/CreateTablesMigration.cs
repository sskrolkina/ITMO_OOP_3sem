using FluentMigrator;

namespace Lab5.DataAccess.Migrations;

[Migration(0)]
public class CreateTablesMigration : Migration
{
    public override void Up()
    {
        Create.Table("bank")
            .WithColumn("id").AsInt32().PrimaryKey()
            .WithColumn("name").AsString()
            .WithColumn("balance").AsDouble()
            .WithColumn("password").AsInt32()
            .WithColumn("role").AsString();

        Create.Table("history")
            .WithColumn("id").AsInt32()
            .WithColumn("operationtype").AsString()
            .WithColumn("balance").AsDouble()
            .WithColumn("message").AsString();
    }

    public override void Down()
    {
        Delete.Table("bank");
        Delete.Table("history");
    }
}