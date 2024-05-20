using System;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class MainForm : Form
    {
        private bool isLoggedIn = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            UpdateLoginState();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            WorkoutForm workoutForm = new WorkoutForm();
            workoutForm.ShowDialog();
        }

        private void btnExercises_Click(object sender, EventArgs e)
        {
            ExercisesForm exercisesForm = new ExercisesForm();
            exercisesForm.ShowDialog();
        }

        private void btnCalories_Click(object sender, EventArgs e)
        {
            CaloriesForm caloriesForm = new CaloriesForm();
            caloriesForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                // Logout
                isLoggedIn = false;
                MessageBox.Show("Delogat cu succes!");
            }
            else
            {
                // Login
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    isLoggedIn = true;
                    MessageBox.Show("Logat cu succes!");
                }
            }
            UpdateLoginState();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FitnessApp v1.0\nDeveloped by YourName");
        }

        private void UpdateLoginState()
        {
            btnLogin.Text = isLoggedIn ? "Delogare" : "Logare";
            btnWorkout.Enabled = isLoggedIn;
            btnExercises.Enabled = isLoggedIn;
            btnCalories.Enabled = isLoggedIn;
        }
    }
}
