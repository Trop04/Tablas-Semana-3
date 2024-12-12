namespace Tablas_Semana_3.Productos_y_Publicaciones
{
    partial class FrmAutorTitulo
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
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelDesc = new Label();
            labelTitulo = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(731, 64);
            label6.Name = "label6";
            label6.Size = new Size(10, 12);
            label6.TabIndex = 33;
            label6.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 100);
            label2.Name = "label2";
            label2.Size = new Size(42, 12);
            label2.TabIndex = 31;
            label2.Text = "Titulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 12);
            label1.TabIndex = 29;
            label1.Text = "Autor";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(65, 94);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(207, 65);
            labelDesc.TabIndex = 28;
            labelDesc.Text = "Inserte/Edite la asociación de \r\nautores llenando\r\nlos campos necesarios\r\n\r\n\r\n";
            labelDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(96, 69);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(146, 18);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "Autores y Títulos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(354, 129);
            label3.Name = "label3";
            label3.Size = new Size(160, 12);
            label3.TabIndex = 34;
            label3.Text = "Porcentaje(%) de Regalías";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(731, 94);
            label4.Name = "label4";
            label4.Size = new Size(10, 12);
            label4.TabIndex = 36;
            label4.Text = "*";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(685, 123);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 23);
            numericUpDown1.TabIndex = 37;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(524, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 38;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(524, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 39;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(524, 162);
            button1.Name = "button1";
            button1.Size = new Size(201, 23);
            button1.TabIndex = 40;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmAutorTitulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelDesc);
            Controls.Add(labelTitulo);
            Name = "FrmAutorTitulo";
            Text = "FrmAutorTitulo";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private Label label1;
        private Label labelDesc;
        private Label labelTitulo;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}