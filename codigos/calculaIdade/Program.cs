Console.Write("Digite seu nome: ");
String nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}!");

Console.Write("Digite o ano de nascimento: ");
int ano = int.Parse(Console.ReadLine());
int idade = 2022 - ano;

Console.WriteLine($"Você tem {idade} anos.");

if(idade >= 18){
    Console.WriteLine("Você é maior de idade");
}
else{
    Console.WriteLine("Você é menor de idade");
}