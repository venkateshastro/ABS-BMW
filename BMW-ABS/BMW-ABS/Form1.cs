using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMW_ABS
{
    public partial class Form1 : Form
    {
        const string exportFile = "FSW_PSW.TRC";
        public static readonly KeyValuePair<string, KeyValuePair<string, string>[]>[] keyvalues =
            new KeyValuePair<string, KeyValuePair<string, string>[]>[]
            {
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_UEBERSTEUERN_MUE_1_2",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_06", "0.5 m/s²"),
                        new KeyValuePair<string, string>("\twert_02", "1 m/s²"),
                        new KeyValuePair<string, string>("\twert_05", "1.406 m/s²"),
                        new KeyValuePair<string, string>("\twert_09", "1.594 m/s²"),
                        new KeyValuePair<string, string>("\twert_08", "1.781 m/s²"),
                        new KeyValuePair<string, string>("\twert_04", "1.797 m/s²"),
                        new KeyValuePair<string, string>("\twert_11", "1.813 m/s²"),
                        new KeyValuePair<string, string>("\twert_03", "2 m/s²"),
                        new KeyValuePair<string, string>("\twert_01", "2.203 m/s²"),
                        new KeyValuePair<string, string>("\twert_10", "2.297 m/s²"),
                        new KeyValuePair<string, string>("\twert_07", "2.406 m/s²"),
                        new KeyValuePair<string, string>("\twert_00\n\twert_12", "2.5 m/s²")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_UNTERSTEUERSCHWELLE",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00\n\twert_01", "Value 00/01 (0)"),
                        new KeyValuePair<string, string>("\twert_02", "Value 02 (13)"),
                        new KeyValuePair<string, string>("\twert_03", "Value 03 (19)"),
                        new KeyValuePair<string, string>("\twert_04", "Value 04 (6)")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_DELTA_PSI_BETA_LIMIT",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00", "Value 00 (0)"),
                        new KeyValuePair<string, string>("\twert_01", "Value 01 (3)"),
                        new KeyValuePair<string, string>("\twert_02", "Value 02 (5)"),
                        new KeyValuePair<string, string>("\twert_03", "Value 03 (4)"),
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_LENKWINKELKENNLINIE",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00\n\twert_04", "Value 00/04 (0)"),
                        new KeyValuePair<string, string>("\twert_01", "Value 01 (3)"),
                        new KeyValuePair<string, string>("\twert_02", "Value 02 (4)"),
                        new KeyValuePair<string, string>("\twert_03", "Value 03 (2)")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_HSA",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00", "Value 00 (0)"),
                        new KeyValuePair<string, string>("\twert_01", "Value 01 (87)"),
                        new KeyValuePair<string, string>("\twert_02", "Value 02 (135)"),
                        new KeyValuePair<string, string>("\twert_03", "Value 03 (183)"),
                        new KeyValuePair<string, string>("\twert_04", "Value 04 (199)"),
                        new KeyValuePair<string, string>("\twert_05", "Value 05 (47)"),
                        new KeyValuePair<string, string>("\twert_06", "Value 06 (111)")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_GMK_ECBA_VA",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00\n\twert_02", "0 mm"),
                        new KeyValuePair<string, string>("\twert_06", "9 mm"),
                        new KeyValuePair<string, string>("\twert_01", "24 mm"),
                        new KeyValuePair<string, string>("\twert_03", "30 mm"),
                        new KeyValuePair<string, string>("\twert_04", "33 mm"),
                        new KeyValuePair<string, string>("\twert_05", "39 mm")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_GMK_ECBA_HA",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00", "0 mm"),
                        new KeyValuePair<string, string>("\twert_05", "6 mm"),
                        new KeyValuePair<string, string>("\twert_01", "27 mm"),
                        new KeyValuePair<string, string>("\twert_03", "36 mm"),
                        new KeyValuePair<string, string>("\twert_02", "39 mm"),
                        new KeyValuePair<string, string>("\twert_04", "45 mm")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_BBV",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_01", "Off"),
                        new KeyValuePair<string, string>("\twert_02", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_RPA",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_01", "Off"),
                        new KeyValuePair<string, string>("\twert_02", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_FLR",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_02", "Off"),
                        new KeyValuePair<string, string>("\twert_00\n\twert_01", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>(
                    "C0A_AFS",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_02", "Off"),
                        new KeyValuePair<string, string>("\twert_01", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>( // check
                    "C0A_DF_DIR",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00\n\twert_02", "Off"),
                        new KeyValuePair<string, string>("\twert_01", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>( // check
                    "C0B_SST",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00", "Off"),
                        new KeyValuePair<string, string>("\twert_01", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>( // check
                    "C0B_TB_BDD",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00", "Off"),
                        new KeyValuePair<string, string>("\twert_01", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>( // check
                    "C0B_FBS",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00", "Off"),
                        new KeyValuePair<string, string>("\twert_01", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>( // check
                    "C0A_GMK",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00", "Off"),
                        new KeyValuePair<string, string>("\twert_01", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>( // check
                    "C0A_BBV_KORR_VA",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00\n\twert_01", "Off"),
                        new KeyValuePair<string, string>("\twert_02", "On")
                    }
                    ),
                new KeyValuePair<string, KeyValuePair<string, string>[]>( // check
                    "C0A_BBV_KORR_HA",
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("\twert_00\n\twert_01", "Off"),
                        new KeyValuePair<string, string>("\twert_02", "On")
                    }
                    )
            };
        
        public List<string> file;
        public int[] keyIndices = new int[keyvalues.Length];
        bool loaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = importButton.Text;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file = File.ReadAllLines(openFileDialog1.FileName).ToList();
                    for (int i = 0; i < keyvalues.Length; i++)
                        keyIndices[i] = Array.IndexOf(
                            keyvalues[i].Value.Select(pair => pair.Key.Split('\n')[0]).ToArray(),
                            file[file.IndexOf(keyvalues[i].Key) + 1]
                            );
                    oversteerTrack.Value = keyIndices[0];
                    understeerTrack.Value = keyIndices[1];
                    deltapsiTrack.Value = keyIndices[2];
                    anglecurveTrack.Value = keyIndices[3];
                    startoffTrack.Value = keyIndices[4];
                    yawmomentfrontTrack.Value = keyIndices[5];
                    yawmomentrearTrack.Value = keyIndices[6];
                    brakepadCheck.Checked = keyIndices[7] == 1;
                    flattireCheck.Checked = keyIndices[8] == 1;
                    reductionCheck.Checked = keyIndices[9] == 1;
                    activefrontCheck.Checked = keyIndices[10] == 1;
                    rotationCheck.Checked = keyIndices[11] == 1;
                    softstopCheck.Checked = keyIndices[12] == 1;
                    brakedryCheck.Checked = keyIndices[13] == 1;
                    brakefadingCheck.Checked = keyIndices[14] == 1;
                    yawmomentCheck.Checked = keyIndices[15] == 1;
                    brakepadfrontCheck.Checked = keyIndices[16] == 1;
                    brakepadrearCheck.Checked = keyIndices[17] == 1;
                    exportButton.Enabled = Enabled;
                    loaded = true;
                }
                catch
                {
                    MessageBox.Show("File malformed or from a different module!");
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = exportButton.Text;
            saveFileDialog1.FileName = exportFile;
            saveFileDialog1.Filter = "|*.TRC";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllLines(saveFileDialog1.FileName, file.ToArray());
        }

        private void ValueChangeHelperTrack(TrackBar control, int controlIndex, bool loaded)
        {
            toolTip1.SetToolTip(control, keyvalues[controlIndex].Value[control.Value].Value);
            if (loaded)
            {
                int parameter = file.IndexOf(keyvalues[controlIndex].Key);
                while (parameter + 1 < file.Count && file[parameter + 1].Contains('\t'))
                    file.RemoveAt(parameter + 1);
                foreach (string value in keyvalues[controlIndex].Value[control.Value].Key.Split('\n').Reverse())
                    file.Insert(parameter + 1, value);
            }
        }

        private void ValueChangeHelperCheck(CheckBox control, int controlIndex, bool loaded)
        {
            toolTip1.SetToolTip(control, keyvalues[controlIndex].Value[control.Checked ? 1 : 0].Value);
            if (loaded)
            {
                int parameter = file.IndexOf(keyvalues[controlIndex].Key);
                while (parameter + 1 < file.Count && file[parameter + 1].Contains('\t'))
                    file.RemoveAt(parameter + 1);
                foreach (string value in keyvalues[controlIndex].Value[control.Checked ? 1 : 0].Key.Split('\n').Reverse())
                    file.Insert(parameter + 1, value);
            }
        }

        private void oversteerTrack_Scroll(object sender, EventArgs e)
        {
            ValueChangeHelperTrack(this.oversteerTrack, 0, loaded);
            //creditsLabel.Text = keyvalues[0].Value[this.oversteerTrack.Value].Key;
        }

        private void understeerTrack_Scroll(object sender, EventArgs e)
        {
            ValueChangeHelperTrack(this.understeerTrack, 1, loaded);
        }

        private void deltapsiTrack_Scroll(object sender, EventArgs e)
        {
            ValueChangeHelperTrack(this.deltapsiTrack, 2, loaded);
        }

        private void anglecurveTrack_Scroll(object sender, EventArgs e)
        {
            ValueChangeHelperTrack(this.anglecurveTrack, 3, loaded);
        }

        private void startoffTrack_Scroll(object sender, EventArgs e)
        {
            ValueChangeHelperTrack(this.startoffTrack, 4, loaded);
        }

        private void yawmomentfrontTrack_Scroll(object sender, EventArgs e)
        {
            ValueChangeHelperTrack(this.yawmomentfrontTrack, 5, loaded);
        }

        private void yawmomentrearTrack_Scroll(object sender, EventArgs e)
        {
            ValueChangeHelperTrack(this.yawmomentrearTrack, 6, loaded);
        }

        private void brakepadCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.brakepadCheck, 7, loaded);
        }

        private void flattireCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.flattireCheck, 8, loaded);
        }

        private void reductionCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.reductionCheck, 9, loaded);
        }

        private void activefrontCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.activefrontCheck, 10, loaded);
        }

        private void rotationCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.rotationCheck, 11, loaded);
        }

        private void softstopCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.softstopCheck, 12, loaded);
        }

        private void brakedryCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.brakedryCheck, 13, loaded);
        }

        private void brakefadingCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.brakefadingCheck, 14, loaded);
        }

        private void yawmomentCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.yawmomentCheck, 15, loaded);
        }

        private void brakepadfrontCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.brakepadfrontCheck, 16, loaded);
        }

        private void brakepadrearCheck_CheckedChanged(object sender, EventArgs e)
        {
            ValueChangeHelperCheck(this.brakepadrearCheck, 17, loaded);
        }
    }
}
