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

namespace Elastic.Clients.Elasticsearch.Core.Search;

public sealed partial class InnerHits
{
	[JsonInclude, JsonPropertyName("collapse")]
	public Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? Collapse { get; set; }
	[JsonInclude, JsonPropertyName("docvalue_fields")]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? DocvalueFields { get; set; }
	[JsonInclude, JsonPropertyName("explain")]
	public bool? Explain { get; set; }
	[JsonInclude, JsonPropertyName("fields")]
	[JsonConverter(typeof(SingleOrManyFieldsConverter))]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

	/// <summary>
	/// <para>Inner hit starting document offset.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("from")]
	public int? From { get; set; }
	[JsonInclude, JsonPropertyName("highlight")]
	public Elastic.Clients.Elasticsearch.Core.Search.Highlight? Highlight { get; set; }
	[JsonInclude, JsonPropertyName("ignore_unmapped")]
	public bool? IgnoreUnmapped { get; set; }

	/// <summary>
	/// <para>The name for the particular inner hit definition in the response.<br/>Useful when a search request contains multiple inner hits.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Name? Name { get; set; }
	[JsonInclude, JsonPropertyName("script_fields")]
	public IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; set; }
	[JsonInclude, JsonPropertyName("seq_no_primary_term")]
	public bool? SeqNoPrimaryTerm { get; set; }

	/// <summary>
	/// <para>The maximum number of hits to return per `inner_hits`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }

	/// <summary>
	/// <para>How the inner hits should be sorted per `inner_hits`.<br/>By default, inner hits are sorted by score.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sort")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.SortOptions))]
	public ICollection<Elastic.Clients.Elasticsearch.SortOptions>? Sort { get; set; }
	[JsonInclude, JsonPropertyName("_source")]
	public Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? Source { get; set; }
	[JsonInclude, JsonPropertyName("stored_fields")]
	[JsonConverter(typeof(SingleOrManyFieldsConverter))]
	public Elastic.Clients.Elasticsearch.Fields? StoredFields { get; set; }
	[JsonInclude, JsonPropertyName("track_scores")]
	public bool? TrackScores { get; set; }
	[JsonInclude, JsonPropertyName("version")]
	public bool? Version { get; set; }
}

public sealed partial class InnerHitsDescriptor<TDocument> : SerializableDescriptor<InnerHitsDescriptor<TDocument>>
{
	internal InnerHitsDescriptor(Action<InnerHitsDescriptor<TDocument>> configure) => configure.Invoke(this);

