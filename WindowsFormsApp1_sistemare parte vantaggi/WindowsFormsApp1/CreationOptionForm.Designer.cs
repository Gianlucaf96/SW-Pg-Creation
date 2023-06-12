
namespace WindowsFormsApp1
{
    partial class CreationOptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseHuman = new System.Windows.Forms.Button();
            this.chooseGhoul = new System.Windows.Forms.Button();
            this.chooseVampire = new System.Windows.Forms.Button();
            this.abilitateGuidateCreation = new System.Windows.Forms.CheckBox();
            this.abilitateRandomCreation = new System.Windows.Forms.CheckBox();
            this.ageAbilitation = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseHuman
            // 
            this.chooseHuman.Location = new System.Drawing.Point(61, 218);
            this.chooseHuman.Name = "chooseHuman";
            this.chooseHuman.Size = new System.Drawing.Size(102, 46);
            this.chooseHuman.TabIndex = 0;
            this.chooseHuman.Text = "Creazione\nUmano";
            this.chooseHuman.UseVisualStyleBackColor = true;
            this.chooseHuman.Click += new System.EventHandler(this.chooseHuman_Click);
            // 
            // chooseGhoul
            // 
            this.chooseGhoul.Location = new System.Drawing.Point(267, 218);
            this.chooseGhoul.Name = "chooseGhoul";
            this.chooseGhoul.Size = new System.Drawing.Size(102, 46);
            this.chooseGhoul.TabIndex = 1;
            this.chooseGhoul.Text = "Creazione\nGhoul";
            this.chooseGhoul.UseVisualStyleBackColor = true;
            this.chooseGhoul.Click += new System.EventHandler(this.chooseGhoul_Click);
            // 
            // chooseVampire
            // 
            this.chooseVampire.Location = new System.Drawing.Point(447, 218);
            this.chooseVampire.Name = "chooseVampire";
            this.chooseVampire.Size = new System.Drawing.Size(104, 46);
            this.chooseVampire.TabIndex = 2;
            this.chooseVampire.Text = "Creazione\nVampiro";
            this.chooseVampire.UseVisualStyleBackColor = true;
            this.chooseVampire.Click += new System.EventHandler(this.chooseVampire_Click);
            // 
            // abilitateGuidateCreation
            // 
            this.abilitateGuidateCreation.AutoSize = true;
            this.abilitateGuidateCreation.Location = new System.Drawing.Point(61, 150);
            this.abilitateGuidateCreation.Name = "abilitateGuidateCreation";
            this.abilitateGuidateCreation.Size = new System.Drawing.Size(145, 21);
            this.abilitateGuidateCreation.TabIndex = 3;
            this.abilitateGuidateCreation.Text = "Creazione guidata";
            this.abilitateGuidateCreation.UseVisualStyleBackColor = true;
            // 
            // abilitateRandomCreation
            // 
            this.abilitateRandomCreation.AutoSize = true;
            this.abilitateRandomCreation.Location = new System.Drawing.Point(447, 150);
            this.abilitateRandomCreation.Name = "abilitateRandomCreation";
            this.abilitateRandomCreation.Size = new System.Drawing.Size(151, 21);
            this.abilitateRandomCreation.TabIndex = 4;
            this.abilitateRandomCreation.Text = "Creazione Random";
            this.abilitateRandomCreation.UseVisualStyleBackColor = true;
            // 
            // ageAbilitation
            // 
            this.ageAbilitation.AutoSize = true;
            this.ageAbilitation.Location = new System.Drawing.Point(18, 24);
            this.ageAbilitation.Name = "ageAbilitation";
            this.ageAbilitation.Size = new System.Drawing.Size(192, 21);
            this.ageAbilitation.TabIndex = 6;
            this.ageAbilitation.Text = "Creare un pg minorenne?";
            this.ageAbilitation.UseVisualStyleBackColor = true;
            this.ageAbilitation.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ageAbilitation);
            this.panel1.Location = new System.Drawing.Point(212, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 72);
            this.panel1.TabIndex = 7;
            // 
            // CreationOptionForm
            // 
            this.ClientSize = new System.Drawing.Size(628, 296);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.abilitateRandomCreation);
            this.Controls.Add(this.abilitateGuidateCreation);
            this.Controls.Add(this.chooseVampire);
            this.Controls.Add(this.chooseGhoul);
            this.Controls.Add(this.chooseHuman);
            this.Name = "CreationOptionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseHuman;
        private System.Windows.Forms.Button chooseGhoul;
        private System.Windows.Forms.Button chooseVampire;
        private System.Windows.Forms.CheckBox abilitateGuidateCreation;
        private System.Windows.Forms.CheckBox abilitateRandomCreation;
        private System.Windows.Forms.CheckBox ageAbilitation;
        private System.Windows.Forms.Panel panel1;
    }
}