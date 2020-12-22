namespace Blueprint
{
    public enum WaitConditionType
    {
        Time, Inactivity, Full, Empty, ItemCount, Circuit, RobotsInactive, FluidCount, PassengerPresent, PassengerNotPresent
    }

    public enum WaitConditionCompareType
    {
        And, Or
    }
    
    public class WaitCondition
    {
        public WaitConditionType Type;
        
        /// <summary>
        /// Tells how this condition is to be compared with the preceding conditions in the corresponding wait_conditions array. 
        /// </summary>
        public WaitConditionCompareType CompareType;

        /// <summary>
        /// Number of ticks to wait or of inactivity. Only present when WaitConditionType is Time or Inactivity. Optional. 
        /// </summary>
        public int ? Ticks;
        
        //TODO condition object
    }
}