namespace Tablas_Semana_3.Productos_y_Publicaciones
{
    partial class FrmEditor
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            labelDesc = new Label();
            labelTitulo = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(520, 224);
            button1.Name = "button1";
            button1.Size = new Size(201, 23);
            button1.TabIndex = 26;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(373, 130);
            label2.Name = "label2";
            label2.Size = new Size(47, 12);
            label2.TabIndex = 24;
            label2.Text = "Ciudad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(520, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 99);
            label1.Name = "label1";
            label1.Size = new Size(116, 12);
            label1.TabIndex = 22;
            label1.Text = "Nombre del Editor";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(79, 130);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(239, 52);
            labelDesc.TabIndex = 21;
            labelDesc.Text = "Inserte/Edite los editores llenando\r\nlos campos necesarios\r\n\r\n\r\n";
            labelDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(162, 99);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(57, 18);
            labelTitulo.TabIndex = 20;
            labelTitulo.Text = "Editor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(373, 159);
            label3.Name = "label3";
            label3.Size = new Size(47, 12);
            label3.TabIndex = 27;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(373, 188);
            label4.Name = "label4";
            label4.Size = new Size(28, 12);
            label4.TabIndex = 29;
            label4.Text = "País";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(520, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(520, 154);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 31;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(520, 183);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(201, 23);
            comboBox3.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(727, 94);
            label6.Name = "label6";
            label6.Size = new Size(10, 12);
            label6.TabIndex = 33;
            label6.Text = "*";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(727, 151);
            label5.Name = "label5";
            label5.Size = new Size(10, 12);
            label5.TabIndex = 34;
            label5.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(727, 183);
            label7.Name = "label7";
            label7.Size = new Size(10, 12);
            label7.TabIndex = 35;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(727, 120);
            label8.Name = "label8";
            label8.Size = new Size(10, 12);
            label8.TabIndex = 36;
            label8.Text = "*";
            // 
            // FrmEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(labelDesc);
            Controls.Add(labelTitulo);
            Name = "FrmEditor";
            Text = "FrmEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label labelDesc;
        private Label labelTitulo;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
    }
}