
string nome = "";

Console.Write("*------------------------------------------------------*");
Console.WriteLine();
Console.WriteLine("|                    MENU DE OPÇÕES                  |");
Console.Write("*------------------------------------------------------*");
Console.WriteLine();
Console.WriteLine("|      0 - SAIR DO quiZ                              |");
Console.WriteLine();
Console.WriteLine("|      1 - INCIAR quiZ                               |");
Console.Write("*------------------------------------------------------*");
Console.WriteLine();
Console.Write("O QUE DESEJA FAZER ? ");
int resMenu = Convert.ToInt32(Console.ReadLine());
Console.Write(" ");

if (resMenu == 0)
{
    Console.WriteLine("Finalizando quiz");
    return;
}
else
{
    Console.Write("Digite seu nome:");
    nome = Convert.ToString(Console.ReadLine());
    Console.Clear();
}

string[] respostas = { "2", "4", "6","8","10","12","14", "16", "18", "20"};

string resposta1;
string resposta2;
string resposta3;
string resposta4;
string resposta5;
string resposta6;
string resposta7;
string resposta8;
string resposta9;
string resposta10;

int ponto = 0;

Console.Write("Quanto e 1 + 1 ?:");
resposta1 = Console.ReadLine();

if (resposta1 == respostas[0])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 1 + 1 ?:");
    resposta1 = Console.ReadLine();

    if (resposta1 != respostas[0])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}

Console.Write("Quanto e 2 + 2 ?:");
resposta2 = Console.ReadLine();

if (resposta2 == respostas[1])
{
    ponto += 10;
    Console.WriteLine("Correto");

}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 2 + 2 ?:");
    resposta2 = Console.ReadLine();

    if (resposta2 != respostas[1])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentatica");

    }
}

Console.Write("Quanto e 3 + 3 ?:");
resposta3 = Console.ReadLine();

if (resposta3 == respostas[2])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 3 + 3 ?:");
    resposta3 = Console.ReadLine();

    if (resposta3 != respostas[2])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentatica");

    }
}

Console.Write("Quanto e 4 + 4 ?:");
resposta4 = Console.ReadLine();

if (resposta4 == respostas[3])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 4 + 4 ?:");
    resposta4 = Console.ReadLine();

    if (resposta4 != respostas[3])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}


Console.Write("Quanto e 5 + 5 ?:");
resposta5 = Console.ReadLine();

if (resposta5 == respostas[4])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 5 + 5 ?:");
    resposta5 = Console.ReadLine();

    if (resposta5 != respostas[4])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}

Console.Write("Quanto e 6 + 6 ?:");
resposta6 = Console.ReadLine();

if (resposta6 == respostas[5])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 6 + 6 ?:");
    resposta6 = Console.ReadLine();

    if (resposta6 != respostas[5])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}

Console.Write("Quanto e 7 + 7 ?:");
resposta7 = Console.ReadLine();

if (resposta7 == respostas[6])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 7 + 7 ?:");
    resposta7 = Console.ReadLine();

    if (resposta7 != respostas[6])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}

Console.Write("Quanto e 8 + 8 ?:");
resposta8 = Console.ReadLine();

if (resposta8 == respostas[7])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 8 + 8 ?:");
    resposta4 = Console.ReadLine();

    if (resposta8 != respostas[7])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}

Console.Write("Quanto e 9 + 9 ?:");
resposta9 = Console.ReadLine();

if (resposta9 == respostas[8])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 9 + 9 ?:");
    resposta9 = Console.ReadLine();

    if (resposta9 != respostas[8])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}

Console.Write("Quanto e 10 + 10 ?:");
resposta10 = Console.ReadLine();

if (resposta10 == respostas[9])
{
    ponto += 10;
    Console.WriteLine("Correto");
}
else
{
    Console.Write("Tente novamente ");

    Console.Write("Quanto e 10 + 10 ?:");
    resposta10 = Console.ReadLine();

    if (resposta10 != respostas[9])
        Console.WriteLine("Errado, duas tentativas");
    else
    {
        ponto += 5;
        Console.WriteLine("Correto na segunda tentativa");

    }
}



Console.WriteLine(nome + " O seu resultado final é " + ponto);


if (ponto < 24)
{
    Console.WriteLine("PESSIMO");
}
if (ponto >= 25 && ponto <= 49)
{
    Console.WriteLine("REGULAR");
}
if (ponto >= 50 && ponto <= 74)
{
    Console.WriteLine("BOM");
}
if (ponto >= 75 && ponto < 99)
{
    Console.WriteLine("ÓTIMO");
}
if(ponto == 100)
{
    Console.WriteLine("EXCELENTE");
}

