namespace MwRepo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainGroupBox = new TabControl();
            ServersTab = new TabPage();
            AddServerButton = new Button();
            button21 = new Button();
            RemoveServerButton = new Button();
            ResetServersFilterButton = new Button();
            ServersFilterButton = new Button();
            ServersHypervisorFilterCombo = new ComboBox();
            label13 = new Label();
            ServersOsVersionFilterCombo = new ComboBox();
            label11 = new Label();
            ServersHardwareFilterCombo = new ComboBox();
            label10 = new Label();
            ServersOsFilterCombo = new ComboBox();
            label9 = new Label();
            ServersBackendFilterCombo = new ComboBox();
            label8 = new Label();
            ServersSystemFilterCombo = new ComboBox();
            label7 = new Label();
            ServersHostnameFilterField = new TextBox();
            label6 = new Label();
            ServersIpFilterField = new TextBox();
            label5 = new Label();
            ServersDataGrid = new DataGridView();
            ServicesTab = new TabPage();
            button8 = new Button();
            button7 = new Button();
            button2 = new Button();
            ResetServicesFilterButton = new Button();
            ServicesTlsEnabledComboBox = new ComboBox();
            label18 = new Label();
            ServicesProtocolFilterField = new TextBox();
            label17 = new Label();
            ServicesPortTypeComboBox = new ComboBox();
            label16 = new Label();
            ServicesPortFilterField = new TextBox();
            label15 = new Label();
            ServicesNameFilterField = new TextBox();
            label14 = new Label();
            ServicesFilterButton = new Button();
            ServicesIpFilterField = new TextBox();
            label25 = new Label();
            ServicesDataGrid = new DataGridView();
            SystemsTab = new TabPage();
            EditSystemsButton = new Button();
            RemoveSystemButton = new Button();
            AddSystemButton = new Button();
            SystemsDataGrid = new DataGridView();
            BackendsTab = new TabPage();
            RemoveBackendButton = new Button();
            EditBackendButton = new Button();
            AddBackendSystem = new Button();
            BackendsDataGrid = new DataGridView();
            OsTab = new TabPage();
            button4 = new Button();
            button9 = new Button();
            button10 = new Button();
            OperatingSystemsDataGrid = new DataGridView();
            VendorsTab = new TabPage();
            button5 = new Button();
            button11 = new Button();
            button12 = new Button();
            VendorsDataGrid = new DataGridView();
            OsVersionsTab = new TabPage();
            button6 = new Button();
            button13 = new Button();
            button14 = new Button();
            OsVersionsDataGrid = new DataGridView();
            LifecyclesTab = new TabPage();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            LifecyclesDataGrid = new DataGridView();
            HardwareModelsTab = new TabPage();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            HardwareModelsDataGrid = new DataGridView();
            label1 = new Label();
            DatabaseIpField = new TextBox();
            DatabasePortField = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DatabaseUsernameField = new TextBox();
            label4 = new Label();
            DatabaseConnectButton = new Button();
            DatabasePasswordField = new MaskedTextBox();
            ServerLifecycleFilterComboBox = new ComboBox();
            label12 = new Label();
            MainGroupBox.SuspendLayout();
            ServersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServersDataGrid).BeginInit();
            ServicesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesDataGrid).BeginInit();
            SystemsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SystemsDataGrid).BeginInit();
            BackendsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackendsDataGrid).BeginInit();
            OsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OperatingSystemsDataGrid).BeginInit();
            VendorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VendorsDataGrid).BeginInit();
            OsVersionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OsVersionsDataGrid).BeginInit();
            LifecyclesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LifecyclesDataGrid).BeginInit();
            HardwareModelsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HardwareModelsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // MainGroupBox
            // 
            MainGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainGroupBox.Controls.Add(ServersTab);
            MainGroupBox.Controls.Add(ServicesTab);
            MainGroupBox.Controls.Add(SystemsTab);
            MainGroupBox.Controls.Add(BackendsTab);
            MainGroupBox.Controls.Add(OsTab);
            MainGroupBox.Controls.Add(VendorsTab);
            MainGroupBox.Controls.Add(OsVersionsTab);
            MainGroupBox.Controls.Add(LifecyclesTab);
            MainGroupBox.Controls.Add(HardwareModelsTab);
            MainGroupBox.Location = new Point(12, 41);
            MainGroupBox.Name = "MainGroupBox";
            MainGroupBox.SelectedIndex = 0;
            MainGroupBox.Size = new Size(1161, 765);
            MainGroupBox.TabIndex = 0;
            // 
            // ServersTab
            // 
            ServersTab.Controls.Add(ServerLifecycleFilterComboBox);
            ServersTab.Controls.Add(label12);
            ServersTab.Controls.Add(AddServerButton);
            ServersTab.Controls.Add(button21);
            ServersTab.Controls.Add(RemoveServerButton);
            ServersTab.Controls.Add(ResetServersFilterButton);
            ServersTab.Controls.Add(ServersFilterButton);
            ServersTab.Controls.Add(ServersHypervisorFilterCombo);
            ServersTab.Controls.Add(label13);
            ServersTab.Controls.Add(ServersOsVersionFilterCombo);
            ServersTab.Controls.Add(label11);
            ServersTab.Controls.Add(ServersHardwareFilterCombo);
            ServersTab.Controls.Add(label10);
            ServersTab.Controls.Add(ServersOsFilterCombo);
            ServersTab.Controls.Add(label9);
            ServersTab.Controls.Add(ServersBackendFilterCombo);
            ServersTab.Controls.Add(label8);
            ServersTab.Controls.Add(ServersSystemFilterCombo);
            ServersTab.Controls.Add(label7);
            ServersTab.Controls.Add(ServersHostnameFilterField);
            ServersTab.Controls.Add(label6);
            ServersTab.Controls.Add(ServersIpFilterField);
            ServersTab.Controls.Add(label5);
            ServersTab.Controls.Add(ServersDataGrid);
            ServersTab.Location = new Point(4, 24);
            ServersTab.Name = "ServersTab";
            ServersTab.Padding = new Padding(3);
            ServersTab.Size = new Size(1153, 737);
            ServersTab.TabIndex = 0;
            ServersTab.Text = "Servers";
            ServersTab.UseVisualStyleBackColor = true;
            // 
            // AddServerButton
            // 
            AddServerButton.BackColor = Color.White;
            AddServerButton.ForeColor = SystemColors.ActiveCaptionText;
            AddServerButton.Location = new Point(3, 506);
            AddServerButton.Name = "AddServerButton";
            AddServerButton.Size = new Size(212, 24);
            AddServerButton.TabIndex = 23;
            AddServerButton.Text = "Add";
            AddServerButton.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.Gray;
            button21.ForeColor = SystemColors.ButtonHighlight;
            button21.Location = new Point(3, 536);
            button21.Name = "button21";
            button21.Size = new Size(212, 24);
            button21.TabIndex = 22;
            button21.Text = "Edit";
            button21.UseVisualStyleBackColor = false;
            // 
            // RemoveServerButton
            // 
            RemoveServerButton.BackColor = Color.IndianRed;
            RemoveServerButton.ForeColor = SystemColors.ButtonHighlight;
            RemoveServerButton.Location = new Point(3, 566);
            RemoveServerButton.Name = "RemoveServerButton";
            RemoveServerButton.Size = new Size(212, 24);
            RemoveServerButton.TabIndex = 21;
            RemoveServerButton.Text = "Remove";
            RemoveServerButton.UseVisualStyleBackColor = false;
            // 
            // ResetServersFilterButton
            // 
            ResetServersFilterButton.Location = new Point(3, 452);
            ResetServersFilterButton.Name = "ResetServersFilterButton";
            ResetServersFilterButton.Size = new Size(212, 24);
            ResetServersFilterButton.TabIndex = 20;
            ResetServersFilterButton.Text = "Reset";
            ResetServersFilterButton.UseVisualStyleBackColor = true;
            ResetServersFilterButton.Click += ResetServersFilterButton_Click;
            // 
            // ServersFilterButton
            // 
            ServersFilterButton.Location = new Point(3, 403);
            ServersFilterButton.Name = "ServersFilterButton";
            ServersFilterButton.Size = new Size(212, 43);
            ServersFilterButton.TabIndex = 19;
            ServersFilterButton.Text = "Filter";
            ServersFilterButton.UseVisualStyleBackColor = true;
            ServersFilterButton.Click += ServersFilterButton_Click;
            // 
            // ServersHypervisorFilterCombo
            // 
            ServersHypervisorFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ServersHypervisorFilterCombo.FormattingEnabled = true;
            ServersHypervisorFilterCombo.Location = new Point(6, 374);
            ServersHypervisorFilterCombo.Name = "ServersHypervisorFilterCombo";
            ServersHypervisorFilterCombo.Size = new Size(212, 23);
            ServersHypervisorFilterCombo.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 356);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 17;
            label13.Text = "Hypervisor";
            // 
            // ServersOsVersionFilterCombo
            // 
            ServersOsVersionFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ServersOsVersionFilterCombo.FormattingEnabled = true;
            ServersOsVersionFilterCombo.Location = new Point(6, 330);
            ServersOsVersionFilterCombo.Name = "ServersOsVersionFilterCombo";
            ServersOsVersionFilterCombo.Size = new Size(212, 23);
            ServersOsVersionFilterCombo.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 312);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 13;
            label11.Text = "OS Version";
            // 
            // ServersHardwareFilterCombo
            // 
            ServersHardwareFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ServersHardwareFilterCombo.FormattingEnabled = true;
            ServersHardwareFilterCombo.Location = new Point(6, 286);
            ServersHardwareFilterCombo.Name = "ServersHardwareFilterCombo";
            ServersHardwareFilterCombo.Size = new Size(212, 23);
            ServersHardwareFilterCombo.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 268);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 11;
            label10.Text = "Hardware";
            // 
            // ServersOsFilterCombo
            // 
            ServersOsFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ServersOsFilterCombo.FormattingEnabled = true;
            ServersOsFilterCombo.Location = new Point(6, 242);
            ServersOsFilterCombo.Name = "ServersOsFilterCombo";
            ServersOsFilterCombo.Size = new Size(212, 23);
            ServersOsFilterCombo.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 224);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 9;
            label9.Text = "Operating System";
            // 
            // ServersBackendFilterCombo
            // 
            ServersBackendFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ServersBackendFilterCombo.FormattingEnabled = true;
            ServersBackendFilterCombo.Location = new Point(6, 198);
            ServersBackendFilterCombo.Name = "ServersBackendFilterCombo";
            ServersBackendFilterCombo.Size = new Size(212, 23);
            ServersBackendFilterCombo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 180);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 7;
            label8.Text = "Backend";
            // 
            // ServersSystemFilterCombo
            // 
            ServersSystemFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ServersSystemFilterCombo.FormattingEnabled = true;
            ServersSystemFilterCombo.Location = new Point(6, 110);
            ServersSystemFilterCombo.Name = "ServersSystemFilterCombo";
            ServersSystemFilterCombo.Size = new Size(212, 23);
            ServersSystemFilterCombo.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 92);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 5;
            label7.Text = "System";
            // 
            // ServersHostnameFilterField
            // 
            ServersHostnameFilterField.Location = new Point(6, 66);
            ServersHostnameFilterField.Name = "ServersHostnameFilterField";
            ServersHostnameFilterField.Size = new Size(212, 23);
            ServersHostnameFilterField.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 48);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 3;
            label6.Text = "Hostname";
            // 
            // ServersIpFilterField
            // 
            ServersIpFilterField.Location = new Point(6, 22);
            ServersIpFilterField.Name = "ServersIpFilterField";
            ServersIpFilterField.Size = new Size(212, 23);
            ServersIpFilterField.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 4);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 1;
            label5.Text = "IP Address";
            // 
            // ServersDataGrid
            // 
            ServersDataGrid.AllowUserToAddRows = false;
            ServersDataGrid.AllowUserToDeleteRows = false;
            ServersDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ServersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServersDataGrid.Location = new Point(224, 4);
            ServersDataGrid.Name = "ServersDataGrid";
            ServersDataGrid.ReadOnly = true;
            ServersDataGrid.Size = new Size(924, 727);
            ServersDataGrid.TabIndex = 0;
            // 
            // ServicesTab
            // 
            ServicesTab.Controls.Add(button8);
            ServicesTab.Controls.Add(button7);
            ServicesTab.Controls.Add(button2);
            ServicesTab.Controls.Add(ResetServicesFilterButton);
            ServicesTab.Controls.Add(ServicesTlsEnabledComboBox);
            ServicesTab.Controls.Add(label18);
            ServicesTab.Controls.Add(ServicesProtocolFilterField);
            ServicesTab.Controls.Add(label17);
            ServicesTab.Controls.Add(ServicesPortTypeComboBox);
            ServicesTab.Controls.Add(label16);
            ServicesTab.Controls.Add(ServicesPortFilterField);
            ServicesTab.Controls.Add(label15);
            ServicesTab.Controls.Add(ServicesNameFilterField);
            ServicesTab.Controls.Add(label14);
            ServicesTab.Controls.Add(ServicesFilterButton);
            ServicesTab.Controls.Add(ServicesIpFilterField);
            ServicesTab.Controls.Add(label25);
            ServicesTab.Controls.Add(ServicesDataGrid);
            ServicesTab.Location = new Point(4, 24);
            ServicesTab.Name = "ServicesTab";
            ServicesTab.Size = new Size(1153, 737);
            ServicesTab.TabIndex = 6;
            ServicesTab.Text = "Services";
            ServicesTab.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackColor = Color.IndianRed;
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(7, 454);
            button8.Name = "button8";
            button8.Size = new Size(212, 26);
            button8.TabIndex = 60;
            button8.Text = "Remove";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(7, 422);
            button7.Name = "button7";
            button7.Size = new Size(212, 26);
            button7.TabIndex = 59;
            button7.Text = "Edit";
            button7.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(7, 390);
            button2.Name = "button2";
            button2.Size = new Size(212, 26);
            button2.TabIndex = 58;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // ResetServicesFilterButton
            // 
            ResetServicesFilterButton.Location = new Point(7, 326);
            ResetServicesFilterButton.Name = "ResetServicesFilterButton";
            ResetServicesFilterButton.Size = new Size(212, 26);
            ResetServicesFilterButton.TabIndex = 57;
            ResetServicesFilterButton.Text = "Reset";
            ResetServicesFilterButton.UseVisualStyleBackColor = true;
            ResetServicesFilterButton.Click += ResetServicesFilterButton_Click;
            // 
            // ServicesTlsEnabledComboBox
            // 
            ServicesTlsEnabledComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ServicesTlsEnabledComboBox.FormattingEnabled = true;
            ServicesTlsEnabledComboBox.Location = new Point(7, 248);
            ServicesTlsEnabledComboBox.Name = "ServicesTlsEnabledComboBox";
            ServicesTlsEnabledComboBox.Size = new Size(212, 23);
            ServicesTlsEnabledComboBox.TabIndex = 56;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 230);
            label18.Name = "label18";
            label18.Size = new Size(70, 15);
            label18.TabIndex = 55;
            label18.Text = "TLS Enabled";
            // 
            // ServicesProtocolFilterField
            // 
            ServicesProtocolFilterField.Location = new Point(7, 113);
            ServicesProtocolFilterField.Name = "ServicesProtocolFilterField";
            ServicesProtocolFilterField.Size = new Size(212, 23);
            ServicesProtocolFilterField.TabIndex = 54;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 95);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 53;
            label17.Text = "Protocol";
            // 
            // ServicesPortTypeComboBox
            // 
            ServicesPortTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ServicesPortTypeComboBox.FormattingEnabled = true;
            ServicesPortTypeComboBox.Location = new Point(7, 204);
            ServicesPortTypeComboBox.Name = "ServicesPortTypeComboBox";
            ServicesPortTypeComboBox.Size = new Size(212, 23);
            ServicesPortTypeComboBox.TabIndex = 52;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 186);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 51;
            label16.Text = "Port Type";
            // 
            // ServicesPortFilterField
            // 
            ServicesPortFilterField.Location = new Point(7, 158);
            ServicesPortFilterField.Name = "ServicesPortFilterField";
            ServicesPortFilterField.Size = new Size(212, 23);
            ServicesPortFilterField.TabIndex = 50;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 186);
            label15.Name = "label15";
            label15.Size = new Size(29, 15);
            label15.TabIndex = 49;
            label15.Text = "Port";
            // 
            // ServicesNameFilterField
            // 
            ServicesNameFilterField.Location = new Point(7, 66);
            ServicesNameFilterField.Name = "ServicesNameFilterField";
            ServicesNameFilterField.Size = new Size(212, 23);
            ServicesNameFilterField.TabIndex = 48;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 48);
            label14.Name = "label14";
            label14.Size = new Size(79, 15);
            label14.TabIndex = 47;
            label14.Text = "Service Name";
            // 
            // ServicesFilterButton
            // 
            ServicesFilterButton.Location = new Point(7, 277);
            ServicesFilterButton.Name = "ServicesFilterButton";
            ServicesFilterButton.Size = new Size(212, 43);
            ServicesFilterButton.TabIndex = 46;
            ServicesFilterButton.Text = "Filter";
            ServicesFilterButton.UseVisualStyleBackColor = true;
            ServicesFilterButton.Click += ServicesFilterButton_Click;
            // 
            // ServicesIpFilterField
            // 
            ServicesIpFilterField.Location = new Point(7, 23);
            ServicesIpFilterField.Name = "ServicesIpFilterField";
            ServicesIpFilterField.Size = new Size(212, 23);
            ServicesIpFilterField.TabIndex = 39;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(7, 5);
            label25.Name = "label25";
            label25.Size = new Size(62, 15);
            label25.TabIndex = 38;
            label25.Text = "IP Address";
            // 
            // ServicesDataGrid
            // 
            ServicesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ServicesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServicesDataGrid.Location = new Point(225, 5);
            ServicesDataGrid.Name = "ServicesDataGrid";
            ServicesDataGrid.ReadOnly = true;
            ServicesDataGrid.Size = new Size(924, 727);
            ServicesDataGrid.TabIndex = 37;
            // 
            // SystemsTab
            // 
            SystemsTab.Controls.Add(EditSystemsButton);
            SystemsTab.Controls.Add(RemoveSystemButton);
            SystemsTab.Controls.Add(AddSystemButton);
            SystemsTab.Controls.Add(SystemsDataGrid);
            SystemsTab.Location = new Point(4, 24);
            SystemsTab.Name = "SystemsTab";
            SystemsTab.Padding = new Padding(3);
            SystemsTab.Size = new Size(1153, 737);
            SystemsTab.TabIndex = 1;
            SystemsTab.Text = "Systems";
            SystemsTab.UseVisualStyleBackColor = true;
            // 
            // EditSystemsButton
            // 
            EditSystemsButton.BackColor = Color.Gray;
            EditSystemsButton.ForeColor = SystemColors.ButtonFace;
            EditSystemsButton.Location = new Point(3, 55);
            EditSystemsButton.Name = "EditSystemsButton";
            EditSystemsButton.Size = new Size(74, 43);
            EditSystemsButton.TabIndex = 38;
            EditSystemsButton.Text = "Edit";
            EditSystemsButton.UseVisualStyleBackColor = false;
            // 
            // RemoveSystemButton
            // 
            RemoveSystemButton.BackColor = Color.IndianRed;
            RemoveSystemButton.ForeColor = SystemColors.ButtonFace;
            RemoveSystemButton.Location = new Point(3, 104);
            RemoveSystemButton.Name = "RemoveSystemButton";
            RemoveSystemButton.Size = new Size(74, 43);
            RemoveSystemButton.TabIndex = 37;
            RemoveSystemButton.Text = "Remove";
            RemoveSystemButton.UseVisualStyleBackColor = false;
            // 
            // AddSystemButton
            // 
            AddSystemButton.Location = new Point(3, 6);
            AddSystemButton.Name = "AddSystemButton";
            AddSystemButton.Size = new Size(74, 43);
            AddSystemButton.TabIndex = 36;
            AddSystemButton.Text = "Add";
            AddSystemButton.UseVisualStyleBackColor = true;
            // 
            // SystemsDataGrid
            // 
            SystemsDataGrid.AllowUserToAddRows = false;
            SystemsDataGrid.AllowUserToDeleteRows = false;
            SystemsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SystemsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SystemsDataGrid.Location = new Point(83, 5);
            SystemsDataGrid.Name = "SystemsDataGrid";
            SystemsDataGrid.ReadOnly = true;
            SystemsDataGrid.Size = new Size(1066, 727);
            SystemsDataGrid.TabIndex = 20;
            // 
            // BackendsTab
            // 
            BackendsTab.Controls.Add(RemoveBackendButton);
            BackendsTab.Controls.Add(EditBackendButton);
            BackendsTab.Controls.Add(AddBackendSystem);
            BackendsTab.Controls.Add(BackendsDataGrid);
            BackendsTab.Location = new Point(4, 24);
            BackendsTab.Name = "BackendsTab";
            BackendsTab.Size = new Size(1153, 737);
            BackendsTab.TabIndex = 2;
            BackendsTab.Text = "Backends";
            BackendsTab.UseVisualStyleBackColor = true;
            // 
            // RemoveBackendButton
            // 
            RemoveBackendButton.BackColor = Color.IndianRed;
            RemoveBackendButton.ForeColor = SystemColors.ButtonFace;
            RemoveBackendButton.Location = new Point(3, 103);
            RemoveBackendButton.Name = "RemoveBackendButton";
            RemoveBackendButton.Size = new Size(74, 43);
            RemoveBackendButton.TabIndex = 48;
            RemoveBackendButton.Text = "Remove";
            RemoveBackendButton.UseVisualStyleBackColor = false;
            // 
            // EditBackendButton
            // 
            EditBackendButton.BackColor = Color.Gray;
            EditBackendButton.ForeColor = SystemColors.ButtonFace;
            EditBackendButton.Location = new Point(3, 54);
            EditBackendButton.Name = "EditBackendButton";
            EditBackendButton.Size = new Size(74, 43);
            EditBackendButton.TabIndex = 47;
            EditBackendButton.Text = "Edit";
            EditBackendButton.UseVisualStyleBackColor = false;
            // 
            // AddBackendSystem
            // 
            AddBackendSystem.Location = new Point(3, 5);
            AddBackendSystem.Name = "AddBackendSystem";
            AddBackendSystem.Size = new Size(74, 43);
            AddBackendSystem.TabIndex = 46;
            AddBackendSystem.Text = "Add";
            AddBackendSystem.UseVisualStyleBackColor = true;
            // 
            // BackendsDataGrid
            // 
            BackendsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackendsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BackendsDataGrid.Location = new Point(83, 5);
            BackendsDataGrid.Name = "BackendsDataGrid";
            BackendsDataGrid.ReadOnly = true;
            BackendsDataGrid.Size = new Size(1066, 727);
            BackendsDataGrid.TabIndex = 37;
            // 
            // OsTab
            // 
            OsTab.Controls.Add(button4);
            OsTab.Controls.Add(button9);
            OsTab.Controls.Add(button10);
            OsTab.Controls.Add(OperatingSystemsDataGrid);
            OsTab.Location = new Point(4, 24);
            OsTab.Name = "OsTab";
            OsTab.Size = new Size(1153, 737);
            OsTab.TabIndex = 3;
            OsTab.Text = "Operating Systems";
            OsTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(3, 54);
            button4.Name = "button4";
            button4.Size = new Size(74, 43);
            button4.TabIndex = 41;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.IndianRed;
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(3, 103);
            button9.Name = "button9";
            button9.Size = new Size(74, 43);
            button9.TabIndex = 40;
            button9.Text = "Remove";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.Location = new Point(3, 5);
            button10.Name = "button10";
            button10.Size = new Size(74, 43);
            button10.TabIndex = 39;
            button10.Text = "Add";
            button10.UseVisualStyleBackColor = true;
            // 
            // OperatingSystemsDataGrid
            // 
            OperatingSystemsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OperatingSystemsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OperatingSystemsDataGrid.Location = new Point(83, 5);
            OperatingSystemsDataGrid.Name = "OperatingSystemsDataGrid";
            OperatingSystemsDataGrid.ReadOnly = true;
            OperatingSystemsDataGrid.Size = new Size(1066, 727);
            OperatingSystemsDataGrid.TabIndex = 37;
            // 
            // VendorsTab
            // 
            VendorsTab.Controls.Add(button5);
            VendorsTab.Controls.Add(button11);
            VendorsTab.Controls.Add(button12);
            VendorsTab.Controls.Add(VendorsDataGrid);
            VendorsTab.Location = new Point(4, 24);
            VendorsTab.Name = "VendorsTab";
            VendorsTab.Size = new Size(1153, 737);
            VendorsTab.TabIndex = 5;
            VendorsTab.Text = "Vendors";
            VendorsTab.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(3, 54);
            button5.Name = "button5";
            button5.Size = new Size(74, 43);
            button5.TabIndex = 41;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.IndianRed;
            button11.ForeColor = SystemColors.ButtonFace;
            button11.Location = new Point(3, 103);
            button11.Name = "button11";
            button11.Size = new Size(74, 43);
            button11.TabIndex = 40;
            button11.Text = "Remove";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.Location = new Point(3, 5);
            button12.Name = "button12";
            button12.Size = new Size(74, 43);
            button12.TabIndex = 39;
            button12.Text = "Add";
            button12.UseVisualStyleBackColor = true;
            // 
            // VendorsDataGrid
            // 
            VendorsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VendorsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VendorsDataGrid.Location = new Point(83, 5);
            VendorsDataGrid.Name = "VendorsDataGrid";
            VendorsDataGrid.ReadOnly = true;
            VendorsDataGrid.Size = new Size(1066, 727);
            VendorsDataGrid.TabIndex = 37;
            // 
            // OsVersionsTab
            // 
            OsVersionsTab.Controls.Add(button6);
            OsVersionsTab.Controls.Add(button13);
            OsVersionsTab.Controls.Add(button14);
            OsVersionsTab.Controls.Add(OsVersionsDataGrid);
            OsVersionsTab.Location = new Point(4, 24);
            OsVersionsTab.Name = "OsVersionsTab";
            OsVersionsTab.Size = new Size(1153, 737);
            OsVersionsTab.TabIndex = 4;
            OsVersionsTab.Text = "OS Versions";
            OsVersionsTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(3, 54);
            button6.Name = "button6";
            button6.Size = new Size(74, 43);
            button6.TabIndex = 41;
            button6.Text = "Edit";
            button6.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.IndianRed;
            button13.ForeColor = SystemColors.ButtonFace;
            button13.Location = new Point(3, 103);
            button13.Name = "button13";
            button13.Size = new Size(74, 43);
            button13.TabIndex = 40;
            button13.Text = "Remove";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.Location = new Point(3, 5);
            button14.Name = "button14";
            button14.Size = new Size(74, 43);
            button14.TabIndex = 39;
            button14.Text = "Add";
            button14.UseVisualStyleBackColor = true;
            // 
            // OsVersionsDataGrid
            // 
            OsVersionsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OsVersionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OsVersionsDataGrid.Location = new Point(83, 5);
            OsVersionsDataGrid.Name = "OsVersionsDataGrid";
            OsVersionsDataGrid.ReadOnly = true;
            OsVersionsDataGrid.Size = new Size(1066, 727);
            OsVersionsDataGrid.TabIndex = 37;
            // 
            // LifecyclesTab
            // 
            LifecyclesTab.Controls.Add(button15);
            LifecyclesTab.Controls.Add(button16);
            LifecyclesTab.Controls.Add(button17);
            LifecyclesTab.Controls.Add(LifecyclesDataGrid);
            LifecyclesTab.Location = new Point(4, 24);
            LifecyclesTab.Name = "LifecyclesTab";
            LifecyclesTab.Size = new Size(1153, 737);
            LifecyclesTab.TabIndex = 7;
            LifecyclesTab.Text = "Lifecycles";
            LifecyclesTab.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.BackColor = Color.Gray;
            button15.ForeColor = SystemColors.ButtonFace;
            button15.Location = new Point(3, 54);
            button15.Name = "button15";
            button15.Size = new Size(74, 43);
            button15.TabIndex = 41;
            button15.Text = "Edit";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.IndianRed;
            button16.ForeColor = SystemColors.ButtonFace;
            button16.Location = new Point(3, 103);
            button16.Name = "button16";
            button16.Size = new Size(74, 43);
            button16.TabIndex = 40;
            button16.Text = "Remove";
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.Location = new Point(3, 5);
            button17.Name = "button17";
            button17.Size = new Size(74, 43);
            button17.TabIndex = 39;
            button17.Text = "Add";
            button17.UseVisualStyleBackColor = true;
            // 
            // LifecyclesDataGrid
            // 
            LifecyclesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LifecyclesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LifecyclesDataGrid.Location = new Point(83, 5);
            LifecyclesDataGrid.Name = "LifecyclesDataGrid";
            LifecyclesDataGrid.ReadOnly = true;
            LifecyclesDataGrid.Size = new Size(1065, 727);
            LifecyclesDataGrid.TabIndex = 38;
            // 
            // HardwareModelsTab
            // 
            HardwareModelsTab.Controls.Add(button18);
            HardwareModelsTab.Controls.Add(button19);
            HardwareModelsTab.Controls.Add(button20);
            HardwareModelsTab.Controls.Add(HardwareModelsDataGrid);
            HardwareModelsTab.Location = new Point(4, 24);
            HardwareModelsTab.Name = "HardwareModelsTab";
            HardwareModelsTab.Size = new Size(1153, 737);
            HardwareModelsTab.TabIndex = 8;
            HardwareModelsTab.Text = "Hardware Models";
            HardwareModelsTab.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.BackColor = Color.Gray;
            button18.ForeColor = SystemColors.ButtonFace;
            button18.Location = new Point(3, 54);
            button18.Name = "button18";
            button18.Size = new Size(74, 43);
            button18.TabIndex = 45;
            button18.Text = "Edit";
            button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.IndianRed;
            button19.ForeColor = SystemColors.ButtonFace;
            button19.Location = new Point(3, 103);
            button19.Name = "button19";
            button19.Size = new Size(74, 43);
            button19.TabIndex = 44;
            button19.Text = "Remove";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.Location = new Point(3, 5);
            button20.Name = "button20";
            button20.Size = new Size(74, 43);
            button20.TabIndex = 43;
            button20.Text = "Add";
            button20.UseVisualStyleBackColor = true;
            // 
            // HardwareModelsDataGrid
            // 
            HardwareModelsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HardwareModelsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HardwareModelsDataGrid.Location = new Point(83, 5);
            HardwareModelsDataGrid.Name = "HardwareModelsDataGrid";
            HardwareModelsDataGrid.ReadOnly = true;
            HardwareModelsDataGrid.Size = new Size(1066, 727);
            HardwareModelsDataGrid.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Database IP";
            // 
            // DatabaseIpField
            // 
            DatabaseIpField.Location = new Point(86, 6);
            DatabaseIpField.Name = "DatabaseIpField";
            DatabaseIpField.Size = new Size(174, 23);
            DatabaseIpField.TabIndex = 1;
            // 
            // DatabasePortField
            // 
            DatabasePortField.Location = new Point(298, 6);
            DatabasePortField.Name = "DatabasePortField";
            DatabasePortField.Size = new Size(72, 23);
            DatabasePortField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(633, 10);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // DatabaseUsernameField
            // 
            DatabaseUsernameField.Location = new Point(442, 6);
            DatabaseUsernameField.Name = "DatabaseUsernameField";
            DatabaseUsernameField.Size = new Size(187, 23);
            DatabaseUsernameField.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 9);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // DatabaseConnectButton
            // 
            DatabaseConnectButton.Location = new Point(887, 6);
            DatabaseConnectButton.Name = "DatabaseConnectButton";
            DatabaseConnectButton.Size = new Size(109, 23);
            DatabaseConnectButton.TabIndex = 5;
            DatabaseConnectButton.Text = "Connect";
            DatabaseConnectButton.UseVisualStyleBackColor = true;
            DatabaseConnectButton.Click += DatabaseConnectButton_Click;
            // 
            // DatabasePasswordField
            // 
            DatabasePasswordField.Location = new Point(696, 6);
            DatabasePasswordField.Name = "DatabasePasswordField";
            DatabasePasswordField.PasswordChar = '*';
            DatabasePasswordField.Size = new Size(185, 23);
            DatabasePasswordField.TabIndex = 4;
            // 
            // ServerLifecycleFilterComboBox
            // 
            ServerLifecycleFilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ServerLifecycleFilterComboBox.FormattingEnabled = true;
            ServerLifecycleFilterComboBox.Location = new Point(6, 154);
            ServerLifecycleFilterComboBox.Name = "ServerLifecycleFilterComboBox";
            ServerLifecycleFilterComboBox.Size = new Size(212, 23);
            ServerLifecycleFilterComboBox.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 136);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 24;
            label12.Text = "Lifecycle";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 818);
            Controls.Add(DatabasePasswordField);
            Controls.Add(DatabaseConnectButton);
            Controls.Add(label3);
            Controls.Add(DatabaseUsernameField);
            Controls.Add(label4);
            Controls.Add(DatabasePortField);
            Controls.Add(label2);
            Controls.Add(DatabaseIpField);
            Controls.Add(label1);
            Controls.Add(MainGroupBox);
            Name = "MainForm";
            Text = "Middleware Repository";
            MainGroupBox.ResumeLayout(false);
            ServersTab.ResumeLayout(false);
            ServersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServersDataGrid).EndInit();
            ServicesTab.ResumeLayout(false);
            ServicesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesDataGrid).EndInit();
            SystemsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SystemsDataGrid).EndInit();
            BackendsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BackendsDataGrid).EndInit();
            OsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OperatingSystemsDataGrid).EndInit();
            VendorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VendorsDataGrid).EndInit();
            OsVersionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OsVersionsDataGrid).EndInit();
            LifecyclesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LifecyclesDataGrid).EndInit();
            HardwareModelsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HardwareModelsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TabControl MainGroupBox;
        private TabPage ServersTab;
        private TabPage SystemsTab;
        private Label label1;
        private TextBox DatabaseIpField;
        private TextBox DatabasePortField;
        private Label label2;
        private Label label3;
        private TextBox DatabaseUsernameField;
        private Label label4;
        private Button DatabaseConnectButton;
        private MaskedTextBox DatabasePasswordField;
        private DataGridView ServersDataGrid;
        private TextBox ServersIpFilterField;
        private Label label5;
        private TabPage BackendsTab;
        private TabPage OsTab;
        private TabPage OsVersionsTab;
        private TabPage VendorsTab;
        private ComboBox ServersHypervisorFilterCombo;
        private Label label13;
        private ComboBox ServersOsVersionFilterCombo;
        private Label label11;
        private ComboBox ServersHardwareFilterCombo;
        private Label label10;
        private ComboBox ServersOsFilterCombo;
        private Label label9;
        private ComboBox ServersBackendFilterCombo;
        private Label label8;
        private ComboBox ServersSystemFilterCombo;
        private Label label7;
        private TextBox ServersHostnameFilterField;
        private Label label6;
        private TabPage ServicesTab;
        private Button ServersFilterButton;
        private DataGridView SystemsDataGrid;
        private Button AddBackendSystem;
        private DataGridView BackendsDataGrid;
        private Button ServicesFilterButton;
        private TextBox ServicesIpFilterField;
        private Label label25;
        private DataGridView ServicesDataGrid;
        private DataGridView OperatingSystemsDataGrid;
        private DataGridView VendorsDataGrid;
        private DataGridView OsVersionsDataGrid;
        private Button ResetServersFilterButton;
        private TabPage LifecyclesTab;
        private DataGridView LifecyclesDataGrid;
        private Button RemoveServerButton;
        private Button RemoveSystemButton;
        private Button AddSystemButton;
        private Button EditBackendButton;
        private Button EditSystemsButton;
        private Button RemoveBackendButton;
        private ComboBox ServicesTlsEnabledComboBox;
        private Label label18;
        private TextBox ServicesProtocolFilterField;
        private Label label17;
        private ComboBox ServicesPortTypeComboBox;
        private Label label16;
        private TextBox ServicesPortFilterField;
        private Label label15;
        private TextBox ServicesNameFilterField;
        private Label label14;
        private Button button8;
        private Button button7;
        private Button button2;
        private Button ResetServicesFilterButton;
        private Button button4;
        private Button button9;
        private Button button10;
        private Button button5;
        private Button button11;
        private Button button12;
        private Button button6;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private TabPage HardwareModelsTab;
        private Button button18;
        private Button button19;
        private Button button20;
        private DataGridView HardwareModelsDataGrid;
        private Button AddServerButton;
        private Button button21;
        private ComboBox ServerLifecycleFilterComboBox;
        private Label label12;
    }
}
