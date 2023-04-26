// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using exercicio_25._04;

Celular x = new Celular();

Console.WriteLine(@$"
Informe a cor do celular: ");
x.cor = Console.ReadLine();

Console.WriteLine(@$"
Informe o modelo do celular: ");
x.modelo = Console.ReadLine();

Console.WriteLine(@$"
Informe o tamanho do celular: ");
x.tamanho = Console.ReadLine();

Console.WriteLine(@$"
O celular esta ligado?(s/n): ");
string resposta = Console.ReadLine();

if(resposta == "s")
{
    x.ligado = true;
}
else
{
    x.ligado = false;
}

Console.WriteLine(@$"
1 - Ligar 
2 - Desligar 
3 - Fazer ligação
4 - Enviar mensagem
");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        x.Ligar();
        break;
    case "2":
        x.Deslisgar();
        break;
    case "3":
        x.FazerLigacao();
        break;
    case "4":
        x.EnviarMensagem();
        break;
    default:
        Console.WriteLine($"Opção inválida !");
        break;
}




