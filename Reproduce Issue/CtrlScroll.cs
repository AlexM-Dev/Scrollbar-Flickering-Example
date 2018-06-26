using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproduce_Issue {
    public partial class CtrlScroll : UserControl {
        public CtrlScroll() {
            InitializeComponent();
            scbMain.Scroll += (sender, e) => {
                VerticalScroll.Value = scbMain.Value;
            };
        }

        private void CtrlScroll_Load(object sender, EventArgs e) {
        }
    }
}
