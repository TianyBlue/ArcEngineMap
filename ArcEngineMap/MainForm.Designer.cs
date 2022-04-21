namespace ArcEngineMap
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.读取文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取shapefile文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取MXD文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择要素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按属性选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按位置选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.要素操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建缓冲区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开要素属性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ScaleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CoordinatesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClearSelectionBtn = new System.Windows.Forms.Button();
            this.ClickSelect = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RectSelectBtn = new System.Windows.Forms.Button();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.MainMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.MainTOCControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开属性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放至图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改要素颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTOCControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读取文件ToolStripMenuItem,
            this.选择要素ToolStripMenuItem,
            this.要素操作ToolStripMenuItem,
            this.连接数据库ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1339, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 读取文件ToolStripMenuItem
            // 
            this.读取文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读取shapefile文件ToolStripMenuItem,
            this.读取MXD文档ToolStripMenuItem});
            this.读取文件ToolStripMenuItem.Name = "读取文件ToolStripMenuItem";
            this.读取文件ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.读取文件ToolStripMenuItem.Text = "读取文件";
            this.读取文件ToolStripMenuItem.Click += new System.EventHandler(this.读取文件ToolStripMenuItem_Click);
            // 
            // 读取shapefile文件ToolStripMenuItem
            // 
            this.读取shapefile文件ToolStripMenuItem.Name = "读取shapefile文件ToolStripMenuItem";
            this.读取shapefile文件ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.读取shapefile文件ToolStripMenuItem.Text = "读取shapefile文件";
            this.读取shapefile文件ToolStripMenuItem.Click += new System.EventHandler(this.读取shapefile文件ToolStripMenuItem_Click);
            // 
            // 读取MXD文档ToolStripMenuItem
            // 
            this.读取MXD文档ToolStripMenuItem.Name = "读取MXD文档ToolStripMenuItem";
            this.读取MXD文档ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.读取MXD文档ToolStripMenuItem.Text = "读取MXD文档";
            this.读取MXD文档ToolStripMenuItem.Click += new System.EventHandler(this.读取MXD文档ToolStripMenuItem_Click);
            // 
            // 选择要素ToolStripMenuItem
            // 
            this.选择要素ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按属性选择ToolStripMenuItem,
            this.按位置选择ToolStripMenuItem,
            this.清除选择ToolStripMenuItem});
            this.选择要素ToolStripMenuItem.Name = "选择要素ToolStripMenuItem";
            this.选择要素ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.选择要素ToolStripMenuItem.Text = "选择要素";
            // 
            // 按属性选择ToolStripMenuItem
            // 
            this.按属性选择ToolStripMenuItem.Name = "按属性选择ToolStripMenuItem";
            this.按属性选择ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按属性选择ToolStripMenuItem.Text = "按属性选择";
            this.按属性选择ToolStripMenuItem.Click += new System.EventHandler(this.按属性选择ToolStripMenuItem_Click);
            // 
            // 按位置选择ToolStripMenuItem
            // 
            this.按位置选择ToolStripMenuItem.Name = "按位置选择ToolStripMenuItem";
            this.按位置选择ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.按位置选择ToolStripMenuItem.Text = "按位置选择";
            this.按位置选择ToolStripMenuItem.Click += new System.EventHandler(this.按位置选择ToolStripMenuItem_Click);
            // 
            // 清除选择ToolStripMenuItem
            // 
            this.清除选择ToolStripMenuItem.Name = "清除选择ToolStripMenuItem";
            this.清除选择ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.清除选择ToolStripMenuItem.Text = "清除选择";
            this.清除选择ToolStripMenuItem.Click += new System.EventHandler(this.清除选择ToolStripMenuItem_Click);
            // 
            // 要素操作ToolStripMenuItem
            // 
            this.要素操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建缓冲区ToolStripMenuItem,
            this.打开要素属性表ToolStripMenuItem});
            this.要素操作ToolStripMenuItem.Name = "要素操作ToolStripMenuItem";
            this.要素操作ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.要素操作ToolStripMenuItem.Text = "要素操作";
            // 
            // 创建缓冲区ToolStripMenuItem
            // 
            this.创建缓冲区ToolStripMenuItem.Name = "创建缓冲区ToolStripMenuItem";
            this.创建缓冲区ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.创建缓冲区ToolStripMenuItem.Text = "创建缓冲区";
            this.创建缓冲区ToolStripMenuItem.Click += new System.EventHandler(this.创建缓冲区ToolStripMenuItem_Click);
            // 
            // 打开要素属性表ToolStripMenuItem
            // 
            this.打开要素属性表ToolStripMenuItem.Name = "打开要素属性表ToolStripMenuItem";
            this.打开要素属性表ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.打开要素属性表ToolStripMenuItem.Text = "打开要素属性表";
            this.打开要素属性表ToolStripMenuItem.Click += new System.EventHandler(this.打开要素属性表ToolStripMenuItem_Click);
            // 
            // 连接数据库ToolStripMenuItem
            // 
            this.连接数据库ToolStripMenuItem.Name = "连接数据库ToolStripMenuItem";
            this.连接数据库ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.连接数据库ToolStripMenuItem.Text = "连接数据库";
            this.连接数据库ToolStripMenuItem.Click += new System.EventHandler(this.连接数据库ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScaleLabel,
            this.CoordinatesLabel,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1339, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(167, 20);
            this.ScaleLabel.Text = "toolStripStatusLabel1";
            this.ScaleLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // CoordinatesLabel
            // 
            this.CoordinatesLabel.Name = "CoordinatesLabel";
            this.CoordinatesLabel.Size = new System.Drawing.Size(167, 20);
            this.CoordinatesLabel.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainMapControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainTOCControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1339, 660);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 34);
            this.panel2.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBtn.Location = new System.Drawing.Point(0, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(271, 30);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "用  户  登  录";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ClearSelectionBtn);
            this.panel3.Controls.Add(this.ClickSelect);
            this.panel3.Controls.Add(this.ClearBtn);
            this.panel3.Controls.Add(this.RectSelectBtn);
            this.panel3.Controls.Add(this.axLicenseControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(283, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 34);
            this.panel3.TabIndex = 4;
            // 
            // ClearSelectionBtn
            // 
            this.ClearSelectionBtn.Location = new System.Drawing.Point(184, 1);
            this.ClearSelectionBtn.Name = "ClearSelectionBtn";
            this.ClearSelectionBtn.Size = new System.Drawing.Size(90, 33);
            this.ClearSelectionBtn.TabIndex = 3;
            this.ClearSelectionBtn.Text = "清除选择";
            this.ClearSelectionBtn.UseVisualStyleBackColor = true;
            this.ClearSelectionBtn.Click += new System.EventHandler(this.ClearSelectionBtn_Click);
            // 
            // ClickSelect
            // 
            this.ClickSelect.Location = new System.Drawing.Point(3, 1);
            this.ClickSelect.Name = "ClickSelect";
            this.ClickSelect.Size = new System.Drawing.Size(81, 32);
            this.ClickSelect.TabIndex = 1;
            this.ClickSelect.Text = "点选";
            this.ClickSelect.UseVisualStyleBackColor = true;
            this.ClickSelect.Click += new System.EventHandler(this.ClickSelect_Click_1);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(280, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(93, 33);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "清除工具";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RectSelectBtn
            // 
            this.RectSelectBtn.Location = new System.Drawing.Point(90, 1);
            this.RectSelectBtn.Name = "RectSelectBtn";
            this.RectSelectBtn.Size = new System.Drawing.Size(90, 33);
            this.RectSelectBtn.TabIndex = 0;
            this.RectSelectBtn.Text = "框选";
            this.RectSelectBtn.UseVisualStyleBackColor = true;
            this.RectSelectBtn.Click += new System.EventHandler(this.RectSelectBtn_Click);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(632, 2);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 2;
            // 
            // MainMapControl
            // 
            this.MainMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMapControl.Location = new System.Drawing.Point(283, 43);
            this.MainMapControl.Name = "MainMapControl";
            this.MainMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainMapControl.OcxState")));
            this.MainMapControl.Size = new System.Drawing.Size(1053, 614);
            this.MainMapControl.TabIndex = 2;
            this.MainMapControl.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.MainMapControl_OnMouseDown);
            this.MainMapControl.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.MainMapControl_OnMouseMove);
            // 
            // MainTOCControl
            // 
            this.MainTOCControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTOCControl.Location = new System.Drawing.Point(3, 43);
            this.MainTOCControl.Name = "MainTOCControl";
            this.MainTOCControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainTOCControl.OcxState")));
            this.MainTOCControl.Size = new System.Drawing.Size(274, 614);
            this.MainTOCControl.TabIndex = 5;
            this.MainTOCControl.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.MainTOCControl_OnMouseDown);
            this.MainTOCControl.OnMouseUp += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseUpEventHandler(this.MainTOCControl_OnMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开属性表ToolStripMenuItem,
            this.缩放至图层ToolStripMenuItem,
            this.更改要素颜色ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 76);
            // 
            // 打开属性表ToolStripMenuItem
            // 
            this.打开属性表ToolStripMenuItem.Name = "打开属性表ToolStripMenuItem";
            this.打开属性表ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.打开属性表ToolStripMenuItem.Text = "打开属性表";
            this.打开属性表ToolStripMenuItem.Click += new System.EventHandler(this.打开属性表ToolStripMenuItem_Click);
            // 
            // 缩放至图层ToolStripMenuItem
            // 
            this.缩放至图层ToolStripMenuItem.Name = "缩放至图层ToolStripMenuItem";
            this.缩放至图层ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.缩放至图层ToolStripMenuItem.Text = "缩放至图层";
            this.缩放至图层ToolStripMenuItem.Click += new System.EventHandler(this.缩放至图层ToolStripMenuItem_Click);
            // 
            // 更改要素颜色ToolStripMenuItem
            // 
            this.更改要素颜色ToolStripMenuItem.Name = "更改要素颜色ToolStripMenuItem";
            this.更改要素颜色ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.更改要素颜色ToolStripMenuItem.Text = "更改要素颜色";
            this.更改要素颜色ToolStripMenuItem.Click += new System.EventHandler(this.更改要素颜色ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTOCControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 读取文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取shapefile文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取MXD文档ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ScaleLabel;
        private System.Windows.Forms.ToolStripStatusLabel CoordinatesLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem 选择要素ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按属性选择ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClickSelect;
        private System.Windows.Forms.Button RectSelectBtn;
        private System.Windows.Forms.Panel panel3;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Button LoginBtn;
        private ESRI.ArcGIS.Controls.AxMapControl MainMapControl;
        private System.Windows.Forms.ToolStripMenuItem 按位置选择ToolStripMenuItem;
        private ESRI.ArcGIS.Controls.AxTOCControl MainTOCControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开属性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩放至图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 要素操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建缓冲区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开要素属性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除选择ToolStripMenuItem;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ToolStripMenuItem 连接数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改要素颜色ToolStripMenuItem;
        private System.Windows.Forms.Button ClearSelectionBtn;
    }
}

