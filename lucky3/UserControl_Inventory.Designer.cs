namespace lucky3
{
    partial class UserControl_Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grid_Inventory = new MetroFramework.Controls.MetroGrid();
            this.CONTROL_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STRAIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMBOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME_DRAW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_PassDataInUpdateForm = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.Border = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.Grid_Inventory);
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 325);
            this.panel2.TabIndex = 220;
            // 
            // Grid_Inventory
            // 
            this.Grid_Inventory.AllowUserToResizeColumns = false;
            this.Grid_Inventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.Black;
            this.Grid_Inventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle56;
            this.Grid_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Inventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Grid_Inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Inventory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Grid_Inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Calibri", 8.75F);
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.Grid_Inventory.ColumnHeadersHeight = 40;
            this.Grid_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONTROL_NO,
            this.STRAIGHT,
            this.RAMBOL,
            this.TIME_DRAW,
            this.DATE});
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Inventory.DefaultCellStyle = dataGridViewCellStyle58;
            this.Grid_Inventory.EnableHeadersVisualStyles = false;
            this.Grid_Inventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_Inventory.GridColor = System.Drawing.Color.DimGray;
            this.Grid_Inventory.HighLightPercentage = 100F;
            this.Grid_Inventory.Location = new System.Drawing.Point(3, 3);
            this.Grid_Inventory.MultiSelect = false;
            this.Grid_Inventory.Name = "Grid_Inventory";
            this.Grid_Inventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.Grid_Inventory.RowHeadersVisible = false;
            this.Grid_Inventory.RowHeadersWidth = 45;
            this.Grid_Inventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            this.Grid_Inventory.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.Grid_Inventory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Grid_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Inventory.Size = new System.Drawing.Size(605, 319);
            this.Grid_Inventory.TabIndex = 16;
            this.Grid_Inventory.UseCustomBackColor = true;
            this.Grid_Inventory.UseCustomForeColor = true;
            this.Grid_Inventory.UseStyleColors = true;
            // 
            // CONTROL_NO
            // 
            this.CONTROL_NO.HeaderText = "CONTROL NO.";
            this.CONTROL_NO.Name = "CONTROL_NO";
            // 
            // STRAIGHT
            // 
            this.STRAIGHT.HeaderText = "STRAIGHT";
            this.STRAIGHT.Name = "STRAIGHT";
            // 
            // RAMBOL
            // 
            this.RAMBOL.HeaderText = "RAMBOL";
            this.RAMBOL.Name = "RAMBOL";
            // 
            // TIME_DRAW
            // 
            this.TIME_DRAW.HeaderText = "TIME DRAW";
            this.TIME_DRAW.Name = "TIME_DRAW";
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            // 
            // button_PassDataInUpdateForm
            // 
            this.button_PassDataInUpdateForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_PassDataInUpdateForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_PassDataInUpdateForm.FlatAppearance.BorderSize = 0;
            this.button_PassDataInUpdateForm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PassDataInUpdateForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_PassDataInUpdateForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PassDataInUpdateForm.Location = new System.Drawing.Point(393, 2);
            this.button_PassDataInUpdateForm.Name = "button_PassDataInUpdateForm";
            this.button_PassDataInUpdateForm.Size = new System.Drawing.Size(68, 26);
            this.button_PassDataInUpdateForm.TabIndex = 224;
            this.button_PassDataInUpdateForm.Text = "UPDATE";
            this.button_PassDataInUpdateForm.UseVisualStyleBackColor = false;
            this.button_PassDataInUpdateForm.Click += new System.EventHandler(this.button_PassDataInUpdateForm_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Delete.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Delete.Location = new System.Drawing.Point(483, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(68, 26);
            this.button_Delete.TabIndex = 223;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Border.Location = new System.Drawing.Point(471, 6);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(2, 18);
            this.Border.TabIndex = 221;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 260;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 22);
            this.button1.TabIndex = 262;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserControl_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_PassDataInUpdateForm);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl_Inventory";
            this.Size = new System.Drawing.Size(618, 364);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid Grid_Inventory;
        private System.Windows.Forms.Button button_PassDataInUpdateForm;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTROL_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STRAIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMBOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME_DRAW;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}
