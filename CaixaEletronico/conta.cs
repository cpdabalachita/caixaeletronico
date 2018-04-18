using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class conta
    {
        public string agencia;
        public string contacorrente;
        public double saldo;
        public Cliente cliente;


        public double CalculaRendimentoAnual(double jurosmensal)

        {
            // passando o saldo atual para uma variavel, porque vamos manipular ela mas nao queremos mudar o saldo real do titular
            // essa variavel eh privada apenas aqui dentro, para projetar um valor, mas nao precisamos dela depois. 
            double saldoNaqueleMes = this.saldo;

            //calculando saldo supondo 0,7% ao mes durante 12 meses
            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * (1+jurosmensal);
            }
            // saiu do for com o saldo no final do ano
        
            // pra saber o rendimento, tiramos a diferenca do saldo inicial e o saldo suposto final
            // criamos uma variavel privada que vai ser a entregue como retorno. 
            // essa variavel so existe aqui dentro mas sera a saida desta funcao 
            double rendimento = saldoNaqueleMes - this.saldo;

            //return saldoNaqueleMes;
            return rendimento;

        }

        public bool Saca(double valor)
        {
            if (valor > 0 && valor < this.saldo && this.cliente.EhMaiordeIdade() )
            {
                this.saldo -= valor;
                return true;
            }
            else { return false; }
        }

        public bool Deposita(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            else
            {
                //aqui viria log de erro
                return false;
            }
                
        }

        //transfere de quem chama (this) para a conta de destino
        public void transfere(double valor, conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
            
        }
    }
}
