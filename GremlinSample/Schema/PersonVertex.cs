﻿using Gremlin.Net.CosmosDb.Structure;

namespace GremlinSample.Schema
{
    [Label("person")]
    public class PersonVertex : IVertex
    {
        public int[] Ages { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public PersonPurchasedProductEdge Purchases { get; }
    }
}