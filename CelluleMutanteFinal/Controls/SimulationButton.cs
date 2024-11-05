using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CelluleMutanteFinal.Controls
{
    class SimulationButton : Button
    {
        public SimulationButton()
        {
            Name = "btn_simulation";
            Text = "Simulation";
            BackColor = Color.LightGray;
            ForeColor = Color.Black;
            Size = new Size(300, 40);
            Dock = DockStyle.None;
            Font = new Font("Arial", 14);
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.Selectable, false);
            
        }

    }
}

