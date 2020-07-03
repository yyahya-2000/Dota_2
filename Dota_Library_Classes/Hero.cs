

namespace Dota_Library_Classes
{
    /// <summary>
    /// class has all parameter's of heros data
    /// </summary>
    public class Hero
    {
        //Initialization hero's parametres
        string name;
        public string Name { get { return name; } set { name = value; } }
        int type;
        public int Type { get { return type; } set { type = value; } }
        int baseStr;
        public int BaseStr { get { return baseStr; } set { baseStr = value; } }
        int baseAgi;
        public int BaseAgi { get { return baseAgi; } set { baseAgi = value; } }
        int baseInt;
        public int BaseInt { get { return baseInt; } set { baseInt = value; } }
        int moveSpeed;
        public int MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }
        double baseArmor;
        public double BaseArmor { get { return baseArmor; } set { baseArmor = value; } }
        int minDmg;
        public int MinDmg { get { return minDmg; } set { minDmg = value; } }
        double regeneration;
        public double Regeneration { get { return regeneration; } set { regeneration = value; } }
        double health;
        public double Health { get { return health; } set { health = value; } }
        double maxHealth;
        public double Maxhealth { get { return maxHealth; } set { maxHealth = value; } }
        //this array help to save the data in table.
        public object[] data_array;
        //constrocter with string parameters(line from data file)
        public Hero(string line_from_file)
        {
            //intialize fields.
            string[] values = line_from_file.ToString().Split(';');
            name = values[0].Trim();
            type = int.Parse(values[1].Trim());
            baseStr = int.Parse(values[2].Trim());
            baseAgi = int.Parse(values[3].Trim());
            baseInt = int.Parse(values[4].Trim());
            moveSpeed = int.Parse(values[5].Trim());
            baseArmor = double.Parse(values[6].Trim());
            minDmg = int.Parse(values[7].Trim());
            regeneration = double.Parse(values[8].Trim());
            health = baseStr * 29;
            maxHealth = baseStr * 29;
            //in case when data will change.
            if (values.Length > 9)
            {
                health = double.Parse(values[9].Trim());
                maxHealth = double.Parse(values[10].Trim());
            }

            data_array = new object[] { name, type, baseStr, baseAgi, baseInt, moveSpeed, baseArmor, minDmg, regeneration, health, maxHealth };
        }
    }
}
