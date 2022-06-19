using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET_Lanches.Migrations
{
    public partial class AdicionarLanches20220618 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            {
                migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescricaoCurta,DescricaoDetalhada" +
          ",Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Queijo simples','Sanduíche de queijo','Sanduíche de queijo com milho, acompanha maionese caseira',7.50,'https://images.unsplash.com/photo-1528736235302-52922df5c122?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1254&q=80','https://images.unsplash.com/photo-1528736235302-52922df5c122?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1254&q=80',1,1,2)");
                migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescricaoCurta,DescricaoDetalhada" +
          ",Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Moda da casa','Sanduíche de mortadela','Sanduíche de mortadela com queijo muçarela e alface',8.00,'https://images.unsplash.com/photo-1521390188846-e2a3a97453a0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80','https://images.unsplash.com/photo-1521390188846-e2a3a97453a0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80',0,1,1)");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
