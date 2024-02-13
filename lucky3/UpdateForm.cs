using Newtonsoft.Json;
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
using static lucky3.Main;

namespace lucky3
{
    public partial class UpdateForm : MetroFramework.Forms.MetroForm
    {
        private List<DrawData> inventoryData;
        private int selectedRowIndex;
        public UpdateForm()
        {
            InitializeComponent();

            // Add choices to the combo box
            metroComboBox_ChooseTime.Items.Add("2:00 PM");
            metroComboBox_ChooseTime.Items.Add("5:00 PM");
            metroComboBox_ChooseTime.Items.Add("9:00 PM");

            // Optionally, you can set a default selection
            metroComboBox_ChooseTime.SelectedIndex = 0;
        }

        // Method to set the values of controls based on the selected cell data
        public void SetControlValues(List<string> straightNumbers, List<string> rambolNumbers, string drawTime)
        {
            
            metroComboBox_ChooseTime.Text = drawTime;
            textBox_Straight1.Text = straightNumbers[0];
            textBox_Straight2.Text = straightNumbers[1];
            textBox_Straight3.Text = straightNumbers[2];
            textBox_Rambol1.Text = rambolNumbers[0];
            textBox_Rambol2.Text = rambolNumbers[1];
            textBox_Rambol3.Text = rambolNumbers[2];
        }

   
        public void SetInventoryData(List<DrawData> data)
        {
            inventoryData = data;
        }

        public void SetSelectedRowIndex(int index)
        {
            selectedRowIndex = index;
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from form controls
                string drawTime = metroComboBox_ChooseTime.SelectedItem.ToString();
                List<string> straightNumbers = new List<string> { textBox_Straight1.Text, textBox_Straight2.Text, textBox_Straight3.Text };
                List<string> rambolNumbers = new List<string> { textBox_Rambol1.Text, textBox_Rambol2.Text, textBox_Rambol3.Text };

                // Get the index of the selected row
                int rowIndex = selectedRowIndex;

                // Find the corresponding DrawData object in the inventoryData list
                DrawData dataToUpdate = inventoryData[rowIndex];

                // Update the data
                dataToUpdate.DrawTime = drawTime;
                dataToUpdate.StraightNumbers = straightNumbers;
                dataToUpdate.RambolNumbers = rambolNumbers;

                // Update the inventory.json file
                string json = JsonConvert.SerializeObject(inventoryData, Formatting.Indented);
                File.WriteAllText("inventory.json", json);

                MessageBox.Show("Data updated successfully.");

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }


    }




}

