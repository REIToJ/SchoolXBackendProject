using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SchoolXAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true),
                    Size = table.Column<string>(type: "text", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "DateCreate", "Name", "Path", "Size" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 25, 10, 24, 5, 980, DateTimeKind.Local).AddTicks(7939), "y43b6ZbH3P", "c:\\temp\\image1.png", "640x480" },
                    { 9L, new DateTime(2022, 4, 18, 21, 37, 13, 810, DateTimeKind.Local).AddTicks(6030), "XHGKuhs3Qx", "c:\\temp\\image9.png", "640x480" },
                    { 8L, new DateTime(2021, 9, 4, 13, 41, 27, 640, DateTimeKind.Local).AddTicks(1868), "oCLeU4a7GY", "c:\\temp\\image8.png", "640x480" },
                    { 7L, new DateTime(2021, 11, 21, 1, 48, 10, 774, DateTimeKind.Local).AddTicks(6884), "x2bZlhZ85R", "c:\\temp\\image7.png", "640x480" },
                    { 6L, new DateTime(2021, 6, 19, 12, 17, 40, 726, DateTimeKind.Local).AddTicks(9189), "ELqSvXVWY4", "c:\\temp\\image6.png", "640x480" },
                    { 10L, new DateTime(2021, 9, 18, 12, 8, 49, 214, DateTimeKind.Local).AddTicks(2741), "tLka2AW0Id", "c:\\temp\\image10.png", "640x480" },
                    { 4L, new DateTime(2021, 12, 28, 5, 22, 9, 274, DateTimeKind.Local).AddTicks(2580), "CULDdrX4Gm", "c:\\temp\\image4.png", "640x480" },
                    { 3L, new DateTime(2021, 12, 19, 18, 30, 53, 281, DateTimeKind.Local).AddTicks(3597), "0BmKlyDrBt", "c:\\temp\\image3.png", "640x480" },
                    { 2L, new DateTime(2021, 9, 10, 2, 54, 21, 776, DateTimeKind.Local).AddTicks(5654), "f9HV0vcZ6l", "c:\\temp\\image2.png", "640x480" },
                    { 5L, new DateTime(2022, 5, 11, 12, 11, 15, 351, DateTimeKind.Local).AddTicks(7367), "OcMe6wa7x4", "c:\\temp\\image5.png", "640x480" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DateCreate", "Email", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 9L, new DateTime(2022, 4, 17, 13, 3, 40, 938, DateTimeKind.Local).AddTicks(576), "Ella90@yahoo.com", "Cecile Volkman", "wik2TZ7jra", "331261" },
                    { 1L, new DateTime(2021, 7, 30, 19, 56, 24, 561, DateTimeKind.Local).AddTicks(439), "Lilyan51@hotmail.com", "Domenic Baumbach", "AqnOd7m6IB", "431998" },
                    { 2L, new DateTime(2022, 3, 19, 4, 6, 16, 161, DateTimeKind.Local).AddTicks(94), "Retta.Emard@gmail.com", "Crystal Jast", "w4tDHafiS9", "986811" },
                    { 3L, new DateTime(2022, 3, 11, 17, 55, 42, 38, DateTimeKind.Local).AddTicks(749), "Camila_Treutel19@gmail.com", "Sydnie Runte", "9frx9bzHGp", "113979" },
                    { 4L, new DateTime(2022, 2, 5, 0, 24, 31, 843, DateTimeKind.Local).AddTicks(8772), "Darion84@yahoo.com", "Blair Stamm", "Cgwfiul7kO", "827865" },
                    { 5L, new DateTime(2021, 8, 23, 21, 42, 40, 215, DateTimeKind.Local).AddTicks(2335), "Bobbie73@yahoo.com", "Garrison Lindgren", "IeoY3vqJnK", "482847" },
                    { 6L, new DateTime(2021, 9, 7, 13, 25, 38, 285, DateTimeKind.Local).AddTicks(1085), "Bethel.Vandervort@yahoo.com", "Elwin Jacobi", "oCawS5eeCn", "292301" },
                    { 7L, new DateTime(2021, 8, 6, 19, 59, 0, 312, DateTimeKind.Local).AddTicks(5690), "Trent_Harber@hotmail.com", "Golda Prohaska", "JfLe8jC5iC", "680739" },
                    { 8L, new DateTime(2021, 12, 18, 2, 39, 34, 717, DateTimeKind.Local).AddTicks(3116), "Daphney84@yahoo.com", "Viola Hane", "qumoo3261a", "875804" },
                    { 10L, new DateTime(2022, 3, 21, 10, 2, 14, 283, DateTimeKind.Local).AddTicks(6539), "Rahul39@hotmail.com", "Anahi Powlowski", "F_m2tr5Ack", "906033" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
