namespace ProjectNew
{
    partial class FormOfClient
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
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNumberBill = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productComboFromRepresentive = new System.Windows.Forms.ComboBox();
            this.numericUQouantity = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.rpresentiveCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRepresentitve = new System.Windows.Forms.Label();
            this.LabelTypeOfBill = new System.Windows.Forms.Label();
            this.TypeBillCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUQouantity)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(303, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 44);
            this.button5.TabIndex = 128;
            this.button5.Text = "فاتورة جديدة";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 31);
            this.comboBox1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 126;
            this.label1.Text = "أسم العميل";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(193, 269);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(563, 218);
            this.listView1.TabIndex = 125;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "الكمية";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "أسم المنتج";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "تاريخ أذن الخروج";
            this.columnHeader3.Width = 178;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "سعر الكمية";
            this.columnHeader4.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 124;
            this.label2.Text = "بيانات الفاتورة";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.panel2.Location = new System.Drawing.Point(-5, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 8);
            this.panel2.TabIndex = 123;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(9, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 44);
            this.button3.TabIndex = 122;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(9, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 44);
            this.button8.TabIndex = 121;
            this.button8.Text = "أضافة";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(605, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 39);
            this.button2.TabIndex = 120;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.labelNumberBill);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(555, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 29);
            this.panel3.TabIndex = 119;
            // 
            // labelNumberBill
            // 
            this.labelNumberBill.AutoSize = true;
            this.labelNumberBill.Location = new System.Drawing.Point(45, 9);
            this.labelNumberBill.Name = "labelNumberBill";
            this.labelNumberBill.Size = new System.Drawing.Size(35, 13);
            this.labelNumberBill.TabIndex = 113;
            this.labelNumberBill.Text = "label4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(211)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-324, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 74);
            this.button1.TabIndex = 56;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(113)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(135, -66);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(103, 32);
            this.button10.TabIndex = 54;
            this.button10.Text = "حذف";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(211)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(239, -66);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 32);
            this.button9.TabIndex = 53;
            this.button9.Text = "تعديل";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // productComboFromRepresentive
            // 
            this.productComboFromRepresentive.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboFromRepresentive.FormattingEnabled = true;
            this.productComboFromRepresentive.Location = new System.Drawing.Point(25, 115);
            this.productComboFromRepresentive.Name = "productComboFromRepresentive";
            this.productComboFromRepresentive.Size = new System.Drawing.Size(172, 31);
            this.productComboFromRepresentive.TabIndex = 118;
            this.productComboFromRepresentive.SelectedIndexChanged += new System.EventHandler(this.productComboFromRepresentive_SelectedIndexChanged);
            // 
            // numericUQouantity
            // 
            this.numericUQouantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUQouantity.Location = new System.Drawing.Point(296, 158);
            this.numericUQouantity.Name = "numericUQouantity";
            this.numericUQouantity.Size = new System.Drawing.Size(122, 31);
            this.numericUQouantity.TabIndex = 117;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(209, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 19);
            this.label17.TabIndex = 116;
            this.label17.Text = "أسم المنتج";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(434, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 19);
            this.label19.TabIndex = 115;
            this.label19.Text = "الكمية";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(681, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 19);
            this.label20.TabIndex = 114;
            this.label20.Text = "رقم الفاتورة";
            // 
            // rpresentiveCombo
            // 
            this.rpresentiveCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpresentiveCombo.FormattingEnabled = true;
            this.rpresentiveCombo.Location = new System.Drawing.Point(25, 20);
            this.rpresentiveCombo.Name = "rpresentiveCombo";
            this.rpresentiveCombo.Size = new System.Drawing.Size(172, 31);
            this.rpresentiveCombo.TabIndex = 130;
            this.rpresentiveCombo.SelectedIndexChanged += new System.EventHandler(this.rpresentiveCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 129;
            this.label4.Text = "أسم المندوب";
            // 
            // labelRepresentitve
            // 
            this.labelRepresentitve.AutoSize = true;
            this.labelRepresentitve.Location = new System.Drawing.Point(86, 26);
            this.labelRepresentitve.Name = "labelRepresentitve";
            this.labelRepresentitve.Size = new System.Drawing.Size(35, 13);
            this.labelRepresentitve.TabIndex = 131;
            this.labelRepresentitve.Text = "label5";
            this.labelRepresentitve.Visible = false;
            // 
            // LabelTypeOfBill
            // 
            this.LabelTypeOfBill.AutoSize = true;
            this.LabelTypeOfBill.Location = new System.Drawing.Point(575, 166);
            this.LabelTypeOfBill.Name = "LabelTypeOfBill";
            this.LabelTypeOfBill.Size = new System.Drawing.Size(35, 13);
            this.LabelTypeOfBill.TabIndex = 135;
            this.LabelTypeOfBill.Text = "label5";
            this.LabelTypeOfBill.Visible = false;
            // 
            // TypeBillCombo
            // 
            this.TypeBillCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBillCombo.FormattingEnabled = true;
            this.TypeBillCombo.Items.AddRange(new object[] {
            "قطاعى",
            "جملة"});
            this.TypeBillCombo.Location = new System.Drawing.Point(514, 159);
            this.TypeBillCombo.Name = "TypeBillCombo";
            this.TypeBillCombo.Size = new System.Drawing.Size(172, 31);
            this.TypeBillCombo.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(698, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 133;
            this.label6.Text = "نوع البيع";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1124, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 39);
            this.button4.TabIndex = 132;
            this.button4.Text = "حفظ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FormOfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.LabelTypeOfBill);
            this.Controls.Add(this.TypeBillCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelRepresentitve);
            this.Controls.Add(this.rpresentiveCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.productComboFromRepresentive);
            this.Controls.Add(this.numericUQouantity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Name = "FormOfClient";
            this.Text = "FormOfClient";
            this.Load += new System.EventHandler(this.FormOfClient_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUQouantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNumberBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox productComboFromRepresentive;
        private System.Windows.Forms.NumericUpDown numericUQouantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox rpresentiveCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRepresentitve;
        private System.Windows.Forms.Label LabelTypeOfBill;
        private System.Windows.Forms.ComboBox TypeBillCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}