using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp1
{
    public partial class CreateCharacterPag2 : Form
    {
        static string[] bonuslist;
        static string[] maluslist;
        public string[] Potericonosciuti;
        public string  _clanname;
        public string choosenPGtype;
        public int _numanita;
        public int _numblodpotency;
        public int umanita;
        public int bloodPoint;
        public CreateCharacterPag2(string clanname,bool chooseVampire, bool chooseGhoul, bool chooseHuman, int num_difettipoints, int num_vantaggipoints,string  vampiretitle,int BloodPotency, int numanità, string pregioPredatore, string difettoPredatore, string[] poteri)
        {
            _clanname = clanname;
            _numanita = numanità;
            _numblodpotency = BloodPotency;
            Potericonosciuti = poteri;
            if (chooseVampire) 
            { choosenPGtype = "Vampire";}
            else if (chooseGhoul) { choosenPGtype = "Ghoul";}
            else if (chooseHuman) { choosenPGtype = "Human";}
            var ChooseBonusMalus = Choose_BonusMalus.Generator(clanname,  chooseVampire,  chooseGhoul,  chooseHuman, num_difettipoints, num_vantaggipoints, vampiretitle, pregioPredatore, difettoPredatore);
            bonuslist = ChooseBonusMalus[0];
            maluslist = ChooseBonusMalus[1];
            InitializeComponent();
        }
        private void CreateCharacterPag2_Load(object sender, EventArgs e)
        {

           string[] poteriNotThin = { "Animalism", "Auspex", "Blood Sorcery", "Celerity", "Dominate", "Fortitude", "Obfuscate", "Oblivion", "Potence", "Presence", "Protean" };
           string[] _poteri = { "Animalism", "Auspex", "Blood Sorcery", "Celerity", "Dominate", "Fortitude", "Obfuscate", "Oblivion", "Potence", "Presence", "Protean", "Thin-Blood Alchemy" };
           string[] ominbonus = {"Short Bond","Unbondable","Blood Hound","Iron Gullet","LInguistic","Beautiful","Stunning",
                                 "Eat food","High Functioning" ,"Chasse","Lien","Portillion","Blood Empathy", "Unseemly aura", "Linguistic", "Beautiful", "Stunning", "Substance Use" ,"Linguistic", "Beautiful", "Stunning", "Substance Use" ,"Alleati", "Contatti", "Fama", "Influenza", "Gregge", "Maschera", "Mawla", "Rifugio", "Risorse", "Seguace", "Status" ,"Affinità in una Disciplina", "Alchimista Sangue debole", "Bevitore Diurno", "Compagni Anarchici", "Contatto nella Camarilla",
                                 "Resilienza Vampirica", "Sangue Concatenato", "Sembianza Vitale","Hesha Ruhadze", "The Church of Set", "Descendant of Xaviar (Gangrel only)", "Descendant of Tyler (Brujah only)",
                                 "Ruins of Carthage", "Blood Plagued", "Anarch Revolt", "Camarilla", "Carmelita Neillson",
                                 "Fatima al-Faqadi", "Fiorenza Savona", "Pure Ventrue Lineage (Ven" +
                                 "true only)", "The Cult of Mithras", "The Pyramid (Tremere only)", "Victoria Ash","Annabelle",
                                 "Ballard Industries","Blacksite 24","The Blue Velvet","The Book of Nod","Capone Gang","The Cobweb (Malkavian only)","Cultivar","Cult of Shalim",
                                 "Descendant of Lodin (Ventrue only)","Descendant of Montano (Lasombra only)","Fires and Floods and Devil's Night","Firstlight","Wauneka","Kevin Jackson","Kindred Iconography","The Labyrinth",
                                 "Lupine Expert","Nathaniel Bordruff","The Painted Lady","Revenant Family: Ducheski (Tremere only)","The Society of St. Leopold","Archons", "The Convention of Chicago", "Descendant of Menele (Brujah only)",
                                 "Goblin Roads", "Justicar Lucinde", "Khalid al-Rashid", "Kindred Dueling","Malkavian Family (Malkavian only)", "Occult Artifacts (Tremere and Banu Haqim only)", "The Pony Express",
                                 "Sheriff Damien", "The Wolf Pack", "Children of the Blood", "The Ashfinders (Thin-Blooded only)", "Amaranthan", "Cleopatras (Nosferatu only)", "Meneleans", "The One True Way", "Starfall Ranch (Malkavian only)",
                                 "Agent of Justicar Parr", "Court of Shadows", "Hunt Club", "London Under London (Nosferatu only)", "Operation Antigen", "Oskar Anasov", "Forbidden Religions", "1444 Chamber (Hecata only)", "Blood Asceticism",
                                 "Gehenna Cults", "Plagues of Gehenna", "Praepositor (Tremere only)", "Spear of Orthia (Ventrue only)", "The Anubi", "Eletria", "Kindred Social Media Influencer", "Juggler", "Lost Secrets of the Milwaukee Chantry",
                                 "Mark Decker", "Maxwell", "The Milwaukee 'Null Zone'", "Modius","The Ruby Throat", "Descendant of Roger de Camden (Hecata only)", "Relics of the Veil Wolves in Sheep's Clothing", "The Nictuku", "Relics of the Veil",
                                 "Wolves in Sheep's Clothing","The Nictuku","Ashfinders", "Bahari", "Church of Caine", "Church of Set", "Cult of Shalim", "Mithraic Mysteries", "Nephilim", "Little Siblings (Hecata only)", "Grudge Masters (Hecata only)", "Bankers of Dunsirn (Hecata only)", "Children of Tenochtitlan (Hecata only)",
                                 "Descendants of the Baron (Hecata only)", "Flesh-Eaters (Hecata only)", "Harbingers of Ashur (Hecata only)",
                                 "La Famiglia Giovanni (Hecata only)", "The Criminal Puttanesca (Hecata only)", "The Gorgons (Hecata only)"};
            int i=0;
            int a = 1;
            foreach (string bonus in bonuslist)
            {
                if (bonus != null)
                {   while (a <= 7)
                    {
                        string vantaggi_comboBoxName = $"vantaggi_comboBox_{a}";
                        Control[] controls = this.Controls.Find(vantaggi_comboBoxName, true);
                        if (controls.Length > 0 && controls[0] is ComboBox comboBox)
                        {
                            comboBox.Items.Insert(i, bonus);
                        }
                        a++;
                    }
                    Controls.Find("vantaggi_comboBox_" + (i+1), true)[0].Text = bonuslist[i];
                    i++;
                    a = 1;
                }
                else
                {
                    continue;
                }
            } 

            i = 0;
            a = 1;
            if (_clanname == "SANGUE DEBOLE")
            {
                foreach(string potere in _poteri)
                {
                    string disciplina_comboBoxName = $"disciplina_comboBox_{a}";
                    Control[] controls = this.Controls.Find(disciplina_comboBoxName, true);
                    if (controls.Length > 0 && controls[0] is ComboBox comboBox)
                    {
                        comboBox.Items.Insert(i, potere);
                    }

                }
            }
            else
            {
                foreach (string potere in poteriNotThin)
                {
                        string disciplina_comboBoxName = $"disciplina_comboBox_{a}";
                        Control[] controls = this.Controls.Find(disciplina_comboBoxName, true);
                        if (controls.Length > 0 && controls[0] is ComboBox comboBox)
                        {
                            comboBox.Items.Insert(i, potere);
                            
                        }
                }
            }
            i = 0;
            a = 1;
            foreach (string potere in Potericonosciuti)
            {
                string disciplina_comboBoxName = $"disciplina_comboBox_{a}";
                Control[] controls = this.Controls.Find(disciplina_comboBoxName, true);
                if (controls.Length > 0 && controls[0] is ComboBox comboBox)
                {
                    Controls.Find(disciplina_comboBoxName, true)[0].Text = potere;

                }
                a++;
                i++;
            }
            a = 1;
            while (  umanita < _numanita)
            {
                string umanità_radioButtonName = $"umanità_radioButton{a}";
                Control[] controls = this.Controls.Find(umanità_radioButtonName, true);
                if (controls.Length > 0 && controls[0] is RadioButton radioButton)
                {

                        radioButton.Checked = true;
                }
               a =  umanita++;

            }
            a = 0;
            while (bloodPoint < _numblodpotency)
            {
                string blood_radioButton_Name = $"blood_radioButton_{a}";
                Control[] controls = this.Controls.Find(blood_radioButton_Name, true);
                if (controls.Length > 0 && controls[0] is RadioButton radioButton)
                {

                    radioButton.Checked = true;
                }
                a = bloodPoint++;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
