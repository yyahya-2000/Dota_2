using System.Data;
using System.IO;

namespace Dota_Library_Classes
{
    /// <summary>
    /// My parser
    /// </summary>
    public class CsvReader
    {
        //use class DataTabale help to save the data in dataGridView1
        DataTable table = new DataTable();
        public CsvReader(string path = @"../../Resources/Dota2.csv")
        {
            table.Rows.Clear();
            table.Columns.Clear();
            //Initialization the table
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Type", typeof(int));
            table.Columns.Add("BaseStr", typeof(int));
            table.Columns.Add("BaseAgi", typeof(int));
            table.Columns.Add("BaseInt", typeof(int));
            table.Columns.Add("MoveSpeed", typeof(int));
            table.Columns.Add("BaseArmor", typeof(double));
            table.Columns.Add("MinDmg", typeof(int));
            table.Columns.Add("Regeneration", typeof(double));
            table.Columns.Add("Health", typeof(double));
            table.Columns.Add("MaxHealth", typeof(double));
            //get file's lines, and save it in datalines array.
            string[] datalines = File.ReadAllLines(path);
            Hero hero_data;
            //ride the parameters from each line -> make hero -> save the parameters of the hero in table variable.
            for (int i = 1; i < datalines.Length; i++)
            {
                //data processing occurs in constrocter in Hero class.
                hero_data = new Hero(datalines[i]);
                //add object array to the table
                table.Rows.Add(hero_data.data_array);
            }

        }
        /// <summary>
        /// help to get data table
        /// </summary>
        public DataTable GetDataTeble() => table;

    }
}
