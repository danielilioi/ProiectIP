using System;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class WorkoutForm : Form
    {
        public WorkoutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
