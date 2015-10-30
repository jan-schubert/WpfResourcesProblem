using System.Windows;

namespace MainApplication
{
  public partial class App
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      new MyBootstrapper().Run();
    }
  }
}
