namespace QGen {
	partial class QuizEditorAboutForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizEditorAboutForm));
			this.panelMain = new System.Windows.Forms.TableLayoutPanel();
			this.btnOK = new System.Windows.Forms.Button();
			this.panelText = new System.Windows.Forms.Panel();
			this.tbAbout = new System.Windows.Forms.RichTextBox();
			this.divider = new System.Windows.Forms.Panel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.panelBackDrop = new System.Windows.Forms.Panel();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.picboxTitle = new System.Windows.Forms.PictureBox();
			this.panelMain.SuspendLayout();
			this.panelText.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.panelBackDrop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelMain.ColumnCount = 3;
			this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.panelMain.Controls.Add(this.btnOK, 1, 1);
			this.panelMain.Controls.Add(this.panelText, 0, 0);
			this.panelMain.Location = new System.Drawing.Point(0, 139);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.RowCount = 2;
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.panelMain.Size = new System.Drawing.Size(348, 168);
			this.panelMain.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnOK.ForeColor = System.Drawing.Color.Black;
			this.btnOK.Location = new System.Drawing.Point(119, 139);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(110, 26);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// panelText
			// 
			this.panelText.BackColor = System.Drawing.Color.White;
			this.panelMain.SetColumnSpan(this.panelText, 3);
			this.panelText.Controls.Add(this.tbAbout);
			this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelText.Location = new System.Drawing.Point(0, 0);
			this.panelText.Margin = new System.Windows.Forms.Padding(0);
			this.panelText.Name = "panelText";
			this.panelText.Padding = new System.Windows.Forms.Padding(8);
			this.panelText.Size = new System.Drawing.Size(348, 136);
			this.panelText.TabIndex = 1;
			// 
			// tbAbout
			// 
			this.tbAbout.BackColor = System.Drawing.Color.White;
			this.tbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.tbAbout.ForeColor = System.Drawing.Color.Black;
			this.tbAbout.Location = new System.Drawing.Point(8, 8);
			this.tbAbout.Margin = new System.Windows.Forms.Padding(0);
			this.tbAbout.Name = "tbAbout";
			this.tbAbout.Size = new System.Drawing.Size(332, 120);
			this.tbAbout.TabIndex = 2;
			this.tbAbout.Text = "";
			this.tbAbout.Enter += new System.EventHandler(this.tbAbout_Enter);
			// 
			// divider
			// 
			this.divider.BackColor = System.Drawing.Color.Transparent;
			this.divider.BackgroundImage = global::QGen.Properties.Resources.BackdropGradient;
			this.divider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.divider.Location = new System.Drawing.Point(0, 81);
			this.divider.Margin = new System.Windows.Forms.Padding(0);
			this.divider.Name = "divider";
			this.divider.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.divider.Size = new System.Drawing.Size(348, 58);
			this.divider.TabIndex = 8;
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
			this.panelHeader.Size = new System.Drawing.Size(348, 100);
			this.panelHeader.TabIndex = 7;
			// 
			// panelBackDrop
			// 
			this.panelBackDrop.BackColor = System.Drawing.Color.Transparent;
			this.panelBackDrop.BackgroundImage = global::QGen.Properties.Resources.QGen_Theme1_BG;
			this.panelBackDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBackDrop.Controls.Add(this.lblSubtitle);
			this.panelBackDrop.Controls.Add(this.picboxTitle);
			this.panelBackDrop.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBackDrop.Location = new System.Drawing.Point(0, 6);
			this.panelBackDrop.Name = "panelBackDrop";
			this.panelBackDrop.Size = new System.Drawing.Size(348, 86);
			this.panelBackDrop.TabIndex = 2;
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.AutoSize = true;
			this.lblSubtitle.BackColor = System.Drawing.Color.Gold;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblSubtitle.Location = new System.Drawing.Point(95, 62);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Size = new System.Drawing.Size(145, 13);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "simple quiz editor and viewer";
			// 
			// picboxTitle
			// 
			this.picboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picboxTitle.BackColor = System.Drawing.Color.Gold;
			this.picboxTitle.Image = ((System.Drawing.Image) (resources.GetObject("picboxTitle.Image")));
			this.picboxTitle.Location = new System.Drawing.Point(27, 11);
			this.picboxTitle.Name = "picboxTitle";
			this.picboxTitle.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.picboxTitle.Size = new System.Drawing.Size(306, 65);
			this.picboxTitle.TabIndex = 0;
			this.picboxTitle.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 316);
			this.ControlBox = false;
			this.Controls.Add(this.divider);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About QGen Quiz Editor";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			this.panelMain.ResumeLayout(false);
			this.panelText.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panelBackDrop.ResumeLayout(false);
			this.panelBackDrop.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel panelMain;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel panelText;
		private System.Windows.Forms.RichTextBox tbAbout;
		public System.Windows.Forms.Panel divider;
		public System.Windows.Forms.Panel panelHeader;
		public System.Windows.Forms.Panel panelBackDrop;
		public System.Windows.Forms.PictureBox picboxTitle;
		public System.Windows.Forms.Label lblSubtitle;
	}
}