	public InnerHitsDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? CollapseValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument> CollapseDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument>> CollapseDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? DocvalueFieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument> DocvalueFieldsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument>> DocvalueFieldsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument>>[] DocvalueFieldsDescriptorActions { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.Highlight? HighlightValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor<TDocument> HighlightDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor<TDocument>> HighlightDescriptorAction { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor> ScriptFieldsValue { get; set; }
	private bool? SeqNoPrimaryTermValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? SourceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; set; }
	private bool? TrackScoresValue { get; set; }
	private bool? VersionValue { get; set; }

	public InnerHitsDescriptor<TDocument> Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? collapse)
	{
		CollapseDescriptor = null;
		CollapseDescriptorAction = null;
		CollapseValue = collapse;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument> descriptor)
	{
		CollapseValue = null;
		CollapseDescriptorAction = null;
		CollapseDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Collapse(Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument>> configure)
	{
		CollapseValue = null;
		CollapseDescriptor = null;
		CollapseDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> DocvalueFields(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? docvalueFields)
	{
		DocvalueFieldsDescriptor = null;
		DocvalueFieldsDescriptorAction = null;
		DocvalueFieldsDescriptorActions = null;
		DocvalueFieldsValue = docvalueFields;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> DocvalueFields(Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument> descriptor)
	{
		DocvalueFieldsValue = null;
		DocvalueFieldsDescriptorAction = null;
		DocvalueFieldsDescriptorActions = null;
		DocvalueFieldsDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> DocvalueFields(Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument>> configure)
	{
		DocvalueFieldsValue = null;
		DocvalueFieldsDescriptor = null;
		DocvalueFieldsDescriptorActions = null;
		DocvalueFieldsDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> DocvalueFields(params Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument>>[] configure)
	{
		DocvalueFieldsValue = null;
		DocvalueFieldsDescriptor = null;
		DocvalueFieldsDescriptorAction = null;
		DocvalueFieldsDescriptorActions = configure;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Inner hit starting document offset.</para>
	/// </summary>
	public InnerHitsDescriptor<TDocument> From(int? from)
	{
		FromValue = from;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Highlight(Elastic.Clients.Elasticsearch.Core.Search.Highlight? highlight)
	{
		HighlightDescriptor = null;
		HighlightDescriptorAction = null;
		HighlightValue = highlight;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Highlight(Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor<TDocument> descriptor)
	{
		HighlightValue = null;
		HighlightDescriptorAction = null;
		HighlightDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Highlight(Action<Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor<TDocument>> configure)
	{
		HighlightValue = null;
		HighlightDescriptor = null;
		HighlightDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	/// <summary>
	/// <para>The name for the particular inner hit definition in the response.<br/>Useful when a search request contains multiple inner hits.</para>
	/// </summary>
	public InnerHitsDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		NameValue = name;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> ScriptFields(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor>> selector)
	{
		ScriptFieldsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor>());
		return Self;
	}

	public InnerHitsDescriptor<TDocument> SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true)
	{
		SeqNoPrimaryTermValue = seqNoPrimaryTerm;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of hits to return per `inner_hits`.</para>
	/// </summary>
	public InnerHitsDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>How the inner hits should be sorted per `inner_hits`.<br/>By default, inner hits are sorted by score.</para>
	/// </summary>
	public InnerHitsDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? source)
	{
		SourceValue = source;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields)
	{
		StoredFieldsValue = storedFields;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> TrackScores(bool? trackScores = true)
	{
		TrackScoresValue = trackScores;
		return Self;
	}

	public InnerHitsDescriptor<TDocument> Version(bool? version = true)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollapseDescriptor is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseDescriptor, options);
		}
		else if (CollapseDescriptorAction is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument>(CollapseDescriptorAction), options);
		}
		else if (CollapseValue is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseValue, options);
		}

		if (DocvalueFieldsDescriptor is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocvalueFieldsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocvalueFieldsDescriptorAction is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument>(DocvalueFieldsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocvalueFieldsDescriptorActions is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			writer.WriteStartArray();
			foreach (var action in DocvalueFieldsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocvalueFieldsValue is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			JsonSerializer.Serialize(writer, DocvalueFieldsValue, options);
		}

		if (ExplainValue.HasValue)
		{
			writer.WritePropertyName("explain");
			writer.WriteBooleanValue(ExplainValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FromValue.HasValue)
		{
			writer.WritePropertyName("from");
			writer.WriteNumberValue(FromValue.Value);
		}

		if (HighlightDescriptor is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightDescriptor, options);
		}
		else if (HighlightDescriptorAction is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor<TDocument>(HighlightDescriptorAction), options);
		}
		else if (HighlightValue is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightValue, options);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (NameValue is not null)
		{
			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
		}

		if (ScriptFieldsValue is not null)
		{
			writer.WritePropertyName("script_fields");
			JsonSerializer.Serialize(writer, ScriptFieldsValue, options);
		}

		if (SeqNoPrimaryTermValue.HasValue)
		{
			writer.WritePropertyName("seq_no_primary_term");
			writer.WriteBooleanValue(SeqNoPrimaryTermValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (SourceValue is not null)
		{
			writer.WritePropertyName("_source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (StoredFieldsValue is not null)
		{
			writer.WritePropertyName("stored_fields");
			JsonSerializer.Serialize(writer, StoredFieldsValue, options);
		}

		if (TrackScoresValue.HasValue)
		{
			writer.WritePropertyName("track_scores");
			writer.WriteBooleanValue(TrackScoresValue.Value);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteBooleanValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class InnerHitsDescriptor : SerializableDescriptor<InnerHitsDescriptor>
{
	internal InnerHitsDescriptor(Action<InnerHitsDescriptor> configure) => configure.Invoke(this);

	public InnerHitsDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? CollapseValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor CollapseDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor> CollapseDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? DocvalueFieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor DocvalueFieldsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor> DocvalueFieldsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor>[] DocvalueFieldsDescriptorActions { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.Highlight? HighlightValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor HighlightDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor> HighlightDescriptorAction { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor> ScriptFieldsValue { get; set; }
	private bool? SeqNoPrimaryTermValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] SortDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? SourceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; set; }
	private bool? TrackScoresValue { get; set; }
	private bool? VersionValue { get; set; }

	public InnerHitsDescriptor Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? collapse)
	{
		CollapseDescriptor = null;
		CollapseDescriptorAction = null;
		CollapseValue = collapse;
		return Self;
	}

	public InnerHitsDescriptor Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor descriptor)
	{
		CollapseValue = null;
		CollapseDescriptorAction = null;
		CollapseDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor Collapse(Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor> configure)
	{
		CollapseValue = null;
		CollapseDescriptor = null;
		CollapseDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor DocvalueFields(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? docvalueFields)
	{
		DocvalueFieldsDescriptor = null;
		DocvalueFieldsDescriptorAction = null;
		DocvalueFieldsDescriptorActions = null;
		DocvalueFieldsValue = docvalueFields;
		return Self;
	}

	public InnerHitsDescriptor DocvalueFields(Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor descriptor)
	{
		DocvalueFieldsValue = null;
		DocvalueFieldsDescriptorAction = null;
		DocvalueFieldsDescriptorActions = null;
		DocvalueFieldsDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor DocvalueFields(Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor> configure)
	{
		DocvalueFieldsValue = null;
		DocvalueFieldsDescriptor = null;
		DocvalueFieldsDescriptorActions = null;
		DocvalueFieldsDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor DocvalueFields(params Action<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor>[] configure)
	{
		DocvalueFieldsValue = null;
		DocvalueFieldsDescriptor = null;
		DocvalueFieldsDescriptorAction = null;
		DocvalueFieldsDescriptorActions = configure;
		return Self;
	}

	public InnerHitsDescriptor Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	public InnerHitsDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Inner hit starting document offset.</para>
	/// </summary>
	public InnerHitsDescriptor From(int? from)
	{
		FromValue = from;
		return Self;
	}

	public InnerHitsDescriptor Highlight(Elastic.Clients.Elasticsearch.Core.Search.Highlight? highlight)
	{
		HighlightDescriptor = null;
		HighlightDescriptorAction = null;
		HighlightValue = highlight;
		return Self;
	}

	public InnerHitsDescriptor Highlight(Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor descriptor)
	{
		HighlightValue = null;
		HighlightDescriptorAction = null;
		HighlightDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor Highlight(Action<Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor> configure)
	{
		HighlightValue = null;
		HighlightDescriptor = null;
		HighlightDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	/// <summary>
	/// <para>The name for the particular inner hit definition in the response.<br/>Useful when a search request contains multiple inner hits.</para>
	/// </summary>
	public InnerHitsDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		NameValue = name;
		return Self;
	}

	public InnerHitsDescriptor ScriptFields(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor>> selector)
	{
		ScriptFieldsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptFieldDescriptor>());
		return Self;
	}

	public InnerHitsDescriptor SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true)
	{
		SeqNoPrimaryTermValue = seqNoPrimaryTerm;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of hits to return per `inner_hits`.</para>
	/// </summary>
	public InnerHitsDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>How the inner hits should be sorted per `inner_hits`.<br/>By default, inner hits are sorted by score.</para>
	/// </summary>
	public InnerHitsDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public InnerHitsDescriptor Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public InnerHitsDescriptor Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public InnerHitsDescriptor Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	public InnerHitsDescriptor Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? source)
	{
		SourceValue = source;
		return Self;
	}

	public InnerHitsDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields)
	{
		StoredFieldsValue = storedFields;
		return Self;
	}

	public InnerHitsDescriptor TrackScores(bool? trackScores = true)
	{
		TrackScoresValue = trackScores;
		return Self;
	}

	public InnerHitsDescriptor Version(bool? version = true)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollapseDescriptor is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseDescriptor, options);
		}
		else if (CollapseDescriptorAction is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor(CollapseDescriptorAction), options);
		}
		else if (CollapseValue is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseValue, options);
		}

		if (DocvalueFieldsDescriptor is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocvalueFieldsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocvalueFieldsDescriptorAction is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor(DocvalueFieldsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocvalueFieldsDescriptorActions is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			writer.WriteStartArray();
			foreach (var action in DocvalueFieldsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormatDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocvalueFieldsValue is not null)
		{
			writer.WritePropertyName("docvalue_fields");
			JsonSerializer.Serialize(writer, DocvalueFieldsValue, options);
		}

		if (ExplainValue.HasValue)
		{
			writer.WritePropertyName("explain");
			writer.WriteBooleanValue(ExplainValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FromValue.HasValue)
		{
			writer.WritePropertyName("from");
			writer.WriteNumberValue(FromValue.Value);
		}

		if (HighlightDescriptor is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightDescriptor, options);
		}
		else if (HighlightDescriptorAction is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.HighlightDescriptor(HighlightDescriptorAction), options);
		}
		else if (HighlightValue is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightValue, options);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (NameValue is not null)
		{
			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
		}

		if (ScriptFieldsValue is not null)
		{
			writer.WritePropertyName("script_fields");
			JsonSerializer.Serialize(writer, ScriptFieldsValue, options);
		}

		if (SeqNoPrimaryTermValue.HasValue)
		{
			writer.WritePropertyName("seq_no_primary_term");
			writer.WriteBooleanValue(SeqNoPrimaryTermValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (SourceValue is not null)
		{
			writer.WritePropertyName("_source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (StoredFieldsValue is not null)
		{
			writer.WritePropertyName("stored_fields");
			JsonSerializer.Serialize(writer, StoredFieldsValue, options);
		}

		if (TrackScoresValue.HasValue)
		{
			writer.WritePropertyName("track_scores");
			writer.WriteBooleanValue(TrackScoresValue.Value);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteBooleanValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}