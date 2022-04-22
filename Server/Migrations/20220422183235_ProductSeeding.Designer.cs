﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220422183235_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tempor quam in gravida posuere. Integer interdum libero purus, eget porta elit convallis eget. Aliquam orci risus, luctus at vestibulum quis, vehicula et sem. Sed egestas diam vel sapien scelerisque efficitur at in urna. Curabitur accumsan, velit eget pretium commodo, tortor metus tincidunt ipsum, vitae auctor massa turpis quis turpis.",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91N3BBmVNKL.jpg",
                            Price = 9.99m,
                            Title = "Liber Null"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Donec magna dui, rutrum nec ornare et, faucibus in quam. Morbi condimentum, tellus nec scelerisque sagittis, tortor diam molestie felis, et bibendum est ipsum eget ante. Vivamus a nibh nibh. Vivamus malesuada finibus quam dictum malesuada. Ut nec lectus pulvinar lacus molestie accumsan at at velit. Sed laoreet tristique cursus.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Georg_B%C3%BCchmann%2C_Gefl%C3%BCgelte_Worte%2C_19._Auflage%2C_1898.jpg/220px-Georg_B%C3%BCchmann%2C_Gefl%C3%BCgelte_Worte%2C_19._Auflage%2C_1898.jpg",
                            Price = 7.99m,
                            Title = "Liber Two"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cras nec orci pharetra magna tempus fermentum. Fusce finibus purus libero. Mauris sed neque vitae turpis volutpat imperdiet vel vel augue. Sed fringilla vestibulum eleifend. ",
                            ImageUrl = "https://www.carochinhaeditora.com.br/wp-content/uploads/2021/01/Ah-nao_E01_CAPA-V1.png",
                            Price = 8.99m,
                            Title = "Outro Livro"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
