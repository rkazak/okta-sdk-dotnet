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
    /// Defines ProvisioningDeprovisionedAction
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class ProvisioningDeprovisionedAction : StringEnum
    {
        /// <summary>
        /// StringEnum ProvisioningDeprovisionedAction for value: NONE
        /// </summary>
        public static ProvisioningDeprovisionedAction NONE = new ProvisioningDeprovisionedAction("NONE");
        /// <summary>
        /// StringEnum ProvisioningDeprovisionedAction for value: REACTIVATE
        /// </summary>
        public static ProvisioningDeprovisionedAction REACTIVATE = new ProvisioningDeprovisionedAction("REACTIVATE");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="ProvisioningDeprovisionedAction"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator ProvisioningDeprovisionedAction(string value) => new ProvisioningDeprovisionedAction(value);

        /// <summary>
        /// Creates a new <see cref="ProvisioningDeprovisionedAction"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public ProvisioningDeprovisionedAction(string value)
            : base(value)
        {
        }
    }


}
