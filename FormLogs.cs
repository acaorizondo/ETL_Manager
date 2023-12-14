using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
//using LiveCharts.Wpf;
//using LiveChartsSeries = LiveCharts.Wpf.Series;

namespace ETL_Manager
{
    public partial class FormLogs : Form
    {
       DataView dv;
       DataView dv_auditStats;
       public FormLogs()
        {
            InitializeComponent();
            this.v_AuditStatsTableAdapter = new DWH_TestDataSetTableAdapters.v_AuditStatsTableAdapter();
            this.v_ETL_ExecTimeTableAdapter = new DWH_TestDataSetTableAdapters.v_ETL_ExecTimeTableAdapter();
            this.InitializeCheckedListBox();
        
        }

        private void InitializeCheckedListBox()
        {
            // Fases fijas
            string[] fixedPhases = { "Prepare Source", "Extract Jobs", "Transform_Load_Dimensions", "Transform_Load_Facts" };

            // Configura el CheckedListBox
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(fixedPhases);

            // Marca todas las casillas de verificación por defecto
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void UpdateChart()
        {
            // Actualiza el gráfico cuando cambian las selecciones en el CheckedListBox
            FillChart();
        }

        private void FillChart()
        {
            DWH_TestDataSet.v_AuditStatsDataTable dataTable = this.v_AuditStatsTableAdapter.GetData();

            // Filtrar fases seleccionadas
            var selectedPhases = checkedListBox1.CheckedItems.Cast<string>().ToList();
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                var filteredData = dataTable.AsEnumerable()
                                        .Where(row => selectedPhases.Contains(row.Field<string>("Phase")))
                                        .CopyToDataTable();

                // Limpiar el Chart existente
                chart1.Series.Clear();

                // Configurar la serie
                var groupedData = filteredData.AsEnumerable()
                                              .GroupBy(row => row.Field<string>("Phase"))
                                              .Select(group => new
                                              {
                                                  Phase = group.Key,
                                                  Data = group.CopyToDataTable()
                                              });

                foreach (var phaseGroup in groupedData)
                {
                    string phase = phaseGroup.Phase;

                    // Agregar una nueva serie
                    Series series = chart1.Series.Add(phase);
                    series.ChartType = SeriesChartType.StackedColumn;
                    series.IsValueShownAsLabel = true;

                    // Enlazar la serie directamente al DataTable
                    series.Points.DataBind(phaseGroup.Data.AsEnumerable(), "Date", "Time in seconds", "");
                }

                chart1.ChartAreas[0].AxisX.Title = "Date";
                chart1.ChartAreas[0].AxisY.Title = "Time in seconds";
                chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
                chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            }
        }




