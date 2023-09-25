Aprendendo a somar, subtrair, dividir e multiplicar.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roberto_Melo
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}

    private void Enviar_Click(object sender, EventArgs e)
    {
        //pergar o valor do primeiro número e atribuir em uma variável
        //pegar o valor do sengundo número e atribuir em variável
        //calcular a soma 
        //exibir o resultado na caixa de texto 

        double n1 = double.Parse(tbxValor1.Text);
        double n2 = double.Parse(tbxValor2.Text);
        double Subtrair = n1 - n2;
        tbxResultado.Text = Subtrair.ToString();

    }

    private void btnSubtrair_Click(object sender, EventArgs e)
    {
        double n1 = double.Parse(tbxValor1.Text);
        double n2 = double.Parse(tbxValor2.Text);
        double Subtrair = n1 - n2;
        tbxResultado.Text = Subtrair.ToString();
       
    }

    private void btnSomar_Click(object sender, EventArgs e)
    {
        double n1 = double.Parse(tbxValor1.Text);
        double n2 = double.Parse(tbxValor2.Text);
        double Somar = n1 + n2;
        tbxResultado.Text = Somar.ToString();
    }

    private void btnDividir_Click(object sender, EventArgs e)
    {
        double n1 = double.Parse(tbxValor1.Text);
        double n2 = double.Parse(tbxValor2.Text);
        double Dividir = n1 / n2;
        tbxResultado.Text = Dividir.ToString();
    }

    private void btnMultiplicar_Click(object sender, EventArgs e)
    {
        double n1 = double.Parse(tbxValor1.Text);
        double n2 = double.Parse(tbxValor2.Text);
        double Multiplicar = n1 * n2;
        tbxResultado.Text = Multiplicar.ToString();
    }
  
    private void btnLimpar_Click(object sender, EventArgs e)
    {
        tbxValor1.Text = "";
        tbxValor2.Text = "";
        tbxResultado.Text = "";
    }
}
}
