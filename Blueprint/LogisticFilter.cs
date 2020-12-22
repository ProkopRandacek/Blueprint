namespace Blueprint
{
    public class LogisticFilter
    {
        /// <summary>
        /// Name of the item prototype this filter is set to.
        /// </summary>
        public string Name;

        /// <summary>
        /// Index of the filter, 1-based. 
        /// </summary>
        public int Index;

        /// <summary>
        /// Number the filter is set to. Is 0 for storage chests. 
        /// </summary>
        public int Count;
    }
}