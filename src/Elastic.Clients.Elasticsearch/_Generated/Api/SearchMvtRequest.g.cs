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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

public sealed partial class SearchMvtRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Searches a vector tile for geospatial values. Returns results as a binary Mapbox vector tile.</para>
/// </summary>
public sealed partial class SearchMvtRequest : PlainRequest<SearchMvtRequestParameters>
{
	public SearchMvtRequest(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Field field, int zoom, int x, int y) : base(r => r.Required("index", indices).Required("field", field).Required("zoom", zoom).Required("x", x).Required("y", y))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceSearchMvt;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "search_mvt";

	/// <summary>
	/// <para>Sub-aggregations for the geotile_grid.</para>
	/// <para>Supports the following aggregation types:<br/>- avg<br/>- cardinality<br/>- max<br/>- min<br/>- sum</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aggs")]
	public IDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.Aggregation>? Aggs { get; set; }

	/// <summary>
	/// <para>Size, in pixels, of a clipping buffer outside the tile. This allows renderers<br/>to avoid outline artifacts from geometries that extend past the extent of the tile.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("buffer")]
	public int? Buffer { get; set; }

	/// <summary>
	/// <para>If false, the meta layer’s feature is the bounding box of the tile.<br/>If true, the meta layer’s feature is a bounding box resulting from a<br/>geo_bounds aggregation. The aggregation runs on <field> values that intersect<br/>the <zoom>/<x>/<y> tile with wrap_longitude set to false. The resulting<br/>bounding box may be larger than the vector tile.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("exact_bounds")]
	public bool? ExactBounds { get; set; }

	/// <summary>
	/// <para>Size, in pixels, of a side of the tile. Vector tiles are square with equal sides.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("extent")]
	public int? Extent { get; set; }

	/// <summary>
	/// <para>Fields to return in the `hits` layer. Supports wildcards (`*`).<br/>This parameter does not support fields with array values. Fields with array<br/>values may return inconsistent results.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fields")]
	[JsonConverter(typeof(SingleOrManyFieldsConverter))]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

	/// <summary>
	/// <para>Aggregation used to create a grid for the `field`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("grid_agg")]
	public Elastic.Clients.Elasticsearch.Core.SearchMvt.GridAggregationType? GridAgg { get; set; }

	/// <summary>
	/// <para>Additional zoom levels available through the aggs layer. For example, if <zoom> is 7<br/>and grid_precision is 8, you can zoom in up to level 15. Accepts 0-8. If 0, results<br/>don’t include the aggs layer.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("grid_precision")]
	public int? GridPrecision { get; set; }

	/// <summary>
	/// <para>Determines the geometry type for features in the aggs layer. In the aggs layer,<br/>each feature represents a geotile_grid cell. If 'grid' each feature is a Polygon<br/>of the cells bounding box. If 'point' each feature is a Point that is the centroid<br/>of the cell.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("grid_type")]
	public Elastic.Clients.Elasticsearch.Core.SearchMvt.GridType? GridType { get; set; }

	/// <summary>
	/// <para>Query DSL used to filter documents for the search.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Query { get; set; }

	/// <summary>
	/// <para>Defines one or more runtime fields in the search request. These fields take<br/>precedence over mapped fields with the same name.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("runtime_mappings")]
	public IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappings { get; set; }

	/// <summary>
	/// <para>Maximum number of features to return in the hits layer. Accepts 0-10000.<br/>If 0, results don’t include the hits layer.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }

	/// <summary>
	/// <para>Sorts features in the hits layer. By default, the API calculates a bounding<br/>box for each feature. It sorts features based on this box’s diagonal length,<br/>from longest to shortest.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sort")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.SortOptions))]
	public ICollection<Elastic.Clients.Elasticsearch.SortOptions>? Sort { get; set; }

	/// <summary>
	/// <para>Number of hits matching the query to count accurately. If `true`, the exact number<br/>of hits is returned at the cost of some performance. If `false`, the response does<br/>not include the total number of hits matching the query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("track_total_hits")]
	public Elastic.Clients.Elasticsearch.Core.Search.TrackHits? TrackTotalHits { get; set; }

	/// <summary>
	/// <para>If `true`, the hits and aggs layers will contain additional point features representing<br/>suggested label positions for the original features.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("with_labels")]
	public bool? WithLabels { get; set; }
}

