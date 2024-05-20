using System;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class CaloriesForm : Form
    {
        public CaloriesForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string food = txtFood.Text;
            if (string.IsNullOrWhiteSpace(food))
            {
                MessageBox.Show("Introdu o mâncare.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Introdu o cantitate validă.");
                return;
            }

            lstFoods.Items.Add($"{food} - {quantity}g");

            txtFood.Clear();
            txtQuantity.Clear();
            txtFood.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int totalCalories = 0;

            foreach (var item in lstFoods.Items)
            {
                // Aici poți adăuga logica pentru a calcula caloriile bazându-te pe numele mâncării și cantitate.
                // De exemplu: totalCalories += GetCalories(food, quantity);
            }

            lblTotalCalories.Text = $"Total Calorii: {totalCalories}";
        }
    }
}
