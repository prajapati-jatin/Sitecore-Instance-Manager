
using SIM.Instances;
using SIM.Pipelines.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM.Pipelines.EnableSolr
{
  public class EnableSolrArgs : ProcessorArgs
  {
    public Instance Instance { get; }

    public String SolrURL { get; }

    public String SolrServiceName { get; }

    public String SolrRoot { get; }

    public EnableSolrArgs(Instance instance, String solrURL = null, String solrServiceName = null, String solrRoot = null)
    {
      this.Instance = instance;
      this.SolrURL = solrURL;
      this.SolrServiceName = solrServiceName;
      this.SolrRoot = solrRoot;
    }
  }
}
