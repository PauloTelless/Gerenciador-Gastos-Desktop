﻿namespace GerenciadorGastos.Forms
{
    partial class Index
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
            ListViewItem listViewItem2 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            panel1 = new Panel();
            label10 = new Label();
            label4 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            listView1 = new ListView();
            nomeProdutoColuna = new ColumnHeader();
            valorColuna = new ColumnHeader();
            nomePessoaColuna = new ColumnHeader();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(465, 597);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 150);
            panel1.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(102, 39);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 19;
            label10.Text = "label10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 39);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 23;
            label4.Text = "Total no mês:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(119, 100);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 22;
            label9.Text = "label9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 10);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 21;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(144, 70);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 22;
            label8.Text = "label8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-1, 70);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 21;
            label6.Text = "Disponível / Semana:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 100);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 20;
            label5.Text = "Disponível / Mês:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 10);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 19;
            label3.Text = "Total no dia:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(318, 27);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { nomeProdutoColuna, valorColuna, nomePessoaColuna });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(20, 54);
            listView1.Name = "listView1";
            listView1.Size = new Size(439, 693);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // nomeProdutoColuna
            // 
            nomeProdutoColuna.Text = "Nome";
            // 
            // valorColuna
            // 
            valorColuna.Text = "Valor";
            // 
            // nomePessoaColuna
            // 
            nomePessoaColuna.Text = "Pessoa";
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(495, 177);
            button3.Name = "button3";
            button3.Size = new Size(181, 55);
            button3.TabIndex = 14;
            button3.Text = "AJUSTAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(495, 99);
            button2.Name = "button2";
            button2.Size = new Size(181, 55);
            button2.TabIndex = 13;
            button2.Text = "REMOVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(495, 21);
            button1.Name = "button1";
            button1.Size = new Size(181, 55);
            button1.TabIndex = 12;
            button1.Text = "ADICIONAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 11;
            label1.Text = "Selecionar data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 54);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 18;
            label2.Text = "Não possuem itens para esse dia ";
            label2.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(495, 256);
            button5.Name = "button5";
            button5.Size = new Size(181, 55);
            button5.TabIndex = 20;
            button5.Text = "VER TERCEIRO";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(20, 753);
            button6.Name = "button6";
            button6.Size = new Size(35, 33);
            button6.TabIndex = 21;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(696, 838);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Index";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador Gastos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private ListView listView1;
        private ColumnHeader nomeProdutoColuna;
        private ColumnHeader valorColuna;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label4;
        private Button button5;
        private Button button6;
        internal ColumnHeader nomePessoaColuna;
    }
}