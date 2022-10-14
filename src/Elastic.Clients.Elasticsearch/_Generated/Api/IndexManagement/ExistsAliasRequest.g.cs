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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed class ExistsAliasRequestParameters : RequestParameters<ExistsAliasRequestParameters>
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

public sealed partial class ExistsAliasRequest : PlainRequest<ExistsAliasRequestParameters>
{
	public ExistsAliasRequest(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
	{
	}

	public ExistsAliasRequest(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names name) : base(r => r.Optional("index", indices).Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementExistsAlias;
	protected override HttpMethod HttpMethod => HttpMethod.HEAD;
	protected override bool SupportsBody => false;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

public sealed partial class ExistsAliasRequestDescriptor<TDocument> : RequestDescriptor<ExistsAliasRequestDescriptor<TDocument>, ExistsAliasRequestParameters>
{
	internal ExistsAliasRequestDescriptor(Action<ExistsAliasRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public ExistsAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
	{
	}

	public ExistsAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names name) : base(r => r.Optional("index", indices).Required("name", name))
	{
	}

	internal ExistsAliasRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementExistsAlias;
	protected override HttpMethod HttpMethod => HttpMethod.HEAD;
	protected override bool SupportsBody => false;
	public ExistsAliasRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ExistsAliasRequestDescriptor<TDocument> ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ExistsAliasRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ExistsAliasRequestDescriptor<TDocument> Local(bool? local = true) => Qs("local", local);
	public ExistsAliasRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Names name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	public ExistsAliasRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class ExistsAliasRequestDescriptor : RequestDescriptor<ExistsAliasRequestDescriptor, ExistsAliasRequestParameters>
{
	internal ExistsAliasRequestDescriptor(Action<ExistsAliasRequestDescriptor> configure) => configure.Invoke(this);
	public ExistsAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
	{
	}

	public ExistsAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names name) : base(r => r.Optional("index", indices).Required("name", name))
	{
	}

	internal ExistsAliasRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementExistsAlias;
	protected override HttpMethod HttpMethod => HttpMethod.HEAD;
	protected override bool SupportsBody => false;
	public ExistsAliasRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ExistsAliasRequestDescriptor ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ExistsAliasRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ExistsAliasRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public ExistsAliasRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	public ExistsAliasRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}