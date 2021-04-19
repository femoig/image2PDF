namespace ImageToPDF
{
    partial class Form1
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImagens = new System.Windows.Forms.TextBox();
            this.textBoxPDF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurar1 = new System.Windows.Forms.Button();
            this.btnProcurar2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxScalebyImageSize = new System.Windows.Forms.CheckBox();
            this.btnVerPDF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(336, 371);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(226, 67);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Converter para PDF";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho das images:";
            // 
            // textBoxImagens
            // 
            this.textBoxImagens.Location = new System.Drawing.Point(33, 108);
            this.textBoxImagens.Name = "textBoxImagens";
            this.textBoxImagens.Size = new System.Drawing.Size(586, 26);
            this.textBoxImagens.TabIndex = 2;
            this.textBoxImagens.Text = "C:\\Imagens";
            // 
            // textBoxPDF
            // 
            this.textBoxPDF.Location = new System.Drawing.Point(33, 242);
            this.textBoxPDF.Name = "textBoxPDF";
            this.textBoxPDF.Size = new System.Drawing.Size(586, 26);
            this.textBoxPDF.TabIndex = 4;
            this.textBoxPDF.Text = "C:\\Imagens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gravar PDF em:";
            // 
            // btnProcurar1
            // 
            this.btnProcurar1.Location = new System.Drawing.Point(616, 73);
            this.btnProcurar1.Name = "btnProcurar1";
            this.btnProcurar1.Size = new System.Drawing.Size(154, 42);
            this.btnProcurar1.TabIndex = 5;
            this.btnProcurar1.Text = "Procurar";
            this.btnProcurar1.UseVisualStyleBackColor = true;
            this.btnProcurar1.Click += new System.EventHandler(this.btnProcurar1_Click);
            // 
            // btnProcurar2
            // 
            this.btnProcurar2.Location = new System.Drawing.Point(616, 207);
            this.btnProcurar2.Name = "btnProcurar2";
            this.btnProcurar2.Size = new System.Drawing.Size(154, 43);
            this.btnProcurar2.TabIndex = 6;
            this.btnProcurar2.Text = "Procurar";
            this.btnProcurar2.UseVisualStyleBackColor = true;
            this.btnProcurar2.Click += new System.EventHandler(this.btnProcurar2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProcurar1);
            this.groupBox1.Controls.Add(this.btnProcurar2);
            this.groupBox1.Controls.Add(this.checkBoxScalebyImageSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 325);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // checkBoxScalebyImageSize
            // 
            this.checkBoxScalebyImageSize.AutoSize = true;
            this.checkBoxScalebyImageSize.Checked = true;
            this.checkBoxScalebyImageSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScalebyImageSize.Location = new System.Drawing.Point(21, 282);
            this.checkBoxScalebyImageSize.Name = "checkBoxScalebyImageSize";
            this.checkBoxScalebyImageSize.Size = new System.Drawing.Size(175, 24);
            this.checkBoxScalebyImageSize.TabIndex = 0;
            this.checkBoxScalebyImageSize.Text = "Scale by ImageSize";
            this.checkBoxScalebyImageSize.UseVisualStyleBackColor = true;
            // 
            // btnVerPDF
            // 
            this.btnVerPDF.Location = new System.Drawing.Point(583, 371);
            this.btnVerPDF.Name = "btnVerPDF";
            this.btnVerPDF.Size = new System.Drawing.Size(199, 67);
            this.btnVerPDF.TabIndex = 7;
            this.btnVerPDF.Text = "Ver PDF";
            this.btnVerPDF.UseVisualStyleBackColor = true;
            this.btnVerPDF.Click += new System.EventHandler(this.btnVerPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerPDF);
            this.Controls.Add(this.textBoxPDF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Image to PDF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImagens;
        private System.Windows.Forms.TextBox textBoxPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurar1;
        private System.Windows.Forms.Button btnProcurar2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxScalebyImageSize;
        private System.Windows.Forms.Button btnVerPDF;
    }
}

