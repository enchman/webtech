using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServiceEngineCore
{
    public abstract class DataContext
    {
        public const int DefaultPort = 27001;

        public string Host { get; set; }
        public int Port { get; set; }
        public bool IsSecure { get; set; }
        public IMongoClient Client { get; private set; }

        public DataContext() : this("localhost", DefaultPort, false)
        { }
        public DataContext(string host) : this(host, DefaultPort, false)
        { }
        public DataContext(string host, int port) : this(host, port, false)
        { }
        public DataContext(string host, int port, bool isSecure)
        {
            Host = host;
            Port = port;
            IsSecure = isSecure;
            Connect();
        }

        public void Connect()
        {
            if (Client == null)
            {
                Client = new MongoClient(new MongoClientSettings
                {
                    Server = new MongoServerAddress(Host, Port),
                    UseSsl = IsSecure
                });

                LoadDatabases();
            }
        }

        private void LoadDatabases()
        {
            var type = GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in properties)
            {
                if(typeof(IMongoDatabase).IsAssignableFrom(property.PropertyType))
                {
                    try
                    {
                        var db = Client.GetDatabase(property.Name);
                        if (db != null)
                        {
                            property.SetValue(this, db, null);
                        }
                    }
                    catch
                    {}
                }
            }
        }
    }
}
