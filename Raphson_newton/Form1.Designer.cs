namespace Raphson_newton
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
            txtFuncion = new TextBox();
            txtDerivada = new TextBox();
            txtValorInicial = new TextBox();
            txtIteraciones = new TextBox();
            lstResultados = new ListBox();
            txtRaiz = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(132, 39);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(125, 27);
            txtFuncion.TabIndex = 0;
            // 
            // txtDerivada
            // 
            txtDerivada.Location = new Point(132, 81);
            txtDerivada.Name = "txtDerivada";
            txtDerivada.Size = new Size(125, 27);
            txtDerivada.TabIndex = 1;
            // 
            // txtValorInicial
            // 
            txtValorInicial.Location = new Point(132, 129);
            txtValorInicial.Name = "txtValorInicial";
            txtValorInicial.Size = new Size(125, 27);
            txtValorInicial.TabIndex = 2;
            // 
            // txtIteraciones
            // 
            txtIteraciones.Location = new Point(132, 174);
            txtIteraciones.Name = "txtIteraciones";
            txtIteraciones.Size = new Size(125, 27);
            txtIteraciones.TabIndex = 3;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(275, 42);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(354, 264);
            lstResultados.TabIndex = 4;
            // 
            // txtRaiz
            // 
            txtRaiz.Location = new Point(416, 9);
            txtRaiz.Name = "txtRaiz";
            txtRaiz.Size = new Size(183, 27);
            txtRaiz.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(75, 232);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 7;
            label1.Text = "Funcion f(x)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 8;
            label2.Text = "Derivada f(x) ´";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 132);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 9;
            label3.Text = "Valor Inicial Xi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 177);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 10;
            label4.Text = "N° Interaciones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 12);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 11;
            label5.Text = "Raiz Aproximada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 341);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtRaiz);
            Controls.Add(lstResultados);
            Controls.Add(txtIteraciones);
            Controls.Add(txtValorInicial);
            Controls.Add(txtDerivada);
            Controls.Add(txtFuncion);
            Name = "Form1";
            Text = "Metodo Newton Raphsor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFuncion;
        private TextBox txtDerivada;
        private TextBox txtValorInicial;
        private TextBox txtIteraciones;
        private ListBox lstResultados;
        private TextBox txtRaiz;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
