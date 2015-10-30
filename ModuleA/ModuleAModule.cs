using System.ComponentModel.Composition;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
  [ModuleExport(typeof(ModuleAModule))]
  public class ModuleAModule : IModule
  {
    private readonly IRegionManager _regionManager;

    [ImportingConstructor]
    public ModuleAModule(IRegionManager regionManager)
    {
      _regionManager = regionManager;
    }

    public void Initialize()
    {
      // Show the Orders Editor view in the shell's main region.
      _regionManager.RegisterViewWithRegion("MainRegion", typeof (MyView));
    }
  }
}