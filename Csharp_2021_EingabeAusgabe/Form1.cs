using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_EingabeAusgabe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Gelesen? Dann bitte Ok drücken.",	// Text, der ausgegeben wird
				"Ok", // Überschrift
				MessageBoxButtons.OK);	// Angezeigte Buttons
		}

		private void btnInformation_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Das ist eine Information.", // Meldungstext
				"Info", // Überschrift
				MessageBoxButtons.OK, // Buttons
				MessageBoxIcon.Information);	// Icon
		}

		private void btnJaNein_Click(object sender, EventArgs e)
		{
			// In der Variablen dr wird gespeichert, welchen Button der Benutzer
			// gedrückt hat
			DialogResult dr = MessageBox.Show(
				"Soll die Datei gesichert werden?",
				"Sicherung",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (dr == DialogResult.Yes) Console.WriteLine("Sichern");
			if (dr == DialogResult.No) Console.WriteLine("Nicht sichern");
		}

		private void btnJaNeinAbbrechen_Click(object sender, EventArgs e)
		{
			// In der Variablen dr wird gespeichert, welchen Button der Benutzer
			// gedrückt hat
			DialogResult dr = MessageBox.Show(
				"Soll die Datei gesichert werden?",
				"Sicherung",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question);

			if (dr == DialogResult.Yes) Console.WriteLine("Sichern");
			if (dr == DialogResult.No) Console.WriteLine("Nicht sichern");
			if (dr == DialogResult.Cancel) Console.WriteLine("Vorgang wurde abgebrochen");
		}

		private void btnWiederholenAbbrechen_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show(
				"Beim Sichern der Datei trat ein Fehler auf.\n " +
				"Wollen Sie es noch einmal probieren?\n" +
				"Wollen Sie den Vorgang abbrechen?",
				"Fehler bei Sicherung",
				MessageBoxButtons.RetryCancel,
				MessageBoxIcon.Error);

			if (dr == DialogResult.Retry) Console.WriteLine("Wiederholen");
			if (dr == DialogResult.Cancel) Console.WriteLine("Abbrechen");
		}

		private void btnAbbrechenWiederholenIgnorieren_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show(
				"Beim Sichern der Datei trat ein Fehler auf.\n " +
				"Wollen Sie es noch einmal probieren?\n" +
				"Wollen Sie den Vorgang abbrechen?\n" +
				"Wollen Sie diese Nachricht ignorieren?",
				"Fehler bei Sicherung",
				MessageBoxButtons.AbortRetryIgnore,
				MessageBoxIcon.Warning);

			if (dr == DialogResult.Retry) Console.WriteLine("Wiederholen");
			if (dr == DialogResult.Abort) Console.WriteLine("Abbrechen");
			if (dr == DialogResult.Ignore) Console.WriteLine("Ignorieren");
		}
	}
}
