namespace Conversor
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            txtPesos = new TextBox();
            txtDolar = new TextBox();
            txtEuro = new TextBox();
            label4 = new Label();
            btnConvertir = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 154);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Euro (EUR$)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Dolar (US$)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 2;
            label3.Text = "Pesos Dominicanos (RD$)";
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(164, 45);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(125, 23);
            txtPesos.TabIndex = 3;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(164, 92);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(125, 23);
            txtDolar.TabIndex = 4;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(164, 151);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(125, 23);
            txtEuro.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 9);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 6;
            label4.Text = "Convertidor de monedas";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(195, 190);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 7;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(58, 190);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Limpiar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 225);
            Controls.Add(btnBorrar);
            Controls.Add(btnConvertir);
            Controls.Add(label4);
            Controls.Add(txtEuro);
            Controls.Add(txtDolar);
            Controls.Add(txtPesos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPesos;
        private TextBox txtDolar;
        private TextBox txtEuro;
        private Label label4;
        private Button btnConvertir;
        private Button btnBorrar;
    }
}