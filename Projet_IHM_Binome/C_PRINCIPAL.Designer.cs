namespace Projet_IHM_Binome
{
    partial class Controle_JSON
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Listbox_Personnes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox_users = new System.Windows.Forms.GroupBox();
            this.Bouton_ajouter = new System.Windows.Forms.Button();
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.Bouton_modifier = new System.Windows.Forms.Button();
            this.textbox_ID = new System.Windows.Forms.TextBox();
            this.textbox_nom = new System.Windows.Forms.TextBox();
            this.textbox_prenom = new System.Windows.Forms.TextBox();
            this.textbox_IDgroupe = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_IDgoupe = new System.Windows.Forms.Label();
            this.Bouton_sauvegarder = new System.Windows.Forms.Button();
            this.groupbox_lecture = new System.Windows.Forms.GroupBox();
            this.La_Checkbox = new System.Windows.Forms.CheckBox();
            this.groupbox_creation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Copie_ID = new System.Windows.Forms.TextBox();
            this.Copie_Nom = new System.Windows.Forms.TextBox();
            this.Copie_Prenom = new System.Windows.Forms.TextBox();
            this.Copie_IDgroupe = new System.Windows.Forms.TextBox();
            this.compteur = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GroupBox_users.SuspendLayout();
            this.groupbox_lecture.SuspendLayout();
            this.groupbox_creation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listbox_Personnes
            // 
            this.Listbox_Personnes.FormattingEnabled = true;
            this.Listbox_Personnes.ItemHeight = 16;
            this.Listbox_Personnes.Location = new System.Drawing.Point(29, 37);
            this.Listbox_Personnes.Name = "Listbox_Personnes";
            this.Listbox_Personnes.Size = new System.Drawing.Size(300, 388);
            this.Listbox_Personnes.TabIndex = 0;
            this.Listbox_Personnes.SelectedIndexChanged += new System.EventHandler(this.Listbox_Personnes_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // GroupBox_users
            // 
            this.GroupBox_users.Controls.Add(this.Listbox_Personnes);
            this.GroupBox_users.Location = new System.Drawing.Point(24, 41);
            this.GroupBox_users.Name = "GroupBox_users";
            this.GroupBox_users.Size = new System.Drawing.Size(415, 455);
            this.GroupBox_users.TabIndex = 2;
            this.GroupBox_users.TabStop = false;
            this.GroupBox_users.Text = "Les_Personnes";
            // 
            // Bouton_ajouter
            // 
            this.Bouton_ajouter.Location = new System.Drawing.Point(180, 303);
            this.Bouton_ajouter.Name = "Bouton_ajouter";
            this.Bouton_ajouter.Size = new System.Drawing.Size(102, 29);
            this.Bouton_ajouter.TabIndex = 3;
            this.Bouton_ajouter.Text = "AJOUTER";
            this.Bouton_ajouter.UseVisualStyleBackColor = true;
            this.Bouton_ajouter.Click += new System.EventHandler(this.Bouton_ajouter_Click);
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(445, 135);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(102, 32);
            this.Bouton_Supprimer.TabIndex = 3;
            this.Bouton_Supprimer.Text = "SUPPRIMER";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Bouton_modifier
            // 
            this.Bouton_modifier.Location = new System.Drawing.Point(191, 317);
            this.Bouton_modifier.Name = "Bouton_modifier";
            this.Bouton_modifier.Size = new System.Drawing.Size(102, 29);
            this.Bouton_modifier.TabIndex = 3;
            this.Bouton_modifier.Text = "MODIFIER";
            this.Bouton_modifier.UseVisualStyleBackColor = true;
            this.Bouton_modifier.Click += new System.EventHandler(this.Bouton_modifier_Click);
            // 
            // textbox_ID
            // 
            this.textbox_ID.Location = new System.Drawing.Point(118, 38);
            this.textbox_ID.Name = "textbox_ID";
            this.textbox_ID.Size = new System.Drawing.Size(100, 22);
            this.textbox_ID.TabIndex = 4;
            // 
            // textbox_nom
            // 
            this.textbox_nom.Location = new System.Drawing.Point(118, 101);
            this.textbox_nom.Name = "textbox_nom";
            this.textbox_nom.Size = new System.Drawing.Size(100, 22);
            this.textbox_nom.TabIndex = 4;
            // 
            // textbox_prenom
            // 
            this.textbox_prenom.Location = new System.Drawing.Point(118, 169);
            this.textbox_prenom.Name = "textbox_prenom";
            this.textbox_prenom.Size = new System.Drawing.Size(100, 22);
            this.textbox_prenom.TabIndex = 4;
            // 
            // textbox_IDgroupe
            // 
            this.textbox_IDgroupe.Location = new System.Drawing.Point(118, 239);
            this.textbox_IDgroupe.Name = "textbox_IDgroupe";
            this.textbox_IDgroupe.Size = new System.Drawing.Size(100, 22);
            this.textbox_IDgroupe.TabIndex = 4;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(23, 36);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(33, 17);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "ID : ";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(23, 101);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(45, 17);
            this.label_nom.TabIndex = 5;
            this.label_nom.Text = "Nom :";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(23, 169);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(69, 17);
            this.label_prenom.TabIndex = 5;
            this.label_prenom.Text = "Prenom : ";
            // 
            // label_IDgoupe
            // 
            this.label_IDgoupe.AutoSize = true;
            this.label_IDgoupe.Location = new System.Drawing.Point(23, 239);
            this.label_IDgoupe.Name = "label_IDgoupe";
            this.label_IDgoupe.Size = new System.Drawing.Size(89, 17);
            this.label_IDgoupe.TabIndex = 5;
            this.label_IDgoupe.Text = "ID_Groupe : ";
            this.label_IDgoupe.Click += new System.EventHandler(this.label_IDgoupe_Click);
            // 
            // Bouton_sauvegarder
            // 
            this.Bouton_sauvegarder.Enabled = false;
            this.Bouton_sauvegarder.Location = new System.Drawing.Point(445, 405);
            this.Bouton_sauvegarder.Name = "Bouton_sauvegarder";
            this.Bouton_sauvegarder.Size = new System.Drawing.Size(117, 29);
            this.Bouton_sauvegarder.TabIndex = 6;
            this.Bouton_sauvegarder.Text = "SAUVEGARDE";
            this.Bouton_sauvegarder.UseVisualStyleBackColor = true;
            this.Bouton_sauvegarder.Click += new System.EventHandler(this.Bouton_sauvegarder_Click);
            // 
            // groupbox_lecture
            // 
            this.groupbox_lecture.Controls.Add(this.La_Checkbox);
            this.groupbox_lecture.Controls.Add(this.label_id);
            this.groupbox_lecture.Controls.Add(this.label_nom);
            this.groupbox_lecture.Controls.Add(this.Bouton_modifier);
            this.groupbox_lecture.Controls.Add(this.textbox_IDgroupe);
            this.groupbox_lecture.Controls.Add(this.textbox_ID);
            this.groupbox_lecture.Controls.Add(this.label_IDgoupe);
            this.groupbox_lecture.Controls.Add(this.textbox_prenom);
            this.groupbox_lecture.Controls.Add(this.label_prenom);
            this.groupbox_lecture.Controls.Add(this.textbox_nom);
            this.groupbox_lecture.Location = new System.Drawing.Point(621, 59);
            this.groupbox_lecture.Name = "groupbox_lecture";
            this.groupbox_lecture.Size = new System.Drawing.Size(306, 375);
            this.groupbox_lecture.TabIndex = 7;
            this.groupbox_lecture.TabStop = false;
            this.groupbox_lecture.Text = "Lecture";
            // 
            // La_Checkbox
            // 
            this.La_Checkbox.AutoSize = true;
            this.La_Checkbox.Location = new System.Drawing.Point(7, 317);
            this.La_Checkbox.Name = "La_Checkbox";
            this.La_Checkbox.Size = new System.Drawing.Size(120, 21);
            this.La_Checkbox.TabIndex = 6;
            this.La_Checkbox.Text = "Accès écriture";
            this.La_Checkbox.UseVisualStyleBackColor = true;
            this.La_Checkbox.CheckedChanged += new System.EventHandler(this.La_Checkbox_CheckedChanged);
            // 
            // groupbox_creation
            // 
            this.groupbox_creation.Controls.Add(this.Bouton_ajouter);
            this.groupbox_creation.Controls.Add(this.label2);
            this.groupbox_creation.Controls.Add(this.label4);
            this.groupbox_creation.Controls.Add(this.label3);
            this.groupbox_creation.Controls.Add(this.label1);
            this.groupbox_creation.Controls.Add(this.Copie_IDgroupe);
            this.groupbox_creation.Controls.Add(this.Copie_Prenom);
            this.groupbox_creation.Controls.Add(this.Copie_Nom);
            this.groupbox_creation.Controls.Add(this.Copie_ID);
            this.groupbox_creation.Location = new System.Drawing.Point(977, 67);
            this.groupbox_creation.Name = "groupbox_creation";
            this.groupbox_creation.Size = new System.Drawing.Size(302, 367);
            this.groupbox_creation.TabIndex = 8;
            this.groupbox_creation.TabStop = false;
            this.groupbox_creation.Text = "Creation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID_Groupe : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Copie_ID
            // 
            this.Copie_ID.Location = new System.Drawing.Point(101, 30);
            this.Copie_ID.Name = "Copie_ID";
            this.Copie_ID.Size = new System.Drawing.Size(100, 22);
            this.Copie_ID.TabIndex = 4;
            this.Copie_ID.TextChanged += new System.EventHandler(this.Copie_ID_TextChanged);
            // 
            // Copie_Nom
            // 
            this.Copie_Nom.Location = new System.Drawing.Point(101, 93);
            this.Copie_Nom.Name = "Copie_Nom";
            this.Copie_Nom.Size = new System.Drawing.Size(100, 22);
            this.Copie_Nom.TabIndex = 4;
            // 
            // Copie_Prenom
            // 
            this.Copie_Prenom.Location = new System.Drawing.Point(101, 156);
            this.Copie_Prenom.Name = "Copie_Prenom";
            this.Copie_Prenom.Size = new System.Drawing.Size(100, 22);
            this.Copie_Prenom.TabIndex = 4;
            // 
            // Copie_IDgroupe
            // 
            this.Copie_IDgroupe.Location = new System.Drawing.Point(101, 231);
            this.Copie_IDgroupe.Name = "Copie_IDgroupe";
            this.Copie_IDgroupe.Size = new System.Drawing.Size(100, 22);
            this.Copie_IDgroupe.TabIndex = 4;
            // 
            // compteur
            // 
            this.compteur.AutoSize = true;
            this.compteur.Location = new System.Drawing.Point(53, 522);
            this.compteur.Name = "compteur";
            this.compteur.Size = new System.Drawing.Size(0, 17);
            this.compteur.TabIndex = 9;
            // 
            // Controle_JSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 569);
            this.Controls.Add(this.compteur);
            this.Controls.Add(this.groupbox_creation);
            this.Controls.Add(this.groupbox_lecture);
            this.Controls.Add(this.Bouton_sauvegarder);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.GroupBox_users);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Controle_JSON";
            this.Text = "Projet_IHM";
            this.Load += new System.EventHandler(this.Controle_JSON_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBox_users.ResumeLayout(false);
            this.groupbox_lecture.ResumeLayout(false);
            this.groupbox_lecture.PerformLayout();
            this.groupbox_creation.ResumeLayout(false);
            this.groupbox_creation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Listbox_Personnes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBox_users;
        private System.Windows.Forms.Button Bouton_ajouter;
        private System.Windows.Forms.Button Bouton_Supprimer;
        private System.Windows.Forms.Button Bouton_modifier;
        private System.Windows.Forms.TextBox textbox_ID;
        private System.Windows.Forms.TextBox textbox_nom;
        private System.Windows.Forms.TextBox textbox_prenom;
        private System.Windows.Forms.TextBox textbox_IDgroupe;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_IDgoupe;
        private System.Windows.Forms.Button Bouton_sauvegarder;
        private System.Windows.Forms.GroupBox groupbox_lecture;
        private System.Windows.Forms.CheckBox La_Checkbox;
        private System.Windows.Forms.GroupBox groupbox_creation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Copie_IDgroupe;
        private System.Windows.Forms.TextBox Copie_Prenom;
        private System.Windows.Forms.TextBox Copie_Nom;
        private System.Windows.Forms.TextBox Copie_ID;
        private System.Windows.Forms.Label compteur;
    }
}

