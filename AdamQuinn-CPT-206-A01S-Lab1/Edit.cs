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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void populationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.populationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.Population' table. You can move, or remove it, as needed.
            this.populationTableAdapter.Fill(this.populationDataSet.Population);

        }

        private void btnExit_Click(object sender, EventArgs e)// closes the edit form
        {
            
            this.Close();
        }
    }
}
