namespace JOIEnergy.Domain
{
    using System;

    public class ElectricityReading
    {
        public DateTime Time { get; set; }
        public Decimal Reading { get; set; }
    }
}
