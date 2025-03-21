using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.Logging;

namespace Dog_Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbDogBreed.Items.AddRange(new string[] { "Labrador", "Great Dane", "German Shepherd", "Beagle", "Chihuahua", "Bulldog", "Poodle", "Corgi", "Rottweiler", "Dachshund", "Pomeranian", "Doberman", });
            lstDogs.DisplayMember = "FullInfo";
        }


        private void txtDogName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDogBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {

            Dog newDog = new Dog()
            {
                Name = txtDogName.Text,
                Breed = cmbDogBreed.SelectedItem.ToString()
            };

            lstDogs.Items.Add(newDog);

            txtDogName.Clear();
            cmbDogBreed.SelectedIndex = -1;

        }

        private void lstDogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (lstDogs.SelectedIndex != -1)
                lstDogs.Items.RemoveAt(lstDogs.SelectedIndex);
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (lstDogs.SelectedItem is Dog selectedDog)
            {
                string barkVolume = bark(selectedDog.Breed);
                MessageBox.Show($"{selectedDog.Name} is a {selectedDog.Breed}! Their bark will be {barkVolume}.");
            }
        }

        public string bark(string breed)
        {
            switch (breed)
            {
                case "Labrador":
                case "Great Dane":
                case "German Shepherd":
                case "Boxer":
                case "Rottweiler":
                case "Doberman":
                case "Siberian Husky":
                    return "very loud";

                case "Beagle":
                case "Dachshund":
                    return "medium";

                case "Chihuahua":
                case "Corgi":
                case "Pomeranian":
                    return "high-pitched but not loud";

                case "Bulldog":
                case "Poodle":
                    return "soft";

                default:
                    return "unknown";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class Dog
    {
        public string Name { get; set; }
        public string Breed{ get; set; }

        public string FullInfo
        {
            get { return Name + " - " + Breed; }
        }

    }
}
