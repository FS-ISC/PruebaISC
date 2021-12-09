namespace JOIEnergy.Services
{
    using JOIEnergy.Enums;

    public interface IAccountService
    {
        Supplier GetPricePlanIdForSmartMeterId(string smartMeterId);
    }
}