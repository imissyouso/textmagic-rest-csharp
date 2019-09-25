/* 
 * TextMagic API Documentation
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * Contact: support@textmagi.biz
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TextMagicClient.Client.SwaggerDateConverter;

namespace TextMagicClient.Model
{
    /// <summary>
    /// GetAvailableSenderSettingOptionsResponse
    /// </summary>
    [DataContract]
    public partial class GetAvailableSenderSettingOptionsResponse :  IEquatable<GetAvailableSenderSettingOptionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableSenderSettingOptionsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAvailableSenderSettingOptionsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableSenderSettingOptionsResponse" /> class.
        /// </summary>
        /// <param name="dedicated">dedicated (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="shared">shared (required).</param>
        /// <param name="senderIds">senderIds (required).</param>
        public GetAvailableSenderSettingOptionsResponse(List<string> dedicated = default(List<string>), List<string> user = default(List<string>), List<string> shared = default(List<string>), List<string> senderIds = default(List<string>))
        {
            // to ensure "dedicated" is required (not null)
            if (dedicated == null)
            {
                throw new InvalidDataException("dedicated is a required property for GetAvailableSenderSettingOptionsResponse and cannot be null");
            }
            else
            {
                this.Dedicated = dedicated;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for GetAvailableSenderSettingOptionsResponse and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "shared" is required (not null)
            if (shared == null)
            {
                throw new InvalidDataException("shared is a required property for GetAvailableSenderSettingOptionsResponse and cannot be null");
            }
            else
            {
                this.Shared = shared;
            }
            // to ensure "senderIds" is required (not null)
            if (senderIds == null)
            {
                throw new InvalidDataException("senderIds is a required property for GetAvailableSenderSettingOptionsResponse and cannot be null");
            }
            else
            {
                this.SenderIds = senderIds;
            }
        }
        
        /// <summary>
        /// Gets or Sets Dedicated
        /// </summary>
        [DataMember(Name="dedicated", EmitDefaultValue=false)]
        public List<string> Dedicated { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public List<string> User { get; set; }

        /// <summary>
        /// Gets or Sets Shared
        /// </summary>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public List<string> Shared { get; set; }

        /// <summary>
        /// Gets or Sets SenderIds
        /// </summary>
        [DataMember(Name="senderIds", EmitDefaultValue=false)]
        public List<string> SenderIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAvailableSenderSettingOptionsResponse {\n");
            sb.Append("  Dedicated: ").Append(Dedicated).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  SenderIds: ").Append(SenderIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetAvailableSenderSettingOptionsResponse);
        }

        /// <summary>
        /// Returns true if GetAvailableSenderSettingOptionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAvailableSenderSettingOptionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAvailableSenderSettingOptionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dedicated == input.Dedicated ||
                    this.Dedicated != null &&
                    this.Dedicated.SequenceEqual(input.Dedicated)
                ) && 
                (
                    this.User == input.User ||
                    this.User != null &&
                    this.User.SequenceEqual(input.User)
                ) && 
                (
                    this.Shared == input.Shared ||
                    this.Shared != null &&
                    this.Shared.SequenceEqual(input.Shared)
                ) && 
                (
                    this.SenderIds == input.SenderIds ||
                    this.SenderIds != null &&
                    this.SenderIds.SequenceEqual(input.SenderIds)
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
                if (this.Dedicated != null)
                    hashCode = hashCode * 59 + this.Dedicated.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Shared != null)
                    hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.SenderIds != null)
                    hashCode = hashCode * 59 + this.SenderIds.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
