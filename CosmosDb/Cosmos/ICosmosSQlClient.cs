﻿using CosmosDb.Domain;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDb
{
    public interface ICosmosSqlClient
    {
        CosmosClient Client { get; }
        Database Database { get; }
        Container Container { get; }


        Task<CosmosResponse> InsertDocument<T>(T document);
        Task<IEnumerable<CosmosResponse>> InsertDocuments<T>(IEnumerable<T> documents, Action<IEnumerable<CosmosResponse>> reportingCallback = null, int threads = 4, int reportingIntervalS = 10);

        Task<CosmosResponse> UpsertDocument<T>(T document);
        Task<IEnumerable<CosmosResponse>> UpsertDocuments<T>(IEnumerable<T> documents, Action<IEnumerable<CosmosResponse>> reportingCallback = null, int threads = 4, int reportingIntervalS = 10);

        Task<CosmosResponse<T>> ReadDocument<T>(string docId, string partitionKey);
        Task<CosmosResponse<IEnumerable<T>>> ExecuteSQL<T>(string query);


        //Task<CosmosResponse> InsertGraphVertex<T>(T vertex);
        //Task<CosmosResponse> UpsertGraphVertex<T>(T vertex);
        //Task<CosmosResponse<T>> ReadGraphVertex<T>(string docId, string partitionKey);

        //Task<CosmosResponse> InsertGraphEdge<T, U, V>(T edge, U source, V target);
        //Task<IEnumerable<CosmosResponse>> InsertGraphVertex<T>(IEnumerable<T> vertices, Action<IEnumerable<CosmosResponse>> reportingCallback = null, int threads = 4, int reportingIntervalS = 10);
        //Task<CosmosResponse> UpsertGraphEdge<T, U, V>(T edge, U source, V target, bool single = false);
        //Task<IEnumerable<CosmosResponse>> UpsertGraphVertex<T>(IEnumerable<T> vertices, Action<IEnumerable<CosmosResponse>> reportingCallback = null, int threads = 4, int reportingIntervalS = 10);

        //Task<CosmosResponse> InsertGraphEdge<T>(T edge, GraphItemBase source, GraphItemBase target);
        //Task<CosmosResponse> UpsertGraphEdge<T>(T edge, GraphItemBase source, GraphItemBase target, bool single = false);


        //Task<CosmosResponse> ExecuteGremlingSingle(string queryString);
        //Task<CosmosResponse<T>> ExecuteGremlingSingle<T>(string queryString);
        //Task<CosmosResponse<IEnumerable<T>>> ExecuteGremlingMulti<T>(string queryString);
    }
}
