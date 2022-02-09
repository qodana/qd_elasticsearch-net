// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using Tests.Core.Extensions;

namespace Tests.Core.Serialization
{
	public class RoundTripResult<T> : DeserializationResult<T>
	{
		public int Iterations { get; set; }

		public override string ToString()
		{
			var s = $"RoundTrip: {Iterations.ToOrdinal()} iteration";
			s += Environment.NewLine;
			s += base.ToString();
			return s;
		}
	}
}
