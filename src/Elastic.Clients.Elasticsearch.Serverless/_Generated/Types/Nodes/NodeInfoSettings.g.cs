// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Nodes;

public sealed partial class NodeInfoSettings
{
	[JsonInclude, JsonPropertyName("action")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoAction? Action { get; init; }
	[JsonInclude, JsonPropertyName("bootstrap")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoBootstrap? Bootstrap { get; init; }
	[JsonInclude, JsonPropertyName("client")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoClient Client { get; init; }
	[JsonInclude, JsonPropertyName("cluster")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSettingsCluster Cluster { get; init; }
	[JsonInclude, JsonPropertyName("discovery")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoDiscover? Discovery { get; init; }
	[JsonInclude, JsonPropertyName("http")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSettingsHttp Http { get; init; }
	[JsonInclude, JsonPropertyName("ingest")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSettingsIngest? Ingest { get; init; }
	[JsonInclude, JsonPropertyName("network")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSettingsNetwork? Network { get; init; }
	[JsonInclude, JsonPropertyName("node")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSettingsNode Node { get; init; }
	[JsonInclude, JsonPropertyName("path")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoPath? Path { get; init; }
	[JsonInclude, JsonPropertyName("repositories")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoRepositories? Repositories { get; init; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoScript? Script { get; init; }
	[JsonInclude, JsonPropertyName("search")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSearch? Search { get; init; }
	[JsonInclude, JsonPropertyName("transport")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSettingsTransport Transport { get; init; }
	[JsonInclude, JsonPropertyName("xpack")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoXpack? Xpack { get; init; }
}