//Entrada: o nome, ano de nascimento, salário do funcionário e a % de reajuste.
//Saída: deve mostrar o nome do funcionário, idade e o valor do salário já calculado com o reajuste.

namespace reajusteMensal;

class reajusteMensal {

    public static void Main(string[] args) {

        Console.WriteLine("Qual é o seu nome?"); 
        string nome = Console.ReadLine();

        Console.WriteLine("Em que ano voce nasceu?");
        string anoDeNascimento = Console.ReadLine();
        int anoDeNascimento2 = int.Parse(anoDeNascimento);

        Console.WriteLine("Qual é o seu salário?");
        string valorDoSalario = Console.ReadLine();
        int valorDoSalario2 = int.Parse(valorDoSalario);

        Console.WriteLine("Qual é a porcentagem de reajuste do seu salario?");
        string porcentagemDeReajuste = Console.ReadLine();
        int porcentagemDeReajuste2 = int.Parse(porcentagemDeReajuste);

        int novoSalario = Calcular(1200, 5);
        int idade = CalcularIdade(2002);

        Console.WriteLine($"Olá {nome}, voce possui {idade} anos e seu salario com reajuste é de {novoSalario}");
        

    }

    public static int Calcular(int valorDoSalario2, int porcentagemDeReajuste2)
    {
        int resultado = valorDoSalario2 * porcentagemDeReajuste2 / 100;
        int novoSalario = valorDoSalario2 + resultado;
        return novoSalario;

    }

    public static int CalcularIdade(int anoDeNascimento2) {

        int idade = 2022 - anoDeNascimento2;
        return idade;
    }

}
