using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QGen {
	public partial class QuizInfoForm : Form {
		public QuizInfoForm(object selectedObject = null) {
			InitializeComponent();
			this.gridQuizInfo.SelectedObject = selectedObject;
		}
	}
}
