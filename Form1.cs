using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI6_Halloween210063
{
	public partial class Form1 : Form
	{
        List<Sweets210063> sweets = new List<Sweets210063>();

        public Form1()
		{
			InitializeComponent();
		}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbxQuantity.Text) > 0)
            {
                Sweets210063 newSweet = new Sweets210063(cbxDoor.Checked, (cbxDoor.Checked ? Convert.ToInt32(tbxQuantity.Text) : -1), tbxDoor.Text);
                sweets.Add(newSweet);

                if (cbxDoor.Checked)
                {
                    lbxDoorSweets.Items.Add($"{newSweet.Door}: {newSweet.Quantity} ({newSweet.Classification()})");
                }
            }
            else
            {
                MessageBox.Show("Invalid value", "Error");
                return;
            }


        }

        private void btnBadNeighbors_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{sweets.Count(a => a.Opened == false)} neighbors didn't open the door");
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Gross: {sweets.Count(a => a.Opened == true && a.Classification() == "Gross")}\n" +
            (sweets.Count(a => a.Opened == true && a.Classification() == "Gross") > 0 ? ($"Average candy quantity: {sweets.FindAll(a => a.Opened == true && a.Classification() == "Gross").Average(a => a.Quantity)}\n") : $"Average candy quantity: 0\n") +
            $"Good: {sweets.Count(a => a.Opened == true && a.Classification() == "Good")}\n" +
            (sweets.Count(a => a.Opened == true && a.Classification() == "Good") > 0 ? ($"Average candy quantity: {sweets.FindAll(a => a.Opened == true && a.Classification() == "Good").Average(a => a.Quantity)}\n") : $"Average candy quantity: 0\n") +
            $"Great: {sweets.Count(a => a.Opened == true && a.Classification() == "Great")}\n" +
            (sweets.Count(a => a.Opened == true && a.Classification() == "Great") > 0 ? ($"Average candy quantity: {sweets.FindAll(a => a.Opened == true && a.Classification() == "Great").Average(a => a.Quantity)}") : $"Average candy quantity: 0")
            );
        }
    }
}
