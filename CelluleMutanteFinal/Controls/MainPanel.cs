using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CelluleMutanteFinal.Controls
{
    public class MainPanel : Panel
    {
        public MainPanel()
        {
            Name = "pnl_main";
            BackColor = Color.LightGray;
            Anchor = AnchorStyles.None;
            Size = new Size(400, 400);
            Dock = DockStyle.None;

        }


    }
}
