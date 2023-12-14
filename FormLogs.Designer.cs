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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.dWH_TestDataSet = new ETL_Manager.DWH_TestDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dGV_FactTablesGrowth = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.v_AuditTableTableAdapter = new ETL_Manager.DWH_TestDataSetTableAdapters.v_AuditTableTableAdapter();
            this.dwH_TestDataSet1 = new ETL_Manager.DWH_TestDataSet();
            this.chartTableGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cBFactTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBCriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAuditTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWH_TestDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_FactTablesGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwH_TestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTableGrowth)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 685);
            this.tabControl1.TabIndex = 6;
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
            this.tabPage1.Text = "History logs";
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
            // dWH_TestDataSet
            // 
            this.dWH_TestDataSet.DataSetName = "DWH_TestDataSet";
            this.dWH_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tabPage2.Text = "ETL Phases";
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
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(20, 22);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
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
            this.tabPage4.Text = "Execution Time";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lineChart
            // 
            this.lineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.lineChart.Legends.Add(legend6);
            this.lineChart.Location = new System.Drawing.Point(20, 22);
            this.lineChart.Name = "lineChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.lineChart.Series.Add(series6);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1240, 659);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Fact Tables Growth";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dGV_FactTablesGrowth
            // 
            this.dGV_FactTablesGrowth.AllowUserToAddRows = false;
            this.dGV_FactTablesGrowth.AllowUserToDeleteRows = false;
            this.dGV_FactTablesGrowth.AllowUserToOrderColumns = true;
            this.dGV_FactTablesGrowth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // chartTableGrowth
            // 
            this.chartTableGrowth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartTableGrowth.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTableGrowth.Legends.Add(legend4);
            this.chartTableGrowth.Location = new System.Drawing.Point(443, 59);
            this.chartTableGrowth.Name = "chartTableGrowth";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTableGrowth.Series.Add(series4);
            this.chartTableGrowth.Size = new System.Drawing.Size(778, 584);
            this.chartTableGrowth.TabIndex = 1;
            this.chartTableGrowth.Text = "chart2";
            this.chartTableGrowth.Click += new System.EventHandler(this.chartTableGrowth_Click);
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAuditTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWH_TestDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_FactTablesGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwH_TestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTableGrowth)).EndInit();
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
    }
}