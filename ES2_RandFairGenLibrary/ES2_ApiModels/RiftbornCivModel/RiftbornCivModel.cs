using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels.RiftbornCivModel
{
    class RiftbornCivModel : BaseCivModel
    {
        public RiftbornCivModel() { }

        protected override void SetRaceBaseValues()
        {
            BaseFoodSupply = RiftbornBaseFoodSupply;
            BaseInfrastructureOutput = RiftbornBaseInfrastructureOutput;
            BaseDustAmount = RiftbornBaseDustAmount;
            BaseResarchFacilities = RiftbornBaseResarchFacilities;
            BaseGeneralsNumber = RiftbornBaseGeneralsNumber;
        }

        //Consider creating additional manpower!
        public static readonly string RiftbornBaseFoodSupply = "0";
        public static readonly string RiftbornBaseInfrastructureOutput = "0";
        public static readonly string RiftbornBaseDustAmount = "250";
        public static readonly string RiftbornBaseResarchFacilities = "0";
        public static readonly string RiftbornBaseGeneralsNumber = "1";
    }
}
