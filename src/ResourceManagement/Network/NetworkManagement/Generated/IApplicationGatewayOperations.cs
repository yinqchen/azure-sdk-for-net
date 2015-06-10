// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Network Resource Provider API includes operations managing the
    /// application gateways for your subscription.
    /// </summary>
    public partial interface IApplicationGatewayOperations
    {
        /// <summary>
        /// The Put ApplicationGateway operation creates/updates a
        /// ApplicationGateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the ApplicationGateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create/delete ApplicationGateway
        /// operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response of Put ApplicationGateway operation
        /// </returns>
        Task<ApplicationGatewayPutResponse> BeginCreateOrUpdatingAsync(string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The delete applicationgateway operation deletes the specified
        /// applicationgateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the applicationgateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        Task<UpdateOperationResponse> BeginDeletingAsync(string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Start ApplicationGateway operation starts application gatewayin
        /// the specified resource group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the application gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworkGateway Api servive call
        /// </returns>
        Task<VirtualNetworkGatewayPutResponse> BeginStartAsync(string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The STOP ApplicationGateway operation stops application gatewayin
        /// the specified resource group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the application gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for PutVirtualNetworkGateway Api servive call
        /// </returns>
        Task<VirtualNetworkGatewayPutResponse> BeginStopAsync(string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Put ApplicationGateway operation creates/updates a
        /// ApplicationGateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the ApplicationGateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create/update ApplicationGateway
        /// operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the applicationgateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get applicationgateway operation retreives information about
        /// the specified applicationgateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the applicationgateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response of a GET ApplicationGateway operation
        /// </returns>
        Task<ApplicationGatewayGetResponse> GetAsync(string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List ApplicationGateway opertion retrieves all the
        /// applicationgateways in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for ListLoadBalancers Api service call
        /// </returns>
        Task<ApplicationGatewayListResponse> ListAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List applicationgateway opertion retrieves all the
        /// applicationgateways in a subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for ListLoadBalancers Api service call
        /// </returns>
        Task<ApplicationGatewayListResponse> ListAllAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// The Start ApplicationGateway operation starts application gatewayin
        /// the specified resource group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the application gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> StartAsync(string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The STOP ApplicationGateway operation stops application gatewayin
        /// the specified resource group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='applicationGatewayName'>
        /// The name of the application gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> StopAsync(string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken);
    }
}
