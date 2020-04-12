using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ES2_RandFairGenLibrary.ES2_ApiModels.UnitedEmpirePage;

namespace ES2_RandFairGenLibrary.ES2_ApiModels
{
    public class MainWindowAppModel : IMainWindowAppModel
    {
        public MainWindowAppModel(IBaseCivModel unitedEmpireCivModel)
        {
            this.unitedEmpireCivModel = unitedEmpireCivModel;
        }

        public void Overwrite()
        {

        }

        public void Export()
        {
            StreamWriter streamWriter = new StreamWriter("ES2_ModChange.txt");

            ExportFileText = new string(
               $"Cravers EmpireMoney={CraversEmpireMoney} \n" +
               $"Sophons EmpireMoney={SophonsEmpireMoney} \n" +
               $"UnitedEmpire EmpireMoney={UnitedEmpireEmpireMoney} \n" +
               $"Horatio EmpireMoney={HoratioEmpireMoney} \n" +
               $"RiftBorn EmpireMoney={RiftBornEmpireMoney} \n" +
               $"Vodyani EmpireMoney={VodyaniEmpireMoney} \n" +
               $"Lumeris EmpireMoney={LumerisEmpireMoney} \n" +
               $"Unfallens EmpireMoney={UnfallensEmpireMoney} \n");

            streamWriter.Write(ExportFileText);
            streamWriter.Close();
        }

        string CraversEmpireMoney = "50";
        string SophonsEmpireMoney = "100";
        string UnitedEmpireEmpireMoney = "200";
        string HoratioEmpireMoney = "100";
        string RiftBornEmpireMoney = "100";
        string VodyaniEmpireMoney = "150";
        string LumerisEmpireMoney = "350";
        string UnfallensEmpireMoney = "150";

        string ExportFileText;

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
