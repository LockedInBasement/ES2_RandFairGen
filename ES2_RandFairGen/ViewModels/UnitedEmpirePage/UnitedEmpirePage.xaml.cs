using ES2_RandFairGenLibrary.ES2_ApiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace ES2_RandFairGen.ViewModels.UnitedEmpirePage
{
    /// <summary>
    /// Interaction logic for UnitedEmpirePage.xaml
    /// </summary>
    public partial class UnitedEmpirePage : Window
    {
        private readonly IMainWindowAppModel mainWindowAppModel;

        public UnitedEmpirePage(IMainWindowAppModel mainWindowAppModel)
        {
            InitializeComponent();
            this.mainWindowAppModel = mainWindowAppModel;
        }

        private void UnitedEmpireReturnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void RestoreDefaults(object sender, MouseButtonEventArgs e)
        {
            mainWindowAppModel.UnitedEmpireCivModel.RestoreDefaults();
        }

        private void OverwriteDefaults(object sender, MouseButtonEventArgs e)
        {
            mainWindowAppModel.UnitedEmpireCivModel.Overwrite("1", "1", "1", "1", "1");
        }

        private void ValidateText(object sender, TextCompositionEventArgs e)
        {
            if(!IsTextAllowed(e.Text))
            {
                e.Handled = false;
                //here;
            }
            else
            {
                mainWindowAppModel.UnitedEmpireCivModel.FoodSupply = (e.Text);
            }

        }

        private static bool IsTextAllowed(string text)
        {
            bool answer = !IsNumber.IsMatch(text);
            return answer; 
        }

        private static Regex IsNumber { get; } = new Regex("[^0-9]+");
    }
}
