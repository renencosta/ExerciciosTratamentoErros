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
        throw new OverflowException("Idade não permitida.");
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
catch (OverflowException)
{
    Console.WriteLine("Idade não permitida.");
}

//4. Contagem Progressiva Segura**

//Peça ao usuário para inserir um número inteiro positivo. O programa deve contar de 1 até esse número. Se a entrada for inválida ou negativa, exiba um erro.

//**Erros a serem tratados:**

/*-Usuário digitar um texto ao invés de um número. (`FormatException`)
- Usuário inserir um número muito grande. (`OverflowException`)
- Usuário inserir um número negativo. (`ArgumentOutOfRangeException`)
*/

try
{
    Console.WriteLine("Digite um número inteiro positivo: ");
    int num3 = int.Parse(Console.ReadLine());

    if (num3 < 0)
    {
        throw new ArgumentOutOfRangeException("Favor informar um número positivo.");
    }

    for (int i = 1; i <= num3; i++)
    {
        Console.WriteLine(i);
    }
}
catch (FormatException)
{
    Console.WriteLine("Apenas números são aceitos.");
}
catch (OverflowException)
{
    Console.WriteLine("Número muito grande.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Favor informar um número positivo.");
}

/*5. Soma de Números**

Crie um programa que peça ao usuário para inserir 5 números e some-os. Use `try/catch` para lidar com entradas inválidas.

**Erros a serem tratados:**

-Usuário digitar um valor não numérico. (`FormatException`)
- Usuário inserir um número negativo. (`ArgumentOutOfRangeException`)
*/

try
{
    int somaNumeros = 0;
    int num4 = 0;
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Informe um número: ");
        num4 = int.Parse(Console.ReadLine());
        if(num4 < 0)
        {
            throw new ArgumentOutOfRangeException("Informe apenas números positivos.");
        }
        else
        {
            somaNumeros += num4;
        }
        
    }
    Console.WriteLine(somaNumeros);
}
catch (FormatException)
{
    Console.WriteLine("Informe apenas números.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Informe apenas números positivos.");
}

/*### **6. Validação de Senha**

Crie um programa que solicite ao usuário uma senha e permita até 3 tentativas. Caso a senha esteja errada, informe quantas tentativas restam.

**Erros a serem tratados:**

-Usuário digitar um valor nulo ou vazio. (`ArgumentNullException`)
*/

try
{
    int tentativas = 3;
    int senha = 1234;
    int senhaDigitada = 0;
   
    do
    {
        Console.WriteLine("Digite a senha: ");
        senhaDigitada = int.Parse(Console.ReadLine());

        if (senhaDigitada != senha)
        {
            
            Console.WriteLine($"Senha incorreta. Você tem {tentativas -1} tentativas.");
            tentativas--;
        }
        else
        {
            Console.WriteLine("Acesso liberado");
        }

        if (tentativas == 0)
        {
            Console.WriteLine("Acesso negado.");
        }

    } while (tentativas > 0 && senhaDigitada != senha);
    
}
catch (ArgumentNullException)
{
    Console.WriteLine("Senha não aceita espaço em branco.");
}