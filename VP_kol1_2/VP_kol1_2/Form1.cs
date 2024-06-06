using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_kol1_2
{
    public partial class Form1 : Form
    {
        public List<Driver> drivers = new List<Driver>();
        public decimal oldValue = 0;
        public Form1()
        {
            InitializeComponent();
            drivers.Add(new Driver("Hamilton", 36, true));
            drivers.Add(new Driver("Vettel", 37, true));
            drivers.Add(new Driver("Russel", 26, false));
            drivers.Add(new Driver("Raikonnen", 38, true));
            drivers.Add(new Driver("Bottas", 32, true));
            drivers.Add(new Driver("Vesrtappen", 27, true));
            drivers.Add(new Driver("Perez", 30, false));
            loadDrivers();

        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddDriver form = new AddDriver();
            if (form.ShowDialog() == DialogResult.OK)
            {
                drivers.Add(form.newDriver);
                lbDrivers.Items.Add(form.newDriver);
            }
        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Дали сте сигурен дека сакате да го избришете овој возач?", "Дали сте сигурни?", MessageBoxButtons.OKCancel);
            if (ds == DialogResult.OK)
            {
                lbDrivers.Items.Remove(lbDrivers.SelectedItem);
            }
        }

        private void loadDrivers()
        {
            drivers.ForEach(driver => { lbDrivers.Items.Add(driver); });
        }

        private void loadLaps()
        {
            lbLaps.Items.Clear();
            Driver selectedDriver = lbDrivers.SelectedItem as Driver;
            if (selectedDriver != null)
            {
                selectedDriver.laps.ForEach(lap => {
                    if (lap.minutes*60 + lap.seconds >= nudCheckTime.Value)
                    {
                        lbLaps.Items.Add(lap);
                    }
                });

            }
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            Driver selectedDriver = lbDrivers.SelectedItem as Driver;
            if (selectedDriver != null)
            {
                if (nudMinutes.Value > 0 || nudSeconds.Value > 0)
                {
                    selectedDriver.laps.Add(new Lap(nudMinutes.Value, nudSeconds.Value));
                    loadLaps();
                    displayFastestLap();
                }
            }
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLaps();
            displayFastestLap();
        }

        public void displayFastestLap()
        {
            Driver selectedDriver = lbDrivers.SelectedItem as Driver;
            if (selectedDriver != null)
            {
                if (selectedDriver.laps.Count != 0)
                {
                    Lap fastestLap = selectedDriver.laps[0] as Lap;
                    foreach (Lap item in selectedDriver.laps)
                    {
                        if (item.minutes < fastestLap.minutes)
                        {
                            fastestLap = item;
                        }
                        else if (item.seconds < fastestLap.seconds)
                        {
                            fastestLap = item;
                        }
                    }
                    tbBestLap.Text = fastestLap.ToString();
                }
            }


        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nudCheckTime_ValueChanged(object sender, EventArgs e)
        {
            loadLaps();
        }
    }
}
