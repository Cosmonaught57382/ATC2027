#pragma warning disable IDE1006 // Naming Styles

using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.Heading;
using ATC2027.DataStructures;
using ATC2027.Library.Altitude;
using ATC2027.Library.Speed;
using SharpDX.DirectWrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.Forms
{
    public partial class AircraftCollectionRing : Form
    {
        public bool formShouldBeUpdated = false;

        private readonly CollectionRing cr;
        private EventBasedList<StatusBoardItem> statusBoardItemList;
        private IList<StatusBoardItem> arrivalStatusBoardItems => [.. statusBoardItemList.Where(x => x.getRelationToThisAirfield() == "arr")];
        private IList<StatusBoardItem> departureStatusBoardItems => [.. statusBoardItemList.Where(x => x.getRelationToThisAirfield() == "dep")];
        private IList<StatusBoardItem> flyByStatusBoardItems => [.. statusBoardItemList.Where(x => x.getRelationToThisAirfield() == "FlyOver")];

        private readonly Dictionary<int, DataGridView> tabIndexAndDataGridView;
        private readonly Dictionary<int, Func<IList<StatusBoardItem>>> tabIndexAndFunctionThatGetsStatusBoardItems;

        public AircraftCollectionRing(ref CollectionRing cr)
        {
            this.cr = cr;

            InitializeComponent();

            statusBoardItemList ??= [];

            UpdateStatusBoardItemList();

            InitialiseDataGridView(ref dgvAllAircraft, this.statusBoardItemList);

            tabIndexAndDataGridView = new Dictionary<int, DataGridView>
            {
                { 0, dgvAllAircraft },
                { 1, dgvArrivals },
                { 2, dgvDepartures },
                { 3, dgvFlyBy }
            };

            tabIndexAndFunctionThatGetsStatusBoardItems = new Dictionary<int, Func<IList<StatusBoardItem>>>
            {
                {0, statusBoardItemList.ToList},
                {1, arrivalStatusBoardItems.ToList},
                {2, departureStatusBoardItems.ToList},
                {3, flyByStatusBoardItems.ToList}
            };

            statusBoardItemList.ItemAdded += UpdateDataGridViewOfSelectedTabIndex;
            statusBoardItemList.ItemRemoved += UpdateDataGridViewOfSelectedTabIndex;
            statusBoardItemList.ItemHasBeenSetByIndexAccess += UpdateDataGridViewOfSelectedTabIndex;
            //statusBoardItemList.ItemHasBeenModified += UpdateForm;
        }
        public void UpdateStatusBoardItemList() 
        {
            this.statusBoardItemList = [.. cr.getAircraftCollectionRingListItemsAsList()];
        }
        public void UpdateForm(object sender = null, EventArgs? e = null)
        {
            //set e to empty if e is null, good practice atm, e isn't accessed or used yet.
            e ??= EventArgs.Empty;
            
            //get the current index
            int index = tabControl.TabIndex;
            
            DataGridView dgv;
            try
            {
                dgv = tabIndexAndDataGridView[index];
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"The {nameof(tabIndexAndDataGridView)} didn't have an item at index {tabControl.TabIndex}");
                return;
            }

            UpdateStatusBoardItemList();
            dgv.Invalidate();
            UpdateDataGridViewOfSelectedTabIndex(sender, new FromUpdateFormFunctionCall(e));
        }
        
        public class FromUpdateFormFunctionCall : EventArgs {
            EventArgs? previousEventArgs;

            public FromUpdateFormFunctionCall(EventArgs e) {
                previousEventArgs = e;
            }
        }

        private void UpdateDataGridViewOfSelectedTabIndex(object sender = null, EventArgs? e = null)
        {
            //set e to empty if e is null, good practice atm, e isn't accessed or used yet.
            e ??= EventArgs.Empty;

            //get the current index
            int index = tabControl.TabIndex;

            //get the dgv associated with the current index
            DataGridView dgv;
            try
            {
                dgv = tabIndexAndDataGridView[index];
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"The {nameof(tabIndexAndDataGridView)} didn't have an item at index {tabControl.TabIndex}");
                return;
            }

            //get the function that gets the status board items associated with the current index
            Func<IList<StatusBoardItem>> funcThatGetsStatusBoardItems;
            try
            {
                funcThatGetsStatusBoardItems = tabIndexAndFunctionThatGetsStatusBoardItems[index];
            }
            catch (IndexOutOfRangeException)
            {
                DialogResult dialogResult = MessageBox.Show($"The {nameof(tabIndexAndFunctionThatGetsStatusBoardItems)} didn't have an item at index {tabControl.TabIndex}");
                return;
            }
            dgv.Invalidate();
            InitialiseDataGridView(ref dgv, funcThatGetsStatusBoardItems());
        }

        
        private void btnApplyClearance_DragOver(object sender, DragEventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }
        private void btnApplyClearance_DragEnter(object sender, DragEventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void AircraftCollectionRing_Load(object sender, EventArgs e)
        {
            cmbBoxSelectAircraft.TabIndex = 0;
            txtBoxHeading.TabIndex = 1;
            txtBoxAltitude.TabIndex = 2;

            cmbBoxAltitudeType.TabIndex = 3;

            cmbBoxAltitudeType.Items.Clear();
            cmbBoxAltitudeType.Items.Add("Feet");
            cmbBoxAltitudeType.Items.Add("Flight Level");

            txtBoxSpeed.TabIndex = 4;

            UpdateCmbBoxSelectAircraft();
        }

        private void cmbBoxSelectAircraft_MouseEnter(object sender, EventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void txtBoxAltitude_TextChanged(object sender, EventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void cmbBoxAltitudeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        public void SetDataGrid(IList<StatusBoardItem> statusBoardItemList)
        {

        }

        private void InitialiseDataGridView(ref DataGridView dgv, IList<StatusBoardItem> statusBoardItems)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("Flight Number", "FlightNumber");
            dgv.Columns.Add("Heading", "Heading (deg)");
            dgv.Columns.Add("Altitude", "Altitude");
            dgv.Columns.Add("Speed", "Speed");
            dgv.Columns.Add("Relation to airfield", "RelationToAirfield");

            foreach (StatusBoardItem sbi in statusBoardItems)
            {
                dgv.Rows.Add(sbi.getFlightNo(), sbi.getHeadingAsStr(), sbi.getAltitudeAsStr(), sbi.getSpeed(), sbi.getRelationToThisAirfield());
            }


        }

        private void btnApplyClearance_MouseHover(object sender, EventArgs e)
        {
            cmbBoxAltitudeType.Cursor = Cursors.Hand;
        }

        private void cmbBoxSelectAircraft_MouseHover(object sender, EventArgs e)
        {
            cmbBoxAltitudeType.Cursor = Cursors.Hand;
        }

        private void cmbBoxAltitudeType_MouseHover(object sender, EventArgs e)
        {
            cmbBoxAltitudeType.Cursor = Cursors.Hand;
        }

        private void btnApplyClearance_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            bool speedIsValid = SpeedIsValid(ref errorMessage);
            bool altitudeIsValid = AltitudeIsValid(ref errorMessage);
            bool headingIsValid = HeadingIsValid(ref errorMessage);
            bool flightNumberIsValid = FlightNumberIsValid(ref errorMessage);

            if (!(speedIsValid && altitudeIsValid && headingIsValid && flightNumberIsValid))
            {
                lblResult.Text = errorMessage;
            }
            else {
                IClearance clearance = Clearance.getEmptyClearance();

                if (txtBoxHeading.Text != "")
                    clearance.ApplyHeading(new Heading(txtBoxHeading.Text));
                if (txtBoxSpeed.Text != "")
                    clearance.ApplySpeed(new Speed(txtBoxSpeed.Text));
                if (txtBoxAltitude.Text != "")
                    clearance.ApplyAltitude(new Altitude(txtBoxAltitude.Text, cmbBoxAltitudeType));

                //apply clearance here
                Plane plane;
                try
                {
                    plane = cr.GetPlaneByFlightNumber(cmbBoxSelectAircraft.Text);
                }
                catch (Exception)
                {

                    DialogResult result = MessageBox.Show(this, $"Unable to find {cmbBoxSelectAircraft.Text}", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.Cancel) { return; }
                    else if (result == DialogResult.Retry)
                        btnApplyClearance_Click(this, new EventArgs());
                    else
                    {
                        MessageBox.Show(this, $"Dialogue result {result} not handled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                this.cr.ApplyClearance(clearance, ref plane);

                //clear text boxes and combo boxes
                lblResult.Text = "clearance applied";
                txtBoxAltitude.Text = "";
                txtBoxHeading.Text = "";
                txtBoxSpeed.Text = "";
                cmbBoxAltitudeType.Text = "";
                cmbBoxSelectAircraft.Text = "";
            } 
        }
        

        private bool FlightNumberIsValid(ref string errorMessage)
        {
            bool result = cmbBoxSelectAircraft.Items.Contains(cmbBoxSelectAircraft.Text);
            if (!result)
                errorMessage = "flight number could not be found";

            return result;

        }

        private bool SpeedIsValid(ref string errorMessage)
        {
            bool speedIsValid;
            //speed is larger than 0 and less than 400
            try
            {
                var val = Int128.Parse(txtBoxSpeed.Text);
                
                speedIsValid = val < 400 && val > 50;
                if (!speedIsValid)
                    errorMessage = "speed was out of the range";

                return speedIsValid;
            }
            catch (Exception)
            {
                if (txtBoxSpeed.Text != "")
                {
                    errorMessage = "speed was not a number";
                    return false;
                }
                return true;

            }
        }

        private bool AltitudeIsValid(ref string errorMessage)
        {
            if (cmbBoxAltitudeType.SelectedItem == null)
            {
                errorMessage = "Altitude type was not selected";
                return txtBoxAltitude.Text == "";
            }
                

            bool altitudeIsInFeet = cmbBoxAltitudeType.Text.ToLower() == "feet";
            
            //altitude in feet is larger than 0 and less than 100000
            if (altitudeIsInFeet)
            {
                try
                {
                    var val = Int128.Parse(txtBoxHeading.Text);
                    return val < 100000 && val > -1;
                }
                catch (Exception)
                {
                    return txtBoxHeading.Text == "";
                }
            }
            else
            {
               //altitude in flight level is larger than 0 and less than 100
                try
                {
                   var val = Int128.Parse(txtBoxHeading.Text);
                   return val < 100 && val > -1;
                }
                catch (Exception)
                {
                   return txtBoxHeading.Text == "";
                }               
            }
        }

        private bool HeadingIsValid(ref string errorMessage)
        {
            //heading is an integer larger than -1 and smaller than 361
            bool headingIsOutsideTheRange;
            bool isValid;
            try
            {
                var val = Int128.Parse(txtBoxHeading.Text);
                headingIsOutsideTheRange = !(val < 361 && val > -1);

                if (headingIsOutsideTheRange)
                {
                    errorMessage = "heading was outside the range";
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                
                var result = (txtBoxHeading.Text == "");

                if (!result)
                    errorMessage = "heading was not a number";

                return result;
            }
        }

        private void UpdateCmbBoxSelectAircraft()
        {
            DataGridView dgv;
            try
            {
                dgv = tabIndexAndDataGridView[tabControl.SelectedIndex];
            }
            catch (Exception)
            {
                //tabControl.SelectedIndex was not a valid value for the number of items in tabIndexAndDataGridView
                return;
            }
            cmbBoxSelectAircraft.Items.Clear();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                cmbBoxSelectAircraft.Items.Add(row.Cells[0].Value);
            }
            cmbBoxSelectAircraft.Text = "";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControl.SelectedIndex;
            try
            {
                var dgv = tabIndexAndDataGridView[selectedIndex];
                IList<StatusBoardItem> statusBoardItems;

                switch (selectedIndex)
                {
                    case 0:
                        statusBoardItems = flyByStatusBoardItems;
                        break;
                    case 1:
                        statusBoardItems = arrivalStatusBoardItems;
                        break;
                    case 2:
                        statusBoardItems = departureStatusBoardItems;
                        break;
                    case 3:
                        statusBoardItems = flyByStatusBoardItems;
                        break;
                    default:
                        throw new NotImplementedException("indexes beyond 3 not handled");
                }
                    

                InitialiseDataGridView(ref dgv, statusBoardItems);
                UpdateCmbBoxSelectAircraft();
            }
            catch (Exception)
            {
                lblResult.Text = $"ERROR - unable to set dgv with a selectedTabIndex of {selectedIndex}";
                tabControl.SelectedIndex = 0;
            }
            
        }
    }
}
