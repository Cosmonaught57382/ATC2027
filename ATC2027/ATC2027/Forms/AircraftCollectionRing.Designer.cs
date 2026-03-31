namespace ATC2027.Forms
{
    partial class AircraftCollectionRing
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            cmbBoxSelectAircraft = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            lblAltitude = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblSpeed = new System.Windows.Forms.Label();
            txtBoxHeading = new System.Windows.Forms.TextBox();
            txtBoxAltitude = new System.Windows.Forms.TextBox();
            txtBoxSpeed = new System.Windows.Forms.TextBox();
            btnApplyClearance = new System.Windows.Forms.Button();
            cmbBoxAltitudeType = new System.Windows.Forms.ComboBox();
            lblResult = new System.Windows.Forms.Label();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(cmbBoxSelectAircraft, 1, 3);
            tableLayoutPanel2.Controls.Add(label1, 3, 1);
            tableLayoutPanel2.Controls.Add(lblAltitude, 3, 3);
            tableLayoutPanel2.Controls.Add(label3, 3, 5);
            tableLayoutPanel2.Controls.Add(lblSpeed, 3, 7);
            tableLayoutPanel2.Controls.Add(txtBoxHeading, 4, 1);
            tableLayoutPanel2.Controls.Add(txtBoxAltitude, 4, 3);
            tableLayoutPanel2.Controls.Add(txtBoxSpeed, 4, 7);
            tableLayoutPanel2.Controls.Add(btnApplyClearance, 6, 3);
            tableLayoutPanel2.Controls.Add(cmbBoxAltitudeType, 4, 5);
            tableLayoutPanel2.Controls.Add(lblResult, 6, 6);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.097561F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.097561F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(798, 294);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // cmbBoxSelectAircraft
            // 
            cmbBoxSelectAircraft.FormattingEnabled = true;
            cmbBoxSelectAircraft.Location = new System.Drawing.Point(42, 83);
            cmbBoxSelectAircraft.Name = "cmbBoxSelectAircraft";
            cmbBoxSelectAircraft.Size = new System.Drawing.Size(152, 33);
            cmbBoxSelectAircraft.TabIndex = 0;
            cmbBoxSelectAircraft.MouseEnter += cmbBoxSelectAircraft_MouseEnter_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(240, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(153, 53);
            label1.TabIndex = 1;
            label1.Text = "Heading";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAltitude
            // 
            lblAltitude.AutoSize = true;
            lblAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAltitude.Location = new System.Drawing.Point(240, 80);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new System.Drawing.Size(153, 53);
            lblAltitude.TabIndex = 2;
            lblAltitude.Text = "Altitude";
            lblAltitude.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(240, 143);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 53);
            label3.TabIndex = 3;
            label3.Text = "AltitudeType";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSpeed.Location = new System.Drawing.Point(240, 206);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(153, 53);
            lblSpeed.TabIndex = 4;
            lblSpeed.Text = "Speed";
            lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxHeading
            // 
            txtBoxHeading.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxHeading.Location = new System.Drawing.Point(399, 20);
            txtBoxHeading.Name = "txtBoxHeading";
            txtBoxHeading.Size = new System.Drawing.Size(153, 31);
            txtBoxHeading.TabIndex = 5;
            // 
            // txtBoxAltitude
            // 
            txtBoxAltitude.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxAltitude.Location = new System.Drawing.Point(399, 83);
            txtBoxAltitude.Name = "txtBoxAltitude";
            txtBoxAltitude.Size = new System.Drawing.Size(153, 31);
            txtBoxAltitude.TabIndex = 6;
            // 
            // txtBoxSpeed
            // 
            txtBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxSpeed.Location = new System.Drawing.Point(399, 209);
            txtBoxSpeed.Name = "txtBoxSpeed";
            txtBoxSpeed.Size = new System.Drawing.Size(153, 31);
            txtBoxSpeed.TabIndex = 8;
            // 
            // btnApplyClearance
            // 
            btnApplyClearance.Dock = System.Windows.Forms.DockStyle.Fill;
            btnApplyClearance.Location = new System.Drawing.Point(597, 83);
            btnApplyClearance.Name = "btnApplyClearance";
            btnApplyClearance.Size = new System.Drawing.Size(153, 47);
            btnApplyClearance.TabIndex = 9;
            btnApplyClearance.Text = "Apply Clearance";
            btnApplyClearance.UseVisualStyleBackColor = true;
            btnApplyClearance.Click += btnApplyClearance_Click;
            // 
            // cmbBoxAltitudeType
            // 
            cmbBoxAltitudeType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxAltitudeType.FormattingEnabled = true;
            cmbBoxAltitudeType.Location = new System.Drawing.Point(399, 146);
            cmbBoxAltitudeType.Name = "cmbBoxAltitudeType";
            cmbBoxAltitudeType.Size = new System.Drawing.Size(153, 33);
            cmbBoxAltitudeType.TabIndex = 10;
            // 
            // lblResult
            // 
            lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.ForeColor = System.Drawing.Color.Red;
            lblResult.Location = new System.Drawing.Point(597, 196);
            lblResult.Name = "lblResult";
            tableLayoutPanel2.SetRowSpan(lblResult, 4);
            lblResult.Size = new System.Drawing.Size(153, 98);
            lblResult.TabIndex = 11;
            lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AircraftCollectionRing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 294);
            Controls.Add(tableLayoutPanel2);
            MaximumSize = new System.Drawing.Size(820, 350);
            MinimumSize = new System.Drawing.Size(820, 350);
            Name = "AircraftCollectionRing";
            Text = "AircraftCollectionRing";
            Load += AircraftCollectionRing_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbBoxSelectAircraft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtBoxHeading;
        private System.Windows.Forms.TextBox txtBoxAltitude;
        private System.Windows.Forms.TextBox txtBoxSpeed;
        private System.Windows.Forms.Button btnApplyClearance;
        private System.Windows.Forms.ComboBox cmbBoxAltitudeType;
        private System.Windows.Forms.Label lblResult;
    }
}