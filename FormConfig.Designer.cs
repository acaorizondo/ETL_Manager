namespace ETL_Manager
{
    partial class FormConfig
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.groupBoxFactOrderEnriched = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarFactOrderEnriched = new System.Windows.Forms.TrackBar();
            this.groupBoxStagingOrder = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarStagingOrder = new System.Windows.Forms.TrackBar();
            this.groupBoxFactOrder = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarFactOrder = new System.Windows.Forms.TrackBar();
            this.groupBoxTransfer = new System.Windows.Forms.GroupBox();
            this.groupBoxFactTransferEnriched = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarFactTransferEnriched = new System.Windows.Forms.TrackBar();
            this.groupBoxStagingTransfer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarStagingTransfer = new System.Windows.Forms.TrackBar();
            this.groupBoxFactTransfer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarFactTransfer = new System.Windows.Forms.TrackBar();
            this.btnSave = new System.Windows.Forms.Button();
            this.runPackagesTableAdapter = new ETL_Manager.DWH_TestDataSetTableAdapters.RunPackagesTableAdapter();
            this.gbAll_Transfer = new System.Windows.Forms.GroupBox();
            this.rbIncremental_Transfer = new System.Windows.Forms.RadioButton();
            this.rbFullLoad_Transfer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIncremental_Order = new System.Windows.Forms.RadioButton();
            this.rbFullLoad_Order = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxFactOrderEnriched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactOrderEnriched)).BeginInit();
            this.groupBoxStagingOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStagingOrder)).BeginInit();
            this.groupBoxFactOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactOrder)).BeginInit();
            this.groupBoxTransfer.SuspendLayout();
            this.groupBoxFactTransferEnriched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactTransferEnriched)).BeginInit();
            this.groupBoxStagingTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStagingTransfer)).BeginInit();
            this.groupBoxFactTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactTransfer)).BeginInit();
            this.gbAll_Transfer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1169, 664);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 621);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.groupBoxOrder);
            this.tabPage1.Controls.Add(this.groupBoxTransfer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1224, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ETL Execution Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOrder.Controls.Add(this.groupBox1);
            this.groupBoxOrder.Controls.Add(this.groupBoxFactOrderEnriched);
            this.groupBoxOrder.Controls.Add(this.groupBoxStagingOrder);
            this.groupBoxOrder.Controls.Add(this.groupBoxFactOrder);
            this.groupBoxOrder.Location = new System.Drawing.Point(26, 160);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(1171, 116);
            this.groupBoxOrder.TabIndex = 5;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Order";
            // 
            // groupBoxFactOrderEnriched
            // 
            this.groupBoxFactOrderEnriched.Controls.Add(this.label7);
            this.groupBoxFactOrderEnriched.Controls.Add(this.label8);
            this.groupBoxFactOrderEnriched.Controls.Add(this.trackBarFactOrderEnriched);
            this.groupBoxFactOrderEnriched.Location = new System.Drawing.Point(548, 19);
            this.groupBoxFactOrderEnriched.Name = "groupBoxFactOrderEnriched";
            this.groupBoxFactOrderEnriched.Size = new System.Drawing.Size(220, 80);
            this.groupBoxFactOrderEnriched.TabIndex = 3;
            this.groupBoxFactOrderEnriched.TabStop = false;
            this.groupBoxFactOrderEnriched.Text = "Fact Order Enriched";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Incremental";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Full Load";
            // 
            // trackBarFactOrderEnriched
            // 
            this.trackBarFactOrderEnriched.Location = new System.Drawing.Point(62, 33);
            this.trackBarFactOrderEnriched.Maximum = 1;
            this.trackBarFactOrderEnriched.Name = "trackBarFactOrderEnriched";
            this.trackBarFactOrderEnriched.Size = new System.Drawing.Size(82, 45);
            this.trackBarFactOrderEnriched.TabIndex = 0;
            // 
            // groupBoxStagingOrder
            // 
            this.groupBoxStagingOrder.Controls.Add(this.label9);
            this.groupBoxStagingOrder.Controls.Add(this.label10);
            this.groupBoxStagingOrder.Controls.Add(this.trackBarStagingOrder);
            this.groupBoxStagingOrder.Location = new System.Drawing.Point(72, 19);
            this.groupBoxStagingOrder.Name = "groupBoxStagingOrder";
            this.groupBoxStagingOrder.Size = new System.Drawing.Size(220, 80);
            this.groupBoxStagingOrder.TabIndex = 1;
            this.groupBoxStagingOrder.TabStop = false;
            this.groupBoxStagingOrder.Text = "Staging Order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Incremental";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Full Load";
            // 
            // trackBarStagingOrder
            // 
            this.trackBarStagingOrder.Location = new System.Drawing.Point(62, 33);
            this.trackBarStagingOrder.Maximum = 1;
            this.trackBarStagingOrder.Name = "trackBarStagingOrder";
            this.trackBarStagingOrder.Size = new System.Drawing.Size(82, 45);
            this.trackBarStagingOrder.TabIndex = 0;
            // 
            // groupBoxFactOrder
            // 
            this.groupBoxFactOrder.Controls.Add(this.label11);
            this.groupBoxFactOrder.Controls.Add(this.label12);
            this.groupBoxFactOrder.Controls.Add(this.trackBarFactOrder);
            this.groupBoxFactOrder.Location = new System.Drawing.Point(311, 19);
            this.groupBoxFactOrder.Name = "groupBoxFactOrder";
            this.groupBoxFactOrder.Size = new System.Drawing.Size(220, 80);
            this.groupBoxFactOrder.TabIndex = 2;
            this.groupBoxFactOrder.TabStop = false;
            this.groupBoxFactOrder.Text = "Fact Order";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Incremental";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Full Load";
            // 
            // trackBarFactOrder
            // 
            this.trackBarFactOrder.Location = new System.Drawing.Point(62, 33);
            this.trackBarFactOrder.Maximum = 1;
            this.trackBarFactOrder.Name = "trackBarFactOrder";
            this.trackBarFactOrder.Size = new System.Drawing.Size(82, 45);
            this.trackBarFactOrder.TabIndex = 0;
            // 
            // groupBoxTransfer
            // 
            this.groupBoxTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTransfer.Controls.Add(this.gbAll_Transfer);
            this.groupBoxTransfer.Controls.Add(this.groupBoxFactTransferEnriched);
            this.groupBoxTransfer.Controls.Add(this.groupBoxStagingTransfer);
            this.groupBoxTransfer.Controls.Add(this.groupBoxFactTransfer);
            this.groupBoxTransfer.Location = new System.Drawing.Point(26, 28);
            this.groupBoxTransfer.Name = "groupBoxTransfer";
            this.groupBoxTransfer.Size = new System.Drawing.Size(1171, 116);
            this.groupBoxTransfer.TabIndex = 4;
            this.groupBoxTransfer.TabStop = false;
            this.groupBoxTransfer.Text = "Transfer";
            // 
            // groupBoxFactTransferEnriched
            // 
            this.groupBoxFactTransferEnriched.Controls.Add(this.label5);
            this.groupBoxFactTransferEnriched.Controls.Add(this.label6);
            this.groupBoxFactTransferEnriched.Controls.Add(this.trackBarFactTransferEnriched);
            this.groupBoxFactTransferEnriched.Location = new System.Drawing.Point(546, 19);
            this.groupBoxFactTransferEnriched.Name = "groupBoxFactTransferEnriched";
            this.groupBoxFactTransferEnriched.Size = new System.Drawing.Size(220, 80);
            this.groupBoxFactTransferEnriched.TabIndex = 3;
            this.groupBoxFactTransferEnriched.TabStop = false;
            this.groupBoxFactTransferEnriched.Text = "Fact Transfer Enriched";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Incremental";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Full Load";
            // 
            // trackBarFactTransferEnriched
            // 
            this.trackBarFactTransferEnriched.Location = new System.Drawing.Point(62, 33);
            this.trackBarFactTransferEnriched.Maximum = 1;
            this.trackBarFactTransferEnriched.Name = "trackBarFactTransferEnriched";
            this.trackBarFactTransferEnriched.Size = new System.Drawing.Size(82, 45);
            this.trackBarFactTransferEnriched.TabIndex = 0;
            // 
            // groupBoxStagingTransfer
            // 
            this.groupBoxStagingTransfer.Controls.Add(this.label2);
            this.groupBoxStagingTransfer.Controls.Add(this.label1);
            this.groupBoxStagingTransfer.Controls.Add(this.trackBarStagingTransfer);
            this.groupBoxStagingTransfer.Location = new System.Drawing.Point(72, 19);
            this.groupBoxStagingTransfer.Name = "groupBoxStagingTransfer";
            this.groupBoxStagingTransfer.Size = new System.Drawing.Size(220, 80);
            this.groupBoxStagingTransfer.TabIndex = 1;
            this.groupBoxStagingTransfer.TabStop = false;
            this.groupBoxStagingTransfer.Text = "Staging Transfer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Incremental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Load";
            // 
            // trackBarStagingTransfer
            // 
            this.trackBarStagingTransfer.Location = new System.Drawing.Point(62, 33);
            this.trackBarStagingTransfer.Maximum = 1;
            this.trackBarStagingTransfer.Name = "trackBarStagingTransfer";
            this.trackBarStagingTransfer.Size = new System.Drawing.Size(82, 45);
            this.trackBarStagingTransfer.TabIndex = 0;
            // 
            // groupBoxFactTransfer
            // 
            this.groupBoxFactTransfer.Controls.Add(this.label3);
            this.groupBoxFactTransfer.Controls.Add(this.label4);
            this.groupBoxFactTransfer.Controls.Add(this.trackBarFactTransfer);
            this.groupBoxFactTransfer.Location = new System.Drawing.Point(309, 19);
            this.groupBoxFactTransfer.Name = "groupBoxFactTransfer";
            this.groupBoxFactTransfer.Size = new System.Drawing.Size(220, 80);
            this.groupBoxFactTransfer.TabIndex = 2;
            this.groupBoxFactTransfer.TabStop = false;
            this.groupBoxFactTransfer.Text = "Fact Transfer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incremental";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Full Load";
            // 
            // trackBarFactTransfer
            // 
            this.trackBarFactTransfer.Location = new System.Drawing.Point(62, 33);
            this.trackBarFactTransfer.Maximum = 1;
            this.trackBarFactTransfer.Name = "trackBarFactTransfer";
            this.trackBarFactTransfer.Size = new System.Drawing.Size(82, 45);
            this.trackBarFactTransfer.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1121, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // runPackagesTableAdapter
            // 
            this.runPackagesTableAdapter.ClearBeforeFill = true;
            // 
            // gbAll_Transfer
            // 
            this.gbAll_Transfer.Controls.Add(this.rbIncremental_Transfer);
            this.gbAll_Transfer.Controls.Add(this.rbFullLoad_Transfer);
            this.gbAll_Transfer.Location = new System.Drawing.Point(783, 19);
            this.gbAll_Transfer.Name = "gbAll_Transfer";
            this.gbAll_Transfer.Size = new System.Drawing.Size(224, 80);
            this.gbAll_Transfer.TabIndex = 6;
            this.gbAll_Transfer.TabStop = false;
            this.gbAll_Transfer.Text = "All Tables";
            // 
            // rbIncremental_Transfer
            // 
            this.rbIncremental_Transfer.AutoSize = true;
            this.rbIncremental_Transfer.Location = new System.Drawing.Point(72, 44);
            this.rbIncremental_Transfer.Name = "rbIncremental_Transfer";
            this.rbIncremental_Transfer.Size = new System.Drawing.Size(80, 17);
            this.rbIncremental_Transfer.TabIndex = 7;
            this.rbIncremental_Transfer.TabStop = true;
            this.rbIncremental_Transfer.Text = "Incremental";
            this.rbIncremental_Transfer.UseVisualStyleBackColor = true;
            this.rbIncremental_Transfer.CheckedChanged += new System.EventHandler(this.rbIncremental_Transfer_CheckedChanged);
            // 
            // rbFullLoad_Transfer
            // 
            this.rbFullLoad_Transfer.AutoSize = true;
            this.rbFullLoad_Transfer.Location = new System.Drawing.Point(72, 21);
            this.rbFullLoad_Transfer.Name = "rbFullLoad_Transfer";
            this.rbFullLoad_Transfer.Size = new System.Drawing.Size(68, 17);
            this.rbFullLoad_Transfer.TabIndex = 6;
            this.rbFullLoad_Transfer.TabStop = true;
            this.rbFullLoad_Transfer.Text = "Full Load";
            this.rbFullLoad_Transfer.UseVisualStyleBackColor = true;
            this.rbFullLoad_Transfer.CheckedChanged += new System.EventHandler(this.rbFullLoad_Transfer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIncremental_Order);
            this.groupBox1.Controls.Add(this.rbFullLoad_Order);
            this.groupBox1.Location = new System.Drawing.Point(783, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Tables";
            // 
            // rbIncremental_Order
            // 
            this.rbIncremental_Order.AutoSize = true;
            this.rbIncremental_Order.Location = new System.Drawing.Point(72, 44);
            this.rbIncremental_Order.Name = "rbIncremental_Order";
            this.rbIncremental_Order.Size = new System.Drawing.Size(80, 17);
            this.rbIncremental_Order.TabIndex = 7;
            this.rbIncremental_Order.TabStop = true;
            this.rbIncremental_Order.Text = "Incremental";
            this.rbIncremental_Order.UseVisualStyleBackColor = true;
            this.rbIncremental_Order.CheckedChanged += new System.EventHandler(this.rbIncremental_Order_CheckedChanged);
            // 
            // rbFullLoad_Order
            // 
            this.rbFullLoad_Order.AutoSize = true;
            this.rbFullLoad_Order.Location = new System.Drawing.Point(72, 21);
            this.rbFullLoad_Order.Name = "rbFullLoad_Order";
            this.rbFullLoad_Order.Size = new System.Drawing.Size(68, 17);
            this.rbFullLoad_Order.TabIndex = 6;
            this.rbFullLoad_Order.TabStop = true;
            this.rbFullLoad_Order.Text = "Full Load";
            this.rbFullLoad_Order.UseVisualStyleBackColor = true;
            this.rbFullLoad_Order.CheckedChanged += new System.EventHandler(this.rbFullLoad_Order_CheckedChanged);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 699);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "ETL Configuration";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxFactOrderEnriched.ResumeLayout(false);
            this.groupBoxFactOrderEnriched.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactOrderEnriched)).EndInit();
            this.groupBoxStagingOrder.ResumeLayout(false);
            this.groupBoxStagingOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStagingOrder)).EndInit();
            this.groupBoxFactOrder.ResumeLayout(false);
            this.groupBoxFactOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactOrder)).EndInit();
            this.groupBoxTransfer.ResumeLayout(false);
            this.groupBoxFactTransferEnriched.ResumeLayout(false);
            this.groupBoxFactTransferEnriched.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactTransferEnriched)).EndInit();
            this.groupBoxStagingTransfer.ResumeLayout(false);
            this.groupBoxStagingTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStagingTransfer)).EndInit();
            this.groupBoxFactTransfer.ResumeLayout(false);
            this.groupBoxFactTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFactTransfer)).EndInit();
            this.gbAll_Transfer.ResumeLayout(false);
            this.gbAll_Transfer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar trackBarStagingTransfer;
        private System.Windows.Forms.GroupBox groupBoxStagingTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxFactTransferEnriched;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarFactTransferEnriched;
        private System.Windows.Forms.GroupBox groupBoxFactTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarFactTransfer;
        private System.Windows.Forms.GroupBox groupBoxTransfer;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.GroupBox groupBoxFactOrderEnriched;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarFactOrderEnriched;
        private System.Windows.Forms.GroupBox groupBoxStagingOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarStagingOrder;
        private System.Windows.Forms.GroupBox groupBoxFactOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarFactOrder;
        private DWH_TestDataSetTableAdapters.RunPackagesTableAdapter runPackagesTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbAll_Transfer;
        private System.Windows.Forms.RadioButton rbIncremental_Transfer;
        private System.Windows.Forms.RadioButton rbFullLoad_Transfer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIncremental_Order;
        private System.Windows.Forms.RadioButton rbFullLoad_Order;
    }
}