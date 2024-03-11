using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MwRepo.Models
{
    internal class MwRepository
    {
        private MwDbContext? Context;
        public bool ConnectionStatus { get; set; }
        public string? LastConnectionMessage { get; set; }

        private static readonly MwRepository _instance = new MwRepository();
        private MwRepository() { }

        public static MwRepository Instance { get { return _instance; } }

        public void Connect(string host, string port, string username, string password)
        {
            // Dispose of old connection if it exists
            DisposeContext();

            var connectionString = $"Host={host}; Port={port}; Database=mw_repository; Username={username}; Password={password};";

            try
            {
                // Set up DbContext with the connection string
                var optionsBuilder = new DbContextOptionsBuilder<MwDbContext>();
                optionsBuilder.UseNpgsql(connectionString);

                // Initialize DbContext
                Context = new MwDbContext(optionsBuilder.Options);

                // Test the connection by querying a dummy record
                var dummyRecord = Context.Servers.FirstOrDefault();

                // If the query succeeds, return true to indicate successful connection
                ConnectionStatus = true;
                LastConnectionMessage = "Connected";
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
                ConnectionStatus = false;
                LastConnectionMessage = ex.Message;
            }
        }

        private void DisposeContext()
        {
            Context?.Dispose();
            Context = null;
        }



        public List<Server>? QueryServers(string? fullname = null, string? ipAddress = null,
            string? lifecycle = null,
            string? system = null,
            string? backend = null,
            string? os = null,
            string? osVersion = null,
            string? hardwareModel = null)
        {
            if (Context == null)
            {
                return null;
            }
            var query = Context.Servers.AsQueryable();
            

            if (!string.IsNullOrEmpty(fullname))
            {
                query = query.Where(s => (s.FullName != null && s.FullName.Contains(fullname))
                || (s.Hostname != null && s.Hostname.Contains(fullname)));
            }

            if (!string.IsNullOrEmpty(ipAddress))
            {
                query = query.Where(s => s.IpAddress != null && s.IpAddress.Contains(ipAddress));
            }

            if (!string.IsNullOrEmpty(lifecycle))
            {
                query = query.Where(s => s.Lifecycle == lifecycle);
            }

            if (!string.IsNullOrEmpty(system))
            {
                query = query.Where(s => s.System == system);
            }

            if (!string.IsNullOrEmpty(backend))
            {
                query = query.Where(s => s.Backend == backend);
            }

            if (!string.IsNullOrEmpty(os))
            {
                query = query.Where(s => s.Os == os);
            }

            if (!string.IsNullOrEmpty(osVersion))
            {
                query = query.Where(s => s.OsVersion == osVersion);
            }

            if (!string.IsNullOrEmpty(hardwareModel))
            {
                query = query.Where(s => s.HardwareModel == hardwareModel);
            }
            return query.ToList() ?? new List<Server>();
        }

        public List<Service>? QueryServices(string? ipAddress = null,
            string? serviceName = null,
            string? protocol = null,
            int? port = null,
            string? portType = null,
            bool? tlsEnabled = null)
        {
            if (Context == null)
            {
                return null;
            }
            var query = Context.Services.AsQueryable();

            if (!string.IsNullOrEmpty(ipAddress))
            {
                query = query.Where(s => s.Ip != null && s.Ip.Contains(ipAddress));
            }
            if (!string.IsNullOrEmpty(serviceName))
            {
                query = query.Where(s => s.Name != null && s.Name.Contains(serviceName));
            }
            if (!string.IsNullOrEmpty(protocol))
            {
                query = query.Where(s => s.Protocol != null && s.Protocol.Contains(protocol));
            }
            if (!string.IsNullOrEmpty(portType))
            {
                query = query.Where(s => s.PortType == portType);
            }
            if (tlsEnabled != null)
            {
                query = query.Where(s => s.TlsEnabled == tlsEnabled);
            }
            if (port != null && port != 0)
            {
                query = query.Where(s => s.Port == port);
            }

            return query.ToList() ?? new List<Service>();
        }

        public List<Systems>? QuerySystems() => Context?.Systems.AsQueryable().ToList() ?? new List<Systems>();

        public List<string?>? QueryHardwareModels() => Context?.Servers.Select(s => s.HardwareModel).Distinct().ToList();

        public List<string?>? QueryBackendSystems() => Context?.Servers.Select(s => s.Backend).Distinct().ToList();

        public List<string?>? QueryOsVersions() => Context?.Servers.Select(s => s.OsVersion).Distinct().ToList();

        public List<Os>? QueryOperatingSystems() => Context?.OperatingSystems.AsQueryable().ToList() ?? new List<Os>();

        public List<string?>? QueryLifecycles() => Context?.Servers.Select(s => s.Lifecycle).Distinct().ToList();
    }
}
