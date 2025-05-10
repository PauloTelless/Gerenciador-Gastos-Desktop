namespace GerenciadorGastos.Forms.ItemForms
{
    partial class EditarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarItem));
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button7 = new Button();
            textBox3 = new TextBox();
            button8 = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(424, 7);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 15;
            label1.Text = "Ajustando Custos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3 });
            listView1.Location = new Point(56, 93);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(298, 139);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome ";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 33);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 17;
            label2.Text = "Gasto Fixo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 33);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(56, 235);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(169, 22);
            button1.TabIndex = 19;
            button1.Text = "ADICIONAR CUSTO FIXO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(56, 261);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(169, 22);
            button2.TabIndex = 20;
            button2.Text = "REMOVER CUSTO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            button3.Location = new Point(56, 288);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(169, 22);
            button3.TabIndex = 21;
            button3.Text = "EDITAR CUSTO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 48);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 22;
            label4.Text = "Dívida:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 48);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 23;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 64);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 24;
            label6.Text = "Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 64);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 25;
            label7.Text = "label7";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader2, columnHeader6, columnHeader7 });
            listView2.Location = new Point(384, 93);
            listView2.Margin = new Padding(3, 2, 3, 2);
            listView2.Name = "listView2";
            listView2.Size = new Size(409, 139);
            listView2.TabIndex = 26;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nome";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Valor";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Parcela Atual";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Total Parcelas";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Valor Parcela";
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Cursor = Cursors.Hand;
            button4.ForeColor = Color.White;
            button4.Location = new Point(384, 288);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(169, 22);
            button4.TabIndex = 29;
            button4.Text = "EDITAR DÍVIDA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Brown;
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.White;
            button5.Location = new Point(384, 261);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(169, 22);
            button5.TabIndex = 28;
            button5.Text = "REMOVER DÍVIDA";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SeaGreen;
            button6.Cursor = Cursors.Hand;
            button6.ForeColor = Color.White;
            button6.Location = new Point(384, 235);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(169, 22);
            button6.TabIndex = 27;
            button6.Text = "ADICIONAR DÍVIDA";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(796, 116);
            label8.Name = "label8";
            label8.Size = new Size(127, 15);
            label8.TabIndex = 30;
            label8.Text = "Fatural Atual (Líquida):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(796, 139);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 31;
            label9.Text = "Fatura Limite: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(929, 116);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 32;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(879, 139);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 33;
            label11.Text = "label11";
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(964, 76);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(38, 30);
            button7.TabIndex = 36;
            button7.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(800, 182);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 23);
            textBox3.TabIndex = 37;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(891, 177);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(38, 30);
            button8.TabIndex = 38;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(834, 94);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 39;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(797, 94);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 40;
            label13.Text = "Data:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(796, 160);
            label14.Name = "label14";
            label14.Size = new Size(93, 15);
            label14.TabIndex = 41;
            label14.Text = "Valor disponível:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(891, 160);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 42;
            label15.Text = "label15";
            // 
            // button9
            // 
            button9.BackColor = Color.Brown;
            button9.Cursor = Cursors.Hand;
            button9.ForeColor = Color.White;
            button9.Location = new Point(807, 288);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(169, 22);
            button9.TabIndex = 43;
            button9.Text = "FECHAR";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkOrange;
            button10.Cursor = Cursors.Hand;
            button10.ForeColor = Color.White;
            button10.Location = new Point(559, 235);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(169, 22);
            button10.TabIndex = 44;
            button10.Text = "ANTECIPAR PARCELA";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // EditarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1009, 338);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(button8);
            Controls.Add(textBox3);
            Controls.Add(button7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(listView2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "EditarItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajustar Custos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button7;
        private TextBox textBox3;
        private Button button8;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button9;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button button10;
    }
}