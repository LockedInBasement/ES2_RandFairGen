using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ExportModels
{
    public class ExportModFile
    {
        public ExportModFile() { }

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
    }
}