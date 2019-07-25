﻿using CosmosDb.Sample.Shared.Models.Csv;
using System;

namespace CosmosDb.Sample.Shared.Models.Graph
{
    public class CastVertex
    {
        [Id]
        public string Id => $"{MovieTitle}-{Order}";

        [PartitionKey]
        public string ActorName { get; set; }

        public string MovieTitle { get; set; }
        public string MovieId { get; set; }

        public string Character { get; set; }
        public int Order { get; set; }
        public bool Uncredited { get; set; }

       
    }
}