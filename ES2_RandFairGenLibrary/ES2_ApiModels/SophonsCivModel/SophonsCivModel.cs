using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.SophonsCivModel
{
    public class SophonsCivModel : BaseCivModel
    {
        public SophonsCivModel() { }

        protected override void SetRaceBaseValues()
        {
            BaseFoodSupply = SophonsBaseFoodSupply;
            BaseInfrastructureOutput = SophonsBaseInfrastructureOutput;
            BaseDustAmount = SophonsBaseDustAmount;
            BaseResarchFacilities = SophonsBaseResarchFacilities;
            BaseGeneralsNumber = SophonsBaseGeneralsNumber;
        }

        public static readonly string SophonsBaseFoodSupply = "0";
        public static readonly string SophonsBaseInfrastructureOutput = "0";
        public static readonly string SophonsBaseDustAmount = "100";
        public static readonly string SophonsBaseResarchFacilities = "0";
        public static readonly string SophonsBaseGeneralsNumber = "1";
    }
}
