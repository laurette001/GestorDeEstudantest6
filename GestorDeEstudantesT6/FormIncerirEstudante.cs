using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormIncerirEstudante : Form
    {
        public FormIncerirEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();

            selecionarImagem.Filter = "Selecione a foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            if(selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(selecionarImagem.FileName);
            }
        


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

            bool Verificar()
            {
                if (textBoxNome.Text.Trim() == "")||
                        (textBoxSobrenome.Text.Trim() == "")||
                        (textBoxTelefone.Text.Trim() == "")||
                        (textBoxEndereço.Text.Trim() == "")||
                        (pictureBoxFoto.Image == null))
                {
                    return false;
                }
                 else
                {
                    return true;
                }
            }


    }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();

            
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime
         
        }
    }
