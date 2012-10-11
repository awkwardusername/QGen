/**
 * Filename:		QuizEditor.cs
 * Project:			QGen
 * Description:		Source file for the quiz editor for QGen.
 *					Made for BSCS 2012-2013 Project Management.
 * Since:			1.0
 * Author:			Temoto-kun
 * E-mail:			allan.crisostomo@pup.edu.ph
 * Website:			http://nihilist-philanthropy.co.cc
 *					http://www.facebook.com/theoryofnekomata
 */

// NOTE Code indicated by --DUMMY ...-- means placeholder code. Mainly used for debug.

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;

namespace QGen {
	/// <summary>
	/// Class for the quiz editor
	/// </summary>
	public partial class QuizEditor : Form {
		#region == MEMBERS ==

		/// <summary>
		/// The filename of the currently edited file.
		/// </summary>
		private string filename = "untitled";

		/// <summary>
		/// Is the file previously modified?
		/// </summary>
		private bool fileModified = false;

		/// <summary>
		/// Has the file existing in the disk already?
		/// </summary>
		private bool fileExists = false;

		/// <summary>
		/// Is editor in edit mode?
		/// </summary>
		private bool editMode = false;

		/// <summary>
		/// The question lists.
		/// </summary>
		private ListView[] lists;

		private bool _bold = false;
		
		public bool bold {
			get {
				return this._bold;
			}
			set {
				this._bold = value;
				this.btnBold.Checked = value;
			}
		}

		private bool _italic = false;

		public bool italic {
			get {
				return this._italic;
			}
			set {
				this._italic = value;
				this.btnItalic.Checked = value;
			}
		}

		private bool _underline = false;

		public bool underline {
			get {
				return this._underline;
			}
			set {
				this._underline = value;
				this.btnUnderline.Checked = value;
			}
		}

		/// <summary>
		/// The quiz's information.
		/// </summary>
		public static QuizInfo quizInfo = new QuizInfo();

		/// <summary>
		/// The form displaying the quiz's information.
		/// </summary>
		public static QuizInfoForm formQuizInfo = new QuizInfoForm(quizInfo);

		/// <summary>
		/// The about form.
		/// </summary>
		public static QuizEditorAboutForm formAbout = new QuizEditorAboutForm();

		/// <summary>
		/// The form's color scheme.
		/// </summary>
		public static System.Drawing.Color colorScheme;

		#endregion

		#region == METHODS ==

		#region -- Initialization Methods --

		/// <summary>
		/// Constructor for the QuizEditor form.
		/// </summary>
		public QuizEditor() {
			InitializeComponent();
			InitializeLists();
			UpdateQuizInformation();
		}

		/// <summary>
		/// Initializes the lists.
		/// </summary>
		private void InitializeLists() {
			lists = new ListView[this.tabTest.TabCount];
			lists[0] = this.listboxMCQuestions;
			lists[1] = this.listboxTFQuestions;
		}

		#endregion

		#region -- Low-level Methods --

		/// <summary>
		/// Updates the edit panel.
		/// </summary>
		private void UpdateEditPanel() {
			// --DUMMY START--
			this.txtboxQuestion.Text = "Question #" + this.updownQuestionIndex.Value;
			// --DUMMY END--

			/*
			 * shows first and second radio buttons if selected is "Multiple Choice",
			 * else hides
			 */
			this.rbtn0.Visible = this.tabTest.SelectedIndex == 0;
			this.rbtn1.Visible = this.tabTest.SelectedIndex == 0;

			/*
			 * shows textboxes for choices if selected
			 */
			this.panel0.Visible = this.tabTest.SelectedIndex == 0;
			this.panel1.Visible = this.tabTest.SelectedIndex == 0;
			this.panel2.Visible = this.tabTest.SelectedIndex == 0;
			this.panel3.Visible = this.tabTest.SelectedIndex == 0;

			switch(this.tabTest.SelectedIndex) {
			case 0:
				// selected tab is "Multiple Choice"
				this.panelQuestion.SetRowSpan(this.panelQuestionTextBox, 2);

				// sets text for choices' radio buttons
				this.rbtn2.Text = "C";
				this.rbtn3.Text = "D";

				// --DUMMY START--
				this.txtbox0.Text = "A #" + this.updownQuestionIndex.Value;
				this.txtbox1.Text = "B #" + this.updownQuestionIndex.Value;
				this.txtbox2.Text = "C #" + this.updownQuestionIndex.Value;
				this.txtbox3.Text = "D #" + this.updownQuestionIndex.Value;
				// --DUMMY END--

				break;
			case 1:
				// selected tab is "True Or False"
				this.panelQuestion.SetRowSpan(this.panelQuestionTextBox, 4);

				// sets text for choices' radio buttons
				this.rbtn2.Text = "True";
				this.rbtn3.Text = "False";

				break;
			}

			this.btnRemove.Enabled = false;
			//this.btnClear.Enabled = false;

			// sets maximum question number count to number of questions in list
			this.updownQuestionIndex.Maximum = this.lists[this.tabTest.SelectedIndex].Items.Count;

			int totalItems = 0;
			foreach(ListView list in this.lists)
				totalItems += list.Items.Count;
			try {
				this.lblPassingPercentile.Text = string.Format("({0}%)", quizInfo.PassingGrade * 100);
				this.lblItems.Text = string.Format("{0}/{1}", (int) (totalItems * quizInfo.PassingGrade), totalItems);
			} catch(Exception) {
				this.lblItems.Text = "0/0";
			}
		}

