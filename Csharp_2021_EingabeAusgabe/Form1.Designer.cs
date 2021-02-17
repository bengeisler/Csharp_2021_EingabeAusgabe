
namespace Csharp_2021_EingabeAusgabe
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOk = new System.Windows.Forms.Button();
			this.btnInformation = new System.Windows.Forms.Button();
			this.btnJaNein = new System.Windows.Forms.Button();
			this.btnJaNeinAbbrechen = new System.Windows.Forms.Button();
			this.btnWiederholenAbbrechen = new System.Windows.Forms.Button();
			this.btnAbbrechenWiederholenIgnorieren = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(12, 12);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnInformation
			// 
			this.btnInformation.Location = new System.Drawing.Point(94, 11);
			this.btnInformation.Name = "btnInformation";
			this.btnInformation.Size = new System.Drawing.Size(75, 23);
			this.btnInformation.TabIndex = 1;
			this.btnInformation.Text = "Information";
			this.btnInformation.UseVisualStyleBackColor = true;
			this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
			// 
			// btnJaNein
			// 
			this.btnJaNein.Location = new System.Drawing.Point(176, 12);
			this.btnJaNein.Name = "btnJaNein";
			this.btnJaNein.Size = new System.Drawing.Size(75, 23);
			this.btnJaNein.TabIndex = 2;
			this.btnJaNein.Text = "Ja Nein";
			this.btnJaNein.UseVisualStyleBackColor = true;
			this.btnJaNein.Click += new System.EventHandler(this.btnJaNein_Click);
			// 
			// btnJaNeinAbbrechen
			// 
			this.btnJaNeinAbbrechen.Location = new System.Drawing.Point(258, 11);
			this.btnJaNeinAbbrechen.Name = "btnJaNeinAbbrechen";
			this.btnJaNeinAbbrechen.Size = new System.Drawing.Size(75, 38);
			this.btnJaNeinAbbrechen.TabIndex = 3;
			this.btnJaNeinAbbrechen.Text = "Ja Nein Abbrechen";
			this.btnJaNeinAbbrechen.UseVisualStyleBackColor = true;
			this.btnJaNeinAbbrechen.Click += new System.EventHandler(this.btnJaNeinAbbrechen_Click);
			// 
			// btnWiederholenAbbrechen
			// 
			this.btnWiederholenAbbrechen.Location = new System.Drawing.Point(339, 11);
			this.btnWiederholenAbbrechen.Name = "btnWiederholenAbbrechen";
			this.btnWiederholenAbbrechen.Size = new System.Drawing.Size(75, 38);
			this.btnWiederholenAbbrechen.TabIndex = 4;
			this.btnWiederholenAbbrechen.Text = "Wiederholen Abbrechen";
			this.btnWiederholenAbbrechen.UseVisualStyleBackColor = true;
			this.btnWiederholenAbbrechen.Click += new System.EventHandler(this.btnWiederholenAbbrechen_Click);
			// 
			// btnAbbrechenWiederholenIgnorieren
			// 
			this.btnAbbrechenWiederholenIgnorieren.Location = new System.Drawing.Point(421, 11);
			this.btnAbbrechenWiederholenIgnorieren.Name = "btnAbbrechenWiederholenIgnorieren";
			this.btnAbbrechenWiederholenIgnorieren.Size = new System.Drawing.Size(137, 38);
			this.btnAbbrechenWiederholenIgnorieren.TabIndex = 5;
			this.btnAbbrechenWiederholenIgnorieren.Text = "Abbrechen Wiederholen Ignorieren";
			this.btnAbbrechenWiederholenIgnorieren.UseVisualStyleBackColor = true;
			this.btnAbbrechenWiederholenIgnorieren.Click += new System.EventHandler(this.btnAbbrechenWiederholenIgnorieren_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 61);
			this.Controls.Add(this.btnAbbrechenWiederholenIgnorieren);
			this.Controls.Add(this.btnWiederholenAbbrechen);
			this.Controls.Add(this.btnJaNeinAbbrechen);
			this.Controls.Add(this.btnJaNein);
			this.Controls.Add(this.btnInformation);
			this.Controls.Add(this.btnOk);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnInformation;
		private System.Windows.Forms.Button btnJaNein;
		private System.Windows.Forms.Button btnJaNeinAbbrechen;
		private System.Windows.Forms.Button btnWiederholenAbbrechen;
		private System.Windows.Forms.Button btnAbbrechenWiederholenIgnorieren;
	}
}

