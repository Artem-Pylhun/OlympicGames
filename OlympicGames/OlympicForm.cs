using OlympicGames.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympicGames
{
    public partial class OlympicForm : Form
    {
        Form1 baseform;
        List<City> cities;
        List<CountryParticipant> countryParticipants;
        Olympic olympic;
        public List<CountryParticipant> participants;
        public OlympicForm(Form1 form)
        {
            InitializeComponent();
            baseform = form;
            olympic = new Olympic();
            cities = new List<City>();
            countryParticipants = new List<CountryParticipant>();
            btnSaveOlympicChanges.Enabled = false;
            btnAddAthlete.Enabled = false;
            btnDelAthlete.Enabled = false;
            btnEditAthlete.Enabled = false;
        }
        public OlympicForm(Form1 form, Olympic olympic)
        {
            InitializeComponent();
            baseform = form;
            this.olympic = olympic;

        }

        private void btnParticipant(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Tag.ToString())
            {
                case "add":
                    {
                        break;
                    }
                case "del":
                    {
                        break;
                    }
                case "edit":
                    {
                        break;
                    }
            }

        }

        private void btnCreateOlympic_Click(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OlympicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            baseform.Enabled = true;
            baseform.Show();
            //baseform.UpdateListBox();
        }

        private void btnCity(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Tag.ToString())
            {
                case "add":
                    {
                        break;
                    }
                case "del":
                    {
                        break;
                    }
                case "edit":
                    {
                        break;
                    }
            }
        }

        private void btnAddParticipantToList_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveParticipantFromList_Click(object sender, EventArgs e)
        {

        }

        private void btnAthlete(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Tag.ToString())
            {
                case "add":
                    {
                        if(lbParticipants.SelectedIndex != -1)
                        {
                            int selectedIndex = lbParticipants.SelectedIndex;
                            CountryParticipant selectedCountryParticipant = participants[selectedIndex];
                            btnAddAthlete.Enabled = true;
                            if (tbFullName.Text != string.Empty)
                            {
                                Athlete athlete = new Athlete();
                                athlete.FullName = tbFullName.Text;
                                athlete.Age = (int)nudAge.Value;
                                athlete.IsMale = cbIsMale.Checked;
                                selectedCountryParticipant.Athletes.Add(athlete);
                                UpdateListBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Fill in all info about Athlete", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
                case "del":
                    {
                        break;
                    }
                case "edit":
                    {
                        break;
                    }
            }
        }
        private void UpdateListBoxes()
        {
            lbAthletes.Items.Clear();
            lbAthletes1.Items.Clear();
            if (lbParticipants.SelectedIndex != -1)
            {
                int selectedIndex = lbParticipants.SelectedIndex;
                CountryParticipant selectedParticipant = countryParticipants[selectedIndex];
                foreach(var at in selectedParticipant.Athletes)
                {
                    lbAthletes.Items.Add(at);
                    lbAthletes1.Items.Add(at);
                }
            }
            lbCities.Items.Clear();
            foreach(var c in cities)
            {
                lbCities.Items.Add(c);
            }
            lbCountryParticipants.Items.Clear();
            lbParticipants.Items.Clear();
            if(participants != null)
            {
                foreach(var participant in participants)
                {
                    lbCountryParticipants.Items.Add(participant);
                    lbParticipants.Items.Add(participant);

                }
            }

        }

    }
}
