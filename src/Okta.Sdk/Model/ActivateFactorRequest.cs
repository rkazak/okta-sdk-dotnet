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
    /// ActivateFactorRequest
    /// </summary>
    [DataContract(Name = "ActivateFactorRequest")]
    
    public partial class ActivateFactorRequest : IEquatable<ActivateFactorRequest>
    {
        
        /// <summary>
        /// Gets or Sets Attestation
        /// </summary>
        [DataMember(Name = "attestation", EmitDefaultValue = true)]
        public string Attestation { get; set; }

        /// <summary>
        /// Gets or Sets ClientData
        /// </summary>
        [DataMember(Name = "clientData", EmitDefaultValue = true)]
        public string ClientData { get; set; }

        /// <summary>
        /// Gets or Sets PassCode
        /// </summary>
        [DataMember(Name = "passCode", EmitDefaultValue = true)]
        public string PassCode { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationData
        /// </summary>
        [DataMember(Name = "registrationData", EmitDefaultValue = true)]
        public string RegistrationData { get; set; }

        /// <summary>
        /// Gets or Sets StateToken
        /// </summary>
        [DataMember(Name = "stateToken", EmitDefaultValue = true)]
        public string StateToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivateFactorRequest {\n");
            sb.Append("  Attestation: ").Append(Attestation).Append("\n");
            sb.Append("  ClientData: ").Append(ClientData).Append("\n");
            sb.Append("  PassCode: ").Append(PassCode).Append("\n");
            sb.Append("  RegistrationData: ").Append(RegistrationData).Append("\n");
            sb.Append("  StateToken: ").Append(StateToken).Append("\n");
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
            return this.Equals(input as ActivateFactorRequest);
        }

        /// <summary>
        /// Returns true if ActivateFactorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivateFactorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivateFactorRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attestation == input.Attestation ||
                    (this.Attestation != null &&
                    this.Attestation.Equals(input.Attestation))
                ) && 
                (
                    this.ClientData == input.ClientData ||
                    (this.ClientData != null &&
                    this.ClientData.Equals(input.ClientData))
                ) && 
                (
                    this.PassCode == input.PassCode ||
                    (this.PassCode != null &&
                    this.PassCode.Equals(input.PassCode))
                ) && 
                (
                    this.RegistrationData == input.RegistrationData ||
                    (this.RegistrationData != null &&
                    this.RegistrationData.Equals(input.RegistrationData))
                ) && 
                (
                    this.StateToken == input.StateToken ||
                    (this.StateToken != null &&
                    this.StateToken.Equals(input.StateToken))
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
                
                if (this.Attestation != null)
                {
                    hashCode = (hashCode * 59) + this.Attestation.GetHashCode();
                }
                if (this.ClientData != null)
                {
                    hashCode = (hashCode * 59) + this.ClientData.GetHashCode();
                }
                if (this.PassCode != null)
                {
                    hashCode = (hashCode * 59) + this.PassCode.GetHashCode();
                }
                if (this.RegistrationData != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationData.GetHashCode();
                }
                if (this.StateToken != null)
                {
                    hashCode = (hashCode * 59) + this.StateToken.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
