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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Represents the attestation strength used by the Chrome Verified Access API
    /// </summary>
    /// <value>Represents the attestation strength used by the Chrome Verified Access API</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class KeyTrustLevelBrowserKey : StringEnum
    {
        /// <summary>
        /// StringEnum KeyTrustLevelBrowserKey for value: CHROME_BROWSER_HW_KEY
        /// </summary>
        public static KeyTrustLevelBrowserKey HWKEY = new KeyTrustLevelBrowserKey("CHROME_BROWSER_HW_KEY");
        /// <summary>
        /// StringEnum KeyTrustLevelBrowserKey for value: CHROME_BROWSER_OS_KEY
        /// </summary>
        public static KeyTrustLevelBrowserKey OSKEY = new KeyTrustLevelBrowserKey("CHROME_BROWSER_OS_KEY");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="KeyTrustLevelBrowserKey"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator KeyTrustLevelBrowserKey(string value) => new KeyTrustLevelBrowserKey(value);

        /// <summary>
        /// Creates a new <see cref="KeyTrustLevelBrowserKey"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public KeyTrustLevelBrowserKey(string value)
            : base(value)
        {
        }
    }


}
