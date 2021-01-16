namespace Blueprint
{
    public class BlueprintBook
    {
        /// <summary>
        /// The name of the item that was saved ("blueprint-book" in vanilla).
        /// </summary>
        public string Item;

        /// <summary>
        /// The name of the blueprint set by the user. 
        /// </summary>
        public string Label;
        
        /// <summary>
        /// The color of the this blueprint
        /// </summary>
        public Color LabelColor;

        /// <summary>
        /// The actual content of the blueprint book.
        /// </summary>
        public Blueprint[] Blueprints;
        
        /// <summary>
        /// Index of the currently selected blueprint, 0-based.
        /// </summary>
        public int ActiveIndex;

        /// <summary>
        /// The map version of the map the blueprint was created in.
        /// </summary>
        public int Version;
    }
}