using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ES2_RandFairGenLibrary.ES2_ApiModels
{
    public class MainWindowAppModel : IMainWindowAppModel
    {
        public MainWindowAppModel(IBaseCivModel craversCivModel, IBaseCivModel horatioCivModel, IBaseCivModel lumerisCivModel, IBaseCivModel riftbornCivModel, IBaseCivModel sophonsCivModel,
            IBaseCivModel unfallenCivModel, IBaseCivModel unitedEmpireCivModel, IBaseCivModel vodyaniCivModel)
        {
            this.craversCivModel = craversCivModel;
            this.horatioCivModel = horatioCivModel;
            this.lumerisCivModel = lumerisCivModel;
            this.riftbornCivModel = riftbornCivModel;
            this.sophonsCivModel = sophonsCivModel;
            this.unfallenCivModel = unfallenCivModel;
            this.unitedEmpireCivModel = unitedEmpireCivModel;
            this.vodyaniCivModel = vodyaniCivModel;

            streamWriter = new StreamWriter("ES2_ModChange.txt");
            
            civModels = new List<IBaseCivModel>();
            civModels.Add(craversCivModel);
            civModels.Add(horatioCivModel);
            civModels.Add(lumerisCivModel);
            civModels.Add(riftbornCivModel);
            civModels.Add(sophonsCivModel);
            civModels.Add(unfallenCivModel);
            civModels.Add(unitedEmpireCivModel);
            civModels.Add(vodyaniCivModel);
        }

        public void Overwrite()
        {

        }

        public void Export()
        {
            streamWriter.Write(BuildExporText());
            streamWriter.Close();
        }

        string BuildExporText()
        {
            string textToExport = string.Empty;

            foreach (IBaseCivModel civModel in civModels)
            {
                textToExport = textToExport + $"{civModel.CivilizationName} \n" +
                $"FoodSupply = {civModel.FoodSupply} \n" +
                $"InfrastructureOutput = {civModel.InfrastructureOutput} \n" +
                $"DustAmount = {civModel.DustAmount} \n" +
                $"ResarchFacilities = {civModel.ResarchFacilities} \n" +
                $"GeneralsNumber = {civModel.GeneralsNumber} \n\n";
            }

            return textToExport;
        }


        StreamWriter streamWriter;
        List<IBaseCivModel> civModels;

        private IBaseCivModel craversCivModel;
        private IBaseCivModel horatioCivModel;
        private IBaseCivModel lumerisCivModel;
        private IBaseCivModel riftbornCivModel;
        private IBaseCivModel sophonsCivModel;
        private IBaseCivModel unfallenCivModel;
        private IBaseCivModel unitedEmpireCivModel;
        private IBaseCivModel vodyaniCivModel;

        public IBaseCivModel CraversCivModel { get => craversCivModel; set => craversCivModel = value; }
        public IBaseCivModel HoratioCivModel { get => horatioCivModel; set => horatioCivModel = value; }
        public IBaseCivModel LumerisCivModel { get => lumerisCivModel; set => lumerisCivModel = value; }
        public IBaseCivModel RiftbornCivModel { get => riftbornCivModel; set => riftbornCivModel = value; }
        public IBaseCivModel SophonsCivModel { get => sophonsCivModel; set => sophonsCivModel = value; }
        public IBaseCivModel UnfallenCivModel { get => unfallenCivModel; set => unfallenCivModel = value; }
        public IBaseCivModel UnitedEmpireCivModel { get => unitedEmpireCivModel; set => unitedEmpireCivModel = value; }
        public IBaseCivModel VodyaniCivModel { get => vodyaniCivModel; set => vodyaniCivModel = value; }
    }
}
