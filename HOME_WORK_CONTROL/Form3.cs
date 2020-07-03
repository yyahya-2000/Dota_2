using System;
using System.Windows.Forms;
using Dota_Library_Classes;
using System.Xml.Linq;

namespace HOME_WORK_CONTROL
{
    public partial class Form3 : Form
    {
        int num_round;
        double max_helth_temp_1, max_helth_temp_2;
        static readonly Random random = new Random();
        Hero hero_1, hero_2;
        //calling this constrocter if user wants to resume the game
        public Form3()
        {
            InitializeComponent();
            Download_xml_data_to_Resume();

        }
        /// <summary>
        /// get data from xml file and initialize the varibles using this data.
        /// </summary>
        private void Download_xml_data_to_Resume()
        {
            Hero[] heroes = new Hero[2];
            string path = "../../Resources/xmlfile.xml";
            //reading the file
            XDocument doc1 = XDocument.Load(path);
            int i = 0;
            string temp = null;
            foreach (XElement el in doc1.Root.Elements())
            {
                //get the data of the first hero
                if (el.Name == "hero_1")
                {
                    playing_style_1.Enabled = bool.Parse(el.Attribute("playing_style_1_enabled").Value);
                    playing_style_1.SelectedItem = el.Attribute("playing_style_1_selected").Value;
                    Random_Always_checkBox1.Checked = bool.Parse(el.Attribute("random_alwayse_1").Value);
                }
                //get the data of the second hero
                else
                {
                    playing_style_2.Enabled = bool.Parse(el.Attribute("playing_style_2_enabled").Value);
                    playing_style_2.SelectedItem = el.Attribute("playing_style_2_selected").Value;
                    Random_always_checkBox2.Checked = bool.Parse(el.Attribute("random_alwayse_2").Value);

                }
                //initialize round number
                round_number.Text = $"ROUND { int.Parse(el.Attribute("round").Value)}";
                temp = null;
                //save all hero's elements as a string 
                foreach (XElement element in el.Elements())
                {
                    temp += $"{ element.Value};";
                }
                //initialize a hero's
                heroes[i++] = new Hero(temp.Substring(0, temp.Length - 1));

            }

            Initialization_Params(heroes[0], heroes[1]);
        }

        //calling this constrocter when user starts new round with new heros
        public Form3(Hero hero_1, Hero hero_2)
        {
            InitializeComponent();
            Initialization_Params(hero_1, hero_2);


        }

