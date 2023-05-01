public class Program
{
    static void Main(string[]arg)
    {
            //chamar  o método
            gerarNumeros();


        //criação do metodo
        void gerarNumeros()
        {
            Random gerar = new Random();
            
            System.Console.WriteLine("\nGeração de números aleatórios:\n");

            //loop de iteração
            for(int i = 0; i < 5; i++)
            {
                System.Console.WriteLine($"\nNumeros Gerados = {gerar.Next(1,100)}");
            }

        }
        System.Console.WriteLine();
        System.Console.WriteLine($"\nPressione para 'ENTER' para sair do programa");
        Console.ReadKey();
    }
}