using OfficeOpenXml;
using OlympicGames.Core.Entities;
using OlympicGames.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Services.OlympicDataManagers
{
    public class XlsxOlympicDataManager : IOlympicDataManager
    {
        private List<Olympic> olympics = new List<Olympic>();
        public bool IsChanged { get; set; } = false;

        public string Filter => "XLSX files (*.xlsx)|*.xlsx";

        public void Add(Olympic entity)
        {
            olympics.Add(entity);
        }

        public void Delete(Olympic entity)
        {
            olympics.Remove(entity);
        }
        public void Update(Olympic oldEntity, Olympic newEntity)
        {
            int index = olympics.IndexOf(oldEntity);
            olympics[index] = newEntity;
        }

        public IEnumerable<Olympic> GetAll()
        {
            return olympics;
        }
        public void SetAll(IEnumerable<Olympic> entities)
        {
            olympics = entities.ToList();
        }

        public void Read(string path)
        {
            List<Olympic> olympics = new List<Olympic>();

            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                foreach (var worksheet in package.Workbook.Worksheets)
                {
                    var olympic = new Olympic();
                    int currentRow = 2; // Start reading from the second row
                    CountryParticipant currentParticipant = null;

                    while (worksheet.Cells[currentRow, 1].Value != null ||
                        worksheet.Cells[currentRow, 2].Value != null ||
                        worksheet.Cells[currentRow, 3].Value != null ||
                        worksheet.Cells[currentRow, 4].Value != null ||
                        worksheet.Cells[currentRow, 5].Value != null ||
                        worksheet.Cells[currentRow, 6].Value != null ||
                        worksheet.Cells[currentRow, 7].Value != null ||
                        worksheet.Cells[currentRow, 8].Value != null ||
                        worksheet.Cells[currentRow, 9].Value != null ||
                        worksheet.Cells[currentRow, 10].Value != null ||
                        worksheet.Cells[currentRow, 11].Value != null)
                    {
                        if (currentRow == 2)
                        {
                            olympic.Year = int.Parse(worksheet.Cells[currentRow, 1].Value.ToString());
                            olympic.HostCity = new City
                            {
                                Title = worksheet.Cells[currentRow, 2].Value.ToString(),
                                Location = worksheet.Cells[currentRow, 3].Value.ToString(),
                                Population = int.Parse(worksheet.Cells[currentRow, 4].Value.ToString())
                            };
                            olympic.EventType = new EventType { Title = worksheet.Cells[currentRow, 5].Value.ToString() };
                            olympic.participants = new List<CountryParticipant>();
                        }

                        if (worksheet.Cells[currentRow, 6].Value != null &&
                            worksheet.Cells[currentRow, 7].Value != null &&
                            worksheet.Cells[currentRow, 8].Value != null)
                        {
                            if (currentParticipant != null)
                            {
                                olympic.participants.Add(currentParticipant);
                            }
                            currentParticipant = new CountryParticipant
                            {
                                Title = worksheet.Cells[currentRow, 6].Value.ToString(),
                                Wins = int.Parse(worksheet.Cells[currentRow, 7].Value.ToString()),
                                Losses = int.Parse(worksheet.Cells[currentRow, 8].Value.ToString()),
                                Athletes = new List<Athlete>()
                            };
                        }

                        if (worksheet.Cells[currentRow, 9].Value != null &&
                            worksheet.Cells[currentRow, 10].Value != null &&
                            worksheet.Cells[currentRow, 11].Value != null)
                        {
                            var athlete = new Athlete
                            {
                                FullName = worksheet.Cells[currentRow, 9].Value.ToString(),
                                Age = int.Parse(worksheet.Cells[currentRow, 10].Value.ToString()),
                                IsMale = bool.Parse(worksheet.Cells[currentRow, 11].Value.ToString())
                            };

                            currentParticipant.Athletes.Add(athlete);
                        }
                        currentRow++;
                    }
                    if (currentParticipant != null)
                    {
                        olympic.participants.Add(currentParticipant);
                    }
                    olympics.Add(olympic);
                }
            }

            this.olympics = olympics;
        }
        public void Write(string path)
        {
            using (var package = new ExcelPackage())
            {
                foreach (var olympic in olympics)
                {
                    var sheet = package.Workbook.Worksheets.Add($"Olympics_{olympic.Year}");

                    sheet.Cells["A1"].Value = "Year";
                    sheet.Cells["B1"].Value = "HostCity";
                    sheet.Cells["C1"].Value = "Location";
                    sheet.Cells["D1"].Value = "Population";
                    sheet.Cells["E1"].Value = "EventType";
                    sheet.Cells["F1"].Value = "Participant";
                    sheet.Cells["G1"].Value = "Wins";
                    sheet.Cells["H1"].Value = "Losses";
                    sheet.Cells["I1"].Value = "Athlete";
                    sheet.Cells["J1"].Value = "Age";
                    sheet.Cells["K1"].Value = "IsMale";

                    int row = 2;

                    sheet.Cells[row, 1].Value = olympic.Year;
                    sheet.Cells[row, 2].Value = olympic.HostCity.Title;
                    sheet.Cells[row, 3].Value = olympic.HostCity.Location;
                    sheet.Cells[row, 4].Value = olympic.HostCity.Population;
                    sheet.Cells[row, 5].Value = olympic.EventType.Title;

                    foreach (var participant in olympic.participants)
                    {
                        sheet.Cells[row, 6].Value = participant.Title;
                        sheet.Cells[row, 7].Value = participant.Wins;
                        sheet.Cells[row, 8].Value = participant.Losses;

                        foreach (var athlete in participant.Athletes)
                        {
                            sheet.Cells[row, 9].Value = athlete.FullName;
                            sheet.Cells[row, 10].Value = athlete.Age;
                            sheet.Cells[row, 11].Value = athlete.IsMale;
                            row++;
                        }
                    }
                }

                package.SaveAs(new FileInfo(path));
            }
        }
    }
}
