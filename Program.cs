namespace Portifolio;

class Program
{
    static void Main(string[] args)
{

int op = 0;
 Console.WriteLine("Digite o Exercicios: ");
 op = Convert.ToInt32(Console.ReadLine());

switch (op)
{
    case 1:
     {
        // Dados
        decimal [] salarios = new decimal [10];
        decimal salarioMai = 0;


for (int i = 0; i < 10; i++)
{
System.Console.WriteLine("Digite o salario");
salarios[i] = Convert.ToDecimal(Console.ReadLine());

}

foreach (decimal salario in salarios)
{
 
if (salario > salarioMai)
{
salarioMai = salario;
}
}
Console.WriteLine("Maior salario: " + salarioMai);
}
    break;

    ///################### EXERCICIO 2 #######################

    case 2:
    {
        decimal n = 3m;
    decimal[] salarios = new decimal[3];

    for(int i = 0; i < 3; i++)
    {
            Console.WriteLine($"Digite o {i + 1}° salario ");
        salarios[i] = Convert.ToDecimal(Console.ReadLine());

    }

    for(int i = 0; i < 3; i++)
    {
        if (salarios[i] < 1000)
        {
        decimal atual = salarios[i] * 0.10m;
        salarios[i] = salarios[i] + atual;
        }        
    }
     
     Console.WriteLine("Salario com aumentos");
     for (int i = 0; i< 5; i++)
     {
       Console.WriteLine($"Salario {i + 1}°: R$ {salarios[i]:F2}" );
     }  
    }
    break; 

    //################# EXERCICIO 3 #####################

    case 3:
    {
    Console.WriteLine("Digite quantos valores deseja:");
    int n = Convert.ToInt32(Console.ReadLine());  
    int [] valores = new int [n];
    int soma = 0, k = 0;         

    for(int i = 0; i < n; i++)
    {
    Console.WriteLine("Digite os valores:");
    valores[i] = Convert.ToInt32(Console.ReadLine());
    }    

    for(int i = 0; i < n; i++)
    {
        soma += valores[i];
        k = soma / n;
    }
      Console.WriteLine($"A media dos valores é: {k}");
    }
    break;

//###################  EXERCICIO 4 ########################

    case 4:
    {
        System.Console.WriteLine("DIGITE QUANTOS ALUNOS TEM:");
        int alunos = Convert.ToInt32(Console.ReadLine());
        string  [] name = new string[alunos];
        decimal [] nota1 = new decimal[alunos];
        decimal [] nota2 = new decimal[alunos];
        decimal [] media = new decimal[alunos];


        for (int i = 0; i < alunos; i++)
        {
            System.Console.WriteLine("Digite o nome do Aluno: ");
           name[i] = Console.ReadLine();

        System.Console.WriteLine("Digite a 1° Nota:");      
        nota1[i] = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a 2° Nota:");        
         nota2[i] = Convert.ToDecimal(Console.ReadLine());        

        }

        for (int i = 0; i < alunos; i++)
        {
        media[i] = nota1[i] + nota2[i];
         media[i] = media[i] / 2;
        }

        for (int i = 0; i < alunos; i++)
        {
             System.Console.WriteLine($"A média do {name[i]} é: " + media[i]);

        }
    }
    break;

}
}
}
