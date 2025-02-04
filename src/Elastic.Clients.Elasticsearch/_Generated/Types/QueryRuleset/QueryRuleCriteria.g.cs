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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.QueryRuleset;

public sealed partial class QueryRuleCriteria
{
	[JsonInclude, JsonPropertyName("metadata")]
	public string Metadata { get; set; }
	[JsonInclude, JsonPropertyName("type")]
	public Elastic.Clients.Elasticsearch.QueryRuleset.QueryRuleCriteriaType Type { get; set; }
	[JsonInclude, JsonPropertyName("values")]
	public ICollection<object>? Values { get; set; }
}

public sealed partial class QueryRuleCriteriaDescriptor : SerializableDescriptor<QueryRuleCriteriaDescriptor>
{
	internal QueryRuleCriteriaDescriptor(Action<QueryRuleCriteriaDescriptor> configure) => configure.Invoke(this);

	public QueryRuleCriteriaDescriptor() : base()
	{
	}

	private string MetadataValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryRuleset.QueryRuleCriteriaType TypeValue { get; set; }
	private ICollection<object>? ValuesValue { get; set; }

	public QueryRuleCriteriaDescriptor Metadata(string metadata)
	{
		MetadataValue = metadata;
		return Self;
	}

	public QueryRuleCriteriaDescriptor Type(Elastic.Clients.Elasticsearch.QueryRuleset.QueryRuleCriteriaType type)
	{
		TypeValue = type;
		return Self;
	}

	public QueryRuleCriteriaDescriptor Values(ICollection<object>? values)
	{
		ValuesValue = values;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("metadata");
		writer.WriteStringValue(MetadataValue);
		writer.WritePropertyName("type");
		JsonSerializer.Serialize(writer, TypeValue, options);
		if (ValuesValue is not null)
		{
			writer.WritePropertyName("values");
			JsonSerializer.Serialize(writer, ValuesValue, options);
		}

		writer.WriteEndObject();
	}
}