using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.Forms
{
    public partial class AircraftCollectionRing : Form
    {
        public AircraftCollectionRing()
        {
            InitializeComponent();
        }

        private void btnApplyClearance_DragOver(object sender, DragEventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void btnApplyClearance_DragEnter(object sender, DragEventArgs e)
        {
            //Mouse to be hand with finger
        }

        private void AircraftCollectionRing_Load(object sender, EventArgs e)
        {
            cmbBoxSelectAircraft.TabIndex = 0;
            txtBoxHeading.TabIndex = 1;
            txtBoxAltitude.TabIndex = 2;

            cmbBoxAltitudeType.SelectedIndex = 3;

            cmbBoxAltitudeType.Items.Clear();
            cmbBoxAltitudeType.Items.Add("Feet");
            cmbBoxAltitudeType.Items.Add("Flight Level");

            txtBoxSpeed.TabIndex = 4;
        }

        private void cmbBoxSelectAircraft_MouseEnter(object sender, EventArgs e)
        {
            //Mouse to be hand with finger
        }

        private void txtBoxAltitude_TextChanged(object sender, EventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void cmbBoxAltitudeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mouse to be hand with finger
        }
    }
}
