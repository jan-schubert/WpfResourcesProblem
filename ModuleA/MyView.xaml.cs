using System.ComponentModel.Composition;

namespace ModuleA
{
  [Export]
  public partial class MyView
  {
    public MyView()
    {
      InitializeComponent();
    }
  }
}
