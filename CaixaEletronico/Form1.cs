using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conta contaCP = new conta();
            Cliente Christian = new Cliente();

            contaCP.cliente = Christian;

            contaCP.contacorrente = "16405";
            contaCP.agencia = "3757";
            contaCP.saldo = 5000;
            contaCP.cliente.nome = "Christian";
            contaCP.cliente.cpf = "00754720667";
            contaCP.cliente.endereco = "ourania 100";
            contaCP.cliente.idade = 41;

            //contaCP.Deposita(200);

            MessageBox.Show("Sacou = " + contaCP.Saca(200));
                
      
            if (contaCP.cliente.EhMaiordeIdade())
            {
                MessageBox.Show(Christian.nome + " eh maior de idade");

            }
            else
            {
                MessageBox.Show(Christian.nome + " eh menor de idade");
              

            }
            //MessageBox.Show("Saldo conta cp eh " + contaCP.saldo);


        }
    }
}