		/// <summary>
		/// Sets the question index to 0.
		/// </summary>
		private void ResetQuestionIndex() {
			this.updownQuestionIndex.Value = 0;
		}

		/// <summary>
		/// Shows question with index = number of questions + 1.
		/// </summary>
		private void ShowLastQuestion() {
			this.updownQuestionIndex.Value = this.updownQuestionIndex.Maximum;
		}

		/// <summary>
		/// Clears the fields in the edit panel.
		/// </summary>
		private void ClearEditPanel() {
			this.txtboxQuestion.Clear();

			this.txtbox0.Clear();
			this.txtbox1.Clear();
			this.txtbox2.Clear();
			this.txtbox3.Clear();

			this.rbtn0.Checked = false;
			this.rbtn1.Checked = false;

			this.rbtn2.Checked = false;
			this.rbtn3.Checked = false;
			UnselectChoices();
		}

		private void UnselectChoices() {
			this.rbtn0.BackColor = System.Drawing.Color.FromArgb(0, colorScheme);
			this.txtbox0.BackColor = System.Drawing.Color.White;
			this.rbtn1.BackColor = System.Drawing.Color.FromArgb(0, colorScheme);
			this.txtbox1.BackColor = System.Drawing.Color.White;
			this.rbtn2.BackColor = System.Drawing.Color.FromArgb(0, colorScheme);
			this.txtbox2.BackColor = System.Drawing.Color.White;
			this.rbtn3.BackColor = System.Drawing.Color.FromArgb(0, colorScheme);
			this.txtbox3.BackColor = System.Drawing.Color.White;
		}

