using System.Windows.Forms;

namespace ETL_Manager
{
    partial class FormLogs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_ETLValidation = new System.Windows.Forms.TabPage();
            this.panelWarnings = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelErrors = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWarnings = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblDateETL = new System.Windows.Forms.Label();
            this.dgvETLValidation = new System.Windows.Forms.DataGridView();
            this.tp_SourceValidation = new System.Windows.Forms.TabPage();
            this.dGV_RowDifference = new System.Windows.Forms.DataGridView();
            this.factTableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDifferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRowDifferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dWH_TestDataSet = new ETL_Manager.DWH_TestDataSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auditKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentAuditKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableInitialRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extractRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filteredRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableFinalRowCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableMaxDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.successfulExecutionIndicatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begindatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exectimeinsecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exectimeinminutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exectimeinhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAuditTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCriteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBFactTables = new System.Windows.Forms.ComboBox();
            this.chartTableGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dGV_FactTablesGrowth = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.v_AuditTableTableAdapter = new ETL_Manager.DWH_TestDataSetTableAdapters.v_AuditTableTableAdapter();
            this.dwH_TestDataSet1 = new ETL_Manager.DWH_TestDataSet();
            this.v_ValidateETLProcessTableAdapter1 = new ETL_Manager.DWH_TestDataSetTableAdapters.v_ValidateETLProcessTableAdapter();
            this.v_RowDifferenceTableAdapter = new ETL_Manager.DWH_TestDataSetTableAdapters.v_RowDifferenceTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tp_ETLValidation.SuspendLayout();
            this.panelWarnings.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelErrors.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvETLValidation)).BeginInit();
            this.tp_SourceValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RowDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRowDifferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWH_TestDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAuditTableBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTableGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_FactTablesGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwH_TestDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1185, 703);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tp_ETLValidation);
            this.tabControl1.Controls.Add(this.tp_SourceValidation);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(66, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 685);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tp_ETLValidation
            // 
            this.tp_ETLValidation.Controls.Add(this.panelWarnings);
            this.tp_ETLValidation.Controls.Add(this.panelErrors);
            this.tp_ETLValidation.Controls.Add(this.lblWarnings);
            this.tp_ETLValidation.Controls.Add(this.lblErrors);
            this.tp_ETLValidation.Controls.Add(this.lblDateETL);
            this.tp_ETLValidation.Controls.Add(this.dgvETLValidation);
            this.tp_ETLValidation.Location = new System.Drawing.Point(4, 22);
            this.tp_ETLValidation.Name = "tp_ETLValidation";
            this.tp_ETLValidation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ETLValidation.Size = new System.Drawing.Size(1240, 659);
            this.tp_ETLValidation.TabIndex = 5;
            this.tp_ETLValidation.Text = "  ETL Validation   ";
            this.tp_ETLValidation.UseVisualStyleBackColor = true;
            // 
            // panelWarnings
            // 
            this.panelWarnings.BackColor = System.Drawing.Color.Yellow;
            this.panelWarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWarnings.Controls.Add(this.panel5);
            this.panelWarnings.Controls.Add(this.panel7);
            this.panelWarnings.ForeColor = System.Drawing.Color.Red;
            this.panelWarnings.Location = new System.Drawing.Point(822, 5);
            this.panelWarnings.Name = "panelWarnings";
            this.panelWarnings.Size = new System.Drawing.Size(12, 10);
            this.panelWarnings.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.ForeColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(88, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 10);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(94, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(54, 10);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(94, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(54, 10);
            this.panel7.TabIndex = 6;
            // 
            // panelErrors
            // 
            this.panelErrors.BackColor = System.Drawing.Color.Red;
            this.panelErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelErrors.Controls.Add(this.panel1);
            this.panelErrors.Controls.Add(this.panel2);
            this.panelErrors.ForeColor = System.Drawing.Color.Red;
            this.panelErrors.Location = new System.Drawing.Point(733, 6);
            this.panelErrors.Name = "panelErrors";
            this.panelErrors.Size = new System.Drawing.Size(12, 10);
            this.panelErrors.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(88, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 10);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(94, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 10);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(94, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 10);
            this.panel2.TabIndex = 6;
            // 
            // lblWarnings
            // 
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.Location = new System.Drawing.Point(834, 3);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(58, 13);
            this.lblWarnings.TabIndex = 4;
            this.lblWarnings.Text = "Warnings: ";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(745, 3);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(40, 13);
            this.lblErrors.TabIndex = 3;
            this.lblErrors.Text = "Errors: ";
            // 
            // lblDateETL
            // 
            this.lblDateETL.AutoSize = true;
            this.lblDateETL.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDateETL.Location = new System.Drawing.Point(1177, 3);
            this.lblDateETL.Name = "lblDateETL";
            this.lblDateETL.Size = new System.Drawing.Size(60, 13);
            this.lblDateETL.TabIndex = 2;
            this.lblDateETL.Text = "lblDateETL";
            this.lblDateETL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvETLValidation
            // 
            this.dgvETLValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvETLValidation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvETLValidation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvETLValidation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvETLValidation.Location = new System.Drawing.Point(3, 33);
            this.dgvETLValidation.MultiSelect = false;
            this.dgvETLValidation.Name = "dgvETLValidation";
            this.dgvETLValidation.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvETLValidation.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvETLValidation.Size = new System.Drawing.Size(1234, 623);
            this.dgvETLValidation.TabIndex = 0;
            this.dgvETLValidation.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvETLValidation_RowPrePaint);
            // 
            // tp_SourceValidation
            // 
            this.tp_SourceValidation.Controls.Add(this.dGV_RowDifference);
            this.tp_SourceValidation.Location = new System.Drawing.Point(4, 22);
            this.tp_SourceValidation.Name = "tp_SourceValidation";
            this.tp_SourceValidation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_SourceValidation.Size = new System.Drawing.Size(1240, 659);
            this.tp_SourceValidation.TabIndex = 6;
            this.tp_SourceValidation.Text = "Source Validation";
            this.tp_SourceValidation.UseVisualStyleBackColor = true;
            // 
            // dGV_RowDifference
            // 
            this.dGV_RowDifference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_RowDifference.AutoGenerateColumns = false;
            this.dGV_RowDifference.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_RowDifference.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_RowDifference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_RowDifference.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factTableDataGridViewTextBoxColumn,
            this.originRowCountDataGridViewTextBoxColumn,
            this.factRowCountDataGridViewTextBoxColumn,
            this.rowDifferenceDataGridViewTextBoxColumn});
            this.dGV_RowDifference.DataSource = this.vRowDifferenceBindingSource;
            this.dGV_RowDifference.Location = new System.Drawing.Point(10, 15);
            this.dGV_RowDifference.Name = "dGV_RowDifference";
            this.dGV_RowDifference.ReadOnly = true;
            this.dGV_RowDifference.Size = new System.Drawing.Size(1224, 638);
            this.dGV_RowDifference.TabIndex = 0;
            this.dGV_RowDifference.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dGV_RowDifference_RowPrePaint);
            // 
            // factTableDataGridViewTextBoxColumn
            // 
            this.factTableDataGridViewTextBoxColumn.DataPropertyName = "FactTable";
            this.factTableDataGridViewTextBoxColumn.HeaderText = "FactTable";
            this.factTableDataGridViewTextBoxColumn.Name = "factTableDataGridViewTextBoxColumn";
            this.factTableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originRowCountDataGridViewTextBoxColumn
            // 
            this.originRowCountDataGridViewTextBoxColumn.DataPropertyName = "OriginRowCount";
            this.originRowCountDataGridViewTextBoxColumn.HeaderText = "OriginRowCount";
            this.originRowCountDataGridViewTextBoxColumn.Name = "originRowCountDataGridViewTextBoxColumn";
            this.originRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factRowCountDataGridViewTextBoxColumn
            // 
            this.factRowCountDataGridViewTextBoxColumn.DataPropertyName = "FactRowCount";
            this.factRowCountDataGridViewTextBoxColumn.HeaderText = "FactRowCount";
            this.factRowCountDataGridViewTextBoxColumn.Name = "factRowCountDataGridViewTextBoxColumn";
            this.factRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowDifferenceDataGridViewTextBoxColumn
            // 
            this.rowDifferenceDataGridViewTextBoxColumn.DataPropertyName = "RowDifference";
            this.rowDifferenceDataGridViewTextBoxColumn.HeaderText = "RowDifference";
            this.rowDifferenceDataGridViewTextBoxColumn.Name = "rowDifferenceDataGridViewTextBoxColumn";
            this.rowDifferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vRowDifferenceBindingSource
            // 
            this.vRowDifferenceBindingSource.DataMember = "v_RowDifference";
            this.vRowDifferenceBindingSource.DataSource = this.dWH_TestDataSet;
            // 
            // dWH_TestDataSet
            // 
            this.dWH_TestDataSet.DataSetName = "DWH_TestDataSet";
            this.dWH_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnResetFilter);
            this.tabPage1.Controls.Add(this.dateTime1);
            this.tabPage1.Controls.Add(this.btnFilter);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  History logs   ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.Location = new System.Drawing.Point(1149, 14);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 10;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click_1);
            // 
            // dateTime1
            // 
            this.dateTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime1.Location = new System.Drawing.Point(861, 17);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(201, 20);
            this.dateTime1.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(1068, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auditKeyDataGridViewTextBoxColumn,
            this.parentAuditKeyDataGridViewTextBoxColumn,
            this.packageNameDataGridViewTextBoxColumn,
            this.databaseNameDataGridViewTextBoxColumn,
            this.tableNameDataGridViewTextBoxColumn,
            this.tableInitialRowCountDataGridViewTextBoxColumn,
            this.extractRowCountDataGridViewTextBoxColumn,
            this.filteredRowCountDataGridViewTextBoxColumn,
            this.insertRowCountDataGridViewTextBoxColumn,
            this.updateRowCountDataGridViewTextBoxColumn,
            this.errorRowCountDataGridViewTextBoxColumn,
            this.tableFinalRowCountDataGridViewTextBoxColumn,
            this.tableMaxDateTimeDataGridViewTextBoxColumn,
            this.successfulExecutionIndicatorDataGridViewTextBoxColumn,
            this.begindatetimeDataGridViewTextBoxColumn,
            this.enddatetimeDataGridViewTextBoxColumn,
            this.exectimeinsecondsDataGridViewTextBoxColumn,
            this.exectimeinminutesDataGridViewTextBoxColumn,
            this.exectimeinhoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vAuditTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 595);
            this.dataGridView1.TabIndex = 7;
            // 
            // auditKeyDataGridViewTextBoxColumn
            // 
            this.auditKeyDataGridViewTextBoxColumn.DataPropertyName = "AuditKey";
            this.auditKeyDataGridViewTextBoxColumn.HeaderText = "AuditKey";
            this.auditKeyDataGridViewTextBoxColumn.Name = "auditKeyDataGridViewTextBoxColumn";
            this.auditKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentAuditKeyDataGridViewTextBoxColumn
            // 
            this.parentAuditKeyDataGridViewTextBoxColumn.DataPropertyName = "ParentAuditKey";
            this.parentAuditKeyDataGridViewTextBoxColumn.HeaderText = "ParentAuditKey";
            this.parentAuditKeyDataGridViewTextBoxColumn.Name = "parentAuditKeyDataGridViewTextBoxColumn";
            this.parentAuditKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageNameDataGridViewTextBoxColumn
            // 
            this.packageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.HeaderText = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            this.packageNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // databaseNameDataGridViewTextBoxColumn
            // 
            this.databaseNameDataGridViewTextBoxColumn.DataPropertyName = "DatabaseName";
            this.databaseNameDataGridViewTextBoxColumn.HeaderText = "DatabaseName";
            this.databaseNameDataGridViewTextBoxColumn.Name = "databaseNameDataGridViewTextBoxColumn";
            this.databaseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableNameDataGridViewTextBoxColumn
            // 
            this.tableNameDataGridViewTextBoxColumn.DataPropertyName = "TableName";
            this.tableNameDataGridViewTextBoxColumn.HeaderText = "TableName";
            this.tableNameDataGridViewTextBoxColumn.Name = "tableNameDataGridViewTextBoxColumn";
            this.tableNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableInitialRowCountDataGridViewTextBoxColumn
            // 
            this.tableInitialRowCountDataGridViewTextBoxColumn.DataPropertyName = "TableInitialRowCount";
            this.tableInitialRowCountDataGridViewTextBoxColumn.HeaderText = "TableInitialRowCount";
            this.tableInitialRowCountDataGridViewTextBoxColumn.Name = "tableInitialRowCountDataGridViewTextBoxColumn";
            this.tableInitialRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extractRowCountDataGridViewTextBoxColumn
            // 
            this.extractRowCountDataGridViewTextBoxColumn.DataPropertyName = "ExtractRowCount";
            this.extractRowCountDataGridViewTextBoxColumn.HeaderText = "ExtractRowCount";
            this.extractRowCountDataGridViewTextBoxColumn.Name = "extractRowCountDataGridViewTextBoxColumn";
            this.extractRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filteredRowCountDataGridViewTextBoxColumn
            // 
            this.filteredRowCountDataGridViewTextBoxColumn.DataPropertyName = "FilteredRowCount";
            this.filteredRowCountDataGridViewTextBoxColumn.HeaderText = "FilteredRowCount";
            this.filteredRowCountDataGridViewTextBoxColumn.Name = "filteredRowCountDataGridViewTextBoxColumn";
            this.filteredRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insertRowCountDataGridViewTextBoxColumn
            // 
            this.insertRowCountDataGridViewTextBoxColumn.DataPropertyName = "InsertRowCount";
            this.insertRowCountDataGridViewTextBoxColumn.HeaderText = "InsertRowCount";
            this.insertRowCountDataGridViewTextBoxColumn.Name = "insertRowCountDataGridViewTextBoxColumn";
            this.insertRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateRowCountDataGridViewTextBoxColumn
            // 
            this.updateRowCountDataGridViewTextBoxColumn.DataPropertyName = "UpdateRowCount";
            this.updateRowCountDataGridViewTextBoxColumn.HeaderText = "UpdateRowCount";
            this.updateRowCountDataGridViewTextBoxColumn.Name = "updateRowCountDataGridViewTextBoxColumn";
            this.updateRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorRowCountDataGridViewTextBoxColumn
            // 
            this.errorRowCountDataGridViewTextBoxColumn.DataPropertyName = "ErrorRowCount";
            this.errorRowCountDataGridViewTextBoxColumn.HeaderText = "ErrorRowCount";
            this.errorRowCountDataGridViewTextBoxColumn.Name = "errorRowCountDataGridViewTextBoxColumn";
            this.errorRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableFinalRowCountDataGridViewTextBoxColumn
            // 
            this.tableFinalRowCountDataGridViewTextBoxColumn.DataPropertyName = "TableFinalRowCount";
            this.tableFinalRowCountDataGridViewTextBoxColumn.HeaderText = "TableFinalRowCount";
            this.tableFinalRowCountDataGridViewTextBoxColumn.Name = "tableFinalRowCountDataGridViewTextBoxColumn";
            this.tableFinalRowCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableMaxDateTimeDataGridViewTextBoxColumn
            // 
            this.tableMaxDateTimeDataGridViewTextBoxColumn.DataPropertyName = "TableMaxDateTime";
            this.tableMaxDateTimeDataGridViewTextBoxColumn.HeaderText = "TableMaxDateTime";
            this.tableMaxDateTimeDataGridViewTextBoxColumn.Name = "tableMaxDateTimeDataGridViewTextBoxColumn";
            this.tableMaxDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // successfulExecutionIndicatorDataGridViewTextBoxColumn
            // 
            this.successfulExecutionIndicatorDataGridViewTextBoxColumn.DataPropertyName = "SuccessfulExecutionIndicator";
            this.successfulExecutionIndicatorDataGridViewTextBoxColumn.HeaderText = "SuccessfulExecutionIndicator";
            this.successfulExecutionIndicatorDataGridViewTextBoxColumn.Name = "successfulExecutionIndicatorDataGridViewTextBoxColumn";
            this.successfulExecutionIndicatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // begindatetimeDataGridViewTextBoxColumn
            // 
            this.begindatetimeDataGridViewTextBoxColumn.DataPropertyName = "begin_datetime";
            this.begindatetimeDataGridViewTextBoxColumn.HeaderText = "begin_datetime";
            this.begindatetimeDataGridViewTextBoxColumn.Name = "begindatetimeDataGridViewTextBoxColumn";
            this.begindatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enddatetimeDataGridViewTextBoxColumn
            // 
            this.enddatetimeDataGridViewTextBoxColumn.DataPropertyName = "end_datetime";
            this.enddatetimeDataGridViewTextBoxColumn.HeaderText = "end_datetime";
            this.enddatetimeDataGridViewTextBoxColumn.Name = "enddatetimeDataGridViewTextBoxColumn";
            this.enddatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exectimeinsecondsDataGridViewTextBoxColumn
            // 
            this.exectimeinsecondsDataGridViewTextBoxColumn.DataPropertyName = "exec_time_in_seconds";
            this.exectimeinsecondsDataGridViewTextBoxColumn.HeaderText = "exec_time_in_seconds";
            this.exectimeinsecondsDataGridViewTextBoxColumn.Name = "exectimeinsecondsDataGridViewTextBoxColumn";
            this.exectimeinsecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exectimeinminutesDataGridViewTextBoxColumn
            // 
            this.exectimeinminutesDataGridViewTextBoxColumn.DataPropertyName = "exec_time_in_minutes";
            this.exectimeinminutesDataGridViewTextBoxColumn.HeaderText = "exec_time_in_minutes";
            this.exectimeinminutesDataGridViewTextBoxColumn.Name = "exectimeinminutesDataGridViewTextBoxColumn";
            this.exectimeinminutesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exectimeinhoursDataGridViewTextBoxColumn
            // 
            this.exectimeinhoursDataGridViewTextBoxColumn.DataPropertyName = "exec_time_in_hours";
            this.exectimeinhoursDataGridViewTextBoxColumn.HeaderText = "exec_time_in_hours";
            this.exectimeinhoursDataGridViewTextBoxColumn.Name = "exectimeinhoursDataGridViewTextBoxColumn";
            this.exectimeinhoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vAuditTableBindingSource
            // 
            this.vAuditTableBindingSource.DataMember = "v_AuditTable";
            this.vAuditTableBindingSource.DataSource = this.dWH_TestDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  ETL Phases   ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Preparse Source",
            "Extract Jobs",
            "Transform_Loads_Dimensions",
            "Transform_Loads_Facts"});
            this.checkedListBox1.Location = new System.Drawing.Point(1053, 82);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(148, 64);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1202, 608);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lineChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1240, 659);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "  Execution Time   ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lineChart
            // 
            this.lineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.lineChart.Legends.Add(legend2);
            this.lineChart.Location = new System.Drawing.Point(20, 22);
            this.lineChart.Name = "lineChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.lineChart.Series.Add(series2);
            this.lineChart.Size = new System.Drawing.Size(1202, 608);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cBCriteria);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cBFactTables);
            this.tabPage3.Controls.Add(this.chartTableGrowth);
            this.tabPage3.Controls.Add(this.dGV_FactTablesGrowth);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1240, 659);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "  Fact Tables Growth   ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Criteria";
            // 
            // cBCriteria
            // 
            this.cBCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBCriteria.FormattingEnabled = true;
            this.cBCriteria.Items.AddRange(new object[] {
            "--",
            "Execution time",
            "Inserted row count"});
            this.cBCriteria.Location = new System.Drawing.Point(938, 32);
            this.cBCriteria.Name = "cBCriteria";
            this.cBCriteria.Size = new System.Drawing.Size(121, 21);
            this.cBCriteria.TabIndex = 4;
            this.cBCriteria.SelectedIndexChanged += new System.EventHandler(this.cBCriteria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1081, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fact Table";
            // 
            // cBFactTables
            // 
            this.cBFactTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBFactTables.FormattingEnabled = true;
            this.cBFactTables.Items.AddRange(new object[] {
            "--",
            "FactOrder",
            "FactTransfer"});
            this.cBFactTables.Location = new System.Drawing.Point(1084, 32);
            this.cBFactTables.Name = "cBFactTables";
            this.cBFactTables.Size = new System.Drawing.Size(137, 21);
            this.cBFactTables.TabIndex = 2;
            this.cBFactTables.SelectedIndexChanged += new System.EventHandler(this.cBFactTables_SelectedIndexChanged);
            // 
            // chartTableGrowth
            // 
            this.chartTableGrowth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartTableGrowth.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTableGrowth.Legends.Add(legend3);
            this.chartTableGrowth.Location = new System.Drawing.Point(443, 59);
            this.chartTableGrowth.Name = "chartTableGrowth";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTableGrowth.Series.Add(series3);
            this.chartTableGrowth.Size = new System.Drawing.Size(778, 584);
            this.chartTableGrowth.TabIndex = 1;
            this.chartTableGrowth.Text = "chart2";
            this.chartTableGrowth.Click += new System.EventHandler(this.chartTableGrowth_Click);
            // 
            // dGV_FactTablesGrowth
            // 
            this.dGV_FactTablesGrowth.AllowUserToAddRows = false;
            this.dGV_FactTablesGrowth.AllowUserToDeleteRows = false;
            this.dGV_FactTablesGrowth.AllowUserToOrderColumns = true;
            this.dGV_FactTablesGrowth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_FactTablesGrowth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_FactTablesGrowth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_FactTablesGrowth.Location = new System.Drawing.Point(16, 59);
            this.dGV_FactTablesGrowth.Name = "dGV_FactTablesGrowth";
            this.dGV_FactTablesGrowth.ReadOnly = true;
            this.dGV_FactTablesGrowth.Size = new System.Drawing.Size(405, 584);
            this.dGV_FactTablesGrowth.TabIndex = 0;
            // 
            // v_AuditTableTableAdapter
            // 
            this.v_AuditTableTableAdapter.ClearBeforeFill = true;
            // 
            // dwH_TestDataSet1
            // 
            this.dwH_TestDataSet1.DataSetName = "DWH_TestDataSet";
            this.dwH_TestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_ValidateETLProcessTableAdapter1
            // 
            this.v_ValidateETLProcessTableAdapter1.ClearBeforeFill = true;
            // 
            // v_RowDifferenceTableAdapter
            // 
            this.v_RowDifferenceTableAdapter.ClearBeforeFill = true;
            // 
            // FormLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 738);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogs";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormLogs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_ETLValidation.ResumeLayout(false);
            this.tp_ETLValidation.PerformLayout();
            this.panelWarnings.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelErrors.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvETLValidation)).EndInit();
            this.tp_SourceValidation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RowDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRowDifferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWH_TestDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAuditTableBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTableGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_FactTablesGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwH_TestDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DWH_TestDataSet dWH_TestDataSet;
        private System.Windows.Forms.BindingSource vAuditTableBindingSource;
        private DWH_TestDataSetTableAdapters.v_AuditTableTableAdapter v_AuditTableTableAdapter;
        private DWH_TestDataSetTableAdapters.v_AuditStatsTableAdapter v_AuditStatsTableAdapter;
        private DWH_TestDataSetTableAdapters.v_ETL_ExecTimeTableAdapter v_ETL_ExecTimeTableAdapter;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentAuditKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableInitialRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extractRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filteredRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableFinalRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableMaxDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn successfulExecutionIndicatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn begindatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exectimeinsecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exectimeinminutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exectimeinhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DWH_TestDataSet dwH_TestDataSet1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dGV_FactTablesGrowth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTableGrowth;
        private System.Windows.Forms.ComboBox cBFactTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBCriteria;
        private System.Windows.Forms.TabPage tp_ETLValidation;
        private System.Windows.Forms.DataGridView dgvETLValidation;
        private DWH_TestDataSetTableAdapters.v_ValidateETLProcessTableAdapter v_ValidateETLProcessTableAdapter1;
        private System.Windows.Forms.Label lblDateETL;
        private System.Windows.Forms.Label lblWarnings;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Panel panelErrors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelWarnings;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tp_SourceValidation;
        private System.Windows.Forms.DataGridView dGV_RowDifference;
        private System.Windows.Forms.BindingSource vRowDifferenceBindingSource;
        private DWH_TestDataSetTableAdapters.v_RowDifferenceTableAdapter v_RowDifferenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn factTableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factRowCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDifferenceDataGridViewTextBoxColumn;
    }
}