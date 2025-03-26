namespace GerenciadorGastos.Forms.CustoFixo.AlterarCusto
{
    partial class EditarCusto
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(282, 257);
            button2.Name = "button2";
            button2.Size = new Size(99, 42);
            button2.TabIndex = 17;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(155, 257);
            button1.Name = "button1";
            button1.Size = new Size(104, 42);
            button1.TabIndex = 16;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 201);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 15;
            label4.Text = "Data Cadastro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 155);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 98);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 13;
            label2.Text = "Nome:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(265, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 9;
            label1.Text = "Editando Custo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 58);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 19;
            label5.Text = "Selecione um custo:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(264, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // EditarCusto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(673, 324);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "EditarCusto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Custo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private ComboBox comboBox1;
    }
}