using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lucky3.Main;
using System.IO;

namespace lucky3
{
    public partial class UserControl_Inventory : UserControl
    {
        public UserControl_Inventory()
        {
            InitializeComponent();
            LoadInventoryData();

            if (Grid_Inventory != null)
            {
                RenumberControlNo(Grid_Inventory);
            }
        }

        public void LoadInventoryData()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "inventory.json");

                if (File.Exists(filePath))
                {
                    // Read the JSON file
                    string json = File.ReadAllText(filePath);

                    // Deserialize JSON to a list of DrawData objects
                    List<DrawData> inventoryData = JsonConvert.DeserializeObject<List<DrawData>>(json);

                    // Clear existing rows in the DataGridView
                    Grid_Inventory.Rows.Clear();

                    // Populate the DataGridView with inventory data
                    foreach (var item in inventoryData)
                    {
                        // Add a row to the DataGridView
                        Grid_Inventory.Rows.Add(
                            item.ControlNo, // CONTROL_NO
                            string.Join(", ", item.StraightNumbers), // STRAIGHT
                            string.Join(", ", item.RambolNumbers), // RAMBOL
                            item.DrawTime, // TIME_DRAW
                            item.MonthDate // DATE
                        );
                    }
                }
                else
                {
                    // Optionally, handle the case where the inventory.json file does not exist
                    MessageBox.Show("The inventory.json file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory data: " + ex.Message);
            }
        }


        private List<DrawData> LoadInventoryDataFromJson()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "inventory.json");

                if (File.Exists(filePath))
                {
                    // Read the JSON file
                    string json = File.ReadAllText(filePath);

                    // Deserialize JSON to a list of DrawData objects
                    return JsonConvert.DeserializeObject<List<DrawData>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory data: " + ex.Message);
            }

            return new List<DrawData>();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Grid_Inventory.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = Grid_Inventory.SelectedRows[0].Index;

                // Get the control number of the selected row
                string controlNo = Grid_Inventory.Rows[rowIndex].Cells["CONTROL_NO"].Value.ToString();

                // Remove the row from the DataGridView
                Grid_Inventory.Rows.RemoveAt(rowIndex);

                // Remove the corresponding data from the inventoryData list
                List<DrawData> inventoryData = LoadInventoryDataFromJson();
                DrawData dataToRemove = inventoryData.FirstOrDefault(item => item.ControlNo == controlNo);
                if (dataToRemove != null)
                {
                    inventoryData.Remove(dataToRemove);

                    // Update the inventory.json file
                    string json = JsonConvert.SerializeObject(inventoryData, Formatting.Indented);
                    File.WriteAllText("inventory.json", json);
                }

                // Renumber ControlNo for the remaining rows
                RenumberControlNo(Grid_Inventory);

                MessageBox.Show("Row deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a row before deleting.");
            }
        }


        private void RenumberControlNo(DataGridView dataGridView)
        {
            // Renumber ControlNo for the remaining rows
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                dataGridView.Rows[i].Cells["CONTROL_NO"].Value = "CTR_0" + (i + 1);
            }
        }

        private void button_PassDataInUpdateForm_Click(object sender, EventArgs e)
        {

            if (Grid_Inventory.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = Grid_Inventory.Rows[Grid_Inventory.SelectedCells[0].RowIndex];
                string controlNo = selectedRow.Cells["CONTROL_NO"].Value.ToString();
                string drawTime = selectedRow.Cells["TIME_DRAW"].Value.ToString();
                string straightNumbers = selectedRow.Cells["STRAIGHT"].Value.ToString();
                string rambolNumbers = selectedRow.Cells["RAMBOL"].Value.ToString();

                // Split comma-separated strings into lists of strings
                List<string> straightNumbersList = straightNumbers.Split(',').ToList();
                List<string> rambolNumbersList = rambolNumbers.Split(',').ToList();

                // Instantiate the UpdateForm
                UpdateForm updateForm = new UpdateForm();

                // Populate the UpdateForm with data
                updateForm.SetControlValues(straightNumbersList, rambolNumbersList, drawTime);

                int selectedRowIndex = Grid_Inventory.SelectedCells[0].RowIndex;

                // Pass data to the UpdateForm  
                updateForm.SetSelectedRowIndex(selectedRowIndex);
                updateForm.SetInventoryData(LoadInventoryDataFromJson());
                updateForm.ShowDialog();

                // Optionally, you can reload the data after updating
                LoadInventoryData();

            }
            else
            {
                MessageBox.Show("Please select a cell before updating.");
            }
        }
    }

}



    




