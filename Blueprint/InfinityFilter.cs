namespace Blueprint
{
    
    public class InfinityFilter
    {
        /// <summary>
        /// Name of the item prototype the filter is set to.
        /// </summary>
        public string Name;

        /// <summary>
        /// Number the filter is set to.
        /// </summary>
        public int Count;

        public ItemFilterMode Mode;

        /// <summary>
        /// Index of the filter, 1-based.
        /// </summary>
        public int Index;
    }
}