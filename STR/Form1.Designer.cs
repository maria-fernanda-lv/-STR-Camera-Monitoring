namespace STR
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connected_cameras = new System.Windows.Forms.Label();
            this.last_updated = new System.Windows.Forms.Label();
            this.txtEventLog = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.camera_5 = new System.Windows.Forms.Panel();
            this.camera_6 = new System.Windows.Forms.Panel();
            this.camera_7 = new System.Windows.Forms.Panel();
            this.camera_3 = new System.Windows.Forms.Panel();
            this.camera_2 = new System.Windows.Forms.Panel();
            this.camera_1 = new System.Windows.Forms.Panel();
            this.camera_4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Câmeras conectadas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Última atualização:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // connected_cameras
            // 
            this.connected_cameras.AutoSize = true;
            this.connected_cameras.Location = new System.Drawing.Point(171, 27);
            this.connected_cameras.Name = "connected_cameras";
            this.connected_cameras.Size = new System.Drawing.Size(14, 16);
            this.connected_cameras.TabIndex = 2;
            this.connected_cameras.Text = "0";
            // 
            // last_updated
            // 
            this.last_updated.AutoSize = true;
            this.last_updated.Location = new System.Drawing.Point(152, 57);
            this.last_updated.Name = "last_updated";
            this.last_updated.Size = new System.Drawing.Size(14, 16);
            this.last_updated.TabIndex = 3;
            this.last_updated.Text = "0";
            // 
            // txtEventLog
            // 
            this.txtEventLog.Location = new System.Drawing.Point(29, 113);
            this.txtEventLog.Name = "txtEventLog";
            this.txtEventLog.Size = new System.Drawing.Size(100, 22);
            this.txtEventLog.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STR.Properties.Resources._52_Planta_Baixa_Tipo_8_B_scaled__2___1___1___1_;
            this.pictureBox1.Location = new System.Drawing.Point(827, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 741);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // camera_5
            // 
            this.camera_5.BackColor = System.Drawing.Color.Red;
            this.camera_5.Location = new System.Drawing.Point(836, 529);
            this.camera_5.Name = "camera_5";
            this.camera_5.Size = new System.Drawing.Size(40, 35);
            this.camera_5.TabIndex = 10;
            // 
            // camera_6
            // 
            this.camera_6.BackColor = System.Drawing.Color.Red;
            this.camera_6.Location = new System.Drawing.Point(1154, 529);
            this.camera_6.Name = "camera_6";
            this.camera_6.Size = new System.Drawing.Size(40, 35);
            this.camera_6.TabIndex = 11;
            // 
            // camera_7
            // 
            this.camera_7.BackColor = System.Drawing.Color.Red;
            this.camera_7.Location = new System.Drawing.Point(1154, 698);
            this.camera_7.Name = "camera_7";
            this.camera_7.Size = new System.Drawing.Size(40, 35);
            this.camera_7.TabIndex = 11;
            // 
            // camera_3
            // 
            this.camera_3.BackColor = System.Drawing.Color.Red;
            this.camera_3.Location = new System.Drawing.Point(999, 192);
            this.camera_3.Name = "camera_3";
            this.camera_3.Size = new System.Drawing.Size(40, 35);
            this.camera_3.TabIndex = 12;
            // 
            // camera_2
            // 
            this.camera_2.BackColor = System.Drawing.Color.Red;
            this.camera_2.Location = new System.Drawing.Point(1154, 48);
            this.camera_2.Name = "camera_2";
            this.camera_2.Size = new System.Drawing.Size(40, 35);
            this.camera_2.TabIndex = 13;
            // 
            // camera_1
            // 
            this.camera_1.BackColor = System.Drawing.Color.Red;
            this.camera_1.Location = new System.Drawing.Point(836, 38);
            this.camera_1.Name = "camera_1";
            this.camera_1.Size = new System.Drawing.Size(40, 35);
            this.camera_1.TabIndex = 14;
            // 
            // camera_4
            // 
            this.camera_4.BackColor = System.Drawing.Color.Red;
            this.camera_4.Location = new System.Drawing.Point(836, 252);
            this.camera_4.Name = "camera_4";
            this.camera_4.Size = new System.Drawing.Size(40, 35);
            this.camera_4.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1372, 794);
            this.Controls.Add(this.camera_4);
            this.Controls.Add(this.camera_1);
            this.Controls.Add(this.camera_2);
            this.Controls.Add(this.camera_3);
            this.Controls.Add(this.camera_7);
            this.Controls.Add(this.camera_6);
            this.Controls.Add(this.camera_5);
            this.Controls.Add(this.txtEventLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.last_updated);
            this.Controls.Add(this.connected_cameras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "STR ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label connected_cameras;
        private System.Windows.Forms.Label last_updated;
        private System.Windows.Forms.TextBox txtEventLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel camera_5;
        private System.Windows.Forms.Panel camera_6;
        private System.Windows.Forms.Panel camera_7;
        private System.Windows.Forms.Panel camera_3;
        private System.Windows.Forms.Panel camera_2;
        private System.Windows.Forms.Panel camera_1;
        private System.Windows.Forms.Panel camera_4;
    }
}

