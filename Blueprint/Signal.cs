namespace Blueprint
{
    public enum SignalType
    {
        Item, Fluid, Virtual
    }
    
    public class Signal
    {
        /// <summary>
        /// Name of the signal prototype this signal is set to.
        /// </summary>
        public string Name;

        /// <summary>
        /// Type of the signal.
        /// </summary>
        public SignalType Type;
    }
}