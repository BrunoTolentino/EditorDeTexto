namespace EditorDeTexto
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            itálicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            centralizarToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            direitaToolStripMenuItem = new ToolStripMenuItem();
            justificarToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnSalvar = new ToolStripButton();
            btnImprimir = new ToolStripButton();
            btnNovo = new ToolStripButton();
            btnAbrir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCopiar = new ToolStripButton();
            btnColar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnNegrito = new ToolStripButton();
            btnItalico = new ToolStripButton();
            btnSublinhado = new ToolStripButton();
            btnFonte = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnEsquerda = new ToolStripButton();
            btnCentro = new ToolStripButton();
            btnDireita = new ToolStripButton();
            btnJustificar = new ToolStripButton();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.WhiteSmoke;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(5, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(792, 391);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem });
            menuStrip1.Location = new Point(5, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(792, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imprimirToolStripMenuItem, novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(120, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(120, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(120, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(120, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(120, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, desfazerToolStripMenuItem, refazerToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(118, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(118, 22);
            colarToolStripMenuItem.Text = "Colar";
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.Size = new Size(118, 22);
            desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.Size = new Size(118, 22);
            refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, itálicoToolStripMenuItem, sublinhadoToolStripMenuItem, alinhamentoToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(143, 22);
            negritoToolStripMenuItem.Text = "Negrito";
            // 
            // itálicoToolStripMenuItem
            // 
            itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            itálicoToolStripMenuItem.Size = new Size(143, 22);
            itálicoToolStripMenuItem.Text = "Itálico";
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(143, 22);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centralizarToolStripMenuItem, esquerdaToolStripMenuItem, direitaToolStripMenuItem, justificarToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(143, 22);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            centralizarToolStripMenuItem.Size = new Size(130, 22);
            centralizarToolStripMenuItem.Text = "Centralizar";
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(130, 22);
            esquerdaToolStripMenuItem.Text = "Esquerda";
            // 
            // direitaToolStripMenuItem
            // 
            direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            direitaToolStripMenuItem.Size = new Size(130, 22);
            direitaToolStripMenuItem.Text = "Direita";
            // 
            // justificarToolStripMenuItem
            // 
            justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            justificarToolStripMenuItem.Size = new Size(130, 22);
            justificarToolStripMenuItem.Text = "Justificar";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSalvar, btnImprimir, btnNovo, btnAbrir, toolStripSeparator1, btnCopiar, btnColar, toolStripSeparator2, btnNegrito, btnItalico, btnSublinhado, btnFonte, toolStripSeparator3, btnEsquerda, btnCentro, btnDireita, btnJustificar });
            toolStrip1.Location = new Point(5, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(792, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            btnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSalvar.Image = Properties.Resources.icons8_salvar_48;
            btnSalvar.ImageTransparentColor = Color.Magenta;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(23, 22);
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnImprimir.Image = Properties.Resources.icons8_impressão_48;
            btnImprimir.ImageTransparentColor = Color.Magenta;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(23, 22);
            btnImprimir.Text = "Imprimir";
            // 
            // btnNovo
            // 
            btnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNovo.Image = Properties.Resources.icons8_novo_arquivo_48;
            btnNovo.ImageTransparentColor = Color.Magenta;
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(23, 22);
            btnNovo.Text = "Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAbrir.Image = Properties.Resources.icons8_arquivo_48;
            btnAbrir.ImageTransparentColor = Color.Magenta;
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(23, 22);
            btnAbrir.Text = "Abrir";
            btnAbrir.Click += btnAbrir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnCopiar
            // 
            btnCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopiar.Image = Properties.Resources.icons8_copiar_48;
            btnCopiar.ImageTransparentColor = Color.Magenta;
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(23, 22);
            btnCopiar.Text = "Copiar";
            // 
            // btnColar
            // 
            btnColar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnColar.Image = Properties.Resources.icons8_colar_48;
            btnColar.ImageTransparentColor = Color.Magenta;
            btnColar.Name = "btnColar";
            btnColar.Size = new Size(23, 22);
            btnColar.Text = "Colar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnNegrito
            // 
            btnNegrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNegrito.Image = Properties.Resources.icons8_negrito_48;
            btnNegrito.ImageTransparentColor = Color.Magenta;
            btnNegrito.Name = "btnNegrito";
            btnNegrito.Size = new Size(23, 22);
            btnNegrito.Text = "Negrito";
            // 
            // btnItalico
            // 
            btnItalico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalico.Image = Properties.Resources.icons8_itálico_48;
            btnItalico.ImageTransparentColor = Color.Magenta;
            btnItalico.Name = "btnItalico";
            btnItalico.Size = new Size(23, 22);
            btnItalico.Text = "Itálico";
            // 
            // btnSublinhado
            // 
            btnSublinhado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSublinhado.Image = Properties.Resources.icons8_sublinhado_48;
            btnSublinhado.ImageTransparentColor = Color.Magenta;
            btnSublinhado.Name = "btnSublinhado";
            btnSublinhado.Size = new Size(23, 22);
            btnSublinhado.Text = "Sublinhado";
            // 
            // btnFonte
            // 
            btnFonte.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFonte.Image = Properties.Resources.icons8_maiúscula_inicial_48;
            btnFonte.ImageTransparentColor = Color.Magenta;
            btnFonte.Name = "btnFonte";
            btnFonte.Size = new Size(23, 22);
            btnFonte.Text = "Fonte";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnEsquerda
            // 
            btnEsquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEsquerda.Image = Properties.Resources.icons8_alinhar_à_esquerda_48;
            btnEsquerda.ImageTransparentColor = Color.Magenta;
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(23, 22);
            btnEsquerda.Text = "Esquerda";
            // 
            // btnCentro
            // 
            btnCentro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCentro.Image = Properties.Resources.icons8_alinhar_ao_centro_48;
            btnCentro.ImageTransparentColor = Color.Magenta;
            btnCentro.Name = "btnCentro";
            btnCentro.Size = new Size(23, 22);
            btnCentro.Text = "Centro";
            // 
            // btnDireita
            // 
            btnDireita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDireita.Image = Properties.Resources.icons8_alinhar_à_direita_48;
            btnDireita.ImageTransparentColor = Color.Magenta;
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(23, 22);
            btnDireita.Text = "Direita";
            // 
            // btnJustificar
            // 
            btnJustificar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnJustificar.Image = Properties.Resources.icons8_alinhar_justificado_48;
            btnJustificar.ImageTransparentColor = Color.Magenta;
            btnJustificar.Name = "btnJustificar";
            btnJustificar.Size = new Size(23, 22);
            btnJustificar.Text = "Justificar";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Title = "Abrir Arquivo";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mundo";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripMenuItem justificarToolStripMenuItem;
        private ToolStripButton btnNovo;
        private ToolStripButton btnAbrir;
        private ToolStripButton btnImprimir;
        private ToolStripButton btnSalvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCopiar;
        private ToolStripButton btnColar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnNegrito;
        private ToolStripButton btnItalico;
        private ToolStripButton btnSublinhado;
        private ToolStripButton btnFonte;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnEsquerda;
        private ToolStripButton btnCentro;
        private ToolStripButton btnDireita;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private ToolStripButton btnJustificar;
    }
}
