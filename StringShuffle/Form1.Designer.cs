namespace StringShuffle
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnhinzufügen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.btnAlleEntfernen = new System.Windows.Forms.Button();
            this.btnSortieren = new System.Windows.Forms.Button();
            this.btnVermischen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Name});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(558, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nummer";
            this.columnHeader1.Width = 100;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 400;
            // 
            // btnhinzufügen
            // 
            this.btnhinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhinzufügen.Location = new System.Drawing.Point(623, 35);
            this.btnhinzufügen.Name = "btnhinzufügen";
            this.btnhinzufügen.Size = new System.Drawing.Size(216, 46);
            this.btnhinzufügen.TabIndex = 1;
            this.btnhinzufügen.Text = "Eintrag hinzufügen";
            this.btnhinzufügen.UseVisualStyleBackColor = true;
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBearbeiten.Location = new System.Drawing.Point(623, 90);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(216, 46);
            this.btnBearbeiten.TabIndex = 2;
            this.btnBearbeiten.Text = "Eintrag bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntfernen.Location = new System.Drawing.Point(623, 145);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(216, 46);
            this.btnEntfernen.TabIndex = 3;
            this.btnEntfernen.Text = "Eintrag entfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            // 
            // btnAlleEntfernen
            // 
            this.btnAlleEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlleEntfernen.Location = new System.Drawing.Point(623, 200);
            this.btnAlleEntfernen.Name = "btnAlleEntfernen";
            this.btnAlleEntfernen.Size = new System.Drawing.Size(216, 46);
            this.btnAlleEntfernen.TabIndex = 4;
            this.btnAlleEntfernen.Text = "Alle Einträge entfernen";
            this.btnAlleEntfernen.UseVisualStyleBackColor = true;
            // 
            // btnSortieren
            // 
            this.btnSortieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortieren.Location = new System.Drawing.Point(623, 320);
            this.btnSortieren.Name = "btnSortieren";
            this.btnSortieren.Size = new System.Drawing.Size(216, 46);
            this.btnSortieren.TabIndex = 5;
            this.btnSortieren.Text = "Alle Einträge sortieren";
            this.btnSortieren.UseVisualStyleBackColor = true;
            // 
            // btnVermischen
            // 
            this.btnVermischen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermischen.Location = new System.Drawing.Point(623, 377);
            this.btnVermischen.Name = "btnVermischen";
            this.btnVermischen.Size = new System.Drawing.Size(216, 46);
            this.btnVermischen.TabIndex = 6;
            this.btnVermischen.Text = "Alle Einträge vermischen";
            this.btnVermischen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.btnVermischen);
            this.Controls.Add(this.btnSortieren);
            this.Controls.Add(this.btnAlleEntfernen);
            this.Controls.Add(this.btnEntfernen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnhinzufügen);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        new private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.Button btnhinzufügen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.Button btnAlleEntfernen;
        private System.Windows.Forms.Button btnSortieren;
        private System.Windows.Forms.Button btnVermischen;
    }
}

