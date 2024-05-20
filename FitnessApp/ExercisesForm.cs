using System;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class ExercisesForm : Form
    {
        public ExercisesForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMuscleGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstExercises.Items.Clear();
            switch (cmbMuscleGroups.SelectedItem.ToString())
            {
                case "Piept":
                    lstExercises.Items.Add("Împins la piept");
                    lstExercises.Items.Add("Fluturări cu gantere");
                    break;
                case "Spate":
                    lstExercises.Items.Add("Tracțiuni");
                    lstExercises.Items.Add("Ramat cu gantera");
                    break;
                case "Umeri":
                    lstExercises.Items.Add("Presă militară");
                    lstExercises.Items.Add("Ridicări laterale");
                    break;
                case "Brațe":
                    lstExercises.Items.Add("Flexii biceps");
                    lstExercises.Items.Add("Extensii triceps");
                    break;
                case "Picioare":
                    lstExercises.Items.Add("Genuflexiuni");
                    lstExercises.Items.Add("Îndreptări");
                    break;
                case "Abdomen":
                    lstExercises.Items.Add("Abdomene");
                    lstExercises.Items.Add("Plank");
                    break;
            }
        }
    }
}
