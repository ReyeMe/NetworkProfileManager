using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace mTwork 
{
    public partial class Form1 : Form 
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage( IntPtr hWnd, int Msg, int wParam, int lParam );
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown( object sender, System.Windows.Forms.MouseEventArgs e )
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        string env = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\saves";

        public Form1()
        {
            InitializeComponent();
            Width = 320;

            IP_add_TextChanged(this, EventArgs.Empty);
            IP_mask_TextChanged(this, EventArgs.Empty);
            IP_gate_TextChanged(this, EventArgs.Empty);
            net_refresh_Click(this, EventArgs.Empty);
        }

        private void SetDHCP( string Card )
        {
            string arguments = "interface ip set address \"" + Card + "\" dhcp";
            ProcessStartInfo procStartInfo = new ProcessStartInfo("netsh", arguments);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            Process.Start(procStartInfo);
        }

        private void SetStaticIP(string IP, string Mask, string Gate, string Card)
        {
            string arguments = "interface ip set address \""+Card+"\" static "+IP+" "+Mask+" "+Gate;
            ProcessStartInfo procStartInfo = new ProcessStartInfo("netsh", arguments);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            Process.Start(procStartInfo);
        }

        private void Form1_VisibleChanged( object sender, EventArgs e )
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width - 25,
                                      workingArea.Bottom - Size.Height - 25);
        }

        bool bHide = false;
        private void btn_toTray_Click( object sender, EventArgs e )
        {
            Hide();
            bHide = true;
        }

        private void btn_exit_Click( object sender, EventArgs e )
        {
            Close();
        }

        //GOTO home
        private void goto_1_l_Click( object sender, EventArgs e )
        {
            page2.Visible = false;
            page3.Visible = false;

            page2.Enabled = false;
            page3.Enabled = false;

            page1.Visible = true;
            page1.Enabled = true;

            saveName_toUse.Text = "Unnamed";
        }

        //GOTO load
        private void goto_3_Click( object sender, EventArgs e )
        {
            RefreshList();
            page1.Visible = false;
            page1.Enabled = false;

            page3.Visible = true;
            page3.Enabled = true;
            page3.Left = 0;
        }

        //GOTO save
        private void goto_2_Click( object sender, EventArgs e )
        {
            RefreshList();

            page1.Visible = false;
            page1.Enabled = false;

            page2.Visible = true;
            page2.Enabled = true;
            page2.Left = 0;
        }

        private void tray_nula_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if (!bHide) return;
            Show();

            bHide = false;
        }

        private void RefreshList()
        {
            SavedProfiles_list.Items.Clear();
            loadProfile_list.Items.Clear();
            
            if(!Directory.Exists(env)) Directory.CreateDirectory(env);

            string[] files = Directory.GetFiles(env,"*.sav");

            foreach (string save in files)
            {
                Config temp = new Config(save);
                if (!temp.Load())
                {
                    temp.Dispose();
                    continue;
                }

                temp.Dispose();

                SavedProfiles_list.Items.Add(Path.GetFileNameWithoutExtension(save));
                loadProfile_list.Items.Add(Path.GetFileNameWithoutExtension(save));
            }
            
            load_profile.Enabled = (files.Length > 0);
            del_profile.Enabled = (files.Length > 0);
        }

        //Settings
        bool[] Locks = { false, false, false, false };

        private void IP_add_TextChanged( object sender, EventArgs e )
        {
            IPAddress temp;
            Locks[0] = IPAddress.TryParse(IP_add.Text, out temp) && (IP_add.Text.Count(f => f == '.') == 3);

            if (!Locks[0]) { IP_add.BackColor = Color.DarkCyan; IP_add.ForeColor = Color.White; }
            else { IP_add.BackColor = Color.Snow; IP_add.ForeColor = Color.Black; }

            Update_buttons();
        }

        private void IP_mask_TextChanged( object sender, EventArgs e )
        {
            IPAddress temp;
            Locks[1] = IPAddress.TryParse(IP_mask.Text, out temp) && (IP_mask.Text.Count(f => f == '.') == 3);

            if (!Locks[1]) { IP_mask.BackColor = Color.DarkCyan; IP_mask.ForeColor = Color.White; }
            else { IP_mask.BackColor = Color.Snow; IP_mask.ForeColor = Color.Black; }

            Update_buttons();
        }

        private void IP_gate_TextChanged( object sender, EventArgs e )
        {
            IPAddress temp = IPAddress.Any;
            Locks[2] = (IP_gate.Text == "")?true:IPAddress.TryParse(IP_gate.Text, out temp) && (IP_gate.Text.Count(f => f == '.') == 3);

            if (!Locks[2]) { IP_gate.BackColor = Color.DarkCyan; IP_gate.ForeColor = Color.White; }
            else { IP_gate.BackColor = Color.Snow; IP_gate.ForeColor = Color.Black; }

            Update_buttons();
        }

        private void Update_buttons()
        {
            bool bEna = Locks[0] && Locks[1] && Locks[2];

            use_settings.Enabled = bEna && Locks[3];
            net_dhcp.Enabled = Locks[3];
            goto_2.Enabled = bEna;
        }

        private void net_refresh_Click( object sender, EventArgs e )
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            net_list.Items.Clear();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet3Megabit ||
                    adapter.NetworkInterfaceType == NetworkInterfaceType.FastEthernetFx ||
                    adapter.NetworkInterfaceType == NetworkInterfaceType.FastEthernetT ||
                    adapter.NetworkInterfaceType == NetworkInterfaceType.GigabitEthernet ||
                    adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();

                    net_list.Items.Add(adapter.Name);
                }
            }

            if (net_list.Items.Count < 1)
            {
                Locks[3] = false;
                Update_buttons();
                return;
            }

            Locks[3] = true;
            net_list.SelectedIndex = 0;
            Update_buttons();
        }

        private void net_dhcp_clicked( object sender, EventArgs e )
        {
            string card = (string)net_list.Items[net_list.SelectedIndex];
            SetDHCP(card);
        }

        private void use_settings_Click( object sender, EventArgs e )
        {
            string card = (string)net_list.Items[net_list.SelectedIndex];
            SetStaticIP(IP_add.Text, IP_mask.Text, IP_gate.Text, card);
        }

        private void del_profile_Click( object sender, EventArgs e )
        {

            DialogResult dr = MessageBox.Show("Do you really want to delete this profile?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                string toDel = (string)loadProfile_list.Items[loadProfile_list.SelectedIndex];

                try {
                    File.Delete(env + "\\" + toDel + ".sav");
                } catch { }

                RefreshList();
            }

        }

        private void load_profile_Click( object sender, EventArgs e )
        {
            string toLoad = env + "\\" + (string)loadProfile_list.Items[loadProfile_list.SelectedIndex] + ".sav";
            Config load = new Config(toLoad, true);

            IP_add.Text = load.Get("IP");
            IP_mask.Text = load.Get("Mask");
            IP_gate.Text = load.Get("Gate");

            goto_1_l_Click(this, EventArgs.Empty);
        }

        private void save_profile_Click( object sender, EventArgs e )
        {
            string toSave = env + "\\" + saveName_toUse.Text + ".sav";

            if (File.Exists(toSave))
            {
                DialogResult dr = MessageBox.Show("Do you really want to overwrite this profile?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    Config load = new Config(toSave, true);

                    load.Set("IP", IP_add.Text);
                    load.Set("Mask", IP_mask.Text);
                    load.Set("Gate", IP_gate.Text);

                    load.Save();
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(toSave))
                {
                    sw.WriteLine("IP="+ IP_add.Text);
                    sw.WriteLine("Mask="+ IP_mask.Text);
                    sw.WriteLine("Gate="+ IP_gate.Text);
                }
            }

            RefreshList();

            saveName_toUse.Text = "Unnamed";

            goto_1_l_Click(this,EventArgs.Empty);
        }

        private void SavedProfiles_list_SelectedIndexChanged( object sender, EventArgs e )
        {
            if(SavedProfiles_list.Items.Count > 0 && SavedProfiles_list.SelectedIndex >= 0)
                saveName_toUse.Text = (string)SavedProfiles_list.Items[SavedProfiles_list.SelectedIndex];
        }

        private void saveName_toUse_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)0x08) return;
            foreach (char invalid in Path.GetInvalidFileNameChars())
            {
                if (e.KeyChar == invalid)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void saveName_toUse_TextChanged( object sender, EventArgs e )
        {
            save_profile.Enabled = (saveName_toUse.Text.Length > 0);
        }
    }
}
