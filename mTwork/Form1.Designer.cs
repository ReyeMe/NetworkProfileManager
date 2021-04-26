namespace mTwork {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.page1 = new System.Windows.Forms.Panel();
            this.net_list = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP_gate = new System.Windows.Forms.TextBox();
            this.IP_mask = new System.Windows.Forms.TextBox();
            this.IP_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.Panel();
            this.SavedProfiles_list = new System.Windows.Forms.ListBox();
            this.saveName_toUse = new System.Windows.Forms.TextBox();
            this.btn_toTray = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Panel();
            this.page3 = new System.Windows.Forms.Panel();
            this.loadProfile_list = new System.Windows.Forms.ListBox();
            this.tray_nula = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.del_profile = new mTwork.uc_Button();
            this.goto_1_l = new mTwork.uc_Button();
            this.load_profile = new mTwork.uc_Button();
            this.goto_1_s = new mTwork.uc_Button();
            this.save_profile = new mTwork.uc_Button();
            this.net_dhcp = new mTwork.uc_Button();
            this.net_refresh = new mTwork.uc_Button();
            this.goto_3 = new mTwork.uc_Button();
            this.goto_2 = new mTwork.uc_Button();
            this.use_settings = new mTwork.uc_Button();
            this.page1.SuspendLayout();
            this.page2.SuspendLayout();
            this.page3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // page1
            // 
            this.page1.BackColor = System.Drawing.Color.Transparent;
            this.page1.Controls.Add(this.net_dhcp);
            this.page1.Controls.Add(this.net_refresh);
            this.page1.Controls.Add(this.net_list);
            this.page1.Controls.Add(this.label4);
            this.page1.Controls.Add(this.label3);
            this.page1.Controls.Add(this.label2);
            this.page1.Controls.Add(this.IP_gate);
            this.page1.Controls.Add(this.IP_mask);
            this.page1.Controls.Add(this.IP_add);
            this.page1.Controls.Add(this.label1);
            this.page1.Controls.Add(this.goto_3);
            this.page1.Controls.Add(this.goto_2);
            this.page1.Controls.Add(this.use_settings);
            this.page1.Location = new System.Drawing.Point(0, 24);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(320, 226);
            this.page1.TabIndex = 0;
            // 
            // net_list
            // 
            this.net_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.net_list.FormattingEnabled = true;
            this.net_list.Location = new System.Drawing.Point(12, 127);
            this.net_list.Name = "net_list";
            this.net_list.Size = new System.Drawing.Size(296, 21);
            this.net_list.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Network connections:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Default gateway:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subnet mask:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IP_gate
            // 
            this.IP_gate.BackColor = System.Drawing.Color.DarkCyan;
            this.IP_gate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IP_gate.Location = new System.Drawing.Point(135, 64);
            this.IP_gate.Name = "IP_gate";
            this.IP_gate.Size = new System.Drawing.Size(173, 20);
            this.IP_gate.TabIndex = 6;
            this.IP_gate.TextChanged += new System.EventHandler(this.IP_gate_TextChanged);
            // 
            // IP_mask
            // 
            this.IP_mask.BackColor = System.Drawing.Color.DarkCyan;
            this.IP_mask.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IP_mask.Location = new System.Drawing.Point(135, 38);
            this.IP_mask.Name = "IP_mask";
            this.IP_mask.Size = new System.Drawing.Size(173, 20);
            this.IP_mask.TabIndex = 5;
            this.IP_mask.TextChanged += new System.EventHandler(this.IP_mask_TextChanged);
            // 
            // IP_add
            // 
            this.IP_add.BackColor = System.Drawing.Color.DarkCyan;
            this.IP_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IP_add.Location = new System.Drawing.Point(135, 12);
            this.IP_add.Name = "IP_add";
            this.IP_add.Size = new System.Drawing.Size(173, 20);
            this.IP_add.TabIndex = 4;
            this.IP_add.TextChanged += new System.EventHandler(this.IP_add_TextChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // page2
            // 
            this.page2.BackColor = System.Drawing.Color.Transparent;
            this.page2.Controls.Add(this.SavedProfiles_list);
            this.page2.Controls.Add(this.saveName_toUse);
            this.page2.Controls.Add(this.goto_1_s);
            this.page2.Controls.Add(this.save_profile);
            this.page2.Location = new System.Drawing.Point(320, 24);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(320, 226);
            this.page2.TabIndex = 1;
            this.page2.Visible = false;
            // 
            // SavedProfiles_list
            // 
            this.SavedProfiles_list.FormattingEnabled = true;
            this.SavedProfiles_list.IntegralHeight = false;
            this.SavedProfiles_list.Location = new System.Drawing.Point(12, 12);
            this.SavedProfiles_list.Name = "SavedProfiles_list";
            this.SavedProfiles_list.ScrollAlwaysVisible = true;
            this.SavedProfiles_list.Size = new System.Drawing.Size(296, 157);
            this.SavedProfiles_list.TabIndex = 6;
            this.SavedProfiles_list.SelectedIndexChanged += new System.EventHandler(this.SavedProfiles_list_SelectedIndexChanged);
            // 
            // saveName_toUse
            // 
            this.saveName_toUse.Location = new System.Drawing.Point(12, 169);
            this.saveName_toUse.MaxLength = 250;
            this.saveName_toUse.Name = "saveName_toUse";
            this.saveName_toUse.Size = new System.Drawing.Size(296, 20);
            this.saveName_toUse.TabIndex = 5;
            this.saveName_toUse.Text = "Unnamed";
            this.saveName_toUse.TextChanged += new System.EventHandler(this.saveName_toUse_TextChanged);
            this.saveName_toUse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saveName_toUse_KeyPress);
            // 
            // btn_toTray
            // 
            this.btn_toTray.BackColor = System.Drawing.Color.Transparent;
            this.btn_toTray.BackgroundImage = global::mTwork.Properties.Resources.btn_exit;
            this.btn_toTray.Location = new System.Drawing.Point(286, 5);
            this.btn_toTray.Name = "btn_toTray";
            this.btn_toTray.Size = new System.Drawing.Size(29, 17);
            this.btn_toTray.TabIndex = 2;
            this.btn_toTray.Click += new System.EventHandler(this.btn_toTray_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::mTwork.Properties.Resources.btn_off;
            this.btn_exit.Location = new System.Drawing.Point(256, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(29, 17);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // page3
            // 
            this.page3.BackColor = System.Drawing.Color.Transparent;
            this.page3.Controls.Add(this.del_profile);
            this.page3.Controls.Add(this.loadProfile_list);
            this.page3.Controls.Add(this.goto_1_l);
            this.page3.Controls.Add(this.load_profile);
            this.page3.Location = new System.Drawing.Point(640, 24);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(320, 226);
            this.page3.TabIndex = 4;
            this.page3.Visible = false;
            // 
            // loadProfile_list
            // 
            this.loadProfile_list.FormattingEnabled = true;
            this.loadProfile_list.IntegralHeight = false;
            this.loadProfile_list.Location = new System.Drawing.Point(12, 12);
            this.loadProfile_list.Name = "loadProfile_list";
            this.loadProfile_list.ScrollAlwaysVisible = true;
            this.loadProfile_list.Size = new System.Drawing.Size(296, 177);
            this.loadProfile_list.TabIndex = 7;
            // 
            // tray_nula
            // 
            this.tray_nula.Icon = ((System.Drawing.Icon)(resources.GetObject("tray_nula.Icon")));
            this.tray_nula.Text = "NULA";
            this.tray_nula.Visible = true;
            this.tray_nula.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_nula_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::mTwork.Properties.Resources.tray_network;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // del_profile
            // 
            this.del_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.del_profile.Location = new System.Drawing.Point(136, 195);
            this.del_profile.Name = "del_profile";
            this.del_profile.Size = new System.Drawing.Size(41, 19);
            this.del_profile.TabIndex = 8;
            this.del_profile.Text = "DEL";
            this.del_profile.Click += new System.EventHandler(this.del_profile_Click);
            // 
            // goto_1_l
            // 
            this.goto_1_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goto_1_l.Location = new System.Drawing.Point(12, 195);
            this.goto_1_l.Name = "goto_1_l";
            this.goto_1_l.Size = new System.Drawing.Size(77, 19);
            this.goto_1_l.TabIndex = 6;
            this.goto_1_l.Text = "Cancel";
            this.goto_1_l.Click += new System.EventHandler(this.goto_1_l_Click);
            // 
            // load_profile
            // 
            this.load_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.load_profile.Location = new System.Drawing.Point(183, 195);
            this.load_profile.Name = "load_profile";
            this.load_profile.Size = new System.Drawing.Size(125, 19);
            this.load_profile.TabIndex = 5;
            this.load_profile.Text = "Load";
            this.load_profile.Click += new System.EventHandler(this.load_profile_Click);
            // 
            // goto_1_s
            // 
            this.goto_1_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goto_1_s.Location = new System.Drawing.Point(12, 195);
            this.goto_1_s.Name = "goto_1_s";
            this.goto_1_s.Size = new System.Drawing.Size(77, 19);
            this.goto_1_s.TabIndex = 4;
            this.goto_1_s.Text = "Cancel";
            this.goto_1_s.Click += new System.EventHandler(this.goto_1_l_Click);
            // 
            // save_profile
            // 
            this.save_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.save_profile.Location = new System.Drawing.Point(183, 195);
            this.save_profile.Name = "save_profile";
            this.save_profile.Size = new System.Drawing.Size(125, 19);
            this.save_profile.TabIndex = 3;
            this.save_profile.Text = "Save";
            this.save_profile.Click += new System.EventHandler(this.save_profile_Click);
            // 
            // net_dhcp
            // 
            this.net_dhcp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.net_dhcp.Location = new System.Drawing.Point(12, 169);
            this.net_dhcp.Name = "net_dhcp";
            this.net_dhcp.Size = new System.Drawing.Size(125, 19);
            this.net_dhcp.TabIndex = 12;
            this.net_dhcp.Text = "Use DHCP";
            this.net_dhcp.Click += new System.EventHandler(this.net_dhcp_clicked);
            // 
            // net_refresh
            // 
            this.net_refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.net_refresh.Location = new System.Drawing.Point(183, 105);
            this.net_refresh.Name = "net_refresh";
            this.net_refresh.Size = new System.Drawing.Size(125, 19);
            this.net_refresh.TabIndex = 11;
            this.net_refresh.Text = "Refresh list";
            this.net_refresh.Click += new System.EventHandler(this.net_refresh_Click);
            // 
            // goto_3
            // 
            this.goto_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goto_3.Location = new System.Drawing.Point(183, 170);
            this.goto_3.Name = "goto_3";
            this.goto_3.Size = new System.Drawing.Size(125, 19);
            this.goto_3.TabIndex = 2;
            this.goto_3.Text = "Load";
            this.goto_3.Click += new System.EventHandler(this.goto_3_Click);
            // 
            // goto_2
            // 
            this.goto_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goto_2.Location = new System.Drawing.Point(183, 195);
            this.goto_2.Name = "goto_2";
            this.goto_2.Size = new System.Drawing.Size(125, 19);
            this.goto_2.TabIndex = 1;
            this.goto_2.Text = "Save";
            this.goto_2.Click += new System.EventHandler(this.goto_2_Click);
            // 
            // use_settings
            // 
            this.use_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.use_settings.Location = new System.Drawing.Point(12, 195);
            this.use_settings.Name = "use_settings";
            this.use_settings.Size = new System.Drawing.Size(125, 19);
            this.use_settings.TabIndex = 0;
            this.use_settings.Text = "Use User settings";
            this.use_settings.Click += new System.EventHandler(this.use_settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mTwork.Properties.Resources.window;
            this.ClientSize = new System.Drawing.Size(960, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.page3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_toTray);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.page1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.page3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Panel btn_toTray;
        private System.Windows.Forms.Panel btn_exit;
        private System.Windows.Forms.Panel page3;
        private uc_Button use_settings;
        private uc_Button goto_3;
        private uc_Button goto_2;
        private uc_Button goto_1_s;
        private uc_Button save_profile;
        private uc_Button goto_1_l;
        private uc_Button load_profile;
        private System.Windows.Forms.TextBox saveName_toUse;
        private System.Windows.Forms.ListBox SavedProfiles_list;
        private System.Windows.Forms.ListBox loadProfile_list;
        private System.Windows.Forms.NotifyIcon tray_nula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_add;
        private System.Windows.Forms.TextBox IP_mask;
        private System.Windows.Forms.TextBox IP_gate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox net_list;
        private System.Windows.Forms.Label label4;
        private uc_Button net_refresh;
        private uc_Button net_dhcp;
        private uc_Button del_profile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

