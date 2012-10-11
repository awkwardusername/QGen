namespace QGen {
	partial class QuizInfoForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizInfoForm));
			this.gridQuizInfo = new System.Windows.Forms.PropertyGrid();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.divider = new System.Windows.Forms.Panel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.panelBackDrop = new System.Windows.Forms.Panel();
			this.picboxTitle = new System.Windows.Forms.PictureBox();
			this.panelHeader.SuspendLayout();
			this.panelBackDrop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// gridQuizInfo
			// 
			this.gridQuizInfo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gridQuizInfo.BackColor = System.Drawing.Color.White;
			this.gridQuizInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.gridQuizInfo.Location = new System.Drawing.Point(0, 164);
			this.gridQuizInfo.Margin = new System.Windows.Forms.Padding(0);
			this.gridQuizInfo.Name = "gridQuizInfo";
			this.gridQuizInfo.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.gridQuizInfo.Size = new System.Drawing.Size(394, 167);
			this.gridQuizInfo.TabIndex = 0;
			this.gridQuizInfo.ToolbarVisible = false;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.ForeColor = System.Drawing.Color.Black;
			this.btnOK.Location = new System.Drawing.Point(226, 337);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.Location = new System.Drawing.Point(307, 337);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.BackColor = System.Drawing.Color.White;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
			this.lblSubtitle.Location = new System.Drawing.Point(0, 139);
			this.lblSubtitle.Margin = new System.Windows.Forms.Padding(0);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
			this.lblSubtitle.Size = new System.Drawing.Size(394, 25);
			this.lblSubtitle.TabIndex = 1;
			this.lblSubtitle.Text = "Quiz Information";
			this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
			this.divider.Size = new System.Drawing.Size(394, 58);
			this.divider.TabIndex = 6;
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
			this.panelHeader.Size = new System.Drawing.Size(394, 100);
			this.panelHeader.TabIndex = 5;
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
			this.panelBackDrop.Size = new System.Drawing.Size(394, 86);
			this.panelBackDrop.TabIndex = 2;
			// 
			// picboxTitle
			// 
			this.picboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picboxTitle.BackColor = System.Drawing.Color.Gold;
			this.picboxTitle.Image = ((System.Drawing.Image) (resources.GetObject("picboxTitle.Image")));
			this.picboxTitle.Location = new System.Drawing.Point(73, 11);
			this.picboxTitle.Name = "picboxTitle";
			this.picboxTitle.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.picboxTitle.Size = new System.Drawing.Size(306, 65);
			this.picboxTitle.TabIndex = 0;
			this.picboxTitle.TabStop = false;
			// 
			// QuizInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 372);
			this.ControlBox = false;
			this.Controls.Add(this.lblSubtitle);
			this.Controls.Add(this.divider);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.gridQuizInfo);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "QuizInfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quiz Information";
			this.panelHeader.ResumeLayout(false);
			this.panelBackDrop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.PropertyGrid gridQuizInfo;
		public System.Windows.Forms.Panel panelHeader;
		public System.Windows.Forms.Panel panelBackDrop;
		public System.Windows.Forms.PictureBox picboxTitle;
		public System.Windows.Forms.Panel divider;
		public System.Windows.Forms.Label lblSubtitle;

	}
}