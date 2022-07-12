
using System.Collections.Generic;

List<int> ages = new List<int>();
List<double> weights = new List<double>();

System.Console.WriteLine("Bem vindo ao sistema de cáculo de médias, hoje vamos calcular a medias dos pesos!");
System.Console.Write("Por favor informe a quantidade das pessoas que vamos calcular:");
int quantity = int.Parse(Console.ReadLine());
string name = null; int age = 0;double weight = 0;
for (int i = 0; i<quantity; i++)
{


        System.Console.WriteLine("Por favor, informe a idade: ");
        age = int.Parse(Console.ReadLine());
        ages.Add(age);
        System.Console.WriteLine("Por favor informe o peso: ");
        weight = double.Parse(Console.ReadLine());
        weights.Add(weight);

         
}
        if(age >= 1 && age <= 10)
         { int totalAge = 0;double totalWeight = 0;double totalMedia =0;
            for (int j = 0; j<quantity; j++)
                {
                
                   
                    totalAge = totalAge + ages[j] ;

                    
                    totalWeight = totalWeight + weights[j];

                     totalMedia = (totalWeight/totalAge);
                    System.Console.WriteLine("A média do peso da faixa etária de 1 a 10 anos é: " + totalMedia);
                }
         }

         if(age >= 11 && age <= 20)
         { int totalAge = 0; double totalWeight = 0;double totalMedia;
            for (int k = 0; k<quantity; k++)
                {
                
                   
                    totalAge = totalAge + ages[k] ;

                   
                    totalWeight = totalWeight + weights[k];

                    
                }totalMedia = (totalWeight/weights.Count());
                    System.Console.WriteLine("A média do peso da faixa etária de 11 a 20 anos é: " + totalMedia);
         }

             if(age >= 21 && age <= 30)
             {int totalAge = 0;double totalMedia =0;double totalWeight= 0;
                for (int w = 0; w<quantity; w++)
                    {
                    
                        
                        totalAge = totalAge + ages[w] ;
                        totalWeight = totalWeight + weights[w];

                       
                    }
                       totalMedia = (totalWeight/weights.Count());
                        System.Console.WriteLine("A média do peso da faixa etária de 21 a 30 anos é: " + totalMedia);
             }
             if(age >30)
             {int totalAge = 0;double totalMedia =0;double totalWeight= 0;
                for (int w = 0; w<quantity; w++)
                    {
                    
                        
                        totalAge = totalAge + ages[w] ;
                        totalWeight = totalWeight + weights[w];

                       
                    }
                       totalMedia = (totalWeight/weights.Count());
                        System.Console.WriteLine("A média do peso da faixa etária mais de 30 anos  é: " + totalMedia);
             }

    




