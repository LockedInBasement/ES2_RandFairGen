using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.HoratioCivModel
{
    public class HoratioCivModel : BaseCivModel
    {
        public HoratioCivModel() { }

        protected override void SetRaceBaseValues()
        {
            BaseFoodSupply = HoratioBaseFoodSupply;
            BaseInfrastructureOutput = HoratioBaseInfrastructureOutput;
            BaseDustAmount = HoratioBaseDustAmount;
            BaseResarchFacilities = HoratioBaseResarchFacilities;
            BaseGeneralsNumber = HoratioBaseGeneralsNumber;
        }

        public static readonly string HoratioBaseFoodSupply = "0";
        public static readonly string HoratioBaseInfrastructureOutput = "0";
        public static readonly string HoratioBaseDustAmount = "100";
        public static readonly string HoratioBaseResarchFacilities = "0";
        public static readonly string HoratioBaseGeneralsNumber = "1";
    }
}