using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET_Lanches.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescricaoCurta,DescricaoDetalhada" +
      ",Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Presunto básico','Sanduíche de presunto','Sanduíche de presunto em pão francês com alface e tomate',8.50,'https://unsplash.com/photos/uhJfaJ6c9fY','https://unsplash.com/photos/uhJfaJ6c9fY',0,1,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescricaoCurta,DescricaoDetalhada" +
      ",Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Natural Simples','Sanduíche natural simples','Sanduíche em pão francês com tomate cereja e folhas verdes',7.50,'https://unsplash.com/photos/Znvxeud6sDc','https://unsplash.com/photos/Znvxeud6sDc',0,1,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
