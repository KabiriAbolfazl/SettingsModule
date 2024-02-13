using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SettingApi.Migrations;

/// <inheritdoc />
public partial class InitialChangeToTPC : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropPrimaryKey(
            name: "PK_NotificationSettings",
            table: "NotificationSettings");

        migrationBuilder.DropColumn(
            name: "IsDirectMessageEnabled",
            table: "NotificationSettings");

        migrationBuilder.DropColumn(
            name: "IsFollowEnabled",
            table: "NotificationSettings");

        migrationBuilder.DropColumn(
            name: "IsMentionEnabled",
            table: "NotificationSettings");

        migrationBuilder.DropColumn(
            name: "NotificationType",
            table: "NotificationSettings");

        migrationBuilder.DropColumn(
            name: "PushSettings_IsDirectMessageEnabled",
            table: "NotificationSettings");

        migrationBuilder.DropColumn(
            name: "PushSettings_IsFollowEnabled",
            table: "NotificationSettings");

        migrationBuilder.DropColumn(
            name: "PushSettings_IsMentionEnabled",
            table: "NotificationSettings");

        migrationBuilder.RenameTable(
            name: "NotificationSettings",
            newName: "SmsSettings");

        migrationBuilder.AlterColumn<bool>(
            name: "IsPasswordChangeEnabled",
            table: "SmsSettings",
            type: "bit",
            nullable: false,
            defaultValue: false,
            oldClrType: typeof(bool),
            oldType: "bit",
            oldNullable: true);

        migrationBuilder.AddPrimaryKey(
            name: "PK_SmsSettings",
            table: "SmsSettings",
            column: "UserId");

        migrationBuilder.CreateTable(
            name: "EmailSettings",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                IsMentionEnabled = table.Column<bool>(type: "bit", nullable: false),
                IsDirectMessageEnabled = table.Column<bool>(type: "bit", nullable: false),
                IsFollowEnabled = table.Column<bool>(type: "bit", nullable: false),
                IsEnabled = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_EmailSettings", x => x.UserId);
            });

        migrationBuilder.CreateTable(
            name: "PushSettings",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                IsMentionEnabled = table.Column<bool>(type: "bit", nullable: false),
                IsDirectMessageEnabled = table.Column<bool>(type: "bit", nullable: false),
                IsFollowEnabled = table.Column<bool>(type: "bit", nullable: false),
                IsEnabled = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PushSettings", x => x.UserId);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "EmailSettings");

        migrationBuilder.DropTable(
            name: "PushSettings");

        migrationBuilder.DropPrimaryKey(
            name: "PK_SmsSettings",
            table: "SmsSettings");

        migrationBuilder.RenameTable(
            name: "SmsSettings",
            newName: "NotificationSettings");

        migrationBuilder.AlterColumn<bool>(
            name: "IsPasswordChangeEnabled",
            table: "NotificationSettings",
            type: "bit",
            nullable: true,
            oldClrType: typeof(bool),
            oldType: "bit");

        migrationBuilder.AddColumn<bool>(
            name: "IsDirectMessageEnabled",
            table: "NotificationSettings",
            type: "bit",
            nullable: true);

        migrationBuilder.AddColumn<bool>(
            name: "IsFollowEnabled",
            table: "NotificationSettings",
            type: "bit",
            nullable: true);

        migrationBuilder.AddColumn<bool>(
            name: "IsMentionEnabled",
            table: "NotificationSettings",
            type: "bit",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "NotificationType",
            table: "NotificationSettings",
            type: "nvarchar(21)",
            maxLength: 21,
            nullable: false,
            defaultValue: "");

        migrationBuilder.AddColumn<bool>(
            name: "PushSettings_IsDirectMessageEnabled",
            table: "NotificationSettings",
            type: "bit",
            nullable: true);

        migrationBuilder.AddColumn<bool>(
            name: "PushSettings_IsFollowEnabled",
            table: "NotificationSettings",
            type: "bit",
            nullable: true);

        migrationBuilder.AddColumn<bool>(
            name: "PushSettings_IsMentionEnabled",
            table: "NotificationSettings",
            type: "bit",
            nullable: true);

        migrationBuilder.AddPrimaryKey(
            name: "PK_NotificationSettings",
            table: "NotificationSettings",
            column: "UserId");
    }
}
