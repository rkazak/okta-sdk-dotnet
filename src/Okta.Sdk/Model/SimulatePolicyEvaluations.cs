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
    /// SimulatePolicyEvaluations
    /// </summary>
    [DataContract(Name = "SimulatePolicyEvaluations")]
    
    public partial class SimulatePolicyEvaluations : IEquatable<SimulatePolicyEvaluations>
    {
        /// <summary>
        /// The result of this entity evaluation
        /// </summary>
        /// <value>The result of this entity evaluation</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class StatusEnum : StringEnum
        {
            /// <summary>
            /// StringEnum MATCH for value: MATCH
            /// </summary>
            
            public static StatusEnum MATCH = new StatusEnum("MATCH");

            /// <summary>
            /// StringEnum NOTMATCH for value: NOT_MATCH
            /// </summary>
            
            public static StatusEnum NOTMATCH = new StatusEnum("NOT_MATCH");

            /// <summary>
            /// StringEnum UNDEFINED for value: UNDEFINED
            /// </summary>
            
            public static StatusEnum UNDEFINED = new StatusEnum("UNDEFINED");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator StatusEnum(string value) => new StatusEnum(value);

            /// <summary>
            /// Creates a new <see cref="Status"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public StatusEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// The result of this entity evaluation
        /// </summary>
        /// <value>The result of this entity evaluation</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Evaluated
        /// </summary>
        [DataMember(Name = "evaluated", EmitDefaultValue = true)]
        public SimulatePolicyEvaluationsEvaluated Evaluated { get; set; }

        /// <summary>
        /// The policy type of the simulate operation
        /// </summary>
        /// <value>The policy type of the simulate operation</value>
        [DataMember(Name = "policyType", EmitDefaultValue = true)]
        public List<PolicyType> PolicyType { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public SimulatePolicyResult Result { get; set; }

        /// <summary>
        /// Gets or Sets Undefined
        /// </summary>
        [DataMember(Name = "undefined", EmitDefaultValue = true)]
        public SimulatePolicyEvaluationsUndefined Undefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimulatePolicyEvaluations {\n");
            sb.Append("  Evaluated: ").Append(Evaluated).Append("\n");
            sb.Append("  PolicyType: ").Append(PolicyType).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Undefined: ").Append(Undefined).Append("\n");
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
            return this.Equals(input as SimulatePolicyEvaluations);
        }

        /// <summary>
        /// Returns true if SimulatePolicyEvaluations instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulatePolicyEvaluations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulatePolicyEvaluations input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Evaluated == input.Evaluated ||
                    (this.Evaluated != null &&
                    this.Evaluated.Equals(input.Evaluated))
                ) && 
                (
                    this.PolicyType == input.PolicyType ||
                    this.PolicyType != null &&
                    input.PolicyType != null &&
                    this.PolicyType.SequenceEqual(input.PolicyType)
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Undefined == input.Undefined ||
                    (this.Undefined != null &&
                    this.Undefined.Equals(input.Undefined))
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
                
                if (this.Evaluated != null)
                {
                    hashCode = (hashCode * 59) + this.Evaluated.GetHashCode();
                }
                if (this.PolicyType != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyType.GetHashCode();
                }
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Undefined != null)
                {
                    hashCode = (hashCode * 59) + this.Undefined.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
