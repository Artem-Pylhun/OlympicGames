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
        EventType eventType;
        public OlympicForm(Form1 form)
        {
            InitializeComponent();
            baseform = form;
            olympic = new Olympic();
            cities = new List<City>();
            participants = new List<CountryParticipant>();
            btnSaveOlympicChanges.Enabled = false;
            nudYear.Minimum = DateTime.Now.Year;
            btnAddAthlete.Enabled = false;
            btnDelAthlete.Enabled = false;
            btnEditAthlete.Enabled = false;

            btnEditParticipant.Enabled = false;
            btnDelParticipant.Enabled = false;

            btnAddParticipantToList.Enabled = false;
            btnRemoveParticipantFromList.Enabled = false;

            btnDelCity.Enabled = false;
            btnEditCity.Enabled = false;

            eventType = new EventType();
            cbEventType.Items.AddRange(eventType.Type.ToArray());
        }
        public OlympicForm(Form1 form, Olympic olympic)
        {
            InitializeComponent();
            baseform = form;
            this.olympic = olympic;
            cities = new List<City>();
            participants = new List<CountryParticipant>();
            cities.Add(olympic.HostCity);
            participants.AddRange(olympic.participants.ToArray());
            UpdateListBoxes();
            cbCityHost.SelectedItem = olympic.HostCity.Title;
            cbEventType.SelectedItem = olympic.EventType.Title;
            btnCreateOlympic.Enabled = false;
            nudYear.Minimum = DateTime.Now.Year;

            btnAddAthlete.Enabled = false;
            btnDelAthlete.Enabled = false;
            btnEditAthlete.Enabled = false;

            btnEditParticipant.Enabled = false;
            btnDelParticipant.Enabled = false;

            btnAddParticipantToList.Enabled = false;
            btnRemoveParticipantFromList.Enabled = false;

            btnDelCity.Enabled = false;
            btnEditCity.Enabled = false;

            eventType = new EventType();
            cbEventType.Items.AddRange(eventType.Type.ToArray());

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
                        else
                        {
                            MessageBox.Show("Fill in all info about Country-Participant", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            if (cbCityHost.SelectedIndex != -1 && cbEventType.SelectedIndex != -1)
            {
                olympic.Year = (int)nudYear.Value;
                City city = cities[cbCityHost.SelectedIndex];
                olympic.HostCity = city;
                olympic.EventType = new EventType() { Title = cbEventType.SelectedItem.ToString() };
                baseform.AddOlympic(olympic);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill in all info about Olympic", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCityHost.SelectedIndex != -1 && cbEventType.SelectedIndex != -1)
            {
                olympic.Year = (int)nudYear.Value;
                City city = cities[cbCityHost.SelectedIndex];
                olympic.HostCity = city;
                olympic.EventType = new EventType() { Title = cbEventType.SelectedItem.ToString() };
                baseform.UpdateOlympicInfo(olympic);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill in all info about Olympic", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
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
                        if (tbCityTitle.Text != string.Empty
                            && tbLocation.Text != string.Empty)
                        {
                            City city = new City()
                            {
                                Title = tbCityTitle.Text,
                                Location = tbLocation.Text,
                                Population = (int)nudPopulation.Value
                            };
                            cities.Add(city);
                            UpdateListBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Fill in all info about City", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                        }
                        break;
                    }
                case "del":
                    {
                        if (lbCities.SelectedIndex != -1)
                        {
                            int selectedIndex = lbCities.SelectedIndex;
                            City selectedCity = cities[selectedIndex];
                            cities.Remove(selectedCity);
                            UpdateListBoxes();
                        }
                        break;
                    }
                case "edit":
                    {
                        if (lbCities.SelectedIndex != -1)
                        {

                            int selectedIndex = lbCities.SelectedIndex;
                            City selectedCity = cities[selectedIndex];
                            selectedCity.Title = tbCityTitle.Text;
                            selectedCity.Location = tbLocation.Text;
                            selectedCity.Population = (int)nudPopulation.Value;
                            cbCityHost.SelectedIndex = -1;
                            UpdateListBoxes();
                        }
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
                cbCountryParticipants.SelectedIndex = -1;
                UpdateListBoxes();
            }
        }

        private void btnRemoveParticipantFromList_Click(object sender, EventArgs e)
        {
            if (lbCountryParticipants.SelectedIndex != -1)
            {
                CountryParticipant countryParticipant = olympic.participants[lbCountryParticipants.SelectedIndex];
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

            foreach (var c in cities)
            {
                lbCities.Items.Add(c);
                cbCityHost.Items.Add(c.Title);
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

        private void lbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCities.SelectedIndex != -1)
            {
                btnDelCity.Enabled = true;
                btnEditCity.Enabled = true;

            }
        }

        private void lbCountryParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCountryParticipants.SelectedIndex != -1)
            {
                btnAddParticipantToList.Enabled = true;
                btnRemoveParticipantFromList.Enabled = true;
            }
        }
    }
}
