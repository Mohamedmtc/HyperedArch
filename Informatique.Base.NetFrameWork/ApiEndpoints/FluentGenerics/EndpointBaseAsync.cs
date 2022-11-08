using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;


namespace Ardalis.ApiEndpoints
{
    public static class EndpointBaseAsync
    {
        public static class WithRequest<TRequest>
        {
            public abstract class WithResult<TResponse> : EndpointBase
            {
                public abstract Task<TResponse> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }

            public abstract class WithoutResult : EndpointBase
            {
                public abstract Task HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }

            public abstract class WithActionResult<TResponse> : EndpointBase
            {
                public abstract Task<IHttpActionResult> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }

            public abstract class WithActionResult : EndpointBase
            {
                public abstract Task<IHttpActionResult> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithAsyncEnumerableResult<T> : EndpointBase
            {
                public abstract IAsyncEnumerable<T> HandleAsync(
                  TRequest request,
                  CancellationToken cancellationToken = default
                );
            }
        }

        public static class WithoutRequest
        {
            public abstract class WithResult<TResponse> : EndpointBase
            {
                public abstract Task<TResponse> HandleAsync(
                    CancellationToken cancellationToken = default
                );
            }

            public abstract class WithoutResult : EndpointBase
            {
                public abstract Task HandleAsync(
                    CancellationToken cancellationToken = default
                );
            }

            public abstract class WithActionResult<TResponse> : EndpointBase
            {
                public abstract Task<IHttpActionResult> HandleAsync(
                    CancellationToken cancellationToken = default
                );
            }

            public abstract class WithActionResult : EndpointBase
            {
                public abstract Task<IHttpActionResult> HandleAsync(
                    CancellationToken cancellationToken = default
                );
            }

            public abstract class WithAsyncEnumerableResult<T> : EndpointBase
            {
                public abstract IAsyncEnumerable<T> HandleAsync(
                  CancellationToken cancellationToken = default
                );
            }
        }
    }
}
