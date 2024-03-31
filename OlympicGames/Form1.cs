using OfficeOpenXml;
using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using OlympicGames.Services.OlympicDataManagers;
using System.Numerics;

namespace OlympicGames
{
    public partial class Form1 : Form
    {
        public IOlympicDataManager DataManager;
        private bool _hasOpenedFile = false;
        private string _openedPath = "";
        public Form1()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            DataManager = new JsonOlympicDataManager();
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
                            Olympic selectedOlympic = DataManager.GetAll().ToList()[selectedIndex];
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
                            Olympic selectedOlympic = DataManager.GetAll().ToList()[selectedIndex];
                            DataManager.Delete(selectedOlympic);
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
                Olympic ol = DataManager.GetAll().ToList()[selectedIndex];
                foreach (var p in ol.participants)
                {
                    lbCountriesParticipants.Items.Add(p);
                }
            }
        }

        public void AddOlympic(Olympic olympic)
        {
            DataManager.Add(olympic);
            UpdateListBox();
        }
        public void UpdateOlympicInfo(Olympic olympicNew)
        {
            int selectedIndex = lbOlympics.SelectedIndex;
            if (selectedIndex != -1)
            {
                DataManager.Update(DataManager.GetAll().ToList()[selectedIndex], olympicNew);
            }
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            lbOlympics.Items.Clear();
            lbCountriesParticipants.Items.Clear();
            foreach (var ol in DataManager.GetAll())
            {
                lbOlympics.Items.Add(ol);
            }
        }

        private void OpenMenuOptionClick(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "csv":
                    DataManager = new CsvOlympicDataManager();
                    break;
                case "json":
                    DataManager = new JsonOlympicDataManager();
                    break;
                case "txt":
                    DataManager = new TxtOlympicDataManager();
                    break;
                case "xlsx":
                    DataManager = new XlsxOlympicDataManager();
                    break;
                case "xml":
                    DataManager = new XmlOlympicDataManager();
                    break;
            }

            var dialog = new OpenFileDialog();
            dialog.Filter = DataManager.Filter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _hasOpenedFile = true;
                _openedPath = dialog.FileName;
                DataManager.Read(dialog.FileName);
                UpdateListBox();
            }
        }
        private void SaveAsMenuOptionClick(object sender, EventArgs e)
        {
            List<Olympic> currentOlympics = DataManager.GetAll().ToList();
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "csv":
                    DataManager = new CsvOlympicDataManager();
                    break;
                case "json":
                    DataManager = new JsonOlympicDataManager();
                    break;
                case "txt":
                    DataManager = new TxtOlympicDataManager();
                    break;
                case "xlsx":
                    DataManager = new XlsxOlympicDataManager();
                    break;
                case "xml":
                    DataManager = new XmlOlympicDataManager();
                    break;
            }
            DataManager.SetAll(currentOlympics);

            var dialog = new SaveFileDialog();
            dialog.Filter = DataManager.Filter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var confirm = MessageBox.Show("Do you really wanna save this file?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (confirm == DialogResult.Yes)
                    {
                        DataManager.Write(dialog.FileName);
                        MessageBox.Show("Data saved!");
                    }
                    else
                    {
                        MessageBox.Show("Data was not saved!");
                    }
                }
            }
        }

        private void SaveMenuOptionClick(object sender, EventArgs e)
        {
            if (!_hasOpenedFile)
            {
                MessageBox.Show("No file opened!");
                return;
            }

            var confirm = MessageBox.Show("Do you really wanna save this file?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (confirm == DialogResult.Yes)
                {
                    DataManager.Write(_openedPath);
                    MessageBox.Show("Data saved!");
                }
                else
                {
                    MessageBox.Show("Data was not saved!");
                }
            }
        }

    }
}
