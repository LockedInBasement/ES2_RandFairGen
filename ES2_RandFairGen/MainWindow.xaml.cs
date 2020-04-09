using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ES2_RandFairGenLibrary.ES2_ExportModels;
using ES2_RandFairGenLibrary.ES2_ApiModels;

namespace ES2_RandFairGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Init

        public MainWindow()
        {
            InitializeComponent();

            //DI later -> for test code smell :P
            CreateLibModels();
        }

        private void CreateLibModels()
        {
            exportModFile = new ExportModFile();
            mainWindowAppStateModel = new MainWindowAppStateModel();
        }

        #endregion

        #region MainGrid Buttons

        private void ButtonOptionsMenu_Click(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = (Storyboard)TryFindResource("SlideMainPage");
            storyboard.Begin();

            mainWindowAppStateModel.LeftPanelState = MainWindowAppStateModel.UIElementState.Visible;
        }

        private void MainGridInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if(mainWindowAppStateModel.RightPanelState == MainWindowAppStateModel.UIElementState.Invisible)
            {
                Storyboard storyboard = (Storyboard)TryFindResource("RightPanelShow");
                storyboard.Begin();

                mainWindowAppStateModel.RightPanelState = MainWindowAppStateModel.UIElementState.Visible;
            }
        }

        private void MainGridExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region RightPanel Buttons

        private void ChangePathButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To Do -> check board priority");
        }

        private void ExportDataToTxtButton_Click(object sender, RoutedEventArgs e)
        {
            exportModFile.Export();
            MessageBox.Show("Exported - for now no dialog window - to do list ;)");
        }

        private void HidePanelButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindowAppStateModel.RightPanelState == MainWindowAppStateModel.UIElementState.Visible)
            {
                Storyboard storyboard = (Storyboard)TryFindResource("RightPanelHide");
                storyboard.Begin();

                mainWindowAppStateModel.RightPanelState = MainWindowAppStateModel.UIElementState.Invisible;
            }
        }

        #endregion

        #region Data

        ExportModFile exportModFile;
        MainWindowAppStateModel mainWindowAppStateModel;

        #endregion
    }
}
