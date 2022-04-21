namespace ArcEngineMap
{
    partial class FeatureAttrForm
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
            this.FieldNameListBox = new System.Windows.Forms.ListBox();
            this.FieldValueListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FieldNameListBox
            // 
            this.FieldNameListBox.FormattingEnabled = true;
            this.FieldNameListBox.ItemHeight = 15;
            this.FieldNameListBox.Location = new System.Drawing.Point(46, 77);
            this.FieldNameListBox.Name = "FieldNameListBox";
            this.FieldNameListBox.Size = new System.Drawing.Size(139, 244);
            this.FieldNameListBox.TabIndex = 0;
            // 
            // FieldValueListBox
            // 
            this.FieldValueListBox.FormattingEnabled = true;
            this.FieldValueListBox.ItemHeight = 15;
            this.FieldValueListBox.Location = new System.Drawing.Point(191, 77);
            this.FieldValueListBox.Name = "FieldValueListBox";
            this.FieldValueListBox.Size = new System.Drawing.Size(144, 244);
            this.FieldValueListBox.TabIndex = 1;
            this.FieldValueListBox.SelectedIndexChanged += new System.EventHandler(this.FieldValueListBox_SelectedIndexChanged);
            // 
            // FeatureAttrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 393);
            this.Controls.Add(this.FieldValueListBox);
            this.Controls.Add(this.FieldNameListBox);
            this.Name = "FeatureAttrForm";
            this.Text = "FeatureAttrForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FieldNameListBox;
        private System.Windows.Forms.ListBox FieldValueListBox;
    }
}