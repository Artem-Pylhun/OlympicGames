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
        Olympic olympic;
        List<CountryParticipant> participants;
        public OlympicForm(Form1 form)
        {
            InitializeComponent();
            baseform = form;
            olympic = new Olympic();
            cities = new List<City>();
            participants = new List<CountryParticipant>();
            btnSaveOlympicChanges.Enabled = false;

            btnAddAthlete.Enabled = false;
            btnDelAthlete.Enabled = false;
            btnEditAthlete.Enabled = false;

            btnEditParticipant.Enabled = false;
            btnDelParticipant.Enabled = false;

            btnAddParticipantToList.Enabled = false;
            btnRemoveParticipantFromList.Enabled = false;
        }
        public OlympicForm(Form1 form, Olympic olympic)
        {
            InitializeComponent();
            baseform = form;
            this.olympic = olympic;
            UpdateListBoxes();
        }

        private void btnParticipant(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Tag.ToString())
            {
                case "add":
                    {
                        if (tbParticipantTitle.Text != string.Empty
                            && nudWins.Value != 0
                            && nudLosses.Value != 0)
                        {
                            CountryParticipant participant = new CountryParticipant()
                            {
                                Title = tbParticipantTitle.Text,
                                Wins = (int)nudWins.Value,
                                Losses = (int)nudLosses.Value
                            };
                            participants.Add(participant);
                            UpdateListBoxes();
                        }
                        break;
                    }
                case "del":
                    {
                        if (lbParticipants.SelectedIndex != -1)
                        {
                            int selectedIndex = lbParticipants.SelectedIndex;
                            CountryParticipant selectedParticipant = participants[selectedIndex];
                            participants.Remove(selectedParticipant);
                            UpdateListBoxes();
                        }
                        break;
                    }
                case "edit":
                    {
                        if (lbParticipants.SelectedIndex != -1)
                        {

                            int selectedIndex = lbParticipants.SelectedIndex;
                            CountryParticipant selectedParticipant = participants[selectedIndex];
                            selectedParticipant.Title = tbParticipantTitle.Text;
                            selectedParticipant.Wins = (int)nudWins.Value;
                            selectedParticipant.Losses = (int)nudLosses.Value;
                            UpdateListBoxes();
                        }
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
            if (cbCountryParticipants.SelectedIndex != -1)
            {
                CountryParticipant countryParticipant = participants[cbCountryParticipants.SelectedIndex];
                olympic.participants.Add(countryParticipant);
                UpdateListBoxes();
            }
        }

        private void btnRemoveParticipantFromList_Click(object sender, EventArgs e)
        {
            if (lbCountryParticipants.SelectedIndex != -1)
            {
                CountryParticipant countryParticipant = participants[lbCountryParticipants.SelectedIndex];
                olympic.participants.Remove(countryParticipant);
                UpdateListBoxes();
            }
        }

        private void btnAthlete(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Tag.ToString())
            {
                case "add":
                    {
                        if (lbParticipants.SelectedIndex != -1)
                        {
                            int selectedIndex = lbParticipants.SelectedIndex;
                            CountryParticipant selectedCountryParticipant = participants[selectedIndex];
                            if (tbFullName.Text != string.Empty)
                            {
                                Athlete athlete = new Athlete()
                                {
                                    FullName = tbFullName.Text,
                                    Age = (int)nudAge.Value,
                                    IsMale = cbIsMale.Checked
                                };
                                selectedCountryParticipant.Athletes.Add(athlete);
                                lbAthletes1.Items.Clear();
                                lbAthletes.Items.Clear();
                                foreach (var at in selectedCountryParticipant.Athletes)
                                {
                                    lbAthletes.Items.Add(at);
                                    lbAthletes1.Items.Add(at);
                                }
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
                        if (lbParticipants.SelectedIndex != -1)
                        {
                            int selectedIndex = lbParticipants.SelectedIndex;
                            CountryParticipant selectedCountryParticipant = participants[selectedIndex];
                            if (lbAthletes.SelectedIndex != -1)
                            {
                                Athlete athlete = selectedCountryParticipant.Athletes[lbAthletes.SelectedIndex];
                                selectedCountryParticipant.Athletes.Remove(athlete);
                                lbAthletes1.Items.Clear();
                                lbAthletes.Items.Clear();
                                foreach (var at in selectedCountryParticipant.Athletes)
                                {
                                    lbAthletes.Items.Add(at);
                                    lbAthletes1.Items.Add(at);
                                }
                            }
                            tbParticipantTitle.Text = string.Empty;
                            nudWins.Value = 0;
                            nudLosses.Value = 0;
                        }
                        break;
                    }
                case "edit":
                    {
                        if (lbParticipants.SelectedIndex != -1)
                        {
                            int selectedIndex = lbParticipants.SelectedIndex;
                            CountryParticipant selectedCountryParticipant = participants[selectedIndex];
                            if (lbAthletes.SelectedIndex != -1)
                            {
                                Athlete athlete = selectedCountryParticipant.Athletes[lbAthletes.SelectedIndex];
                                athlete.FullName = tbFullName.Text;
                                athlete.Age = (int)nudAge.Value;
                                athlete.IsMale = cbIsMale.Checked;
                                lbAthletes1.Items.Clear();
                                lbAthletes.Items.Clear();
                                foreach (var at in selectedCountryParticipant.Athletes)
                                {
                                    lbAthletes.Items.Add(at);
                                    lbAthletes1.Items.Add(at);
                                }

                            }
                        }
                        break;
                    }
            }
        }
        private void UpdateListBoxes()
        {
            lbAthletes.Items.Clear();
            lbAthletes1.Items.Clear();

            lbCities.Items.Clear();
            cbCityHost.Items.Clear();
            cbCountryParticipants.Items.Clear();
            if (cities.Count != 0)
            {
                foreach (var c in cities)
                {
                    lbCities.Items.Add(c);
                }
            }
            lbParticipants.Items.Clear();
            if (participants != null)
            {
                foreach (var participant in participants)
                {
                    lbParticipants.Items.Add(participant);
                    cbCountryParticipants.Items.Add(participant.Title);
                }
            }
            lbCountryParticipants.Items.Clear();
            if (olympic.participants.Count != 0)
            {
                foreach (var participant in olympic.participants)
                {
                    lbCountryParticipants.Items.Add(participant);

                }
            }


        }

        private void lbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddAthlete.Enabled = true;
            if (lbParticipants.SelectedIndex != -1)
            {
                btnDelParticipant.Enabled = true;
                btnEditParticipant.Enabled = true;
                lbAthletes.Items.Clear();
                lbAthletes1.Items.Clear();
                CountryParticipant currentParticipant = participants[lbParticipants.SelectedIndex];
                tbParticipantTitle.Text = currentParticipant.Title;
                nudWins.Value = currentParticipant.Wins;
                nudLosses.Value = currentParticipant.Losses;
                foreach (var at in currentParticipant.Athletes)
                {
                    lbAthletes.Items.Add(at);
                    lbAthletes1.Items.Add(at);
                }
            }
        }

        private void lbAthletes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelAthlete.Enabled = true;
            btnEditAthlete.Enabled = true;
        }

        private void cbCountryParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountryParticipants.SelectedIndex != -1)
            {
                btnAddParticipantToList.Enabled = true;
                btnRemoveParticipantFromList.Enabled = true;
            }
        }
    }
}
