// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WebApplicationApiClient
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class ActivitiesExtensions
    {
            /// <summary>
            /// Gets all activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Activity> Get(this IActivities operations)
            {
                return Task.Factory.StartNew(s => ((IActivities)s).GetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Activity>> GetAsync( this IActivities operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<IList<Activity>> result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Creates a new activity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static object Post(this IActivities operations, Activity value)
            {
                return Task.Factory.StartNew(s => ((IActivities)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new activity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostAsync( this IActivities operations, Activity value, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<object> result = await operations.PostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes an activity by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static bool? Delete(this IActivities operations, int? id)
            {
                return Task.Factory.StartNew(s => ((IActivities)s).DeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an activity by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> DeleteAsync( this IActivities operations, int? id, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<bool?> result = await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
