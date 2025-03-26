namespace GerenciadorGastos.Forms.ItemForms
{
    partial class RemoverItem
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
            comboBox2 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(238, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(297, 28);
            comboBox2.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(68, 139);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 30;
            label5.Text = "Selecione o item:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(68, 86);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 29;
            label4.Text = "Data do registro: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 13);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
            label1.TabIndex = 26;
            label1.Text = "Removendo Item";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(238, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 27);
            dateTimePicker1.TabIndex = 38;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(68, 237);
            button1.Name = "button1";
            button1.Size = new Size(115, 45);
            button1.TabIndex = 39;
            button1.Text = "REMOVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(190, 237);
            button2.Name = "button2";
            button2.Size = new Size(134, 45);
            button2.TabIndex = 40;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RemoverItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 352);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "RemoverItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remover Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private Label label5;
        private Label label4;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}