using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SettingApi.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "NotificationSettings",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                NotificationType = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                IsMentionEnabled = table.Column<bool>(type: "bit", nullable: true),
                IsDirectMessageEnabled = table.Column<bool>(type: "bit", nullable: true),
                IsFollowEnabled = table.Column<bool>(type: "bit", nullable: true),
                PushSettings_IsMentionEnabled = table.Column<bool>(type: "bit", nullable: true),
                PushSettings_IsDirectMessageEnabled = table.Column<bool>(type: "bit", nullable: true),
                PushSettings_IsFollowEnabled = table.Column<bool>(type: "bit", nullable: true),
                IsPasswordChangeEnabled = table.Column<bool>(type: "bit", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NotificationSettings", x => x.UserId);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "NotificationSettings");
    }
}
