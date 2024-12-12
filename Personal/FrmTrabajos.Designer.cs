namespace Tablas_Semana_3.Personal
{
    partial class FrmTrabajos
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
            button1 = new Button();
            label6 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            labelDesc = new Label();
            labelTitulo = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(512, 262);
            button1.Name = "button1";
            button1.Size = new Size(201, 23);
            button1.TabIndex = 27;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(719, 151);
            label6.Name = "label6";
            label6.Size = new Size(10, 12);
            label6.TabIndex = 26;
            label6.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(365, 159);
            label2.Name = "label2";
            label2.Size = new Size(132, 12);
            label2.TabIndex = 24;
            label2.Text = "Salario mínimo ($/hr)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(512, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 52);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 99);
            label1.Name = "label1";
            label1.Size = new Size(77, 12);
            label1.TabIndex = 22;
            label1.Text = "Descripción";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(71, 130);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(226, 52);
            labelDesc.TabIndex = 21;
            labelDesc.Text = "Inserte/Edite los cargos llenando\r\nlos campos necesarios\r\n\r\n\r\n";
            labelDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(145, 99);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(78, 18);
            labelTitulo.TabIndex = 20;
            labelTitulo.Text = "Trabajos";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(660, 152);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 28;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(660, 181);
            numericUpDown2.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(53, 23);
            numericUpDown2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(365, 188);
            label3.Name = "label3";
            label3.Size = new Size(135, 12);
            label3.TabIndex = 29;
            label3.Text = "Salario máximo ($/hr)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(719, 181);
            label4.Name = "label4";
            label4.Size = new Size(10, 12);
            label4.TabIndex = 31;
            label4.Text = "*";
            // 
            // FrmTrabajos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(labelDesc);
            Controls.Add(labelTitulo);
            Name = "FrmTrabajos";
            Text = "FrmTrabajos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label labelDesc;
        private Label labelTitulo;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
    }
}