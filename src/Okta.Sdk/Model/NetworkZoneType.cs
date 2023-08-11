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
    /// The type of network zone
    /// </summary>
    /// <value>The type of network zone</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class NetworkZoneType : StringEnum
    {
        /// <summary>
        /// StringEnum NetworkZoneType for value: DYNAMIC
        /// </summary>
        public static NetworkZoneType DYNAMIC = new NetworkZoneType("DYNAMIC");
        /// <summary>
        /// StringEnum NetworkZoneType for value: IP
        /// </summary>
        public static NetworkZoneType IP = new NetworkZoneType("IP");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="NetworkZoneType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator NetworkZoneType(string value) => new NetworkZoneType(value);

        /// <summary>
        /// Creates a new <see cref="NetworkZoneType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public NetworkZoneType(string value)
            : base(value)
        {
        }
    }


}
