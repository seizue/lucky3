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
                    // Handle the case where the file doesn't exist
                    MessageBox.Show("Inventory file not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the loading process
                MessageBox.Show("Error loading inventory data: " + ex.Message);
            }
        }



    }
}

