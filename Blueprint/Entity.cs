using System.Collections.Generic;

namespace Blueprint
{
    public enum UndergroundBeltType
    {
        Input, Output
    }

    public enum SplitterPriority
    {
        Right, Left, None
    }

    public enum FilterMode
    {
        Whitelist, Blacklist
    }
    
    public class Entity
    {
        /// <summary>
        /// Index of the entity, 1-based.
        /// </summary>
        public int EntityNumber;

        /// <summary>
        /// Prototype name of the entity (e.g. "offshore-pump"). 
        /// </summary>
        public string Name;

        /// <summary>
        /// Position of the entity within the blueprint.
        /// </summary>
        public Position Position;

        /// <summary>
        /// Direction of the entity, uint (optional).
        /// </summary>
        public int ? Direction;

        /// <summary>
        /// Orientation of cargo wagon or locomotive, value 0 to 1 (optional).
        /// </summary>
        public float ? Orientation;
        
        public Connection[] Connections;
        
        // TODO control_behaviour

        /// <summary>
        /// Item requests by this entity, this is what defines the item-request-proxy when the blueprint is placed, optional.
        /// 1 or more instances of key/value pairs. Key is the name of the item, string. Value is the amount of items to be requested
        /// </summary>
        public Dictionary<string, int> ? Items;

        /// <summary>
        /// Name of the recipe prototype this assembling machine is set to, optional, string.
        /// </summary>
        public string Recipe;

        /// <summary>
        /// Used by Prototype/Container, optional. The index of the first inaccessible item slot due to limiting with the red "bar". 0-based Types/ItemStackIndex. 
        /// </summary>
        public int ? Bar;

        /// <summary>
        /// Cargo wagon inventory configuration, optional.
        /// </summary>
        public Inventory Inventory;

        /// <summary>
        /// Used by Prototype/InfinityContainer, optional.
        /// </summary>
        public InfinitySettings InfinitySettings;

        /// <summary>
        /// Type of the underground belt or loader, optional.
        /// </summary>
        public UndergroundBeltType ? Type;

        /// <summary>
        /// Input priority of the splitter, optional.
        /// </summary>
        public SplitterPriority ? InputPriority;

        /// <summary>
        /// Output priority of the splitter, optional.
        /// </summary>
        public SplitterPriority ? OutputPriority;

        /// <summary>
        /// Filter of the splitter, optional. Name of the item prototype the filter is set to, string.
        /// </summary>
        public string Filter;

        /// <summary>
        /// Filters of the filter inserter or loader, optional.
        /// </summary>
        public ItemFilter[] Filters;

        /// <summary>
        /// Filter mode of the filter inserter, optional.
        /// </summary>
        public FilterMode ? FilterMode;

        /// <summary>
        /// The stack size the inserter is set to, optional.
        /// </summary>
        public int ? OverrideStackSize;

        /// <summary>
        /// The drop position the inserter is set to, optional.
        /// </summary>
        public Position DropPosition;

        /// <summary>
        /// The pickup position the inserter is set to, optional.
        /// </summary>
        public Position PickupPosition;

        /// <summary>
        /// Used by Prototype/LogisticContainer, optional.
        /// </summary>
        public LogisticFilter RequestFilter;

        /// <summary>
        /// Whether this requester chest can request from buffer chests.
        /// </summary>
        public bool ? RequestFromBuffers;

        /// <summary>
        /// Used by Programmable speaker, optional.
        /// </summary>
        public SpeakerParameter Parameters;

        /// <summary>
        /// Used by Programmable speaker, optional.
        /// </summary>
        public SpeakerAlertParameter AlertParameter;

        /// <summary>
        /// Used by the rocket silo, optional. Boolean, whether auto launch is enabled.
        /// </summary>
        public bool ? AutoLaunch;
        
        // TODO variation

        /// <summary>
        /// Color of the Prototype/SimpleEntityWithForce, Prototype/SimpleEntityWithOwner, or train station, optional.
        /// </summary>
        public Color Color;

        /// <summary>
        /// Tha name of the train station, optional.
        /// </summary>
        public string Station;
    }
}