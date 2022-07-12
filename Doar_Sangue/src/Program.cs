using System;

Console.WriteLine("Por favor informe e sua idade:");

int idade = int.Parse(Console.ReadLine());

if(idade >= 18 && idade <= 67){
    System.Console.WriteLine("Parabéns, você esta apto para doação de sangue!");
}
else{
    System.Console.WriteLine("Infelizmente você não é apto para a doação de sangue");
}