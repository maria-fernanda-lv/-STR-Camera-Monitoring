namespace STR
{
    partial class Menu
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
            this.star_button = new System.Windows.Forms.Button();
            this.explanation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_tb = new System.Windows.Forms.TextBox();
            this.senha_tb = new System.Windows.Forms.TextBox();
            this.senha_label = new System.Windows.Forms.Label();
            this.admin_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // star_button
            // 
            this.star_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.star_button.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.star_button.Location = new System.Drawing.Point(553, 544);
            this.star_button.Name = "star_button";
            this.star_button.Size = new System.Drawing.Size(276, 61);
            this.star_button.TabIndex = 0;
            this.star_button.Text = "Começar Monitoramento";
            this.star_button.UseVisualStyleBackColor = false;
            this.star_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // explanation
            // 
            this.explanation.AutoSize = true;
            this.explanation.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanation.Location = new System.Drawing.Point(188, 587);
            this.explanation.Name = "explanation";
            this.explanation.Size = new System.Drawing.Size(0, 18);
            this.explanation.TabIndex = 1;
            this.explanation.Click += new System.EventHandler(this.explanation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(285, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "O monitoramento de camêras se conecta automaticamente com as câmeras instaladas n" +
    "a sua rede,\r\nmostrando a qualidade da conexão e se movimentos suspeitos foram id" +
    "entificados.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(372, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projeto para a matéria de Sistemas Operacionais em Tempo Real\r\n     Alunos: Cayo " +
    "Philipe, Luigi Negrini, Maria Fernanda Lopes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::STR.Properties.Resources.STR_Monitoramento_removebg_preview__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(461, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin_tb
            // 
            this.admin_tb.Location = new System.Drawing.Point(553, 426);
            this.admin_tb.Name = "admin_tb";
            this.admin_tb.Size = new System.Drawing.Size(276, 22);
            this.admin_tb.TabIndex = 5;
            // 
            // senha_tb
            // 
            this.senha_tb.Location = new System.Drawing.Point(553, 481);
            this.senha_tb.MaxLength = 10;
            this.senha_tb.Name = "senha_tb";
            this.senha_tb.PasswordChar = '*';
            this.senha_tb.Size = new System.Drawing.Size(276, 22);
            this.senha_tb.TabIndex = 6;
            // 
            // senha_label
            // 
            this.senha_label.AutoSize = true;
            this.senha_label.BackColor = System.Drawing.Color.Transparent;
            this.senha_label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.senha_label.Location = new System.Drawing.Point(485, 478);
            this.senha_label.Name = "senha_label";
            this.senha_label.Size = new System.Drawing.Size(54, 20);
            this.senha_label.TabIndex = 7;
            this.senha_label.Text = "Senha";
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.BackColor = System.Drawing.Color.Transparent;
            this.admin_label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_label.Location = new System.Drawing.Point(485, 428);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(54, 20);
            this.admin_label.TabIndex = 8;
            this.admin_label.Text = "Admin";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STR.Properties.Resources.Design_sem_nome__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 754);
            this.Controls.Add(this.admin_label);
            this.Controls.Add(this.senha_label);
            this.Controls.Add(this.senha_tb);
            this.Controls.Add(this.admin_tb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.explanation);
            this.Controls.Add(this.star_button);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button star_button;
        private System.Windows.Forms.Label explanation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox admin_tb;
        private System.Windows.Forms.TextBox senha_tb;
        private System.Windows.Forms.Label senha_label;
        private System.Windows.Forms.Label admin_label;
    }
}