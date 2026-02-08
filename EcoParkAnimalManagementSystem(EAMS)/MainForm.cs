using EcoParkAnimalManagementSystem_EAMS_.AnimalGen;
using EcoParkAnimalManagementSystem_EAMS_.Mammals;
using EcoParkAnimalManagementSystem_EAMS_.Reptiles;
using EcoParkAnimalManagementSystem_EAMS_.Utilities;

namespace EcoParkAnimalManagementSystem_EAMS_
{
   
    // Main form for the EcoPark Animal Management System.
    public partial class MainForm : Form
    {
        private Animal animal = null;
        private string selectedImagePath = string.Empty;


        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

       
        // Initializes all GUI components.
        private void InitializeGUI()
        {
            // Populate category list
            lstCategory.Items.Clear();
            foreach (CategoryType category in Enum.GetValues(typeof(CategoryType)))
            {
                lstCategory.Items.Add(category);
            }

            // Populate gender combobox 
            cmbGender.Items.Clear();
            foreach (GenderType gender in Enum.GetValues(typeof(GenderType)))
            {
                cmbGender.Items.Add(gender);
            }
            cmbGender.SelectedIndex = 0;

            // Clear inputs and output
            ClearInputFields();
            lblAnimalInfo.Text = string.Empty;
            picAnimal.Image = null;
        }

    
        // Clears all input fields
        private void ClearInputFields()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtWeight.Text = string.Empty;
            cmbGender.SelectedIndex = 0;
            selectedImagePath = string.Empty;
        }


        // Category and Species Selection
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Validate selection before use
            int index = lstCategory.SelectedIndex;
            if (index < 0)
                return;

            if (chkListAllSpecies.Checked)
                return;

            CategoryType selectedCategory = (CategoryType)lstCategory.SelectedItem;
            PopulateSpeciesList(selectedCategory);
        }


        // Populates species list based on selected category.
        private void PopulateSpeciesList(CategoryType category)
        {
            lstSpecies.Items.Clear();

            switch (category)
            {
                case CategoryType.Mammal:
                    foreach (MammalSpecies species in Enum.GetValues(typeof(MammalSpecies)))
                    {
                        lstSpecies.Items.Add(species);
                    }
                    break;

                case CategoryType.Reptile:
                    foreach (ReptileSpecies species in Enum.GetValues(typeof(ReptileSpecies)))
                    {
                        lstSpecies.Items.Add(species);
                    }
                    break;

                default:
                    lstSpecies.Items.Add("(Not implemented)");
                    break;
            }
        }

        private void lstSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

            // highlights category when species selected
            if (chkListAllSpecies.Checked)
            {
                HighlightCategoryForSelectedSpecies();
            }
        }

     
        // Highlights category for selected species.
        private void HighlightCategoryForSelectedSpecies()
        {
            int index = lstSpecies.SelectedIndex;
            if (index < 0)
                return;

            object selectedItem = lstSpecies.SelectedItem;

            if (selectedItem is MammalSpecies)
            {
                lstCategory.SelectedItem = CategoryType.Mammal;
            }
            else if (selectedItem is ReptileSpecies)
            {
                lstCategory.SelectedItem = CategoryType.Reptile;
            }
        }

        private void chkListAllSpecies_CheckedChanged(object sender, EventArgs e)
        {
            if (chkListAllSpecies.Checked)
            {
                lstCategory.Enabled = false;
                PopulateAllSpecies();
            }
            else
            {
                lstCategory.Enabled = true;
                lstSpecies.Items.Clear();

                if (lstCategory.SelectedIndex >= 0)
                {
                    PopulateSpeciesList((CategoryType)lstCategory.SelectedItem);
                }
            }
        }


        // Populates all species from all categories.
        private void PopulateAllSpecies()
        {
            lstSpecies.Items.Clear();

            foreach (MammalSpecies species in Enum.GetValues(typeof(MammalSpecies)))
            {
                lstSpecies.Items.Add(species);
            }

            foreach (ReptileSpecies species in Enum.GetValues(typeof(ReptileSpecies)))
            {
                lstSpecies.Items.Add(species);
            }
        }

        // Create Animal Button

        private void btnCreateAnimal_Click(object sender, EventArgs e)
        {
            //  Validates selection
            if (lstSpecies.SelectedIndex < 0)
            {
                MessageBox.Show("Kindly select a species first.",
                    "Selection is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            object selectedSpecies = lstSpecies.SelectedItem;

            if (selectedSpecies is MammalSpecies)
            {
                OpenMammalView((MammalSpecies)selectedSpecies);
            }
            else if (selectedSpecies is ReptileSpecies)
            {
                OpenReptileView((ReptileSpecies)selectedSpecies);
            }
            else
            {
                MessageBox.Show("This category has not yet been implemented.",
                    "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenMammalView(MammalSpecies species)
        {
            MammalView mammalView = new MammalView((int)species);

            if (mammalView.ShowDialog() == DialogResult.OK)
            {
                //  receiving animal from form
                animal = mammalView.Animal;
            }
        }

        private void OpenReptileView(ReptileSpecies species)
        {
            ReptileView reptileView = new ReptileView((int)species);

            if (reptileView.ShowDialog() == DialogResult.OK)
            {
                //  Dynamic binding - receiving animal from form
                animal = reptileView.Animal;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (animal == null)
            {
                MessageBox.Show("Please create an animal first by clicking the 'Create Animal Button'.",
                    "No Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ReadGeneralAnimalData())
                return;

            UpdateGUI();
        }

        /// <summary>
        /// Reads general animal data from GUI.
        ///  Works with any animal type.
        /// </summary>
        private bool ReadGeneralAnimalData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            (double age, bool okAge) = NumericUtility.GetDouble(txtAge.Text);
            if (!okAge || age < 0)
            {
                MessageBox.Show("Please enter a valid age.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }

            (double weight, bool okWeight) = NumericUtility.GetDouble(txtWeight.Text);
            if (!okWeight || weight < 0)
            {
                MessageBox.Show("Please enter a valid weight.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return false;
            }

            // works for any species
            animal.Name = txtName.Text;
            animal.Age = age;
            animal.Weight = weight;
            animal.Gender = (GenderType)cmbGender.SelectedItem;
            animal.ImagePath = selectedImagePath;

            return true;
        }


        /// Updates the display
        private void UpdateGUI()
        {
            if (animal == null)
            {
                lblAnimalInfo.Text = string.Empty;
                return;
            }

        
            lblAnimalInfo.Text = animal.ToString();

            if (!string.IsNullOrEmpty(animal.ImagePath))
            {
                try
                {
                    picAnimal.Image = Image.FromFile(animal.ImagePath);
                }
                catch
                {
                    picAnimal.Image = null;
                }
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Animal Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;

                    try
                    {
                        picAnimal.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}",
                            "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedImagePath = string.Empty;
                    }
                }
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EcoPark Animal Management System\nVersion 1.0\n\n By: Richmond Boakye",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
