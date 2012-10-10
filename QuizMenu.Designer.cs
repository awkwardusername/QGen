namespace QGen {
	partial class QGenMainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QGenMainForm));
			this.panelMain = new System.Windows.Forms.TableLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnQuizEditor = new System.Windows.Forms.Button();
			this.btnTakeQuizzes = new System.Windows.Forms.Button();
			this.lblTooltip = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.divider = new System.Windows.Forms.Panel();
			this.cmbboxColorScheme = new System.Windows.Forms.ComboBox();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.panelBackDrop = new System.Windows.Forms.Panel();
			this.picboxTitle = new System.Windows.Forms.PictureBox();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
			this.divider.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.panelBackDrop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelMain.ColumnCount = 2;
			this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.panelMain.Controls.Add(this.btnExit, 0, 3);
			this.panelMain.Controls.Add(this.btnQuizEditor, 0, 1);
			this.panelMain.Controls.Add(this.btnTakeQuizzes, 0, 0);
			this.panelMain.Controls.Add(this.lblTooltip, 1, 0);
			this.panelMain.Controls.Add(this.pictureBox1, 1, 1);
			this.panelMain.Location = new System.Drawing.Point(13, 143);
			this.panelMain.Name = "panelMain";
			this.panelMain.RowCount = 4;
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.panelMain.Size = new System.Drawing.Size(484, 231);
			this.panelMain.TabIndex = 9;
			// 
			// btnExit
			// 
			this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.btnExit.Location = new System.Drawing.Point(3, 174);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(115, 54);
			this.btnExit.TabIndex = 4;
			this.btnExit.Tag = "Exits QGen.";
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnExit.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.btnExit.MouseLeave += new System.EventHandler(this.btnTakeQuizzes_MouseLeave);
			// 
			// btnQuizEditor
			// 
			this.btnQuizEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuizEditor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.btnQuizEditor.Location = new System.Drawing.Point(3, 60);
			this.btnQuizEditor.Name = "btnQuizEditor";
			this.btnQuizEditor.Size = new System.Drawing.Size(115, 51);
			this.btnQuizEditor.TabIndex = 2;
			this.btnQuizEditor.Tag = "Manage and edit quizzes.";
			this.btnQuizEditor.Text = "Quiz Editor";
			this.btnQuizEditor.UseVisualStyleBackColor = true;
			this.btnQuizEditor.Click += new System.EventHandler(this.btnQuizEditor_Click);
			this.btnQuizEditor.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.btnQuizEditor.MouseLeave += new System.EventHandler(this.btnTakeQuizzes_MouseLeave);
			// 
			// btnTakeQuizzes
			// 
			this.btnTakeQuizzes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTakeQuizzes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.btnTakeQuizzes.Location = new System.Drawing.Point(3, 3);
			this.btnTakeQuizzes.Name = "btnTakeQuizzes";
			this.btnTakeQuizzes.Size = new System.Drawing.Size(115, 51);
			this.btnTakeQuizzes.TabIndex = 0;
			this.btnTakeQuizzes.Tag = "Take quizzes already in the database.";
			this.btnTakeQuizzes.Text = "Take Quizzes";
			this.btnTakeQuizzes.UseVisualStyleBackColor = true;
			this.btnTakeQuizzes.MouseEnter += new System.EventHandler(this.button_MouseEnter);
			this.btnTakeQuizzes.MouseLeave += new System.EventHandler(this.btnTakeQuizzes_MouseLeave);
			// 
			// lblTooltip
			// 
			this.lblTooltip.AutoSize = true;
			this.lblTooltip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTooltip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblTooltip.Location = new System.Drawing.Point(137, 0);
			this.lblTooltip.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
			this.lblTooltip.Name = "lblTooltip";
			this.lblTooltip.Size = new System.Drawing.Size(347, 57);
			this.lblTooltip.TabIndex = 5;
			this.lblTooltip.Text = "Welcome to QGen.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(137, 57);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.panelMain.SetRowSpan(this.pictureBox1, 3);
			this.pictureBox1.Size = new System.Drawing.Size(347, 174);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// divider
			// 
			this.divider.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.divider.BackColor = System.Drawing.Color.Gold;
			this.divider.BackgroundImage = global::QGen.Properties.Resources.BackdropGradient;
			this.divider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.divider.Controls.Add(this.cmbboxColorScheme);
			this.divider.Location = new System.Drawing.Point(0, 81);
			this.divider.Margin = new System.Windows.Forms.Padding(0);
			this.divider.Name = "divider";
			this.divider.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.divider.Size = new System.Drawing.Size(509, 58);
			this.divider.TabIndex = 8;
			// 
			// cmbboxColorScheme
			// 
			this.cmbboxColorScheme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.cmbboxColorScheme.ForeColor = System.Drawing.Color.Black;
			this.cmbboxColorScheme.FormattingEnabled = true;
			this.cmbboxColorScheme.Items.AddRange(new object[] {
            "Tomato",
            "Mango",
            "Green Apple",
            "Sky",
            "Dew",
            "Plum"});
			this.cmbboxColorScheme.Location = new System.Drawing.Point(373, 11);
			this.cmbboxColorScheme.Name = "cmbboxColorScheme";
			this.cmbboxColorScheme.Size = new System.Drawing.Size(121, 21);
			this.cmbboxColorScheme.TabIndex = 0;
			this.cmbboxColorScheme.SelectedIndexChanged += new System.EventHandler(this.cmbboxColorScheme_SelectedIndexChanged);
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.Gold;
			this.panelHeader.BackgroundImage = global::QGen.Properties.Resources.BackdropHorizontal;
			this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelHeader.Controls.Add(this.panelBackDrop);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.panelHeader.Size = new System.Drawing.Size(509, 100);
			this.panelHeader.TabIndex = 7;
			// 
			// panelBackDrop
			// 
			this.panelBackDrop.BackColor = System.Drawing.Color.Transparent;
			this.panelBackDrop.BackgroundImage = global::QGen.Properties.Resources.QGen_Theme1_BG;
			this.panelBackDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBackDrop.Controls.Add(this.picboxTitle);
			this.panelBackDrop.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBackDrop.Location = new System.Drawing.Point(0, 6);
			this.panelBackDrop.Name = "panelBackDrop";
			this.panelBackDrop.Size = new System.Drawing.Size(509, 86);
			this.panelBackDrop.TabIndex = 2;
			// 
			// picboxTitle
			// 
			this.picboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picboxTitle.BackColor = System.Drawing.Color.Gold;
			this.picboxTitle.Image = ((System.Drawing.Image) (resources.GetObject("picboxTitle.Image")));
			this.picboxTitle.Location = new System.Drawing.Point(188, 11);
			this.picboxTitle.Name = "picboxTitle";
			this.picboxTitle.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.picboxTitle.Size = new System.Drawing.Size(306, 65);
			this.picboxTitle.TabIndex = 0;
			this.picboxTitle.TabStop = false;
			// 
			// QGenMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(509, 386);
			this.ControlBox = false;
			this.Controls.Add(this.divider);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelHeader);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "QGenMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuizMenu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QGenMainForm_FormClosing);
			this.Load += new System.EventHandler(this.QGenMainForm_Load);
			this.VisibleChanged += new System.EventHandler(this.QGenMainForm_VisibleChanged);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
			this.divider.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panelBackDrop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel divider;
		public System.Windows.Forms.Panel panelHeader;
		public System.Windows.Forms.Panel panelBackDrop;
		public System.Windows.Forms.PictureBox picboxTitle;
		private System.Windows.Forms.TableLayoutPanel panelMain;
		private System.Windows.Forms.Button btnTakeQuizzes;
		private System.Windows.Forms.Button btnQuizEditor;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblTooltip;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cmbboxColorScheme;
	}
}