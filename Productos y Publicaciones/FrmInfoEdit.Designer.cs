namespace Tablas_Semana_3.Productos_y_Publicaciones
{
    partial class FrmInfoEdit
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            labelDesc = new Label();
            labelTitulo = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(719, 113);
            label6.Name = "label6";
            label6.Size = new Size(10, 12);
            label6.TabIndex = 41;
            label6.Text = "*";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(512, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 40;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(512, 243);
            button1.Name = "button1";
            button1.Size = new Size(201, 23);
            button1.TabIndex = 39;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(365, 149);
            label2.Name = "label2";
            label2.Size = new Size(35, 12);
            label2.TabIndex = 38;
            label2.Text = "Logo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 118);
            label1.Name = "label1";
            label1.Size = new Size(43, 12);
            label1.TabIndex = 36;
            label1.Text = "Editor";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(87, 149);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(223, 65);
            labelDesc.TabIndex = 35;
            labelDesc.Text = "Inserte/Edite la información de\r\nlas distintas editoriales llenando\r\nlos campos necesarios\r\n\r\n\r\n";
            labelDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(104, 118);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(177, 18);
            labelTitulo.TabIndex = 34;
            labelTitulo.Text = "Información Editorial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(719, 173);
            label3.Name = "label3";
            label3.Size = new Size(10, 12);
            label3.TabIndex = 44;
            label3.Text = "*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(512, 173);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 41);
            textBox2.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 178);
            label4.Name = "label4";
            label4.Size = new Size(77, 12);
            label4.TabIndex = 42;
            label4.Text = "Información";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(512, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 45;
            // 
            // FrmInfoEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelDesc);
            Controls.Add(labelTitulo);
            Name = "FrmInfoEdit";
            Text = "FrmInfoEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label labelDesc;
        private Label labelTitulo;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox2;
    }
}