using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Contas
{
    public partial class frmContas : Form
    {
        public frmContas()
        {
            InitializeComponent();
        }

        private void frmContas_Load(object sender, EventArgs e)
        {
            mskDataLancto.Mask = "00/00/0000"; // Configuração da Máscara da data
            mskHoraLacto.Mask = "00:00:00"; // Configuração da Máscara da hora

            mskDataLancto.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Mostra a data do sistema
            mskHoraLacto.Text = DateTime.Now.ToString("HH:mm:ss"); // Mostra a hora do sistema      

            // Preenche o combo da conta
            cmbConta.Items.Add("");
            cmbConta.Items.Add("Água");
            cmbConta.Items.Add("Energia");
            cmbConta.Items.Add("Internet");
            cmbConta.Items.Add("SuperMercado");
            cmbConta.Items.Add("Gás");

            // Preenche o tipo da conta
            cmbTipo.Items.Add("");
            cmbTipo.Items.Add("Fixa");
            cmbTipo.Items.Add("Variável");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fechando", "saindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar(); // Chama o método limpar
        }

        private void Limpar()
        {
            cmbConta.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            numValor.Value = 0;
            txtQtdeContas.Clear();
            txtTotal.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar para não permitir adicionar conta nula
            if (string.IsNullOrEmpty(cmbConta.Text))
            {
                MessageBox.Show("Selecione uma conta", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar para não permitir adicionar tipo nulo
            if (string.IsNullOrEmpty(cmbTipo.Text))
            {
                MessageBox.Show("Selecione um tipo", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar para não permitir adicionar conteudo duplicados
            if (lstContas.Items.Contains(cmbConta.SelectedItem))
            {
                MessageBox.Show("Essa conta já foi selecionada", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Adiciona no listBox de contas, a conta que foi selecionada no ComboBox
                lstContas.Items.Add(cmbConta.SelectedItem);

                // Faz a contagem das contas lançadas no listBox de contas
                txtQtdeContas.Text = lstContas.Items.Count.ToString();
            }

            
        }
    }
}
