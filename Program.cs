



Console.WriteLine(@$" 
|--------------------------------------------------------|
|Bem vindo ao Sistema, selecione uma das opções a seguir |
|                                                        |
| Coca-Cola equivale ao número 1                         |
|                                                        |
| Pepsi  equivale ao número 2                            |
|                                                        |
| Fanta   equivale ao número 3                           |
|                                                        |
| Monster  equivale ao número 4                          |
|--------------------------------------------------------|

");

int escolha = int.Parse(Console.ReadLine()!);

switch (escolha)
{
    case 1:
        Console.WriteLine($"A bebida escolhida foi Coca-Cola");
        Console.WriteLine($"A bebida vai acompanhar gelo? responda S ou N ");
        char resposta = char.Parse(Console.ReadLine()!.ToUpper());

        if (resposta == 'S')
        {
            Console.WriteLine($"A Bebida acompanhara gelo");

        }
        else if (resposta == 'N')
        {
            Console.WriteLine($"A Bebida nao vira com gelo");

        }

        else {   
        Console.WriteLine($"Opção inválida");
          }

        break;

        case 2:
        Console.WriteLine($"A bebida escolhida foi Pepsi");
        Console.WriteLine($"A bebida vai acompanhar gelo? responda S ou N ");
        char resposta2 = char.Parse(Console.ReadLine()!.ToUpper());

        if (resposta2 == 'S')
        {
            Console.WriteLine($"A Bebida acompanhara gelo");

        }
          else if (resposta2 == 'N')
        {
            Console.WriteLine($"A Bebida nao vira com gelo");

        }

          else {   
        Console.WriteLine($"Opção inválida");
          }

break;
        case 3:
        Console.WriteLine($"A bebida escolhida foi Fanta");
        Console.WriteLine($"A bebida vai acompanhar gelo? responda S ou N ");
        char resposta3 = char.Parse(Console.ReadLine()!.ToUpper());

        if (resposta3 == 'S')
        {
            Console.WriteLine($"A Bebida acompanhara gelo");

        }
          else if (resposta3 == 'N')
        {
            Console.WriteLine($"A Bebida nao vira com gelo");

        }

          else {   
        Console.WriteLine($"Opção inválida");
          }
        
        break;

case 4:
        Console.WriteLine($"A bebida escolhida foi Monster");
        Console.WriteLine($"A bebida vai acompanhar gelo? responda S ou N ");
        char resposta4 = char.Parse(Console.ReadLine()!.ToUpper());

        if (resposta4 == 'S')
        {
            Console.WriteLine($"A Bebida acompanhara gelo");

        }
          else if (resposta4 == 'N')
        {
            Console.WriteLine($"A Bebida nao vira com gelo");

        }

          else {   
        Console.WriteLine($"Opção inválida");
          }
          
        break;

       
    default:
    Console.WriteLine($"Numero invalido !");
    
        break;
}














