using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.UnfallenCivModel
{
    public class UnfallenCivModel : BaseCivModel, IUnfallenCivModel
    {
        public UnfallenCivModel() { }

        protected override void SetRaceBaseValues()
        {
            CivilizationName = UnfallenCivilizationName;
            BaseFoodSupply = UnfallenBaseFoodSupply;
            BaseInfrastructureOutput = UnfallenBaseInfrastructureOutput;
            BaseDustAmount = UnfallenBaseDustAmount;
            BaseResarchFacilities = UnfallenBaseResarchFacilities;
            BaseGeneralsNumber = UnfallenBaseGeneralsNumber;
        }

        //change cost of vine ship
        public void ChangeVineShipModuleCost() { }

        public static readonly string UnfallenCivilizationName = "Unfallen";
        public static readonly string UnfallenBaseFoodSupply = "0";
        public static readonly string UnfallenBaseInfrastructureOutput = "0";
        public static readonly string UnfallenBaseDustAmount = "100";
        public static readonly string UnfallenBaseResarchFacilities = "30";
        public static readonly string UnfallenBaseGeneralsNumber = "1";
    }
}