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

        //StreamReader leitura = null;

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

        //Copiar
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        //Colar
        private void btnColar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        //Negrito
        private void btnNegrito_Click(object sender, EventArgs e)
        {
            AplicarFormatacaoEstilo(richTextBox1,FontStyle.Bold);
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarFormatacaoEstilo(richTextBox1, FontStyle.Bold);
        }

        //Itálico
        private void btnItalico_Click(object sender, EventArgs e)
        {
            AplicarFormatacaoEstilo(richTextBox1, FontStyle.Italic);
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarFormatacaoEstilo(richTextBox1, FontStyle.Italic);
        }

        //Sublinhado
        private void btnSublinhado_Click(object sender, EventArgs e)
        {
            AplicarFormatacaoEstilo(richTextBox1, FontStyle.Underline);
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarFormatacaoEstilo(richTextBox1, FontStyle.Underline);
        }

        #endregion

        #region "Métodos"

        private void Novo()
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {

                if (MessageBox.Show("Deseja salvar o arquivo atual?",
                                   "Arquivo não salvo.",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    if (Path.GetExtension(filepath) == "")
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
                MessageBox.Show("Erro na gravação do arquivo! " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Nâo foi possível abrir o arquivo!" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            richTextBox1.Paste();
        }       

        private void AplicarFormatacaoEstilo(RichTextBox rtb,FontStyle fstyle)
        {
            if(rtb.SelectionFont != null)
            {
                Font fonteSelecao = rtb.SelectionFont;

                fstyle = fonteSelecao.Style ^ fstyle;
                rtb.SelectionFont = new Font(fonteSelecao.FontFamily,fonteSelecao.Size, fstyle);
            }
           
        }

        #endregion
       
    }
}
