using JetBrains.Annotations;
using SIM.Extensions;
using SIM.Instances;
using SIM.Pipelines.EnableSolr;
using SIM.Tool.Base;
using SIM.Tool.Base.Plugins;
using SIM.Tool.Base.Wizards;
using SIM.Tool.Windows.UserControls.EnableSolr;
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
      return (instance != null && instance.Product != null && 
        instance.Product.Name.EqualsIgnoreCase("Sitecore CMS") && 
        instance.Product.TwoVersion.StartsWith("8."));
    }

    public void OnClick([NotNull] Window mainWindow, [CanBeNull] Instance instance)
    {
      if(instance != null)
      {
        var id = MainWindowHelper.GetListItemID(instance.ID);
        WizardPipelineManager.Start("enablesolr", mainWindow, new EnableSolrArgs(instance), null, ignore => MainWindowHelper.MakeInstanceSelected(id), () => new EnableSolrSettingsWizardArgs(instance));
      }
    }
  }
}
