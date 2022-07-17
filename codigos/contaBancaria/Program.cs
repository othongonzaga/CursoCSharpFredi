class Program{
    static void Main(){
        ConsoleRegistrar registrar = new ConsoleRegistrar();
        ContaBancaria conta1 = new ContaBancaria("Othon", 1000, registrar);
        ContaBancaria conta2 = new ContaBancaria("Luana", 500, registrar);
        var conta3 = new ContaBancaria("Neymar", 2000, registrar);

        List<ContaBancaria> contas = new List<ContaBancaria>(){
            conta1, conta2, conta3
        };
        contas.Remove(conta3);

        conta1.Deposito(-100);
        conta2.Deposito(200);

        Console.WriteLine($"Seu saldo é de: {conta2.Saldo}.");
    }
}

class ConsoleRegistrar : IRegistrar
{
    public void Registro(string mensagem)
    {
        Console.WriteLine($"Registrar: {mensagem}");
    }
}

interface IRegistrar{
    void Registro(string mensagem);
}
class ContaBancaria
{
    private string nome;
    private decimal saldo;
    private readonly IRegistrar registrar;

    public decimal Saldo { 
        get{return saldo;} 
        private set{saldo = value;}
        }

    public ContaBancaria(string nome, decimal saldo, IRegistrar registrar){
        if(string.IsNullOrWhiteSpace(nome)){
            throw new ArgumentException("Nome inválido", nameof(nome));
        }
        if(saldo < 0){
            throw new Exception("Saldo não pode ser negativo.");
        }

        this.nome = nome;
        this.saldo = saldo;
        this.registrar = registrar;
    }

    public void Deposito(decimal quantia){
        if(quantia <= 0){
            registrar.Registro($"Não é possível depositar {quantia} na conta de {nome}.");
            return;
        }

        registrar.Registro($"Olá, {nome}, depósito de {quantia} realizado!");
        saldo += quantia;
    }
}