namespace GerenciadorGastos.Forms.ItemForms.PagarItem
{
    partial class PagarItem
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
            components = new System.ComponentModel.Container();
            checkedListBox1 = new CheckedListBox();
            itemDALBindingSource = new BindingSource(components);
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)itemDALBindingSource).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(93, 56);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(497, 172);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // itemDALBindingSource
            // 
            itemDALBindingSource.DataSource = typeof(DAL.ItemDAL);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 26);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Procure por mês:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "MMM";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(356, 26);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(55, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(93, 261);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 3;
            button1.Text = "Ver Pagos";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(199, 261);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(122, 33);
            button2.TabIndex = 4;
            button2.Text = "Pagar Tudo";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(326, 261);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(102, 33);
            button3.TabIndex = 5;
            button3.Text = "Fechar";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 230);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // PagarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 305);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "PagarItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Item";
            ((System.ComponentModel.ISupportInitialize)itemDALBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private BindingSource itemDALBindingSource;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}