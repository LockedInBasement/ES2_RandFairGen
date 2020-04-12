using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.VodyaniCivModel
{
    public class VodyaniCivModel : BaseCivModel, IVodyaniCivModel
    {
        public VodyaniCivModel() { }

        protected override void SetRaceBaseValues()
        {
            CivilizationName = VodyaniCivilizationName;
            BaseFoodSupply = VodyaniBaseFoodSupply;
            BaseInfrastructureOutput = VodyaniBaseInfrastructureOutput;
            BaseDustAmount = VodyaniBaseDustAmount;
            BaseResarchFacilities = VodyaniBaseResarchFacilities;
            BaseGeneralsNumber = VodyaniBaseGeneralsNumber;
        }

        //race specyfic features:
        public void MothershipModuleBaseValue() { }

        public static readonly string VodyaniCivilizationName = "Vodyani";
        public static readonly string VodyaniBaseFoodSupply = "0";
        public static readonly string VodyaniBaseInfrastructureOutput = "0";
        public static readonly string VodyaniBaseDustAmount = "200";
        public static readonly string VodyaniBaseResarchFacilities = "30";
        public static readonly string VodyaniBaseGeneralsNumber = "1";
    }
}
