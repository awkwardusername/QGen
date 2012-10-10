using System;
using System.Windows.Forms;

namespace QGen {
	public partial class QuizEditorAboutForm : Form {
		public QuizEditorAboutForm() {
			InitializeComponent();
		}

		private void AboutForm_Load(object sender, EventArgs e) {
			this.tbAbout.Rtf = @"{\rtf1\utf8 \fs28 Written by \par \fs20 Temoto-kun    \fs16\i http://nihilist-philanthropy.co.cc\i0 \fs28 \par\par \qr Licensed under \par \fs20 GNU General Public License v.3.0}";
		}

		private void btnOK_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void tbAbout_Enter(object sender, EventArgs e) {
			this.btnOK.Focus();
		}
	}
}
