namespace TMSapp
{
    partial class frmHangDi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGaDen = new System.Windows.Forms.TabPage();
            this.treeViewGaDen = new System.Windows.Forms.TreeView();
            this.tabPageKhachHang = new System.Windows.Forms.TabPage();
            this.treeViewKhachHang = new System.Windows.Forms.TreeView();
            this.tabPageThoiGian = new System.Windows.Forms.TabPage();
            this.treeViewThoiGian = new System.Windows.Forms.TreeView();
            this.tabControlDSBB = new System.Windows.Forms.TabControl();
            this.tabPageDSBB = new System.Windows.Forms.TabPage();
            this.btnInBienBan = new System.Windows.Forms.Button();
            this.dataGridViewHangdi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCheck = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGaDen.SuspendLayout();
            this.tabPageKhachHang.SuspendLayout();
            this.tabPageThoiGian.SuspendLayout();
            this.tabControlDSBB.SuspendLayout();
            this.tabPageDSBB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangdi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlDSBB);
            this.splitContainer1.Size = new System.Drawing.Size(1056, 509);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPageGaDen);
            this.tabControl.Controls.Add(this.tabPageKhachHang);
            this.tabControl.Controls.Add(this.tabPageThoiGian);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(285, 509);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGaDen
            // 
            this.tabPageGaDen.Controls.Add(this.treeViewGaDen);
            this.tabPageGaDen.Location = new System.Drawing.Point(4, 4);
            this.tabPageGaDen.Name = "tabPageGaDen";
            this.tabPageGaDen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGaDen.Size = new System.Drawing.Size(277, 483);
            this.tabPageGaDen.TabIndex = 0;
            this.tabPageGaDen.Text = "Ga đến";
            this.tabPageGaDen.UseVisualStyleBackColor = true;
            // 
            // treeViewGaDen
            // 
            this.treeViewGaDen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGaDen.Location = new System.Drawing.Point(3, 3);
            this.treeViewGaDen.Name = "treeViewGaDen";
            this.treeViewGaDen.Size = new System.Drawing.Size(271, 477);
            this.treeViewGaDen.TabIndex = 0;
            this.treeViewGaDen.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGaDen_AfterSelect);
            // 
            // tabPageKhachHang
            // 
            this.tabPageKhachHang.Controls.Add(this.treeViewKhachHang);
            this.tabPageKhachHang.Location = new System.Drawing.Point(4, 4);
            this.tabPageKhachHang.Name = "tabPageKhachHang";
            this.tabPageKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKhachHang.Size = new System.Drawing.Size(277, 483);
            this.tabPageKhachHang.TabIndex = 1;
            this.tabPageKhachHang.Text = "Khách hàng";
            this.tabPageKhachHang.UseVisualStyleBackColor = true;
            // 
            // treeViewKhachHang
            // 
            this.treeViewKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewKhachHang.Location = new System.Drawing.Point(3, 3);
            this.treeViewKhachHang.Name = "treeViewKhachHang";
            this.treeViewKhachHang.Size = new System.Drawing.Size(271, 477);
            this.treeViewKhachHang.TabIndex = 0;
            this.treeViewKhachHang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewKhachHang_AfterSelect);
            // 
            // tabPageThoiGian
            // 
            this.tabPageThoiGian.Controls.Add(this.treeViewThoiGian);
            this.tabPageThoiGian.Location = new System.Drawing.Point(4, 4);
            this.tabPageThoiGian.Name = "tabPageThoiGian";
            this.tabPageThoiGian.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThoiGian.Size = new System.Drawing.Size(277, 483);
            this.tabPageThoiGian.TabIndex = 2;
            this.tabPageThoiGian.Text = "Thời gian";
            this.tabPageThoiGian.UseVisualStyleBackColor = true;
            // 
            // treeViewThoiGian
            // 
            this.treeViewThoiGian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewThoiGian.Location = new System.Drawing.Point(3, 3);
            this.treeViewThoiGian.Name = "treeViewThoiGian";
            this.treeViewThoiGian.Size = new System.Drawing.Size(271, 477);
            this.treeViewThoiGian.TabIndex = 0;
            this.treeViewThoiGian.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewThoiGian_AfterSelect);
            // 
            // tabControlDSBB
            // 
            this.tabControlDSBB.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlDSBB.Controls.Add(this.tabPageDSBB);
            this.tabControlDSBB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDSBB.Location = new System.Drawing.Point(0, 0);
            this.tabControlDSBB.Name = "tabControlDSBB";
            this.tabControlDSBB.SelectedIndex = 0;
            this.tabControlDSBB.Size = new System.Drawing.Size(767, 509);
            this.tabControlDSBB.TabIndex = 0;
            // 
            // tabPageDSBB
            // 
            this.tabPageDSBB.Controls.Add(this.btnInBienBan);
            this.tabPageDSBB.Controls.Add(this.dataGridViewHangdi);
            this.tabPageDSBB.Location = new System.Drawing.Point(4, 4);
            this.tabPageDSBB.Name = "tabPageDSBB";
            this.tabPageDSBB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDSBB.Size = new System.Drawing.Size(759, 483);
            this.tabPageDSBB.TabIndex = 0;
            this.tabPageDSBB.Text = "Danh sách biên bản";
            this.tabPageDSBB.UseVisualStyleBackColor = true;
            // 
            // btnInBienBan
            // 
            this.btnInBienBan.Location = new System.Drawing.Point(3, 3);
            this.btnInBienBan.Name = "btnInBienBan";
            this.btnInBienBan.Size = new System.Drawing.Size(113, 32);
            this.btnInBienBan.TabIndex = 1;
            this.btnInBienBan.Text = "In biên bản";
            this.btnInBienBan.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHangdi
            // 
            this.dataGridViewHangdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHangdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHangdi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHangdi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewHangdi.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewHangdi.Name = "dataGridViewHangdi";
            this.dataGridViewHangdi.Size = new System.Drawing.Size(753, 439);
            this.dataGridViewHangdi.TabIndex = 0;
            this.dataGridViewHangdi.DoubleClick += new System.EventHandler(this.dataGridViewHangdi_DoubleClick);
            // 
            // colCheck
            // 
            this.colCheck.Checked = true;
            this.colCheck.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.colCheck.CheckValue = null;
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = false;
            this.colCheck.Width = 20;
            // 
            // frmHangDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 509);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHangDi";
            this.Text = "frmHangDi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHangDi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageGaDen.ResumeLayout(false);
            this.tabPageKhachHang.ResumeLayout(false);
            this.tabPageThoiGian.ResumeLayout(false);
            this.tabControlDSBB.ResumeLayout(false);
            this.tabPageDSBB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangdi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGaDen;
        private System.Windows.Forms.TabPage tabPageKhachHang;
        private System.Windows.Forms.TabControl tabControlDSBB;
        private System.Windows.Forms.TabPage tabPageDSBB;
        private System.Windows.Forms.Button btnInBienBan;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewHangdi;
        private System.Windows.Forms.TabPage tabPageThoiGian;
        private System.Windows.Forms.TreeView treeViewGaDen;
        private System.Windows.Forms.TreeView treeViewKhachHang;
        private System.Windows.Forms.TreeView treeViewThoiGian;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colCheck;
    }
}