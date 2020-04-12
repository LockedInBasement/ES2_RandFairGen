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
using ES2_RandFairGenLibrary.ES2_ApiModels;
using ES2_RandFairGen.ViewModels.UnitedEmpirePage;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;
using System.Diagnostics;
using ES2_RandFairGenLibrary.ES2_ApiModels.UnitedEmpireCivModel;
using ES2_RandFairGenLibrary.ES2_ApiModels.CraversCivModel;
using ES2_RandFairGenLibrary.ES2_ApiModels.HoratioCivModel;
using ES2_RandFairGenLibrary.ES2_ApiModels.LumerisCivModel;
using ES2_RandFairGenLibrary.ES2_ApiModels.SophonsCivModel;
using ES2_RandFairGenLibrary.ES2_ApiModels.UnfallenCivModel;
using ES2_RandFairGenLibrary.ES2_ApiModels.VodyaniCivModel;
using ES2_RandFairGenLibrary.ES2_ApiModels.RiftbornCivModel;

namespace ES2_RandFairGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window //IServiceProvider
    {
        #region Init

        public MainWindow()
        {
            InitializeComponent();

            CreateLibModels();
        }

        //To do
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IMainWindowAppModel, MainWindowAppModel>();
            //services.AddTransient<IBaseCivModel, UnitedEmpireCivModel>();
            //services.AddTransient<IProductData, ProductData>();
            //services.AddTransient<ISaleData, SaleData>();
            //services.AddTransient<IUserData, UserData>();
        }

        //Code smell - (to do list)
        private void CreateLibModels()
        {
            rightPanelState = UIElementState.Visible;
            leftPanelState = UIElementState.Invisible;

            mainWindowAppModel = new MainWindowAppModel(new CraversCivModel(), new HoratioCivModel(), new LumerisCivModel(), new RiftbornCivModel(), new SophonsCivModel(), new UnfallenCivModel(), 
                new UnitedEmpireCivModel(), new VodyaniCivModel());

            Debug.Write(mainWindowAppModel.CraversCivModel.CivilizationName);
            unitedEmpirePage = new UnitedEmpirePage(mainWindowAppModel);
        }

        #endregion

        #region MainGrid Buttons

        //Title bar

        private void ButtonOptionsMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To Do -> check board priority");

            //Storyboard storyboard = (Storyboard)TryFindResource("SlideMainPage");
            //storyboard.Begin();

            //mainWindowAppStateModel.LeftPanelState = MainWindowAppStateModel.UIElementState.Visible;
        }
        
        private void MainGridInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if(rightPanelState == UIElementState.Invisible)
            {
                Storyboard storyboard = (Storyboard)TryFindResource("RightPanelShow");
                storyboard.Begin();

                rightPanelState = UIElementState.Visible;
            }
            else
            {
                Storyboard storyboard = (Storyboard)TryFindResource("RightPanelHide");
                storyboard.Begin();

                rightPanelState = UIElementState.Invisible;
            }
        }

        private void MainGridExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Races
        private void UnitedEmpireButton_Click(object sender, MouseButtonEventArgs e)
        {
            unitedEmpirePage.Show();
        }

        #endregion

        #region RightPanel Buttons

        private void ChangePathButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To Do -> check board priority");
        }

        private void ExportDataToTxtButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindowAppModel.Export();
        }

        private void HidePanelButton_Click(object sender, RoutedEventArgs e)
        {
            if (rightPanelState == UIElementState.Visible)
            {
                Storyboard storyboard = (Storyboard)TryFindResource("RightPanelHide");
                storyboard.Begin();

                rightPanelState = UIElementState.Invisible;
            }
        }

        #endregion

        #region Data

        IMainWindowAppModel mainWindowAppModel;

        UnitedEmpirePage unitedEmpirePage;

        private UIElementState rightPanelState;
        private UIElementState leftPanelState;

        #endregion

        #region Property

        public enum UIElementState
        {
            Error = 0,
            Visible = 1,
            Invisible = 2,
        }

        #endregion
    }
}