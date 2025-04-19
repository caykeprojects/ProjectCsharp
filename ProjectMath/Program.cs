using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using ProjectMath;
class Program {
    static void Main(string[] args) {
        // Entrada de dados.

        Console.WriteLine("Digite o uma operaçao para ser efetuada : ");
        string opcao = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Digite o primeiro Valor : ");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite segundo Valor : ");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        CultureInfo Espaco = CultureInfo.InvariantCulture; 
        //Concatenação de Variáveis.
        switch (opcao) {

            case "+":
                //Realizar Soma 
                Soma objsoma = new Soma();
                int Resultado = objsoma.RealizarSoma(valor1, valor2);
                Console.WriteLine("O resultado Sera " + Resultado.ToString("F2", Espaco));
                break;

            case "-":
                //Realizar Subtração
                Subtracao objsubtracao = new Subtracao();
                 Resultado = objsubtracao.RealizarSubtracao(valor1, valor2);
                Console.WriteLine("O resultado Sera " + Resultado.ToString("F2", Espaco));
                break;
                //Realizar Multiplicação 
            case "*":   
                Multiplicacao objmultiplica = new Multiplicacao();
                objmultiplica = new Multiplicacao();
                Resultado = objmultiplica.RealizarMultiplicacao(valor1, valor2);
                 Console.WriteLine("O resultado Sera " + Resultado.ToString("F2", Espaco));
                break;
               //Realizar Divisão 
            case "/":
                Divisao objdivisao = new Divisao();
                objdivisao = new Divisao();
                Resultado = objdivisao.RealizarDivisao(valor1, valor2);
                Console.WriteLine("O resultado Sera " + Resultado.ToString("F2", Espaco));
                break;
                

        }
    Console.ReadKey();
      
        
    }
   
}