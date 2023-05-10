namespace Calculadora
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
            btn_um = new Button();
            btn_dois = new Button();
            btn_tres = new Button();
            btn_quatro = new Button();
            btn_cinco = new Button();
            btn_seis = new Button();
            btn_sete = new Button();
            btn_oito = new Button();
            btn_nove = new Button();
            btn_Adicionar = new Button();
            btn_subtrair = new Button();
            btn_Multiplicar = new Button();
            btn_dividir = new Button();
            btn_resultado = new Button();
            button15 = new Button();
            textCalcular = new TextBox();
            btn_zero = new Button();
            btn_ponto = new Button();
            btn_virgula = new Button();
            SuspendLayout();
            // 
            // btn_um
            // 
            btn_um.Location = new Point(12, 102);
            btn_um.Name = "btn_um";
            btn_um.Size = new Size(51, 40);
            btn_um.TabIndex = 1;
            btn_um.Text = "1";
            btn_um.UseVisualStyleBackColor = true;
            btn_um.Click += btn_um_Click;
            // 
            // btn_dois
            // 
            btn_dois.Location = new Point(69, 102);
            btn_dois.Name = "btn_dois";
            btn_dois.Size = new Size(51, 40);
            btn_dois.TabIndex = 2;
            btn_dois.Text = "2";
            btn_dois.UseVisualStyleBackColor = true;
            btn_dois.Click += btn_dois_Click;
            // 
            // btn_tres
            // 
            btn_tres.Location = new Point(126, 102);
            btn_tres.Name = "btn_tres";
            btn_tres.Size = new Size(51, 40);
            btn_tres.TabIndex = 3;
            btn_tres.Text = "3";
            btn_tres.UseVisualStyleBackColor = true;
            btn_tres.Click += btn_tres_Click;
            // 
            // btn_quatro
            // 
            btn_quatro.Location = new Point(12, 148);
            btn_quatro.Name = "btn_quatro";
            btn_quatro.Size = new Size(51, 40);
            btn_quatro.TabIndex = 4;
            btn_quatro.Text = "4";
            btn_quatro.UseVisualStyleBackColor = true;
            btn_quatro.Click += btn_quatro_Click;
            // 
            // btn_cinco
            // 
            btn_cinco.Location = new Point(69, 148);
            btn_cinco.Name = "btn_cinco";
            btn_cinco.Size = new Size(51, 40);
            btn_cinco.TabIndex = 5;
            btn_cinco.Text = "5";
            btn_cinco.UseVisualStyleBackColor = true;
            btn_cinco.Click += btn_cinco_Click;
            // 
            // btn_seis
            // 
            btn_seis.Location = new Point(126, 148);
            btn_seis.Name = "btn_seis";
            btn_seis.Size = new Size(51, 40);
            btn_seis.TabIndex = 6;
            btn_seis.Text = "6";
            btn_seis.UseVisualStyleBackColor = true;
            btn_seis.Click += btn_seis_Click;
            // 
            // btn_sete
            // 
            btn_sete.Location = new Point(12, 194);
            btn_sete.Name = "btn_sete";
            btn_sete.Size = new Size(51, 40);
            btn_sete.TabIndex = 7;
            btn_sete.Text = "7";
            btn_sete.UseVisualStyleBackColor = true;
            btn_sete.Click += btn_sete_Click;
            // 
            // btn_oito
            // 
            btn_oito.Location = new Point(69, 194);
            btn_oito.Name = "btn_oito";
            btn_oito.Size = new Size(51, 40);
            btn_oito.TabIndex = 8;
            btn_oito.Text = "8";
            btn_oito.UseVisualStyleBackColor = true;
            btn_oito.Click += btn_oito_Click;
            // 
            // btn_nove
            // 
            btn_nove.Location = new Point(126, 194);
            btn_nove.Name = "btn_nove";
            btn_nove.Size = new Size(51, 40);
            btn_nove.TabIndex = 9;
            btn_nove.Text = "9";
            btn_nove.UseVisualStyleBackColor = true;
            btn_nove.Click += btn_nove_Click;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Location = new Point(209, 102);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(51, 40);
            btn_Adicionar.TabIndex = 10;
            btn_Adicionar.Text = "+";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // btn_subtrair
            // 
            btn_subtrair.Location = new Point(209, 148);
            btn_subtrair.Name = "btn_subtrair";
            btn_subtrair.Size = new Size(51, 40);
            btn_subtrair.TabIndex = 11;
            btn_subtrair.Text = "-";
            btn_subtrair.UseVisualStyleBackColor = true;
            btn_subtrair.Click += btn_subtrair_Click;
            // 
            // btn_Multiplicar
            // 
            btn_Multiplicar.Location = new Point(209, 194);
            btn_Multiplicar.Name = "btn_Multiplicar";
            btn_Multiplicar.Size = new Size(51, 40);
            btn_Multiplicar.TabIndex = 12;
            btn_Multiplicar.Text = "*";
            btn_Multiplicar.UseVisualStyleBackColor = true;
            btn_Multiplicar.Click += btn_Multiplicar_Click;
            // 
            // btn_dividir
            // 
            btn_dividir.Location = new Point(266, 102);
            btn_dividir.Name = "btn_dividir";
            btn_dividir.Size = new Size(51, 40);
            btn_dividir.TabIndex = 13;
            btn_dividir.Text = "/";
            btn_dividir.UseVisualStyleBackColor = true;
            btn_dividir.Click += btn_dividir_Click;
            // 
            // btn_resultado
            // 
            btn_resultado.Location = new Point(266, 148);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(51, 40);
            btn_resultado.TabIndex = 14;
            btn_resultado.Text = "=";
            btn_resultado.UseVisualStyleBackColor = true;
            btn_resultado.Click += btn_resultado_Click;
            // 
            // button15
            // 
            button15.Location = new Point(266, 194);
            button15.Name = "button15";
            button15.Size = new Size(51, 40);
            button15.TabIndex = 15;
            button15.Text = "c";
            button15.UseVisualStyleBackColor = true;
            // 
            // textCalcular
            // 
            textCalcular.Location = new Point(12, 23);
            textCalcular.Name = "textCalcular";
            textCalcular.ReadOnly = true;
            textCalcular.Size = new Size(305, 23);
            textCalcular.TabIndex = 16;
            textCalcular.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_zero
            // 
            btn_zero.Location = new Point(69, 240);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(51, 40);
            btn_zero.TabIndex = 17;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = true;
            btn_zero.Click += btn_zero_Click;
            // 
            // btn_ponto
            // 
            btn_ponto.Location = new Point(12, 240);
            btn_ponto.Name = "btn_ponto";
            btn_ponto.Size = new Size(51, 40);
            btn_ponto.TabIndex = 18;
            btn_ponto.Text = ".";
            btn_ponto.UseVisualStyleBackColor = true;
            btn_ponto.Click += btn_ponto_Click;
            // 
            // btn_virgula
            // 
            btn_virgula.Location = new Point(126, 240);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(51, 40);
            btn_virgula.TabIndex = 19;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = true;
            btn_virgula.Click += btn_virgula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 292);
            Controls.Add(btn_virgula);
            Controls.Add(btn_ponto);
            Controls.Add(btn_zero);
            Controls.Add(textCalcular);
            Controls.Add(button15);
            Controls.Add(btn_resultado);
            Controls.Add(btn_dividir);
            Controls.Add(btn_Multiplicar);
            Controls.Add(btn_subtrair);
            Controls.Add(btn_Adicionar);
            Controls.Add(btn_nove);
            Controls.Add(btn_oito);
            Controls.Add(btn_sete);
            Controls.Add(btn_seis);
            Controls.Add(btn_cinco);
            Controls.Add(btn_quatro);
            Controls.Add(btn_tres);
            Controls.Add(btn_dois);
            Controls.Add(btn_um);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_um;
        private Button btn_dois;
        private Button btn_tres;
        private Button btn_quatro;
        private Button btn_cinco;
        private Button btn_seis;
        private Button btn_sete;
        private Button btn_oito;
        private Button btn_nove;
        private Button btn_Adicionar;
        private Button btn_subtrair;
        private Button btn_Multiplicar;
        private Button btn_dividir;
        private Button btn_resultado;
        private Button button15;
        private TextBox textCalcular;
        private Button btn_zero;
        private Button btn_ponto;
        private Button btn_virgula;
    }
}