namespace UEFA_MicroNations
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblMostGoalsMatch = new System.Windows.Forms.Label();
            this.lblTotGoalsScored = new System.Windows.Forms.Label();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.lblMaxGoalsScored = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pctSearchFlag = new System.Windows.Forms.PictureBox();
            this.btnSearchTeam = new System.Windows.Forms.Button();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.nmrAwayGoals = new System.Windows.Forms.NumericUpDown();
            this.lblAwayGoals = new System.Windows.Forms.Label();
            this.nmrHomeGoals = new System.Windows.Forms.NumericUpDown();
            this.lblHomeGoals = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.txtAwayTeam = new System.Windows.Forms.TextBox();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.txtHomeTeam = new System.Windows.Forms.TextBox();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblControlsTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.pnlTitleContainer = new System.Windows.Forms.Panel();
            this.lblTitleP2 = new System.Windows.Forms.Label();
            this.lblUEFATitle = new System.Windows.Forms.Label();
            this.lstWindow = new System.Windows.Forms.ListView();
            this.clmHomeTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeGoals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmColon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAwayGoals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAwayTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMaxGoalsValue = new System.Windows.Forms.Label();
            this.lblTotGoalsValue = new System.Windows.Forms.Label();
            this.lblMatchMostGoalsValue = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearchFlag)).BeginInit();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAwayGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHomeGoals)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTitleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(163)))), ((int)(((byte)(55)))));
            this.pnlControls.Controls.Add(this.pnlStats);
            this.pnlControls.Controls.Add(this.pnlSearch);
            this.pnlControls.Controls.Add(this.pnlAdd);
            this.pnlControls.Controls.Add(this.lblControlsTitle);
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControls.Location = new System.Drawing.Point(675, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(324, 693);
            this.pnlControls.TabIndex = 0;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.Silver;
            this.pnlStats.Controls.Add(this.lblMatchMostGoalsValue);
            this.pnlStats.Controls.Add(this.lblTotGoalsValue);
            this.pnlStats.Controls.Add(this.lblMaxGoalsValue);
            this.pnlStats.Controls.Add(this.lblMostGoalsMatch);
            this.pnlStats.Controls.Add(this.lblTotGoalsScored);
            this.pnlStats.Controls.Add(this.lblStatsTitle);
            this.pnlStats.Controls.Add(this.lblMaxGoalsScored);
            this.pnlStats.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStats.Location = new System.Drawing.Point(12, 187);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(300, 284);
            this.pnlStats.TabIndex = 10;
            this.pnlStats.Visible = false;
            // 
            // lblMostGoalsMatch
            // 
            this.lblMostGoalsMatch.AutoSize = true;
            this.lblMostGoalsMatch.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostGoalsMatch.Location = new System.Drawing.Point(14, 211);
            this.lblMostGoalsMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostGoalsMatch.Name = "lblMostGoalsMatch";
            this.lblMostGoalsMatch.Size = new System.Drawing.Size(193, 23);
            this.lblMostGoalsMatch.TabIndex = 10;
            this.lblMostGoalsMatch.Text = "Match with most goals: ";
            this.lblMostGoalsMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotGoalsScored
            // 
            this.lblTotGoalsScored.AutoSize = true;
            this.lblTotGoalsScored.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotGoalsScored.Location = new System.Drawing.Point(12, 137);
            this.lblTotGoalsScored.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotGoalsScored.Name = "lblTotGoalsScored";
            this.lblTotGoalsScored.Size = new System.Drawing.Size(157, 23);
            this.lblTotGoalsScored.TabIndex = 9;
            this.lblTotGoalsScored.Text = "Total goals scored: ";
            this.lblTotGoalsScored.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsTitle.Location = new System.Drawing.Point(10, 11);
            this.lblStatsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(131, 33);
            this.lblStatsTitle.TabIndex = 4;
            this.lblStatsTitle.Text = "Statistics:";
            // 
            // lblMaxGoalsScored
            // 
            this.lblMaxGoalsScored.AutoSize = true;
            this.lblMaxGoalsScored.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxGoalsScored.Location = new System.Drawing.Point(14, 68);
            this.lblMaxGoalsScored.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxGoalsScored.Name = "lblMaxGoalsScored";
            this.lblMaxGoalsScored.Size = new System.Drawing.Size(152, 23);
            this.lblMaxGoalsScored.TabIndex = 0;
            this.lblMaxGoalsScored.Text = "Max goals scored: ";
            this.lblMaxGoalsScored.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Silver;
            this.pnlSearch.Controls.Add(this.pctSearchFlag);
            this.pnlSearch.Controls.Add(this.btnSearchTeam);
            this.pnlSearch.Controls.Add(this.lblSearchTitle);
            this.pnlSearch.Controls.Add(this.txtTeamName);
            this.pnlSearch.Controls.Add(this.lblTeamName);
            this.pnlSearch.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(12, 187);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(300, 284);
            this.pnlSearch.TabIndex = 9;
            this.pnlSearch.Visible = false;
            // 
            // pctSearchFlag
            // 
            this.pctSearchFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctSearchFlag.Location = new System.Drawing.Point(75, 130);
            this.pctSearchFlag.Margin = new System.Windows.Forms.Padding(2);
            this.pctSearchFlag.Name = "pctSearchFlag";
            this.pctSearchFlag.Size = new System.Drawing.Size(150, 81);
            this.pctSearchFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSearchFlag.TabIndex = 9;
            this.pctSearchFlag.TabStop = false;
            // 
            // btnSearchTeam
            // 
            this.btnSearchTeam.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeam.Location = new System.Drawing.Point(75, 219);
            this.btnSearchTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTeam.Name = "btnSearchTeam";
            this.btnSearchTeam.Size = new System.Drawing.Size(150, 41);
            this.btnSearchTeam.TabIndex = 8;
            this.btnSearchTeam.Text = "Search";
            this.btnSearchTeam.UseVisualStyleBackColor = true;
            this.btnSearchTeam.Click += new System.EventHandler(this.btnSearchTeam_Click);
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTitle.Location = new System.Drawing.Point(10, 11);
            this.lblSearchTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(190, 33);
            this.lblSearchTitle.TabIndex = 4;
            this.lblSearchTitle.Text = "Search a team:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.BackColor = System.Drawing.Color.White;
            this.txtTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeamName.Location = new System.Drawing.Point(16, 89);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(269, 30);
            this.txtTeamName.TabIndex = 1;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(14, 68);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(157, 23);
            this.lblTeamName.TabIndex = 0;
            this.lblTeamName.Text = "Name of the team:";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Silver;
            this.pnlAdd.Controls.Add(this.btnAddMatch);
            this.pnlAdd.Controls.Add(this.nmrAwayGoals);
            this.pnlAdd.Controls.Add(this.lblAwayGoals);
            this.pnlAdd.Controls.Add(this.nmrHomeGoals);
            this.pnlAdd.Controls.Add(this.lblHomeGoals);
            this.pnlAdd.Controls.Add(this.lblAddTitle);
            this.pnlAdd.Controls.Add(this.txtAwayTeam);
            this.pnlAdd.Controls.Add(this.lblAwayTeam);
            this.pnlAdd.Controls.Add(this.txtHomeTeam);
            this.pnlAdd.Controls.Add(this.lblHomeTeam);
            this.pnlAdd.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdd.Location = new System.Drawing.Point(12, 187);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(300, 284);
            this.pnlAdd.TabIndex = 2;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMatch.Location = new System.Drawing.Point(75, 203);
            this.btnAddMatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(150, 41);
            this.btnAddMatch.TabIndex = 8;
            this.btnAddMatch.Text = "Add";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // nmrAwayGoals
            // 
            this.nmrAwayGoals.Font = new System.Drawing.Font("Noto Mono", 13.8F);
            this.nmrAwayGoals.Location = new System.Drawing.Point(230, 150);
            this.nmrAwayGoals.Margin = new System.Windows.Forms.Padding(2);
            this.nmrAwayGoals.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmrAwayGoals.Name = "nmrAwayGoals";
            this.nmrAwayGoals.Size = new System.Drawing.Size(56, 29);
            this.nmrAwayGoals.TabIndex = 6;
            this.nmrAwayGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAwayGoals
            // 
            this.lblAwayGoals.AutoSize = true;
            this.lblAwayGoals.Location = new System.Drawing.Point(226, 129);
            this.lblAwayGoals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAwayGoals.Name = "lblAwayGoals";
            this.lblAwayGoals.Size = new System.Drawing.Size(59, 23);
            this.lblAwayGoals.TabIndex = 7;
            this.lblAwayGoals.Text = "Goals:";
            this.lblAwayGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmrHomeGoals
            // 
            this.nmrHomeGoals.Font = new System.Drawing.Font("Noto Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrHomeGoals.Location = new System.Drawing.Point(230, 89);
            this.nmrHomeGoals.Margin = new System.Windows.Forms.Padding(2);
            this.nmrHomeGoals.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmrHomeGoals.Name = "nmrHomeGoals";
            this.nmrHomeGoals.Size = new System.Drawing.Size(56, 29);
            this.nmrHomeGoals.TabIndex = 1;
            this.nmrHomeGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHomeGoals
            // 
            this.lblHomeGoals.AutoSize = true;
            this.lblHomeGoals.Location = new System.Drawing.Point(226, 68);
            this.lblHomeGoals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeGoals.Name = "lblHomeGoals";
            this.lblHomeGoals.Size = new System.Drawing.Size(59, 23);
            this.lblHomeGoals.TabIndex = 5;
            this.lblHomeGoals.Text = "Goals:";
            this.lblHomeGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(10, 11);
            this.lblAddTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(206, 33);
            this.lblAddTitle.TabIndex = 4;
            this.lblAddTitle.Text = "Add new match:";
            // 
            // txtAwayTeam
            // 
            this.txtAwayTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAwayTeam.Location = new System.Drawing.Point(16, 150);
            this.txtAwayTeam.Margin = new System.Windows.Forms.Padding(2);
            this.txtAwayTeam.Name = "txtAwayTeam";
            this.txtAwayTeam.Size = new System.Drawing.Size(207, 30);
            this.txtAwayTeam.TabIndex = 3;
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Location = new System.Drawing.Point(14, 129);
            this.lblAwayTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(104, 23);
            this.lblAwayTeam.TabIndex = 2;
            this.lblAwayTeam.Text = "Away team:";
            this.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHomeTeam
            // 
            this.txtHomeTeam.BackColor = System.Drawing.Color.White;
            this.txtHomeTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHomeTeam.Location = new System.Drawing.Point(16, 89);
            this.txtHomeTeam.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomeTeam.Name = "txtHomeTeam";
            this.txtHomeTeam.Size = new System.Drawing.Size(207, 30);
            this.txtHomeTeam.TabIndex = 1;
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(14, 68);
            this.lblHomeTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(108, 23);
            this.lblHomeTeam.TabIndex = 0;
            this.lblHomeTeam.Text = "Home team:";
            this.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblControlsTitle
            // 
            this.lblControlsTitle.AutoSize = true;
            this.lblControlsTitle.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlsTitle.ForeColor = System.Drawing.Color.White;
            this.lblControlsTitle.Location = new System.Drawing.Point(11, 14);
            this.lblControlsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblControlsTitle.Name = "lblControlsTitle";
            this.lblControlsTitle.Size = new System.Drawing.Size(158, 49);
            this.lblControlsTitle.TabIndex = 1;
            this.lblControlsTitle.Text = "Controls";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnStats);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 81);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(202, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 57);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(105, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(8, 12);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(90, 57);
            this.btnStats.TabIndex = 0;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // pnlTitleContainer
            // 
            this.pnlTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(163)))), ((int)(((byte)(55)))));
            this.pnlTitleContainer.Controls.Add(this.lblTitleP2);
            this.pnlTitleContainer.Controls.Add(this.lblUEFATitle);
            this.pnlTitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleContainer.Name = "pnlTitleContainer";
            this.pnlTitleContainer.Size = new System.Drawing.Size(675, 75);
            this.pnlTitleContainer.TabIndex = 1;
            // 
            // lblTitleP2
            // 
            this.lblTitleP2.AutoSize = true;
            this.lblTitleP2.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleP2.ForeColor = System.Drawing.Color.White;
            this.lblTitleP2.Location = new System.Drawing.Point(136, 14);
            this.lblTitleP2.Name = "lblTitleP2";
            this.lblTitleP2.Size = new System.Drawing.Size(240, 49);
            this.lblTitleP2.TabIndex = 1;
            this.lblTitleP2.Text = "MicroNations";
            // 
            // lblUEFATitle
            // 
            this.lblUEFATitle.AutoSize = true;
            this.lblUEFATitle.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUEFATitle.ForeColor = System.Drawing.Color.White;
            this.lblUEFATitle.Location = new System.Drawing.Point(12, 14);
            this.lblUEFATitle.Name = "lblUEFATitle";
            this.lblUEFATitle.Size = new System.Drawing.Size(118, 49);
            this.lblUEFATitle.TabIndex = 0;
            this.lblUEFATitle.Text = "UEFA";
            // 
            // lstWindow
            // 
            this.lstWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHomeTeam,
            this.clmHomeGoals,
            this.clmColon,
            this.clmAwayGoals,
            this.clmAwayTeam});
            this.lstWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWindow.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWindow.HideSelection = false;
            this.lstWindow.Location = new System.Drawing.Point(0, 75);
            this.lstWindow.Margin = new System.Windows.Forms.Padding(2);
            this.lstWindow.Name = "lstWindow";
            this.lstWindow.Scrollable = false;
            this.lstWindow.Size = new System.Drawing.Size(675, 618);
            this.lstWindow.TabIndex = 1;
            this.lstWindow.UseCompatibleStateImageBehavior = false;
            this.lstWindow.View = System.Windows.Forms.View.Details;
            // 
            // clmHomeTeam
            // 
            this.clmHomeTeam.Text = "Home Team";
            this.clmHomeTeam.Width = 350;
            // 
            // clmHomeGoals
            // 
            this.clmHomeGoals.Text = "";
            this.clmHomeGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHomeGoals.Width = 55;
            // 
            // clmColon
            // 
            this.clmColon.Text = "Result";
            this.clmColon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmColon.Width = 90;
            // 
            // clmAwayGoals
            // 
            this.clmAwayGoals.Text = "";
            this.clmAwayGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmAwayGoals.Width = 55;
            // 
            // clmAwayTeam
            // 
            this.clmAwayTeam.Text = "Away Team";
            this.clmAwayTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmAwayTeam.Width = 350;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMaxGoalsValue
            // 
            this.lblMaxGoalsValue.AutoSize = true;
            this.lblMaxGoalsValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxGoalsValue.Location = new System.Drawing.Point(226, 67);
            this.lblMaxGoalsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxGoalsValue.Name = "lblMaxGoalsValue";
            this.lblMaxGoalsValue.Size = new System.Drawing.Size(21, 22);
            this.lblMaxGoalsValue.TabIndex = 11;
            this.lblMaxGoalsValue.Text = "0";
            this.lblMaxGoalsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotGoalsValue
            // 
            this.lblTotGoalsValue.AutoSize = true;
            this.lblTotGoalsValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotGoalsValue.Location = new System.Drawing.Point(226, 137);
            this.lblTotGoalsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotGoalsValue.Name = "lblTotGoalsValue";
            this.lblTotGoalsValue.Size = new System.Drawing.Size(21, 22);
            this.lblTotGoalsValue.TabIndex = 12;
            this.lblTotGoalsValue.Text = "0";
            this.lblTotGoalsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatchMostGoalsValue
            // 
            this.lblMatchMostGoalsValue.AutoSize = true;
            this.lblMatchMostGoalsValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchMostGoalsValue.Location = new System.Drawing.Point(226, 211);
            this.lblMatchMostGoalsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatchMostGoalsValue.Name = "lblMatchMostGoalsValue";
            this.lblMatchMostGoalsValue.Size = new System.Drawing.Size(21, 22);
            this.lblMatchMostGoalsValue.TabIndex = 13;
            this.lblMatchMostGoalsValue.Text = "0";
            this.lblMatchMostGoalsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 693);
            this.Controls.Add(this.lstWindow);
            this.Controls.Add(this.pnlTitleContainer);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "UEFA MicroNations";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearchFlag)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAwayGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHomeGoals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlTitleContainer.ResumeLayout(false);
            this.pnlTitleContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlTitleContainer;
        private System.Windows.Forms.Label lblTitleP2;
        private System.Windows.Forms.Label lblUEFATitle;
        private System.Windows.Forms.ListView lstWindow;
        private System.Windows.Forms.ColumnHeader clmHomeTeam;
        private System.Windows.Forms.ColumnHeader clmHomeGoals;
        private System.Windows.Forms.ColumnHeader clmColon;
        private System.Windows.Forms.ColumnHeader clmAwayGoals;
        private System.Windows.Forms.ColumnHeader clmAwayTeam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblControlsTitle;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.TextBox txtAwayTeam;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.TextBox txtHomeTeam;
        private System.Windows.Forms.NumericUpDown nmrHomeGoals;
        private System.Windows.Forms.Label lblHomeGoals;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.NumericUpDown nmrAwayGoals;
        private System.Windows.Forms.Label lblAwayGoals;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearchTeam;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pctSearchFlag;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblMaxGoalsScored;
        private System.Windows.Forms.Label lblMostGoalsMatch;
        private System.Windows.Forms.Label lblTotGoalsScored;
        private System.Windows.Forms.Label lblMatchMostGoalsValue;
        private System.Windows.Forms.Label lblTotGoalsValue;
        private System.Windows.Forms.Label lblMaxGoalsValue;
    }
}

