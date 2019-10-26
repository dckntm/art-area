using ArtArea.Web.Models;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ApplicationDb
{
    private IMongoDatabase database;
    private IGridFSBucket bucket;
    public ApplicationDb()
    {
        var client = new MongoClient();
        database = client.GetDatabase("artareadb");
        bucket = new GridFSBucket(database);
    }
    public IMongoCollection<ArtArea.Web.Models.Task> Tasks => database.GetCollection<ArtArea.Web.Models.Task>("tasks");
    public IMongoCollection<File> Files => database.GetCollection<File>("files");
    public IMongoCollection<Comment> Comments => database.GetCollection<Comment>("comments");



}