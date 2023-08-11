/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 5.1.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Okta.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial interface IApplicationLogosApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Upload an application Logo
        /// </summary>
        /// <remarks>
        /// Uploads a logo for the app instance. If the app already has a logo, this operation replaces the previous logo.  The logo is visible in the Admin Console as an icon for your app instance. If you have one &#x60;appLink&#x60; object configured, this logo also appears in the End-User Dashboard as an icon for your app. &gt; **Note:** If you have multiple &#x60;appLink&#x60; objects, use the Admin Console to add logos for each app link. &gt; You can&#39;t use the API to add logos for multiple app links. 
        /// </remarks>
        /// <exception cref="Okta.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the Application</param>
        /// <param name="file">The image file containing the logo.  The file must be in PNG, JPG, SVG, or GIF format, and less than one MB in size. For best results, use an image with a transparent background and a square dimension of 200 x 200 pixels to prevent upscaling. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UploadApplicationLogoAsync(  string appId ,   System.IO.Stream file , System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Upload an application Logo
        /// </summary>
        /// <remarks>
        /// Uploads a logo for the app instance. If the app already has a logo, this operation replaces the previous logo.  The logo is visible in the Admin Console as an icon for your app instance. If you have one &#x60;appLink&#x60; object configured, this logo also appears in the End-User Dashboard as an icon for your app. &gt; **Note:** If you have multiple &#x60;appLink&#x60; objects, use the Admin Console to add logos for each app link. &gt; You can&#39;t use the API to add logos for multiple app links. 
        /// </remarks>
        /// <exception cref="Okta.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the Application</param>
        /// <param name="file">The image file containing the logo.  The file must be in PNG, JPG, SVG, or GIF format, and less than one MB in size. For best results, use an image with a transparent background and a square dimension of 200 x 200 pixels to prevent upscaling. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UploadApplicationLogoWithHttpInfoAsync(  string appId ,   System.IO.Stream file , System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial interface IApplicationLogosApi :  IApplicationLogosApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationLogosApi : IApplicationLogosApi
    {
        private Okta.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
        private IOAuthTokenProvider _oAuthTokenProvider;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationLogosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <param name="oAuthTokenProvider">The access token provider to be used when the AuthorizationMode is equals to Private Key. Optional./param>
        /// <param name="webProxy">The web proxy to be used by the HTTP client. Optional./param>
        /// <returns></returns>
        public ApplicationLogosApi(Okta.Sdk.Client.Configuration configuration = null, IOAuthTokenProvider oAuthTokenProvider = null, WebProxy webProxy = null)
        {
            configuration = Sdk.Client.Configuration.GetConfigurationOrDefault(configuration);

            this.Configuration = Okta.Sdk.Client.Configuration.MergeConfigurations(
                Okta.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            
            Sdk.Client.Configuration.Validate((Configuration)this.Configuration);
            
            _oAuthTokenProvider = NullOAuthTokenProvider.Instance;
            if (Sdk.Client.Configuration.IsPrivateKeyMode(this.Configuration))
            {
                _oAuthTokenProvider = oAuthTokenProvider ?? new DefaultOAuthTokenProvider(Configuration);
            }
            
            this.AsynchronousClient = new Okta.Sdk.Client.ApiClient(this.Configuration.OktaDomain, _oAuthTokenProvider, webProxy);
            ExceptionFactory = Okta.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationLogosApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ApplicationLogosApi(Okta.Sdk.Client.IAsynchronousClient asyncClient, Okta.Sdk.Client.IReadableConfiguration configuration)
        {
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Okta.Sdk.Client.Configuration.DefaultExceptionFactory;
             _oAuthTokenProvider = NullOAuthTokenProvider.Instance;
            if (Sdk.Client.Configuration.IsPrivateKeyMode(this.Configuration))
            {
                _oAuthTokenProvider = new DefaultOAuthTokenProvider(Configuration);
            }
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Okta.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.OktaDomain;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Okta.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Okta.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }
         
        /// <summary>
        /// Upload an application Logo Uploads a logo for the app instance. If the app already has a logo, this operation replaces the previous logo.  The logo is visible in the Admin Console as an icon for your app instance. If you have one &#x60;appLink&#x60; object configured, this logo also appears in the End-User Dashboard as an icon for your app. &gt; **Note:** If you have multiple &#x60;appLink&#x60; objects, use the Admin Console to add logos for each app link. &gt; You can&#39;t use the API to add logos for multiple app links. 
        /// </summary>
        /// <exception cref="Okta.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the Application</param>
        /// <param name="file">The image file containing the logo.  The file must be in PNG, JPG, SVG, or GIF format, and less than one MB in size. For best results, use an image with a transparent background and a square dimension of 200 x 200 pixels to prevent upscaling. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UploadApplicationLogoAsync(  string appId ,   System.IO.Stream file , System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await UploadApplicationLogoWithHttpInfoAsync(appId, file, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Upload an application Logo Uploads a logo for the app instance. If the app already has a logo, this operation replaces the previous logo.  The logo is visible in the Admin Console as an icon for your app instance. If you have one &#x60;appLink&#x60; object configured, this logo also appears in the End-User Dashboard as an icon for your app. &gt; **Note:** If you have multiple &#x60;appLink&#x60; objects, use the Admin Console to add logos for each app link. &gt; You can&#39;t use the API to add logos for multiple app links. 
        /// </summary>
        /// <exception cref="Okta.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the Application</param>
        /// <param name="file">The image file containing the logo.  The file must be in PNG, JPG, SVG, or GIF format, and less than one MB in size. For best results, use an image with a transparent background and a square dimension of 200 x 200 pixels to prevent upscaling. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Okta.Sdk.Client.ApiResponse<Object>> UploadApplicationLogoWithHttpInfoAsync(  string appId ,   System.IO.Stream file , System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
            {
                throw new Okta.Sdk.Client.ApiException(400, "Missing required parameter 'appId' when calling ApplicationLogosApi->UploadApplicationLogo");
            }

            // verify the required parameter 'file' is set
            if (file == null)
            {
                throw new Okta.Sdk.Client.ApiException(400, "Missing required parameter 'file' when calling ApplicationLogosApi->UploadApplicationLogo");
            }


            Okta.Sdk.Client.RequestOptions localVarRequestOptions = new Okta.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Okta.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Okta.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("appId", Okta.Sdk.Client.ClientUtils.ParameterToString(appId)); // path parameter
            localVarRequestOptions.FileParameters.Add("file", file);

            // authentication (apiToken) required
            if (Sdk.Client.Configuration.IsSswsMode(this.Configuration) && !string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (Sdk.Client.Configuration.IsBearerTokenMode(this.Configuration) && !string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            
            if (Sdk.Client.Configuration.IsPrivateKeyMode(this.Configuration) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                var token = await _oAuthTokenProvider.GetAccessTokenAsync(cancellationToken: cancellationToken);
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + token);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/v1/apps/{appId}/logo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UploadApplicationLogo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
