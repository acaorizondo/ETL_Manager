using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ETL_Manager
{
    public partial class FormConfig : Form
    {
        DWH_TestDataSet.RunPackagesDataTable dataTable;
        public FormConfig()
        {
            InitializeComponent();
           this.runPackagesTableAdapter = new DWH_TestDataSetTableAdapters.RunPackagesTableAdapter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getValues()
        {

            trackBarStagingOrder.Value = this.getValue("ERP_ICS_Order", "Staging");
            trackBarFactOrder.Value = this.getValue("FactOrder", "DWH_Test");
            trackBarFactOrderEnriched.Value = this.getValue("FactOrderEnriched", "DWH_Test");

            trackBarStagingTransfer.Value = this.getValue("ERP_ICS_Transfer", "Staging");
            trackBarFactTransfer.Value = this.getValue("FactTransfer", "DWH_Test");
            trackBarFactTransferEnriched.Value = this.getValue("FactTransferEnrich", "DWH_Test");

        }

        private  int getValue(string targetTableName, string targetDatabaseName)
        {
            // Filtra las filas según los valores específicos de "TableName" y "DatabaseName"
            var rows = dataTable
                .AsEnumerable()
                .Where(row =>
                    row.Field<string>("TableName") == targetTableName &&
                    row.Field<string>("DatabaseName") == targetDatabaseName);

            if (rows.Any())
            {
                // Obtén el valor del atributo incremental de la primera fila que cumple con los criterios
                int valorIncremental = rows.First().Field<bool>("Incremental") ? 1 : 0;
                return valorIncremental;
                
            }
            return -1;

        }

        private void saveValue(string targetTableName, string targetDatabaseName, int value)
        {
            Boolean incremental;
            incremental = (value == 1); // Convertir el valor a booleano
            
            // Guardar los cambios en la base de datos
            runPackagesTableAdapter.UpdateQuery(incremental,targetDatabaseName, targetTableName);
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            dataTable = this.runPackagesTableAdapter.GetData();
            this.getValues();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Guardar el valor en la base de datos para cada trackBar
            saveValue("ERP_ICS_Order", "Staging", trackBarStagingOrder.Value);
            saveValue("FactOrder", "DWH_Test", trackBarFactOrder.Value);
            saveValue("FactOrderEnriched", "DWH_Test", trackBarFactOrderEnriched.Value);

            saveValue("ERP_ICS_Transfer", "Staging", trackBarStagingTransfer.Value);
            saveValue("FactTransfer", "DWH_Test", trackBarFactTransfer.Value);
            saveValue("FactTransferEnrich", "DWH_Test", trackBarFactTransferEnriched.Value);

            // Mostrar un mensaje de éxito o realizar otras acciones necesarias
            MessageBox.Show(text:"Values saved successfully",
                             caption:"ETL Manager",
                             buttons: MessageBoxButtons.OK,
                             icon: MessageBoxIcon.Information);
            this.Close();
        }

        private void rbFullLoad_Transfer_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingTransfer.Value = 0;
            trackBarFactTransfer.Value = 0;
            trackBarFactTransferEnriched.Value = 0;

        }

        private void rbIncremental_Transfer_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingTransfer.Value = 1;
            trackBarFactTransfer.Value = 1;
            trackBarFactTransferEnriched.Value = 1;
        }

        private void rbFullLoad_Order_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingOrder.Value = 0;
            trackBarFactOrder.Value = 0;
            trackBarFactOrderEnriched.Value = 0;
        }

        private void rbIncremental_Order_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingOrder.Value = 1;
            trackBarFactOrder.Value = 1;
            trackBarFactOrderEnriched.Value = 1;
        }
    }
}
