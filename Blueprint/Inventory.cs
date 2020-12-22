namespace Blueprint
{
    public class Inventory
    {
        public ItemFilter[] Filters;

        /// <summary>
        /// The index of the first inaccessible item slot due to limiting with the red "bar". 0-based, optional.
        /// </summary>
        public int ? Bar;
    }
}