﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace S2SIntegration_ProcessPrintTask.Graph.Models
{
    using Newtonsoft.Json;

    public class ResourceData
    {
        // The ID of the resource.
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        // The OData etag property.
        [JsonProperty(PropertyName = "@odata.etag")]
        public string ODataEtag { get; set; }

        // The OData ID of the resource. This is the same value as the resource property.
        [JsonProperty(PropertyName = "@odata.id")]
        public string ODataId { get; set; }

        // The OData type of the resource: e.g. "#Microsoft.Graph.PrintTask"
        [JsonProperty(PropertyName = "@odata.type")]
        public string ODataType { get; set; }

        // The OData type of the resource: "#Microsoft.Graph.Message", "#Microsoft.Graph.Event", or "#Microsoft.Graph.Contact".
        [JsonProperty(PropertyName = "parentUrl")]
        public string ParentUrl { get; set; }
    }
}
