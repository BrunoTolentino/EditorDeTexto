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

        #region "Vari�veis"

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

        //Abrir
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        #endregion

        #region "M�todos"

        private void Novo()
        {
            if(! string.IsNullOrEmpty(richTextBox1.Text)){
                
                if(MessageBox.Show("Deseja salvar o arquivo atual?",
                                   "Arquivo n�o salvo.",
                                   MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Salvar();
                }
                
            }

            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string filepath = this.saveFileDialog1.FileName;
                    if(Path.GetExtension(filepath) == "")
                    {
                        filepath += ".TXT";
                    }

                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Mundo_StreamWriter = new StreamWriter(arquivo);
                    Mundo_StreamWriter.Flush();
                    Mundo_StreamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    Mundo_StreamWriter.Write(this.richTextBox1.Text);
                    Mundo_StreamWriter.Flush();
                    Mundo_StreamWriter.Close();

                    MessageBox.Show("Arquivo Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na grava��o do arquivo! " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Abrir()
        {
            try
            {
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";

                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {

                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader Mundo_Leitor = new StreamReader(arquivo);
                    Mundo_Leitor.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = String.Empty;
                    string texto = Mundo_Leitor.ReadToEnd();
                    this.richTextBox1.Text = texto;
                    Mundo_Leitor.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel abrir o arquivo!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion



        private void Main_Load(object sender, EventArgs e)
        {

        }

        
    }
}
