namespace GUI
{
    partial class FarmForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCowCount;
        private System.Windows.Forms.Label lblSheepCount;
        private System.Windows.Forms.Label lblGoatCount;
        private System.Windows.Forms.TextBox txtCowCount;
        private System.Windows.Forms.TextBox txtSheepCount;
        private System.Windows.Forms.TextBox txtGoatCount;
        private System.Windows.Forms.Button btnAddAnimals;
        private System.Windows.Forms.Button btnMakeSounds;
        private System.Windows.Forms.Button btnGetStatistics;
        private System.Windows.Forms.Button btnClearAnimals;
        private System.Windows.Forms.ErrorProvider errorProvider;

        private void InitializeComponent()
        {
            this.lblCowCount = new System.Windows.Forms.Label();
            this.lblSheepCount = new System.Windows.Forms.Label();
            this.lblGoatCount = new System.Windows.Forms.Label();
            this.txtCowCount = new System.Windows.Forms.TextBox();
            this.txtSheepCount = new System.Windows.Forms.TextBox();
            this.txtGoatCount = new System.Windows.Forms.TextBox();
            this.btnAddAnimals = new System.Windows.Forms.Button();
            this.btnMakeSounds = new System.Windows.Forms.Button();
            this.btnGetStatistics = new System.Windows.Forms.Button();
            this.btnClearAnimals = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();

            // 
            // lblCowCount
            // 
            this.lblCowCount.Text = "Cow:";
            this.lblCowCount.Location = new System.Drawing.Point(20, 20);

            // 
            // lblSheepCount
            // 
            this.lblSheepCount.Text = "Sheep:";
            this.lblSheepCount.Location = new System.Drawing.Point(20, 60);

            // 
            // lblGoatCount
            // 
            this.lblGoatCount.Text = "Goat:";
            this.lblGoatCount.Location = new System.Drawing.Point(20, 100);

            // 
            // txtCowCount
            // 
            this.txtCowCount.Location = new System.Drawing.Point(120, 20);

            // 
            // txtSheepCount
            // 
            this.txtSheepCount.Location = new System.Drawing.Point(120, 60);

            // 
            // txtGoatCount
            // 
            this.txtGoatCount.Location = new System.Drawing.Point(120, 100);

            // 
            // btnAddAnimals
            // 
            this.btnAddAnimals.Text = "Add Animals";
            this.btnAddAnimals.Location = new System.Drawing.Point(20, 150);
            this.btnAddAnimals.Size = new System.Drawing.Size(120, 30);
            this.btnAddAnimals.Click += new System.EventHandler(this.btnAddAnimals_Click);

            // 
            // btnMakeSounds
            // 
            this.btnMakeSounds.Text = "Make Sounds";
            this.btnMakeSounds.Location = new System.Drawing.Point(150, 150);
            this.btnMakeSounds.Size = new System.Drawing.Size(120, 30);
            this.btnMakeSounds.Click += new System.EventHandler(this.btnMakeSounds_Click);

            // 
            // btnGetStatistics
            // 
            this.btnGetStatistics.Text = "Get Statistics";
            this.btnGetStatistics.Location = new System.Drawing.Point(280, 150);
            this.btnGetStatistics.Size = new System.Drawing.Size(120, 30);
            this.btnGetStatistics.Click += new System.EventHandler(this.btnGetStatistics_Click);

            // 
            // btnClearAnimals
            // 
            this.btnClearAnimals.Text = "Clear Animals";
            this.btnClearAnimals.Location = new System.Drawing.Point(410, 150);
            this.btnClearAnimals.Size = new System.Drawing.Size(120, 30);
            this.btnClearAnimals.Click += new System.EventHandler(this.btnClearAnimals_Click);

            // 
            // FarmForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblCowCount);
            this.Controls.Add(this.txtCowCount);
            this.Controls.Add(this.lblSheepCount);
            this.Controls.Add(this.txtSheepCount);
            this.Controls.Add(this.lblGoatCount);
            this.Controls.Add(this.txtGoatCount);
            this.Controls.Add(this.btnAddAnimals);
            this.Controls.Add(this.btnMakeSounds);
            this.Controls.Add(this.btnGetStatistics);
            this.Controls.Add(this.btnClearAnimals);
            this.Text = "Farm";
        }
    }
}
