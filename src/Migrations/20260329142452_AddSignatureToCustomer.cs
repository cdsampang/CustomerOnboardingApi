using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerOnboardingApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSignatureToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Signature",
                table: "Customers",
                type: "BLOB",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Customers");
        }
    }
}
