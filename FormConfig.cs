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
            // Order
            trackBarStagingOrder.Value = this.getValue("ERP_ICS_Order", "Staging");
            trackBarFactOrder.Value = this.getValue("FactOrder", "DWH_Test");
            trackBarFactOrderEnriched.Value = this.getValue("FactOrderEnriched", "DWH_Test");

            //Transfer
            trackBarStagingTransfer.Value = this.getValue("ERP_ICS_Transfer", "Staging");
            trackBarFactTransfer.Value = this.getValue("FactTransfer", "DWH_Test");
            trackBarFactTransferEnriched.Value = this.getValue("FactTransferEnrich", "DWH_Test");

            //Inventory month
            trackBarStagingInventoryMonth.Value = this.getValue("ERP_ICS_InventoryMonth", "Staging");
            trackBarFactInventoryMonth.Value = this.getValue("FactInventoryMonth", "DWH_Test");
            trackBarFactInventoryMonthEnriched.Value = this.getValue("FactInventoryMonthEnriched", "DWH_Test");

            //Inventory voyage
            trackBarStagingInventoryVoyage.Value = this.getValue("ERP_ICS_InventoryVoyage", "Staging");
            trackBarFactInventoryVoyage.Value = this.getValue("FactInventoryVoyage", "DWH_Test");
            trackBarFactInventoryVoyageEnriched.Value = this.getValue("FactInventoryVoyageEnriched", "DWH_Test");

            //Physical count
            trackBarStagingPhysicalCount.Value  = this.getValue("ERP_ICS_PhysicalCount", "Staging");
            trackBarFactPhysicalCount.Value     = this.getValue("FactPhysicalCount", "DWH_Test");
            trackBarPhysicalCountEnriched.Value = this.getValue("FactPhysicalCountEnriched", "DWH_Test");

            //Adjustment
            trackBarStagingAdjustment.Value = this.getValue("ERP_ICS_Adjustment", "Staging");
            trackBarFactAdjustment.Value = this.getValue("FactAdjustment", "DWH_Test");
            trackBarAdjustmentEnriched.Value = this.getValue("FactAdjustmentEnriched", "DWH_Test");

            // Invoice
            trackBarStagingInvoice.Value = this.getValue("ERP_ICS_Invoice", "Staging");
            trackBarFactInvoice.Value = this.getValue("FactInvoice", "DWH_Test");
            trackBarInvoiceEnriched.Value = this.getValue("FactInvoiceEnriched", "DWH_Test");

            // POSInvoice
            trackBarStagingPOSInvoice.Value = this.getValue("ERP_ICS_POSInvoice", "Staging");
            trackBarFactPOSInvoice.Value = this.getValue("FactPOSInvoice", "DWH_Test");
            trackBarPOSInvoiceEnriched.Value = this.getValue("FactPOSInvoiceEnriched", "DWH_Test");

            //Delivery
            trackBarStagingDelivery.Value = this.getValue("ERP_ICS_Delivery", "Staging");
            trackBarFactDelivery.Value= this.getValue("FactDelivery", "DWH_Test");
            trackBarDeliveryEnriched.Value= this.getValue("FactDeliveryEnriched", "DWH_Test");

            trackBarStagingDeliveryDetail.Value = this.getValue("ERP_ICS_DeliveryDetail", "Staging");
            trackBarFactDeliveryDetail.Value = this.getValue("FactDeliveryDetail", "DWH_Test");
            trackBarDeliveryDetailEnriched.Value = this.getValue("FactDeliveryDetailEnriched", "DWH_Test");

            //Receiving
            trackBarStagingReceiving.Value = this.getValue("ERP_ICS_Receiving", "Staging");
            trackBarFactReceiving.Value = this.getValue("FactReceiving", "DWH_Test");
            trackBarReceivingEnriched.Value = this.getValue("FactReceivingEnriched", "DWH_Test");

            //full load
            if (this.getValue("AllTables", "DWH_Test") == 0)
                {
                   cBReloadDWH.Checked = true;
                }
            else
            {
                cBReloadDWH.Checked = false;
            }

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

        private void fullLoad(int value)
        {
            trackBarStagingTransfer.Value = value;
            trackBarFactTransfer.Value = value;
            trackBarFactTransferEnriched.Value = value;

            trackBarStagingOrder.Value = value;
            trackBarFactOrder.Value = value;
            trackBarFactOrderEnriched.Value = value;

            trackBarFactInventoryMonth.Value = value;
            trackBarFactInventoryMonthEnriched.Value = value;
            trackBarStagingInventoryMonth.Value = value;

            trackBarStagingInventoryVoyage.Value = value;
            trackBarFactInventoryVoyageEnriched.Value = value;
            trackBarFactInventoryVoyage.Value = value;

            trackBarStagingPhysicalCount.Value = value;
            trackBarFactPhysicalCount.Value = value;
            trackBarPhysicalCountEnriched.Value = value;

            trackBarStagingInvoice.Value = value;
            trackBarFactInvoice.Value = value;
            trackBarInvoiceEnriched.Value = value;

            trackBarStagingDelivery.Value = value;
            trackBarFactDelivery.Value = value;
            trackBarDeliveryEnriched.Value = value;

            trackBarStagingDeliveryDetail.Value = value;
            trackBarFactDeliveryDetail.Value = value;
            trackBarDeliveryDetailEnriched.Value = value;

            trackBarStagingReceiving.Value = value;
            trackBarFactReceiving.Value = value;
            trackBarReceivingEnriched.Value = value;

            trackBarStagingPOSInvoice.Value = value;
            trackBarFactPOSInvoice.Value = value;
            trackBarPOSInvoiceEnriched.Value = value;

            trackBarStagingAdjustment.Value = value;
            trackBarFactAdjustment.Value = value;
            trackBarAdjustmentEnriched.Value = value;

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
          
            saveValue("ERP_ICS_InventoryMonth", "Staging", trackBarStagingInventoryMonth.Value);
            saveValue("FactInventoryMonth", "DWH_Test", trackBarFactInventoryMonth.Value);
            saveValue("FactInventoryMonthEnriched", "DWH_Test", trackBarFactInventoryMonthEnriched.Value);
            
            saveValue("ERP_ICS_InventoryVoyage", "Staging", trackBarStagingInventoryVoyage.Value);
            saveValue("FactInventoryVoyage", "DWH_Test", trackBarFactInventoryVoyage.Value);
            saveValue("FactInventoryVoyageEnriched", "DWH_Test", trackBarFactInventoryVoyageEnriched.Value);

            saveValue("ERP_ICS_PhysicalCount", "Staging", trackBarStagingPhysicalCount.Value);
            saveValue("FactPhysicalCount", "DWH_Test", trackBarFactPhysicalCount.Value);
            saveValue("FactPhysicalCountEnriched", "DWH_Test", trackBarPhysicalCountEnriched.Value);

            saveValue("ERP_ICS_Adjustment", "Staging", trackBarStagingAdjustment.Value);
            saveValue("FactAdjustment", "DWH_Test", trackBarFactAdjustment.Value);
            saveValue("FactAdjustmentEnriched", "DWH_Test", trackBarAdjustmentEnriched.Value);

            saveValue("ERP_ICS_Invoice", "Staging", trackBarStagingInvoice.Value);
            saveValue("FactInvoice", "DWH_Test", trackBarFactInvoice.Value);
            saveValue("FactInvoiceEnriched", "DWH_Test", trackBarInvoiceEnriched.Value);

            saveValue("ERP_ICS_POSInvoice", "Staging", trackBarStagingPOSInvoice.Value);
            saveValue("FactPOSInvoice", "DWH_Test", trackBarFactPOSInvoice.Value);
            saveValue("FactPOSInvoiceEnriched", "DWH_Test", trackBarPOSInvoiceEnriched.Value);

            saveValue("ERP_ICS_Delivery", "Staging", trackBarStagingDelivery.Value);
            saveValue("FactDelivery", "DWH_Test",trackBarFactDelivery.Value);
            saveValue("FactDeliveryEnriched", "DWH_Test", trackBarDeliveryEnriched.Value);

            saveValue("ERP_ICS_DeliveryDetail", "Staging", trackBarStagingDeliveryDetail.Value);
            saveValue("FactDeliveryDetail", "DWH_Test", trackBarFactDeliveryDetail.Value);
            saveValue("FactDeliveryDetailEnriched", "DWH_Test",trackBarDeliveryDetailEnriched.Value);

            saveValue("ERP_ICS_Receiving", "Staging", trackBarStagingReceiving.Value);
            saveValue("FactReceiving", "DWH_Test", trackBarFactReceiving.Value);
            saveValue("FactReceivingEnriched", "DWH_Test", trackBarReceivingEnriched.Value);

            if (cBReloadDWH.Checked == true)
            {
                saveValue("AllTables", "DWH_Test",0);
            }
            else
            {
                saveValue("AllTables", "DWH_Test", 1);
            }
            
            
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            trackBarFactInventoryMonth.Value= 0;
            trackBarFactInventoryMonthEnriched.Value= 0;
            trackBarStagingInventoryMonth.Value= 0;
        }

        private void rbIncremental_InventoryMonth_CheckedChanged(object sender, EventArgs e)
        {
            trackBarFactInventoryMonth.Value = 1;
            trackBarFactInventoryMonthEnriched.Value = 1;
            trackBarStagingInventoryMonth.Value = 1;
        }

        private void rbFullLoad_InventoryVoyage_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingInventoryVoyage.Value = 0;
            trackBarFactInventoryVoyageEnriched.Value = 0;
            trackBarFactInventoryVoyage.Value = 0;
        }

        private void rbIncremental_InventoryVoyage_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingInventoryVoyage.Value = 1;
            trackBarFactInventoryVoyageEnriched.Value = 1;
            trackBarFactInventoryVoyage.Value = 1;
        }

        private void rbFullLoad_PhysicalCount_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingPhysicalCount.Value = 0;
            trackBarFactPhysicalCount.Value = 0;
            trackBarPhysicalCountEnriched.Value = 0;
        }

        private void rbIncremental_PhysicalCount_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingPhysicalCount.Value = 1;
            trackBarFactPhysicalCount.Value = 1;
            trackBarPhysicalCountEnriched.Value = 1;
        }

        private void rbFullLoad_Invoice_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingInvoice.Value = 0;
            trackBarFactInvoice.Value = 0;
            trackBarInvoiceEnriched.Value = 0;  
        }

        private void rbIncremental_Invoice_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingInvoice.Value = 1;
            trackBarFactInvoice.Value = 1;
            trackBarInvoiceEnriched.Value = 1;
        }

        private void rbFullLoad_Delivery_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingDelivery.Value = 0;
            trackBarFactDelivery.Value = 0; 
            trackBarDeliveryEnriched.Value = 0;
        }

        private void rbIncremental_Delivery_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingDelivery.Value = 1;
            trackBarFactDelivery.Value = 1;
            trackBarDeliveryEnriched.Value = 1;
        }

        private void rbFullLoad_DeliveryDetail_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingDeliveryDetail.Value = 0; 
            trackBarFactDeliveryDetail.Value= 0;
            trackBarDeliveryDetailEnriched.Value = 0;
        }

        private void rbIncremental_DeliveryDetail_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingDeliveryDetail.Value = 1;
            trackBarFactDeliveryDetail.Value = 1;
            trackBarDeliveryDetailEnriched.Value = 1;
        }

        private void rbFullLoad_Receiving_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingReceiving.Value=0;
            trackBarFactReceiving.Value=0;
            trackBarReceivingEnriched.Value=0;
        }

        private void rbIncremental_Receiving_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingReceiving.Value = 1;
            trackBarFactReceiving.Value = 1;
            trackBarReceivingEnriched.Value = 1;
        }

        private void rbFullLoad_POSInvoice_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingPOSInvoice.Value = 0;
            trackBarFactPOSInvoice.Value = 0;
            trackBarPOSInvoiceEnriched.Value = 0;
        }

        private void rbIncremental_POSInvoice_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingPOSInvoice.Value = 1;
            trackBarFactPOSInvoice.Value = 1;
            trackBarPOSInvoiceEnriched.Value = 1;
        }

        private void rbFullLoad_Adjustment_CheckedChanged(object sender, EventArgs e)
        {
            trackBarStagingAdjustment.Value = 0;
            trackBarFactAdjustment.Value = 0;
            trackBarAdjustmentEnriched.Value = 0;
        }

        private void cBReloadDWH_CheckedChanged(object sender, EventArgs e)
        {
            if (cBReloadDWH.Checked == true)
            {
                fullLoad(0);
            }
            else
            {
                fullLoad(1);
            }
        }
    }
}
