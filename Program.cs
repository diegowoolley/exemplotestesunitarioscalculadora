using Calculadora;
class Program
{
    static void Main(string[] args)
    {
        calculadora calc = new calculadora();

        Console.WriteLine("Digite dois números:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtrair");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        int opcao = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;
        switch (opcao)
        {
            case 1:
                resultado = calc.Somar(n1, n2);
                break;
            case 2:
                resultado = calc.Subtrair(n1, n2);
                break;
            case 3:
                resultado = calc.Multiplicar(n1, n2);
                break;
            case 4:
                resultado = calc.Dividir(n1, n2);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}


