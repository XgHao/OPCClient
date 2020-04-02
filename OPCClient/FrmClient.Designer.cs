namespace OPCClient
{
    partial class FrmClient
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
            this.lbl_SvrNode = new System.Windows.Forms.Label();
            this.cbB_SvrNode = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lb_Items = new System.Windows.Forms.ListBox();
            this.dGV_Var = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_SvrName = new System.Windows.Forms.Label();
            this.cbB_SvrName = new System.Windows.Forms.ComboBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Var)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SvrNode
            // 
            this.lbl_SvrNode.AutoSize = true;
            this.lbl_SvrNode.Location = new System.Drawing.Point(57, 27);
            this.lbl_SvrNode.Name = "lbl_SvrNode";
            this.lbl_SvrNode.Size = new System.Drawing.Size(77, 12);
            this.lbl_SvrNode.TabIndex = 0;
            this.lbl_SvrNode.Text = "Server Node:";
            // 
            // cbB_SvrNode
            // 
            this.cbB_SvrNode.BackColor = System.Drawing.Color.White;
            this.cbB_SvrNode.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbB_SvrNode.FormattingEnabled = true;
            this.cbB_SvrNode.Location = new System.Drawing.Point(156, 22);
            this.cbB_SvrNode.Name = "cbB_SvrNode";
            this.cbB_SvrNode.Size = new System.Drawing.Size(160, 23);
            this.cbB_SvrNode.TabIndex = 2;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(353, 22);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // lb_Items
            // 
            this.lb_Items.FormattingEnabled = true;
            this.lb_Items.ItemHeight = 12;
            this.lb_Items.Location = new System.Drawing.Point(57, 101);
            this.lb_Items.Name = "lb_Items";
            this.lb_Items.Size = new System.Drawing.Size(369, 148);
            this.lb_Items.TabIndex = 4;
            // 
            // dGV_Var
            // 
            this.dGV_Var.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGV_Var.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Var.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Var.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Value,
            this.Time});
            this.dGV_Var.Location = new System.Drawing.Point(57, 283);
            this.dGV_Var.Name = "dGV_Var";
            this.dGV_Var.RowTemplate.Height = 23;
            this.dGV_Var.Size = new System.Drawing.Size(369, 175);
            this.dGV_Var.TabIndex = 5;
            // 
            // Tag
            // 
            this.Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tag.HeaderText = "变量";
            this.Tag.Name = "Tag";
            // 
            // Value
            // 
            this.Value.HeaderText = "值";
            this.Value.Name = "Value";
            // 
            // Time
            // 
            this.Time.HeaderText = "时间";
            this.Time.Name = "Time";
            // 
            // lbl_SvrName
            // 
            this.lbl_SvrName.AutoSize = true;
            this.lbl_SvrName.Location = new System.Drawing.Point(57, 66);
            this.lbl_SvrName.Name = "lbl_SvrName";
            this.lbl_SvrName.Size = new System.Drawing.Size(77, 12);
            this.lbl_SvrName.TabIndex = 0;
            this.lbl_SvrName.Text = "Server Name:";
            // 
            // cbB_SvrName
            // 
            this.cbB_SvrName.BackColor = System.Drawing.Color.White;
            this.cbB_SvrName.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbB_SvrName.FormattingEnabled = true;
            this.cbB_SvrName.Location = new System.Drawing.Point(156, 61);
            this.cbB_SvrName.Name = "cbB_SvrName";
            this.cbB_SvrName.Size = new System.Drawing.Size(160, 23);
            this.cbB_SvrName.TabIndex = 2;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(353, 61);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 484);
            this.Controls.Add(this.dGV_Var);
            this.Controls.Add(this.lb_Items);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cbB_SvrName);
            this.Controls.Add(this.lbl_SvrName);
            this.Controls.Add(this.cbB_SvrNode);
            this.Controls.Add(this.lbl_SvrNode);
            this.Name = "FrmClient";
            this.Text = "OPC Client";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Var)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SvrNode;
        private System.Windows.Forms.ComboBox cbB_SvrNode;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ListBox lb_Items;
        private System.Windows.Forms.DataGridView dGV_Var;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Label lbl_SvrName;
        private System.Windows.Forms.ComboBox cbB_SvrName;
        private System.Windows.Forms.Button btn_Connect;
    }
}

