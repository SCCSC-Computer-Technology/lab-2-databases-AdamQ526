using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamQuinn_CPT_206_A01S_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void populationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.populationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.Population' table. You can move, or remove it, as needed.
            this.populationTableAdapter.Fill(this.populationDataSet.Population);

        }

        private void btnExit_Click(object sender, EventArgs e) 
            //Closes the program
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
            // opens the edit form
        {
            Edit edit = new Edit();
            edit.ShowDialog();
            this.populationTableAdapter.Fill(this.populationDataSet.Population);
        }

        private void btnAvgPop_Click(object sender, EventArgs e)
            //displays the avg population 
        {
            int avgPop = 0;
            avgPop = (int)this.populationTableAdapter.AvgPop();
            MessageBox.Show($"The average population of all the cities is: {avgPop}");
        }

        private void btnTotalPop_Click(object sender, EventArgs e)
            //displays the total population
        {
            int totalPop = 0;
            totalPop = (int)this.populationTableAdapter.TotalPop();
            MessageBox.Show($"The total population of all the cities is: {totalPop}");
        }

        private void btnMaxPop_Click(object sender, EventArgs e)
            //displays the maximum population 
        {
            int maxPop = 0;
            maxPop = (int)this.populationTableAdapter.MaxPop();
            MessageBox.Show($"The Maximum population of all the cities is: {maxPop}");
        }

        private void btnMinPop_Click(object sender, EventArgs e)
            //displays the minimum population 
        {
            int minPop = 0;
            minPop = (int)this.populationTableAdapter.MinPop();
            MessageBox.Show($"The minimum population of all the cities is: {minPop}");
        }

        private void btnOderByPopAesc_Click(object sender, EventArgs e)
            //orders the table by population in aescending order
        {
            this.populationTableAdapter.FillByPopAsc(this.populationDataSet.Population);
        }

        private void btnOrderByCity_Click(object sender, EventArgs e)
            // orders the table alphabetically by city 
        {
            this.populationTableAdapter.FillByCity(this.populationDataSet.Population);
        }

        private void btnOrderByPopDesc_Click(object sender, EventArgs e)
            //orders teh table by the population in descending order
        {
            this.populationTableAdapter.FillByPopDesc(this.populationDataSet.Population);
        }

        private void btnOrderByDefault_Click(object sender, EventArgs e)
            //orders the table by the city ID
        {
            this.populationTableAdapter.Fill(this.populationDataSet.Population);
        }
    }
    
}
