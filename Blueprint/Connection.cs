namespace Blueprint
{
    /// <summary>
    /// Object containing information about the connections to other entities formed by red or green wires.
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// First connection point. The default for everything that doesn't have multiple connection points.
        /// </summary>
        public ConnectionPoint Cp1;

        /// <summary>
        /// Second connection point. For example, the "output" part of an arithmetic combinator.
        /// </summary>
        public ConnectionPoint Cp2;
    }
}