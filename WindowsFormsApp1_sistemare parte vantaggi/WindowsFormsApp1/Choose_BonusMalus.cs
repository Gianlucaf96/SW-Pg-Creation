using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Choose_BonusMalus
   {
        static string[] bonusType = { "Vampire", "Ghoul", "Human", "Background", "Loresheet", "Thin Blood" };
        static string[] malusType = { "Vampire", "Ghoul", "Human", "Background", "Loresheet", "Thin Blood" };
        static string[] vampirebonuslist = {"Legame breve,2","Invincolabile,5","Segugio ematico,1","Stomaco di ferro,1","Linguista","Attraente,2","Strepitoso,4",
                                            "mangiare cibo,2","Dipendenza ad alta funzionalità,1"};
        static string[] ghoulbonuslist = { "Blood Empathy,2", "Unseemly aura,2", "Linguista", "Attraente,2", "Strepitoso,4", "Dipendenza ad alta funzionalità,1" };
        static string[] humanbonuslist = { "Linguista", "Attraente,2", "Strepitoso,4", "Dipendenza ad alta funzionalità,1" };
    
        static string[] backgroundbonuslist = {"Alleati","Contatti","Fama","Influenza","Gregge","Maschera","Mawla","Rifugio","Risorse","Seguace","Status"};
        static string[] thinbloodbonus = { "Affinità in una Disciplina", "Alchimista Sangue debole", "Bevitore Diurno", "Compagni Anarchici", "Contatto nella Camarilla",
                                    "Resilienza Vampirica", "Sangue Concatenato", "Sembianza Vitale", };
        static string[] listthinbloodmalus = {"casa","true vampire hunger","light sensivity" };
         static string[] Loresheet =  
        {"Hesha Ruhadze", "The Church of Set", "Descendant of Xaviar (Gangrel only)", "Descendant of Tyler (Brujah only)", 
         "Ruins of Carthage", "Blood Plagued", "Anarch Revolt", "Camarilla", "Carmelita Neillson",
         "Fatima al-Faqadi", "Fiorenza Savona", "Pure Ventrue Lineage (Ventrue only)", "The Cult of Mithras", "The Pyramid (Tremere only)", "Victoria Ash","Annabelle",
         "Ballard Industries","Blacksite 24","The Blue Velvet","The Book of Nod","Capone Gang","The Cobweb (Malkavian only)","Cultivar","Cult of Shalim",
         "Descendant of Lodin (Ventrue only)","Descendant of Montano (Lasombra only)","Fires and Floods and Devil's Night","Firstlight","Wauneka","Kevin Jackson","Kindred Iconography","The Labyrinth",
         "Lupine Expert","Nathaniel Bordruff","The Painted Lady","Revenant Family: Ducheski (Tremere only)","The Society of St. Leopold","Archons", "The Convention of Chicago", "Descendant of Menele (Brujah only)",
         "Goblin Roads", "Justicar Lucinde", "Khalid al-Rashid", "Kindred Dueling","Malkavian Family (Malkavian only)", "Occult Artifacts (Tremere and Banu Haqim only)", "The Pony Express",
         "Sheriff Damien", "The Wolf Pack", "Children of the Blood", "The Ashfinders (Thin-Blooded only)", "Amaranthan", "Cleopatras (Nosferatu only)", "Meneleans", "The One True Way", "Starfall Ranch (Malkavian only)",
         "Agent of Justicar Parr", "Court of Shadows", "Hunt Club", "London Under London (Nosferatu only)", "Operation Antigen", "Oskar Anasov", "Forbidden Religions", "1444 Chamber (Hecata only)", "Blood Asceticism", 
         "Gehenna Cults", "Plagues of Gehenna", "Praepositor (Tremere only)", "Spear of Orthia (Ventrue only)", "The Anubi", "Eletria", "Kindred Social Media Influencer", "Juggler", "Lost Secrets of the Milwaukee Chantry",
         "Mark Decker", "Maxwell", "The Milwaukee 'Null Zone'", "Modius","The Ruby Throat", "Descendant of Roger de Camden (Hecata only)", "Relics of the Veil Wolves in Sheep's Clothing", "The Nictuku", "Relics of the Veil",
         "Wolves in Sheep's Clothing","The Nictuku"};
         static string[] cults = { "Ashfinders", "Bahari", "Church of Caine", "Church of Set", "Cult of Shalim", "Mithraic Mysteries", "Nephilim" };
         static string[] bloodlines = { "Little Siblings (Hecata only)", "Grudge Masters (Hecata only)", "Bankers of Dunsirn (Hecata only)", "Children of Tenochtitlan (Hecata only)", 
                                "Descendants of the Baron (Hecata only)", "Flesh-Eaters (Hecata only)", "Harbingers of Ashur (Hecata only)", 
                                "La Famiglia Giovanni (Hecata only)", "The Criminal Puttanesca (Hecata only)", "The Gorgons (Hecata only)" };


        public static  List<string[]> Generator(string clanname, bool chooseVampire, bool chooseGhoul, bool chooseHuman, int num_difettipoints, int num_vantaggipoints, string vampiretitle, string pregioPredatore, string difettoPredatore)
        {
            string[] pregiPredatore    =    pregioPredatore.Split('-');
            string[] difettiiPredatore = difettoPredatore.Split('-');
            string[] listchoosenbonus = new string[num_vantaggipoints + 4];
            string[] listofchoosenmalus = new string[num_difettipoints + 4];
            int choosenbonuscounter = 1;
            int choosenmaluscounter = 1;
            int listchoosenbonus_index = 0;
            int lischoosenmalus_index = 0;
            int pointsnonspesi = 10;
            int c = 0;
            Random rBonustype = new Random();
            Random rmalusType = new Random();
            while ( choosenbonuscounter < num_vantaggipoints || choosenmaluscounter < num_difettipoints )
            {
                if (choosenbonuscounter < num_vantaggipoints)
                {
                    if (chooseVampire && clanname == "SANGUE DEBOLE")
                    {
                        List<string[]> bonusTypes = new List<string[]> { vampirebonuslist, humanbonuslist, backgroundbonuslist, thinbloodbonus };
                        string[] bonusTypesnames = { "vampirebonuslist", "humanbonuslist", "backgroundbonuslist", "thinbloodbonus" };
                        int index_bonuslist = rBonustype.Next(bonusTypes.Count);
                        string selectedBonusArrayName = bonusTypesnames[index_bonuslist];
                        string[] selectedBonusArray = bonusTypes[index_bonuslist];
                        string selectedbonusArray = bonusTypes[index_bonuslist].ToString();
                        int choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                        string selectedBonus = selectedBonusArray[choosenbonus] + "";
                        if (!selectedBonusArrayName.Contains("thinbloodbonus"))
                        {
                            if (selectedBonus.Contains("Only"))
                            {
                                string[] checkesclusivity = selectedBonus.Split('(');
                                if (checkesclusivity[1] == clanname)
                                {   string[] _selectedBonus = selectedBonus.Split(',');
                                    if (_selectedBonus.Length>1)
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else
                                    {
                                        Random _rCost = new Random();
                                        int rcost = _rCost.Next(1,6);
                                        if (_selectedBonus[0] == "Linguista")
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (backgroundbonuslist.Contains(_selectedBonus[0]))
                                        {
                                            if (_selectedBonus[0] == "Alleati")
                                            {

                                                int randomNumber_1 = _rCost.Next(1, 5);
                                                int randomNumber_2 = _rCost.Next(1, 4);
                                                while ((randomNumber_1+ randomNumber_2)>7)
                                                {
                                                     randomNumber_1 = _rCost.Next(1, 5);
                                                     randomNumber_2 = _rCost.Next(1, 4);
                                                }
                                                choosenbonuscounter = choosenbonuscounter + randomNumber_1 + randomNumber_2;
                                                listchoosenbonus[listchoosenbonus_index] = $"{_selectedBonus[0]}: Efficacia {randomNumber_1} Affidabilità {randomNumber_2}";
                                            }
                                            else if (_selectedBonus[0] == "Contatti")
                                            {
                                                rcost = _rCost.Next(1, 4);
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                            else if (_selectedBonus[0] == "Fama" || _selectedBonus[0] == "Influenza"|| _selectedBonus[0] == "Gregge"|| _selectedBonus[0] == "Mawla)"|| _selectedBonus[0] == "Risorse"|| _selectedBonus[0] == "Status")
                                            {
                                                rcost = _rCost.Next(1, 6);
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                            else if (_selectedBonus[0] == "Maschera")
                                            {
                                                rcost = _rCost.Next(1, 6);
                                                if (rcost>=2)
                                                {
                                                    int chooseifadd = _rCost.Next(1, 3);
                                                    if (chooseifadd > 1)
                                                    {
                                                        int choose = _rCost.Next(0,3);
                                                        string[] bonusMaschera = { "Azzerato", "Falsario" };
                                                        if (choose<3)
                                                        {
                                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0]+" "+bonusMaschera[choose];
                                                            choosenbonuscounter = choosenbonuscounter + rcost+1;
                                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                                        }
                                                        else
                                                        {
                                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + bonusMaschera[0]+" "+ bonusMaschera[1];
                                                            choosenbonuscounter = choosenbonuscounter + rcost + 2;
                                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                                        }
                                                    }
                                                }    
                                                else 
                                                {
                                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                                }

                                            }
                                            else if (_selectedBonus[0] == "Rifugio")
                                            {
                                                rcost = _rCost.Next(1, 4);
                                                int chooseifadd = _rCost.Next(1, 3);
                                                if (chooseifadd>1)
                                                {
                                                   int bonusrifugiocost = _rCost.Next(1, 5);
                                                   int costusato = 1;
                                                    string[] bonusrifugio = { };
                                                    List<string> elencobonusrifugio = new List<string> { "Arsenale nascosto", "Biblioteca", "Cella", "Guardiani", "Laboratorio", "Lusso", "Posterla", "Protezione", "Sala operatoria", "Sistema di sicurezza", "Ubicazione" };
                                                   while (costusato < bonusrifugiocost)
                                                   {
                                                        int indexbonusrifugio = _rCost.Next(elencobonusrifugio.Count);
                                                        bonusrifugio[(costusato-1)] = ( elencobonusrifugio[indexbonusrifugio]);
                                                        elencobonusrifugio.RemoveAt(indexbonusrifugio);
                                                        costusato++;
                                                   }
                                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0]+ bonusrifugio;
                                                    choosenbonuscounter = choosenbonuscounter + rcost+ bonusrifugiocost;
                                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                                }
                                                else
                                                {
                                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                                }
                                            }
                                            else if (_selectedBonus[0] == "Seguace")
                                            {
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                        }
                                        else if (Loresheet.Contains(_selectedBonus[0]))
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (cults.Contains(_selectedBonus[0]))
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (bloodlines.Contains(_selectedBonus[0]))
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                string[] _selectedBonus = selectedBonus.Split(',');
                                if (_selectedBonus.Length > 1)
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                    choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else
                                {
                                    Random _rCost = new Random();
                                    int rcost = _rCost.Next(1, 6);
                                    if (_selectedBonus[0] == "Linguista")
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (backgroundbonuslist.Contains(_selectedBonus[0]))
                                    {
                                        if (_selectedBonus[0] == "Alleati")
                                        {

                                            int randomNumber_1 = _rCost.Next(1, 5);
                                            int randomNumber_2 = _rCost.Next(1, 4);
                                            while ((randomNumber_1 + randomNumber_2) > 7)
                                            {
                                                randomNumber_1 = _rCost.Next(1, 5);
                                                randomNumber_2 = _rCost.Next(1, 4);
                                            }
                                            choosenbonuscounter = choosenbonuscounter + randomNumber_1 + randomNumber_2;
                                            listchoosenbonus[listchoosenbonus_index] = $"{_selectedBonus[0]}: Efficacia {randomNumber_1} Affidabilità {randomNumber_2}";
                                        }
                                        else if (_selectedBonus[0] == "Contatti")
                                        {
                                            rcost = _rCost.Next(1, 4);
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (_selectedBonus[0] == "Fama" || _selectedBonus[0] == "Influenza" || _selectedBonus[0] == "Gregge" || _selectedBonus[0] == "Mawla)" || _selectedBonus[0] == "Risorse" || _selectedBonus[0] == "Status")
                                        {
                                            rcost = _rCost.Next(1, 6);
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (_selectedBonus[0] == "Maschera")
                                        {
                                            rcost = _rCost.Next(1, 6);
                                            if (rcost >= 2)
                                            {
                                                int chooseifadd = _rCost.Next(1, 3);
                                                if (chooseifadd > 1)
                                                {
                                                    int choose = _rCost.Next(0, 3);
                                                    string[] bonusMaschera = { "Azzerato", "Falsario" };
                                                    if (choose < 3)
                                                    {
                                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + bonusMaschera[choose];
                                                        choosenbonuscounter = choosenbonuscounter + rcost + 1;
                                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                                    }
                                                    else
                                                    {
                                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + bonusMaschera[0] + " " + bonusMaschera[1];
                                                        choosenbonuscounter = choosenbonuscounter + rcost + 2;
                                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }

                                        }
                                        else if (_selectedBonus[0] == "Rifugio")
                                        {
                                            rcost = _rCost.Next(1, 4);
                                            int chooseifadd = _rCost.Next(1, 3);
                                            if (chooseifadd > 1)
                                            {
                                                int bonusrifugiocost = _rCost.Next(1, 5);
                                                int costusato = 1;
                                                string[] bonusrifugio = { };
                                                List<string> elencobonusrifugio = new List<string> { "Arsenale nascosto", "Biblioteca", "Cella", "Guardiani", "Laboratorio", "Lusso", "Posterla", "Protezione", "Sala operatoria", "Sistema di sicurezza", "Ubicazione" };
                                                while (costusato < bonusrifugiocost)
                                                {
                                                    int indexbonusrifugio = _rCost.Next(elencobonusrifugio.Count);
                                                    bonusrifugio[(costusato - 1)] = (elencobonusrifugio[indexbonusrifugio]);
                                                    elencobonusrifugio.RemoveAt(indexbonusrifugio);
                                                    costusato++;
                                                }
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + bonusrifugio;
                                                choosenbonuscounter = choosenbonuscounter + rcost + bonusrifugiocost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                            else
                                            {
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                        }
                                        else if (_selectedBonus[0] == "Seguace")
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                    }
                                    else if (Loresheet.Contains(_selectedBonus[0]))
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (cults.Contains(_selectedBonus[0]))
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (bloodlines.Contains(_selectedBonus[0]))
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (c <= 1)
                            {
                                listchoosenbonus[listchoosenbonus_index] = selectedBonus;
                                int choosethinbloodmalus = rmalusType.Next(listthinbloodmalus.Length);
                                listofchoosenmalus[lischoosenmalus_index] = listthinbloodmalus[choosethinbloodmalus];
                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                lischoosenmalus_index = lischoosenmalus_index + 1;
                                c++;
                            }
                            continue;
                        }

                    }
                    else if (chooseVampire)
                    {
                        List<string[]> bonusTypes = new List<string[]> { vampirebonuslist, ghoulbonuslist, humanbonuslist, backgroundbonuslist, Loresheet };
                        int index_bonuslist = rBonustype.Next(bonusTypes.Count);
                        string[] selectedBonusArray = bonusTypes[index_bonuslist];
                        int choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                        string selectedBonus = selectedBonusArray[choosenbonus] + "";
                        while (listchoosenbonus.Contains(selectedBonus))
                        {
                            index_bonuslist = rBonustype.Next(bonusTypes.Count);
                            selectedBonusArray = bonusTypes[index_bonuslist];
                            choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                            selectedBonus = selectedBonusArray[choosenbonus] + "";
                        }
                        string selectedbonus = selectedBonus.ToLower();
                        if (selectedbonus.Contains("only"))
                        {
                            string[] checkesclusivity = selectedbonus.Split('(');
                            if (checkesclusivity[1].Contains( clanname.ToLower()))
                            {
                                string[] _selectedBonus = selectedBonus.Split(',');
                                if (_selectedBonus.Length > 1)
                                {   if (pointsnonspesi >= Int32.Parse(_selectedBonus[1]))
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + _selectedBonus[1];
                                        choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else
                                    {   while(pointsnonspesi < Int32.Parse(_selectedBonus[1]))
                                        {
                                            index_bonuslist = rBonustype.Next(bonusTypes.Count);
                                            selectedBonusArray = bonusTypes[index_bonuslist];
                                            choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                                            selectedBonus = selectedBonusArray[choosenbonus] + "";
                                        }
                                    }
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0]+" "+ _selectedBonus[1];
                                    choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else
                                {
                                    Random _rCost = new Random();
                                    int rcost = _rCost.Next(1, 6);
                                    if (_selectedBonus[0] == "Linguista")
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0]+" "+rcost;
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (backgroundbonuslist.Contains(_selectedBonus[0]))
                                    {
                                        if (_selectedBonus[0] == "Alleati")
                                        {
                                            int randomNumber_1;
                                            int randomNumber_2;
                                            if (pointsnonspesi<4)
                                            {
                                              randomNumber_1 = _rCost.Next(1, (pointsnonspesi+1));
                                            }
                                            if (pointsnonspesi<3)
                                            {
                                                 randomNumber_1 = _rCost.Next(1, pointsnonspesi);
                                                 randomNumber_2 = _rCost.Next(1, pointsnonspesi);
                                            }
                                            else
                                            {
                                                randomNumber_1 = _rCost.Next(1, 5);
                                                randomNumber_2 = _rCost.Next(1, 4);
                                            }
                                            while ((randomNumber_1 + randomNumber_2) > 7)
                                            {
                                                if (pointsnonspesi < 4)
                                                {
                                                    randomNumber_1 = _rCost.Next(1, (pointsnonspesi + 1));
                                                }
                                                if (pointsnonspesi < 3)
                                                {
                                                    randomNumber_1 = _rCost.Next(1, pointsnonspesi);
                                                    randomNumber_2 = _rCost.Next(1, pointsnonspesi);
                                                }
                                                else
                                                {
                                                    randomNumber_1 = _rCost.Next(1, 5);
                                                    randomNumber_2 = _rCost.Next(1, 4);
                                                }
                                            }
                                            choosenbonuscounter = choosenbonuscounter + randomNumber_1 + randomNumber_2;
                                            listchoosenbonus[listchoosenbonus_index] = $"{_selectedBonus[0]}: Efficacia {randomNumber_1} Affidabilità {randomNumber_2}";
                                        }
                                        else if (_selectedBonus[0] == "Contatti")
                                        {
                                            if (pointsnonspesi<3)
                                            {
                                                rcost = _rCost.Next(1, pointsnonspesi);
                                            }
                                            else
                                            {
                                                rcost = _rCost.Next(1, 4);
                                            }
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (_selectedBonus[0] == "Fama" || _selectedBonus[0] == "Influenza" || _selectedBonus[0] == "Gregge" || _selectedBonus[0] == "Mawla)" || _selectedBonus[0] == "Risorse" || _selectedBonus[0] == "Status")
                                        {
                                            if (pointsnonspesi<5)
                                            {
                                                rcost = _rCost.Next(1, pointsnonspesi);
                                            }
                                            else
                                            {
                                                rcost = _rCost.Next(1, 6);
                                            }
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (_selectedBonus[0] == "Maschera")
                                        {
                                            if (pointsnonspesi < 5)
                                            {
                                                rcost = _rCost.Next(1, pointsnonspesi);
                                            }
                                            else
                                            {
                                                rcost = _rCost.Next(1, 6);
                                            }
                                            if (rcost >= 2 && pointsnonspesi >= 3)
                                            {
                                                int chooseifadd = _rCost.Next(1, 3);
                                                if (chooseifadd > 1)
                                                {
                                                    int choose = _rCost.Next(0, 3);
                                                    string[] bonusMaschera = { "Azzerato", "Falsario" };
                                                    if (choose < 3)
                                                    {
                                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] +" "+rcost+ " " + bonusMaschera[choose];
                                                        choosenbonuscounter = choosenbonuscounter + rcost + 1;
                                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                                    }
                                                    else
                                                    {
                                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0]+rcost + " " + bonusMaschera[0] + " " + bonusMaschera[1];
                                                        choosenbonuscounter = choosenbonuscounter + rcost + 2;
                                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " "+rcost;
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }

                                        }
                                        else if (_selectedBonus[0] == "Rifugio")
                                        {
                                            if (pointsnonspesi < 3)
                                            {
                                                rcost = _rCost.Next(1, pointsnonspesi);
                                            }
                                            else
                                            {
                                                rcost = _rCost.Next(1, 4);
                                            }
                                            int chooseifadd = _rCost.Next(1, 3);
                                            if (chooseifadd > 1 && pointsnonspesi >=4)
                                            {
                                                int bonusrifugiocost = _rCost.Next(1, 5);
                                                int costusato = 1;
                                                string[] bonusrifugio = { };
                                                List<string> elencobonusrifugio = new List<string> { "Arsenale nascosto", "Biblioteca", "Cella", "Guardiani", "Laboratorio", "Lusso", "Posterla", "Protezione", "Sala operatoria", "Sistema di sicurezza", "Ubicazione" };
                                                while (costusato < bonusrifugiocost)
                                                {
                                                    int indexbonusrifugio = _rCost.Next(elencobonusrifugio.Count);
                                                    bonusrifugio[(costusato - 1)] = (elencobonusrifugio[indexbonusrifugio]);
                                                    elencobonusrifugio.RemoveAt(indexbonusrifugio);
                                                    costusato++;
                                                }
                                                listchoosenbonus[listchoosenbonus_index] =$"{_selectedBonus[0]} {rcost} {bonusrifugio}" ;
                                                choosenbonuscounter = choosenbonuscounter + rcost + bonusrifugiocost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                            else
                                            {
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0]+" "+rcost;
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                        }
                                        else if (_selectedBonus[0] == "Seguace")
                                        {
                                            if (pointsnonspesi < 3)
                                            {
                                                rcost = _rCost.Next(1, pointsnonspesi);
                                            }
                                            else
                                            {
                                                rcost = _rCost.Next(1, 4);
                                            }
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0]+" "+rcost;
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                    }
                                    else if (Loresheet.Contains(_selectedBonus[0]))
                                    {
                                        if (pointsnonspesi < 5)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 6);
                                        }
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (cults.Contains(_selectedBonus[0]))
                                    {
                                        if (pointsnonspesi <= 5)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 6);
                                        }
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (bloodlines.Contains(_selectedBonus[0]))
                                    {
                                        if (pointsnonspesi < 5)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 6);
                                        }
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            string[] _selectedBonus = selectedBonus.Split(',');
                            if (_selectedBonus.Length > 1)
                            {
                                if (pointsnonspesi >= Int32.Parse(_selectedBonus[1]))
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + _selectedBonus[1];
                                    choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else
                                {
                                    while (pointsnonspesi < Int32.Parse(_selectedBonus[1]))
                                    {
                                        index_bonuslist = rBonustype.Next(bonusTypes.Count);
                                        selectedBonusArray = bonusTypes[index_bonuslist];
                                        choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                                        selectedBonus = selectedBonusArray[choosenbonus] + "";
                                    }
                                }
                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + _selectedBonus[1];
                                choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                listchoosenbonus_index = listchoosenbonus_index + 1;
                            }
                            else
                            {
                                Random _rCost = new Random();
                                int rcost = _rCost.Next(1, 6);
                                if (_selectedBonus[0] == "Linguista")
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else if (backgroundbonuslist.Contains(_selectedBonus[0]))
                                {
                                    if (_selectedBonus[0] == "Alleati")
                                    {
                                        int randomNumber_1;
                                        int randomNumber_2;
                                        if (pointsnonspesi < 4)
                                        {
                                            randomNumber_1 = _rCost.Next(1, (pointsnonspesi + 1));
                                        }
                                        if (pointsnonspesi < 3)
                                        {
                                            randomNumber_1 = _rCost.Next(1, pointsnonspesi);
                                            randomNumber_2 = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            randomNumber_1 = _rCost.Next(1, 5);
                                            randomNumber_2 = _rCost.Next(1, 4);
                                        }
                                        while ((randomNumber_1 + randomNumber_2) > 7)
                                        {
                                            if (pointsnonspesi < 4)
                                            {
                                                randomNumber_1 = _rCost.Next(1, (pointsnonspesi + 1));
                                            }
                                            if (pointsnonspesi < 3)
                                            {
                                                randomNumber_1 = _rCost.Next(1, pointsnonspesi);
                                                randomNumber_2 = _rCost.Next(1, pointsnonspesi);
                                            }
                                            else
                                            {
                                                randomNumber_1 = _rCost.Next(1, 5);
                                                randomNumber_2 = _rCost.Next(1, 4);
                                            }
                                        }
                                        choosenbonuscounter = choosenbonuscounter + randomNumber_1 + randomNumber_2;
                                        listchoosenbonus[listchoosenbonus_index] = $"{_selectedBonus[0]}: Efficacia {randomNumber_1} Affidabilità {randomNumber_2}";
                                    }
                                    else if (_selectedBonus[0] == "Contatti")
                                    {
                                        if (pointsnonspesi < 3)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 4);
                                        }
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (_selectedBonus[0] == "Fama" || _selectedBonus[0] == "Influenza" || _selectedBonus[0] == "Gregge" || _selectedBonus[0] == "Mawla)" || _selectedBonus[0] == "Risorse" || _selectedBonus[0] == "Status")
                                    {
                                        if (pointsnonspesi < 5)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 6);
                                        }
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (_selectedBonus[0] == "Maschera")
                                    {
                                        if (pointsnonspesi < 5)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 6);
                                        }
                                        if (rcost >= 2 && pointsnonspesi >= 3)
                                        {
                                            int chooseifadd = _rCost.Next(1, 3);
                                            if (chooseifadd > 1)
                                            {
                                                int choose = _rCost.Next(0, 3);
                                                string[] bonusMaschera = { "Azzerato", "Falsario" };
                                                if (choose < 3)
                                                {
                                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost + " " + bonusMaschera[choose];
                                                    choosenbonuscounter = choosenbonuscounter + rcost + 1;
                                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                                }
                                                else
                                                {
                                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + rcost + " " + bonusMaschera[0] + " " + bonusMaschera[1];
                                                    choosenbonuscounter = choosenbonuscounter + rcost + 2;
                                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }

                                    }
                                    else if (_selectedBonus[0] == "Rifugio")
                                    {
                                        if (pointsnonspesi < 3)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 4);
                                        }
                                        int chooseifadd = _rCost.Next(1, 3);
                                        if (chooseifadd > 1 && pointsnonspesi >= 4)
                                        {
                                            int bonusrifugiocost = _rCost.Next(1, 5);
                                            int costusato = 1;
                                            string[] bonusrifugio = { };
                                            List<string> elencobonusrifugio = new List<string> { "Arsenale nascosto", "Biblioteca", "Cella", "Guardiani", "Laboratorio", "Lusso", "Posterla", "Protezione", "Sala operatoria", "Sistema di sicurezza", "Ubicazione" };
                                            while (costusato < bonusrifugiocost)
                                            {
                                                int indexbonusrifugio = _rCost.Next(elencobonusrifugio.Count);
                                                bonusrifugio[(costusato - 1)] = (elencobonusrifugio[indexbonusrifugio]);
                                                elencobonusrifugio.RemoveAt(indexbonusrifugio);
                                                costusato++;
                                            }
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost + " " + bonusrifugio;
                                            choosenbonuscounter = choosenbonuscounter + rcost + bonusrifugiocost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                    }
                                    else if (_selectedBonus[0] == "Seguace")
                                    {
                                        if (pointsnonspesi < 3)
                                        {
                                            rcost = _rCost.Next(1, pointsnonspesi);
                                        }
                                        else
                                        {
                                            rcost = _rCost.Next(1, 4);
                                        }
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                }
                                else if (Loresheet.Contains(_selectedBonus[0]))
                                {
                                    if (pointsnonspesi < 5)
                                    {
                                        rcost = _rCost.Next(1, pointsnonspesi);
                                    }
                                    else
                                    {
                                        rcost = _rCost.Next(1, 6);
                                    }
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else if (cults.Contains(_selectedBonus[0]))
                                {
                                    if (pointsnonspesi <= 5)
                                    {
                                        rcost = _rCost.Next(1, pointsnonspesi);
                                    }
                                    else
                                    {
                                        rcost = _rCost.Next(1, 6);
                                    }
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else if (bloodlines.Contains(_selectedBonus[0]))
                                {
                                    if (pointsnonspesi < 5)
                                    {
                                        rcost = _rCost.Next(1, pointsnonspesi);
                                    }
                                    else
                                    {
                                        rcost = _rCost.Next(1, 6);
                                    }
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + rcost;
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                            }
                        }
                    }
                    else if (chooseGhoul)
                    {
                        List<string[]> bonusTypes = new List<string[]> { ghoulbonuslist, humanbonuslist, backgroundbonuslist, Loresheet };
                        int index_bonuslist = rBonustype.Next(bonusTypes.Count);
                        string[] selectedBonusArray = bonusTypes[index_bonuslist];
                        int choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                        string selectedBonus = selectedBonusArray[choosenbonus] + "";
                        if (selectedBonus.Contains("Only"))
                        {
                            string[] checkesclusivity = selectedBonus.Split('(');
                            if (checkesclusivity[1] == clanname)
                            {
                                string[] _selectedBonus = selectedBonus.Split(',');
                                if (_selectedBonus.Length > 1)
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                    choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else
                                {
                                    Random _rCost = new Random();
                                    int rcost = _rCost.Next(1, 6);
                                    if (_selectedBonus[0] == "Linguista")
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (backgroundbonuslist.Contains(_selectedBonus[0]))
                                    {
                                        if (_selectedBonus[0] == "Alleati")
                                        {

                                            int randomNumber_1 = _rCost.Next(1, 5);
                                            int randomNumber_2 = _rCost.Next(1, 4);
                                            while ((randomNumber_1 + randomNumber_2) > 7)
                                            {
                                                randomNumber_1 = _rCost.Next(1, 5);
                                                randomNumber_2 = _rCost.Next(1, 4);
                                            }
                                            choosenbonuscounter = choosenbonuscounter + randomNumber_1 + randomNumber_2;
                                            listchoosenbonus[listchoosenbonus_index] = $"{_selectedBonus[0]}: Efficacia {randomNumber_1} Affidabilità {randomNumber_2}";
                                        }
                                        else if (_selectedBonus[0] == "Contatti")
                                        {
                                            rcost = _rCost.Next(1, 4);
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (_selectedBonus[0] == "Fama" || _selectedBonus[0] == "Influenza" || _selectedBonus[0] == "Gregge" || _selectedBonus[0] == "Mawla)" || _selectedBonus[0] == "Risorse" || _selectedBonus[0] == "Status")
                                        {
                                            rcost = _rCost.Next(1, 6);
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else if (_selectedBonus[0] == "Maschera")
                                        {
                                            rcost = _rCost.Next(1, 6);
                                            if (rcost >= 2)
                                            {
                                                int chooseifadd = _rCost.Next(1, 3);
                                                if (chooseifadd > 1)
                                                {
                                                    int choose = _rCost.Next(0, 3);
                                                    string[] bonusMaschera = { "Azzerato", "Falsario" };
                                                    if (choose < 3)
                                                    {
                                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + bonusMaschera[choose];
                                                        choosenbonuscounter = choosenbonuscounter + rcost + 1;
                                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                                    }
                                                    else
                                                    {
                                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + bonusMaschera[0] + " " + bonusMaschera[1];
                                                        choosenbonuscounter = choosenbonuscounter + rcost + 2;
                                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }

                                        }
                                        else if (_selectedBonus[0] == "Rifugio")
                                        {
                                            rcost = _rCost.Next(1, 4);
                                            int chooseifadd = _rCost.Next(1, 3);
                                            if (chooseifadd > 1)
                                            {
                                                int bonusrifugiocost = _rCost.Next(1, 5);
                                                int costusato = 1;
                                                string[] bonusrifugio = { };
                                                List<string> elencobonusrifugio = new List<string> { "Arsenale nascosto", "Biblioteca", "Cella", "Guardiani", "Laboratorio", "Lusso", "Posterla", "Protezione", "Sala operatoria", "Sistema di sicurezza", "Ubicazione" };
                                                while (costusato < bonusrifugiocost)
                                                {
                                                    int indexbonusrifugio = _rCost.Next(elencobonusrifugio.Count);
                                                    bonusrifugio[(costusato - 1)] = (elencobonusrifugio[indexbonusrifugio]);
                                                    elencobonusrifugio.RemoveAt(indexbonusrifugio);
                                                    costusato++;
                                                }
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + bonusrifugio;
                                                choosenbonuscounter = choosenbonuscounter + rcost + bonusrifugiocost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                            else
                                            {
                                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                                choosenbonuscounter = choosenbonuscounter + rcost;
                                                listchoosenbonus_index = listchoosenbonus_index + 1;
                                            }
                                        }
                                        else if (_selectedBonus[0] == "Seguace")
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                    }
                                    else if (Loresheet.Contains(_selectedBonus[0]))
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (cults.Contains(_selectedBonus[0]))
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (bloodlines.Contains(_selectedBonus[0]))
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            string[] _selectedBonus = selectedBonus.Split(',');
                            if (_selectedBonus.Length > 1)
                            {
                                listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                                listchoosenbonus_index = listchoosenbonus_index + 1;
                            }
                            else
                            {
                                Random _rCost = new Random();
                                int rcost = _rCost.Next(1, 6);
                                if (_selectedBonus[0] == "Linguista")
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else if (backgroundbonuslist.Contains(_selectedBonus[0]))
                                {
                                    if (_selectedBonus[0] == "Alleati")
                                    {

                                        int randomNumber_1 = _rCost.Next(1, 5);
                                        int randomNumber_2 = _rCost.Next(1, 4);
                                        while ((randomNumber_1 + randomNumber_2) > 7)
                                        {
                                            randomNumber_1 = _rCost.Next(1, 5);
                                            randomNumber_2 = _rCost.Next(1, 4);
                                        }
                                        choosenbonuscounter = choosenbonuscounter + randomNumber_1 + randomNumber_2;
                                        listchoosenbonus[listchoosenbonus_index] = $"{_selectedBonus[0]}: Efficacia {randomNumber_1} Affidabilità {randomNumber_2}";
                                    }
                                    else if (_selectedBonus[0] == "Contatti")
                                    {
                                        rcost = _rCost.Next(1, 4);
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (_selectedBonus[0] == "Fama" || _selectedBonus[0] == "Influenza" || _selectedBonus[0] == "Gregge" || _selectedBonus[0] == "Mawla)" || _selectedBonus[0] == "Risorse" || _selectedBonus[0] == "Status")
                                    {
                                        rcost = _rCost.Next(1, 6);
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                    else if (_selectedBonus[0] == "Maschera")
                                    {
                                        rcost = _rCost.Next(1, 6);
                                        if (rcost >= 2)
                                        {
                                            int chooseifadd = _rCost.Next(1, 3);
                                            if (chooseifadd > 1)
                                            {
                                                int choose = _rCost.Next(0, 3);
                                                string[] bonusMaschera = { "Azzerato", "Falsario" };
                                                if (choose < 3)
                                                {
                                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + bonusMaschera[choose];
                                                    choosenbonuscounter = choosenbonuscounter + rcost + 1;
                                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                                }
                                                else
                                                {
                                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + " " + bonusMaschera[0] + " " + bonusMaschera[1];
                                                    choosenbonuscounter = choosenbonuscounter + rcost + 2;
                                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }

                                    }
                                    else if (_selectedBonus[0] == "Rifugio")
                                    {
                                        rcost = _rCost.Next(1, 4);
                                        int chooseifadd = _rCost.Next(1, 3);
                                        if (chooseifadd > 1)
                                        {
                                            int bonusrifugiocost = _rCost.Next(1, 5);
                                            int costusato = 1;
                                            string[] bonusrifugio = { };
                                            List<string> elencobonusrifugio = new List<string> { "Arsenale nascosto", "Biblioteca", "Cella", "Guardiani", "Laboratorio", "Lusso", "Posterla", "Protezione", "Sala operatoria", "Sistema di sicurezza", "Ubicazione" };
                                            while (costusato < bonusrifugiocost)
                                            {
                                                int indexbonusrifugio = _rCost.Next(elencobonusrifugio.Count);
                                                bonusrifugio[(costusato - 1)] = (elencobonusrifugio[indexbonusrifugio]);
                                                elencobonusrifugio.RemoveAt(indexbonusrifugio);
                                                costusato++;
                                            }
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0] + bonusrifugio;
                                            choosenbonuscounter = choosenbonuscounter + rcost + bonusrifugiocost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                        else
                                        {
                                            listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                            choosenbonuscounter = choosenbonuscounter + rcost;
                                            listchoosenbonus_index = listchoosenbonus_index + 1;
                                        }
                                    }
                                    else if (_selectedBonus[0] == "Seguace")
                                    {
                                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                        choosenbonuscounter = choosenbonuscounter + rcost;
                                        listchoosenbonus_index = listchoosenbonus_index + 1;
                                    }
                                }
                                else if (Loresheet.Contains(_selectedBonus[0]))
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else if (cults.Contains(_selectedBonus[0]))
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                                else if (bloodlines.Contains(_selectedBonus[0]))
                                {
                                    listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                                    choosenbonuscounter = choosenbonuscounter + rcost;
                                    listchoosenbonus_index = listchoosenbonus_index + 1;
                                }
                            }
                        }

                    }
                    else if (chooseHuman)
                    {
                        List<string[]> bonusTypes = new List<string[]> { humanbonuslist, backgroundbonuslist };
                        int index_bonuslist = rBonustype.Next(bonusTypes.Count);
                        string[] selectedBonusArray = bonusTypes[index_bonuslist];
                        int choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                        string selectedBonus = selectedBonusArray[choosenbonus] + "";
                        string[] _selectedBonus = selectedBonus.Split(',');
                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                        while (_selectedBonus[0] == "Gregge"|| _selectedBonus[0] == "Maschera" || _selectedBonus[0] == "Mawla")
                        {
                            choosenbonus = rBonustype.Next(selectedBonusArray.Length);
                            selectedBonus = selectedBonusArray[choosenbonus] + "";
                           _selectedBonus = selectedBonus.Split(',');  
                        }
                        listchoosenbonus[listchoosenbonus_index] = _selectedBonus[0];
                        choosenbonuscounter = choosenbonuscounter + Int32.Parse(_selectedBonus[1]);
                        listchoosenbonus_index = listchoosenbonus_index + 1;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    pointsnonspesi = num_vantaggipoints - choosenbonuscounter;

                }
                if (choosenmaluscounter < num_difettipoints)
                {
                    Console.WriteLine("");
                    choosenmaluscounter = choosenmaluscounter + 1;
                }
            }
            Console.WriteLine("0");
            List<string[]> listBonusMalus = new List<string[]> { listchoosenbonus, listofchoosenmalus };
            return listBonusMalus;

        }

    }
}
