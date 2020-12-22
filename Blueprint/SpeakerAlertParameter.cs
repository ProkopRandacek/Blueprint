namespace Blueprint
{
    public class SpeakerAlertParameter
    {
        /// <summary>
        /// Boolean, whether an alert is shown.
        /// </summary>
        public bool ShowAlert;

        /// <summary>
        /// Boolean, whether an alert icon is shown on the map.
        /// </summary>
        public bool ShowOnMap;

        /// <summary>
        /// The icon that is displayed with the alert
        /// </summary>
        public Signal IconSignal;

        public string AlertMessage;
    }
}