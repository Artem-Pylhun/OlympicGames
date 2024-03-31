using OlympicGames.Entities;

namespace OlympicGames
{
    public partial class Form1 : Form
    {
        public List<Olympic> olympics;
        public Form1()
        {
            InitializeComponent();
            olympics = new List<Olympic>();
            btnDelOlympic.Enabled = false;
            btnEditOlympic.Enabled = false;
            UpdateListBox();
        }

        private void btnOlympic_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Tag.ToString())
            {
                case "add":
                    {
                        OlympicForm olympicForm = new OlympicForm(this);
                        olympicForm.Show();
                        this.Hide();
                        this.Enabled = false;
                        break;
                    }

                case "edit":
                    {
                        if (lbOlympics.SelectedItem != null)
                        {
                            int selectedIndex = lbOlympics.SelectedIndex;
                            Olympic selectedOlympic = olympics[selectedIndex];
                            OlympicForm olympicForm = new OlympicForm(this, selectedOlympic);
                            olympicForm.Show();
                            this.Hide();
                            this.Enabled = false;

                        }
                        break;
                    }
                case "del":
                    {
                        if (lbOlympics.SelectedItem != null)
                        {
                            int selectedIndex = lbOlympics.SelectedIndex;
                            olympics.Remove(olympics[selectedIndex]);
                            UpdateListBox();
                            btnDelOlympic.Enabled = false;
                            btnEditOlympic.Enabled = false;
                        }
                            break;
                    }

            }
        }

        private void lbOlympics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOlympics.SelectedIndex != -1)
            {
                btnDelOlympic.Enabled = true;
                btnEditOlympic.Enabled = true;
                lbCountriesParticipants.Items.Clear();
                int selectedIndex = lbOlympics.SelectedIndex;
                Olympic ol = olympics[selectedIndex];
                foreach (var p in ol.participants) 
                {
                    lbCountriesParticipants.Items.Add(p);
                }
            }
        }

        public void AddOlympic(Olympic olympic)
        {
            olympics.Add(olympic);
            UpdateListBox();
        }
        public void UpdateOlympicInfo(Olympic olympic)
        {
            int selectedIndex = lbOlympics.SelectedIndex;
            if(selectedIndex != -1)
            {
                olympics[selectedIndex] = olympic;
            }
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            lbOlympics.Items.Clear();
            lbCountriesParticipants.Items.Clear();
            foreach (var ol in olympics)
            {
                lbOlympics.Items.Add(ol);
            }
        }
    }
}
