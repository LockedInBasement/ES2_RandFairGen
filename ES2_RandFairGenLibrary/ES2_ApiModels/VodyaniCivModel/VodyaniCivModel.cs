using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.VodyaniCivModel
{
    public class VodyaniCivModel : BaseCivModel
    {
        public VodyaniCivModel() { }

        protected override void SetRaceBaseValues()
        {
            BaseFoodSupply = VodyaniBaseFoodSupply;
            BaseInfrastructureOutput = VodyaniBaseInfrastructureOutput;
            BaseDustAmount = VodyaniBaseDustAmount;
            BaseResarchFacilities = VodyaniBaseResarchFacilities;
            BaseGeneralsNumber = VodyaniBaseGeneralsNumber;
        }

        //mothership modules add!
        public static readonly string VodyaniBaseFoodSupply = "0";
        public static readonly string VodyaniBaseInfrastructureOutput = "0";
        public static readonly string VodyaniBaseDustAmount = "200";
        public static readonly string VodyaniBaseResarchFacilities = "30";
        public static readonly string VodyaniBaseGeneralsNumber = "1";
    }
}
