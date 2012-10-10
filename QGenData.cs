using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QGen {
	public static class QGenDB {
		private static string pathDB;
		private static string connStr;
		private static OleDbConnection conn;
		
		public static void Connect(string path) {
			pathDB = path;
			connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathDB;
			conn = new OleDbConnection(connStr);
			conn.Open();
		}

		public static int GetNumberOfRows(string which) {
			OleDbCommand cmd;
			OleDbDataReader reader;
			int numRows = 0;

			cmd = new OleDbCommand(string.Format("SELECT * FROM QGEN_{0};", which), conn);
			reader = cmd.ExecuteReader();

			while(reader.Read())
				numRows++;

			return numRows;
		}

		public static Dictionary<string, object[]> RetrieveQuestion(int index) {
			Dictionary<string, object[]> data = new Dictionary<string, object[]>();
			OleDbDataReader reader;
			OleDbCommand cmd;

			cmd = new OleDbCommand(String.Format("SELECT Question, A, B, C, D, CorrectAnswer FROM QGEN_MC WHERE Index = {0};", index), conn);
			string[] itemMC = new string[6];
			data["MC"] = itemMC;
			reader = cmd.ExecuteReader();
			while(reader.Read())
				reader.GetValues(data["MC"]);

			cmd = new OleDbCommand(String.Format("SELECT Question, Answer FROM QGEN_TF WHERE Index = {0};", index), conn);
			object[] itemTF = new object[2];
			data["TF"] = itemTF;
			reader = cmd.ExecuteReader();
			while(reader.Read())
				reader.GetValues(data["TF"]);

			cmd.Dispose();
			reader.Dispose();

			return data;
		}

		public static void ClearDatabase() {
			OleDbCommand cmd;

			cmd = new OleDbCommand("DELETE * FROM QGEN_MC;", conn);
			cmd.ExecuteNonQuery();

			cmd = new OleDbCommand("DELETE * FROM QGEN_TF;", conn);
			cmd.ExecuteNonQuery();

			cmd.Dispose();
		}

		public static bool InsertQuestion(int index, string question, string a, string b, string c, string d, string correctAnswer) {
			OleDbCommand cmd;
			int rowsAffected;

			cmd = new OleDbCommand(String.Format("INSERT INTO QGEN_MC VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", index, question.Replace("'", "''"), a.Replace("'", "''"), b.Replace("'", "''"), c.Replace("'", "''"), d.Replace("'", "''"), correctAnswer.Replace("'", "''")), conn);
			rowsAffected = cmd.ExecuteNonQuery();

			return rowsAffected == 1;
		}

		public static bool InsertQuestion(int index, string question, bool answer) {
			OleDbCommand cmd;
			int rowsAffected;

			cmd = new OleDbCommand(String.Format("INSERT INTO QGEN_TF VALUES({0}, '{1}', {2});", index, question.Replace("'", "''"), answer.ToString()), conn);
			rowsAffected = cmd.ExecuteNonQuery();

			return rowsAffected == 1;
		}

		public static QuizInfo GetInformation() {
			OleDbCommand cmd;
			OleDbDataReader reader;
			QuizInfo quizInfo = new QuizInfo();

			cmd = new OleDbCommand("SELECT * FROM QGEN_DATA;", conn);
			reader = cmd.ExecuteReader();

			while(reader.Read()) {
				quizInfo.Name = reader.GetString(0);
				quizInfo.Date = reader.GetDateTime(1);
				quizInfo.Number = int.Parse(reader.GetValue(2).ToString());
				string strQuizTime = reader.GetValue(3).ToString();
				string[] quizTime = strQuizTime.Substring(strQuizTime.IndexOf(' ') + 1).Split(':');
				quizInfo.Time = new TimeSpan(int.Parse(quizTime[0]), int.Parse(quizTime[1]), 0);
				quizInfo.PassingGrade = float.Parse(reader.GetValue(4).ToString());
				quizInfo.Subject = reader.GetString(5);
				quizInfo.Instructor = reader.GetString(6);
				quizInfo.Class = reader.GetString(7);
				quizInfo.School = reader.GetString(8);
			}

			return quizInfo;
		}

		public static void SetInformation(QuizInfo info) {
			OleDbCommand cmd;

			cmd = new OleDbCommand("DELETE * FROM QGEN_DATA;", conn);
			cmd.ExecuteNonQuery();

			cmd = new OleDbCommand(
				String.Format("INSERT INTO QGEN_DATA VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
					info.Name.Replace("'", "''"),
					info.Date,
					info.Number,
					info.Time.ToString(),
					info.PassingGrade,
					info.Subject.Replace("'", "''"),
					info.Instructor.Replace("'", "''"),
					info.Class.Replace("'", "''"),
					info.School.Replace("'", "''")
				), conn);
			cmd.ExecuteNonQuery();
		}

		public static void Disconnect() {
			conn.Close();
		}
	}
}
