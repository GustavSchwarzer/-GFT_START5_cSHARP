using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTest.conta.src
{
    public class ContaCorrente : Conta
    {       public double rend { get; set; } 
            override public double Redimento  ( double saldo, double rendimento){

            return this.Saldo += saldo * rendimento;

        }

        public override string ToString()
        {   return
           "Titular: " + Titular +"\n"
           + "Saldo: " + Saldo;
        }
    }
}