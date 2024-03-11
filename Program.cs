
using System;


class Program
{
    

    // Código escrito apenas para testes de Integração e Deploy Continuo. 
    static void Main(string[] args)
    {
        Console.WriteLine("Operacoes");


     
        int resultadoAdicao = Adicao(5, 3);
        Console.WriteLine($"5 + 3 = {resultadoAdicao}");

     
        int resultadoSubtracao = Subtracao(10, 7);
        Console.WriteLine($"10 - 7 = {resultadoSubtracao}");

       
        int resultadoMultiplicacao = Multiplicacao(4, 6);
        Console.WriteLine($"4 * 6 = {resultadoMultiplicacao}");

     
        double resultadoDivisao = Divisao(20, 5);
        Console.WriteLine($"20 / 5 = {resultadoDivisao}");

        Console.ReadLine();


        
    }
    public static int Adicao(int a, int b)
    {

        return a + b;
    }


    public static int Subtracao(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicacao(int a, int b)
    {
        return a * b;
    }

    public static int Divisao(int a, int b)
    {
        if (b == 0)
            return 0;
        else
        {
            return a / b;
        }
    }
}