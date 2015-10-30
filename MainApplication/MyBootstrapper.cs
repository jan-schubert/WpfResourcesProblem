using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Prism.Logging;
using Prism.Mef;
using Prism.Modularity;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MainApplication
{
  public class MyBootstrapper : MefBootstrapper
  {
    protected override DependencyObject CreateShell()
    {
      return ServiceLocator.Current.GetInstance<ShellView>();
    }

    protected override void InitializeShell()
    {
      Application.Current.MainWindow = (Window) Shell;
      Application.Current.MainWindow.Show();
    }

    protected override IModuleCatalog CreateModuleCatalog()
    {
      // When using MEF, the existing Prism ModuleCatalog is still
      // the place to configure modules via configuration files.
      return new ConfigurationModuleCatalog();
    }

    protected override void ConfigureAggregateCatalog()
    {
      base.ConfigureAggregateCatalog();

      AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MyBootstrapper).Assembly));

      AggregateCatalog.Catalogs.Add(new DirectoryCatalog("Modules"));
    }
  }
}