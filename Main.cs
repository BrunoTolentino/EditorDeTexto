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
using System.Diagnostics.Eventing.Reader;

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

        StringReader leitura = null;

        #endregion

        #region "Eventos Principais"

        //Impressão
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimrir();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimrir();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float posY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }

            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);

            linha = leitura.ReadLine();

            while (cont < linhasPagina && linha != null)
            {
                posY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, posY, new StringFormat());
                cont++;
                linha = leitura.ReadLine();
            }

            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();

        }

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

        //Fonte
        private void btnFonte_Click(object sender, EventArgs e)
        {
            AlterarFonte();
        }

        //Negrito
        private void btnNegrito_Click(object sender, EventArgs e)
        {
            AplicarFormatacaoEstilo(richTextBox1, FontStyle.Bold);
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

        //Alinhamento à esquerda
        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            Alinhamento(richTextBox1, HorizontalAlignment.Left);
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alinhamento(richTextBox1, HorizontalAlignment.Left);
        }

        //Alinhamento ao centro
        private void btnCentro_Click(object sender, EventArgs e)
        {
            Alinhamento(richTextBox1, HorizontalAlignment.Center);
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alinhamento(richTextBox1, HorizontalAlignment.Center);

        }

        //Alinhamento à direita
        private void btnDireita_Click(object sender, EventArgs e)
        {
            Alinhamento(richTextBox1, HorizontalAlignment.Right);
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alinhamento(richTextBox1, HorizontalAlignment.Right);
        }

        //Sair 
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Eventos Secundários"

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.S))
            {
                Salvar();
                return true;
            } else if (keyData == (Keys.Control | Keys.I))
            {
                Imprimrir();
                return true;
            } else if (keyData == (Keys.Control | Keys.N))
            {
                Novo();
                return true;
            } else if (keyData == (Keys.Control | Keys.A))
            {
                Abrir();
                return true;
            } else if (keyData == (Keys.Control | Keys.C))
            {
                Copiar();
                return true;
            } else if(keyData == (Keys.Control | Keys.V))
            {
                Colar();
                return true;
            } else if(keyData == (Keys.Control | Keys.B))
            {
                AplicarFormatacaoEstilo(richTextBox1, FontStyle.Bold);
                return true;
            } else if(keyData == (Keys.Control | Keys.T))
            {
                AplicarFormatacaoEstilo(richTextBox1, FontStyle.Italic);
                return true;
            } else if(keyData == (Keys.Control | Keys.U))
            {
                AplicarFormatacaoEstilo(richTextBox1, FontStyle.Underline);
                return true;
            } else if(keyData == (Keys.Control | Keys.F)){
                AlterarFonte();
                return true;
            } else if(keyData == (Keys.Control | Keys.E)){
                Alinhamento(richTextBox1, HorizontalAlignment.Left);
                return true;
            } else if (keyData == (Keys.Control | Keys.D)) {
                Alinhamento(richTextBox1, HorizontalAlignment.Right);
                return true;
            } else if (keyData == (Keys.Control | Keys.M)) {
                Alinhamento(richTextBox1, HorizontalAlignment.Center);
                return true;
            }

                return base.ProcessCmdKey(ref msg, keyData);

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

        private void AplicarFormatacaoEstilo(RichTextBox rtb, FontStyle fstyle)
        {
            if (rtb.SelectionFont != null)
            {
                Font fonteSelecao = rtb.SelectionFont;

                fstyle = fonteSelecao.Style ^ fstyle;
                rtb.SelectionFont = new Font(fonteSelecao.FontFamily, fonteSelecao.Size, fstyle);
            }

        }

        private void AlterarFonte()
        {
           if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                FontStyle fStyle = fontDialog1.Font.Style;
                float fontSize = fontDialog1.Font.Size;
                richTextBox1.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontSize, fStyle);
            }
        }

        private void Alinhamento(RichTextBox rtb, HorizontalAlignment alinhamento)
        {
            rtb.SelectionAlignment = alinhamento;
        }

        private void Imprimrir()
        {
            printDialog1.Document = printDocument1;

            leitura = new StringReader(richTextBox1.Text);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

                this.printDocument1.Print();

            }
        }

        #endregion
        
    }
}
