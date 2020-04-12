using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.RiftbornCivModel
{
    public class RiftbornCivModel : BaseCivModel, IRiftbornCivModel
    {
        public RiftbornCivModel() { }

        protected override void SetRaceBaseValues()
        {
            CivilizationName = RiftbornCivilizationName;
            BaseFoodSupply = RiftbornBaseFoodSupply;
            BaseInfrastructureOutput = RiftbornBaseInfrastructureOutput;
            BaseDustAmount = RiftbornBaseDustAmount;
            BaseResarchFacilities = RiftbornBaseResarchFacilities;
            BaseGeneralsNumber = RiftbornBaseGeneralsNumber;
        }

        public void IncereaseManpowerCreationFactor() { }

        public static readonly string RiftbornCivilizationName = "Riftborn";
        public static readonly string RiftbornBaseFoodSupply = "0";
        public static readonly string RiftbornBaseInfrastructureOutput = "0";
        public static readonly string RiftbornBaseDustAmount = "250";
        public static readonly string RiftbornBaseResarchFacilities = "0";
        public static readonly string RiftbornBaseGeneralsNumber = "1";
    }
}
