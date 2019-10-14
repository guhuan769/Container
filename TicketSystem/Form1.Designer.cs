namespace TicketSystem
{
    partial class frm_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.cmb_StartSite = new System.Windows.Forms.ComboBox();
            this.lb_EndSite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_Serch = new System.Windows.Forms.Button();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Time);
            this.groupBox1.Controls.Add(this.btn_Serch);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_EndSite);
            this.groupBox1.Controls.Add(this.cmb_StartSite);
            this.groupBox1.Controls.Add(this.lb_Address);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件筛选";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(6, 36);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(60, 15);
            this.lb_Address.TabIndex = 0;
            this.lb_Address.Text = "出发地:";
            // 
            // cmb_StartSite
            // 
            this.cmb_StartSite.FormattingEnabled = true;
            this.cmb_StartSite.Items.AddRange(new object[] {
            "成都",
            "上海",
            "长沙",
            "广东",
            "北京"});
            this.cmb_StartSite.Location = new System.Drawing.Point(67, 33);
            this.cmb_StartSite.Name = "cmb_StartSite";
            this.cmb_StartSite.Size = new System.Drawing.Size(121, 23);
            this.cmb_StartSite.TabIndex = 1;
            // 
            // lb_EndSite
            // 
            this.lb_EndSite.AutoSize = true;
            this.lb_EndSite.Location = new System.Drawing.Point(199, 36);
            this.lb_EndSite.Name = "lb_EndSite";
            this.lb_EndSite.Size = new System.Drawing.Size(55, 15);
            this.lb_EndSite.TabIndex = 2;
            this.lb_EndSite.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "日期:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "成都",
            "上海",
            "长沙",
            "广东",
            "北京"});
            this.comboBox2.Location = new System.Drawing.Point(268, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 5;
            // 
            // btn_Serch
            // 
            this.btn_Serch.Location = new System.Drawing.Point(655, 32);
            this.btn_Serch.Name = "btn_Serch";
            this.btn_Serch.Size = new System.Drawing.Size(75, 23);
            this.btn_Serch.TabIndex = 7;
            this.btn_Serch.Text = "查  询";
            this.btn_Serch.UseVisualStyleBackColor = true;
            this.btn_Serch.Click += new System.EventHandler(this.Btn_Serch_Click);
            // 
            // dtp_Time
            // 
            this.dtp_Time.CustomFormat = "yyyy-MM-dd";
            this.dtp_Time.Location = new System.Drawing.Point(446, 32);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(200, 25);
            this.dtp_Time.TabIndex = 8;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Main";
            this.Text = "售票窗口";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_EndSite;
        private System.Windows.Forms.ComboBox cmb_StartSite;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_Serch;
        private System.Windows.Forms.DateTimePicker dtp_Time;
    }
}

