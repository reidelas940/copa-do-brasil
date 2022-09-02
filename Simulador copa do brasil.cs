int placar01 = 0, placar02 = 0,
    agregados01 = 0, agregados02 = 0;

String semifinal01, semifinal02;

Console.WriteLine("Simulador da Copa do Brasil");
Console.WriteLine("Semifinal 01");
Console.WriteLine("SPFC X Flamengo");

Console.WriteLine("Insira a quantida de" + "gols feitos por SPFC no Primeiro jogo");
placar01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a quantida de" + "gols feitos por Flamengo no Primeiro jogo");
placar02 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Resultado do jogo de Ida");
Console.WriteLine(" SPFC {0}  x  {1} Flamengo", placar01, placar02);
Console.ReadKey();
Console.Clear();

agregados01 = placar01;
agregados02 = placar02;

Console.WriteLine("Simulador da Copa do Brasil");
Console.WriteLine("Semifinal 01");
Console.WriteLine("SPFC X Flamengo");

Console.WriteLine("Insira a quantida de" + "gols feitos por SPFC no Segundo jogo");
placar01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a quantida de" + "gols feitos por Flamengo no Segundo jogo");
placar02 = Convert.ToInt16(Console.ReadLine());

Console.Clear();
Console.WriteLine("Resultado do jogo de Volta");
Console.WriteLine(" SPFC {0}  x  {1} Flamengo", placar01, placar02);
Console.ReadKey();
Console.Clear();

Console.WriteLine("Placar Agregado");
placar01 = placar01 + agregados01;
placar02 = placar02 + agregados02;
Console.WriteLine(" SPFC {0}  x  {1} Flamengo", placar01, placar02);
Console.ReadKey();
Console.Clear();

if (placar01 > placar02)
{
    Console.WriteLine("SPFC PASSOU!!");
    semifinal01 = "SPFC";
}
else if (placar01 < placar02)
{
    Console.WriteLine("Flamengo PASSOU!!");
    semifinal01 = "Flamengo";
}
else
{

    Console.WriteLine(" Qual time classificou SPFC/Flamengo");
    semifinal01 = Console.ReadLine();
}
Console.ReadKey();
Console.Clear();
Console.WriteLine("Simulador da Copa do Brasil");
Console.WriteLine("Semifinal 02");
Console.WriteLine("Corinthias X Fluminense");

Console.WriteLine("Insira a quantida de" + "gols feitos por Corinthias no Primeiro jogo");
placar01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira a quantida de" + "gols feitos por Fluminese no Primeiro jogo");
placar02 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Resultado do jogo de Ida");
Console.WriteLine(" Corinthias {0}  x  {1} Fluminense", placar01, placar02);
Console.ReadKey();
Console.Clear();

agregados01 = placar01;
agregados02 = placar02;

Console.WriteLine("Simulador da Copa do Brasil");
Console.WriteLine("Semifinal 02");
Console.WriteLine("Corinthias X Fluminense");

Console.WriteLine("Insira a quantida de" + "gols feitos por Corinthias no Segundo jogo");
placar01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira a quantida de" + "gols feitos por Fluminense no Segundo jogo");
placar02 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Resultado do jogo de Volta");
Console.WriteLine("Corinthias {0}  x  {1} Fluminense", placar01, placar02);
Console.ReadKey();

Console.Clear();
Console.WriteLine("Placar Agregado");
placar01 = placar01 + agregados01;
placar02 = placar02 + agregados02;
Console.WriteLine(" Corinthias {0}  x  {1} Fluminense", placar01, placar02);
Console.ReadKey();
Console.Clear();

if (placar01 > placar02)
{
    Console.WriteLine("Corinthias PASSOU!!");
    semifinal02 = "Corinthias";
}
else if (placar01 < placar02)
{
    Console.WriteLine("Fluminense PASSOU!!");
    semifinal02 = "Fluminense";
}
else
{

    Console.WriteLine(" Qual time classificou Corinthias/Fluminense");
    semifinal02 = Console.ReadLine();
}
Console.ReadKey();
Console.Clear();
Console.WriteLine("Simulador da Copa do Brasil");
Console.WriteLine("Final");
Console.WriteLine("{0} x {1}", semifinal01, semifinal02);

Console.WriteLine("Insira a quantida de" + "gols do {0} no Primeiro jogo", semifinal01);
placar01 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a quantida de" + "gols do {0} no Primeiro jogo", semifinal02);
placar02 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Resultado do jogo de Ida");
Console.WriteLine("  {0} {1} x {2} {3} ", semifinal01, placar01, placar02, semifinal02);
Console.ReadKey();
Console.Clear();

placar01 = agregados01;
placar02 = agregados02;

Console.WriteLine("Simulador da Copa do Brasil");
Console.WriteLine("Final");
Console.WriteLine("{0} x {1}", semifinal01, semifinal02);

Console.WriteLine("Insira a quantida de" + "gols do {0} no Primeiro jogo", semifinal01);
placar01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a quantida de" + "gols feitos di {0} no Primeiro jogo", semifinal02);
placar02 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Resultado do jogo de Ida");
Console.WriteLine("  {0} {1} x {2} {3} ", semifinal01, placar01, placar02, semifinal02);
Console.ReadKey();

Console.Clear();
Console.WriteLine("Placar Agregado");
Console.WriteLine("  {0} {1} x {2} {3} ", semifinal01, placar01, placar02, semifinal02);
Console.Clear();


if (placar01 > placar02)
{
    Console.WriteLine("O CAMPEÃO FOI: {0}", semifinal01);
    Console.ReadKey();
}
else if (placar01 < placar02)
{
    Console.WriteLine("O CAMPEÃO FOI: {0}", semifinal02);
    Console.ReadKey();
}
else
{
    Console.WriteLine("O CAMPEÃO FOI: {0}/{1}", semifinal01, semifinal02);
    Console.ReadKey();
}
