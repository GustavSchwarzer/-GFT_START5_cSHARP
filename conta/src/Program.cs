using FinalTest.conta.src;
ContaCorrente corrente = new ContaCorrente();
ContaPoupanca poupanca = new ContaPoupanca();

System.Console.WriteLine("Nome do ttular:");
string name = Console.ReadLine();
System.Console.WriteLine("Informe o numero da conta:");
int numeroConta = int.Parse(Console.ReadLine());
System.Console.WriteLine("Inform o saldo da conta:");
double saldo = double.Parse(Console.ReadLine());

System.Console.WriteLine("Qual o tipo de conta? correte/poupanca");
string cont = Console.ReadLine();

if(cont == "correte"){
    corrente.Redimento(saldo,0.03);
}
else{
    poupanca.Redimento(saldo,0.05);
}

