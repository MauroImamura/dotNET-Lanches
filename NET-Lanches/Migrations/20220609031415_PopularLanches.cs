using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET_Lanches.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescricaoCurta,DescricaoDetalhada" +
      ",Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Presunto básico','Sanduíche de presunto','Sanduíche de presunto em pão francês com alface e tomate',8.50,'https://images.unsplash.com/photo-1485451456034-3f9391c6f769?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80','https://images.unsplash.com/photo-1485451456034-3f9391c6f769?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80',0,1,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescricaoCurta,DescricaoDetalhada" +
      ",Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Natural Simples','Sanduíche natural simples','Sanduíche em pão francês com tomate cereja e folhas verdes',7.50,'https://images.unsplash.com/photo-1509722747041-616f39b57569?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80','https://images.unsplash.com/photo-1509722747041-616f39b57569?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80',0,1,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
