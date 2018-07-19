using JetBrains.Annotations;
using SIM.Instances;
using SIM.Tool.Base;
using SIM.Tool.Base.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SIM.Tool.Windows.MainWindowComponents
{
  public class EnableSolrButton : IMainWindowButton
  {
    public bool IsEnabled([NotNull] Window mainWindow, [CanBeNull] Instance instance)
    {
      if(instance != null)
      {
        return true;
      }
      return false;
    }

    public void OnClick([NotNull] Window mainWindow, [CanBeNull] Instance instance)
    {
      WindowHelper.ShowMessage("Enable solr");
    }
  }
}
