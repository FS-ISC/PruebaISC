namespace JOIEnergy.Domain
{
    using System;
    using System.Collections.Generic;

    public class MeterReadings
    {
        public string SmartMeterId { get; set; }
        public List<ElectricityReading> ElectricityReadings { get; set; }
    }
}
