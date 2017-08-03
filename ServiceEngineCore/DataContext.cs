using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServiceEngineCore
{
    public abstract class DataContext
    {
        public IMongoDatabase Database { get; set; }



        public DataContext(IMongoDatabase database)
        {
            Database = database;
        }

        private void Initialize()
        {
            var type = GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            if (properties != null && properties.Length != 0)
            {
                foreach (var property in properties)
                {
                    if (typeof(IMongoCollection<>) == property.GetType().GetGenericTypeDefinition())
                    {

                    }
                }
            }
        }
    }

    //public abstract class DataContext
    //{
    //    public const int DefaultPort = 0;

    //    public string Host { get; set; }
    //    public int Port { get; set; }
    //    public bool IsSecure { get; set; }
    //    public IMongoClient Client { get; private set; }
    //    public List<IMongoDatabase> Databases { get; protected set; }

    //    protected DataContext() : this("localhost", DefaultPort, false)
    //    { }
    //    protected DataContext(string host) : this(host, DefaultPort, false)
    //    { }
    //    protected DataContext(string host, int port) : this(host, port, false)
    //    { }
    //    protected DataContext(string host, int port, bool isSecure)
    //    {
    //        Host = host;
    //        Port = port;
    //        IsSecure = isSecure;
    //    }

    //    public void Connect(params string[] dbName)
    //    {
    //        Client = new MongoClient(new MongoClientSettings
    //        {
    //            Server = Port != 0 ? new MongoServerAddress(Host, Port) : new MongoServerAddress(Host),
    //            UseSsl = IsSecure
    //        });

    //        LoadDatabases(dbName);
    //    }

    //    private void LoadCollections()
    //    {

    //    }

    //    private void LoadDatabases(string[] dbNameList)
    //    {
    //        if (dbNameList != null && dbNameList.Length != 0)
    //        {
                
    //        }

    //        var type = GetType();
    //        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
    //        foreach (var property in properties)
    //        {
    //            if(typeof(IMongoDatabase).IsAssignableFrom(property.PropertyType))
    //            {
    //                try
    //                {
    //                    var db = Client.GetDatabase(property.Name);
    //                    if (db != null)
    //                    {
    //                        property.SetValue(this, db, null);
    //                    }
    //                }
    //                catch
    //                {}
    //            }
    //        }
    //    }
    //}
}
