using System;

namespace DDD.Domain.Entities
{
    public class ContaCorrente : BaseEntity
    {
        public double Limite_credito { get; set; }
        public double Saldo { get; set; }   

        public void Debitar(double valor){
            if(valor > (this.Limite_credito+this.Saldo)) {
                throw new Exception("Saldo insuficiente!");
            } else {
                if(valor <= this.Saldo) {
                    this.Saldo -= valor;
                } else {
                    this.Saldo -= valor;
                    this.Limite_credito -= this.Saldo;
                }
            }
        } 

        public void Creditar(double valor){
            this.Saldo += valor;
            if(valor > 50000){
                Console.WriteLine("Notificação para COAF:");
                Console.WriteLine("Movimentação maior que R$50.000,00.");
            } 
        }
    }
}