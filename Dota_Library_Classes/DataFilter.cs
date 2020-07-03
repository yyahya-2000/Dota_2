

namespace Dota_Library_Classes
{
    /// <summary>
    /// helpin filter proccess, to find the heros who's have the ordered parametrs.
    /// </summary>
    public class DataFilter : Hero
    {
        public DataFilter(string hero) : base(hero) { }
        /// <summary>
        /// checking if this hero meets the required specification.
        /// </summary>
        /// <param name="min1">min type in the filter</param>
        /// <param name="max1">max type in the filter</param>
        /// <param name="min2"> min move speed in the filter</param>
        /// <param name="max2">max move speed in the filter</param>
        /// <param name="min3">min regeneration in thhe filter</param>
        /// <param name="max3">max regeneration in the filter</param>
        /// <returns></returns>
        public bool Check_Data(decimal min1, decimal max1, decimal min2, decimal max2, decimal min3, decimal max3)
        {
            if (Type >= min1 && Type <= max1 && MoveSpeed >= min2 && MoveSpeed <= max2 && Regeneration >= (double)min3 && Regeneration <= (double)max3)
                return true;
            return false;
        }
    }
}
