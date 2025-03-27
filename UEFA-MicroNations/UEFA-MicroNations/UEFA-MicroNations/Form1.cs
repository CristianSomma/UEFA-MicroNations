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
        // creo un dizionario per contenere quello ritornato dal check della formattazione
        public Dictionary<string, int> fieldsOrder = new Dictionary<string, int>();
        // Lista contenente tutti i team che vengono aggiunti
        public List<Team> teams = new List<Team>();
        // tiene conto di quale finestra è aperta
        public bool isStatsListOpen = false;
        public MainForm()
        {
            InitializeComponent();
            // modifica manuale di altezza e larghezza poiché tramite progettazione non è accurato
            this.Width = 1350;  
            this.Height = 750;
            // costruisce le colonne della listView
            BuildMatchesList();
            // recupera i match e i team salvati nel file .csv
            RetrieveFromDatabase();
        }

        // *** GESTIONE DATABASE ***

        // funzione che aggiunge al database il match passato come parametro
        private void AddToDatabase(MatchResult matchResultToAdd)
        {
            // stringa che contiene il titolo dei campi
            string fieldsNames = "";
            // tutto il contenuto del file
            string fileContent = "";
            // stringa che conterrà i valori da inserire nel file nell'ordine definito
            string[] recordDatas = new string[4];
            // in base al dizionario, inserisce i valori nell'indice corretto
            recordDatas[fieldsOrder["HOMETEAM"]] = matchResultToAdd.HomeTeam.ToUpper();
            recordDatas[fieldsOrder["AWAYTEAM"]] = matchResultToAdd.AwayTeam.ToUpper();
            recordDatas[fieldsOrder["HOMEGOALS"]] = matchResultToAdd.HomeGoals.ToString();
            recordDatas[fieldsOrder["AWAYGOALS"]] = matchResultToAdd.AwayGoals.ToString();

            // lettura del file .csv
            using (StreamReader streamReader = new StreamReader("../../files/database.csv"))
            {
                int index = 0;
                while (!streamReader.EndOfStream)
                {
                    // lettura del singolo record
                    string record = streamReader.ReadLine();
                    
                    // se è la prima riga del file .csv
                    if(index == 0)
                    {
                        fieldsNames = record;
                        index++;
                        // salta alla prossima ripetizione del ciclo
                        continue;
                    }
                    
                    // inserisce in fileContent la riga e va a capo
                    fileContent += $"{record}\n";
                }
            }

            // scrittura del file .csv
            using(StreamWriter streamWriter = new StreamWriter("../../files/database.csv"))
            {
                // riscrive prima i titoli dei campi, la nuova riga e il resto del file .csv
                streamWriter.Write($"{fieldsNames}" +
                    $"\n{recordDatas[0]};" +
                    $"{recordDatas[1]};" +
                    $"{recordDatas[2]};" +
                    $"{recordDatas[3]}" +
                    $"\n{fileContent}");
            
            }
        }

        // funzione che recupera i dati dal file .csv
        private void RetrieveFromDatabase()
        {
            // pulisce la finestra nel caso ci siano già delle righe presenti
            lstWindow.Items.Clear();
            // reset della lista che contiene i team
            teams.Clear();

            // apre il file in modalità lettura
            using (StreamReader streamReader = new StreamReader("../../files/database.csv"))
            {
                // indice che tiene conto della riga letta nel file
                int index = 0;
                while (!streamReader.EndOfStream)
                {
                    // lettura del record del file
                    string record = streamReader.ReadLine();
                    // split del record in un array con i valori singoli
                    string[] recordFields = record.Split(';');

                    // se la riga letta è la prima
                    if (index == 0)
                    {
                        // esegue il controllo della formattazione del file
                        fieldsOrder = CheckDatabaseFormatting(recordFields);
                        // aumenta di uno l'indice
                        index++;
                        // salta il resto del ciclo
                        continue;
                    }

                    // crea una nuova istanza di MatchResult per il match salvato
                    // tramite il valore da ricavare ottengo l'indice che lo contiene dal dizionario e lo inserisco come parametro
                    MatchResult oldMatch = new MatchResult(
                        recordFields[fieldsOrder["HOMETEAM"]].ToUpper(),
                        recordFields[fieldsOrder["AWAYTEAM"]].ToUpper(),
                        int.Parse(recordFields[fieldsOrder["HOMEGOALS"]]),
                        int.Parse(recordFields[fieldsOrder["AWAYGOALS"]]));

                    // aggiungo alla finestra il match
                    AddMatchInList(oldMatch, false);

                    // aggiungo alla squadra di casa il match
                    UpdateTeam(oldMatch.HomeTeam, oldMatch);
                    // aggiungo alla squadra ospite il match
                    UpdateTeam(oldMatch.AwayTeam, oldMatch);
                }
            }
        }

        // funzione che controlla la formattazione del file .csv:
        private Dictionary<string, int> CheckDatabaseFormatting(string[] titleRecord)
        {
            // creo un dizionario per relazionare ogni elemento dell'array al suo valore
            // { Valore, indiceInRecord }
            Dictionary<String, int> valuesOrder = new Dictionary<string, int>()
            {
                { "HOMETEAM", -1},
                { "AWAYTEAM", -1 },
                { "HOMEGOALS", -1 },
                { "AWAYGOALS", -1 }
            };

            // dizionario utilizzato per la traduzione del titolo del campo al corrispondente inglese per permettere di rintracciare la chiave di ValuesOrder
            Dictionary<string, string> italianToEnglish = new Dictionary<string, string>()
            {
                { "SQUADRACASA", "HOMETEAM" },
                { "SQUADRAOSPITE", "AWAYTEAM" },
                { "GOALSCASA", "HOMEGOALS" },
                { "GOALSOSPITE", "AWAYGOALS" }
            };

            // per ogni campo del csv si cerca il corrispondente
            for (int i = 0; i < titleRecord.Length; i++)
            {
                // sanificazione del titolo del campo per la ricerca della key corrispondente
                string sanitizedValue = titleRecord[i].ToUpper();

                // se il titolo del campo è in italiano viene tradotto in inglese
                if (italianToEnglish.ContainsKey(sanitizedValue))
                    sanitizedValue = italianToEnglish[sanitizedValue];

                // se esiste una chiave con lo stesso nome del campo
                if (valuesOrder.ContainsKey(sanitizedValue))
                    // si lega alla chiave l'indice dell'array per recuperare quel valore
                    valuesOrder[sanitizedValue] = i;
                else
                {
                    // se il titolo del campo non viene trovato allora dà un messaggio di errore
                    MessageBox.Show("Il database non rispetta la formattazione richiesta.\nModifica il file oppure sostituiscilo.");
                    // esce dal programma
                    Application.Exit();
                }

            }

            // ritorna il dizionario che contiene i valori e l'indice in cui trovarli
            return valuesOrder;
        }

        // ******
        // *** GESTIONE LISTA ***

        // funzione che aggiunge il match alla lista (ver. match)
        private void AddMatchInList(MatchResult matchResultToAdd, bool onTop)
        {
            // crea un nuovo item che ha come parametro il valore da inserire nella prima colonna
            ListViewItem newItem = new ListViewItem(GetFormattedText(matchResultToAdd.HomeTeam));
            // inserisco tutti gli altri valori
            newItem.SubItems.Add(matchResultToAdd.HomeGoals.ToString());
            newItem.SubItems.Add(":");
            newItem.SubItems.Add(matchResultToAdd.AwayGoals.ToString());
            newItem.SubItems.Add(GetFormattedText(matchResultToAdd.AwayTeam));
            // aggiungo effettivamente l'oggetto ListViewItem

            if (onTop)
                // se onTop == true inserisce l'elemento in cima alla lista
                lstWindow.Items.Insert(0, newItem);
            else
                // altrimenti alla fine
                lstWindow.Items.Add(newItem);
        }

        // funzione che aggiunge le squadre in ordine (ver. classifica)
        private void ShowTeamsRanking()
        {
            // pulisco la listView dagli elementi presenti
            lstWindow.Items.Clear();

            List<Team> sortedTeams = teams.OrderByDescending(team => team.Points)
                           .ThenByDescending(team => team.GoalsScored - team.GoalsAgainst)
                           .ToList();

            // per ogni team...
            foreach (Team team in sortedTeams)
            {
                // crea una istanza di ListViewItem e per ogni colonna inserisce il valore corrispondente
                ListViewItem newItem = new ListViewItem(GetFormattedText(team.TeamName));
                newItem.SubItems.Add(team.playedMatches.Count.ToString());
                newItem.SubItems.Add(team.MatchesStats[0].ToString());
                newItem.SubItems.Add(team.MatchesStats[1].ToString());
                newItem.SubItems.Add(team.MatchesStats[2].ToString());
                newItem.SubItems.Add(team.GoalsScored.ToString());
                newItem.SubItems.Add(team.GoalsAgainst.ToString());
                newItem.SubItems.Add((team.GoalsScored - team.GoalsAgainst).ToString());
                newItem.SubItems.Add(team.Points.ToString());
                
                // aggiunge alla lista l'elemento
                lstWindow.Items.Add(newItem);
            }
        }

        // funzione che crea le colonne per la visualizzazione dei match giocati
        private void BuildMatchesList()
        {
            // dizionario che contiene i titoli delle colonne e la loro larghezza in percentuale rispetto alla larghezza della lista
            Dictionary<string, float> columnsProperties = new Dictionary<string, float>()
            {
                { "Home team", 0.390f },
                { "", 0.060f },
                { "Results", 0.100f },
                { " ", 0.060f },
                { "Away team", 0.390f }
            };

            // chiama la funzione che crea effettivamente le colonne
            SetWindowColumns(columnsProperties);
            // aggiunge i match alla lista recuperandole dal file .csv
            RetrieveFromDatabase();
        }

        // funzione che crea le colonne per la classifica delle squadre
        private void BuildRankingList()
        {
            // dizionario che contiene le colonne, key = nome colonna, value = larghezza della colonna (in percentuale)
            Dictionary<string, float> columnsProperties = new Dictionary<string, float>()
            {
                { "Team name", 0.390f },
                { "P", 0.070f },
                { "W", 0.070f },
                { "D", 0.070f },
                { "L", 0.070f },
                { "GF", 0.077f },
                { "GA", 0.077f },
                { "GD", 0.077f },
                { "Pts", 0.099f }
            };

            // crea effettivamente le colonne della listView
            SetWindowColumns(columnsProperties);
        }

        // funzione che crea le colonne sulla base del dizionario preso come parametro
        private void SetWindowColumns(Dictionary<string, float> columnsBlueprint)
        {
            // pulisce dalle colonne precedenti la listView
            lstWindow.Clear();

            // indice che tiene conto di quale colonna sta venendo creata
            int index = 0;

            // per ogni voce del dizionario preso come parametro...
            foreach (KeyValuePair<string, float> element in columnsBlueprint)
            {
                // crea una nuova istanza dell'oggetto colonna
                ColumnHeader newColumn = new ColumnHeader();
                // titolo della colonna è la key della voce
                newColumn.Text = element.Key;
                // la larghezza è relativa a quella della listView
                newColumn.Width = (int)(lstWindow.ClientSize.Width * element.Value);
                
                // if controlla come allineare il testo della colonna
                if (index == columnsBlueprint.Count-1 && !isStatsListOpen)
                    // se è ultima colonna della finestra di match allinea a destra
                    newColumn.TextAlign = HorizontalAlignment.Right;
                else
                    // altrimenti al centro.
                    newColumn.TextAlign = HorizontalAlignment.Center;
                
                // aggiunge la colonna alla listView
                lstWindow.Columns.Add(newColumn);
                // aumenta l'indice che tiene conto della colonna corrente
                index++;
            }
        }

        // ******
        // *** GESTIONE INPUT ***

        // funzione che ritorna un booleano che indica se la textbox è vuota o no
        private bool IsTextBoxEmpty(TextBox[] textboxs)
        {
            // per ogni textbox passata
            foreach (TextBox textbox in textboxs)
            {
                // se la textbox è vuota ritorna true
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    InvalidTextBox(new TextBox[] { textbox });
                    MessageBox.Show("Complete all the fields before adding...");
                    return true;
                }
            }

            return false;
        }

        // funzione che resetta le textbox passate come parametri
        private void ResetTextBox(TextBox[] textboxs)
        {
            foreach (TextBox textbox in textboxs)
            {
                textbox.Clear();
                textbox.BackColor = Color.White;
                textbox.ForeColor = Color.Black;
            }
        }

        // funzione che mostra l'invalidità della textbox
        private void InvalidTextBox(TextBox[] textboxs)
        {
            foreach (TextBox textbox in textboxs)
            {
                textbox.Clear();
                textbox.BackColor = Color.Firebrick;
                textbox.ForeColor = Color.White;
                textbox.Focus();
            }
        }

        // ******
        // *** FUNZIONALITA' ***

        // funzione di aggiunta match
        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            // crea un array con le textbox da poter passare come parametro alle funzioni
            TextBox[] textboxs = new TextBox[] { txtHomeTeam, txtAwayTeam };

            // se almeno una delle textbox è vuota allora ferma la funzione
            if (IsTextBoxEmpty(textboxs))
                return;
            
            // se le due squadre rivali sono la stessa allora dà errore
            if (textboxs[0].Text.ToUpper().Trim() == textboxs[1].Text.ToUpper().Trim())
            {
                // tramite apposita funzione mostra a schermo un comportamento che indica errore
                InvalidTextBox(textboxs);
                // messaggio di spiegazione dell'errore
                MessageBox.Show("Enter two different teams...");
                return;
            }

            // se gli input sono corretti crea una nuova istanza di MatchResult
            MatchResult newMatch = new MatchResult(
                textboxs[0].Text,
                textboxs[1].Text,
                (int)nmrHomeGoals.Value,
                (int)nmrAwayGoals.Value);

            // aggiungo al team di casa il nuovo match giocato
            UpdateTeam(newMatch.HomeTeam, newMatch);
            // aggiungo al team ospite il nuovo match giocato
            UpdateTeam(newMatch.AwayTeam, newMatch);
            // Aggiunge il nuovo match alla listView
            AddMatchInList(newMatch, true);
            // aggiunge il nuovo match anche al file .csv
            AddToDatabase(newMatch);
            
            // reset dei campi di input
            ResetTextBox(textboxs);
            nmrHomeGoals.Value = 0;
            nmrAwayGoals.Value = 0;
        }

        // funzione di ricerca della squadra presa in input e match fatti
        private void btnSearchTeam_Click(object sender, EventArgs e)
        {
            // se la textbox è vuota
            if (IsTextBoxEmpty(new TextBox[] { txtTeamName }))
                return;

            // recupera l'indice del team inserito
            int teamIndex = GetTeamIndex(txtTeamName.Text);

            // se il team non esiste...
            if (teamIndex == -1)
            {
                // chiama la funzione per mostrare l'errore graficamente
                InvalidTextBox(new TextBox[] { txtTeamName });
                // mostra un messaggio popup
                MessageBox.Show("The team entered wasn't found...");
                // esce dalla funzione
                return;
            }

            pctSearchFlag.Image = Image.FromFile(GetTeamFlag(txtTeamName.Text.ToUpper()));
            // pulisce la finestra dalle righe presenti
            lstWindow.Items.Clear();
            // recupera la lista di match disputati dal team inserito
            List<MatchResult> teamMatches = teams[teamIndex].playedMatches;

            // per ogni match disputato
            foreach (MatchResult match in teamMatches)
            {
                // lo inserisce nella finestra
                AddMatchInList(match, true);
            }
        }

        // ******
        // *** GESTIONE TEAM ***

        // funzione che gestisce il team, se esiste aggiunge il match altrimenti lo crea e aggiunge il match
        private void UpdateTeam(string teamName, MatchResult newMatch)
        {
            // ottiene l'indice del team nella lista
            int teamIndex = GetTeamIndex(teamName);

            // se il team non esiste (-1)
            if(teamIndex == -1)
            {
                // crea un nuovo team
                Team newTeam = new Team(teamName);
                // aggiunge il match
                newTeam.AddPlayedMatch(newMatch);
                // aggiunge alla lista globale il nuovo team
                teams.Add(newTeam);
            }
            else
            {
                // aggiunge il match al team nell'indice ottenuto
                teams[teamIndex].AddPlayedMatch(newMatch);
            }
        }

        // funzione che controlla se il team esiste sulla base del nome e ritorna l'indice
        private int GetTeamIndex(string teamName)
        {
            // per ogni team esistente...
            for (int i = 0; i<teams.Count; i++)
            {
                // se il nome è uguale e di conseguenza già esiste
                if (teams[i].TeamName == teamName.ToUpper().Trim())
                {
                    // ritorna true
                    return i;
                }
            }

            // se il team non esiste ritorna -1
            return -1;
        }

        // funzione che ottiene la bandiera, se esiste, in base al nome del team
        private string GetTeamFlag(string teamName)
        {
            // rimpiazza ogni spazio con underscore per rispettare la formattazione
            string sanitizedTeamName = teamName.Replace(' ', '_');
            // potenziale flag   
            string potentialFlagPath = $"../../flags/{sanitizedTeamName}.png";

            // se il file della bandiera esiste
            if (File.Exists(potentialFlagPath))
            {
                // la assegna.
                return potentialFlagPath;
            }
            else
            {
                // se la flag non esiste allora gli assegna quella di riserva (UNFOUND)
                return "../../flags/UNFOUND.png";
            }
        }

        // ******
        // *** HELPER ***

        // funzione che rende maiuscola la prima lettera di ogni parola
        public string GetFormattedText(string text)
        {
            // split del nome del team ad ogni spazio, se ci sono elementi vuoti li rimuove
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // per ogni parola che compone il nome...
            for (int i = 0; i < words.Length; i++)
            {
                // controllo aggiuntivo che salta gli elementi vuoti se ne rimanessero
                if (words[i].Length == 0) continue;
                // la parola viene rimpiazzata da sé stessa ma con la prima lettera maiuscola
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            // ritorno tutte le parole separate da spazio
            return string.Join(" ", words);
        }

        // funzione che gestisce la visibilità dei pannelli
        public void HandlePanels(Panel panelToShow)
        {
            // array con i pannelli per le modalità
            Panel[] panels = { pnlAdd, pnlSearch, pnlStats };

            foreach(Panel panel in panels)
            {
                // se il panel da mostrare è quello corrente...
                if (panelToShow == panel)
                    // ...viene reso visibile
                    panel.Visible = true;
                else
                    // ...altrimenti viene nascosto
                    panel1.Visible = false;
            }
        }

        public void ShowPanelStats()
        {
            int sumGoals = 0;
            int maxGoals = 0;
            MatchResult matchMostGoals = new MatchResult("Home", "Away", 0, 0);
            foreach(Team team in teams)
            {
                sumGoals += team.GoalsScored;
                
                if (maxGoals < team.GoalsScored)
                    maxGoals = team.GoalsScored;

                team.playedMatches.ForEach(match =>
                {
                    if (matchMostGoals.HomeGoals + matchMostGoals.AwayGoals > match.HomeGoals + match.AwayGoals)
                        matchMostGoals = match;
                });
            }

            lblTotGoalsValue.Text = sumGoals.ToString();
            lblMaxGoalsValue.Text = maxGoals.ToString();
            lblMatchMostGoalsValue.Text = $"{matchMostGoals.HomeTeam} : {matchMostGoals.AwayTeam}";
        }

        // ******
        // *** GESTIONE EVENTI ***

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            // se la finestra è ridimensionata allora anche le colonne della listView fanno lo stesso
            // in base allo stato...
            if (isStatsListOpen)
                // se è aperta la finestra delle statistiche aggiorna quella
                BuildRankingList();
            else
                // altrimenti questa...
                BuildMatchesList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // statistiche chiuse
            isStatsListOpen = false;
            // mostra il pannello di aggiunta match
            HandlePanels(pnlAdd);
            // costruisce la lista dei match
            BuildMatchesList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            isStatsListOpen = false;
            // reset dei campi di input
            ResetTextBox(new TextBox[] { txtTeamName });
            pctSearchFlag.Image = null;
            HandlePanels(pnlSearch);
            BuildMatchesList();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            isStatsListOpen = true;
            HandlePanels(pnlStats);
            ShowPanelStats();
            BuildRankingList();
            ShowTeamsRanking();
        }
    
        // ******
    }

    public class Team
    {
        public string TeamName;
        public List<MatchResult> playedMatches = new List<MatchResult>();
        private int 
            _goalsScored = 0, 
            _goalsAgainst = 0, 
            _points = 0, 
            _wonMatches = 0, 
            _lostMatches = 0,
            _drawMatches = 0;

        // proprietà pubbliche che danno accesso alle variabili private come readonly
        public int GoalsScored { get => _goalsScored; }
        public int GoalsAgainst { get => _goalsAgainst; }
        public int Points { get => _points; }
        public int[] MatchesStats => new int[] { _wonMatches, _drawMatches, _lostMatches };
        
        public Team(string teamName)
        {
            TeamName = teamName.ToUpper().Trim();
        }

        public void AddPlayedMatch(MatchResult newMatch)
        {

            bool isHomeTeam = newMatch.HomeTeam == TeamName;

            int teamGoals = isHomeTeam ? newMatch.HomeGoals : newMatch.AwayGoals;
            int opponentGoals = isHomeTeam ? newMatch.AwayGoals : newMatch.HomeGoals;

            _goalsScored += teamGoals;
            _goalsAgainst += opponentGoals;

            if (teamGoals > opponentGoals)
            {
                _points += 3;
                _wonMatches++;
            }
            else if (teamGoals == opponentGoals)
            {
                _points += 1;
                _drawMatches++;
            }
            else
            {
                _lostMatches++;
            }

            playedMatches.Add(newMatch);
        }
    }

    public struct MatchResult
    {
        public string HomeTeam, AwayTeam;
        public int HomeGoals, AwayGoals;

        public MatchResult(string homeTeam, string awayTeam, int homeGoals, int awayGoals)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
        }
    }
}
