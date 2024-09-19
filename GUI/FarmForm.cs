using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FarmForm : Form
    {
        private Farm farm;

        public FarmForm()
        {
            InitializeComponent();
            farm = new Farm();
            errorProvider = new ErrorProvider();
        }

        // add animals to the farm
        private void btnAddAnimals_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider.Clear(); // Clear all previous errors

            // validate cow count
            bool isCowCountValid = int.TryParse(txtCowCount.Text, out int cowCount);
            if (!isCowCountValid || cowCount < 0)
            {
                errorProvider.SetError(txtCowCount, "Please enter a valid number for cows.");
                isValid = false;
            }

            // validate sheep count
            bool isSheepCountValid = int.TryParse(txtSheepCount.Text, out int sheepCount);
            if (!isSheepCountValid || sheepCount < 0)
            {
                errorProvider.SetError(txtSheepCount, "Please enter a valid number for sheep.");
                isValid = false;
            }

            // validate goat count
            bool isGoatCountValid = int.TryParse(txtGoatCount.Text, out int goatCount);
            if (!isGoatCountValid || goatCount < 0)
            {
                errorProvider.SetError(txtGoatCount, "Please enter a valid number for goats.");
                isValid = false;
            }

            // if validation fails, return
            if (!isValid) return;

            // add valid animals to the farm
            if (cowCount > 0) farm.AddAnimal(new Cow(), cowCount);
            if (sheepCount > 0) farm.AddAnimal(new Sheep(), sheepCount);
            if (goatCount > 0) farm.AddAnimal(new Goat(), goatCount);

            // clear the input fields and refocus
            ClearFields();

            MessageBox.Show("Animals have been added to the farm!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ClearFields()
        {
            txtCowCount.Clear();
            txtSheepCount.Clear();
            txtGoatCount.Clear();
            txtCowCount.Focus(); // Focus back on the first input field
        }

        // Button to make animals produce sounds
        private void btnMakeSounds_Click(object sender, EventArgs e)
        {
            if (farm.Animals.Count == 0)
            {
                MessageBox.Show("There are no animals on the farm.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                string sounds = farm.GetAllAnimalSounds();
                MessageBox.Show(sounds);
            }
        }

        // Button to get farm statistics
        private void btnGetStatistics_Click(object sender, EventArgs e)
        {
            if (farm.Animals.Count == 0)
            {
                MessageBox.Show("There are no animals on the farm.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int totalMilk = 0;
            int totalOffspring = 0;
            int totalCows = 0, totalSheep = 0, totalGoats = 0;
            int cowsBorn = 0, sheepBorn = 0, goatsBorn = 0;

            foreach (var animal in farm.Animals)
            {
                totalMilk += animal.ProduceMilk();
                totalOffspring += animal.GiveBirth();

                if (animal is Cow)
                {
                    totalCows += animal.Count;
                    cowsBorn += animal.GiveBirth();
                }
                else if (animal is Sheep)
                {
                    totalSheep += animal.Count;
                    sheepBorn += animal.GiveBirth();
                }
                else if (animal is Goat)
                {
                    totalGoats += animal.Count;
                    goatsBorn += animal.GiveBirth();
                }
            }

            MessageBox.Show($"Current animal count:\n" +
                            $"Cows: {totalCows}\n" +
                            $"Sheep: {totalSheep}\n" +
                            $"Goats: {totalGoats}\n\n" +
                            $"Offspring born:\n" +
                            $"Cows: {cowsBorn}\n" +
                            $"Sheep: {sheepBorn}\n" +
                            $"Goats: {goatsBorn}\n\n" +
                            $"Milk produced: {totalMilk} liters", "Farm Statistics", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Clear all animals from the farm
        private void btnClearAnimals_Click(object sender, EventArgs e)
        {
            farm.Animals.Clear();
            MessageBox.Show("All animals have been removed from the farm.", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}