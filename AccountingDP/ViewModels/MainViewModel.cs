using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System;

namespace AccountingDP.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ReportViewModel reportViewModel;
        public MainViewModel()
        {
            ReportViewModel = new();
            AccountingContext = new();
         
        }

        [ObservableProperty]
        private EF.Models.ThanhCongModel.AccountingContext accountingContext;

        [RelayCommand]
        public void TestEF()
        {
            string? connectionString = System.Configuration.ConfigurationManager.AppSettings["Setting1"];
            var result = AccountingContext.Users;
            object gg = Services.VietseaService.getNXT(DateTime.Now);
            var t = gg.GetType();
            string a = " ";
        }
    }
}