        /// <summary>
        /// initialize all parameters in this form when form loaded
        /// </summary>
        private void Initialization_Params(Hero hero_1, Hero hero_2)
        {
            this.hero_1 = hero_1;
            this.hero_2 = hero_2;
            Your_Level_health.Value = (int)(100 * (hero_1.Health / hero_1.Maxhealth));
            enemy_Level_health.Value = (int)(100 * (hero_2.Health / hero_2.Maxhealth));
            enemy_name_lable.Text = hero_2.Name;
            your_name_lable.Text = hero_1.Name;
            playing_style_2.Enabled = false;
            max_helth_temp_1 = hero_1.Maxhealth;
            max_helth_temp_2 = hero_2.Maxhealth;
            //insert the percent of health level lable
            Percent_label1.Text = (Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0)).ToString() + "%";
            Percent_label2.Text = (Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0)).ToString() + "%";
            Show_data_players();
        }

        /// <summary>
        /// start a new round 
        /// </summary>
        private void New_round_button_Click(object sender, EventArgs e)
        {
            //knowing play mode
            string[] ran_choice = new string[] { "ATTACK", "RUN AWAY", "PROTECT" };
            if (Random_Always_checkBox1.Checked)
                playing_style_1.SelectedItem = playing_style_1.SelectedText = ran_choice[random.Next(3)];
            if (Random_always_checkBox2.Checked && Random_Always_checkBox1.Checked)
                playing_style_2.SelectedItem = playing_style_2.SelectedText = ran_choice[random.Next(3)];
            if (playing_style_1.SelectedItem == null || playing_style_2.SelectedItem == null)
                MessageBox.Show("YOU HAVE NOT FILLED OUT ALL THE REQUIRED INFORMATION!!!",
                    "INCOMPLETE INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                //start proccess game
                StartRound();

        }
        /// <summary>
        /// choicing plaing style event
        /// </summary>
        private void playing_style_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enabled_Tools();
        }

        /// <summary>
        ///event fires when enemy choice playing style random
        /// </summary>
        private void Choose_Random_button_Click(object sender, EventArgs e)
        {
            //if enemy in random always mode the button will not work
            if (!Random_always_checkBox2.Checked)
            {
                if (playing_style_1.SelectedItem == null && !Random_Always_checkBox1.Checked)
                {
                    MessageBox.Show($"{hero_1.Name} SHOULD CHOOSE AT THE FIRST", "UNORGANIZED CHOICE");
                }
                else
                {
                    string[] ran_choice = new string[] { "ATTACK", "RUN AWAY", "PROTECT" };
                    playing_style_2.SelectedItem = ran_choice[random.Next(3)];
                }
            }
            else
            {
                MessageBox.Show("YOU ARE IN RANDOM ALWAYSE MODE, YOU SHOULD CHANGE THIS MODE TO DO THAT",
                    "RANDOM ALWAYSE MODE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// changing playing mode always random by user
        /// </summary>
        private void Random_Always_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Enabled_Tools();
        }

        /// <summary>
        /// changing playing mode always random by enemy
        /// </summary>
        private void Random_always_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Enabled_Tools();
        }

        /// <summary>
        ///event fires when user choice playing style random
        /// </summary>
        private void Choose_Random_button_1_Click(object sender, EventArgs e)
        {
            //if user in random always mode the button will not work
            if (!Random_Always_checkBox1.Checked)
            {
                string[] ran_choice = new string[] { "ATTACK", "RUN AWAY", "PROTECT" };
                playing_style_1.SelectedItem = ran_choice[random.Next(3)];
                if (Random_always_checkBox2.Checked)
                    playing_style_2.SelectedItem = ran_choice[random.Next(3)];
            }
            else
            {
                MessageBox.Show("YOU ARE IN RANDOM ALWAYSE MODE, YOU SHOULD CHANGE THIS MODE TO DO THAT",
                    "RANDOM ALWAYSE MODE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// saving round data in xml file while form3 is closing if user wants that
        /// </summary>
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("DO YOU WANT TO SAVE GAME ROUNDS?", "SAVING ROUNDS",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                string playing_style_1_enabled, playing_style_1_selected, random_alwayse_1;
                string playing_style_2_enabled, playing_style_2_selected, random_alwayse_2;
                try
                {
                    Insert_data_xml(out playing_style_1_enabled, out playing_style_1_selected, out random_alwayse_1,
                    out playing_style_2_enabled, out playing_style_2_selected, out random_alwayse_2);

                    string path = "../../Resources/xmlfile.xml";
                    //Creation by nested constructors.
                    XDocument document = new XDocument(
                        //main root
                        new XElement($"heroes",
                            //first sub root
                            new XElement($"hero_1",
                                /*
                                 * 4 attributes and 11 elements
                                 */
                                new XAttribute("round", $"{num_round}"),
                                new XAttribute("playing_style_1_enabled", $"{playing_style_1_enabled}"),
                                new XAttribute("playing_style_1_selected", $"{playing_style_1_selected}"),
                                new XAttribute("random_alwayse_1", $"{random_alwayse_1}"),
                                new XElement("name", $"{hero_1.Name}"),
                                new XElement("type", $"{hero_1.Type}"),
                                new XElement("baseStr", $"{hero_1.BaseStr}"),
                                new XElement("baseAgi", $"{hero_1.BaseAgi}"),
                                new XElement("baseInt", $"{ hero_1.BaseInt }"),
                                new XElement("moveSpeed", $"{hero_1.MoveSpeed}"),
                                new XElement("baseArmor", $"{hero_1.BaseArmor}"),
                                new XElement("minDmg", $"{hero_1.MinDmg}"),
                                new XElement("regeneration", $"{hero_1.Regeneration}"),
                                new XElement("health", $"{hero_1.Health}"),
                                new XElement("maxHealth", $"{hero_1.Maxhealth}")),
                            //second sub root
                            new XElement($"hero_2",
                                /*
                                 * 4 attributes and 11 elements
                                 */
                                new XAttribute("round", $"{num_round}"),
                                new XAttribute("playing_style_2_enabled", $"{playing_style_2_enabled}"),
                                new XAttribute("playing_style_2_selected", $"{playing_style_2_selected}"),
                                new XAttribute("random_alwayse_2", $"{random_alwayse_2}"),
                                new XElement("name", $"{hero_2.Name}"),
                                new XElement("type", $"{hero_2.Type}"),
                                new XElement("baseStr", $"{hero_2.BaseStr}"),
                                new XElement("baseAgi", $"{hero_2.BaseAgi}"),
                                new XElement("baseInt", $"{ hero_2.BaseInt }"),
                                new XElement("moveSpeed", $"{hero_2.MoveSpeed}"),
                                new XElement("baseArmor", $"{hero_2.BaseArmor}"),
                                new XElement("minDmg", $"{hero_2.MinDmg}"),
                                new XElement("regeneration", $"{hero_2.Regeneration}"),
                                new XElement("health", $"{hero_2.Health}"),
                                new XElement("maxHealth", $"{hero_2.Maxhealth}"))));
                    //save the decoment
                    document.Save(path);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("THE PARAMETERS OF XML COULDN'T GET ANY VALUE!!!!", "NULL REFERENCE",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("THERE IS SOME ATTRIBUTE DIDN'T GET ANY VALUE WILL SAVING IN XML FILE!!",
                        "ARGUMENT NULL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("SOMETHING HAPPIEND WHILE DATA WAS SAVING IN XML FILE",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// insert all this out params to save it in xml file to resite it when user resume the game
        /// </summary>
        private void Insert_data_xml(out string playing_style_1_enabled, out string playing_style_1_selected, out string random_alwayse_1,
            out string playing_style_2_enabled, out string playing_style_2_selected, out string random_alwayse_2)
        {
            playing_style_1_enabled = playing_style_1.Enabled.ToString();
            if (playing_style_1.Text.ToString() != null)
                playing_style_1_selected = playing_style_1.Text.ToString();
            else
                playing_style_1_selected = "Choose Playing Style!";
            random_alwayse_1 = Random_Always_checkBox1.Checked.ToString();
            playing_style_2_enabled = playing_style_2.Enabled.ToString();
            if (playing_style_2.Text.ToString() != null)
                playing_style_2_selected = playing_style_2.Text.ToString();
            else
                playing_style_2_selected = "Choose Playing Style!";
            random_alwayse_2 = Random_always_checkBox2.Checked.ToString();
        }

        /// <summary>
        /// control Editability of the tools
        /// </summary>
        private void Enabled_Tools()
        {
            if (Random_Always_checkBox1.Checked || Random_always_checkBox2.Checked)
            {
                if (Random_Always_checkBox1.Checked && !Random_always_checkBox2.Checked)
                {
                    playing_style_2.Enabled = true;
                    playing_style_1.Enabled = false;

                }
                else if (!Random_Always_checkBox1.Checked && Random_always_checkBox2.Checked)
                {
                    playing_style_2.Enabled = false;
                    playing_style_1.Enabled = true;
                }
                else
                {
                    playing_style_1.Enabled = false;
                    playing_style_2.Enabled = false;
                }

            }
            else
            {
                if (playing_style_1.SelectedItem == null)
                {
                    playing_style_1.Enabled = true;
                    playing_style_2.Enabled = false;
                }
                else
                {
                    playing_style_1.Enabled = true;
                    playing_style_2.Enabled = true;
                }
            }

        }

        /// <summary>
        /// playing proccess
        /// </summary>
        private void StartRound()
        {
            var style_2 = playing_style_2.SelectedItem;
            var style_1 = playing_style_1.SelectedItem;
            /*
             * chick if heros's health
             */
            if (hero_1.Health == 0)
            {
                MessageBox.Show($"THE WINNER IS {enemy_name_lable.Text}", "WHO IS THE WIINER");
                this.Close();
                return;
            }
            if (hero_2.Health == 0)
            {
                MessageBox.Show($"THE WINNER IS {your_name_lable.Text}", "WHO IS THE WIINER");
                this.Close();
                return;
            }
            //heros's показатели/ points  
            double temp_points_hero_1 = hero_1.MinDmg * hero_1.BaseStr / 10.0 + hero_1.BaseArmor * hero_1.BaseAgi / 10;
            double temp_points_hero_2 = hero_2.MinDmg * hero_2.BaseStr / 10.0 + hero_2.BaseArmor * hero_2.BaseAgi / 10;
            //cases of the game.
            switch (style_1.ToString().Trim())
            {
                case "RUN AWAY":
                    switch (style_2.ToString().Trim())
                    {
                        //here was handled case : Run away <-> Run away
                        #region Run away <-> Run away
                        case "RUN AWAY":
                            hero_1.Health = random.NextDouble() > 0.2 ? ((hero_1.Health + hero_1.Regeneration * 5) > hero_1.Maxhealth ?
                                hero_1.Maxhealth : hero_1.Health + hero_1.Regeneration * 5) : hero_1.Health;
                            Your_Level_health.Value = int.Parse(Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0).ToString());
                            Percent_label1.Text = (Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0)).ToString() + "%";
                            hero_2.Health = random.NextDouble() > 0.2 ? ((hero_2.Health + hero_2.Regeneration * 5) > hero_2.Maxhealth ?
                                hero_2.Maxhealth : hero_2.Health + hero_2.Regeneration * 5) : hero_2.Health;
                            enemy_Level_health.Value = int.Parse(Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString());
                            Percent_label2.Text = Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString() + "%";

                            break;
                        #endregion
                        //here was handled case : Run away <-> PROTECT
                        #region Run away <-> PROTECT
                        case "PROTECT":
                            hero_1.Maxhealth = hero_1.Maxhealth - hero_1.Maxhealth / 100.0 > 2 ? hero_1.Maxhealth - hero_1.Maxhealth / 100.0 : 2;
                            hero_1.Health = hero_1.Health > hero_1.Maxhealth ? hero_1.Maxhealth : hero_1.Health;
                            Your_Level_health.Value = int.Parse(Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0).ToString());
                            Percent_label1.Text = (Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0)).ToString() + "%";
                            break;
                        #endregion
                        //here was handled case : Run away <-> Attack
                        #region Run away <-> Attack
                        case "ATTACK":
                            hero_1.Maxhealth = hero_1.Maxhealth - hero_1.Maxhealth / 100.0 > 2 ? hero_1.Maxhealth - hero_1.Maxhealth / 100.0 : 2;
                            hero_1.Health = hero_1.Health > hero_1.Maxhealth ? hero_1.Maxhealth : hero_1.Health;
                            Your_Level_health.Value = int.Parse(Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0).ToString());
                            Percent_label1.Text = (Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0)).ToString() + "%";
                            break;
                        #endregion
                        default:
                            MessageBox.Show("Error in choosing playing style");
                            this.Close();
                            Form3 form33 = new Form3(hero_1, hero_2);
                            form33.ShowDialog();
                            break;
                    }
                    break;
                case "PROTECT":
                    switch (style_2.ToString().Trim())
                    {
                        //here was handled case : PROTECT <-> Run away
                        #region PROTECT <-> Run away
                        case "RUN AWAY":
                            hero_2.Maxhealth = hero_2.Maxhealth - hero_2.Maxhealth / 100.0 > 2 ? hero_2.Maxhealth - hero_2.Maxhealth / 100.0 : 2;
                            hero_2.Health = hero_2.Health > hero_2.Maxhealth ? hero_2.Maxhealth : hero_2.Health;
                            enemy_Level_health.Value = int.Parse(Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString());
                            Percent_label2.Text = Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString() + "%";
                            break;
                        #endregion
                        //here was handled case :PROTECT <-> Defend oneself
                        #region PROTECT <-> Defend oneself
                        case "PROTECT":
                            //nothing will happend
                            break;
                        #endregion
                        //here was handled case : PROTECT <-> Attack
                        #region PROTECT<-> Attack
                        case "ATTACK":
                            if (temp_points_hero_1 <= temp_points_hero_2)
                            {
                                hero_1.Health = hero_1.Health - hero_2.MinDmg * hero_2.BaseStr / 20.0 > 0 ? hero_1.Health - hero_2.MinDmg * hero_2.BaseStr / 20.0 : 0;
                                Your_Level_health.Value = int.Parse(Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0).ToString());
                                Percent_label1.Text = (Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0)).ToString() + "%";
                            }
                            //else nothing will happen
                            break;
                        #endregion
                        default:
                            MessageBox.Show("Error in choosing playing style");
                            this.Close();
                            Form3 form33 = new Form3(hero_1, hero_2);
                            form33.ShowDialog();
                            break;
                    }
                    break;
                case "ATTACK":
                    switch (style_2.ToString().Trim())
                    {
                        //here was handled case : Attack <-> Run away
                        #region Attack <-> Run away
                        case "RUN AWAY":
                            hero_2.Maxhealth = hero_2.Maxhealth - hero_2.Maxhealth / 100.0 > 2 ? hero_2.Maxhealth - hero_2.Maxhealth / 100.0 : 2;
                            hero_2.Health = hero_2.Health > hero_2.Maxhealth ? hero_2.Maxhealth : hero_2.Health;
                            enemy_Level_health.Value = int.Parse(Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString());
                            Percent_label2.Text = Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString() + "%";
                            break;
                        #endregion
                        //here was handled case : Attack <-> PROTECT
                        #region Attack <-> Defend oneself
                        case "PROTECT":
                            if (temp_points_hero_1 >= temp_points_hero_2)
                            {
                                hero_2.Health = hero_2.Health - hero_1.MinDmg * hero_1.BaseStr / 20.0 > 0 ? hero_2.Health - hero_1.MinDmg * hero_1.BaseStr / 20.0 : 0;
                                enemy_Level_health.Value = int.Parse(Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString());
                                Percent_label2.Text = Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString() + "%";
                            }
                            //else nothing will happen
                            break;
                        #endregion
                        //here was handled case : Attack <-> Attack
                        #region attack <-> attack
                        case "ATTACK":
                            if (temp_points_hero_1 > temp_points_hero_2)
                            {
                                hero_2.Health = hero_2.Health - hero_1.MinDmg * hero_1.BaseStr / 20.0 > 0 ? hero_2.Health - hero_1.MinDmg * hero_1.BaseStr / 20.0 : 0;
                                enemy_Level_health.Value = int.Parse(Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString());
                                Percent_label2.Text = Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString() + "%";
                            }
                            else if (temp_points_hero_1 < temp_points_hero_2)
                            {
                                hero_1.Health = hero_1.Health - hero_2.MinDmg * hero_2.BaseStr / 20.0 > 0 ? hero_1.Health - hero_2.MinDmg * hero_2.BaseStr / 20.0 : 0;
                                Your_Level_health.Value = int.Parse(Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0).ToString());
                                Percent_label1.Text = (Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0)).ToString() + "%";
                            }
                            else
                            {
                                hero_2.Health = hero_2.Health - hero_1.MinDmg * hero_1.BaseStr / 20.0 > 0 ? hero_2.Health - hero_1.MinDmg * hero_1.BaseStr / 20.0 : 0;
                                enemy_Level_health.Value = int.Parse(Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString());
                                Percent_label2.Text = Math.Round(100 * hero_2.Health / hero_2.Maxhealth, 0).ToString() + "%";
                                hero_1.Health = hero_1.Health - hero_2.MinDmg * hero_2.BaseStr / 20.0 > 0 ? hero_1.Health - hero_2.MinDmg * hero_2.BaseStr / 20.0 : 0;
                                Your_Level_health.Value = int.Parse(Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0).ToString());
                                Percent_label1.Text = (Math.Round(100 * hero_1.Health / hero_1.Maxhealth, 0)).ToString() + "%";

                            }

                            #endregion
                            break;
                        default:
                            MessageBox.Show("Error in choosing playing style");
                            this.Close();
                            Form3 form33 = new Form3(hero_1, hero_2);
                            form33.ShowDialog();
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Error in choosing playing style");
                    Form3 form3 = new Form3(hero_1, hero_2);
                    form3.ShowDialog();
                    break;
            }
            //refrash the data which showes in the screen
            Show_data_players();
            /*
             * chick if heros's health
             */
            if (hero_1.Health == 0)
            {
                MessageBox.Show($"THE WINNER IS {enemy_name_lable.Text} ", "WHO IS THE WIINER");
                this.Close();

            }
            if (hero_2.Health == 0)
            {
                MessageBox.Show($"THE WINNER IS {your_name_lable.Text}", "WHO IS THE WIINER");
                this.Close();
            }
            /*
             * reinitialize playing styles
             */
            if (!Random_Always_checkBox1.Checked)
            {
                playing_style_1.SelectedItem = null;
                playing_style_1.SelectedText = "Choose Playing Style!";
            }
            if (!Random_always_checkBox2.Checked)
            {
                playing_style_2.SelectedItem = null;
                playing_style_2.SelectedText = "Choose Playing Style!";
            }
            //control Editability of the tools
            Enabled_Tools();
            round_number.Text = $"ROUND : {++num_round}";
        }

        /// <summary>
        /// show the heros parameters in the right/left bottum of form3
        /// </summary>
        private void Show_data_players()
        {
            data_player_1_label.Text = $"type: {hero_1.Type}\nbaseStr: {hero_1.BaseStr}\nbaseAgi: {hero_1.BaseAgi}" +
                $"\nbaseInt: {hero_1.BaseInt}\nmoveSpeed: {hero_1.MoveSpeed}\nbaseArmor: {hero_1.BaseArmor}\nminDmg: " +
                $"{hero_1.MinDmg}\nregeneration: {hero_1.Regeneration}\nhealth: {Math.Round(hero_1.Health, 2)}\nmaxHealth: {Math.Round(hero_1.Maxhealth, 2)}";

            data_player_2_label.Text = $"type: {hero_2.Type}\nbaseStr: {hero_2.BaseStr}\nbaseAgi: {hero_2.BaseAgi}" +
                $"\nbaseInt: {hero_2.BaseInt}\nmoveSpeed: {hero_2.MoveSpeed}\nbaseArmor: {hero_2.BaseArmor}" +
                $"\nminDmg: {hero_2.MinDmg}\nregeneration: {hero_2.Regeneration}\nhealth: {Math.Round(hero_2.Health, 2)}\nmaxHealth: {Math.Round(hero_2.Maxhealth, 2)}";
        }
    }
}

