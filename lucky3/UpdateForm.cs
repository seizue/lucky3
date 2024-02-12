using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lucky3
{
    public partial class UpdateForm : MetroFramework.Forms.MetroForm
    {
        public UpdateForm()
        {
            InitializeComponent();
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

        }
    }


}
