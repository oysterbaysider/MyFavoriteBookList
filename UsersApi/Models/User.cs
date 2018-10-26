using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApi.Models
{
    public class User
    {
        [BsonId]
        public ObjectId UserID { get; set; }

        public string UserName { get; set; }

        public string UserDisplayName { get; set; }

        public int UserAge { get; set; }
    }
}
