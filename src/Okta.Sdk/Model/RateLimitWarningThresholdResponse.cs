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
    /// Template: ModelGeneric
    /// RateLimitWarningThresholdResponse
    /// </summary>
    [DataContract(Name = "RateLimitWarningThresholdResponse")]
    
    public partial class RateLimitWarningThresholdResponse : IEquatable<RateLimitWarningThresholdResponse>
    {
        
        /// <summary>
        /// The threshold value (percentage) of a rate limit that, when exceeded, triggers a warning notification. By default, this value is 90 for Workforce orgs and 60 for CIAM orgs.
        /// </summary>
        /// <value>The threshold value (percentage) of a rate limit that, when exceeded, triggers a warning notification. By default, this value is 90 for Workforce orgs and 60 for CIAM orgs.</value>
        [DataMember(Name = "warningThreshold", EmitDefaultValue = true)]
        public int WarningThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RateLimitWarningThresholdResponse {\n");
            sb.Append("  WarningThreshold: ").Append(WarningThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RateLimitWarningThresholdResponse);
        }

        /// <summary>
        /// Returns true if RateLimitWarningThresholdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RateLimitWarningThresholdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateLimitWarningThresholdResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WarningThreshold == input.WarningThreshold ||
                    this.WarningThreshold.Equals(input.WarningThreshold)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                
                hashCode = (hashCode * 59) + this.WarningThreshold.GetHashCode();
                return hashCode;
            }
        }

    }

}
