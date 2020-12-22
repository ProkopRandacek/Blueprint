namespace Blueprint
{
    /// <summary>
    /// Information about a single connection between two connection points.
    /// </summary>
    public class ConnectionData
    {
        /// <summary>
        /// ID of the entity this connection is connected with. 
        /// </summary>
        public int EntityId;
        
        /// <summary>
        /// The circuit connector id of the entity this connection is connected to, see https://lua-api.factorio.com/latest/defines.html#defines.circuit_connector_id.
        /// </summary>
        public int CircuitId;
    }
}