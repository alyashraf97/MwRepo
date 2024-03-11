using Npgsql;
using System.Numerics;
using System.Text.RegularExpressions;
using MwRepo.Models;

namespace MwRepo
{
    public partial class MainForm : Form
    {
        
        private MwRepository repo = MwRepository.Instance;

        private List<Server>? servers = new List<Server>();
        private List<Systems>? systems = new List<Systems>();
        private List<string?>? lifecycles = new List<string>();
        private List<string?>? backendSystems = new List<string>();
        private List<Service>? services = new List<Service>();
        private List<Os>? os = new List<Os>();
        private List<string?>? hardwareModels = new List<string>();
        private List<string?>? osVersions = new List<string>();
        //private List<Vendor>? vendors = new List<Vendor>();
        
        /*
        private Dictionary<string, int>? systemIdDict;
        private Dictionary<string, int>? lifecyclesIdDict;
        private Dictionary<string, int>? backendSystemsIdDict;
        private Dictionary<string, int>? servicesIdDict;
        private Dictionary<string, int>? osIdDict;
        private Dictionary<string, int>? hardwareModelsIdDict;
        private Dictionary<string, int>? osVersionsIdDict;
        private Dictionary<string, int>? vendorsIdDict;
        */
        private const string PortRegex = @"^(6553[0-5]|655[0-2]\\d|65[0-4]\\d{2}|6[0-4]\\d{3}|[1-5]\\d{4}|[1-9]\\d{0,3}|0)$";
        private const string IpRegex = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
               @"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.?)?" +
               @"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.?)?" +
               @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)?$";
        private const string HostnameRegex = @"^(?:(?=[a-z0-9-]{1,63}\.)(xn--)?[a-z0-9]+(-[a-z0-9]+)*\.)*[a-z0-9]{1,63}$";

        public MainForm()
        {
            InitializeComponent();
            MainGroupBox.Enabled = false;
            DatabasePortField.Text = "5432";
            DatabaseUsernameField.Text = "mwrepo";
        }
        /// <summary>
        /// Populating the Main Data Grids
        /// </summary>
        
        private void PopulateDataGrids()
        {
            PopulateServers();
            PopulateServices();
            PopulateSystems();
            PopulateLifecycles();
            //PopulateBackendSystems();
            //PopulateHardwareModels();
            //PopulateHypervisors();
            PopulateOperatingSystems();
            //PopulateOperatingSystemVersions();
            //PopulateVendors();
        }
        
        /// <summary>
        /// Functions for each Tab
        /// </summary>

        // Servers (RHEL, Solaris, Ubuntu, Exadata, etc..)
        
        private void PopulateServers()
        {
            servers = repo.QueryServers();

            if (servers == null) { return; }

            ServersDataGrid.DataSource = servers;
        }
        

        // Major Systems (CRM, ERP, CBS, etc..)
        private void PopulateSystems()
        {
            systems = repo.QuerySystems();

            if (systems == null) { return; }

            SystemsDataGrid.DataSource = systems;                        
        }
        
        // Lifecycles (Dev, Test, Prod, etc..)
        private void PopulateLifecycles()
        {
            lifecycles = repo.QueryLifecycles();

            if (lifecycles == null) { return; }

            LifecyclesDataGrid.DataSource = lifecycles;
        }

        // Backend Systems
        private void PopulateBackendSystems()
        {

            backendSystems = repo.QueryBackendSystems();

            if (backendSystems == null) { return; }

            BackendsDataGrid.DataSource = backendSystems;
        }

        // Services
        private void PopulateServices()
        {
            services = repo.QueryServices();

            if (services == null)
            {
                return;
            }

            ServicesDataGrid.DataSource = services;
        }

        // Hardware Models
        private void PopulateHardwareModels()
        {
            hardwareModels = repo.QueryHardwareModels();

            if (hardwareModels == null)
            {
                return;
            }

            HardwareModelsDataGrid.DataSource = hardwareModels;
        }


        // Operating Systems
        private void PopulateOperatingSystems()
        {
            os = repo.QueryOperatingSystems();

            if (os == null)
            {
                return;
            }

            OperatingSystemsDataGrid.DataSource = os;
        }

