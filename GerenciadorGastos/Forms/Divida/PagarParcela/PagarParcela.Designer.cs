namespace GerenciadorGastos.Forms.Divida.PagarParcela
{
    partial class PagarParcela
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 8);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 0;
            label1.Text = "Pagando Parcela";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 48);
            label2.Name = "label2";
            label2.Size = new Size(113, 13);
            label2.TabIndex = 1;
            label2.Text = "Selecione uma dívida:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 21);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 86);
            label3.Name = "label3";
            label3.Size = new Size(151, 13);
            label3.TabIndex = 3;
            label3.Text = "Número de parcelas restantes:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(290, 109);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 21);
            comboBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 112);
            label4.Name = "label4";
            label4.Size = new Size(171, 13);
            label4.TabIndex = 5;
            label4.Text = "Número de parcela para antecipar:";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(113, 157);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 6;
            button1.Text = "ANTECIPAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(232, 157);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 7;
            button2.Text = "FECHAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PagarParcela
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(526, 204);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "PagarParcela";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Parcela";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}