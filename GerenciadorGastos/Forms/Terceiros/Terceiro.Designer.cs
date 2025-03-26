namespace GerenciadorGastos.Forms.Terceiros
{
    partial class Terceiro
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 9);
            label1.Name = "label1";
            label1.Size = new Size(400, 41);
            label1.TabIndex = 0;
            label1.Text = "Exibindo Custos De Terceiros";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(99, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(605, 207);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 290);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 290);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(577, 328);
            button1.Name = "button1";
            button1.Size = new Size(127, 51);
            button1.TabIndex = 4;
            button1.Text = "FECHAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Data Cadastro";
            // 
            // Terceiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Terceiro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terceiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label2;
        private Label label3;
        private Button button1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}