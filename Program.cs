
internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Write("Resposta Questão 1 - ");
        Questao1();
        Console.WriteLine();

        Console.WriteLine("Resposta Questão 2 - ");
        Questao2();

        Console.WriteLine();
        Questao3();
        Console.WriteLine();

        Console.WriteLine("Resposta Questão 4 - ");
        Questao4();
        Console.WriteLine();
        
        Console.WriteLine("Resposta Questão 5 - ");
        Questao5();
    }

    static void Questao1(){
        //Variáveis para o laço de repetição
        int indice = 13;
        int soma = 0;
        int k = 0;
        //--------------------------------------//
        
        //Laço de repetição
        while (k < indice)
        {
            k = k+1;
            soma = soma + k;
        }
        //--------------------------------------//
        
        //Resultado
        Console.Write($"O resultado é: {soma}");
        //--------------------------------------//
        
    }

    static void Questao2(){

        //Variáveis para o laço de repetição
        int num1 = 0;
        int num2 = 1;
        int soma = 1;
        int cont = 0;
        //--------------------------------------//

        //Variáveis para o usuário digitar os números de entrada
        Console.WriteLine("Digite quantos números da sequência quer mostrar");
        int indice = int.Parse(Console.ReadLine());
        Console.WriteLine($"Serão {indice} números na sequência! ");

        Console.WriteLine("Digite o número que quer conferir dentro da sequência!");
        int usuNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Esses são os primeiros {indice} números da sequência de Fibonacci");
        //--------------------------------------//

        //Array que armazena os primeiros números da sequência de Fibonacci
        int[] fibosequel = new int [indice];
        //--------------------------------------//

        //Laço de repetição da sequência de Fibonacci
        while ( cont < indice)
        {   
            
            Console.WriteLine(num1);
            fibosequel[cont] = num1;
            soma = num2 + num1;
            num1 = num2;
            num2 = soma;
            cont++;
            
            

        }
        //--------------------------------------//

        //Método de verificação para saber se o número está dentro da sequência de Fibonacci(Array)
        

        for(int j = 0; j <= fibosequel.Length; j++){


            if(fibosequel.Contains(usuNumber)){
                Console.WriteLine($"Seu número '{usuNumber}' está na sequência!!!");
                break;
            }
            else{
                Console.WriteLine($"Infelizmente seu número '{usuNumber}' não está na sequência.");
                break;
            }


        }
        //--------------------------------------//
    }    
    static void Questao3(){
        //Infelizmente a única que não resolvi...

        Console.WriteLine("Essa aqui eu não fiz infelizmente...");
        Console.WriteLine("Mas quero muito essa vaga!");
        Console.WriteLine("Por favor! Reconsiderem olhando as outras Perguntas!");
        
        
        //--------------------------------------//

        }

    static void Questao4(){
            //Dados da questão em variáveis
            float porcSP = 67836.43f;
            float porcRJ = 36678.66f;
            float porcMG = 29229.88f;
            float porcES = 27165.48f;
            float porcOU = 19849.53f;
            //--------------------------------------//

            //Variáveis para o laço de repetição
            float[] empMensal = {porcSP, porcRJ, porcMG, porcES, porcOU};

            float perc100 = empMensal.Sum();

            float[] emptotal = new float[5];
            //--------------------------------------//
            
            //Laço de repetição para calcular a porcentagem
            for (int cont = 0; cont < empMensal.Length; cont++){
                float porcentagem = (100 * empMensal[cont]) / perc100;
                emptotal[cont] =  porcentagem;
                Console.WriteLine($"A porcentagem do {cont+1}° é: {emptotal[cont]} % ");
            }
            //--------------------------------------//    
    }

    static void Questao5(){
        //Variáveis para o laço de repetição
        Console.WriteLine("Por favor, digite a palavra que será invertida!");
        string silaba = Console.ReadLine() ;
        string frase = "" ;
        //--------------------------------------//

        //Laço de repetição para inverter a String

        for (int i = silaba.Length - 1; i >=0; i--){
            frase += silaba[i];
        }
        Console.WriteLine($"Frase invertida '{frase}'");
        //--------------------------------------//
    }
}

       
        
    
