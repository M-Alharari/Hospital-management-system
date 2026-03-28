using Business;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PeopleList : Form
    {
        enum enMode { add = 1, update = 2 }
        enMode enMode1 = enMode.add;
        private static readonly PersonService _personService = new PersonService();
        private List<Person> _allPeople;
        public PeopleList()
        {
            InitializeComponent();
        }

        private void PeopleList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // 1. Get List from Business Layer
            _allPeople = _personService.GetPeople();

            if (_allPeople != null)
            {
                // 2. Bind directly to the DataGrid
                dgPeople.DataSource = _allPeople;

                // 3. Hide columns you don't want to show (like ImagePath or IDs)
                //if (dgPeople.Columns["ImagePath"] != null)
                //    dgPeople.Columns["ImagePath"].Visible = false;

                lblRecord.Text = _allPeople.Count.ToString();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdatePerson frmAddNewPerson = new AddUpdatePerson();
            frmAddNewPerson.ShowDialog();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdatePerson frmAddNewPerson = new AddUpdatePerson((int)dgPeople.CurrentRow.Cells[0].Value);
            frmAddNewPerson.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdatePerson frmAddNewPerson = new AddUpdatePerson();
            frmAddNewPerson.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
