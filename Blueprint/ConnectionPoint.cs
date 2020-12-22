namespace Blueprint
{
    /// <summary>
    /// The actual point where a wire is connected to. Contains information about where it is connected to.
    /// </summary>
    public class ConnectionPoint
    {
        /// <summary>
        /// An array of Connection data objects containing all the connections from this point created by red wire.
        /// </summary>
        public ConnectionData[] Red;

        /// <summary>
        /// An array of Connection data objects containing all the connections from this point created by green wire.
        /// </summary>
        public ConnectionData[] Green;
    }
}