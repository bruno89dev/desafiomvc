using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioMVC.Migrations
{
    public partial class AddPopulaDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Receitas(Id, Nome, TempoDePreparo, ModoDePreparo, Status, UrlImagem) VALUES (3, 'Bolo de fubá', 45, '1. Com auxílio de uma peneira, coloque 2 xícaras de chá de fubá, 1 xícara de chá de farinha de trigo e 1 colher de sopa de fermento em pó em um recipiente. Misture e reserve; 2. No liquidificador, coloque 3 ovos, 1 xícara de chá de leite, 1 xícara de chá de óleo e 2 xícaras de chá de açúcar. Bata até ficar homogêneo; 3. Junte a mistura do liquidificador com os ingredientes peneirados e misture; 4. Transfira a massa para uma forma untada com manteiga e polvilhada com fubá; 5. Leve para assar em forno preaquecido a 180 graus Celsius por 30 minutos.', 1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQLJfUSqhkugh4r5uOp80ip8y5Os5q6dzOKMA&usqp=CAU')");
            
            migrationBuilder.Sql("INSERT INTO Receitas(Id, Nome, TempoDePreparo, ModoDePreparo, Status, UrlImagem) VALUES (4, 'Canjica', 40, '1. Deixe 500g de canjica de molho por 4 horas; 2. Após esse tempo, escorra a água e coloque a canjica numa panela de pressão cobrindo totalmente com água; 3. Adicione cravo e canela em rama a gosto e 1/2 xícara de chá de açúcar; 4. Leve ao fogo médio e deixe por 30 minutos após pegar pressão; 5. Apague o fogo, retire a pressão, adicione 1 litro de leite, 1 lata de leite condensado, 500mL leite de coco e coco ralado (a gosto), ferva em fogo baixo até reduzir o líquido pela metade e a canjica ficar cremosa.', 1, 'https://www.sabornamesa.com.br/media/k2/items/cache/8b73a42f665d6a2641fcaae19abdf883_XL.jpg')");
            
            migrationBuilder.Sql("INSERT INTO Receitas(Id, Nome, TempoDePreparo, ModoDePreparo, Status, UrlImagem) VALUES (6, 'Quentão de vinho', 20, '1. Misture em uma panela: 2 litros de vinho tinto suave, 200mL de água, 1/2 copo de cachaça, 1 e 1/2 copo de açúcar, 2 ramas de canela, cravo e gengibre a gosto; 2. Depois que levantar fervura, deixe por mais 10 minutos e está pronto;  3. Sirva a bebida quente.', 1, 'https://www.cooper.coop.br/image/3695/402/1/quentao-de-vinho.jpg')");
            
            migrationBuilder.Sql("INSERT INTO Receitas(Id, Nome, TempoDePreparo, ModoDePreparo, Status, UrlImagem) VALUES (7, 'Pinhão cozido', 60, '1. Lave bem 1Kg de pinhão em bastante água corrente;  2. Coloque os pinhões com 1 litro de água e 1/4 de xícara de sal na panela de pressão; 3. Leve ao fogo alto e assim que pegar pressão conte 40 minutos;  4. Remova a panela do fogo e deixe perder a pressão naturalmente; 5. Descasque e sirva o pinhão cozido ainda quente.', 1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRr30_Ydo20_-se-afzvatfsgYoXLeYybFLlA&usqp=CAU')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Receitas");
        }
    }
}
