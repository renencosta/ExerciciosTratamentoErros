//1. Entrada Segura de Números**

//Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve usar `try/catch` para garantir que o usuário insira um número válido.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)

Console.WriteLine("Digite um número: ");
try
{
    int num = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Apenas números são aceitos.");
}

//2. Divisão Segura**

//Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use `try/catch` para evitar divisão por zero e entrada inválida.

//**Erros a serem tratados:**

//-Usuário digitar um valor não numérico. (`FormatException`)
//- Tentativa de divisão por zero. (`DivideByZeroException`)

try
{
    Console.WriteLine("Informe o primeiro número:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine(num1 / num2);
}
catch (FormatException)
{
    Console.WriteLine("Apenas números são aceitos.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Não é possível realizar divisões por 0.");
}

//3. Validação de Idade**

//Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use `try/catch` para evitar entradas inválidas.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)
//- Usuário inserir um número muito grande. (`OverflowException`)

try
{
    Console.WriteLine("Informe a sua idade");
    int idade = int.Parse(Console.ReadLine());
    if (idade < 0 || idade > 129)
    {
        throw new ArgumentOutOfRangeException("Idade não permitida.");
    }
    else if (idade >= 18)
    {
        Console.WriteLine("Maior de idade");
    }
    else
    {
        Console.WriteLine("Menor de idade");
    }
}
catch (FormatException)
{
    Console.WriteLine("Apenas números são aceitos.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Idade não permitida.");
}





