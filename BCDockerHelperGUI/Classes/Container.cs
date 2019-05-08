using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDockerHelper
{
    public enum ContainerStatus
    {
        stopped,
        unhealthy,
        starting,
        healthy,
        unknown
    }
    public class Container
    {
        #region Properties
        public string ID { get; set; }
        public string Containername { get; set; }
        public ContainerStatus ContainerStatus { get; set; }
        public string ContainerStatusText { get; set; }
        #endregion

        #region Methods
        public async Task Restart()
        {
            await PowershellHelper.Instance.RestartContainer(Containername);
            return;
        }
        public async Task Stop()
        {
            await PowershellHelper.Instance.StopContainer(Containername);
            return;
        }
        public async Task Start()
        {
            await PowershellHelper.Instance.StartContainer(Containername);
            return;
        }

        public async Task Remove()
        {
            await PowershellHelper.Instance.RemoveContainer(Containername);
            return;
        }
        public override string ToString()
        {
            return Containername;
        }


        #endregion
    }
}
