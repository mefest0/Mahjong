using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahjong
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MainForm form = Owner as MainForm;

            if (form != null)
            {
                form.XCount = 2 * widthTBar.Value;
                form.YCount = lengthTBar.Value;
                form.ZCount = heightTBar.Value;

                if (easyRButton.Checked) form.Diff = Difficulty.Easy;
                else if (hardRButton.Checked) form.Diff = Difficulty.Hard;
                else form.Diff = Difficulty.Standart;

                if (pyramidRButton.Checked) form.FType = FieldType.Pyramid;
                else form.FType = FieldType.Rectangle;
            }
            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void TBar_Scroll(object sender, EventArgs e)
        {
            foreach (Control c in fieldSizePanel.Controls)
            {
                if (c is Label && (sender as TrackBar).Tag == c.Tag)
                {
                    int value = (c.Tag.ToString() == "1") ? (sender as TrackBar).Value * 2 : (sender as TrackBar).Value;
                    string ended;

                    if (value == 1)
                        ended = "кость";
                    else if (value < 5)
                        ended = "кости";
                    else ended = "костей";

                    (c as Label).Text = string.Format("{0} {1}", value, ended);
                }
            }
        }

        
    }
}
