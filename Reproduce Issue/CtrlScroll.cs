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
        // Solution provided by user "γηράσκω δ' αεί πολλά διδασκόμε" on StackOverflow.
        // https://stackoverflow.com/users/2261657/γηράσκω-δ-αεί-πολλά-διδασκόμε
        // https://stackoverflow.com/questions/51008730/custom-scrollbar-scrolling-triggers-autoscroll-scrollbars/51091719#51091719
        // (I love you so much)
        public CtrlScroll() {
            InitializeComponent();

            scbMain.Scroll += (sender, e) => {
                //Normally the if statement whouldn't be needed but the metro srollbar
                //has a weird behaviour when the scroll value becomes max
                if (scbMain.Value > pnlBody.Height - this.Height) {
                    pnlBody.Top = -(pnlBody.Height - this.Height);
                } else {
                    pnlBody.Top = -scbMain.Value;
                };
            };
        }

        private void updateScrollbar() {
            int maxVertical = pnlBody.Height;

            // Hide the scrollbar if it's not scrollable.
            // It's just better this way ;)
            bool scrollable = maxVertical >= this.Height;
            scbMain.Visible = scrollable;
            pnlBody.Top = scrollable ? pnlBody.Top : 0;

            // SmallChange is typically 1%.
            int smallChangeVertical = Math.Max((int)(maxVertical / 100), 1);

            // LargeChange is one page.
            int largeChangeVertical = this.Height;

            scbMain.Minimum = 0;
            scbMain.Maximum = maxVertical;
            scbMain.SmallChange = smallChangeVertical;
            scbMain.LargeChange = largeChangeVertical;
        }

        private void CtrlScroll_Resize(object sender, EventArgs e) {
            updateScrollbar();
        }
    }
}
