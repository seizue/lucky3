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

        public void SetControlValues(string selectedCellValue, List<string> straightNumbers, List<string> rambolNumbers, string drawTime)
        {
            // Set the values of the controls based on the parameters passed
            metroComboBox_ChooseTime.Text = drawTime;
            textBox_Straight1.Text = straightNumbers[0];
            textBox_Straight2.Text = straightNumbers[1];
            textBox_Straight3.Text = straightNumbers[2];
            textBox_Rambol1.Text = rambolNumbers[0];
            textBox_Rambol2.Text = rambolNumbers[1];
            textBox_Rambol3.Text = rambolNumbers[2];
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            // Get the updated values from the controls
            string drawTime = metroComboBox_ChooseTime.Text;
            List<string> straightNumbers = new List<string>
            {
                textBox_Straight1.Text,
                textBox_Straight2.Text,
                textBox_Straight3.Text
            };
            List<string> rambolNumbers = new List<string>
            {
                textBox_Rambol1.Text,
                textBox_Rambol2.Text,
                textBox_Rambol3.Text
            };

            // Update the data in the inventory.json file
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "inventory.json");

                if (File.Exists(filePath))
                {
                    // Read the existing JSON data
                    string json = File.ReadAllText(filePath);

                    // Deserialize JSON to a list of DrawData objects
                    List<DrawData> inventoryData = JsonConvert.DeserializeObject<List<DrawData>>(json);

                    // Find the corresponding DrawData object and update its properties
                    foreach (DrawData data in inventoryData)
                    {
                        if (data.DrawTime == drawTime && data.StraightNumbers.SequenceEqual(straightNumbers) && data.RambolNumbers.SequenceEqual(rambolNumbers))
                        {
                            // Update the properties
                            data.DrawTime = drawTime;
                            data.StraightNumbers = straightNumbers;
                            data.RambolNumbers = rambolNumbers;

                            break; // Exit the loop after updating
                        }
                    }

                    // Serialize the updated list to JSON
                    string updatedJson = JsonConvert.SerializeObject(inventoryData, Formatting.Indented);

                    // Write the updated JSON data back to the file
                    File.WriteAllText(filePath, updatedJson);

                    MessageBox.Show("Changes saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }
    }
}
    



