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
    /// Defines a list of domains with a subset of the properties for each domain.
    /// </summary>
    [DataContract(Name = "DomainListResponse")]
    
    public partial class DomainListResponse : IEquatable<DomainListResponse>
    {
        
        /// <summary>
        /// Each element of the array defines an individual domain.
        /// </summary>
        /// <value>Each element of the array defines an individual domain.</value>
        [DataMember(Name = "domains", EmitDefaultValue = true)]
        public List<DomainResponse> Domains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainListResponse {\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
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
            return this.Equals(input as DomainListResponse);
        }

        /// <summary>
        /// Returns true if DomainListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
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
                
                if (this.Domains != null)
                {
                    hashCode = (hashCode * 59) + this.Domains.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
