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

namespace Elastic.Clients.Elasticsearch.Inference;

public sealed partial class GetModelRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Get an inference service model</para>
/// </summary>
public sealed partial class GetModelRequest : PlainRequest<GetModelRequestParameters>
{
	public GetModelRequest(Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Required("inference_id", inferenceId))
	{
	}

	public GetModelRequest(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Optional("task_type", taskType).Required("inference_id", inferenceId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferenceGetModel;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "inference.get_model";
}

/// <summary>
/// <para>Get an inference service model</para>
/// </summary>
public sealed partial class GetModelRequestDescriptor : RequestDescriptor<GetModelRequestDescriptor, GetModelRequestParameters>
{
	internal GetModelRequestDescriptor(Action<GetModelRequestDescriptor> configure) => configure.Invoke(this);

	public GetModelRequestDescriptor(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Optional("task_type", taskType).Required("inference_id", inferenceId))
	{
	}

	public GetModelRequestDescriptor(Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Required("inference_id", inferenceId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferenceGetModel;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "inference.get_model";

	public GetModelRequestDescriptor InferenceId(Elastic.Clients.Elasticsearch.Id inferenceId)
	{
		RouteValues.Required("inference_id", inferenceId);
		return Self;
	}

	public GetModelRequestDescriptor TaskType(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType)
	{
		RouteValues.Optional("task_type", taskType);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}