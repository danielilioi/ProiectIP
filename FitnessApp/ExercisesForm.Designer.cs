namespace FitnessApp
{
    partial class ExercisesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbMuscleGroups = new System.Windows.Forms.ComboBox();
            this.lblMuscleGroup = new System.Windows.Forms.Label();
            this.lstExercises = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(100, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbMuscleGroups
            // 
            this.cmbMuscleGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuscleGroups.FormattingEnabled = true;
            this.cmbMuscleGroups.Items.AddRange(new object[] {
            "Piept",
            "Spate",
            "Umeri",
            "Brațe",
            "Picioare",
            "Abdomen"});
            this.cmbMuscleGroups.Location = new System.Drawing.Point(100, 10);
            this.cmbMuscleGroups.Name = "cmbMuscleGroups";
            this.cmbMuscleGroups.Size = new System.Drawing.Size(172, 21);
            this.cmbMuscleGroups.TabIndex = 1;
            this.cmbMuscleGroups.SelectedIndexChanged += new System.EventHandler(this.cmbMuscleGroups_SelectedIndexChanged);
            // 
            // lblMuscleGroup
            // 
            this.lblMuscleGroup.AutoSize = true;
            this.lblMuscleGroup.Location = new System.Drawing.Point(12, 13);
            this.lblMuscleGroup.Name = "lblMuscleGroup";
            this.lblMuscleGroup.Size = new System.Drawing.Size(82, 13);
            this.lblMuscleGroup.TabIndex = 2;
            this.lblMuscleGroup.Text = "Grupă Musculară:";
            // 
            // lstExercises
            // 
            this.lstExercises.FormattingEnabled = true;
            this.lstExercises.Location = new System.Drawing.Point(100, 40);
            this.lstExercises.Name = "lstExercises";
            this.lstExercises.Size = new System.Drawing.Size(172, 95);
            this.lstExercises.TabIndex = 3;
            // 
            // ExercisesForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.lstExercises);
            this.Controls.Add(this.lblMuscleGroup);
            this.Controls.Add(this.cmbMuscleGroups);
            this.Controls.Add(this.btnClose);
            this.Name = "ExercisesForm";
            this.Text = "Exerciții";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbMuscleGroups;
        private System.Windows.Forms.Label lblMuscleGroup;
        private System.Windows.Forms.ListBox lstExercises;
    }
}
