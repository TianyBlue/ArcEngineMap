namespace ArcEngineMap
{
    partial class SelectByLocForm
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
            this.TargetLayerComboBox = new System.Windows.Forms.ComboBox();
            this.MethodListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TargetLayerComboBox
            // 
            this.TargetLayerComboBox.Font = new System.Drawing.Font("宋体", 12F);
            this.TargetLayerComboBox.FormattingEnabled = true;
            this.TargetLayerComboBox.Location = new System.Drawing.Point(44, 63);
            this.TargetLayerComboBox.Name = "TargetLayerComboBox";
            this.TargetLayerComboBox.Size = new System.Drawing.Size(336, 28);
            this.TargetLayerComboBox.TabIndex = 1;
            this.TargetLayerComboBox.SelectedIndexChanged += new System.EventHandler(this.TargetLayerComboBox_SelectedIndexChanged);
            // 
            // MethodListBox
            // 
            this.MethodListBox.FormattingEnabled = true;
            this.MethodListBox.ItemHeight = 15;
            this.MethodListBox.Items.AddRange(new object[] {
            "与该要素相交",
            "与该要素相离",
            "被该要素包含",
            "与该要素邻接",
            "在……范围以内"});
            this.MethodListBox.Location = new System.Drawing.Point(50, 39);
            this.MethodListBox.Name = "MethodListBox";
            this.MethodListBox.Size = new System.Drawing.Size(236, 139);
            this.MethodListBox.TabIndex = 2;
            this.MethodListBox.Click += new System.EventHandler(this.MethodListBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MethodListBox);
            this.groupBox1.Location = new System.Drawing.Point(44, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 224);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择条件";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(94, 395);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(233, 25);
            this.ConditionTextBox.TabIndex = 4;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(167, 468);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "搜索";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "设定值(如果需要)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "目标图层";
            // 
            // SelectByLocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TargetLayerComboBox);
            this.Name = "SelectByLocForm";
            this.Text = "SelectByLocForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TargetLayerComboBox;
        private System.Windows.Forms.ListBox MethodListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}