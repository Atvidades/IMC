using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercício_valendo_nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_IMC_Click(object sender, EventArgs e)
        {
            if (TB_Altura.Text == "" || TB_Peso.Text == "")
            {
                MessageBox.Show("Digite os valores primeiro!!!");
            }
            else
            {
                double Altura = double.Parse(TB_Altura.Text);
                double Peso = double.Parse(TB_Peso.Text);
                double R;
                R = Peso / (Altura * Altura);
                TB_Resultado.Text = Convert.ToString(R);

                if (R <= 18.5)
                {
                    MessageBox.Show("BAIXO PESO:" + R + " \n\nNesse ponto, o corpo magro deixa de ser saudável e o organismo fica mais vulnerável a infecções. Se o baixo peso persistir, mesmo com alimentação normal, procure ajuda médica; a dificuldade para engordar pode ser sintoma de alguma doença insidiosa, como o diabetes.");
                }
                if (R >= 18.5 && R <= 24.9)
                {
                    MessageBox.Show("PESO IDEAL:" + R + " \n\nSeu peso está adequado à altura.É importante manter a educação alimentar e a atividade física.Fique atento caso seu valor esteja perto dos limites para os estagios de Baixo Peso ou Sobrepeso.");
                }
                if (R >= 24.9 && R <= 29.9)
                {
                    MessageBox.Show("SOBREPESO:" + R + " \n\nEsta faixa indica que você está com predisposição à obesidade; dependendo do seu histórico familiar e pessoal, pode haver um quadro de pré-diabetes e hipertensão.Procure orientação médica para evitar o próximo estágio,Obesidade 1.Quanto mais quilos extras, maior a dificuldade para emagrecer.");
                }
                if (R >= 29.9 && R <= 34.9)
                {
                    MessageBox.Show("OBESIDADE GRAU 1:" + R + " \n\nO risco de desenvolver diabetes, para quem está nesta faixa de peso, é de 20%, e o de hipertensão ultrapassa 25%.Há risco maior de outras doenças cardiovasculares, artuculares, distúrbios psiquiátricos, apneia do sono e até certo tipos de câncer.");
                }

                if (R >= 34.9 && R <= 39.9)
                {
                    MessageBox.Show("OBESIDADE GRAU 2:" + R + " \n\nO risco de desenvolver diabetes chega 40%, e a chance de surgirem doenças associadas à obesidade, como reumatismos,câncer,apneia do sono,hipertensão e outros problemas cardiovasculares pode chegar a 50%. Procure orientação médica.");
                }

                if (R >= 40)
                {
                    MessageBox.Show("OBESIDADE GRAU 3:" + R + " \n\nO risco de desenvolver doenças associadas ao excesso de peso, como diabetes, reumatismos,câncer apneia do sono,hipertensão e outros problema cardiovasculares chega a 90%, Nesse estágio, a cirurgia  de redução de estomago pode ser indicada.Procure orienação médica imediatamente.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_Resultado.Text = null;
            TB_Peso.Text = null;
            TB_Altura.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