        private void fillDataGrid()
        {
            
            dv = new DataView(this.dWH_TestDataSet.v_AuditTable);

            DataGridViewColumn column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                                .FirstOrDefault(c => c.DataPropertyName == "exec_time_in_seconds");
            column.HeaderText = "Seconds";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                                .FirstOrDefault(c => c.DataPropertyName == "exec_time_in_minutes");
            column.HeaderText = "Minutes";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                               .FirstOrDefault(c => c.DataPropertyName == "exec_time_in_hours");
            column.HeaderText = "Hours";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "begin_datetime");
            column.HeaderText = "Begin";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "end_datetime");
            column.HeaderText = "Finished";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "PackageName");
            column.HeaderText = "Package";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "TableName");
            column.HeaderText = "Table";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "DatabaseName");
            column.HeaderText = "Database";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "TableInitialRowCount");
            column.HeaderText = "Initial Row Count";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "ParentAuditKey");
            column.HeaderText = "Parent AuditKey";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "TableFinalRowCount");
            column.HeaderText = "Final Row Count";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "ExtractRowCount");
            column.HeaderText = "Extract Row Count";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "FilteredRowCount");
            column.HeaderText = "Filtered Row Count";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "InsertRowCount");
            column.HeaderText = "Inserted Row Count";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "UpdateRowCount");
            column.HeaderText = "Updated Row Count";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "ErrorRowCount");
            column.HeaderText = "Error Row Count";
            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "SuccessfulExecutionIndicator");
            column.HeaderText = "Successful";

            column = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                              .FirstOrDefault(c => c.DataPropertyName == "TableMaxDateTime");
            column.HeaderText = "Max DateTime";

        }

        private void fillDataGridView_FactTableGrowth()
        {
            DataTable newDataTable = new DataTable();
            newDataTable.Columns.Add("Date", typeof(DateTime));
            newDataTable.Columns.Add("Fact Table", typeof(string));
            newDataTable.Columns.Add("Row count", typeof(int));
            newDataTable.Columns.Add("Inserted Row count", typeof(int));
            newDataTable.Columns.Add("Load time in minutes", typeof(double));

            var filteredData = dv.Cast<DataRowView>()
                                .Select(rowView => rowView.Row)
                                .Where(row => {
                                    string tableName = row["TableName"].ToString();
                                    return tableName == "FactOrder" || tableName == "FactTransfer";
                                })
                                .OrderBy(row => row["TableName"])
                                .ThenBy(row => row["end_datetime"])
                                .ToList();

            foreach (DataRow row in filteredData)
            {
                DateTime endDateTime = Convert.ToDateTime(row["end_datetime"]);
                newDataTable.Rows.Add(endDateTime.Date, row["TableName"], row["TableFinalRowCount"], row["InsertRowCount"], row["exec_time_in_minutes"]);
            }

            dGV_FactTablesGrowth.DataSource = newDataTable;

            // Ajustar el ancho de las columnas al contenido
            dGV_FactTablesGrowth.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void FillBarChart_TableGrowth1()
        {
            DataTable newDataTable = new DataTable();
            newDataTable.Columns.Add("Date", typeof(DateTime));
            newDataTable.Columns.Add("Value", typeof(double));

            // Verificar si hay un elemento seleccionado en el ComboBox de TableName
            if (cBFactTables != null && cBFactTables.SelectedItem != null && cBFactTables.SelectedItem.ToString() != "--")
            {
                // Obtener el TableName seleccionado en el ComboBox de TableName
                string selectedTableName = cBFactTables.SelectedItem.ToString();

                // Verificar si hay un elemento seleccionado en el ComboBox de Criterio
                if (cBCriteria != null && cBCriteria.SelectedItem != null && cBFactTables.SelectedItem.ToString() != "--")
                {
                    // Obtener el criterio seleccionado en el ComboBox de Criterio
                    string selectedCriteria = cBCriteria.SelectedItem.ToString();

                    // Limpiar el DataTable antes de agregar nuevos datos
                    newDataTable.Rows.Clear();

                    // Filtrar datos por TableName y Criterio seleccionado
                    var filteredData = dv.Cast<DataRowView>()
                                        .Select(rowView => rowView.Row)
                                        .Where(row => row["TableName"].ToString() == selectedTableName)
                                        .OrderBy(row => row["end_datetime"])
                                        .ToList();

                    foreach (DataRow row in filteredData)
                    {
                        DateTime endDateTime = Convert.ToDateTime(row["end_datetime"]);

                        // Obtener el valor correcto según el criterio seleccionado
                        double value = 0.0;

                        if (selectedCriteria == "Inserted row count")
                        {
                            value = Convert.ToDouble(row["InsertRowCount"]);
                        }
                        else if (selectedCriteria == "Execution time")
                        {
                            value = Convert.ToDouble(row["exec_time_in_minutes"]);
                        }

                        newDataTable.Rows.Add(endDateTime.Date, value);
                    }


                    // Limpiar el Chart existente
                    chartTableGrowth.Series.Clear();

                    // Configurar la serie de columnas
                    Series series = chartTableGrowth.Series.Add(selectedCriteria);
                    series.ChartType = SeriesChartType.Column;

                    // Enlazar la serie directamente al DataTable
                    series.Points.DataBind(newDataTable.AsEnumerable(), "Date", "Value", "");

                    // Configurar el eje X
                    chartTableGrowth.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chartTableGrowth.ChartAreas[0].AxisX.Interval = 1;
                    chartTableGrowth.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";

                    // Configurar el eje Y
                    if (selectedCriteria == "Execution time")
                    {
                        chartTableGrowth.ChartAreas[0].AxisY.Title = selectedCriteria.ToString() + " (minutes)";
                    }
                    else
                    {
                        chartTableGrowth.ChartAreas[0].AxisY.Title = selectedCriteria;
                    }
                   

                    // Configurar el título del gráfico
                    chartTableGrowth.Titles.Clear();
                    chartTableGrowth.Titles.Add($"{selectedCriteria} by Date for {selectedTableName}");

                    Color colorForZero = Color.FromArgb(211, 211, 211);        // LightGray
                    Color colorForInsertedRowCount = Color.FromArgb(65, 140, 240);
                    Color colorForExecutionTime = Color.FromArgb(252, 180, 65);

                    // Asignar color a la serie
                    if (selectedCriteria == "Inserted row count")
                    {
                        series.Color = colorForInsertedRowCount; // Color para Inserted row count
                    }
                    else if (selectedCriteria == "Execution time")
                    {
                        series.Color = colorForExecutionTime; // Color para Execution time
                    }

                    // Asignar colores a las barras
                    foreach (DataPoint point in series.Points)
                    {
                        if (point.YValues[0] == 0.0)
                        {
                            point.Color = Color.LightGray; // Color para valores cero
                        }
                        else if (selectedCriteria == "Inserted row count")
                        {
                            point.Color = colorForInsertedRowCount; // Color para Inserted row count
                        }
                        else if (selectedCriteria == "Execution time")
                        {
                            point.Color = colorForExecutionTime; // Color para Execution time
                        }
                        // Mostrar el valor de cada columna
                        point.IsValueShownAsLabel = true;
                    }

                   
                }
            }
        }

        private void fillLineChart()
        {
            DWH_TestDataSet.v_ETL_ExecTimeDataTable dataTable = this.v_ETL_ExecTimeTableAdapter.GetData();
            lineChart.DataSource = dataTable;
            lineChart.Series.Clear();

            lineChart.Series.Add("ETL Execution Time");
            lineChart.Series["ETL Execution Time"].ChartType = SeriesChartType.Line;
            lineChart.Series["ETL Execution Time"].XValueMember = "date"; // Reemplaza "ColumnNameX" con el nombre de la columna X
            lineChart.Series["ETL Execution Time"].YValueMembers = "minutes"; // Reemplaza "ColumnNameY" con el nombre de la columna Y

            lineChart.ChartAreas[0].AxisX.Title = "Date"; // Reemplaza "Eje X" con el nombre que desees
            lineChart.ChartAreas[0].AxisY.Title = "Execution time (minutes)"; // Reemplaza "Eje Y" con el nombre que desees
            lineChart.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold); // Establecer fuente y tamaño
            lineChart.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold); // Establecer fuente y tamaño



            lineChart.Series["ETL Execution Time"].Color = Color.Blue;
            lineChart.Series["ETL Execution Time"].BorderWidth = 2;
            lineChart.Series["ETL Execution Time"].MarkerStyle = MarkerStyle.Circle;
            lineChart.Series["ETL Execution Time"].MarkerSize = 8;
            lineChart.Series["ETL Execution Time"].IsValueShownAsLabel = true;

            // Actualizar el gráfico
            lineChart.DataBind();

        }
        private void FormLogs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dWH_TestDataSet.v_AuditTable' table. You can move, or remove it, as needed.
            this.v_AuditTableTableAdapter.Fill(this.dWH_TestDataSet.v_AuditTable);
            this.v_ETL_ExecTimeTableAdapter.Fill(this.dWH_TestDataSet.v_ETL_ExecTime);

            this.fillDataGrid();
            this.FillChart();
            this.fillLineChart();
            this.fillDataGridView_FactTableGrowth();
            // this.FillBarChart_TableGrowth();
            this.FillBarChart_TableGrowth1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime filter_date = dateTime1.Value.Date;
            dv.RowFilter = $"CONVERT(begin_datetime, 'System.DateTime') >= #{filter_date.ToString("yyyy-MM-dd")}# AND CONVERT(begin_datetime, 'System.DateTime') < #{filter_date.AddDays(1).ToString("yyyy-MM-dd")}#";
            dataGridView1.DataSource = dv;
        }

        private void btnResetFilter_Click_1(object sender, EventArgs e)
        {
            dv.RowFilter = "";

            // Volver a asignar el DataTable original como origen de datos
            dataGridView1.DataSource = this.dWH_TestDataSet.v_AuditTable;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateChart();
        }

        private void cBFactTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this.FillBarChart_TableGrowth();
            this.FillBarChart_TableGrowth1();
        }

        private void cBCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this.FillBarChart_TableGrowth();
            this.FillBarChart_TableGrowth1();
        }

        private void chartTableGrowth_Click(object sender, EventArgs e)
        {

        }
    }
}
