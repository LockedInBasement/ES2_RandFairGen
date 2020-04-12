namespace ES2_RandFairGenLibrary.ES2_ApiModels
{
    public interface IBaseCivModel
    {
        string DustAmount { get; set; }
        string FoodSupply { get; set; }
        string InfrastructureOutput { get; set; }
        string ResarchFacilities { get; set; }
        string GeneralsNumber { get; set; }

        void Overwrite(string foodSupply, string infrastructureOutput, string dustAmount, string resarchFacilities, string generalsNumber);
        void RestoreDefaults();
    }
}