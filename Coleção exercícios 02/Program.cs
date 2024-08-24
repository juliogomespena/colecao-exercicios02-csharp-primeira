/* Exercícios */

//Exercício 01

//void operacoesBasicas(double a, double b)
//{

//    double somar = a + b;
//    double subtrair = a - b;
//    double multiplicar = a * b;
//    double dividir = a / b;

//    Console.WriteLine($"{a} + {b} = {somar}");
//    Console.WriteLine($"{a} - {b} = {subtrair}");
//    Console.WriteLine($"{a} * {b} = {multiplicar}");
//    Console.WriteLine($"{a} / {b} = {dividir}");

//}

//operacoesBasicas(1.5, 1.5);



// Exercícios 02 e 03

//void FuncaoBandas()
//{

//    List<string> bandas = new List<string>();
//    string banda;

//    while (true)
//    {

//        Console.WriteLine("Digite suas bandas favoritas.\nAo terminar digite 'sair'.");
//        banda = Console.ReadLine()!;
//        banda = banda.ToUpper();

//        if (banda == "SAIR")
//        {
//            break;
//        }
//        else
//        {
//            bandas.Add(banda);
//        }

//    }

//    Console.WriteLine("\nBandas adicionadas: ");

//    foreach (string exibirBandas in bandas)
//    {

//        Console.WriteLine(exibirBandas);

//    }
//}

//FuncaoBandas();



//Exercício 04

//List<int> numeros = new List<int> {1, 2, 3, 4, 5};

//void SomarInteiros(List<int> numeros)
//{

//    int somarInteiros = 0;

//    foreach (int numero in numeros)
//    {
//        somarInteiros += numero;
//    }

//    Console.WriteLine(somarInteiros);

//}

//SomarInteiros(numeros);