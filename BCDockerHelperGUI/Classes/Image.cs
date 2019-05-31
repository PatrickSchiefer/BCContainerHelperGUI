using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDockerHelper
{
    public class Image
    {
        #region Images
        public string ID { get; set; }
        public string Repository { get; set; }
        public string Tag { get; set; }
        public string Size { get; set; }
        #endregion

        #region Methods
        public async Task Remove()
        {
            await PowershellHelper.Instance.RemoveImage(ID);
            return;
        }
        #endregion
    }
}
