namespace Practica_2_Unidad_4
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textPapas = new TextBox();
            textRefresco = new TextBox();
            textTe = new TextBox();
            textSandwich = new TextBox();
            textHotDog = new TextBox();
            textHamburguesa = new TextBox();
            textTotal = new TextBox();
            label7 = new Label();
            BotonCalcular = new Button();
            BotonSalida = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selección por pedido ";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(16, 130);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(107, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Otro Pedido";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(16, 96);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(244, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "No.3 (Sandwich, Refresco, Papas)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(16, 62);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(235, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "No.2 (HotDog, Refresco, Papas)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(16, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(259, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "No.1 (Hamburgues, Refreso, Papas)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textPapas);
            groupBox2.Controls.Add(textRefresco);
            groupBox2.Controls.Add(textTe);
            groupBox2.Controls.Add(textSandwich);
            groupBox2.Controls.Add(textHotDog);
            groupBox2.Controls.Add(textHamburguesa);
            groupBox2.Location = new Point(324, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 291);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alimentos Seleccionados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(99, 251);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 11;
            label6.Text = "Papas Fritas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(99, 204);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Refresco";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(99, 161);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 9;
            label4.Text = "Te";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(99, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Sandwich";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(99, 74);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "HotDog";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 6;
            label1.Text = "Hamburguesa";
            // 
            // textPapas
            // 
            textPapas.Location = new Point(6, 248);
            textPapas.Name = "textPapas";
            textPapas.Size = new Size(79, 23);
            textPapas.TabIndex = 5;
            // 
            // textRefresco
            // 
            textRefresco.Location = new Point(6, 204);
            textRefresco.Name = "textRefresco";
            textRefresco.Size = new Size(79, 23);
            textRefresco.TabIndex = 4;
            // 
            // textTe
            // 
            textTe.Location = new Point(6, 158);
            textTe.Name = "textTe";
            textTe.Size = new Size(79, 23);
            textTe.TabIndex = 3;
            // 
            // textSandwich
            // 
            textSandwich.Location = new Point(6, 115);
            textSandwich.Name = "textSandwich";
            textSandwich.Size = new Size(79, 23);
            textSandwich.TabIndex = 2;
            // 
            // textHotDog
            // 
            textHotDog.Location = new Point(6, 71);
            textHotDog.Name = "textHotDog";
            textHotDog.Size = new Size(79, 23);
            textHotDog.TabIndex = 1;
            // 
            // textHamburguesa
            // 
            textHamburguesa.Location = new Point(6, 26);
            textHamburguesa.Name = "textHamburguesa";
            textHamburguesa.Size = new Size(79, 23);
            textHamburguesa.TabIndex = 0;
            // 
            // textTotal
            // 
            textTotal.Location = new Point(70, 228);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(100, 23);
            textTotal.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(70, 205);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 3;
            label7.Text = "Total a cobrar";
            // 
            // BotonCalcular
            // 
            BotonCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BotonCalcular.Location = new Point(28, 263);
            BotonCalcular.Name = "BotonCalcular";
            BotonCalcular.Size = new Size(95, 32);
            BotonCalcular.TabIndex = 4;
            BotonCalcular.Text = "Calcular";
            BotonCalcular.UseVisualStyleBackColor = true;
            BotonCalcular.Click += BotonCalcular_Click;
            // 
            // BotonSalida
            // 
            BotonSalida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BotonSalida.Location = new Point(144, 263);
            BotonSalida.Name = "BotonSalida";
            BotonSalida.Size = new Size(94, 32);
            BotonSalida.TabIndex = 5;
            BotonSalida.Text = "Salida";
            BotonSalida.UseVisualStyleBackColor = true;
            BotonSalida.Click += BotonSalida_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonSalida);
            Controls.Add(BotonCalcular);
            Controls.Add(label7);
            Controls.Add(textTotal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textPapas;
        private TextBox textRefresco;
        private TextBox textTe;
        private TextBox textSandwich;
        private TextBox textHotDog;
        private TextBox textHamburguesa;
        private Label label2;
        private Label label1;
        private TextBox textTotal;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button BotonCalcular;
        private Button BotonSalida;
    }
}