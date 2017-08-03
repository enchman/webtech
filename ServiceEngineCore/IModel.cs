using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceEngineCore
{
    public interface IModel
    {
        string _id { get; set; }
        BsonDocument ToData();
    }
}
