using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTest.conta.src
{
    public abstract class Conta
    {   
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }


        public Conta()
        {
            
        }

        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
        virtual public double  Redimento( double saldo, double rendmento){

            return this.Saldo += saldo * rendmento;

        }
        
    }
}