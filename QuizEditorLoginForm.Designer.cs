namespace QGen {
	partial class QuizEditorLoginForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizEditorLoginForm));
			this.divider = new System.Windows.Forms.Panel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.panelBackDrop = new System.Windows.Forms.Panel();
			this.picboxTitle = new System.Windows.Forms.PictureBox();
			this.lblSubtitle = new System.Windows.Forms.Label();
			this.panelLogin = new System.Windows.Forms.TableLayoutPanel();
			this.lblLogin = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtboxUsername = new System.Windows.Forms.TextBox();
			this.txtboxPassword = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			this.panelBackDrop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).BeginInit();
			this.panelLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// divider
			// 
			this.divider.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.divider.BackColor = System.Drawing.Color.Gold;
			this.divider.BackgroundImage = global::QGen.Properties.Resources.BackdropGradient;
			this.divider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.divider.Location = new System.Drawing.Point(0, 81);
			this.divider.Margin = new System.Windows.Forms.Padding(0);
			this.divider.Name = "divider";
			this.divider.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.divider.Size = new System.Drawing.Size(359, 58);
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
			this.panelHeader.Size = new System.Drawing.Size(359, 100);
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
			this.panelBackDrop.Size = new System.Drawing.Size(359, 86);
			this.panelBackDrop.TabIndex = 2;
			// 
			// picboxTitle
			// 
			this.picboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picboxTitle.BackColor = System.Drawing.Color.Gold;
			this.picboxTitle.Image = ((System.Drawing.Image) (resources.GetObject("picboxTitle.Image")));
			this.picboxTitle.Location = new System.Drawing.Point(38, 11);
			this.picboxTitle.Name = "picboxTitle";
			this.picboxTitle.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.picboxTitle.Size = new System.Drawing.Size(306, 65);
			this.picboxTitle.TabIndex = 0;
			this.picboxTitle.TabStop = false;
			// 
			// lblSubtitle
			// 
			this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblSubtitle.BackColor = System.Drawing.Color.White;
			this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
			this.lblSubtitle.Location = new System.Drawing.Point(0, 139);
			this.lblSubtitle.Margin = new System.Windows.Forms.Padding(0);
			this.lblSubtitle.Name = "lblSubtitle";
			this.lblSubtitle.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
			this.lblSubtitle.Size = new System.Drawing.Size(359, 25);
			this.lblSubtitle.TabIndex = 9;
			this.lblSubtitle.Text = "Login";
			this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// panelLogin
			// 
			this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelLogin.BackColor = System.Drawing.Color.White;
			this.panelLogin.ColumnCount = 2;
			this.panelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelLogin.Controls.Add(this.txtboxPassword, 1, 1);
			this.panelLogin.Controls.Add(this.label1, 0, 1);
			this.panelLogin.Controls.Add(this.lblLogin, 0, 0);
			this.panelLogin.Controls.Add(this.txtboxUsername, 1, 0);
			this.panelLogin.Location = new System.Drawing.Point(0, 164);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.RowCount = 2;
			this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelLogin.Size = new System.Drawing.Size(359, 59);
			this.panelLogin.TabIndex = 10;
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblLogin.Location = new System.Drawing.Point(16, 0);
			this.lblLogin.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(160, 29);
			this.lblLogin.TabIndex = 0;
			this.lblLogin.Text = "Username";
			this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.label1.Location = new System.Drawing.Point(16, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Password";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtboxUsername
			// 
			this.txtboxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtboxUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtboxUsername.Location = new System.Drawing.Point(179, 0);
			this.txtboxUsername.Margin = new System.Windows.Forms.Padding(0);
			this.txtboxUsername.Name = "txtboxUsername";
			this.txtboxUsername.Size = new System.Drawing.Size(180, 27);
			this.txtboxUsername.TabIndex = 2;
			// 
			// txtboxPassword
			// 
			this.txtboxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtboxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtboxPassword.Location = new System.Drawing.Point(179, 29);
			this.txtboxPassword.Margin = new System.Windows.Forms.Padding(0);
			this.txtboxPassword.Name = "txtboxPassword";
			this.txtboxPassword.Size = new System.Drawing.Size(180, 27);
			this.txtboxPassword.TabIndex = 3;
			this.txtboxPassword.UseSystemPasswordChar = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.Location = new System.Drawing.Point(272, 229);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.ForeColor = System.Drawing.Color.Black;
			this.btnOK.Location = new System.Drawing.Point(191, 229);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// QuizEditorLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 264);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.panelLogin);
			this.Controls.Add(this.lblSubtitle);
			this.Controls.Add(this.divider);
			this.Controls.Add(this.panelHeader);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "QuizEditorLoginForm";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.QuizEditorLoginForm_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelBackDrop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.picboxTitle)).EndInit();
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel divider;
		public System.Windows.Forms.Panel panelHeader;
		public System.Windows.Forms.Panel panelBackDrop;
		public System.Windows.Forms.PictureBox picboxTitle;
		public System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.TableLayoutPanel panelLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.TextBox txtboxPassword;
		private System.Windows.Forms.TextBox txtboxUsername;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}