/// <summary>
/// <para>Searches a vector tile for geospatial values. Returns results as a binary Mapbox vector tile.</para>
/// </summary>
public sealed partial class SearchMvtRequestDescriptor<TDocument> : RequestDescriptor<SearchMvtRequestDescriptor<TDocument>, SearchMvtRequestParameters>
{
	internal SearchMvtRequestDescriptor(Action<SearchMvtRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SearchMvtRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Field field, int zoom, int x, int y) : base(r => r.Required("index", indices).Required("field", field).Required("zoom", zoom).Required("x", x).Required("y", y))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceSearchMvt;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "search_mvt";

	public SearchMvtRequestDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		RouteValues.Required("field", field);
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> x(int x)
	{
		RouteValues.Required("x", x);
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> y(int y)
	{
		RouteValues.Required("y", y);
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> Zoom(int zoom)
	{
		RouteValues.Required("zoom", zoom);
		return Self;
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> AggsValue { get; set; }
	private int? BufferValue { get; set; }
	private bool? ExactBoundsValue { get; set; }
	private int? ExtentValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.SearchMvt.GridAggregationType? GridAggValue { get; set; }
	private int? GridPrecisionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.SearchMvt.GridType? GridTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>> RuntimeMappingsValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.TrackHits? TrackTotalHitsValue { get; set; }
	private bool? WithLabelsValue { get; set; }

	/// <summary>
	/// <para>Sub-aggregations for the geotile_grid.</para>
	/// <para>Supports the following aggregation types:<br/>- avg<br/>- cardinality<br/>- max<br/>- min<br/>- sum</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> Aggs(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>>> selector)
	{
		AggsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>Size, in pixels, of a clipping buffer outside the tile. This allows renderers<br/>to avoid outline artifacts from geometries that extend past the extent of the tile.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> Buffer(int? buffer)
	{
		BufferValue = buffer;
		return Self;
	}

	/// <summary>
	/// <para>If false, the meta layer’s feature is the bounding box of the tile.<br/>If true, the meta layer’s feature is a bounding box resulting from a<br/>geo_bounds aggregation. The aggregation runs on <field> values that intersect<br/>the <zoom>/<x>/<y> tile with wrap_longitude set to false. The resulting<br/>bounding box may be larger than the vector tile.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> ExactBounds(bool? exactBounds = true)
	{
		ExactBoundsValue = exactBounds;
		return Self;
	}

	/// <summary>
	/// <para>Size, in pixels, of a side of the tile. Vector tiles are square with equal sides.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> Extent(int? extent)
	{
		ExtentValue = extent;
		return Self;
	}

	/// <summary>
	/// <para>Fields to return in the `hits` layer. Supports wildcards (`*`).<br/>This parameter does not support fields with array values. Fields with array<br/>values may return inconsistent results.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Aggregation used to create a grid for the `field`.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> GridAgg(Elastic.Clients.Elasticsearch.Core.SearchMvt.GridAggregationType? gridAgg)
	{
		GridAggValue = gridAgg;
		return Self;
	}

	/// <summary>
	/// <para>Additional zoom levels available through the aggs layer. For example, if <zoom> is 7<br/>and grid_precision is 8, you can zoom in up to level 15. Accepts 0-8. If 0, results<br/>don’t include the aggs layer.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> GridPrecision(int? gridPrecision)
	{
		GridPrecisionValue = gridPrecision;
		return Self;
	}

	/// <summary>
	/// <para>Determines the geometry type for features in the aggs layer. In the aggs layer,<br/>each feature represents a geotile_grid cell. If 'grid' each feature is a Polygon<br/>of the cells bounding box. If 'point' each feature is a Point that is the centroid<br/>of the cell.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> GridType(Elastic.Clients.Elasticsearch.Core.SearchMvt.GridType? gridType)
	{
		GridTypeValue = gridType;
		return Self;
	}

	/// <summary>
	/// <para>Query DSL used to filter documents for the search.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Defines one or more runtime fields in the search request. These fields take<br/>precedence over mapped fields with the same name.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> RuntimeMappings(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of features to return in the hits layer. Accepts 0-10000.<br/>If 0, results don’t include the hits layer.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>Sorts features in the hits layer. By default, the API calculates a bounding<br/>box for each feature. It sorts features based on this box’s diagonal length,<br/>from longest to shortest.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public SearchMvtRequestDescriptor<TDocument> Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Number of hits matching the query to count accurately. If `true`, the exact number<br/>of hits is returned at the cost of some performance. If `false`, the response does<br/>not include the total number of hits matching the query.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> TrackTotalHits(Elastic.Clients.Elasticsearch.Core.Search.TrackHits? trackTotalHits)
	{
		TrackTotalHitsValue = trackTotalHits;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the hits and aggs layers will contain additional point features representing<br/>suggested label positions for the original features.</para>
	/// </summary>
	public SearchMvtRequestDescriptor<TDocument> WithLabels(bool? withLabels = true)
	{
		WithLabelsValue = withLabels;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AggsValue is not null)
		{
			writer.WritePropertyName("aggs");
			JsonSerializer.Serialize(writer, AggsValue, options);
		}

		if (BufferValue.HasValue)
		{
			writer.WritePropertyName("buffer");
			writer.WriteNumberValue(BufferValue.Value);
		}

		if (ExactBoundsValue.HasValue)
		{
			writer.WritePropertyName("exact_bounds");
			writer.WriteBooleanValue(ExactBoundsValue.Value);
		}

		if (ExtentValue.HasValue)
		{
			writer.WritePropertyName("extent");
			writer.WriteNumberValue(ExtentValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (GridAggValue is not null)
		{
			writer.WritePropertyName("grid_agg");
			JsonSerializer.Serialize(writer, GridAggValue, options);
		}

		if (GridPrecisionValue.HasValue)
		{
			writer.WritePropertyName("grid_precision");
			writer.WriteNumberValue(GridPrecisionValue.Value);
		}

		if (GridTypeValue is not null)
		{
			writer.WritePropertyName("grid_type");
			JsonSerializer.Serialize(writer, GridTypeValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
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

		if (TrackTotalHitsValue is not null)
		{
			writer.WritePropertyName("track_total_hits");
			JsonSerializer.Serialize(writer, TrackTotalHitsValue, options);
		}

		if (WithLabelsValue.HasValue)
		{
			writer.WritePropertyName("with_labels");
			writer.WriteBooleanValue(WithLabelsValue.Value);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Searches a vector tile for geospatial values. Returns results as a binary Mapbox vector tile.</para>
/// </summary>
public sealed partial class SearchMvtRequestDescriptor : RequestDescriptor<SearchMvtRequestDescriptor, SearchMvtRequestParameters>
{
	internal SearchMvtRequestDescriptor(Action<SearchMvtRequestDescriptor> configure) => configure.Invoke(this);

	public SearchMvtRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Field field, int zoom, int x, int y) : base(r => r.Required("index", indices).Required("field", field).Required("zoom", zoom).Required("x", x).Required("y", y))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceSearchMvt;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "search_mvt";

	public SearchMvtRequestDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		RouteValues.Required("field", field);
		return Self;
	}

	public SearchMvtRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	public SearchMvtRequestDescriptor x(int x)
	{
		RouteValues.Required("x", x);
		return Self;
	}

	public SearchMvtRequestDescriptor y(int y)
	{
		RouteValues.Required("y", y);
		return Self;
	}

	public SearchMvtRequestDescriptor Zoom(int zoom)
	{
		RouteValues.Required("zoom", zoom);
		return Self;
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> AggsValue { get; set; }
	private int? BufferValue { get; set; }
	private bool? ExactBoundsValue { get; set; }
	private int? ExtentValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.SearchMvt.GridAggregationType? GridAggValue { get; set; }
	private int? GridPrecisionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.SearchMvt.GridType? GridTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor> RuntimeMappingsValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] SortDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.TrackHits? TrackTotalHitsValue { get; set; }
	private bool? WithLabelsValue { get; set; }

	/// <summary>
	/// <para>Sub-aggregations for the geotile_grid.</para>
	/// <para>Supports the following aggregation types:<br/>- avg<br/>- cardinality<br/>- max<br/>- min<br/>- sum</para>
	/// </summary>
	public SearchMvtRequestDescriptor Aggs(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor>> selector)
	{
		AggsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>Size, in pixels, of a clipping buffer outside the tile. This allows renderers<br/>to avoid outline artifacts from geometries that extend past the extent of the tile.</para>
	/// </summary>
	public SearchMvtRequestDescriptor Buffer(int? buffer)
	{
		BufferValue = buffer;
		return Self;
	}

	/// <summary>
	/// <para>If false, the meta layer’s feature is the bounding box of the tile.<br/>If true, the meta layer’s feature is a bounding box resulting from a<br/>geo_bounds aggregation. The aggregation runs on <field> values that intersect<br/>the <zoom>/<x>/<y> tile with wrap_longitude set to false. The resulting<br/>bounding box may be larger than the vector tile.</para>
	/// </summary>
	public SearchMvtRequestDescriptor ExactBounds(bool? exactBounds = true)
	{
		ExactBoundsValue = exactBounds;
		return Self;
	}

	/// <summary>
	/// <para>Size, in pixels, of a side of the tile. Vector tiles are square with equal sides.</para>
	/// </summary>
	public SearchMvtRequestDescriptor Extent(int? extent)
	{
		ExtentValue = extent;
		return Self;
	}

	/// <summary>
	/// <para>Fields to return in the `hits` layer. Supports wildcards (`*`).<br/>This parameter does not support fields with array values. Fields with array<br/>values may return inconsistent results.</para>
	/// </summary>
	public SearchMvtRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Aggregation used to create a grid for the `field`.</para>
	/// </summary>
	public SearchMvtRequestDescriptor GridAgg(Elastic.Clients.Elasticsearch.Core.SearchMvt.GridAggregationType? gridAgg)
	{
		GridAggValue = gridAgg;
		return Self;
	}

	/// <summary>
	/// <para>Additional zoom levels available through the aggs layer. For example, if <zoom> is 7<br/>and grid_precision is 8, you can zoom in up to level 15. Accepts 0-8. If 0, results<br/>don’t include the aggs layer.</para>
	/// </summary>
	public SearchMvtRequestDescriptor GridPrecision(int? gridPrecision)
	{
		GridPrecisionValue = gridPrecision;
		return Self;
	}

	/// <summary>
	/// <para>Determines the geometry type for features in the aggs layer. In the aggs layer,<br/>each feature represents a geotile_grid cell. If 'grid' each feature is a Polygon<br/>of the cells bounding box. If 'point' each feature is a Point that is the centroid<br/>of the cell.</para>
	/// </summary>
	public SearchMvtRequestDescriptor GridType(Elastic.Clients.Elasticsearch.Core.SearchMvt.GridType? gridType)
	{
		GridTypeValue = gridType;
		return Self;
	}

	/// <summary>
	/// <para>Query DSL used to filter documents for the search.</para>
	/// </summary>
	public SearchMvtRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public SearchMvtRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public SearchMvtRequestDescriptor Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Defines one or more runtime fields in the search request. These fields take<br/>precedence over mapped fields with the same name.</para>
	/// </summary>
	public SearchMvtRequestDescriptor RuntimeMappings(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of features to return in the hits layer. Accepts 0-10000.<br/>If 0, results don’t include the hits layer.</para>
	/// </summary>
	public SearchMvtRequestDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>Sorts features in the hits layer. By default, the API calculates a bounding<br/>box for each feature. It sorts features based on this box’s diagonal length,<br/>from longest to shortest.</para>
	/// </summary>
	public SearchMvtRequestDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public SearchMvtRequestDescriptor Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public SearchMvtRequestDescriptor Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public SearchMvtRequestDescriptor Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Number of hits matching the query to count accurately. If `true`, the exact number<br/>of hits is returned at the cost of some performance. If `false`, the response does<br/>not include the total number of hits matching the query.</para>
	/// </summary>
	public SearchMvtRequestDescriptor TrackTotalHits(Elastic.Clients.Elasticsearch.Core.Search.TrackHits? trackTotalHits)
	{
		TrackTotalHitsValue = trackTotalHits;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the hits and aggs layers will contain additional point features representing<br/>suggested label positions for the original features.</para>
	/// </summary>
	public SearchMvtRequestDescriptor WithLabels(bool? withLabels = true)
	{
		WithLabelsValue = withLabels;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AggsValue is not null)
		{
			writer.WritePropertyName("aggs");
			JsonSerializer.Serialize(writer, AggsValue, options);
		}

		if (BufferValue.HasValue)
		{
			writer.WritePropertyName("buffer");
			writer.WriteNumberValue(BufferValue.Value);
		}

		if (ExactBoundsValue.HasValue)
		{
			writer.WritePropertyName("exact_bounds");
			writer.WriteBooleanValue(ExactBoundsValue.Value);
		}

		if (ExtentValue.HasValue)
		{
			writer.WritePropertyName("extent");
			writer.WriteNumberValue(ExtentValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (GridAggValue is not null)
		{
			writer.WritePropertyName("grid_agg");
			JsonSerializer.Serialize(writer, GridAggValue, options);
		}

		if (GridPrecisionValue.HasValue)
		{
			writer.WritePropertyName("grid_precision");
			writer.WriteNumberValue(GridPrecisionValue.Value);
		}

		if (GridTypeValue is not null)
		{
			writer.WritePropertyName("grid_type");
			JsonSerializer.Serialize(writer, GridTypeValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
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

		if (TrackTotalHitsValue is not null)
		{
			writer.WritePropertyName("track_total_hits");
			JsonSerializer.Serialize(writer, TrackTotalHitsValue, options);
		}

		if (WithLabelsValue.HasValue)
		{
			writer.WritePropertyName("with_labels");
			writer.WriteBooleanValue(WithLabelsValue.Value);
		}

		writer.WriteEndObject();
	}
}