namespace Blueprint
{
    public enum ItemFilterMode
    {
        AtLeast, AtMost, Exactly
    }
    
    public class ItemFilter
    {
        /// <summary>
        /// Name of the item prototype this filter is set to.
        /// </summary>
        public string Name;

        /// <summary>
        /// Index of the filter, 1-based.
        /// </summary>
        public int Index;
    }
}