        // OS Versions
        private void PopulateOperatingSystemVersions()
        {
            osVersions = repo.QueryOsVersions();

            if (osVersions == null)
            {
                return;
            }

            OsVersionsDataGrid.DataSource = osVersions;
        }

        // Vendors
        /*
        private void PopulateVendors()
        {
            vendorsIdDict = new Dictionary<string, int>
            {
                { "None", 0}
            };

            vendors = repo.QueryVendors();

            if (vendors == null)
            {
                return;
            }

            VendorsDataGrid.DataSource = vendors;

            foreach (Vendor vendor in vendors)
            {
                vendorsIdDict.Add(vendor.Name, vendor.Id);
            }
        }*/

        private void PopulateHypervisors()
        {

        }

        /// <summary>
        /// Populating Combo Boxes
        /// </summary>

        private void PopulateComboBoxes()
        {
            PopulateServersComboBoxes();
            PopulateServicesComboBoxes();
        }

        private void PopulateComboBox(ComboBox comboBox, List<string> items)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("None");
            comboBox.SelectedIndex = 0;
            foreach (string item in items)
            {
                comboBox.Items.Add(item);
            }
        }
        

        private void PopulateServersComboBoxes()
        {

            if (systems != null)
            {
                var systemNames = systems.Select(system => system.Name).ToList();
                PopulateComboBox(ServersSystemFilterCombo, systemNames);
            }

            if (lifecycles != null)
            {
                PopulateComboBox(ServerLifecycleFilterComboBox, lifecycles);
            }

            if (backendSystems != null)
            {
                PopulateComboBox(ServersBackendFilterCombo, items: backendSystems);
            }

            if (os != null)
            {
                var osNames = os.Select(operatingSystem => operatingSystem.Name).ToList();
                PopulateComboBox(ServersOsFilterCombo, osNames);
            }

            if (hardwareModels != null)
            {
                PopulateComboBox(ServersHardwareFilterCombo, hardwareModels);
            }

            if (osVersions != null)
            {
                PopulateComboBox(ServersOsVersionFilterCombo, osVersions);
            }
        }

        private void PopulateServicesComboBoxes()
        {
            ServicesPortTypeComboBox.Items.Clear();
            ServicesPortTypeComboBox.Items.Add("None");
            ServicesPortTypeComboBox.Items.Add("TCP");
            ServicesPortTypeComboBox.Items.Add("UDP");
            ServicesPortTypeComboBox.SelectedIndex = 0;

            ServicesTlsEnabledComboBox.Items.Clear();
            ServicesTlsEnabledComboBox.Items.Add("None");
            ServicesTlsEnabledComboBox.Items.Add("True");
            ServicesTlsEnabledComboBox.Items.Add("False");
            ServicesTlsEnabledComboBox.SelectedIndex = 0;
        }

        private void ResetServersComboBoxIndecies()
        {
            if (ServersSystemFilterCombo.Items.Count != 0) { ServersSystemFilterCombo.SelectedIndex = 0; }
            if (ServersBackendFilterCombo.Items.Count != 0) { ServersBackendFilterCombo.SelectedIndex = 0; }
            if (ServersOsFilterCombo.Items.Count != 0) { ServersOsFilterCombo.SelectedIndex = 0; }
            if (ServersHardwareFilterCombo.Items.Count != 0) { ServersHardwareFilterCombo.SelectedIndex = 0; }
            if (ServersOsVersionFilterCombo.Items.Count != 0) { ServersOsVersionFilterCombo.SelectedIndex = 0; }
            if (ServersHypervisorFilterCombo.Items.Count != 0) { ServersHypervisorFilterCombo.SelectedIndex = 0; }
        }

        private void ResetServicesComboBoxIndecies()
        {
            if (ServicesPortTypeComboBox.Items.Count != 0) { ServicesPortTypeComboBox.SelectedIndex = 0; }
            if (ServicesTlsEnabledComboBox.Items.Count != 0) { ServicesTlsEnabledComboBox.SelectedIndex = 0; }
        }

        private int? GetMappedId(Dictionary<string, int>? dict, string key)
        {
            if (dict != null && dict.TryGetValue(key, out int mappedId))
            {
                return mappedId;
            }
            return null;
        }
        
        private void DatabaseConnectButton_Click(object sender, EventArgs e)
        {            
            MainGroupBox.Enabled = false;
            string databaseHost = DatabaseIpField.Text;
            string databasePort = DatabasePortField.Text;
            string databaseUsername = DatabaseUsernameField.Text;
            string databasePassword = DatabasePasswordField.Text;

            string connString = $"Host={databaseHost}; Port={databasePort}; " +
                $"Database=mw_repo; Username={databaseUsername}; Password={databasePassword};";

            try
            {
                var pgConn = new NpgsqlConnection(connectionString: connString);
                pgConn.Open();
                pgConn.Close();
                pgConn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database. \nError: {ex.Message}");
                return;
            }

            repo.Connect(databaseHost, databasePort, databaseUsername, databasePassword);

            if (!repo.ConnectionStatus == true)
            {
                MessageBox.Show($"Failed to connect to database. \nError: {repo.LastConnectionMessage}");
                return;
            }

            MainGroupBox.Enabled = true;
            PopulateDataGrids();
            PopulateComboBoxes();            
        }
        
        private void ServersFilterButton_Click(object sender, EventArgs e)
        {            
            if (!Regex.IsMatch(ServersHostnameFilterField.Text, HostnameRegex, RegexOptions.IgnoreCase)
                && !string.IsNullOrEmpty(ServersHostnameFilterField.Text))
            {
                MessageBox.Show("Invalid Hostname.");
                return;
            }
            if (!Regex.IsMatch(ServersIpFilterField.Text, IpRegex)
                && !string.IsNullOrEmpty(ServersIpFilterField.Text))
            {
                MessageBox.Show("Invalid IP Address.");
                return;
            }
            try
            {
                servers = repo.QueryServers(
                    fullname: ServersHostnameFilterField.Text,
                    ipAddress: ServersIpFilterField.Text,
                    system: ServersSystemFilterCombo.Text,
                    lifecycle: ServerLifecycleFilterComboBox.Text,
                    backend: ServersBackendFilterCombo.Text,
                    os: ServersOsFilterCombo.Text,
                    osVersion: ServersOsVersionFilterCombo.Text,
                    hardwareModel: ServersHardwareFilterCombo.Text
                // Add other parameters as needed
                );
                ServersDataGrid.DataSource = servers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error occurred: {ex.Message}");
            }
        }

        private void ResetServersFilterButton_Click(object sender, EventArgs e)
        {
            PopulateServers();
            ResetServersComboBoxIndecies();
        }

        private void ServicesFilterButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(ServicesIpFilterField.Text, IpRegex)
                && !string.IsNullOrEmpty(ServicesIpFilterField.Text))
            {
                MessageBox.Show("Invalid IP Address.");
                return;
            }

            if (!Regex.IsMatch(ServicesPortFilterField.Text, PortRegex)
                && !string.IsNullOrEmpty(ServicesPortFilterField.Text))
            {
                MessageBox.Show("Invalid Port Number.");
                return;
            }
            try
            {

                int port = 0;
                bool isPortValid = string.IsNullOrEmpty(ServicesPortFilterField.Text)
                    || int.TryParse(ServicesPortFilterField.Text, out port);
                if (!isPortValid)
                {
                    MessageBox.Show("Invalid Port Number.");
                    return;
                }

                bool? tlsEnabled = null;
                if (ServicesTlsEnabledComboBox.Text.ToLower() != "none")
                {
                    tlsEnabled = bool.Parse(ServicesTlsEnabledComboBox.Text.ToLower());
                }

                services = repo.QueryServices(
                    serviceName: ServicesNameFilterField.Text,
                    ipAddress: ServicesIpFilterField.Text,
                    protocol: ServicesProtocolFilterField.Text,
                    port: port,
                    portType: ServicesPortTypeComboBox.Text.ToLower(),
                    tlsEnabled: tlsEnabled
                    );
                ServicesDataGrid.DataSource = services;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error occurred: {ex.Message}");
            }
        }

        private void ResetServicesFilterButton_Click(object sender, EventArgs e)
        {
            //PopulateServices();
            ResetServicesComboBoxIndecies();
        }
    }
}
