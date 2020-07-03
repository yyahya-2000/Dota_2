using Dota_Library_Classes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HOME_WORK_CONTROL
{
    public partial class Form2 : Form
    {
        DataGridView DataGridView = new DataGridView();
        Hero hero_1;//link to hero class 
        Hero hero_2;//another link 
        //link datatable help to add data to the table.
        DataTable table = new DataTable();
        string temp_name = null;
        //constrocter
        public Form2()
        {
            InitializeComponent();
            //adding the data to the table
            Add_Data_to_Table();
        }

        /// <summary>
        /// adding the data to the table
        /// </summary>
        private void Add_Data_to_Table(string path = @"../../Resources/Dota2.csv")
        {
            try
            {
                CsvReader csvReader = new CsvReader(path);
                dataGridView1.DataSource = table = csvReader.GetDataTeble();
                Insert_Min_Max_filter(dataGridView1);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"COULDN'T ACCSESS TO THE FILE =>", "ERORR IN ACCESSING TO THE FILE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
            catch (IOException)
            {
                MessageBox.Show($"WRONG WITH FILE WRITTING =>", "ERORR IN WRITTING TO THE FILE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show($"CANN'T OPEN THE FILE", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        /// <summary>
        /// Initialization filter's parametrs
        /// </summary>
        /// <param name="dataGridView1"> the data in dataGridView1</param>
        private void Insert_Min_Max_filter(DataGridView dataGridView1)
        {
            //make copy of data table 
            var data = dataGridView1;
            //temp parametrs.
            int max_type = 0, min_type = 1000000, min_moveSpped = 100000, max_moveSpeed = 0;
            double min_regeneration = 1000000, max_regeneration = 0;
            //testing the data which is in dataGridView1 and get max and min from data type : type, movinfspeed, regeneration
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                if ((int)data.Rows[i].Cells[1].Value > max_type)
                    max_type = (int)data.Rows[i].Cells[1].Value;
                if ((int)data.Rows[i].Cells[1].Value < min_type)
                    min_type = (int)data.Rows[i].Cells[1].Value;
                if ((int)data.Rows[i].Cells[5].Value > max_moveSpeed)
                    max_moveSpeed = (int)data.Rows[i].Cells[5].Value;
                if ((int)data.Rows[i].Cells[5].Value < min_moveSpped)
                    min_moveSpped = (int)data.Rows[i].Cells[5].Value;
                if ((double)data.Rows[i].Cells[8].Value > max_regeneration)
                    max_regeneration = (double)data.Rows[i].Cells[8].Value;
                if ((double)data.Rows[i].Cells[8].Value < min_regeneration)
                    min_regeneration = (double)data.Rows[i].Cells[8].Value;
            }
            //set the max and min and value of every numericUpDown tools.
            min_type_numericUpDown.Minimum = max_type_numericUpDown1.Minimum = min_type;
            min_type_numericUpDown.Maximum = max_type_numericUpDown1.Maximum = max_type;
            max_type_numericUpDown1.Value = max_type;
            min_moveSpeed_numericUpDown.Minimum = max_moveSpped_numericUpDown4.Minimum = min_moveSpped;
            min_moveSpeed_numericUpDown.Maximum = max_moveSpped_numericUpDown4.Maximum = max_moveSpeed;
            max_moveSpped_numericUpDown4.Value = max_moveSpeed;
            max_regeneration_numericUpDown.Minimum = min_regeneration_numericUpDown.Minimum = (decimal)min_regeneration;
            min_regeneration_numericUpDown.Maximum = max_regeneration_numericUpDown.Maximum = (decimal)max_regeneration;
            max_regeneration_numericUpDown.Value = (decimal)max_regeneration;


        }

        /// <summary>
        /// this method help to choose the heros from selected row
        /// </summary>
        /// <param name="row"> the selected cell</param>
        /// <returns></returns>
        private Hero Choose_Hero(DataGridViewSelectedRowCollection row)
        {
            string temp = row[0].Cells[0].Value.ToString() + ";" + row[0].Cells[1].Value.ToString() + ";" + row[0].Cells[2].Value.ToString() + ";" +
                row[0].Cells[3].Value.ToString() + ";" + row[0].Cells[4].Value.ToString() + ";" + row[0].Cells[5].Value.ToString() + ";" +
                row[0].Cells[6].Value.ToString() + ";" + row[0].Cells[7].Value.ToString() + ";" + row[0].Cells[8].Value.ToString() + ";" +
                row[0].Cells[9].Value.ToString() + ";" + row[0].Cells[10].Value.ToString();
            Hero hero = new Hero(temp);
            //retern link of the information of the hero.
            return hero;
        }

        /// <summary>
        /// handling choosing heros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choose_hero_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (choose_hero_button.Text == "CHOOSE YOUR HERO")
                    hero_1 = Choose_Hero(dataGridView1.SelectedRows);
                else
                    hero_2 = Choose_Hero(dataGridView1.SelectedRows);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show($"CHOICING HERO WAS FILED!!", "ERROR IN CHOICING HERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to choose this hero :{dataGridView1.SelectedRows[0].Cells[0].Value}",
                "Confirmation Of Choice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowindex);

            }

            if (choose_hero_button.Text == "CHOOSE ENEMY HERO")
            {
                //if player after choicIng heros want to continue or not
                if (DialogResult.Yes == MessageBox.Show($"YOU HAVE CHOOSED TWO HEROS, ARE YOU READY TO START THE ROUND?\n" +
                    $"IF YOU CANCEL YOU WILL START CHOOSING FROM THE FIRST!!!!",
                    "Confirmation Of Choice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    this.Close();
                    Form3 form3 = new Form3(hero_1, hero_2);
                    form3.ShowDialog();

                }
                else
                {
                    this.Close();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }

            }
            if (choose_hero_button.Text == "CHOOSE YOUR HERO")
                choose_hero_button.Text = "CHOOSE ENEMY HERO";
        }

        /// <summary>
        /// save the chosse of the heros.
        /// </summary>
        private void save_changed_Click(object sender, EventArgs e)
        {
            Save_Edited_data(@"../../Resources/Dotaaa2.csv");
            MessageBox.Show("Data Changed");
        }

        /// <summary>
        /// method help to save the editing data in parser file
        /// </summary>
        /// <param name="path">the path of the file where we should save the editing data</param>
        private void Save_Edited_data(string path = @"../../Resources/Dotaaa2.csv")
        {

            try
            {
                TextWriter writer = new StreamWriter(path);
                writer.WriteLine("name;type;baseStr;baseAgi;baseInt;moveSpeed;baseArmor;minDmg;regeneration;health;maxhealth");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        if (j < dataGridView1.Columns.Count - 1)
                            writer.Write(";");
                    }
                    writer.WriteLine();
                }
                writer.Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"COULDN'T ACCSESS TO THE FILE!!", "ERORR IN ACCESSING TO THE FILE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            catch (IOException)
            {
                MessageBox.Show($"WRONG WITH FILE WRITTING!!", "ERORR IN WRITTING TO THE FILE"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show($"SOME THING RONGE HAPPIEND WHILE YOU ARE TRYING TO CHANGE THE DATA", "ERORR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

        }

        //Error Event warning about wronge entry input in the table
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("THIS DATA WHICH YOU ENTERED IS NOT AVAIALBLE IN THIS CELL, PLEASE ENTER CORRECT DATA!!!", "INCORRECT INPUT ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Handling wrong entries for data in the dataGrideView.
        /// </summary>
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            double newDouble = 0;
            //handling empty input.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                MessageBox.Show("YOU HAVE ENTRED INCORRECT DATA PLEASE ENTER CORRECT DATA!!!", "INCORRECT INPUT ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            //handling string input in cells type numbers
            else if (!(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is string) && !double.TryParse(e.FormattedValue.ToString(),
                out newDouble) || newDouble < 0)
            {
                MessageBox.Show("YOU HAVE ENTRED INCORRECT DATA PLEASE ENTER CORRECT DATA!!!", "INCORRECT INPUT ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            //if the max health is less than 2
            else if (e.ColumnIndex == 10 && (!double.TryParse(e.FormattedValue.ToString(), out newDouble) || newDouble < 2))
            {
                MessageBox.Show("MaxHealth SHOULD BE MORE THAN OR EQUAL 2", "INCORRECT INPUT");
                e.Cancel = true;
            }
            //if the name's cell has no value
            if (e.ColumnIndex == 0)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    MessageBox.Show("YOU HAVE ENTRED INCORRECT DATA PLEASE ENTER CORRECT DATA!!!", "INCORRECT INPUT ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }


            }
            /*
             * max helth should be always more or equal health.
             * so in this tow conditions i fixed this wronge case
             */
            if (e.ColumnIndex == 9 && (!(double.TryParse(e.FormattedValue.ToString(), out newDouble)) ||
                newDouble > double.Parse((dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value).ToString().Trim())))
            {
                MessageBox.Show("Health SHOULD BE LESS THAN OR EQUAL MaxHealth!!", "INCORRECT INPUT");
                e.Cancel = true;
            }
            if (e.ColumnIndex == 10 && (!(double.TryParse(e.FormattedValue.ToString(), out newDouble)) ||
                newDouble < double.Parse((dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value).ToString().Trim())))
            {
                MessageBox.Show("MaxHealth SHOULD BE LESS THAN OR EQUAL Health!!", "INCORRECT INPUT");
                e.Cancel = true;
            }
        }

        //download data from parser file
        private void Download_Modified_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"../../Resources/Dotaaa2.csv"))
                Add_Data_to_Table(@"../../Resources/Dotaaa2.csv");
            else
                MessageBox.Show("THERE IS NO SAVED DATA", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        //dawnload data from original file
        private void Download_Oreginal_button_Click(object sender, EventArgs e)
        {
            Add_Data_to_Table(@"../../Resources/Dota2.csv");
            choose_hero_button.Text = "CHOOSE YOUR HERO";
        }

        /// <summary>
        /// handling erorrs
        /// </summary>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                //IF played enter the name of the player with spaces at the first 
                // this problem  was fixed here
                var temp = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (e.ColumnIndex == 0 && !string.IsNullOrEmpty(temp.ToString().Trim()) && temp.ToString()[0] == ' ')
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp.ToString().Trim();
                if (temp.ToString().Contains(";"))
                    if (string.IsNullOrEmpty(temp.ToString().Replace(";", "")) || string.IsNullOrWhiteSpace(temp.ToString().Replace(";", "")))
                        if (temp_name != null)
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp_name;
                        else
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0.ToString();
                    else
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp.ToString().Replace(";", "");
                dataGridView1.Refresh();

                Insert_Min_Max_filter(dataGridView1);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (temp.ToString().ToLower().Trim().Equals(dataGridView1.Rows[i].Cells[0].Value.ToString().ToLower().Trim()) && i != e.RowIndex)
                    {
                        MessageBox.Show("THIS NAME IS USED BY ANOTHER HERO!!!", "EXISTS NAME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp_name;
                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"THE INDEX WAS OUT THE ARRAY SIZE{ex}", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

        }

        /// <summary>
        /// start filter proccess
        /// </summary>
        private void search_button_Click(object sender, EventArgs e)
        {

            if (Check_Input_filter())
            {
                dataGridView1.DataSource = table;
                //insert filter parameters in variables.
                decimal min1 = min_type_numericUpDown.Value, max1 = max_type_numericUpDown1.Value;
                decimal min2 = min_moveSpeed_numericUpDown.Value, max2 = max_moveSpped_numericUpDown4.Value;
                decimal min3 = min_regeneration_numericUpDown.Value, max3 = max_regeneration_numericUpDown.Value;
                var data = dataGridView1;
                //creat a table
                DataTable tablee = new DataTable();
                tablee.Columns.Add("Name", typeof(string));
                tablee.Columns.Add("Type", typeof(int));
                tablee.Columns.Add("BaseStr", typeof(int));
                tablee.Columns.Add("BaseAgi", typeof(int));
                tablee.Columns.Add("BaseInt", typeof(int));
                tablee.Columns.Add("MoveSpeed", typeof(int));
                tablee.Columns.Add("BaseArmor", typeof(double));
                tablee.Columns.Add("MinDmg", typeof(int));
                tablee.Columns.Add("Regeneration", typeof(double));
                tablee.Columns.Add("Health", typeof(double));
                tablee.Columns.Add("MaxHealth", typeof(double));


                DataFilter filter;
                //checking the data in datagridview to show only the Required data
                for (int i = 0; i < data.Rows.Count - 1; i++)
                {
                    filter = new DataFilter(Get_String_Data(data.Rows[i]));
                    if (filter.Check_Data(min1, max1, min2, max2, min3, max3))
                    {
                        tablee.Rows.Add(filter.data_array);
                    }
                }
                //send the data from variable tablee to data source in  datagridview
                dataGridView1.DataSource = tablee;

            }


        }
        //getting row from datagridview and change it to string form
        private string Get_String_Data(DataGridViewRow row)
        {
            return row.Cells[0].Value.ToString() + ";" + row.Cells[1].Value.ToString() + ";" + row.Cells[2].Value.ToString() + ";" +
                 row.Cells[3].Value.ToString() + ";" + row.Cells[4].Value.ToString() + ";" + row.Cells[5].Value.ToString() + ";" +
                 row.Cells[6].Value.ToString() + ";" + row.Cells[7].Value.ToString() + ";" + row.Cells[8].Value.ToString() + ";" +
                 row.Cells[9].Value.ToString() + ";" + row.Cells[10].Value.ToString();
        }

        /// <summary>
        /// fixing min and max value if min get value more than max
        /// </summary>
        private bool Check_Input_filter()
        {
            bool done = false;
            //check if there is any min>max in parameters filter
            if (min_type_numericUpDown.Value > max_type_numericUpDown1.Value ||
                min_moveSpeed_numericUpDown.Value > max_moveSpped_numericUpDown4.Value ||
                min_regeneration_numericUpDown.Value > max_regeneration_numericUpDown.Value)
            {
                if (DialogResult.Yes == MessageBox.Show("YOU HAVE ENTERED INCORRECT FILTER PARAMETRS, DO YOU WANT TO FIX IT?",
                    "ERORR IN INPUTING FILTER PARAMETES", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    done = true;
                    if (min_type_numericUpDown.Value > max_type_numericUpDown1.Value)
                    {
                        decimal temp = 0;
                        //min:=max and max:=min
                        temp = min_type_numericUpDown.Value;
                        min_type_numericUpDown.Value = max_type_numericUpDown1.Value;
                        max_type_numericUpDown1.Value = temp;


                    }
                    if (min_moveSpeed_numericUpDown.Value > max_moveSpped_numericUpDown4.Value)
                    {
                        decimal temp = 0;
                        //min:=max and max:=min
                        temp = min_moveSpeed_numericUpDown.Value;
                        min_moveSpeed_numericUpDown.Value = max_moveSpped_numericUpDown4.Value;
                        max_moveSpped_numericUpDown4.Value = temp;

                    }
                    if (min_regeneration_numericUpDown.Value > max_regeneration_numericUpDown.Value)
                    {
                        decimal temp = 0;
                        //min:=max and max:=min
                        temp = min_regeneration_numericUpDown.Value;
                        min_regeneration_numericUpDown.Value = max_regeneration_numericUpDown.Value;
                        max_regeneration_numericUpDown.Value = temp;
                    }
                }
            }
            else
                done = true;
            return done;
        }

        /// <summary>
        /// saving the first name value in the data when user starts editting proccess
        /// </summary>
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                temp_name = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            play_instructions.Visible = play_instructions.Visible ? false : true;
        }
    }
}
