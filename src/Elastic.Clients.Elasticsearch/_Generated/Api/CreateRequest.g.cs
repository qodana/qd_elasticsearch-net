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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed class CreateRequestParameters : RequestParameters<CreateRequestParameters>
{
	[JsonIgnore]
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
}

public sealed partial class CreateRequest<TDocument> : PlainRequest<CreateRequestParameters>
{
	public CreateRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCreate;
	protected override HttpMethod HttpMethod => HttpMethod.PUT;
	protected override bool SupportsBody => true;
	[JsonIgnore]
	public TDocument Document { get; set; }

	[JsonIgnore]
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
}

public sealed partial class CreateRequestDescriptor<TDocument> : RequestDescriptor<CreateRequestDescriptor<TDocument>, CreateRequestParameters>
{
	internal CreateRequestDescriptor(Action<CreateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	internal CreateRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	public CreateRequestDescriptor(TDocument document) : this(typeof(TDocument), Elasticsearch.Id.From(document)) => DocumentValue = document;
	public CreateRequestDescriptor(TDocument document, IndexName index, Id id) : this(index, id) => DocumentValue = document;
	public CreateRequestDescriptor(TDocument document, IndexName index) : this(index, Elasticsearch.Id.From(document)) => DocumentValue = document;
	public CreateRequestDescriptor(TDocument document, Id id) : this(typeof(TDocument), id) => DocumentValue = document;
	public CreateRequestDescriptor(Id id) : this(typeof(TDocument), id)
	{
	}

	internal CreateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCreate;
	protected override HttpMethod HttpMethod => HttpMethod.PUT;
	protected override bool SupportsBody => true;
	public CreateRequestDescriptor<TDocument> Pipeline(string? pipeline) => Qs("pipeline", pipeline);
	public CreateRequestDescriptor<TDocument> Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
	public CreateRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public CreateRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public CreateRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
	public CreateRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
	public CreateRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public CreateRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public CreateRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	private TDocument DocumentValue { get; set; }

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		SourceSerialisation.Serialize(DocumentValue, writer, settings.SourceSerializer);
	}
}