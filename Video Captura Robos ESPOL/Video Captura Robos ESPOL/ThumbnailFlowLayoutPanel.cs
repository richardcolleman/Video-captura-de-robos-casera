using System;
using System.Windows.Forms;
using System.Drawing;

namespace Video_Captura_Robos_ESPOL
{
    public class ThumbnailFlowLayoutPanel : FlowLayoutPanel
    {
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }
    }
}
