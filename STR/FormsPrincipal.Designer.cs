namespace STR
{
    partial class FormsPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.last_updated = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.camera1 = new System.Windows.Forms.Panel();
            this.camera3 = new System.Windows.Forms.Panel();
            this.camera2 = new System.Windows.Forms.Panel();
            this.listViewAlerts = new System.Windows.Forms.ListView();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Última atualização:";
            // 
            // last_updated
            // 
            this.last_updated.AutoSize = true;
            this.last_updated.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_updated.Location = new System.Drawing.Point(225, 627);
            this.last_updated.Name = "last_updated";
            this.last_updated.Size = new System.Drawing.Size(18, 19);
            this.last_updated.TabIndex = 3;
            this.last_updated.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STR.Properties.Resources._52_Planta_Baixa_Tipo_8_B_scaled__2___1___1___1_;
            this.pictureBox1.Location = new System.Drawing.Point(827, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 731);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // camera1
            // 
            this.camera1.BackColor = System.Drawing.Color.FloralWhite;
            this.camera1.Location = new System.Drawing.Point(949, 60);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(66, 67);
            this.camera1.TabIndex = 12;
            // 
            // camera3
            // 
            this.camera3.BackColor = System.Drawing.Color.FloralWhite;
            this.camera3.Location = new System.Drawing.Point(840, 690);
            this.camera3.Name = "camera3";
            this.camera3.Size = new System.Drawing.Size(70, 64);
            this.camera3.TabIndex = 13;
            // 
            // camera2
            // 
            this.camera2.BackColor = System.Drawing.Color.FloralWhite;
            this.camera2.Location = new System.Drawing.Point(1199, 436);
            this.camera2.Name = "camera2";
            this.camera2.Size = new System.Drawing.Size(70, 67);
            this.camera2.TabIndex = 14;
            // 
            // listViewAlerts
            // 
            this.listViewAlerts.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAlerts.HideSelection = false;
            this.listViewAlerts.Location = new System.Drawing.Point(30, 220);
            this.listViewAlerts.Name = "listViewAlerts";
            this.listViewAlerts.Size = new System.Drawing.Size(743, 374);
            this.listViewAlerts.TabIndex = 17;
            this.listViewAlerts.UseCompatibleStateImageBehavior = false;
            this.listViewAlerts.SelectedIndexChanged += new System.EventHandler(this.listViewAlerts_SelectedIndexChanged);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Monitoramento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Câmera Sala:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Câmera Varanda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Câmera Quarto:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.BackColor = System.Drawing.Color.LightYellow;
            this.label_2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(205, 122);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(18, 20);
            this.label_2.TabIndex = 24;
            this.label_2.Text = "-";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.LightYellow;
            this.label_1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(205, 152);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(18, 20);
            this.label_1.TabIndex = 25;
            this.label_1.Text = "-";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.BackColor = System.Drawing.Color.LightYellow;
            this.label_3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(205, 92);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(18, 20);
            this.label_3.TabIndex = 26;
            this.label_3.Text = "-";
            // 
            // FormsPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1328, 805);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewAlerts);
            this.Controls.Add(this.camera2);
            this.Controls.Add(this.camera3);
            this.Controls.Add(this.camera1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.last_updated);
            this.Controls.Add(this.label2);
            this.Name = "FormsPrincipal";
            this.Text = "STR ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label last_updated;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel camera3;
        private System.Windows.Forms.Panel camera2;
        private System.Windows.Forms.Panel camera1;
        private System.Windows.Forms.ListView listViewAlerts;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_3;
    }
}

