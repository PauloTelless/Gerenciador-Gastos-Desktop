namespace GerenciadorGastos.Forms.ItemForms
{
    partial class ItensPagos
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMM";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(362, 2);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(53, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 2);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 4;
            label1.Text = "Procure por mês:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(80, 29);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(497, 172);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(80, 235);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(93, 27);
            button1.TabIndex = 6;
            button1.Text = "FECHAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 203);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // ItensPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 263);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "ItensPagos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Itens Pagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Label label2;
    }
}