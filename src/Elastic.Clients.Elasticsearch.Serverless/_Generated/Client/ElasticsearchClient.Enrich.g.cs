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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Enrich;

public partial class EnrichNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>Initializes a new instance of the <see cref="EnrichNamespacedClient"/> class for mocking.</para>
	/// </summary>
	protected EnrichNamespacedClient() : base()
	{
	}

	internal EnrichNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Deletes an existing enrich policy and its enrich index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeletePolicyRequest, DeletePolicyResponse, DeletePolicyRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an existing enrich policy and its enrich index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePolicyRequestDescriptor, DeletePolicyResponse, DeletePolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an existing enrich policy and its enrich index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePolicyResponse> DeletePolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeletePolicyRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePolicyRequestDescriptor, DeletePolicyResponse, DeletePolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an existing enrich policy and its enrich index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePolicyResponse> DeletePolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, Action<DeletePolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeletePolicyRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePolicyRequestDescriptor, DeletePolicyResponse, DeletePolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates the enrich index for an existing enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/execute-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<ExecutePolicyRequest, ExecutePolicyResponse, ExecutePolicyRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Creates the enrich index for an existing enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/execute-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<ExecutePolicyRequestDescriptor, ExecutePolicyResponse, ExecutePolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates the enrich index for an existing enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/execute-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExecutePolicyResponse> ExecutePolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, CancellationToken cancellationToken = default)
	{
		var descriptor = new ExecutePolicyRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<ExecutePolicyRequestDescriptor, ExecutePolicyResponse, ExecutePolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates the enrich index for an existing enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/execute-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExecutePolicyResponse> ExecutePolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, Action<ExecutePolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ExecutePolicyRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ExecutePolicyRequestDescriptor, ExecutePolicyResponse, ExecutePolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets information about an enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/get-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetPolicyRequest, GetPolicyResponse, GetPolicyRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Gets information about an enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/get-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPolicyRequestDescriptor, GetPolicyResponse, GetPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets information about an enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/get-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPolicyResponse> GetPolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Names? name, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPolicyRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPolicyRequestDescriptor, GetPolicyResponse, GetPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets information about an enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/get-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPolicyResponse> GetPolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Names? name, Action<GetPolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPolicyRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPolicyRequestDescriptor, GetPolicyResponse, GetPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets information about an enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/get-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPolicyResponse> GetPolicyAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPolicyRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPolicyRequestDescriptor, GetPolicyResponse, GetPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets information about an enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/get-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPolicyResponse> GetPolicyAsync(Action<GetPolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPolicyRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPolicyRequestDescriptor, GetPolicyResponse, GetPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates a new enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/put-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PutPolicyRequest, PutPolicyResponse, PutPolicyRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Creates a new enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/put-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPolicyResponse> PutPolicyAsync<TDocument>(PutPolicyRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPolicyRequestDescriptor<TDocument>, PutPolicyResponse, PutPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates a new enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/put-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPolicyResponse> PutPolicyAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Name name, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPolicyRequestDescriptor<TDocument>(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPolicyRequestDescriptor<TDocument>, PutPolicyResponse, PutPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates a new enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/put-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPolicyResponse> PutPolicyAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Name name, Action<PutPolicyRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPolicyRequestDescriptor<TDocument>(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPolicyRequestDescriptor<TDocument>, PutPolicyResponse, PutPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates a new enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/put-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPolicyRequestDescriptor, PutPolicyResponse, PutPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates a new enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/put-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPolicyResponse> PutPolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPolicyRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPolicyRequestDescriptor, PutPolicyResponse, PutPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates a new enrich policy.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/put-enrich-policy-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPolicyResponse> PutPolicyAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, Action<PutPolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPolicyRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPolicyRequestDescriptor, PutPolicyResponse, PutPolicyRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets enrich coordinator statistics and information about enrich policies that are currently executing.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-stats-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EnrichStatsResponse> StatsAsync(EnrichStatsRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<EnrichStatsRequest, EnrichStatsResponse, EnrichStatsRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Gets enrich coordinator statistics and information about enrich policies that are currently executing.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-stats-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EnrichStatsResponse> StatsAsync(EnrichStatsRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<EnrichStatsRequestDescriptor, EnrichStatsResponse, EnrichStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets enrich coordinator statistics and information about enrich policies that are currently executing.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-stats-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EnrichStatsResponse> StatsAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new EnrichStatsRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<EnrichStatsRequestDescriptor, EnrichStatsResponse, EnrichStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Gets enrich coordinator statistics and information about enrich policies that are currently executing.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-stats-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EnrichStatsResponse> StatsAsync(Action<EnrichStatsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EnrichStatsRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EnrichStatsRequestDescriptor, EnrichStatsResponse, EnrichStatsRequestParameters>(descriptor, cancellationToken);
	}
}