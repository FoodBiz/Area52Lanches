using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Area52Lanches.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationPopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'images/cheese-salada2.jpg', 'images/cheese-salada1.jpeg', 0 , 'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, bacon, cheddar, alface e tomate','Pão de hambúrger com bacon crocante, queijo cheddar derretido, alface e tomate frescos',1, 'images/cheese-bacon1.jpg', 'images/cheese-bacon2.jpg', 0 , 'Cheese Bacon', 14.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, queijo, cebola roxa e molho especial','Pão de hambúrger com queijo derretido, cebola roxa caramelizada e molho especial da casa',1, 'images/cheese-onion1.jpg', 'images/cheese-onion2.jpg', 0 , 'Cheese Onion', 13.50)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, ovo, queijo e presunto','Pão de hambúrger com ovo frito, queijo derretido e presunto defumado',1, 'images/x-egg1.jpg', 'images/x-egg2.jpg', 1 , 'X-Egg', 11.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, frango grelhado, queijo, alface e tomate','Pão integral com filé de frango grelhado, queijo, alface e tomate frescos',1, 'images/chiken-burger1.jpg', 'images/chiken-burger2.jpg', 0 , 'Chicken Burger', 12.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pão, carne de soja, queijo, alface, tomate e molho especial','Pão integral com hambúrger de soja, queijo, alface, tomate e molho especial vegano',1, 'images/veggie-burger1.jpg', 'images/veggie-burger2.jpg', 0 , 'Veggie Burger', 13.00)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches WHERE Nome IN ('Cheese Salada', 'Cheese Bacon', 'Cheese Onion', 'X-Egg', 'Chicken Burger', 'Veggie Burger')");
        }
    }
}
