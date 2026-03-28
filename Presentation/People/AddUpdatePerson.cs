using Business;
using DataAccess.Models;
using Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentation
{
   
    public partial class AddUpdatePerson : Form
    {
        private readonly PersonService _personService = new PersonService();
        private readonly CountryService _countryService = new CountryService();
        private string _selectedImagePath = ""; // Store the path at class level
        private Person _person; // To hold the data for the current person

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public enum enGender { Male = 0, Female = 1 };
        private int _PersonID = -1;
        public AddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public AddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
        }
        private void _FillCountriesInComoboBox()
        {
            // 1. Get the list of Country objects from your service
            List<Country> countries = _countryService.GetCountries();

            // 2. Bind the list to the ComboBox
            cbCountry.DataSource = countries;


            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "Id";
        }

        private void _ResetDefaultValues()
        {
            // 1. Fill Countries using your service layer
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _person = new Person(); // Initialize fresh EF Core model

                // Default UI values for Add Mode
                txtFirstName.Clear();
                txtSecondName.Clear();
                txtThirdName.Clear();
                txtLastName.Clear();
                txtNationalNo.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtAddress.Text = "";
                rbMale.Checked = true; // Default gender

                // Default Image based on gender
                picPerson.Image = Properties.Resources.Male_512;

                // Default country selection
                cbCountry.SelectedIndex = cbCountry.FindString("Jordan");
            }
            else
            {
                lblTitle.Text = "Update Person";
                // Data mapping happens later in _LoadData()
            }

            // 2. Set Date Constraints (Logic remains the same)
            BirthDate.MaxDate = DateTime.Now.AddYears(-18);
            BirthDate.Value = BirthDate.MaxDate;
            BirthDate.MinDate = DateTime.Now.AddYears(-100);

            // 3. Handle Image Link visibility
            // Since it's a new person, ImagePath is null/empty
            llRemoveImage.Visible = !string.IsNullOrEmpty(_person?.ImagePath);
        }

        private void _LoadData()
        {
            try
            {
                // 1. Fetch data through the Business Layer
                _person = _personService.GetPersonDetails(_PersonID);

                if (_person == null)
                {
                    MessageBox.Show($"No Person with ID = {_PersonID}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;
                }

                // 2. Map Person object to UI Controls
                lblPersonID.Text = _person.Id.ToString();
                txtFirstName.Text = _person.FirstName;
                txtSecondName.Text = _person.SecondName;
                txtThirdName.Text = _person.ThirdName;
                txtLastName.Text = _person.LastName;
                txtNationalNo.Text = _person.NationalNo;
                BirthDate.Value = _person.DateOfBirth;

                // Handle Gender (0 = Male, 1 = Female)
                if (_person.Gender == 0)
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;

                txtAddress.Text = _person.Address;
                txtPhone.Text = _person.Phone;
                txtEmail.Text = _person.Email;

                // Handle Image loading
                if (!string.IsNullOrEmpty(_person.ImagePath) && System.IO.File.Exists(_person.ImagePath))
                {
                    // Loading via stream prevents "file in use" locks
                    using (var stream = new System.IO.FileStream(_person.ImagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        picPerson.Image = Image.FromStream(stream);
                    }
                    llRemoveImage.Visible = true;
                }
                else
                {
                    picPerson.Image = null; // Or set a default placeholder image
                    llRemoveImage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                this.Close();
            }
        }

        private void AddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (picPerson.ImageLocation == null)
                picPerson.Image = Resources.Male_512;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {   
            if (picPerson.ImageLocation == null)
                picPerson.Image = Resources.Female_512;
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        { 
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string finalImagePath = _personService.ProcessPersonImage(_person.ImagePath, _selectedImagePath);
            try
            {
                // 1. Map the UI to the Object
                var newPerson = new Person
                {
                    FirstName = txtFirstName.Text,
                    SecondName = txtSecondName.Text,
                    ThirdName = txtThirdName.Text,
                    LastName = txtLastName.Text,
                    NationalNo = txtNationalNo.Text,
                    DateOfBirth = BirthDate.Value,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    NationalityCountryID = (int)cbCountry.SelectedValue,
                    ImagePath = _selectedImagePath,

                    // Use a ternary operator for the gender assignment
                    Gender = (short)(rbMale.Checked ? enGender.Male : enGender.Female)
                };

                // 2. Pass the object to the Business Layer
                _personService.AddPerson(newPerson);

                // 3. Refresh and Notify
                _LoadData();
                MessageBox.Show("Person saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
         

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // FIX: Assign the path to the class-level variable so btnSave can see it
                _selectedImagePath = openFileDialog1.FileName;

                // Show in UI
                picPerson.Image = Image.FromFile(_selectedImagePath);
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPerson.ImageLocation = null;
            llRemoveImage.Visible = false;
        }
    }
}
