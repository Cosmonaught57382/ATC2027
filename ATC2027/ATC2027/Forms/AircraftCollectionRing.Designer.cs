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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tabControl = new System.Windows.Forms.TabControl();
            tpAllAircraft = new System.Windows.Forms.TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tpArrivals = new System.Windows.Forms.TabPage();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            tpDepartures = new System.Windows.Forms.TabPage();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            tpFlyBy = new System.Windows.Forms.TabPage();
            dataGridView4 = new System.Windows.Forms.DataGridView();
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
            tableLayoutPanel1.SuspendLayout();
            tabControl.SuspendLayout();
            tpAllAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpArrivals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tpDepartures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tpFlyBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tabControl, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.77778F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.2222214F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 816);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpAllAircraft);
            tabControl.Controls.Add(tpArrivals);
            tabControl.Controls.Add(tpDepartures);
            tabControl.Controls.Add(tpFlyBy);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(3, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(794, 579);
            tabControl.TabIndex = 0;
            // 
            // tpAllAircraft
            // 
            tpAllAircraft.Controls.Add(dataGridView1);
            tpAllAircraft.Location = new System.Drawing.Point(4, 34);
            tpAllAircraft.Name = "tpAllAircraft";
            tpAllAircraft.Padding = new System.Windows.Forms.Padding(3);
            tpAllAircraft.Size = new System.Drawing.Size(786, 541);
            tpAllAircraft.TabIndex = 0;
            tpAllAircraft.Text = "All Aircraft";
            tpAllAircraft.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(780, 535);
            dataGridView1.TabIndex = 0;
            // 
            // tpArrivals
            // 
            tpArrivals.Controls.Add(dataGridView2);
            tpArrivals.Location = new System.Drawing.Point(4, 34);
            tpArrivals.Name = "tpArrivals";
            tpArrivals.Padding = new System.Windows.Forms.Padding(3);
            tpArrivals.Size = new System.Drawing.Size(786, 279);
            tpArrivals.TabIndex = 1;
            tpArrivals.Text = "Arrivals";
            tpArrivals.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView2.Location = new System.Drawing.Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new System.Drawing.Size(780, 273);
            dataGridView2.TabIndex = 0;
            // 
            // tpDepartures
            // 
            tpDepartures.Controls.Add(dataGridView3);
            tpDepartures.Location = new System.Drawing.Point(4, 34);
            tpDepartures.Name = "tpDepartures";
            tpDepartures.Padding = new System.Windows.Forms.Padding(3);
            tpDepartures.Size = new System.Drawing.Size(786, 279);
            tpDepartures.TabIndex = 2;
            tpDepartures.Text = "Departures";
            tpDepartures.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView3.Location = new System.Drawing.Point(3, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new System.Drawing.Size(780, 273);
            dataGridView3.TabIndex = 0;
            // 
            // tpFlyBy
            // 
            tpFlyBy.Controls.Add(dataGridView4);
            tpFlyBy.Location = new System.Drawing.Point(4, 34);
            tpFlyBy.Name = "tpFlyBy";
            tpFlyBy.Padding = new System.Windows.Forms.Padding(3);
            tpFlyBy.Size = new System.Drawing.Size(786, 279);
            tpFlyBy.TabIndex = 3;
            tpFlyBy.Text = "Fly By";
            tpFlyBy.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView4.Location = new System.Drawing.Point(3, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new System.Drawing.Size(780, 273);
            dataGridView4.TabIndex = 0;
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
            tableLayoutPanel2.Controls.Add(cmbBoxSelectAircraft, 1, 2);
            tableLayoutPanel2.Controls.Add(label1, 3, 1);
            tableLayoutPanel2.Controls.Add(lblAltitude, 3, 3);
            tableLayoutPanel2.Controls.Add(label3, 3, 5);
            tableLayoutPanel2.Controls.Add(lblSpeed, 3, 7);
            tableLayoutPanel2.Controls.Add(txtBoxHeading, 4, 1);
            tableLayoutPanel2.Controls.Add(txtBoxAltitude, 4, 3);
            tableLayoutPanel2.Controls.Add(txtBoxSpeed, 4, 7);
            tableLayoutPanel2.Controls.Add(btnApplyClearance, 6, 2);
            tableLayoutPanel2.Controls.Add(cmbBoxAltitudeType, 4, 4);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 588);
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
            tableLayoutPanel2.Size = new System.Drawing.Size(794, 225);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // cmbBoxSelectAircraft
            // 
            cmbBoxSelectAircraft.FormattingEnabled = true;
            cmbBoxSelectAircraft.Location = new System.Drawing.Point(42, 57);
            cmbBoxSelectAircraft.Name = "cmbBoxSelectAircraft";
            cmbBoxSelectAircraft.Size = new System.Drawing.Size(152, 33);
            cmbBoxSelectAircraft.TabIndex = 0;
            cmbBoxSelectAircraft.MouseEnter += cmbBoxSelectAircraft_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(239, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 41);
            label1.TabIndex = 1;
            label1.Text = "Heading";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAltitude
            // 
            lblAltitude.AutoSize = true;
            lblAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAltitude.Location = new System.Drawing.Point(239, 62);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new System.Drawing.Size(152, 41);
            lblAltitude.TabIndex = 2;
            lblAltitude.Text = "Altitude";
            lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(239, 111);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 41);
            label3.TabIndex = 3;
            label3.Text = "AltitudeType";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSpeed.Location = new System.Drawing.Point(239, 160);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(152, 41);
            lblSpeed.TabIndex = 4;
            lblSpeed.Text = "Speed";
            lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxHeading
            // 
            txtBoxHeading.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxHeading.Location = new System.Drawing.Point(397, 16);
            txtBoxHeading.Name = "txtBoxHeading";
            txtBoxHeading.Size = new System.Drawing.Size(152, 31);
            txtBoxHeading.TabIndex = 5;
            // 
            // txtBoxAltitude
            // 
            txtBoxAltitude.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxAltitude.Location = new System.Drawing.Point(397, 65);
            txtBoxAltitude.Name = "txtBoxAltitude";
            txtBoxAltitude.Size = new System.Drawing.Size(152, 31);
            txtBoxAltitude.TabIndex = 6;
            txtBoxAltitude.TextChanged += txtBoxAltitude_TextChanged;
            // 
            // txtBoxSpeed
            // 
            txtBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxSpeed.Location = new System.Drawing.Point(397, 163);
            txtBoxSpeed.Name = "txtBoxSpeed";
            txtBoxSpeed.Size = new System.Drawing.Size(152, 31);
            txtBoxSpeed.TabIndex = 8;
            // 
            // btnApplyClearance
            // 
            btnApplyClearance.Dock = System.Windows.Forms.DockStyle.Fill;
            btnApplyClearance.Location = new System.Drawing.Point(594, 57);
            btnApplyClearance.Name = "btnApplyClearance";
            tableLayoutPanel2.SetRowSpan(btnApplyClearance, 4);
            btnApplyClearance.Size = new System.Drawing.Size(152, 92);
            btnApplyClearance.TabIndex = 9;
            btnApplyClearance.Text = "Apply Clearance";
            btnApplyClearance.UseVisualStyleBackColor = true;
            btnApplyClearance.DragEnter += btnApplyClearance_DragEnter;
            btnApplyClearance.DragOver += btnApplyClearance_DragOver;
            btnApplyClearance.MouseHover += btnApplyClearance_MouseHover;
            // 
            // cmbBoxAltitudeType
            // 
            cmbBoxAltitudeType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxAltitudeType.FormattingEnabled = true;
            cmbBoxAltitudeType.Location = new System.Drawing.Point(397, 106);
            cmbBoxAltitudeType.Name = "cmbBoxAltitudeType";
            cmbBoxAltitudeType.Size = new System.Drawing.Size(152, 33);
            cmbBoxAltitudeType.TabIndex = 10;
            cmbBoxAltitudeType.SelectedIndexChanged += cmbBoxAltitudeType_SelectedIndexChanged;
            // 
            // AircraftCollectionRing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 816);
            Controls.Add(tableLayoutPanel1);
            Name = "AircraftCollectionRing";
            Text = "AircraftCollectionRing";
            Load += AircraftCollectionRing_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tpAllAircraft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpArrivals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tpDepartures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tpFlyBy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpAllAircraft;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpArrivals;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tpDepartures;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tpFlyBy;
        private System.Windows.Forms.DataGridView dataGridView4;
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
    }
}