using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ArtArea.Models
{
    /*
        PIN: 
            - Id : 
                ObjectID generated by MongoDb for concrete pin

            - Message : 
                Message object that stores publication dat, author,... data for pin

            - FileId : 
                attached source file id (stringed ObjectId) stored in GridFS

            - Thumbnail : 
                id of the attached to pin thumbnail
    */
    public class Pin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Message Message { get; set; }
        public List<string> Messages { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string FileId { get; set; }
        public string ThumbnailId { get; set; }

    }
}