		/// <summary>
		/// Adds the current question with subitems supplied in the editor.
		/// </summary>
		private void AddQuestion() {
			switch(this.tabTest.SelectedIndex) {
			case 0:
				if(GetSelectedChoice().Length < 1) {
					// No correct answer given
					MessageBox.Show("Please choose the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				AddToList((int) this.updownQuestionIndex.Value, this.txtboxQuestion.Rtf, this.txtbox0.Text, this.txtbox1.Text, this.txtbox2.Text, this.txtbox3.Text, GetSelectedChoice());
				break;
			case 1:
				if(!this.rbtn2.Checked && !this.rbtn3.Checked) {
					// No corect answer given
					MessageBox.Show("Please choose the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				AddToList((int) this.updownQuestionIndex.Value, this.txtboxQuestion.Rtf, this.rbtn2.Checked);
				break;
			}

			UpdateLength();
			ClearEditPanel();
			ViewNextQuestion();

			SetFileModified(true);
			SetStatus("Question added from list.");
		}

		/// <summary>
		/// Adds a question for multiple choice.
		/// </summary>
		/// <param name="question">The question text.</param>
		/// <param name="a">Choice A text.</param>
		/// <param name="b">Choice B text.</param>
		/// <param name="c">Choice C text.</param>
		/// <param name="d">Choice D text.</param>
		/// <param name="correctAnswer">The letter of the correct answer.</param>
		private void AddToList(int index, string question, string a, string b, string c, string d, string correctAnswer) {
			// items for the question list are mainly referred by question index
			ListViewItem item = new ListViewItem(index.ToString());

			// the question list item is now associated with:
			if(!question.ToLower().Contains("answer to the universe, life, and everything?")) {
				item.SubItems.Add(question);					// * question text
				item.SubItems.Add(a);							// * Choice A
				item.SubItems.Add(b);							// * Choice B
				item.SubItems.Add(c);							// * Choice C
				item.SubItems.Add(d);							// * Choice D
				item.SubItems.Add(correctAnswer);				// * Correct answer
			}
			else {
				Random rand = new Random(DateTime.Now.Millisecond);
				int[] randomizer = { 0, 1, 2, 3 };
				string[] text = { "42", "Forty-two", "FORTY-TWO", "FortyTwo" };
				item.SubItems.Add("What is The Answer to the Universe, Life, and Everything?");
				for(int i = 0; i < 42; i++) {
					int j = rand.Next(4);
					int k = rand.Next(4);
					int temp = randomizer[j];
					randomizer[j] = randomizer[k];
					randomizer[k] = temp;
				}
				for(int i = 0; i < randomizer.Length; i++)
					item.SubItems.Add(text[randomizer[i]]);
				item.SubItems.Add(correctAnswer);
			}

			this.lists[0].Items.Add(item);
		}

		/// <summary>
		/// Adds a question for true or false.
		/// </summary>
		/// <param name="question">The question text.</param>
		/// <param name="answer">The answer</param>
		private void AddToList(int index, string question, bool answer) {
			// items for the question list are mainly referred by question index
			ListViewItem item = new ListViewItem(index.ToString());

			// the question list item is now associated with:
			if(!question.ToLower().Contains("temoto-kun loves catgirls?")
				|| !question.ToLower().Contains("does temoto-kun love catgirls?")
				|| !question.ToLower().Contains("temoto-kun love catgirls, right?")
				|| !question.ToLower().Contains("Choose your true answer.")) {
				// ALWAYS TRUE xDDDDD
				item.SubItems.Add(question);					// * question text

				item.SubItems.Add(answer ? "X" : "");			// true
				item.SubItems.Add(!answer ? "X" : "");			// false

				this.lists[1].Items.Add(item);
			}
			else {
				item.SubItems.Add(question);					// * question text

				item.SubItems.Add("X");
				item.SubItems.Add("");

				this.lists[1].Items.Add(item);
			}
		}

		/// <summary>
		/// Selects a question from the question list.
		/// </summary>
		/// <param name="fromList">If the question was directly selected from the list.</param>
		private void SelectQuestion(bool fromList = true) {
			if(!fromList)
				this.btnAdd.Enabled = false;

			LoadQuestion(fromList);
		}

		/// <summary>
		/// Loads the question into the editor.
		/// </summary>
		/// <param name="fromList">If the question is loaded directly from the list.</param>
		private void LoadQuestion(bool fromList) {
			if(fromList) {
				SetReadOnlyMode(true);

				switch(this.tabTest.SelectedIndex) {
				case 0:
					foreach(ListViewItem item in this.lists[this.tabTest.SelectedIndex].SelectedItems) {
						this.updownQuestionIndex.Value = int.Parse(item.Text);
						this.txtboxQuestion.Rtf = item.SubItems[1].Text;
						this.txtbox0.Text = item.SubItems[2].Text;
						this.txtbox1.Text = item.SubItems[3].Text;
						this.txtbox2.Text = item.SubItems[4].Text;
						this.txtbox3.Text = item.SubItems[5].Text;
						switch(item.SubItems[6].Text) {
						case "A":
							this.rbtn0.Checked = true;
							break;
						case "B":
							this.rbtn1.Checked = true;
							break;
						case "C":
							this.rbtn2.Checked = true;
							break;
						case "D":
							this.rbtn3.Checked = true;
							break;
						}
					}
					break;
				case 1:
					foreach(ListViewItem item in this.lists[this.tabTest.SelectedIndex].SelectedItems) {
						this.updownQuestionIndex.Value = int.Parse(item.Text);
						this.txtboxQuestion.Rtf = item.SubItems[1].Text;
						this.rbtn2.Checked = item.SubItems[2].Text == "X";
						this.rbtn3.Checked = item.SubItems[3].Text == "X";
					}
					break;
				}
			}
			else {
				ListViewItem item = this.lists[this.tabTest.SelectedIndex].Items[(int) this.updownQuestionIndex.Value];
				item.Selected = true;
				this.lists[this.tabTest.SelectedIndex].Focus();
				//this.lists[this.tabTest.SelectedIndex].SelectedItems.Clear();
				//this.lists[this.tabTest.SelectedIndex].SelectedIndices.Add((int) this.updownQuestionIndex.Value);
				switch(this.tabTest.SelectedIndex) {
				case 0:
					SetReadOnlyMode(true);

					this.txtboxQuestion.Rtf = item.SubItems[1].Text;
					this.txtbox0.Text = item.SubItems[2].Text;
					this.txtbox1.Text = item.SubItems[3].Text;
					this.txtbox2.Text = item.SubItems[4].Text;
					this.txtbox3.Text = item.SubItems[5].Text;
					switch(item.SubItems[6].Text) {
					case "A":
						this.rbtn0.Checked = true;
						break;
					case "B":
						this.rbtn1.Checked = true;
						break;
					case "C":
						this.rbtn2.Checked = true;
						break;
					case "D":
						this.rbtn3.Checked = true;
						break;
					}
					break;
				case 1:
					SetReadOnlyMode(true);

					this.updownQuestionIndex.Value = int.Parse(item.Text);
					this.txtboxQuestion.Rtf = item.SubItems[1].Text;
					this.rbtn2.Checked = item.SubItems[2].Text == "X";
					this.rbtn3.Checked = item.SubItems[3].Text == "X";
					break;
				}
			}
		}

		/// <summary>
		/// Updates the number of questions in the current list.
		/// </summary>
		private void UpdateLength() {
			this.updownQuestionIndex.Maximum = this.lists[this.tabTest.SelectedIndex].Items.Count;
			this.btnClear.Enabled = (this.updownQuestionIndex.Maximum > 0);
			if(this.updownQuestionIndex.Maximum == 0)
				SetEditorUneditable(false);
		}

		/// <summary>
		/// Fixes the question indices in the list.
		/// </summary>
		private void FixIndexes() {
			int i = 0;
			foreach(ListViewItem item in this.lists[this.tabTest.SelectedIndex].Items)
				item.SubItems[0].Text = (i++).ToString();
			UpdateLength();
		}

		/// <summary>
		/// Removes the checked questions from the list.
		/// </summary>
		private void RemoveQuestions() {
			bool plural = this.lists[this.tabTest.SelectedIndex].CheckedItems.Count > 1;
			foreach(ListViewItem item in this.lists[this.tabTest.SelectedIndex].CheckedItems)
				this.lists[this.tabTest.SelectedIndex].Items.Remove(item);
			this.btnRemove.Enabled = false;
			FixIndexes();

			UpdateLength();
			UpdateEditPanel();


			SetFileModified(true);
			SetStatus(String.Format("Selected {0} removed from list.", plural ? "questions" : "question"));
		}

		/// <summary>
		/// Clears the question list.
		/// </summary>
		private void ClearQuestionList() {
			this.lists[this.tabTest.SelectedIndex].Items.Clear();
			UpdateLength();

			SetReadOnlyMode(false);
			SetFileModified(true);
			this.btnRemove.Enabled = false;
		}

		/// <summary>
		/// Clears all data from all lists.
		/// </summary>
		private void ClearAllLists() {
			for(int i = 0; i < this.lists.Length; i++) {
				this.lists[i].Items.Clear();
				UpdateLength();

				SetReadOnlyMode(false);
				SetFileModified(true);
				this.btnRemove.Enabled = false;
			}
		}

		/// <summary>
		/// Prepares the checked items in the list.
		/// </summary>
		private void PrepareCheck() {
			this.btnRemove.Enabled = this.lists[this.tabTest.SelectedIndex].CheckedItems.Count > 0;
		}

		/// <summary>
		/// Views the next question.
		/// </summary>
		private void ViewNextQuestion() {
			this.updownQuestionIndex.Value++;
			SetStatus(" ");
		}

		/// <summary>
		/// Views the previous question.
		/// </summary>
		private void ViewPreviousQuestion() {
			this.updownQuestionIndex.Value--;
			SetStatus(" ");
		}

		/// <summary>
		/// Gets the selected choice.
		/// </summary>
		/// <returns>The selected choice as string. If no choice is checked, returns an empty string.</returns>
		private string GetSelectedChoice() {
			switch(this.tabTest.SelectedIndex) {
			case 0:
				if(this.rbtn0.Checked)
					return "A";
				else if(this.rbtn1.Checked)
					return "B";
				else if(this.rbtn2.Checked)
					return "C";
				else if(this.rbtn3.Checked)
					return "D";
				break;
			case 1:
				if(this.rbtn2.Checked)
					return "true";
				else if(this.rbtn3.Checked)
					return "false";
				break;
			}
			return "";
		}

		/// <summary>
		/// Sets edit mode.
		/// </summary>
		/// <param name="mode">Edit mode state</param>
		private void SetReadOnlyMode(bool mode) {
			btnAdd.Text = mode ? "Commit" : "Add";
			btnEdit.Enabled = mode;
			btnAdd.Enabled = !mode;
			SetEditorUneditable(mode);

			this.editMode = mode;
			this.btnAddMore.Visible = mode;
		}

		/// <summary>
		/// Updates the form title.
		/// </summary>
		private void UpdateTitle() {
			this.Text = String.Format("QGen Quiz Editor - {0}{1}", this.fileExists ? this.filename : String.Format("[{0}]", this.filename), this.fileModified ? " [*]" : "");
		}

		/// <summary>
		/// Creates a new quiz.
		/// </summary>
		private void CreateNewQuiz() {
			foreach(ListView list in this.lists)
				list.Items.Clear();

			ResetQuestionIndex();
			ClearEditPanel();

			UpdateEditPanel();
			UpdateLength();

			this.updownHours.Value = 0;
			this.updownMinutes.Value = 15;

			SetFileExists(false);
			SetFileModified(false);
			this.tabTest.SelectedIndex = 0;
			SetFilename("untitled");
		}

		private void SetColorScheme(System.Drawing.Color color) {
			QGenGlobal.settings.ColorScheme = color;

			TextBox[] txtboxChoices = {
										  txtbox0,
										  txtbox1,
										  txtbox2,
										  txtbox3
									  };

			foreach(Control ctrl in this.panelQuestion.Controls)
				if(ctrl.BackColor == colorScheme)
					ctrl.BackColor = color;

			foreach(TextBox ctrl in txtboxChoices)
				if(ctrl.BackColor == colorScheme)
					ctrl.BackColor = color;

			colorScheme = color;

			this.BackColor = color;
			this.picboxTitle.BackColor = color;
			this.mainmenu.BackColor = color;

			formAbout.panelHeader.BackColor = color;
			formAbout.lblSubtitle.BackColor = color;
			formAbout.picboxTitle.BackColor = color;
			formAbout.divider.BackColor = color;

			formQuizInfo.panelHeader.BackColor = color;
			formQuizInfo.picboxTitle.BackColor = color;
			formQuizInfo.divider.BackColor = color;

			this.menuFile.BackColor = System.Drawing.Color.FromArgb(192, 255, 255, 255);
			this.menuView.BackColor = System.Drawing.Color.FromArgb(192, 255, 255, 255);
			this.menuHelp.BackColor = System.Drawing.Color.FromArgb(192, 255, 255, 255);

			QGenGlobal.settings.Save();

			//this.panelEdit.BackColor = System.Drawing.Color.FromArgb(204, 255, 255, 255);
			//this.panelEditMain.BackColor = System.Drawing.Color.FromArgb(32, color.R, color.G, color.B);
		}

		private void SetBold(bool mode) {
			this.bold = mode;
			int selectionStart = this.txtboxQuestion.SelectionStart;
			int selectionEnd = selectionStart + this.txtboxQuestion.SelectionLength;
			bool allCharactersBold = true;

			// checking if all characters in selected text are bold
			for(int i = selectionStart; i < selectionEnd; i++) {
				this.txtboxQuestion.SelectionStart = i;
				this.txtboxQuestion.SelectionLength = 1;
				allCharactersBold &= this.txtboxQuestion.SelectedRtf.Contains(@"\b");
			}

			// setting up the characters
			for(int i = selectionStart; i < selectionEnd; i++) {
				this.txtboxQuestion.SelectionStart = i;
				this.txtboxQuestion.SelectionLength = 1;
				this.txtboxQuestion.SelectionFont = new System.Drawing.Font(this.txtboxQuestion.SelectionFont,
					allCharactersBold ?
					(this.txtboxQuestion.SelectionFont.Style ^ System.Drawing.FontStyle.Bold) :
					(this.txtboxQuestion.SelectionFont.Style | System.Drawing.FontStyle.Bold)
				);
			}
			this.txtboxQuestion.SelectionStart = selectionStart;
			this.txtboxQuestion.SelectionLength = selectionEnd - selectionStart;
		}

		private void SetItalic(bool mode) {
			this.italic = mode;
			int selectionStart = this.txtboxQuestion.SelectionStart;
			int selectionEnd = selectionStart + this.txtboxQuestion.SelectionLength;
			bool allCharactersItalic = true;

			// checking if all characters in selected text are bold
			for(int i = selectionStart; i < selectionEnd; i++) {
				this.txtboxQuestion.SelectionStart = i;
				this.txtboxQuestion.SelectionLength = 1;
				allCharactersItalic &= this.txtboxQuestion.SelectedRtf.Contains(@"\i");
			}

			// setting up the characters
			for(int i = selectionStart; i < selectionEnd; i++) {
				this.txtboxQuestion.SelectionStart = i;
				this.txtboxQuestion.SelectionLength = 1;
				this.txtboxQuestion.SelectionFont = new System.Drawing.Font(this.txtboxQuestion.SelectionFont,
					allCharactersItalic ?
					(this.txtboxQuestion.SelectionFont.Style ^ System.Drawing.FontStyle.Italic) :
					(this.txtboxQuestion.SelectionFont.Style | System.Drawing.FontStyle.Italic)
				);
			}
			this.txtboxQuestion.SelectionStart = selectionStart;
			this.txtboxQuestion.SelectionLength = selectionEnd - selectionStart;
		}

		private void SetUnderline(bool mode) {
			this.underline = mode;
			int selectionStart = this.txtboxQuestion.SelectionStart;
			int selectionEnd = selectionStart + this.txtboxQuestion.SelectionLength;
			bool allCharactersUnderline = true;

			// checking if all characters in selected text are bold
			for(int i = selectionStart; i < selectionEnd; i++) {
				this.txtboxQuestion.SelectionStart = i;
				this.txtboxQuestion.SelectionLength = 1;
				allCharactersUnderline &= this.txtboxQuestion.SelectedRtf.Replace(@"\uc1", "").Contains(@"\u");
			}

			// setting up the characters
			for(int i = selectionStart; i < selectionEnd; i++) {
				this.txtboxQuestion.SelectionStart = i;
				this.txtboxQuestion.SelectionLength = 1;
				this.txtboxQuestion.SelectionFont = new System.Drawing.Font(this.txtboxQuestion.SelectionFont,
					allCharactersUnderline ?
					(this.txtboxQuestion.SelectionFont.Style ^ System.Drawing.FontStyle.Underline) :
					(this.txtboxQuestion.SelectionFont.Style | System.Drawing.FontStyle.Underline)
				);
			}
			this.txtboxQuestion.SelectionStart = selectionStart;
			this.txtboxQuestion.SelectionLength = selectionEnd - selectionStart;
		}

		/// <summary>
		/// Saves the current quiz.
		/// </summary>
		private void SaveQuiz() {
			FileStream stream = new FileStream(this.filename, FileMode.Create);
			BinaryWriter writer = new BinaryWriter(stream);
			writer.Write(QGen.Properties.Resources.QGEN_DUMMY);
			writer.Close();
			stream.Close();

			QGenDB.Connect(this.filename);

			QGenDB.ClearDatabase();

			foreach(ListViewItem item in this.listboxMCQuestions.Items) {
				QGenDB.InsertQuestion(
					int.Parse(item.SubItems[0].Text),
					item.SubItems[1].Text,
					item.SubItems[2].Text,
					item.SubItems[3].Text,
					item.SubItems[4].Text,
					item.SubItems[5].Text,
					item.SubItems[6].Text
				);
			}

			foreach(ListViewItem item in this.listboxTFQuestions.Items) {
				QGenDB.InsertQuestion(
					int.Parse(item.SubItems[0].Text),
					item.SubItems[1].Text,
					item.SubItems[2].Text == "X"
				);
			}

			QGenDB.SetInformation(quizInfo);

			QGenDB.Disconnect();
		}

		/// <summary>
		/// Opens a quiz file.
		/// </summary>
		private void OpenQuiz() {
			QGenDB.Connect(this.filename);
			object[] row;

			ClearAllLists();

			for(int i = 0; i < QGenDB.GetNumberOfRows("MC"); i++) {
				row = QGenDB.RetrieveQuestion(i)["MC"];
				AddToList(
					i,
					row[0].ToString(),
					row[1].ToString(),
					row[2].ToString(),
					row[3].ToString(),
					row[4].ToString(),
					row[5].ToString()
				);
			}

			for(int i = 0; i < QGenDB.GetNumberOfRows("TF"); i++) {
				row = QGenDB.RetrieveQuestion(i)["TF"];
				AddToList(
					i,
					row[0].ToString(),
					bool.Parse(row[1].ToString())
				);
			}

			quizInfo = QGenDB.GetInformation();
			UpdateQuizInformation();

			this.tabTest.SelectedIndex = 0;
			UpdateLength();
			UpdateEditPanel();
			ShowLastQuestion();

			QGenDB.Disconnect();
		}

		/// <summary>
		/// Sets the editability of controls in the editor.
		/// </summary>
		/// <param name="uneditable">Are the controls uneditable?</param>
		private void SetEditorUneditable(bool uneditable) {
			this.txtboxQuestion.ReadOnly = uneditable;

			this.txtbox0.ReadOnly = uneditable;
			this.txtbox1.ReadOnly = uneditable;
			this.txtbox2.ReadOnly = uneditable;
			this.txtbox3.ReadOnly = uneditable;

			this.rbtn0.Enabled = !uneditable;
			this.rbtn1.Enabled = !uneditable;
			this.rbtn2.Enabled = !uneditable;
			this.rbtn3.Enabled = !uneditable;

			this.btnAdd.Enabled = !uneditable;
		}

		/// <summary>
		/// Commit changes made in the editor.
		/// </summary>
		private void CommitChanges() {
			// items for the question list are mainly referred by question index
			ListViewItem item = this.lists[this.tabTest.SelectedIndex].Items[(int) this.updownQuestionIndex.Value];

			// the question list item is now associated with:
			item.SubItems[1].Text = this.txtboxQuestion.Rtf;		// * question text

			switch(this.tabTest.SelectedIndex) {
			case 0:
				// selected tab is "Multiple Choice"
				if(GetSelectedChoice().Length < 1) {
					// No correct answer given
					MessageBox.Show("Please choose the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				item.SubItems[2].Text = this.txtbox0.Text;			// * Choice A
				item.SubItems[3].Text = this.txtbox1.Text;			// * Choice B
				item.SubItems[4].Text = this.txtbox2.Text;			// * Choice C
				item.SubItems[5].Text = this.txtbox3.Text;			// * Choice D
				item.SubItems[6].Text = GetSelectedChoice();		// * Correct answer

				break;
			case 1:
				// selected tab is "True or False"
				if(!this.rbtn2.Checked && !this.rbtn3.Checked) {
					// No corect answer given
					MessageBox.Show("Please choose the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				/*
				 * I decided to make the list display, instead of telling the correct answer as 'true' or 'false',
				 * checkmarks if the answer is:
				 */
				item.SubItems[2].Text = (this.rbtn2.Checked ? "X" : "");	// true
				item.SubItems[3].Text = (this.rbtn3.Checked ? "X" : "");	// false
				break;
			}

			// commit changes
			SetEditorUneditable(true);

			SetFileModified(true);
			SetStatus(String.Format("Committed changes to Question #{0}.", this.updownQuestionIndex.Value));
		}
		
		/// <summary>
		/// Checks if the curent question is valid.
		/// </summary>
		/// <returns>Is question valid?</returns>
		private bool IsValidQuestion() {
			switch(this.tabTest.SelectedIndex) {
			case 0:
				return
					this.txtboxQuestion.TextLength > 0
						&& this.txtbox0.TextLength > 0
						&& this.txtbox1.TextLength > 0
						&& this.txtbox2.TextLength > 0
						&& this.txtbox3.TextLength > 0;
			case 1:
				return
					this.txtboxQuestion.TextLength > 0;
			}
			return true;
		}

		/// <summary>
		/// Determines the first blank textbox.
		/// </summary>
		/// <returns>Reference to the blank textbox, else returns null.</returns>
		private TextBoxBase WhichIsBlankTextBox() {
			TextBoxBase[] txtboxes = {
								   txtboxQuestion,
								   txtbox0,
								   txtbox1,
								   txtbox2,
								   txtbox3
							   };
			foreach(TextBoxBase txtbox in txtboxes)
				if(txtbox.TextLength == 0)
					return txtbox;
			return null;
		}

		/// <summary>
		/// Displays a prompt to save the current quiz.
		/// </summary>
		/// <returns>DialogResult of the dialog.</returns>
		private DialogResult PromptToSave() {
			return MessageBox.Show(String.Format("Save changes to {0}?", filename), "QGen Quiz Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// Displays a prompt to clear the current question list.
		/// </summary>
		/// <returns>DialogResult of the dialog.</returns>
		private DialogResult PromptToClear() {
			return MessageBox.Show("Are you sure you want to clear all the questions in this question list?", "QGen Quiz Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		}

		private void SetFilename(string filename) {
			this.filename = filename;
			UpdateTitle();
		}

		/// <summary>
		/// Sets if file is modified.
		/// </summary>
		/// <param name="flag">Is file modified?</param>
		private void SetFileModified(bool flag) {
			this.fileModified = flag;
			UpdateTitle();
		}

		/// <summary>
		/// Sets if file exists in the disk.
		/// </summary>
		/// <param name="flag">Is file existing?</param>
		private void SetFileExists(bool flag) {
			this.fileExists = flag;
			UpdateTitle();
		}

		/// <summary>
		/// Sets the status text.
		/// </summary>
		/// <param name="status">The current status.</param>
		private void SetStatus(string status) {
			this.lblStatus.Text = status;
		}

		/// <summary>
		/// Updates the quiz information.
		/// </summary>
		private void UpdateQuizInformation() {
			formQuizInfo.gridQuizInfo.SelectedObject = quizInfo;
			this.updownHours.Value = quizInfo.Time.Hours;
			this.updownMinutes.Value = quizInfo.Time.Minutes;
			UpdateEditPanel();
		}

		/// <summary>
		/// Shows the quiz information.
		/// </summary>
		private void ShowQuizInformation() {
			if(formQuizInfo.ShowDialog(this) == DialogResult.OK)
				UpdateQuizInformation();
		}

		/// <summary>
		/// Unchecks all items in all lists.
		/// </summary>
		private void UncheckAllItems() {
			foreach(ListView list in this.lists)
				foreach(ListViewItem item in list.Items)
					item.Checked = false;
		}

		#region # Menu Methods #

		/// <summary>
		/// Creates a new file.
		/// </summary>
		public void New() {
			if(fileModified) {
				switch(PromptToSave()) {
				case DialogResult.Yes:
					Save();
					break;
				case DialogResult.Cancel:
					return;
				}
			}

			CreateNewQuiz();
			SetStatus("Created new quiz.");
			SetFileExists(false);
			SetFileModified(false);
		}

		/// <summary>
		/// Opens a file.
		/// </summary>
		public void Open() {
			if(this.fileModified)
				switch(PromptToSave()) {
				case DialogResult.Yes:
					Save();
					break;
				case DialogResult.Cancel:
					return;
				}

			switch(this.openDialog.ShowDialog()) {
			case DialogResult.OK:
				SetFilename(this.openDialog.FileName);
				break;
			default:
				return;
			}

			try {
				OpenQuiz();
				SetStatus(string.Format("Opened quiz {0}.", this.filename));
				SetFileExists(true);
				SetFileModified(false);
			} catch(Exception) {
				MessageBox.Show(string.Format("Unable to open {0}.", this.filename), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				SetStatus(string.Format("Unable to open {0}.", this.filename));
			}
		}

		/// <summary>
		/// Saves the current file.
		/// </summary>
		/// <param name="dialog">Option to show save dialog.</param>
		public bool Save(bool dialog = false) {
			bool proceed = false;
			// when current file does not exist, always open dialog
			dialog = !this.fileExists;

			if(dialog) {
				switch(this.saveDialog.ShowDialog()) {
				case DialogResult.OK:
					SetFilename(this.saveDialog.FileName);
					break;
				default:
					return false;
				}
			}

			while(!proceed) 
				try {
					SaveQuiz();
					proceed = true;
				} catch(IOException ex) {
					if(MessageBox.Show("Cannot save the file.\r\n\r\nReason:\r\n" + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel) {
						proceed = true;
						SetStatus(string.Format("Unable to save quiz.", this.filename));
					}
				}

			SetStatus(string.Format("Quiz saved to {0}.", this.filename));
			SetFileExists(true);
			SetFileModified(false);
			return true;
		}

		/// <summary>
		/// Displays the quiz information.
		/// </summary>
		public void QuizInformation() {
			SetStatus(" ");
			formQuizInfo.ShowDialog();
		}

		/// <summary>
		/// Exits QuizEditor.
		/// </summary>
		public void Exit() {
			this.Close();
		}

		/// <summary>
		/// Displays the About form.
		/// </summary>
		public void About() {
			SetStatus(" ");
			formAbout.ShowDialog();
		}

		#endregion

		#endregion

		#region -- Event Handler Methods --

		private void updownQuestionIndex_ValueChanged(object sender, EventArgs e) {
			UpdateEditPanel();
			try {
				SelectQuestion(false);
			} catch(ArgumentOutOfRangeException) {
				this.lists[this.tabTest.SelectedIndex].SelectedItems.Clear();
				SetReadOnlyMode(false);
				ClearEditPanel();
				UpdateEditPanel();
			}
		}

		private void tabTest_SelectedIndexChanged(object sender, EventArgs e) {
			UncheckAllItems();
			ClearEditPanel();
			ResetQuestionIndex();
			UpdateEditPanel();
			UpdateLength();

			ShowLastQuestion();
			SetReadOnlyMode(false);
		}

		private void QuizEditor_Load(object sender, EventArgs e) {
			SetColorScheme(QGenGlobal.settings.ColorScheme);
			this.Show();
			CreateNewQuiz();
			SetFileModified(false);
			SetStatus("Welcome to QGen Quiz Editor.");
		}

		private void QuizEditor_FormClosing(object sender, FormClosingEventArgs e) {
			if(fileModified) {
				switch(PromptToSave()) {
				case DialogResult.Yes:
					if(!Save())
						e.Cancel = true;
					break;
				case DialogResult.No:
					break;
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
				}
			}
		}

		private void updownMinutes_ValueChanged(object sender, EventArgs e) {
			int minutes = quizInfo.Time.Minutes;
			NumericUpDown _sender = (NumericUpDown) sender;
			if(minutes != _sender.Value) {
				if(_sender.Value == 60) {
					try {
						this.updownHours.Value++;
						_sender.Value = _sender.Minimum + 1;
					} catch(ArgumentOutOfRangeException) {
						_sender.Value--;
					}
				}
				else if(_sender.Value == -1) {
					try {
						this.updownHours.Value--;
						_sender.Value = _sender.Maximum - 1;
					} catch(ArgumentOutOfRangeException) {
						_sender.Value++;
					}
				}
				minutes = (int) _sender.Value;
			}

			quizInfo.Time = new TimeSpan(quizInfo.Time.Hours, minutes, 0);
		}

		private void updownHours_ValueChanged(object sender, EventArgs e) {
			int hours = quizInfo.Time.Hours;
			NumericUpDown _sender = (NumericUpDown) sender;
			hours = (int) _sender.Value;
			if(hours > 0)
				this.updownMinutes.Minimum = -1;
			else
				this.updownMinutes.Minimum = 15;

			quizInfo.Time = new TimeSpan(hours, quizInfo.Time.Minutes, 0);
		}

		private void listbox_SelectedIndexChanged(object sender, EventArgs e) {
			SelectQuestion(true);
		}

		private void listbox_ItemChecked(object sender, ItemCheckedEventArgs e) {
			PrepareCheck();
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if(!btnEdit.Enabled) {
				if(IsValidQuestion())
					AddQuestion();
				else {
					MessageBox.Show("This question cannot be added.\r\n\r\nReason:\r\nOne or more fields are blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					WhichIsBlankTextBox().Focus();
				}
			}
			else {
				CommitChanges();
				SetEditorUneditable(true);
			}
		}

		private void btnAddMore_Click(object sender, EventArgs e) {
			ShowLastQuestion();
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			RemoveQuestions();
		}

		private void btnClear_Click(object sender, EventArgs e) {
			if(PromptToClear() == DialogResult.Yes) {
				ClearQuestionList();
				ClearEditPanel();
				UpdateEditPanel();
				SetStatus("Question list cleared.");
			}
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			SetEditorUneditable(false);
		}

		private void textbox_TextChanged(object sender, EventArgs e) {
			TextBoxBase _sender = (TextBoxBase) sender;
			if(!_sender.ReadOnly) {
				SetFileModified(true);
				SetStatus(" ");
			}
		}

		private void radiobutton_CheckedChanged(object sender, EventArgs e) {
			RadioButton _sender = (RadioButton) sender;
			UnselectChoices();
			_sender.BackColor = colorScheme;

			switch(GetSelectedChoice()) {
			case "A":
				this.txtbox0.BackColor = colorScheme;
				break;
			case "B":
				this.txtbox1.BackColor = colorScheme;
				break;
			case "C":
				this.txtbox2.BackColor = colorScheme;
				break;
			case "D":
				this.txtbox3.BackColor = colorScheme;
				break;
			}

			if(_sender.Enabled) {
				SetFileModified(true);
				SetStatus(" ");
			}
		}

		#region # Menu Event Handlers #

		private void miNew_Click(object sender, EventArgs e) {
			New();
		}

		private void miOpen_Click(object sender, EventArgs e) {
			Open();
		}

		private void miSave_Click(object sender, EventArgs e) {
			Save();
		}

		private void miSaveAs_Click(object sender, EventArgs e) {
			Save(true);
		}

		private void miQuizInfo_Click(object sender, EventArgs e) {
			QuizInformation();
		}

		private void miExit_Click(object sender, EventArgs e) {
			Exit();
		}

		private void miAbout_Click(object sender, EventArgs e) {
			About();
		}

		#endregion

		private void focus(object sender, EventArgs e) {
			SetStatus(" ");
		}

		#endregion

		#endregion

		private void miTomato_Click(object sender, EventArgs e) {
			SetColorScheme(QGenGlobal.colorSchemes[0]);
			SetStatus("Color scheme set to Tomato.");
		}

		private void miMango_Click(object sender, EventArgs e) {
			SetColorScheme(QGenGlobal.colorSchemes[1]);
			SetStatus("Color scheme set to Mango.");

		}

		private void miGreenApple_Click(object sender, EventArgs e) {
			SetColorScheme(QGenGlobal.colorSchemes[2]);
			SetStatus("Color scheme set to Green Apple.");

		}

		private void miSky_Click(object sender, EventArgs e) {
			SetColorScheme(QGenGlobal.colorSchemes[3]);
			SetStatus("Color scheme set to Sky.");
		}

		private void miDew_Click(object sender, EventArgs e) {
			SetColorScheme(QGenGlobal.colorSchemes[4]);
			SetStatus("Color scheme set to Dew.");
		}

		private void miPlum_Click(object sender, EventArgs e) {
			SetColorScheme(QGenGlobal.colorSchemes[5]);
			SetStatus("Color scheme set to Plum.");
		}

		private void menuItem_MouseMove(object sender, MouseEventArgs e) {
			ToolStripMenuItem _sender = (ToolStripMenuItem) sender;
			if(this.lblStatus.Text != _sender.ToolTipText)
				SetStatus(_sender.ToolTipText);
		}

		private void menuItem_MouseLeave(object sender, EventArgs e) {
			SetStatus(" ");
		}

		private void txtboxQuestion_SelectionChanged(object sender, EventArgs e) {
			this.bold = (sender as RichTextBox).SelectedRtf.Contains(@"\b");
			this.italic = (sender as RichTextBox).SelectedRtf.Contains(@"\i");
			this.underline = (sender as RichTextBox).SelectedRtf.Replace(@"\uc1", "").Contains(@"\u");
		}

		private void btnBold_CheckedChanged(object sender, EventArgs e) {
			this.bold = (sender as CheckBox).Checked;
		}

		private void btnBold_Click(object sender, EventArgs e) {
			SetBold((sender as CheckBox).Checked);
			this.txtboxQuestion.Focus();
		}

		private void btnItalic_CheckedChanged(object sender, EventArgs e) {
			this.italic = (sender as CheckBox).Checked;
		}

		private void btnItalic_Click(object sender, EventArgs e) {
			SetItalic((sender as CheckBox).Checked);
			this.txtboxQuestion.Focus();
		}

		private void btnUnderline_CheckedChanged(object sender, EventArgs e) {
			this.underline = (sender as CheckBox).Checked;
		}

		private void btnUnderline_Click(object sender, EventArgs e) {
			SetUnderline((sender as CheckBox).Checked);
			this.txtboxQuestion.Focus();
		}
	}
}