using Business.Services;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentation
{
    public partial class Form1 : Form
    {
        enum enMode { add=1, update =2}
        enMode enMode1 = enMode.add;
        private readonly PersonService _personService = new PersonService();
        private string _selectedImagePath = ""; // Store the path at class level
        public Form1()
        {
            InitializeComponent();
            enMode1 = enMode.add;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = _personService.GetPeople();

            if (data != null)
            {
                dataGridView1.DataSource = data;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

       
            try
            {
                var newPerson = new Person
                {
                    FirstName = txtname.Text,
                    SecondName = txtAge.Text,
                    
                    ImagePath = _selectedImagePath
                };

                _personService.AddPerson(newPerson);
                LoadData();
                MessageBox.Show("Person added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filter to show only image files
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 1. Get the path
                    _selectedImagePath = openFileDialog.FileName;

                    // 2. Display it in the UI
                    pictureBox1.Image = Image.FromFile(_selectedImagePath);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // FIX: Assign the path to the class-level variable so btnSave can see it
                _selectedImagePath = openFileDialog1.FileName;

                // Show in UI
                pictureBox1.Image = Image.FromFile(_selectedImagePath);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if a row is actually selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 1. Get the Person object from the selected row
                var selectedPerson = dataGridView1.SelectedRows[0].DataBoundItem as Person;

                if (selectedPerson != null)
                {
                    // 2. Show the text data
                    txtname.Text = selectedPerson.FirstName;
                    txtAge.Text = selectedPerson.SecondName;

                    // 3. Handle the Image
                    if (!string.IsNullOrEmpty(selectedPerson.ImagePath) && System.IO.File.Exists(selectedPerson.ImagePath))
                    {
                        // Use a FileStream so the file isn't "locked" by the app
                        using (var stream = new System.IO.FileStream(selectedPerson.ImagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            pictureBox1.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null; // Clear if no image exists
                    }
                }

            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtname.Text;
                if (!int.TryParse(txtAge.Text, out int num))
                    throw new Exception("Age must be a valid number");

                // Use the variable that actually holds the path!

                var updatePerson = new Person
                {
                    FirstName = txtname.Text,
                    SecondName = txtAge.Text,

                    ImagePath = _selectedImagePath
                };
                _personService.UpdatePerson(updatePerson);

                LoadData();
                MessageBox.Show("Saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
 
