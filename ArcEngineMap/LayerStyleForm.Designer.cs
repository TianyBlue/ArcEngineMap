namespace ArcEngineMap
{
    partial class LayerStyleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorRedBtn = new System.Windows.Forms.Button();
            this.ColorBlueBtn = new System.Windows.Forms.Button();
            this.ColorGreenBtn = new System.Windows.Forms.Button();
            this.ColorYellowBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConfirmBtn);
            this.groupBox1.Controls.Add(this.ColorYellowBtn);
            this.groupBox1.Controls.Add(this.ColorGreenBtn);
            this.groupBox1.Controls.Add(this.ColorBlueBtn);
            this.groupBox1.Controls.Add(this.ColorRedBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ColorRedBtn
            // 
            this.ColorRedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.ColorRedBtn.Location = new System.Drawing.Point(57, 34);
            this.ColorRedBtn.Name = "ColorRedBtn";
            this.ColorRedBtn.Size = new System.Drawing.Size(57, 39);
            this.ColorRedBtn.TabIndex = 0;
            this.ColorRedBtn.UseVisualStyleBackColor = false;
            this.ColorRedBtn.Click += new System.EventHandler(this.ColorRedBtn_Click);
            // 
            // ColorBlueBtn
            // 
            this.ColorBlueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(192)))), ((int)(((byte)(242)))));
            this.ColorBlueBtn.Location = new System.Drawing.Point(177, 34);
            this.ColorBlueBtn.Name = "ColorBlueBtn";
            this.ColorBlueBtn.Size = new System.Drawing.Size(57, 39);
            this.ColorBlueBtn.TabIndex = 1;
            this.ColorBlueBtn.UseVisualStyleBackColor = false;
            this.ColorBlueBtn.Click += new System.EventHandler(this.ColorBlueBtn_Click);
            // 
            // ColorGreenBtn
            // 
            this.ColorGreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(217)))), ((int)(((byte)(139)))));
            this.ColorGreenBtn.Location = new System.Drawing.Point(57, 106);
            this.ColorGreenBtn.Name = "ColorGreenBtn";
            this.ColorGreenBtn.Size = new System.Drawing.Size(57, 39);
            this.ColorGreenBtn.TabIndex = 2;
            this.ColorGreenBtn.UseVisualStyleBackColor = false;
            this.ColorGreenBtn.Click += new System.EventHandler(this.ColorGreenBtn_Click);
            // 
            // ColorYellowBtn
            // 
            this.ColorYellowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(84)))));
            this.ColorYellowBtn.Location = new System.Drawing.Point(177, 106);
            this.ColorYellowBtn.Name = "ColorYellowBtn";
            this.ColorYellowBtn.Size = new System.Drawing.Size(57, 39);
            this.ColorYellowBtn.TabIndex = 3;
            this.ColorYellowBtn.UseVisualStyleBackColor = false;
            this.ColorYellowBtn.Click += new System.EventHandler(this.ColorYellowBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(106, 167);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 4;
            this.ConfirmBtn.Text = "确认";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // LayerStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 202);
            this.Controls.Add(this.groupBox1);
            this.Name = "LayerStyleForm";
            this.Text = "LayerStyleForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ColorYellowBtn;
        private System.Windows.Forms.Button ColorGreenBtn;
        private System.Windows.Forms.Button ColorBlueBtn;
        private System.Windows.Forms.Button ColorRedBtn;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}