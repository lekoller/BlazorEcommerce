using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tempor quam in gravida posuere. Integer interdum libero purus, eget porta elit convallis eget. Aliquam orci risus, luctus at vestibulum quis, vehicula et sem. Sed egestas diam vel sapien scelerisque efficitur at in urna. Curabitur accumsan, velit eget pretium commodo, tortor metus tincidunt ipsum, vitae auctor massa turpis quis turpis.", "https://images-na.ssl-images-amazon.com/images/I/91N3BBmVNKL.jpg", 9.99m, "Liber Null" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Donec magna dui, rutrum nec ornare et, faucibus in quam. Morbi condimentum, tellus nec scelerisque sagittis, tortor diam molestie felis, et bibendum est ipsum eget ante. Vivamus a nibh nibh. Vivamus malesuada finibus quam dictum malesuada. Ut nec lectus pulvinar lacus molestie accumsan at at velit. Sed laoreet tristique cursus.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Georg_B%C3%BCchmann%2C_Gefl%C3%BCgelte_Worte%2C_19._Auflage%2C_1898.jpg/220px-Georg_B%C3%BCchmann%2C_Gefl%C3%BCgelte_Worte%2C_19._Auflage%2C_1898.jpg", 7.99m, "Liber Two" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Cras nec orci pharetra magna tempus fermentum. Fusce finibus purus libero. Mauris sed neque vitae turpis volutpat imperdiet vel vel augue. Sed fringilla vestibulum eleifend. ", "https://www.carochinhaeditora.com.br/wp-content/uploads/2021/01/Ah-nao_E01_CAPA-V1.png", 8.99m, "Outro Livro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
