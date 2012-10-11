namespace QGen {
	partial class QuizEditor {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizEditor));
			this.mainmenu = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.miNew = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.miSave = new System.Windows.Forms.ToolStripMenuItem();
			this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.miQuizInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.miColorScheme = new System.Windows.Forms.ToolStripMenuItem();
			this.miTomato = new System.Windows.Forms.ToolStripMenuItem();
			this.miMango = new System.Windows.Forms.ToolStripMenuItem();
			this.miGreenApple = new System.Windows.Forms.ToolStripMenuItem();
			this.miSky = new System.Windows.Forms.ToolStripMenuItem();
			this.miDew = new System.Windows.Forms.ToolStripMenuItem();
			this.miPlum = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.openDialog = new System.Windows.Forms.OpenFileDialog();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPassing = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblItems = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPassingPercentile = new System.Windows.Forms.ToolStripStatusLabel();
			this.panelMain = new System.Windows.Forms.TableLayoutPanel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.panelBackground = new System.Windows.Forms.Panel();
			this.picboxTitle = new System.Windows.Forms.PictureBox();
			this.panelEdit = new System.Windows.Forms.TableLayoutPanel();
			this.panelEditHeader = new System.Windows.Forms.TableLayoutPanel();
			this.updownMinutes = new System.Windows.Forms.NumericUpDown();
			this.panelQuestionIndex = new System.Windows.Forms.Panel();
			this.updownQuestionIndex = new System.Windows.Forms.NumericUpDown();
			this.lblIndex = new System.Windows.Forms.Label();
			this.lblTimer = new System.Windows.Forms.Label();
			this.lblColon = new System.Windows.Forms.Label();
			this.updownHours = new System.Windows.Forms.NumericUpDown();
			this.lblHours = new System.Windows.Forms.Label();
			this.lblMinutes = new System.Windows.Forms.Label();
			this.panelEditMain = new System.Windows.Forms.SplitContainer();
			this.panelQuestion = new System.Windows.Forms.TableLayoutPanel();
			this.rbtn0 = new System.Windows.Forms.RadioButton();
			this.panel0 = new System.Windows.Forms.Panel();
			this.txtbox0 = new System.Windows.Forms.TextBox();
			this.rbtn1 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtbox1 = new System.Windows.Forms.TextBox();
			this.rbtn2 = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtbox2 = new System.Windows.Forms.TextBox();
			this.rbtn3 = new System.Windows.Forms.RadioButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtbox3 = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnAddMore = new System.Windows.Forms.Button();
			this.panelQuestionTextBox = new System.Windows.Forms.Panel();
			this.txtboxQuestion = new System.Windows.Forms.RichTextBox();
			this.panelFormatting = new System.Windows.Forms.TableLayoutPanel();
			this.btnUnderline = new System.Windows.Forms.CheckBox();
			this.btnBold = new System.Windows.Forms.CheckBox();
			this.btnItalic = new System.Windows.Forms.CheckBox();
			this.panelList = new System.Windows.Forms.TableLayoutPanel();
			this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.tabTest = new System.Windows.Forms.TabControl();
			this.pageMC = new System.Windows.Forms.TabPage();
			this.listboxMCQuestions = new System.Windows.Forms.ListView();
			this.indexMC = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.questionMC = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.aMC = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.bMC = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.cMC = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.dMC = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.correctAnswerMC = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.pageTF = new System.Windows.Forms.TabPage();
			this.listboxTFQuestions = new System.Windows.Forms.ListView();
			this.indexTF = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.questionTF = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.trueTF = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.falseTF = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
			this.panelDivider = new System.Windows.Forms.Panel();
			this.mainmenu.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.panelBackground.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).BeginInit();
			this.panelEdit.SuspendLayout();
			this.panelEditHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.updownMinutes)).BeginInit();
			this.panelQuestionIndex.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.updownQuestionIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.updownHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.panelEditMain)).BeginInit();
			this.panelEditMain.Panel1.SuspendLayout();
			this.panelEditMain.Panel2.SuspendLayout();
			this.panelEditMain.SuspendLayout();
			this.panelQuestion.SuspendLayout();
			this.panel0.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelQuestionTextBox.SuspendLayout();
			this.panelFormatting.SuspendLayout();
			this.panelList.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.tabTest.SuspendLayout();
			this.pageMC.SuspendLayout();
			this.pageTF.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainmenu
			// 
			this.mainmenu.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mainmenu.AutoSize = false;
			this.mainmenu.BackColor = System.Drawing.Color.Gold;
			this.mainmenu.Dock = System.Windows.Forms.DockStyle.None;
			this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuHelp});
			this.mainmenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.mainmenu.Location = new System.Drawing.Point(248, 97);
			this.mainmenu.Name = "mainmenu";
			this.mainmenu.Size = new System.Drawing.Size(175, 28);
			this.mainmenu.TabIndex = 4;
			this.mainmenu.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.BackColor = System.Drawing.Color.LemonChiffon;
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.toolStripSeparator1,
            this.miOpen,
            this.toolStripSeparator2,
            this.miSave,
            this.miSaveAs,
            this.exitToolStripMenuItem,
            this.miQuizInfo,
            this.toolStripSeparator3,
            this.miExit});
			this.menuFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.menuFile.ForeColor = System.Drawing.Color.Black;
			this.menuFile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(43, 24);
			this.menuFile.Text = "&File";
			// 
			// miNew
			// 
			this.miNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miNew.ForeColor = System.Drawing.Color.Black;
			this.miNew.Name = "miNew";
			this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.miNew.Size = new System.Drawing.Size(188, 22);
			this.miNew.Text = "&New";
			this.miNew.ToolTipText = "Creates a new quiz with blank questions.";
			this.miNew.Click += new System.EventHandler(this.miNew_Click);
			this.miNew.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miNew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
			// 
			// miOpen
			// 
			this.miOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miOpen.ForeColor = System.Drawing.Color.Black;
			this.miOpen.Name = "miOpen";
			this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.miOpen.Size = new System.Drawing.Size(188, 22);
			this.miOpen.Text = "&Open";
			this.miOpen.ToolTipText = "Opens an existing quiz.";
			this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
			this.miOpen.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miOpen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
			// 
			// miSave
			// 
			this.miSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miSave.ForeColor = System.Drawing.Color.Black;
			this.miSave.Name = "miSave";
			this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.miSave.Size = new System.Drawing.Size(188, 22);
			this.miSave.Text = "&Save";
			this.miSave.ToolTipText = "Saves the current quiz file.";
			this.miSave.Click += new System.EventHandler(this.miSave_Click);
			this.miSave.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// miSaveAs
			// 
			this.miSaveAs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miSaveAs.ForeColor = System.Drawing.Color.Black;
			this.miSaveAs.Name = "miSaveAs";
			this.miSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.S)));
			this.miSaveAs.Size = new System.Drawing.Size(188, 22);
			this.miSaveAs.Text = "Save &As";
			this.miSaveAs.ToolTipText = "Saves the current quiz file in a new name.";
			this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
			this.miSaveAs.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miSaveAs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 6);
			// 
			// miQuizInfo
			// 
			this.miQuizInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miQuizInfo.ForeColor = System.Drawing.Color.Black;
			this.miQuizInfo.Name = "miQuizInfo";
			this.miQuizInfo.Size = new System.Drawing.Size(188, 22);
			this.miQuizInfo.Text = "Quiz Information";
			this.miQuizInfo.ToolTipText = "Shows the quiz information.";
			this.miQuizInfo.Click += new System.EventHandler(this.miQuizInfo_Click);
			this.miQuizInfo.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miQuizInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
			// 
			// miExit
			// 
			this.miExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miExit.ForeColor = System.Drawing.Color.Black;
			this.miExit.Name = "miExit";
			this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.miExit.Size = new System.Drawing.Size(188, 22);
			this.miExit.Text = "E&xit";
			this.miExit.ToolTipText = "Exits Quiz Editor.";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			this.miExit.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// menuView
			// 
			this.menuView.BackColor = System.Drawing.Color.LemonChiffon;
			this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miColorScheme});
			this.menuView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.menuView.ForeColor = System.Drawing.Color.Black;
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(52, 24);
			this.menuView.Text = "&View";
			// 
			// miColorScheme
			// 
			this.miColorScheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTomato,
            this.miMango,
            this.miGreenApple,
            this.miSky,
            this.miDew,
            this.miPlum});
			this.miColorScheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miColorScheme.ForeColor = System.Drawing.Color.Black;
			this.miColorScheme.Name = "miColorScheme";
			this.miColorScheme.Size = new System.Drawing.Size(194, 22);
			this.miColorScheme.Text = "Change Color Scheme";
			// 
			// miTomato
			// 
			this.miTomato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miTomato.ForeColor = System.Drawing.Color.Black;
			this.miTomato.Name = "miTomato";
			this.miTomato.Size = new System.Drawing.Size(139, 22);
			this.miTomato.Text = "Tomato";
			this.miTomato.ToolTipText = "Changes color scheme to Tomato.";
			this.miTomato.Click += new System.EventHandler(this.miTomato_Click);
			this.miTomato.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miTomato.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// miMango
			// 
			this.miMango.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miMango.ForeColor = System.Drawing.Color.Black;
			this.miMango.Name = "miMango";
			this.miMango.Size = new System.Drawing.Size(139, 22);
			this.miMango.Text = "Mango";
			this.miMango.ToolTipText = "Changes color scheme to Mango.";
			this.miMango.Click += new System.EventHandler(this.miMango_Click);
			this.miMango.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miMango.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// miGreenApple
			// 
			this.miGreenApple.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miGreenApple.ForeColor = System.Drawing.Color.Black;
			this.miGreenApple.Name = "miGreenApple";
			this.miGreenApple.Size = new System.Drawing.Size(139, 22);
			this.miGreenApple.Text = "Green Apple";
			this.miGreenApple.ToolTipText = "Changes color scheme to Green Apple.";
			this.miGreenApple.Click += new System.EventHandler(this.miGreenApple_Click);
			this.miGreenApple.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miGreenApple.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// miSky
			// 
			this.miSky.ForeColor = System.Drawing.Color.Black;
			this.miSky.Name = "miSky";
			this.miSky.Size = new System.Drawing.Size(139, 22);
			this.miSky.Text = "Sky";
			this.miSky.ToolTipText = "Changes color scheme to Sky.";
			this.miSky.Click += new System.EventHandler(this.miSky_Click);
			this.miSky.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miSky.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// miDew
			// 
			this.miDew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.miDew.ForeColor = System.Drawing.Color.Black;
			this.miDew.Name = "miDew";
			this.miDew.Size = new System.Drawing.Size(139, 22);
			this.miDew.Text = "Dew";
			this.miDew.ToolTipText = "Changes color scheme to Dew.";
			this.miDew.Click += new System.EventHandler(this.miDew_Click);
			this.miDew.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miDew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// miPlum
			// 
			this.miPlum.Name = "miPlum";
			this.miPlum.Size = new System.Drawing.Size(139, 22);
			this.miPlum.Text = "Plum";
			this.miPlum.ToolTipText = "Changes color scheme to Dew.";
			this.miPlum.Click += new System.EventHandler(this.miPlum_Click);
			this.miPlum.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miPlum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// menuHelp
			// 
			this.menuHelp.BackColor = System.Drawing.Color.LemonChiffon;
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
			this.menuHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic);
			this.menuHelp.ForeColor = System.Drawing.Color.Black;
			this.menuHelp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(51, 24);
			this.menuHelp.Text = "&Help";
			// 
			// miAbout
			// 
			this.miAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.miAbout.ForeColor = System.Drawing.Color.Black;
			this.miAbout.Name = "miAbout";
			this.miAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.miAbout.Size = new System.Drawing.Size(128, 22);
			this.miAbout.Text = "&About";
			this.miAbout.ToolTipText = "Show the details, version number and license info of Quiz Editor.";
			this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
			this.miAbout.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
			this.miAbout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuItem_MouseMove);
			// 
			// saveDialog
			// 
			this.saveDialog.DefaultExt = "qqf";
			this.saveDialog.FileName = "*.qqf";
			this.saveDialog.Filter = "QGen Quiz files|*.qqf";
			this.saveDialog.RestoreDirectory = true;
			this.saveDialog.SupportMultiDottedExtensions = true;
			this.saveDialog.Title = "Save File As...";
			// 
			// openDialog
			// 
			this.openDialog.DefaultExt = "qqf";
			this.openDialog.FileName = "*.qqf";
			this.openDialog.Filter = "QGen Quiz files|*.qqf";
			this.openDialog.RestoreDirectory = true;
			this.openDialog.SupportMultiDottedExtensions = true;
			this.openDialog.Title = "Open File...";
			// 
			// statusBar
			// 
			this.statusBar.BackColor = System.Drawing.SystemColors.Control;
			this.statusBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblPassing,
            this.lblItems,
            this.lblPassingPercentile});
			this.statusBar.Location = new System.Drawing.Point(0, 465);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(496, 25);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 19;
			this.statusBar.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(339, 20);
			this.lblStatus.Spring = true;
			this.lblStatus.Text = "Welcome to QGen Quiz Editor.";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPassing
			// 
			this.lblPassing.Name = "lblPassing";
			this.lblPassing.Size = new System.Drawing.Size(61, 20);
			this.lblPassing.Text = "Passing:";
			this.lblPassing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblItems
			// 
			this.lblItems.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblItems.Name = "lblItems";
			this.lblItems.Size = new System.Drawing.Size(34, 20);
			this.lblItems.Text = "0/0";
			// 
			// lblPassingPercentile
			// 
			this.lblPassingPercentile.Name = "lblPassingPercentile";
			this.lblPassingPercentile.Size = new System.Drawing.Size(47, 20);
			this.lblPassingPercentile.Text = "(50%)";
			// 
			// panelMain
			// 
			this.panelMain.ColumnCount = 1;
			this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelMain.Controls.Add(this.panelHeader, 0, 0);
			this.panelMain.Controls.Add(this.panelEdit, 0, 1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.RowCount = 2;
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelMain.Size = new System.Drawing.Size(496, 465);
			this.panelMain.TabIndex = 22;
			// 
			// panelHeader
			// 
			this.panelHeader.BackgroundImage = global::QGen.Properties.Resources.BackdropHorizontal;
			this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelHeader.Controls.Add(this.panelBackground);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(496, 128);
			this.panelHeader.TabIndex = 22;
			// 
			// panelBackground
			// 
			this.panelBackground.BackColor = System.Drawing.Color.Transparent;
			this.panelBackground.BackgroundImage = global::QGen.Properties.Resources.QGen_Theme1_BG;
			this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBackground.Controls.Add(this.picboxTitle);
			this.panelBackground.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelBackground.Location = new System.Drawing.Point(158, 0);
			this.panelBackground.Name = "panelBackground";
			this.panelBackground.Size = new System.Drawing.Size(338, 128);
			this.panelBackground.TabIndex = 2;
			// 
			// picboxTitle
			// 
			this.picboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picboxTitle.BackColor = System.Drawing.Color.Gold;
			this.picboxTitle.Image = global::QGen.Properties.Resources.QGen_Small;
			this.picboxTitle.Location = new System.Drawing.Point(34, 47);
			this.picboxTitle.Margin = new System.Windows.Forms.Padding(0);
			this.picboxTitle.Name = "picboxTitle";
			this.picboxTitle.Padding = new System.Windows.Forms.Padding(8);
			this.picboxTitle.Size = new System.Drawing.Size(304, 64);
			this.picboxTitle.TabIndex = 1;
			this.picboxTitle.TabStop = false;
			// 
			// panelEdit
			// 
			this.panelEdit.BackColor = System.Drawing.Color.White;
			this.panelEdit.ColumnCount = 1;
			this.panelEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelEdit.Controls.Add(this.panelEditHeader, 0, 0);
			this.panelEdit.Controls.Add(this.panelEditMain, 0, 1);
			this.panelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEdit.Location = new System.Drawing.Point(0, 128);
			this.panelEdit.Margin = new System.Windows.Forms.Padding(0);
			this.panelEdit.Name = "panelEdit";
			this.panelEdit.RowCount = 2;
			this.panelEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
			this.panelEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelEdit.Size = new System.Drawing.Size(496, 337);
			this.panelEdit.TabIndex = 21;
			// 
			// panelEditHeader
			// 
			this.panelEditHeader.BackColor = System.Drawing.Color.Transparent;
			this.panelEditHeader.ColumnCount = 5;
			this.panelEditHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelEditHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
			this.panelEditHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.panelEditHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
			this.panelEditHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.panelEditHeader.Controls.Add(this.updownMinutes, 4, 0);
			this.panelEditHeader.Controls.Add(this.panelQuestionIndex, 0, 0);
			this.panelEditHeader.Controls.Add(this.lblTimer, 1, 0);
			this.panelEditHeader.Controls.Add(this.lblColon, 3, 0);
			this.panelEditHeader.Controls.Add(this.updownHours, 2, 0);
			this.panelEditHeader.Controls.Add(this.lblHours, 2, 1);
			this.panelEditHeader.Controls.Add(this.lblMinutes, 4, 1);
			this.panelEditHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEditHeader.Location = new System.Drawing.Point(8, 32);
			this.panelEditHeader.Margin = new System.Windows.Forms.Padding(8, 32, 8, 0);
			this.panelEditHeader.Name = "panelEditHeader";
			this.panelEditHeader.RowCount = 2;
			this.panelEditHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelEditHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelEditHeader.Size = new System.Drawing.Size(480, 56);
			this.panelEditHeader.TabIndex = 6;
			// 
			// updownMinutes
			// 
			this.updownMinutes.BackColor = System.Drawing.SystemColors.Window;
			this.updownMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.updownMinutes.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.updownMinutes.ForeColor = System.Drawing.Color.Black;
			this.updownMinutes.Location = new System.Drawing.Point(418, 3);
			this.updownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.updownMinutes.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.updownMinutes.Name = "updownMinutes";
			this.updownMinutes.Size = new System.Drawing.Size(59, 25);
			this.updownMinutes.TabIndex = 2;
			this.updownMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.updownMinutes.ValueChanged += new System.EventHandler(this.updownMinutes_ValueChanged);
			// 
			// panelQuestionIndex
			// 
			this.panelQuestionIndex.BackColor = System.Drawing.Color.Transparent;
			this.panelQuestionIndex.Controls.Add(this.updownQuestionIndex);
			this.panelQuestionIndex.Controls.Add(this.lblIndex);
			this.panelQuestionIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelQuestionIndex.Location = new System.Drawing.Point(3, 3);
			this.panelQuestionIndex.Name = "panelQuestionIndex";
			this.panelEditHeader.SetRowSpan(this.panelQuestionIndex, 2);
			this.panelQuestionIndex.Size = new System.Drawing.Size(256, 50);
			this.panelQuestionIndex.TabIndex = 0;
			// 
			// updownQuestionIndex
			// 
			this.updownQuestionIndex.BackColor = System.Drawing.SystemColors.Window;
			this.updownQuestionIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.updownQuestionIndex.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.updownQuestionIndex.ForeColor = System.Drawing.Color.Black;
			this.updownQuestionIndex.Location = new System.Drawing.Point(136, 3);
			this.updownQuestionIndex.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.updownQuestionIndex.Name = "updownQuestionIndex";
			this.updownQuestionIndex.Size = new System.Drawing.Size(105, 39);
			this.updownQuestionIndex.TabIndex = 0;
			this.updownQuestionIndex.ValueChanged += new System.EventHandler(this.updownQuestionIndex_ValueChanged);
			// 
			// lblIndex
			// 
			this.lblIndex.AutoSize = true;
			this.lblIndex.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
			this.lblIndex.ForeColor = System.Drawing.Color.Black;
			this.lblIndex.Location = new System.Drawing.Point(3, 3);
			this.lblIndex.Name = "lblIndex";
			this.lblIndex.Size = new System.Drawing.Size(141, 37);
			this.lblIndex.TabIndex = 0;
			this.lblIndex.Text = "Question #";
			this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14.25F);
			this.lblTimer.ForeColor = System.Drawing.Color.Black;
			this.lblTimer.Location = new System.Drawing.Point(265, 0);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(68, 28);
			this.lblTimer.TabIndex = 1;
			this.lblTimer.Text = "Timer";
			this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblColon
			// 
			this.lblColon.AutoSize = true;
			this.lblColon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblColon.Font = new System.Drawing.Font("Segoe UI", 14.25F);
			this.lblColon.ForeColor = System.Drawing.Color.Black;
			this.lblColon.Location = new System.Drawing.Point(399, 0);
			this.lblColon.Name = "lblColon";
			this.lblColon.Size = new System.Drawing.Size(13, 28);
			this.lblColon.TabIndex = 4;
			this.lblColon.Text = ":";
			// 
			// updownHours
			// 
			this.updownHours.BackColor = System.Drawing.SystemColors.Window;
			this.updownHours.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.updownHours.ForeColor = System.Drawing.Color.Black;
			this.updownHours.Location = new System.Drawing.Point(339, 3);
			this.updownHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.updownHours.Name = "updownHours";
			this.updownHours.Size = new System.Drawing.Size(54, 25);
			this.updownHours.TabIndex = 1;
			this.updownHours.ValueChanged += new System.EventHandler(this.updownHours_ValueChanged);
			// 
			// lblHours
			// 
			this.lblHours.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHours.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblHours.ForeColor = System.Drawing.Color.Black;
			this.lblHours.Location = new System.Drawing.Point(339, 28);
			this.lblHours.Name = "lblHours";
			this.lblHours.Size = new System.Drawing.Size(54, 28);
			this.lblHours.TabIndex = 5;
			this.lblHours.Text = "hours";
			// 
			// lblMinutes
			// 
			this.lblMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblMinutes.ForeColor = System.Drawing.Color.Black;
			this.lblMinutes.Location = new System.Drawing.Point(418, 28);
			this.lblMinutes.Name = "lblMinutes";
			this.lblMinutes.Size = new System.Drawing.Size(59, 28);
			this.lblMinutes.TabIndex = 6;
			this.lblMinutes.Text = "minutes";
			// 
			// panelEditMain
			// 
			this.panelEditMain.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelEditMain.BackColor = System.Drawing.Color.Transparent;
			this.panelEditMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.panelEditMain.Location = new System.Drawing.Point(8, 96);
			this.panelEditMain.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.panelEditMain.Name = "panelEditMain";
			// 
			// panelEditMain.Panel1
			// 
			this.panelEditMain.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.panelEditMain.Panel1.Controls.Add(this.panelQuestion);
			this.panelEditMain.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.panelEditMain.Panel1MinSize = 272;
			// 
			// panelEditMain.Panel2
			// 
			this.panelEditMain.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.panelEditMain.Panel2.Controls.Add(this.panelList);
			this.panelEditMain.Panel2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.panelEditMain.Panel2MinSize = 200;
			this.panelEditMain.Size = new System.Drawing.Size(480, 241);
			this.panelEditMain.SplitterDistance = 272;
			this.panelEditMain.SplitterWidth = 8;
			this.panelEditMain.TabIndex = 18;
			// 
			// panelQuestion
			// 
			this.panelQuestion.ColumnCount = 5;
			this.panelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.panelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
			this.panelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.panelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.panelQuestion.Controls.Add(this.rbtn0, 0, 2);
			this.panelQuestion.Controls.Add(this.panel0, 1, 2);
			this.panelQuestion.Controls.Add(this.rbtn1, 0, 3);
			this.panelQuestion.Controls.Add(this.panel1, 1, 3);
			this.panelQuestion.Controls.Add(this.rbtn2, 0, 4);
			this.panelQuestion.Controls.Add(this.panel2, 1, 4);
			this.panelQuestion.Controls.Add(this.rbtn3, 0, 5);
			this.panelQuestion.Controls.Add(this.panel3, 1, 5);
			this.panelQuestion.Controls.Add(this.btnAdd, 3, 6);
			this.panelQuestion.Controls.Add(this.btnAddMore, 2, 6);
			this.panelQuestion.Controls.Add(this.panelQuestionTextBox, 0, 0);
			this.panelQuestion.Controls.Add(this.panelFormatting, 4, 0);
			this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelQuestion.Location = new System.Drawing.Point(0, 0);
			this.panelQuestion.Name = "panelQuestion";
			this.panelQuestion.RowCount = 7;
			this.panelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.panelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.panelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.panelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.panelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.panelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.panelQuestion.Size = new System.Drawing.Size(268, 241);
			this.panelQuestion.TabIndex = 2;
			// 
			// rbtn0
			// 
			this.rbtn0.AutoSize = true;
			this.rbtn0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbtn0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.rbtn0.ForeColor = System.Drawing.Color.Black;
			this.rbtn0.Location = new System.Drawing.Point(3, 111);
			this.rbtn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtn0.Name = "rbtn0";
			this.rbtn0.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.rbtn0.Size = new System.Drawing.Size(74, 21);
			this.rbtn0.TabIndex = 6;
			this.rbtn0.Text = "A";
			this.rbtn0.UseVisualStyleBackColor = true;
			this.rbtn0.CheckedChanged += new System.EventHandler(this.radiobutton_CheckedChanged);
			// 
			// panel0
			// 
			this.panelQuestion.SetColumnSpan(this.panel0, 4);
			this.panel0.Controls.Add(this.txtbox0);
			this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel0.Location = new System.Drawing.Point(80, 109);
			this.panel0.Margin = new System.Windows.Forms.Padding(0);
			this.panel0.Name = "panel0";
			this.panel0.Size = new System.Drawing.Size(188, 25);
			this.panel0.TabIndex = 15;
			// 
			// txtbox0
			// 
			this.txtbox0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtbox0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtbox0.ForeColor = System.Drawing.Color.Black;
			this.txtbox0.Location = new System.Drawing.Point(0, 0);
			this.txtbox0.Margin = new System.Windows.Forms.Padding(0);
			this.txtbox0.Name = "txtbox0";
			this.txtbox0.Size = new System.Drawing.Size(188, 25);
			this.txtbox0.TabIndex = 10;
			this.txtbox0.TextChanged += new System.EventHandler(this.textbox_TextChanged);
			// 
			// rbtn1
			// 
			this.rbtn1.AutoSize = true;
			this.rbtn1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbtn1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.rbtn1.ForeColor = System.Drawing.Color.Black;
			this.rbtn1.Location = new System.Drawing.Point(3, 136);
			this.rbtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtn1.Name = "rbtn1";
			this.rbtn1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.rbtn1.Size = new System.Drawing.Size(74, 21);
			this.rbtn1.TabIndex = 7;
			this.rbtn1.Text = "B";
			this.rbtn1.UseVisualStyleBackColor = true;
			this.rbtn1.CheckedChanged += new System.EventHandler(this.radiobutton_CheckedChanged);
			// 
			// panel1
			// 
			this.panelQuestion.SetColumnSpan(this.panel1, 4);
			this.panel1.Controls.Add(this.txtbox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(80, 134);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(188, 25);
			this.panel1.TabIndex = 16;
			// 
			// txtbox1
			// 
			this.txtbox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtbox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtbox1.ForeColor = System.Drawing.Color.Black;
			this.txtbox1.Location = new System.Drawing.Point(0, 0);
			this.txtbox1.Margin = new System.Windows.Forms.Padding(0);
			this.txtbox1.Name = "txtbox1";
			this.txtbox1.Size = new System.Drawing.Size(188, 25);
			this.txtbox1.TabIndex = 11;
			this.txtbox1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
			// 
			// rbtn2
			// 
			this.rbtn2.AutoSize = true;
			this.rbtn2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbtn2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.rbtn2.ForeColor = System.Drawing.Color.Black;
			this.rbtn2.Location = new System.Drawing.Point(3, 161);
			this.rbtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtn2.Name = "rbtn2";
			this.rbtn2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.rbtn2.Size = new System.Drawing.Size(74, 21);
			this.rbtn2.TabIndex = 8;
			this.rbtn2.Text = "C";
			this.rbtn2.UseVisualStyleBackColor = true;
			this.rbtn2.CheckedChanged += new System.EventHandler(this.radiobutton_CheckedChanged);
			// 
			// panel2
			// 
			this.panelQuestion.SetColumnSpan(this.panel2, 4);
			this.panel2.Controls.Add(this.txtbox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(80, 159);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(188, 25);
			this.panel2.TabIndex = 17;
			// 
			// txtbox2
			// 
			this.txtbox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtbox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtbox2.ForeColor = System.Drawing.Color.Black;
			this.txtbox2.Location = new System.Drawing.Point(0, 0);
			this.txtbox2.Margin = new System.Windows.Forms.Padding(0);
			this.txtbox2.Name = "txtbox2";
			this.txtbox2.Size = new System.Drawing.Size(188, 25);
			this.txtbox2.TabIndex = 12;
			this.txtbox2.TextChanged += new System.EventHandler(this.textbox_TextChanged);
			// 
			// rbtn3
			// 
			this.rbtn3.AutoSize = true;
			this.rbtn3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbtn3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.rbtn3.ForeColor = System.Drawing.Color.Black;
			this.rbtn3.Location = new System.Drawing.Point(3, 186);
			this.rbtn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtn3.Name = "rbtn3";
			this.rbtn3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.rbtn3.Size = new System.Drawing.Size(74, 21);
			this.rbtn3.TabIndex = 9;
			this.rbtn3.Text = "D";
			this.rbtn3.UseVisualStyleBackColor = true;
			this.rbtn3.CheckedChanged += new System.EventHandler(this.radiobutton_CheckedChanged);
			// 
			// panel3
			// 
			this.panelQuestion.SetColumnSpan(this.panel3, 4);
			this.panel3.Controls.Add(this.txtbox3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(80, 184);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(188, 25);
			this.panel3.TabIndex = 18;
			// 
			// txtbox3
			// 
			this.txtbox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtbox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtbox3.ForeColor = System.Drawing.Color.Black;
			this.txtbox3.Location = new System.Drawing.Point(0, 0);
			this.txtbox3.Margin = new System.Windows.Forms.Padding(0);
			this.txtbox3.Name = "txtbox3";
			this.txtbox3.Size = new System.Drawing.Size(188, 25);
			this.txtbox3.TabIndex = 13;
			this.txtbox3.TextChanged += new System.EventHandler(this.textbox_TextChanged);
			// 
			// btnAdd
			// 
			this.panelQuestion.SetColumnSpan(this.btnAdd, 2);
			this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.Location = new System.Drawing.Point(199, 212);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(66, 26);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnAddMore
			// 
			this.btnAddMore.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAddMore.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.btnAddMore.ForeColor = System.Drawing.Color.Black;
			this.btnAddMore.Location = new System.Drawing.Point(127, 212);
			this.btnAddMore.Name = "btnAddMore";
			this.btnAddMore.Size = new System.Drawing.Size(66, 26);
			this.btnAddMore.TabIndex = 14;
			this.btnAddMore.Text = "Add More";
			this.btnAddMore.UseVisualStyleBackColor = true;
			this.btnAddMore.Visible = false;
			this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
			// 
			// panelQuestionTextBox
			// 
			this.panelQuestionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelQuestion.SetColumnSpan(this.panelQuestionTextBox, 4);
			this.panelQuestionTextBox.Controls.Add(this.txtboxQuestion);
			this.panelQuestionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelQuestionTextBox.Location = new System.Drawing.Point(0, 0);
			this.panelQuestionTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 8, 5);
			this.panelQuestionTextBox.Name = "panelQuestionTextBox";
			this.panelQuestionTextBox.Padding = new System.Windows.Forms.Padding(1);
			this.panelQuestion.SetRowSpan(this.panelQuestionTextBox, 2);
			this.panelQuestionTextBox.Size = new System.Drawing.Size(228, 104);
			this.panelQuestionTextBox.TabIndex = 19;
			// 
			// txtboxQuestion
			// 
			this.txtboxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtboxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtboxQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtboxQuestion.Location = new System.Drawing.Point(1, 1);
			this.txtboxQuestion.Margin = new System.Windows.Forms.Padding(1);
			this.txtboxQuestion.Name = "txtboxQuestion";
			this.txtboxQuestion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.txtboxQuestion.Size = new System.Drawing.Size(224, 100);
			this.txtboxQuestion.TabIndex = 20;
			this.txtboxQuestion.Text = "";
			this.txtboxQuestion.SelectionChanged += new System.EventHandler(this.txtboxQuestion_SelectionChanged);
			this.txtboxQuestion.TextChanged += new System.EventHandler(this.textbox_TextChanged);
			// 
			// panelFormatting
			// 
			this.panelFormatting.ColumnCount = 1;
			this.panelFormatting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelFormatting.Controls.Add(this.btnUnderline, 0, 2);
			this.panelFormatting.Controls.Add(this.btnBold, 0, 0);
			this.panelFormatting.Controls.Add(this.btnItalic, 0, 1);
			this.panelFormatting.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelFormatting.Location = new System.Drawing.Point(236, 0);
			this.panelFormatting.Margin = new System.Windows.Forms.Padding(0);
			this.panelFormatting.Name = "panelFormatting";
			this.panelFormatting.RowCount = 3;
			this.panelQuestion.SetRowSpan(this.panelFormatting, 2);
			this.panelFormatting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelFormatting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelFormatting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelFormatting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.panelFormatting.Size = new System.Drawing.Size(32, 100);
			this.panelFormatting.TabIndex = 20;
			// 
			// btnUnderline
			// 
			this.btnUnderline.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnUnderline.AutoSize = true;
			this.btnUnderline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnUnderline.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.btnUnderline.Location = new System.Drawing.Point(0, 66);
			this.btnUnderline.Margin = new System.Windows.Forms.Padding(0);
			this.btnUnderline.Name = "btnUnderline";
			this.btnUnderline.Size = new System.Drawing.Size(32, 34);
			this.btnUnderline.TabIndex = 2;
			this.btnUnderline.Text = "U";
			this.btnUnderline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnUnderline.UseVisualStyleBackColor = true;
			this.btnUnderline.CheckedChanged += new System.EventHandler(this.btnUnderline_CheckedChanged);
			this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
			// 
			// btnBold
			// 
			this.btnBold.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnBold.AutoSize = true;
			this.btnBold.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBold.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.btnBold.Location = new System.Drawing.Point(0, 0);
			this.btnBold.Margin = new System.Windows.Forms.Padding(0);
			this.btnBold.Name = "btnBold";
			this.btnBold.Size = new System.Drawing.Size(32, 33);
			this.btnBold.TabIndex = 0;
			this.btnBold.Text = "B";
			this.btnBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBold.UseVisualStyleBackColor = true;
			this.btnBold.CheckedChanged += new System.EventHandler(this.btnBold_CheckedChanged);
			this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
			// 
			// btnItalic
			// 
			this.btnItalic.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnItalic.AutoSize = true;
			this.btnItalic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnItalic.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.btnItalic.Location = new System.Drawing.Point(0, 33);
			this.btnItalic.Margin = new System.Windows.Forms.Padding(0);
			this.btnItalic.Name = "btnItalic";
			this.btnItalic.Size = new System.Drawing.Size(32, 33);
			this.btnItalic.TabIndex = 1;
			this.btnItalic.Text = "I";
			this.btnItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnItalic.UseVisualStyleBackColor = true;
			this.btnItalic.CheckedChanged += new System.EventHandler(this.btnItalic_CheckedChanged);
			this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
			// 
			// panelList
			// 
			this.panelList.ColumnCount = 1;
			this.panelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.panelList.Controls.Add(this.panelButtons, 0, 1);
			this.panelList.Controls.Add(this.tabTest, 0, 0);
			this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(4, 0);
			this.panelList.Margin = new System.Windows.Forms.Padding(0);
			this.panelList.Name = "panelList";
			this.panelList.RowCount = 2;
			this.panelList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.panelList.Size = new System.Drawing.Size(200, 241);
			this.panelList.TabIndex = 0;
			// 
			// panelButtons
			// 
			this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelButtons.ColumnCount = 3;
			this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelButtons.Controls.Add(this.btnClear, 2, 0);
			this.panelButtons.Controls.Add(this.btnRemove, 1, 0);
			this.panelButtons.Controls.Add(this.btnEdit, 0, 0);
			this.panelButtons.Location = new System.Drawing.Point(4, 209);
			this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.RowCount = 1;
			this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.panelButtons.Size = new System.Drawing.Size(196, 32);
			this.panelButtons.TabIndex = 0;
			// 
			// btnClear
			// 
			this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.btnClear.ForeColor = System.Drawing.Color.Black;
			this.btnClear.Location = new System.Drawing.Point(133, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(60, 26);
			this.btnClear.TabIndex = 0;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRemove.Enabled = false;
			this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.btnRemove.ForeColor = System.Drawing.Color.Black;
			this.btnRemove.Location = new System.Drawing.Point(68, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(59, 26);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEdit.Enabled = false;
			this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.btnEdit.ForeColor = System.Drawing.Color.Black;
			this.btnEdit.Location = new System.Drawing.Point(3, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(59, 26);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// tabTest
			// 
			this.tabTest.Controls.Add(this.pageMC);
			this.tabTest.Controls.Add(this.pageTF);
			this.tabTest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabTest.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.tabTest.Location = new System.Drawing.Point(0, 0);
			this.tabTest.Margin = new System.Windows.Forms.Padding(0);
			this.tabTest.Name = "tabTest";
			this.tabTest.Padding = new System.Drawing.Point(0, 0);
			this.tabTest.SelectedIndex = 0;
			this.tabTest.Size = new System.Drawing.Size(200, 209);
			this.tabTest.TabIndex = 1;
			this.tabTest.SelectedIndexChanged += new System.EventHandler(this.tabTest_SelectedIndexChanged);
			// 
			// pageMC
			// 
			this.pageMC.Controls.Add(this.listboxMCQuestions);
			this.pageMC.Location = new System.Drawing.Point(4, 22);
			this.pageMC.Margin = new System.Windows.Forms.Padding(0);
			this.pageMC.Name = "pageMC";
			this.pageMC.Size = new System.Drawing.Size(192, 183);
			this.pageMC.TabIndex = 0;
			this.pageMC.Text = "Multiple Choice";
			this.pageMC.UseVisualStyleBackColor = true;
			// 
			// listboxMCQuestions
			// 
			this.listboxMCQuestions.CheckBoxes = true;
			this.listboxMCQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexMC,
            this.questionMC,
            this.aMC,
            this.bMC,
            this.cMC,
            this.dMC,
            this.correctAnswerMC});
			this.listboxMCQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listboxMCQuestions.ForeColor = System.Drawing.Color.Black;
			this.listboxMCQuestions.FullRowSelect = true;
			this.listboxMCQuestions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listboxMCQuestions.HideSelection = false;
			this.listboxMCQuestions.Location = new System.Drawing.Point(0, 0);
			this.listboxMCQuestions.Margin = new System.Windows.Forms.Padding(0);
			this.listboxMCQuestions.MultiSelect = false;
			this.listboxMCQuestions.Name = "listboxMCQuestions";
			this.listboxMCQuestions.ShowItemToolTips = true;
			this.listboxMCQuestions.Size = new System.Drawing.Size(192, 183);
			this.listboxMCQuestions.TabIndex = 0;
			this.listboxMCQuestions.UseCompatibleStateImageBehavior = false;
			this.listboxMCQuestions.View = System.Windows.Forms.View.Details;
			this.listboxMCQuestions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listbox_ItemChecked);
			this.listboxMCQuestions.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
			// 
			// indexMC
			// 
			this.indexMC.Text = "#";
			// 
			// questionMC
			// 
			this.questionMC.Text = "Question";
			// 
			// aMC
			// 
			this.aMC.Text = "A";
			// 
			// bMC
			// 
			this.bMC.Text = "B";
			// 
			// cMC
			// 
			this.cMC.Text = "C";
			// 
			// dMC
			// 
			this.dMC.Text = "D";
			// 
			// correctAnswerMC
			// 
			this.correctAnswerMC.Text = "Correct Answer";
			// 
			// pageTF
			// 
			this.pageTF.Controls.Add(this.listboxTFQuestions);
			this.pageTF.Location = new System.Drawing.Point(4, 22);
			this.pageTF.Margin = new System.Windows.Forms.Padding(0);
			this.pageTF.Name = "pageTF";
			this.pageTF.Size = new System.Drawing.Size(188, 183);
			this.pageTF.TabIndex = 1;
			this.pageTF.Text = "True or False";
			this.pageTF.UseVisualStyleBackColor = true;
			// 
			// listboxTFQuestions
			// 
			this.listboxTFQuestions.CheckBoxes = true;
			this.listboxTFQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexTF,
            this.questionTF,
            this.trueTF,
            this.falseTF});
			this.listboxTFQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listboxTFQuestions.ForeColor = System.Drawing.Color.Black;
			this.listboxTFQuestions.FullRowSelect = true;
			this.listboxTFQuestions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listboxTFQuestions.Location = new System.Drawing.Point(0, 0);
			this.listboxTFQuestions.Margin = new System.Windows.Forms.Padding(0);
			this.listboxTFQuestions.MultiSelect = false;
			this.listboxTFQuestions.Name = "listboxTFQuestions";
			this.listboxTFQuestions.ShowItemToolTips = true;
			this.listboxTFQuestions.Size = new System.Drawing.Size(188, 183);
			this.listboxTFQuestions.TabIndex = 1;
			this.listboxTFQuestions.UseCompatibleStateImageBehavior = false;
			this.listboxTFQuestions.View = System.Windows.Forms.View.Details;
			this.listboxTFQuestions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listbox_ItemChecked);
			this.listboxTFQuestions.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
			// 
			// indexTF
			// 
			this.indexTF.Text = "#";
			// 
			// questionTF
			// 
			this.questionTF.Text = "Question";
			// 
			// trueTF
			// 
			this.trueTF.Text = "True";
			this.trueTF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.trueTF.Width = 40;
			// 
			// falseTF
			// 
			this.falseTF.Text = "False";
			this.falseTF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.falseTF.Width = 40;
			// 
			// panelDivider
			// 
			this.panelDivider.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelDivider.BackColor = System.Drawing.Color.Transparent;
			this.panelDivider.BackgroundImage = global::QGen.Properties.Resources.BackdropGradient;
			this.panelDivider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelDivider.Location = new System.Drawing.Point(0, 111);
			this.panelDivider.Margin = new System.Windows.Forms.Padding(0);
			this.panelDivider.Name = "panelDivider";
			this.panelDivider.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.panelDivider.Size = new System.Drawing.Size(496, 49);
			this.panelDivider.TabIndex = 2;
			// 
			// QuizEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gold;
			this.ClientSize = new System.Drawing.Size(496, 490);
			this.Controls.Add(this.mainmenu);
			this.Controls.Add(this.panelDivider);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.statusBar);
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainmenu;
			this.MinimumSize = new System.Drawing.Size(512, 512);
			this.Name = "QuizEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QGen Quiz Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizEditor_FormClosing);
			this.Load += new System.EventHandler(this.QuizEditor_Load);
			this.mainmenu.ResumeLayout(false);
			this.mainmenu.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.panelMain.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panelBackground.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).EndInit();
			this.panelEdit.ResumeLayout(false);
			this.panelEditHeader.ResumeLayout(false);
			this.panelEditHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.updownMinutes)).EndInit();
			this.panelQuestionIndex.ResumeLayout(false);
			this.panelQuestionIndex.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.updownQuestionIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.updownHours)).EndInit();
			this.panelEditMain.Panel1.ResumeLayout(false);
			this.panelEditMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.panelEditMain)).EndInit();
			this.panelEditMain.ResumeLayout(false);
			this.panelQuestion.ResumeLayout(false);
			this.panelQuestion.PerformLayout();
			this.panel0.ResumeLayout(false);
			this.panel0.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panelQuestionTextBox.ResumeLayout(false);
			this.panelFormatting.ResumeLayout(false);
			this.panelFormatting.PerformLayout();
			this.panelList.ResumeLayout(false);
			this.panelButtons.ResumeLayout(false);
			this.tabTest.ResumeLayout(false);
			this.pageMC.ResumeLayout(false);
			this.pageTF.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainmenu;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem miNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miOpen;
		private System.Windows.Forms.ToolStripMenuItem miSave;
		private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.ToolStripMenuItem miAbout;
		private System.Windows.Forms.ToolStripMenuItem miSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.SaveFileDialog saveDialog;
		private System.Windows.Forms.OpenFileDialog openDialog;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripMenuItem miQuizInfo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem menuView;
		private System.Windows.Forms.ToolStripMenuItem miColorScheme;
		private System.Windows.Forms.ToolStripMenuItem miTomato;
		private System.Windows.Forms.ToolStripMenuItem miMango;
		private System.Windows.Forms.ToolStripMenuItem miGreenApple;
		private System.Windows.Forms.ToolStripMenuItem miDew;
		private System.Windows.Forms.ToolStripMenuItem miSky;
		private System.Windows.Forms.TableLayoutPanel panelMain;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Panel panelDivider;
		private System.Windows.Forms.Panel panelBackground;
		private System.Windows.Forms.PictureBox picboxTitle;
		private System.Windows.Forms.TableLayoutPanel panelEdit;
		private System.Windows.Forms.TableLayoutPanel panelEditHeader;
		private System.Windows.Forms.NumericUpDown updownMinutes;
		private System.Windows.Forms.Panel panelQuestionIndex;
		private System.Windows.Forms.NumericUpDown updownQuestionIndex;
		private System.Windows.Forms.Label lblIndex;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Label lblColon;
		private System.Windows.Forms.NumericUpDown updownHours;
		private System.Windows.Forms.Label lblHours;
		private System.Windows.Forms.Label lblMinutes;
		private System.Windows.Forms.SplitContainer panelEditMain;
		private System.Windows.Forms.TableLayoutPanel panelQuestion;
		private System.Windows.Forms.RadioButton rbtn0;
		private System.Windows.Forms.Panel panel0;
		private System.Windows.Forms.TextBox txtbox0;
		private System.Windows.Forms.RadioButton rbtn1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtbox1;
		private System.Windows.Forms.RadioButton rbtn2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtbox2;
		private System.Windows.Forms.RadioButton rbtn3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtbox3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnAddMore;
		private System.Windows.Forms.TableLayoutPanel panelList;
		private System.Windows.Forms.TableLayoutPanel panelButtons;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.TabControl tabTest;
		private System.Windows.Forms.TabPage pageMC;
		private System.Windows.Forms.ListView listboxMCQuestions;
		private System.Windows.Forms.ColumnHeader indexMC;
		private System.Windows.Forms.ColumnHeader questionMC;
		private System.Windows.Forms.ColumnHeader aMC;
		private System.Windows.Forms.ColumnHeader bMC;
		private System.Windows.Forms.ColumnHeader cMC;
		private System.Windows.Forms.ColumnHeader dMC;
		private System.Windows.Forms.ColumnHeader correctAnswerMC;
		private System.Windows.Forms.TabPage pageTF;
		private System.Windows.Forms.ListView listboxTFQuestions;
		private System.Windows.Forms.ColumnHeader indexTF;
		private System.Windows.Forms.ColumnHeader questionTF;
		private System.Windows.Forms.ColumnHeader trueTF;
		private System.Windows.Forms.ColumnHeader falseTF;
		private System.Windows.Forms.ToolStripStatusLabel lblPassing;
		private System.Windows.Forms.ToolStripStatusLabel lblItems;
		private System.Windows.Forms.ToolStripStatusLabel lblPassingPercentile;
		private System.Windows.Forms.Panel panelQuestionTextBox;
		private System.Windows.Forms.RichTextBox txtboxQuestion;
		private System.Windows.Forms.TableLayoutPanel panelFormatting;
		private System.Windows.Forms.ToolStripMenuItem miPlum;
		private System.Windows.Forms.CheckBox btnBold;
		private System.Windows.Forms.CheckBox btnItalic;
		private System.Windows.Forms.CheckBox btnUnderline;
	}
}

