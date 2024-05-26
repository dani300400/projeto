using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        private void btnGravar_Click(object sender, EventArgs e)
            {
                
                string dados = $"{lblNome.Text}: {txtNome.Text}\n" +
                               $"{lblEndereco.Text}: {txtEndereco.Text}\n" +
                               $"{lblBairro.Text}: {txtBairro.Text}\n" +
                               $"{lblEstado.Text}: {txtEstado.Text}\n" +
                               $"{lblTelefone.Text}: {txtTelefone.Text}\n" +
                               $"{lblCelular.Text}: {txtCelular.Text}\n" +
                               $"{lblEmail.Text}: {txtEmail.Text}\n";

                
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Arquivo de Texto|*.txt";
                saveFileDialog1.Title = "Salvar Cadastro";
                saveFileDialog1.ShowDialog();

                
                if (saveFileDialog1.FileName != "")
                {
                    File.WriteAllText(saveFileDialog1.FileName, dados);
                    MessageBox.Show("Cadastro gravado com sucesso!");
                }
            }

            private void btnNovo_Click(object sender, EventArgs e)
            {
                
                LimparCampos();
            }

            private void btnVer_Click(object sender, EventArgs e)
            {
                
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Arquivo de Texto|*.txt";
                openFileDialog1.Title = "Abrir Cadastro";
                openFileDialog1.ShowDialog();

                
                if (openFileDialog1.FileName != "")
                {
                    string dados = File.ReadAllText(openFileDialog1.FileName);
                    MessageBox.Show(dados);
                }
            }

            private void LimparCampos()
            {
                
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtEstado.Text = "";
                txtTelefone.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
            }
        }
    }



