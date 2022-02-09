// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using Elastic.Transport;
using Elastic.Transport.Products.Elasticsearch;

namespace Elastic.Clients.Elasticsearch;

internal sealed class ElasticsearchClientProductRegistration : ElasticsearchProductRegistration
{
	public ElasticsearchClientProductRegistration(Type markerType) : base(markerType) { }

	public static ElasticsearchClientProductRegistration DefaultForElasticsearchClientsElasticsearch { get; } = new(typeof(IElasticsearchClient));

	/// <summary>
	///     Elastic.Clients.Elasticsearch handles 404 in its <see cref="ResponseBase.IsValid" />, we do not want the low level client throwing
	///     exceptions
	///     when <see cref="ITransportConfiguration.ThrowExceptions" /> is enabled for 404's. The client is in charge of
	///     composing paths
	///     so a 404 never signals a wrong URL but a missing entity.
	/// </summary>
	public override bool HttpStatusCodeClassifier(HttpMethod method, int statusCode) =>
		statusCode is >= 200 and < 300 or 404;

	/// <summary>
	///     Makes the low level transport aware of Elastic.Clients.Elasticsearch's <see cref="ResponseBase" />
	///     so that it can peek in to its exposed error when reporting failures.
	/// </summary>
	public override bool TryGetServerErrorReason<TResponse>(TResponse response, out string? reason)
	{
		if (response is not ResponseBase r)
			return base.TryGetServerErrorReason(response, out reason);
		reason = r.ServerError?.Error?.ToString();
		return !string.IsNullOrEmpty(reason);
	}
}
