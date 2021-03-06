﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.LumerisCivModel
{
    public class LumerisCivModel : BaseCivModel, ILumerisCivModel
    {
        public LumerisCivModel() { }

        protected override void SetRaceBaseValues()
        {
            CivilizationName = LumerisCivilizationName;
            BaseFoodSupply = LumerisBaseFoodSupply;
            BaseInfrastructureOutput = LumerisBaseInfrastructureOutput;
            BaseDustAmount = LumerisBaseDustAmount;
            BaseResarchFacilities = LumerisBaseResarchFacilities;
            BaseGeneralsNumber = LumerisBaseGeneralsNumber;
        }

        public void MarketSalesChange() { }

        public static readonly string LumerisCivilizationName = "Lumeris";
        public static readonly string LumerisBaseFoodSupply = "0";
        public static readonly string LumerisBaseInfrastructureOutput = "0";
        public static readonly string LumerisBaseDustAmount = "500";
        public static readonly string LumerisBaseResarchFacilities = "0";
        public static readonly string LumerisBaseGeneralsNumber = "1";
    }
}
