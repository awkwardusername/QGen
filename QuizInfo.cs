using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace QGen {
	[DefaultPropertyAttribute("Name")]
	public class QuizInfo {
		private string _Name = "";
		private DateTime _Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
		private int _Number = 0;
		private TimeSpan _Time = new TimeSpan(0, 15, 0);
		private float _PassingGrade = 0.5F;
		private string _Subject = "";
		private string _Instructor = "";
		private string _Class = "";
		private string _School = "";

		[CategoryAttribute("Quiz"), Description("The quiz name.")]
		/// <summary>
		/// The quiz name.
		/// </summary>
		public string Name {
			get { return _Name; }
			set { _Name = value; }
		}

		[CategoryAttribute("Quiz"), Description("The date when this quiz should be taken.")]
		/// <summary>
		/// The date when this quiz should be taken.
		/// </summary>
		public DateTime Date {
			get { return _Date; }
			set { _Date = value; }
		}

		[CategoryAttribute("Quiz"), Description("The quiz number."), DefaultValue(0)]
		/// <summary>
		/// The quiz number.
		/// </summary>
		public int Number {
			get { return _Number; }
			set { _Number = value; }
		}

		[Category("Quiz"), ReadOnly(true), Description("Time alloted to take the quiz.\r\nThis value is only editable from the main window."), DefaultValue(typeof(TimeSpan), "00:15:00")]
		/// <summary>
		/// Time alloted to take the quiz.
		/// </summary>
		public TimeSpan Time {
			get { return _Time; }
			set { _Time = value; }
		}

		[DisplayName("Passing Grade"), Category("Quiz"), Description("Passing grade for this quiz."), DefaultValue(0.5F), TypeConverter(typeof(PercentConverter))]
		/// <summary>
		/// Passing grade for this quiz. A value of 1.0 is equivalent to 100%
		/// </summary>
		public float PassingGrade {
			get { return _PassingGrade; }
			set { _PassingGrade = value; }
		}

		[Category("Subject"), Description("The subject of the quiz.")]
		/// <summary>
		/// The subject of the quiz.
		/// </summary>
		public string Subject {
			get { return _Subject; }
			set { _Subject = value; }
		}

		[Category("Subject"), Description("The instructor's name.")]
		/// <summary>
		/// The instructor's name.
		/// </summary>
		public string Instructor {
			get { return _Instructor; }
			set { _Instructor = value; }
		}

		[Category("Subject"), Description("The class taking the quiz.")]
		/// <summary>
		/// The class taking the quiz.
		/// </summary>
		public string Class {
			get { return _Class; }
			set { _Class = value; }
		}

		[Category("Subject"), Description("The school name.")]
		/// <summary>
		/// The school name.
		/// </summary>
		public string School {
			get { return _School; }
			set { _School = value; }
		}
	}

	public class PercentConverter : TypeConverter {
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {

			if(sourceType == typeof(string))
				return true;
			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
			if(value is string) {
				float returnVal;
				float.TryParse(value.ToString(), out returnVal);
				returnVal /= 100;
				return returnVal;
			}
			return base.ConvertFrom(context, culture, value);
		}

		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
			if(destinationType == typeof(string)) {
				return string.Format("{0:#.##}", (float)value * 100) + "%";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
