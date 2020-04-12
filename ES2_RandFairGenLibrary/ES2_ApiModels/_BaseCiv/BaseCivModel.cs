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
            FoodSupply = BaseFoodSupply;
            InfrastructureOutput = BaseInfrastructureOutput;
            DustAmount = BaseDustAmount;
            ResarchFacilities = BaseResarchFacilities;
            GeneralsNumber = BaseGeneralsNumber;
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
        private string generalsNumber = "1";

        public string FoodSupply { get => foodSupply; set => foodSupply = value; }
        public string InfrastructureOutput { get => infrastructureOutput; set => infrastructureOutput = value; }
        public string DustAmount { get => dustAmount; set => dustAmount = value; }
        public string ResarchFacilities { get => resarchFacilities; set => resarchFacilities = value; }
        public string GeneralsNumber { get => generalsNumber; set => generalsNumber = value; }

        public string BaseFoodSupply = "333";
        public string BaseInfrastructureOutput = "333";
        public string BaseDustAmount = "333";
        public string BaseResarchFacilities = "333";
        public string BaseGeneralsNumber = "1";
    }
}
