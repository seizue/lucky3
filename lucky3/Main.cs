﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lucky3
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private Color defaultColor = Color.Black; // Default color 
        private Color clickedColor = Color.Maroon; // Color when the button is clicked

        public class DrawData
        {
            public string ControlNo { get; set; } // Autogenerated ID
            public string DrawTime { get; set; }
            public List<string> StraightNumbers { get; set; } // For Straight numbers
            public List<string> RambolNumbers { get; set; } // For Rambol numbers
            public string MonthDate { get; set; } // Text displayed MonthDate

            public DrawData()
            {
                StraightNumbers = new List<string>();
                RambolNumbers = new List<string>();
            }
        }


        // List to store the data
        private List<DrawData> drawDataList = new List<DrawData>();

        public Main()
        {
            InitializeComponent();
            UpdateDateTimeLabel();
            

            // Add choices to the combo box
            metroComboBox_ChooseTime.Items.Add("2:00 PM");
            metroComboBox_ChooseTime.Items.Add("5:00 PM");
            metroComboBox_ChooseTime.Items.Add("9:00 PM");

            // Optionally, you can set a default selection
            metroComboBox_ChooseTime.SelectedIndex = 0; // Selects the first item by default
        }

        // Optionally, you can handle the selection change event
        private void metroComboBox_ChooseTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Example of handling the selection change event
            string selectedTime = metroComboBox_ChooseTime.SelectedItem.ToString();
            MessageBox.Show("You selected: " + selectedTime);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroComboBox_ChooseTime.SelectedItem != null) // Ensure an item is selected
                {
                    // Read existing JSON data from the file if it exists
                    List<DrawData> existingData = new List<DrawData>();
                    if (File.Exists("inventory.json"))
                    {
                        string existingJson = File.ReadAllText("inventory.json");
                        existingData = JsonConvert.DeserializeObject<List<DrawData>>(existingJson);

                        // Check if existingData is null
                        if (existingData == null)
                        {
                            existingData = new List<DrawData>(); // Initialize to an empty list
                        }
                    }

                    // Create a new instance of DrawData
                    DrawData data = new DrawData();

                    // Generate ControlNo
                    data.ControlNo = "CTR_0" + (existingData.Count + 1);

                    // Set other properties based on user input
                    data.DrawTime = metroComboBox_ChooseTime.SelectedItem.ToString();

                    // Add Straight numbers
                    data.StraightNumbers.Add(textBox_Straight1.Text);
                    data.StraightNumbers.Add(textBox_Straight2.Text);
                    data.StraightNumbers.Add(textBox_Straight3.Text);

                    // Add Rambol numbers
                    data.RambolNumbers.Add(textBox_Rambol1.Text);
                    data.RambolNumbers.Add(textBox_Rambol2.Text);
                    data.RambolNumbers.Add(textBox_Rambol3.Text);

                    // Add the text displayed in button_MonthDate
                    data.MonthDate = button_MonthDate.Text;

                    // Add the new data to the existing list
                    existingData.Add(data);

                    // Serialize the updated list to JSON
                    string json = JsonConvert.SerializeObject(existingData, Formatting.Indented);

                    // Write the JSON to the file
                    File.WriteAllText("inventory.json", json);

                    MessageBox.Show("Data saved successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a time before saving data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
        

        private void UpdateDateTimeLabel()
        {
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Format the date and time string
            string formattedDateTime = currentDateTime.ToString("MMMM dd, yyyy");

            // Set the label text to the formatted date and time
            button_MonthDate.Text = formattedDateTime;
        }

        private void label_Inventory_Click(object sender, EventArgs e)
        {
            label_Entries.ForeColor = defaultColor;
            label_Inventory.ForeColor = clickedColor;

            userControl_Inventory1.BringToFront();
            userControl_Inventory1.Visible = true;

            userControl_Inventory1.Reload();
        }

        private void label_Entries_Click(object sender, EventArgs e)
        {
            label_Entries.ForeColor = clickedColor;
            label_Inventory.ForeColor = defaultColor;

            userControl_Inventory1.SendToBack();
            userControl_Inventory1.Visible = false;

        }
    }
    
}
