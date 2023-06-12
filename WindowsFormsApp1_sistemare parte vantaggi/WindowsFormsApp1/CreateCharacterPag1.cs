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

    public partial class CreateCharacterPag1 : Form
    {
        public int BloodPotency;
        public int umanità;
        private Form Create_CharacterPag2;
        private string  nomeAbilità;
        public string pregioPredatore;
        public string difettoPredatore;
        public CreateCharacterPag1(bool chooseVampire, bool chooseGhoul, bool chooseHuman, bool ageAbilitated)
        {
            InitializeComponent();
            var pgGenerator = new pgGenerator();
            var main = pgGenerator.Main(ageAbilitated);
            umanità = pgGenerator.NumUmanità;
            pregioPredatore  = pgGenerator.PregioPredatore;
            difettoPredatore =  pgGenerator.DifettoPredatore;
            var _bonusxp = pgGenerator.bonusxp;
            this.textBox_pgName.Text = "Name: " + pgGenerator.pgname;
            if (chooseVampire == true || chooseGhoul == true)
            {
                BloodPotency = pgGenerator.BloodPotency;
                if (pgGenerator.clanname == "SANGUE DEBOLE")
                {
                    BloodPotency = 0;
                }
                this.clan_textBox.Text = "Clan: " + pgGenerator.clanname;
                this.sire_textBox.Text = "Sire: " + pgGenerator.sirename;
                if (pgGenerator.pgname == pgGenerator.sirename)
                {
                    string _sire_textBox = "Sire: " + pgGenerator.sirename;
                }
                this.sire_textBox.Text = "Sire: " + pgGenerator.sirename;
                if (chooseVampire)
                {
                    this.predatore_textBox.Text = pgGenerator.Predator;
                    this.generazione_textBox.Text = "Generazione: " + pgGenerator.generation;
                }
            }
            else
            {
                clan_textBox.Text = " ";
                sire_textBox.Text = " ";
                generazione_textBox.Text = " ";
            }

            foreach (string[] stat in pgGenerator.StatAssegnate)
            {
                string nomeStat = stat[0];
                string valStat = stat[1];
                for (int i = 1; i <= 5; i++)
                {
                    string radioButtonName = $"{nomeStat}_radioButton_{i}";
                    Control[] controls = this.Controls.Find(radioButtonName, true);
                    if (controls.Length > 0 && controls[0] is RadioButton radioButton)
                    {
                        int radioButtonValue;
                        bool isNumeric = int.TryParse(valStat, out radioButtonValue);

                        if (isNumeric)
                        {
                            radioButton.Checked = (i == radioButtonValue);
                        }
                    }
                }
            }
                foreach (string[] abilità in pgGenerator.AbilitàAssegnate)
                {
                    if (abilità[0] == "armi da fuoco")
                    {
                        nomeAbilità = "armidafuoco";
                    }
                    else if (abilità[0]== "Affinità Animale")
                    {
                        nomeAbilità = "AffinitàAnimale";
                    }
                    else
                    {
                        nomeAbilità = abilità[0];
                    }
                    string valAbilità = abilità[1];
                    for (int i = 1; i <= 5; i++)
                    {
                        string radioButtonName = $"{nomeAbilità}_radioButton_{i}";
                        Control[] control_1 = this.Controls.Find(radioButtonName, true);
                        if (control_1.Length > 0 && control_1[0] is RadioButton radioButton)
                        {
                            int radioButtonValue;
                            bool isNumeric = int.TryParse(valAbilità, out radioButtonValue);

                            if (isNumeric)
                            {
                                radioButton.Checked = (i == radioButtonValue);
                            }
                        }
                    }
                    string textBoxName = $"{ nomeAbilità}_TextBox";
                    Control[] control_2 = this.Controls.Find(textBoxName, true);
                    if (control_2.Length > 0 && control_2[0] is TextBox textBox)
                    {
                        if(abilità.Length==4)
                        {
                            textBox.Text = $"{abilità[0]} {abilità[2]} {abilità[3]}";
                        }
                        else if (abilità.Length==3)
                        {
                            textBox.Text = $"{abilità[0]} {abilità[2]}";
                        }
                        else
                        {
                            int textvalue;
                            bool isNumeric = int.TryParse(abilità.Last(),out textvalue);
                            if (!isNumeric)
                            {
                                textBox.Text = $"{abilità[0]} {abilità[1]}";
                            }
                        }
                    }

                }
            Create_CharacterPag2 = new CreateCharacterPag2(pgGenerator.clanname, chooseVampire, chooseGhoul, chooseHuman, pgGenerator.num_difettipoints, pgGenerator.num_vantaggipoints, pgGenerator.vampiretitle, BloodPotency, umanità, pregioPredatore, difettoPredatore, pgGenerator.poteri);

        }
        private void Powers_button_Click(object sender, EventArgs e)
            {
                Create_CharacterPag2.Show();
                this.Hide();
            }

            private void CreateCharacterPag1_Load(object sender, EventArgs e)
            {

            }

    }
}
