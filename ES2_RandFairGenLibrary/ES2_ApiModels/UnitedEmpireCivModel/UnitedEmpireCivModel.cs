using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.UnitedEmpireCivModel
{
    public class UnitedEmpireCivModel : BaseCivModel, IUnitedEmpireCivModel
    {
        public UnitedEmpireCivModel() { }

        protected override void SetRaceBaseValues()
        {
            CivilizationName = UnitedEmpireCivilizationName;
            BaseFoodSupply = UnitedEmpireBaseFoodSupply;
            BaseInfrastructureOutput = UnitedEmpireBaseInfrastructureOutput;
            BaseDustAmount = UnitedEmpireBaseDustAmount;
            BaseResarchFacilities = UnitedEmpireBaseResarchFacilities;
            BaseGeneralsNumber = UnitedEmpireBaseGeneralsNumber;

            //temp just for test
            FoodSupply = "23";
            InfrastructureOutput = "45";
            DustAmount = "234";
            ResarchFacilities = "12";
            GeneralsNumber = "2";
        }

        //race specyfic features:
        public void SetInfluenceConversionRatio() { }

        public static readonly string UnitedEmpireCivilizationName = "UnitedEmpire";
        public static readonly string UnitedEmpireBaseFoodSupply = "0";
        public static readonly string UnitedEmpireBaseInfrastructureOutput = "50";
        public static readonly string UnitedEmpireBaseDustAmount = "100";
        public static readonly string UnitedEmpireBaseResarchFacilities = "0";
        public static readonly string UnitedEmpireBaseGeneralsNumber = "1";
    }
}
