using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEFA_MicroNations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RetrieveFromDatabase();
        }

        private void RetrieveFromDatabase()
        {
            using(StreamReader streamReader = new StreamReader("../../files/database.csv"))
            {
                
                int index = 0;
                while (!streamReader.EndOfStream)
                {
                    string record = streamReader.ReadLine();
                    string[] recordFields = record.Split(';');

                    if (index == 0)
                    {
                        
                        index++;
                        continue;
                    }

                    
                    Match oldMatch = new Match(
                        recordFields[0],
                        recordFields[1],
                        int.Parse(recordFields[2]),
                        int.Parse(recordFields[3]));

                    AddMatchInList(oldMatch);
                }
            }
        }

        private void CheckDatabaseFormatting(string[] titleRecord)
        {
            string[] englishFieldsNames = new string[]
                {
                    "hometeam",
                    "awayteam",
                    "homegoals",
                    "awaygoals"
                };

            string[] italianFieldsNames = new string[]
            {
                    "teamcasa",
                    "teamospite",
                    "casagoals",
                    "ospitegoals"
            };

            if (englishFieldsNames.Contains(titleRecord[0].ToLower())){
                Array.IndexOf(englishFieldsNames, titleRecord[0].ToLower())
            }
                
        }

        private void AddMatchInList(Match matchToAdd)
        {
            string newLine = $"{matchToAdd.HomeTeam.PadRight(35)}" +
                $"{matchToAdd.HomeGoals.ToString().PadRight(5)}:" +
                $"{matchToAdd.AwayGoals.ToString().PadLeft(5)}" +
                $"{matchToAdd.AwayTeam.PadLeft(35)}";

            lstWindow.Items.Add(newLine);
        }
    }

    public struct Match
    {
        public string HomeTeam, AwayTeam;
        public int HomeGoals, AwayGoals;

        public Match(string homeTeam, string awayTeam, int homeGoals, int awayGoals)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
        }
    }
}
