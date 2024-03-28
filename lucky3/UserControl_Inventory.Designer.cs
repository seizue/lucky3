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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button_Search = new System.Windows.Forms.Button();
            this.button_ClearSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Grid_Inventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Inventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Grid_Inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Inventory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Grid_Inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Inventory.ColumnHeadersHeight = 40;
            this.Grid_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONTROL_NO,
            this.STRAIGHT,
            this.RAMBOL,
            this.TIME_DRAW,
            this.DATE});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Inventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Inventory.EnableHeadersVisualStyles = false;
            this.Grid_Inventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_Inventory.GridColor = System.Drawing.Color.DimGray;
            this.Grid_Inventory.HighLightPercentage = 100F;
            this.Grid_Inventory.Location = new System.Drawing.Point(3, 3);
            this.Grid_Inventory.MultiSelect = false;
            this.Grid_Inventory.Name = "Grid_Inventory";
            this.Grid_Inventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_Inventory.RowHeadersVisible = false;
            this.Grid_Inventory.RowHeadersWidth = 45;
            this.Grid_Inventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Grid_Inventory.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            this.button_PassDataInUpdateForm.Location = new System.Drawing.Point(453, 2);
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
            this.button_Delete.Location = new System.Drawing.Point(543, 2);
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
            this.Border.Location = new System.Drawing.Point(531, 6);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(2, 18);
            this.Border.TabIndex = 221;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 260;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Search.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Search.Location = new System.Drawing.Point(3, 4);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(68, 22);
            this.button_Search.TabIndex = 262;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_ClearSearch
            // 
            this.button_ClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button_ClearSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_ClearSearch.FlatAppearance.BorderSize = 0;
            this.button_ClearSearch.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_ClearSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ClearSearch.Location = new System.Drawing.Point(342, 2);
            this.button_ClearSearch.Name = "button_ClearSearch";
            this.button_ClearSearch.Size = new System.Drawing.Size(68, 26);
            this.button_ClearSearch.TabIndex = 263;
            this.button_ClearSearch.Text = "CLEAR";
            this.button_ClearSearch.UseVisualStyleBackColor = false;
            this.button_ClearSearch.Click += new System.EventHandler(this.button_ClearSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(430, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 18);
            this.panel1.TabIndex = 264;
            // 
            // UserControl_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ClearSearch);
            this.Controls.Add(this.button_Search);
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
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_ClearSearch;
        private System.Windows.Forms.Panel panel1;
    }
}
