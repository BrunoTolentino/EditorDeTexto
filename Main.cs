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

namespace EditorDeTexto
{

    public partial class Main : Form
    {

        #region "Construtores"

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region "Variáveis"

        StreamReader leitura = null;

        #endregion

        #region "Eventos Principais"

        //Novo
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        //Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        #endregion

        #region "Métodos"

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Mundo_StreamWriter = new StreamWriter(arquivo);
                    Mundo_StreamWriter.Flush();
                    Mundo_StreamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    Mundo_StreamWriter.Write(this.richTextBox1.Text);
                    Mundo_StreamWriter.Flush();
                    Mundo_StreamWriter.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação do arquivo! " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
