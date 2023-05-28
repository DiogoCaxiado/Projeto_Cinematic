namespace Projeto_Cinematic
{
    partial class Sessao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sessao));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFecharX = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSalas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarSecao = new System.Windows.Forms.Button();
            this.btnFilmes = new System.Windows.Forms.Button();
            this.boxFilmes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.btnFecharX);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 38);
            this.panel2.TabIndex = 6;
            // 
            // btnFecharX
            // 
            this.btnFecharX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFecharX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharX.ForeColor = System.Drawing.Color.Red;
            this.btnFecharX.Location = new System.Drawing.Point(344, 7);
            this.btnFecharX.Name = "btnFecharX";
            this.btnFecharX.Size = new System.Drawing.Size(31, 23);
            this.btnFecharX.TabIndex = 8;
            this.btnFecharX.Text = "X";
            this.btnFecharX.UseVisualStyleBackColor = false;
            this.btnFecharX.Click += new System.EventHandler(this.btnFecharX_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 8);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(154, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cadastrar Sessão";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtSalas
            // 
            this.txtSalas.Location = new System.Drawing.Point(74, 27);
            this.txtSalas.Name = "txtSalas";
            this.txtSalas.Size = new System.Drawing.Size(100, 20);
            this.txtSalas.TabIndex = 0;
            this.txtSalas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sala : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(190, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filmes :";
            // 
            // btnCadastrarSecao
            // 
            this.btnCadastrarSecao.Location = new System.Drawing.Point(74, 63);
            this.btnCadastrarSecao.Name = "btnCadastrarSecao";
            this.btnCadastrarSecao.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarSecao.TabIndex = 5;
            this.btnCadastrarSecao.Text = "Cadastrar";
            this.btnCadastrarSecao.UseVisualStyleBackColor = true;
            this.btnCadastrarSecao.Click += new System.EventHandler(this.btnCadastrarSecao_Click);
            // 
            // btnFilmes
            // 
            this.btnFilmes.Location = new System.Drawing.Point(250, 63);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(75, 23);
            this.btnFilmes.TabIndex = 7;
            this.btnFilmes.Text = "Buscar";
            this.btnFilmes.UseVisualStyleBackColor = true;
            this.btnFilmes.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxFilmes
            // 
            this.boxFilmes.FormattingEnabled = true;
            this.boxFilmes.Location = new System.Drawing.Point(246, 26);
            this.boxFilmes.Name = "boxFilmes";
            this.boxFilmes.Size = new System.Drawing.Size(100, 21);
            this.boxFilmes.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.boxFilmes);
            this.panel1.Controls.Add(this.btnFilmes);
            this.panel1.Controls.Add(this.btnCadastrarSecao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSalas);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 98);
            this.panel1.TabIndex = 5;
            // 
            // Sessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(396, 156);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sessao";
            this.Load += new System.EventHandler(this.Sessao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFecharX;
        private System.Windows.Forms.TextBox txtSalas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarSecao;
        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.ComboBox boxFilmes;
        private System.Windows.Forms.Panel panel1;
    }
}