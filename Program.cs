
//Atividade de cadastro de pessoas
string nome, endereco, telefone, email, menu;
int idade;
bool looping = true;



while (looping)
{
    Console.WriteLine("Escreva seu nome");
    nome = Console.ReadLine();

    if (nome => 3)
    {
        Console.WriteLine("Nome cadastrado com sucesso!");
        looping = false;
    }
    else
    {
        Console.WriteLine("Seu nome está inválido, escreva-o corretamente");
    }
}
Console.WriteLine(" ");
Console.WriteLine("Digite sua idade");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Digite a cidade onde mora");
endereco = Console.ReadLine();
Console.WriteLine(" ");

while (looping)
{
    Console.WriteLine("Escreva seu email");
    email = Console.ReadLine();

    if (email.Contains("@") && email.Contains(".com") || email.Contains(".com.br"))
    {
        Console.WriteLine("Seu e-mail é válido");
        looping = false;
    }
    else
    {
        Console.WriteLine("Seu e-mail está inválido, escreva-o corretamente");
    }
}
while (looping)
{
    Console.WriteLine("Escreva seu Telefone com DDD");
    telefone = Console.ReadLine();

    if (telefone.Length > 12)
    {
        Console.WriteLine("Seu telefone ultrapassou os limites de dígitos");
    }
    else
        looping = false;
}

Console.WriteLine("Cadastro completo!!!! \n Escolha uma das opções com seus respectivos números:");
Console.WriteLine(" 1 - Gerador de número aleatório \n 2 - Conversor binário ");
menu = Console.ReadLine();

switch (menu)
{
    case "1":
        Random randNum = new Random();
        randNum.Next(0, 100);
        break;

    case "2":
        Console.WriteLine("abublé");
        break;

}






