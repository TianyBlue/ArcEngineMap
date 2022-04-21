namespace ArcEngineMap
{
    partial class LayerAttrForm
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
            this.AttrTableView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AttrTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // AttrTableView
            // 
            this.AttrTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttrTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttrTableView.Location = new System.Drawing.Point(0, 0);
            this.AttrTableView.Name = "AttrTableView";
            this.AttrTableView.RowHeadersWidth = 51;
            this.AttrTableView.RowTemplate.Height = 27;
            this.AttrTableView.Size = new System.Drawing.Size(587, 523);
            this.AttrTableView.TabIndex = 0;
            // 
            // LayerAttrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 523);
            this.Controls.Add(this.AttrTableView);
            this.Name = "LayerAttrForm";
            this.Text = "LayerAttrForm";
            ((System.ComponentModel.ISupportInitialize)(this.AttrTableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AttrTableView;
    }
}