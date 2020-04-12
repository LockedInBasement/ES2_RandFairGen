namespace ES2_RandFairGenLibrary.ES2_ApiModels
{
    public interface IMainWindowAppModel
    {
        void Export();
        void Overwrite();

        public IBaseCivModel CraversCivModel { get; set; }
        public IBaseCivModel HoratioCivModel { get; set; }
        public IBaseCivModel LumerisCivModel { get; set; }
        public IBaseCivModel RiftbornCivModel { get; set; }
        public IBaseCivModel SophonsCivModel { get; set; }
        public IBaseCivModel UnfallenCivModel { get; set; }
        public IBaseCivModel UnitedEmpireCivModel { get; set; }
        public IBaseCivModel VodyaniCivModel { get ; set ; }
    }
}