using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreationOptionForm : Form
    {
        bool randomCreation;
        bool guidateCreation;
        bool ageAbilitated = false;

        public CreationOptionForm()
        {
            InitializeComponent();
        }

        private void abilitateGuidateCreation_CheckedChanged(object sender, EventArgs e)
        {
            guidateCreation = true;
            randomCreation = false;
            abilitateRandomCreation.Enabled = false;
        }



        private void chooseVampire_Click(object sender, EventArgs e)
        {
            if (abilitateRandomCreation.Checked == true)
            {
                bool chooseVampire = true;
                bool chooseGhoul = false;
                bool chooseHuman = false;
                Form CreateCharacterPag1 = new CreateCharacterPag1(chooseVampire, chooseGhoul, chooseHuman, ageAbilitated);
                CreateCharacterPag1.Show();
                this.Hide();
            }
            else if (abilitateGuidateCreation.Checked == true)
            {
                bool chooseVampire = true;
                bool chooseGhoul = false;
                bool chooseHuman = false;
                Form CreateCharacterPag1 = new CreateCharacterPag1(chooseVampire, chooseGhoul, chooseHuman, ageAbilitated);
                CreateCharacterPag1.Show();
                this.Hide();
            }
            else
            {
                string message = "Selezionare uno dei due metodi di creazione";
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }


        private void chooseGhoul_Click(object sender, EventArgs e)
        {
            if (abilitateRandomCreation.Checked == true)
            {
                bool chooseVampire = false;
                bool chooseGhoul = true;
                bool chooseHuman = false;
                Form CreateCharacterPag1 = new CreateCharacterPag1(chooseVampire, chooseGhoul, chooseHuman, ageAbilitated);
                CreateCharacterPag1.Show();

            }
            else if (abilitateGuidateCreation.Checked == true)
            {
                bool chooseVampire = false;
                bool chooseGhoul = true;
                bool chooseHuman = false;
                Form CreateCharacterPag1 = new CreateCharacterPag1(chooseVampire, chooseGhoul, chooseHuman, ageAbilitated);
                CreateCharacterPag1.Show();
                this.Hide();
            }
            else
            {
                string message = "Selezionare uno dei due metodi di creazione";
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void chooseHuman_Click(object sender, EventArgs e)
        {
            if (abilitateRandomCreation.Checked == true)
            {
                bool chooseVampire = false;
                bool chooseGhoul = false;
                bool chooseHuman = true;
              Form CreateCharacterPag1 = new CreateCharacterPag1( chooseVampire, chooseGhoul, chooseHuman, ageAbilitated);
                CreateCharacterPag1.Show();
            }
            else if (abilitateGuidateCreation.Checked == true)
            {
                bool chooseVampire = false;
                bool chooseGhoul = false;
                bool chooseHuman = true;
                Form CreateCharacterPag1 = new CreateCharacterPag1(chooseVampire, chooseGhoul, chooseHuman, ageAbilitated);
                CreateCharacterPag1.Show();
                this.Hide();
            }
            else
            {
                string message = "Selezionare uno dei due metodi di creazione";
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
          
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ageAbilitated = true;
        }
    }
}
