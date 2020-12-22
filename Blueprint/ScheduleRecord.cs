namespace Blueprint
{
    public class ScheduleRecord
    {
        /// <summary>
        /// The name of the stop for this schedule record.
        /// </summary>
        public string Station;

        public WaitCondition[] WaitConditions;
    }
}