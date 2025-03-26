namespace GerenciadorGastos.Forms.CustoFixo.RemoverCusto
{
    partial class RemoverCusto
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
            label5 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 58);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 30;
            label5.Text = "Selecione um custo:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(283, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(348, 335);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 28;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(238, 335);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 31);
            label1.TabIndex = 20;
            label1.Text = "Removendo Custo";
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            button3.Location = new Point(137, 107);
            button3.Name = "button3";
            button3.Size = new Size(97, 41);
            button3.TabIndex = 31;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Cursor = Cursors.Hand;
            button4.ForeColor = Color.White;
            button4.Location = new Point(250, 107);
            button4.Name = "button4";
            button4.Size = new Size(98, 41);
            button4.TabIndex = 32;
            button4.Text = "CANCELAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // RemoverCusto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(674, 194);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "RemoverCusto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remover Custo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}