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
    /// CreateUserRequest
    /// </summary>
    [DataContract(Name = "CreateUserRequest")]
    
    public partial class CreateUserRequest : IEquatable<CreateUserRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateUserRequest() { }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = true)]
        public UserCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets GroupIds
        /// </summary>
        [DataMember(Name = "groupIds", EmitDefaultValue = true)]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = true)]
        public UserProfile Profile { get; set; }

        /// <summary>
        /// The ID of the realm in which the user is residing
        /// </summary>
        /// <value>The ID of the realm in which the user is residing</value>
        [DataMember(Name = "realmId", EmitDefaultValue = true)]
        public string RealmId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public UserType Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUserRequest {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  RealmId: ").Append(RealmId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateUserRequest);
        }

        /// <summary>
        /// Returns true if CreateUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    input.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.RealmId == input.RealmId ||
                    (this.RealmId != null &&
                    this.RealmId.Equals(input.RealmId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.GroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.GroupIds.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.RealmId != null)
                {
                    hashCode = (hashCode * 59) + this.RealmId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
