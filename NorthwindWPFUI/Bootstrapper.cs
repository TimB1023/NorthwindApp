using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using NorthwindWPFUI.ViewModels;

namespace NorthwindWPFUI
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper() => Initialize();
        //public decimal x = NorthwindLibrary.NorthwindMethods.MaxRevenueByAnyCustomer();

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<NWMainViewModel>();
        }

    }
}
