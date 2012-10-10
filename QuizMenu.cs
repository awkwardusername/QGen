using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QGen {
	public partial class QGenMainForm : Form {
		internal QGen.Properties.Settings settings = new Properties.Settings();

		private void ApplyColorScheme() {
			this.picboxTitle.BackColor = QGenGlobal.settings.ColorScheme;
			this.panelHeader.BackColor = QGenGlobal.settings.ColorScheme;
			this.divider.BackColor = QGenGlobal.settings.ColorScheme;

			if(QGenGlobal.settings.ColorScheme == QGenGlobal.colorSchemes[0])
				this.cmbboxColorScheme.Text = "Tomato";
			else if(QGenGlobal.settings.ColorScheme == QGenGlobal.colorSchemes[1])
				this.cmbboxColorScheme.Text = "Mango";
			else if(QGenGlobal.settings.ColorScheme == QGenGlobal.colorSchemes[2])
				this.cmbboxColorScheme.Text = "Green Apple";
			else if(QGenGlobal.settings.ColorScheme == QGenGlobal.colorSchemes[3])
				this.cmbboxColorScheme.Text = "Sky";
			else if(QGenGlobal.settings.ColorScheme == QGenGlobal.colorSchemes[4])
				this.cmbboxColorScheme.Text = "Dew";
			else if(QGenGlobal.settings.ColorScheme == QGenGlobal.colorSchemes[5])
				this.cmbboxColorScheme.Text = "Plum";
		}

		public QGenMainForm() {
			InitializeComponent();
		}

		private void button_MouseEnter(object sender, EventArgs e) {
			this.lblTooltip.Text = (sender as Button).Tag as string;
		}

		private void btnTakeQuizzes_MouseLeave(object sender, EventArgs e) {
			this.lblTooltip.Text = "Welcome to QGen.";
		}

		private void btnQuizEditor_Click(object sender, EventArgs e) {
			this.Hide();
			new QuizEditor().ShowDialog();
			this.Show();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void QGenMainForm_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = MessageBox.Show("Are you sure you want to exit QGen?", "QGen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
		}

		private void QGenMainForm_VisibleChanged(object sender, EventArgs e) {
			ApplyColorScheme();
		}

		private void cmbboxColorScheme_SelectedIndexChanged(object sender, EventArgs e) {
			switch((sender as ComboBox).Text) {
			case "Tomato":
				QGenGlobal.settings.ColorScheme = QGenGlobal.colorSchemes[0];
				break;
			case "Mango":
				QGenGlobal.settings.ColorScheme = QGenGlobal.colorSchemes[1];
				break;
			case "Green Apple":
				QGenGlobal.settings.ColorScheme = QGenGlobal.colorSchemes[2];
				break;
			case "Sky":
				QGenGlobal.settings.ColorScheme = QGenGlobal.colorSchemes[3];
				break;
			case "Dew":
				QGenGlobal.settings.ColorScheme = QGenGlobal.colorSchemes[4];
				break;
			case "Plum":
				QGenGlobal.settings.ColorScheme = QGenGlobal.colorSchemes[5];
				break;
			}

			QGenGlobal.settings.Save();
			ApplyColorScheme();
		}

		private void QGenMainForm_Load(object sender, EventArgs e) {
			ApplyColorScheme();
		}
	}
}
