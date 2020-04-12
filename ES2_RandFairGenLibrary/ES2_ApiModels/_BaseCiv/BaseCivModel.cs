using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels
{
    public class BaseCivModel : IBaseCivModel
    {
        public BaseCivModel()
        {
            SetRaceBaseValues();
        }

        protected virtual void SetRaceBaseValues() { }

        protected void SetRaceDefaultValues() 
        {
            FoodSupply = baseFoodSupply;
            InfrastructureOutput = baseInfrastructureOutput;
            DustAmount = baseDustAmount;
            ResarchFacilities = baseResarchFacilities;
            GeneralsNumber = baseGeneralsNumber;
        }

        public void RestoreDefaults()
        {
            SetRaceDefaultValues();
        }

        public void Overwrite(string foodSupply, string infrastructureOutput, string dustAmount, string resarchFacilities, string generalsNumber)
        {
            FoodSupply = foodSupply;
            InfrastructureOutput = infrastructureOutput;
            DustAmount = dustAmount;
            ResarchFacilities = resarchFacilities;
            GeneralsNumber = generalsNumber;
        }

        private string foodSupply = "333";
        private string infrastructureOutput = "333";
        private string dustAmount = "333";
        private string resarchFacilities = "333";
        private string generalsNumber = "333";
        private string civilizationName = "Unknown";

        public string CivilizationName { get => civilizationName; set => civilizationName = value; }
        public string FoodSupply { get => foodSupply; set => foodSupply = value; }
        public string InfrastructureOutput { get => infrastructureOutput; set => infrastructureOutput = value; }
        public string DustAmount { get => dustAmount; set => dustAmount = value; }
        public string ResarchFacilities { get => resarchFacilities; set => resarchFacilities = value; }
        public string GeneralsNumber { get => generalsNumber; set => generalsNumber = value; }
  
        private string baseFoodSupply = "333";
        private string baseInfrastructureOutput = "333";
        private string baseDustAmount = "333";
        private string baseResarchFacilities = "333";
        private string baseGeneralsNumber = "333";

        public string BaseFoodSupply { get => baseFoodSupply; set => baseFoodSupply = value; }
        public string BaseInfrastructureOutput { get => baseInfrastructureOutput; set => baseInfrastructureOutput = value; }
        public string BaseDustAmount { get => baseDustAmount; set => baseDustAmount = value; }
        public string BaseResarchFacilities { get => baseResarchFacilities; set => baseResarchFacilities = value; }
        public string BaseGeneralsNumber { get => baseGeneralsNumber; set => baseGeneralsNumber = value; }
    }
}
