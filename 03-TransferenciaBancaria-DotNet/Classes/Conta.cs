using System;

namespace pooDotNet
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }        
        private double Saldo { get; set; } // private para que não seja alterado dentro do código 
        private double Credito { get; set; } // encapsulamento
        private string Nome { get; set; } 
   

        public Conta(TipoConta tipoConta, double saldo,double credito, string nome) //Construtor
        {   
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Sacar(double valorSaque)  // métodos, ações da Classe conta
        { // boleano, retorna true se der certo
            //Validação do saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.Saldo -= valorSaque; 

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString() //override, sobrescreve da classe de origem
        {
            string retorno = "";
            retorno += "Tipo de Conta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito + " | ";
            return retorno;
        }
    }
}