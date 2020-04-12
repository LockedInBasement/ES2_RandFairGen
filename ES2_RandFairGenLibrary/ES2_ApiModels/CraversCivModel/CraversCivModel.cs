using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.CraversCivModel
{
    public class CraversCivModel : BaseCivModel, ICraversCivModel
    {
        public CraversCivModel() { }

        protected override void SetRaceBaseValues()
        {
            CivilizationName = CraversCivilizationName;
            BaseFoodSupply = CraversBaseFoodSupply;
            BaseInfrastructureOutput = CraversBaseInfrastructureOutput;
            BaseDustAmount = CraversBaseDustAmount;
            BaseResarchFacilities = CraversBaseResarchFacilities;
            BaseGeneralsNumber = CraversBaseGeneralsNumber;
        }

        public void DepletionPointChange() { }

        public static readonly string CraversCivilizationName = "Cravers";
        public static readonly string CraversBaseFoodSupply = "0";
        public static readonly string CraversBaseInfrastructureOutput = "0";
        public static readonly string CraversBaseDustAmount = "100";
        public static readonly string CraversBaseResarchFacilities = "0";
        public static readonly string CraversBaseGeneralsNumber = "1";
    }
}