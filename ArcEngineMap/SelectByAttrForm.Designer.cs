namespace ArcEngineMap
{
    partial class SelectByAttrForm
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
            this.LayerNameComboBox = new System.Windows.Forms.ComboBox();
            this.FieldsListBox = new System.Windows.Forms.ListBox();
            this.表达式 = new System.Windows.Forms.GroupBox();
            this.btnbetween = new System.Windows.Forms.Button();
            this.btncharacter = new System.Windows.Forms.Button();
            this.btnpercent = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnand = new System.Windows.Forms.Button();
            this.btnnot = new System.Windows.Forms.Button();
            this.btnless = new System.Windows.Forms.Button();
            this.btnnull = new System.Windows.Forms.Button();
            this.btnor = new System.Windows.Forms.Button();
            this.btnloe = new System.Windows.Forms.Button();
            this.btnmoe = new System.Windows.Forms.Button();
            this.btnmore = new System.Windows.Forms.Button();
            this.btnlike = new System.Windows.Forms.Button();
            this.btnis = new System.Windows.Forms.Button();
            this.btnunequal = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.SQLTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PotentialValListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.表达式.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayerNameComboBox
            // 
            this.LayerNameComboBox.Font = new System.Drawing.Font("宋体", 12F);
            this.LayerNameComboBox.FormattingEnabled = true;
            this.LayerNameComboBox.Location = new System.Drawing.Point(119, 27);
            this.LayerNameComboBox.Name = "LayerNameComboBox";
            this.LayerNameComboBox.Size = new System.Drawing.Size(358, 28);
            this.LayerNameComboBox.TabIndex = 0;
            this.LayerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.LayerNameComboBox_SelectedIndexChanged);
            // 
            // FieldsListBox
            // 
            this.FieldsListBox.FormattingEnabled = true;
            this.FieldsListBox.ItemHeight = 15;
            this.FieldsListBox.Location = new System.Drawing.Point(38, 74);
            this.FieldsListBox.Name = "FieldsListBox";
            this.FieldsListBox.Size = new System.Drawing.Size(439, 94);
            this.FieldsListBox.TabIndex = 1;
            this.FieldsListBox.SelectedIndexChanged += new System.EventHandler(this.FieldsListBox_SelectedIndexChanged);
            this.FieldsListBox.DoubleClick += new System.EventHandler(this.FieldsListBox_DoubleClick);
            // 
            // 表达式
            // 
            this.表达式.Controls.Add(this.btnbetween);
            this.表达式.Controls.Add(this.btncharacter);
            this.表达式.Controls.Add(this.btnpercent);
            this.表达式.Controls.Add(this.btnin);
            this.表达式.Controls.Add(this.btnand);
            this.表达式.Controls.Add(this.btnnot);
            this.表达式.Controls.Add(this.btnless);
            this.表达式.Controls.Add(this.btnnull);
            this.表达式.Controls.Add(this.btnor);
            this.表达式.Controls.Add(this.btnloe);
            this.表达式.Controls.Add(this.btnmoe);
            this.表达式.Controls.Add(this.btnmore);
            this.表达式.Controls.Add(this.btnlike);
            this.表达式.Controls.Add(this.btnis);
            this.表达式.Controls.Add(this.btnunequal);
            this.表达式.Controls.Add(this.btnequal);
            this.表达式.Location = new System.Drawing.Point(33, 196);
            this.表达式.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.表达式.Name = "表达式";
            this.表达式.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.表达式.Size = new System.Drawing.Size(230, 214);
            this.表达式.TabIndex = 4;
            this.表达式.TabStop = false;
            this.表达式.Text = "表达式";
            // 
            // btnbetween
            // 
            this.btnbetween.Location = new System.Drawing.Point(79, 111);
            this.btnbetween.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbetween.Name = "btnbetween";
            this.btnbetween.Size = new System.Drawing.Size(79, 22);
            this.btnbetween.TabIndex = 16;
            this.btnbetween.Text = "Between";
            this.btnbetween.UseVisualStyleBackColor = true;
            this.btnbetween.Click += new System.EventHandler(this.btnbetween_Click);
            // 
            // btncharacter
            // 
            this.btncharacter.Location = new System.Drawing.Point(21, 111);
            this.btncharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncharacter.Name = "btncharacter";
            this.btncharacter.Size = new System.Drawing.Size(52, 22);
            this.btncharacter.TabIndex = 15;
            this.btncharacter.Text = "\' \'";
            this.btncharacter.UseVisualStyleBackColor = true;
            this.btncharacter.Click += new System.EventHandler(this.btncharacter_Click);
            // 
            // btnpercent
            // 
            this.btnpercent.Location = new System.Drawing.Point(167, 111);
            this.btnpercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpercent.Name = "btnpercent";
            this.btnpercent.Size = new System.Drawing.Size(52, 22);
            this.btnpercent.TabIndex = 14;
            this.btnpercent.Text = "%";
            this.btnpercent.UseVisualStyleBackColor = true;
            this.btnpercent.Click += new System.EventHandler(this.btnpercent_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(21, 179);
            this.btnin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(52, 22);
            this.btnin.TabIndex = 12;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnand
            // 
            this.btnand.Location = new System.Drawing.Point(93, 82);
            this.btnand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnand.Name = "btnand";
            this.btnand.Size = new System.Drawing.Size(52, 22);
            this.btnand.TabIndex = 11;
            this.btnand.Text = "And";
            this.btnand.UseVisualStyleBackColor = true;
            this.btnand.Click += new System.EventHandler(this.btnand_Click);
            // 
            // btnnot
            // 
            this.btnnot.Location = new System.Drawing.Point(21, 82);
            this.btnnot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnot.Name = "btnnot";
            this.btnnot.Size = new System.Drawing.Size(52, 22);
            this.btnnot.TabIndex = 10;
            this.btnnot.Text = "Not";
            this.btnnot.UseVisualStyleBackColor = true;
            this.btnnot.Click += new System.EventHandler(this.btnnot_Click);
            // 
            // btnless
            // 
            this.btnless.Location = new System.Drawing.Point(167, 52);
            this.btnless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnless.Name = "btnless";
            this.btnless.Size = new System.Drawing.Size(52, 22);
            this.btnless.TabIndex = 9;
            this.btnless.Text = "<";
            this.btnless.UseVisualStyleBackColor = true;
            this.btnless.Click += new System.EventHandler(this.btnless_Click);
            // 
            // btnnull
            // 
            this.btnnull.Location = new System.Drawing.Point(93, 144);
            this.btnnull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnull.Name = "btnnull";
            this.btnnull.Size = new System.Drawing.Size(52, 22);
            this.btnnull.TabIndex = 8;
            this.btnnull.Text = "Null";
            this.btnnull.UseVisualStyleBackColor = true;
            this.btnnull.Click += new System.EventHandler(this.btnnull_Click);
            // 
            // btnor
            // 
            this.btnor.Location = new System.Drawing.Point(167, 144);
            this.btnor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnor.Name = "btnor";
            this.btnor.Size = new System.Drawing.Size(52, 22);
            this.btnor.TabIndex = 7;
            this.btnor.Text = "Or";
            this.btnor.UseVisualStyleBackColor = true;
            this.btnor.Click += new System.EventHandler(this.btnor_Click);
            // 
            // btnloe
            // 
            this.btnloe.Location = new System.Drawing.Point(93, 52);
            this.btnloe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnloe.Name = "btnloe";
            this.btnloe.Size = new System.Drawing.Size(52, 22);
            this.btnloe.TabIndex = 6;
            this.btnloe.Text = "<=";
            this.btnloe.UseVisualStyleBackColor = true;
            this.btnloe.Click += new System.EventHandler(this.btnloe_Click);
            // 
            // btnmoe
            // 
            this.btnmoe.Location = new System.Drawing.Point(21, 52);
            this.btnmoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmoe.Name = "btnmoe";
            this.btnmoe.Size = new System.Drawing.Size(52, 22);
            this.btnmoe.TabIndex = 5;
            this.btnmoe.Text = ">=";
            this.btnmoe.UseVisualStyleBackColor = true;
            this.btnmoe.Click += new System.EventHandler(this.btnmoe_Click);
            // 
            // btnmore
            // 
            this.btnmore.Location = new System.Drawing.Point(167, 22);
            this.btnmore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmore.Name = "btnmore";
            this.btnmore.Size = new System.Drawing.Size(52, 22);
            this.btnmore.TabIndex = 4;
            this.btnmore.Text = ">";
            this.btnmore.UseVisualStyleBackColor = true;
            this.btnmore.Click += new System.EventHandler(this.btnmore_Click);
            // 
            // btnlike
            // 
            this.btnlike.Location = new System.Drawing.Point(167, 82);
            this.btnlike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlike.Name = "btnlike";
            this.btnlike.Size = new System.Drawing.Size(52, 22);
            this.btnlike.TabIndex = 3;
            this.btnlike.Text = "like";
            this.btnlike.UseVisualStyleBackColor = true;
            this.btnlike.Click += new System.EventHandler(this.btnlike_Click);
            // 
            // btnis
            // 
            this.btnis.Location = new System.Drawing.Point(21, 144);
            this.btnis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnis.Name = "btnis";
            this.btnis.Size = new System.Drawing.Size(52, 22);
            this.btnis.TabIndex = 2;
            this.btnis.Text = "is";
            this.btnis.UseVisualStyleBackColor = true;
            this.btnis.Click += new System.EventHandler(this.btnis_Click);
            // 
            // btnunequal
            // 
            this.btnunequal.Location = new System.Drawing.Point(93, 22);
            this.btnunequal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnunequal.Name = "btnunequal";
            this.btnunequal.Size = new System.Drawing.Size(52, 22);
            this.btnunequal.TabIndex = 1;
            this.btnunequal.Text = "！=";
            this.btnunequal.UseVisualStyleBackColor = true;
            this.btnunequal.Click += new System.EventHandler(this.btnunequal_Click);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(21, 22);
            this.btnequal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(52, 22);
            this.btnequal.TabIndex = 0;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // SQLTextBox
            // 
            this.SQLTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.SQLTextBox.Location = new System.Drawing.Point(33, 451);
            this.SQLTextBox.Name = "SQLTextBox";
            this.SQLTextBox.Size = new System.Drawing.Size(444, 30);
            this.SQLTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "图层";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("宋体", 12F);
            this.ConfirmButton.Location = new System.Drawing.Point(189, 512);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(121, 40);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "确 定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PotentialValListBox
            // 
            this.PotentialValListBox.FormattingEnabled = true;
            this.PotentialValListBox.ItemHeight = 15;
            this.PotentialValListBox.Location = new System.Drawing.Point(282, 196);
            this.PotentialValListBox.Name = "PotentialValListBox";
            this.PotentialValListBox.Size = new System.Drawing.Size(195, 214);
            this.PotentialValListBox.TabIndex = 8;
            this.PotentialValListBox.DoubleClick += new System.EventHandler(this.PotentialValListBox_DoubleClick);
            // 
            // SelectByAttrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 564);
            this.Controls.Add(this.PotentialValListBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SQLTextBox);
            this.Controls.Add(this.表达式);
            this.Controls.Add(this.FieldsListBox);
            this.Controls.Add(this.LayerNameComboBox);
            this.Name = "SelectByAttrForm";
            this.Text = "SelectForm";
            this.表达式.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LayerNameComboBox;
        private System.Windows.Forms.ListBox FieldsListBox;
        private System.Windows.Forms.GroupBox 表达式;
        private System.Windows.Forms.Button btnbetween;
        private System.Windows.Forms.Button btncharacter;
        private System.Windows.Forms.Button btnpercent;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnand;
        private System.Windows.Forms.Button btnnot;
        private System.Windows.Forms.Button btnless;
        private System.Windows.Forms.Button btnnull;
        private System.Windows.Forms.Button btnor;
        private System.Windows.Forms.Button btnloe;
        private System.Windows.Forms.Button btnmoe;
        private System.Windows.Forms.Button btnmore;
        private System.Windows.Forms.Button btnlike;
        private System.Windows.Forms.Button btnis;
        private System.Windows.Forms.Button btnunequal;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.TextBox SQLTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ListBox PotentialValListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}