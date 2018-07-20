using SIM.Instances;
using SIM.Pipelines.EnableSolr;
using SIM.Pipelines.Processors;
using SIM.Tool.Base.Wizards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM.Tool.Windows.UserControls.EnableSolr
{
  public class EnableSolrSettingsWizardArgs : WizardArgs
  {
    public Instance Instance { get; }

    public String SolrURL { get; set; }

    public String SolrServiceName { get; set; }

    public String SolrRoot { get; set; }

    public EnableSolrSettingsWizardArgs(Instance instance)
    {
      this.Instance = instance;
    }

    public override ProcessorArgs ToProcessorArgs()
    {
      var enableSolrArgs = new EnableSolrArgs(Instance, SolrURL, SolrServiceName, SolrRoot);
      return enableSolrArgs;
    }
  }
}
