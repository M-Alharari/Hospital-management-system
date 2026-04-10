using Business.Services;
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

namespace Presentation.People
{
    public partial class ctrlPersonCard : UserControl
    {
        private PersonService _service = new PersonService();
        private readonly CountryService _countryService = new CountryService();
        public Person SelectedPersonInfo { get; private set; }

        public int PersonID => SelectedPersonInfo?.Id ?? -1;

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            SelectedPersonInfo = _service.GetPersonDetails(PersonID);
            if (SelectedPersonInfo == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            SelectedPersonInfo = _service.GetPersonDetails(NationalNo);
            if (SelectedPersonInfo == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        private void _LoadPersonImage()
        {
            if (SelectedPersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = SelectedPersonInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;

            lblPersonID.Text = SelectedPersonInfo.Id.ToString();
            lblNationalNo.Text = SelectedPersonInfo.NationalNo;
            lblFullName.Text = SelectedPersonInfo.FullName;
            lblGender.Text = SelectedPersonInfo.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = SelectedPersonInfo.Email;
            lblPhone.Text = SelectedPersonInfo.Phone;
            lblBirthDate.Text = SelectedPersonInfo.DateOfBirth.ToShortDateString();
            var country = _countryService.GetCountryByID(
     SelectedPersonInfo.NationalityCountryID);
            lblCountry.Text = country.CountryName;
            lblAddress.Text = SelectedPersonInfo.Address;
            _LoadPersonImage();




        }

        public void ResetPersonInfo()
        {

            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";


        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdatePerson frm = new AddUpdatePerson(PersonID);
            frm.ShowDialog();

            //refresh
            LoadPersonInfo(PersonID);
        }
    }
}
