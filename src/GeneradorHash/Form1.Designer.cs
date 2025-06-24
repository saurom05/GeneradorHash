namespace GeneradorHash
{
    partial class fmrGeneradorHash
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
            label1 = new Label();
            txtRutaArchivo = new TextBox();
            btnAgregarArchivo = new Button();
            txtResultado = new TextBox();
            btnGenerarArchivo = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar Archivo Txt :";
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.Location = new Point(115, 6);
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(261, 23);
            txtRutaArchivo.TabIndex = 1;
            // 
            // btnAgregarArchivo
            // 
            btnAgregarArchivo.Location = new Point(382, 5);
            btnAgregarArchivo.Name = "btnAgregarArchivo";
            btnAgregarArchivo.Size = new Size(40, 24);
            btnAgregarArchivo.TabIndex = 2;
            btnAgregarArchivo.Text = "Add";
            btnAgregarArchivo.UseVisualStyleBackColor = true;
            btnAgregarArchivo.Click += btnAgregarArchivo_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(7, 31);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(462, 157);
            txtResultado.TabIndex = 3;
            // 
            // btnGenerarArchivo
            // 
            btnGenerarArchivo.Location = new Point(425, 4);
            btnGenerarArchivo.Name = "btnGenerarArchivo";
            btnGenerarArchivo.Size = new Size(43, 24);
            btnGenerarArchivo.TabIndex = 4;
            btnGenerarArchivo.Text = "Gen";
            btnGenerarArchivo.UseVisualStyleBackColor = true;
            btnGenerarArchivo.Click += btnGenerarArchivo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 191);
            label2.Name = "label2";
            label2.Size = new Size(231, 15);
            label2.TabIndex = 5;
            label2.Text = "Desarrollado por Rodrigo Menendez V1.0.0";
            label2.Click += label2_Click;
            // 
            // fmrGeneradorHash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 211);
            Controls.Add(label2);
            Controls.Add(btnGenerarArchivo);
            Controls.Add(txtResultado);
            Controls.Add(btnAgregarArchivo);
            Controls.Add(txtRutaArchivo);
            Controls.Add(label1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "fmrGeneradorHash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador Hash";
            Load += fmrGeneradorHash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRutaArchivo;
        private Button btnAgregarArchivo;
        private TextBox txtResultado;
        private Button btnGenerarArchivo;
        private Label label2;
    }
}
