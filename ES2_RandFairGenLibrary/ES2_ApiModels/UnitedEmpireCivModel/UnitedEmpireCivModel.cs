using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.UnitedEmpireCivModel
{
    public class UnitedEmpireCivModel : BaseCivModel
    {
        public UnitedEmpireCivModel() { }

        protected override void SetRaceBaseValues()
        {
            BaseFoodSupply = UnitedEmpireBaseFoodSupply;
            BaseInfrastructureOutput = UnitedEmpireBaseInfrastructureOutput;
            BaseDustAmount = UnitedEmpireBaseDustAmount;
            BaseResarchFacilities = UnitedEmpireBaseResarchFacilities;
            BaseGeneralsNumber = UnitedEmpireBaseGeneralsNumber;
        }

        public static readonly string UnitedEmpireBaseFoodSupply = "0";
        public static readonly string UnitedEmpireBaseInfrastructureOutput = "50";
        public static readonly string UnitedEmpireBaseDustAmount = "100";
        public static readonly string UnitedEmpireBaseResarchFacilities = "0";
        public static readonly string UnitedEmpireBaseGeneralsNumber = "1";
    }
}
