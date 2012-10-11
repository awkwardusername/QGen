using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QGen {
	public partial class QuizEditorLoginForm : Form {
		public QuizEditorLoginForm() {
			InitializeComponent();
		}

		private void QuizEditorLoginForm_Load(object sender, EventArgs e) {
			this.picboxTitle.BackColor = QGenGlobal.settings.ColorScheme;
			this.panelHeader.BackColor = QGenGlobal.settings.ColorScheme;
			this.divider.BackColor = QGenGlobal.settings.ColorScheme;
		}
	}
}
