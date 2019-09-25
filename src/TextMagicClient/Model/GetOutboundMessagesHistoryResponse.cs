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
    /// GetOutboundMessagesHistoryResponse
    /// </summary>
    [DataContract]
    public partial class GetOutboundMessagesHistoryResponse :  IEquatable<GetOutboundMessagesHistoryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOutboundMessagesHistoryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetOutboundMessagesHistoryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOutboundMessagesHistoryResponse" /> class.
        /// </summary>
        /// <param name="lastId">lastId (required).</param>
        /// <param name="nextLastId">nextLastId (required).</param>
        /// <param name="limit">limit (required).</param>
        /// <param name="resources">resources (required).</param>
        public GetOutboundMessagesHistoryResponse(int? lastId = default(int?), int? nextLastId = default(int?), int? limit = default(int?), List<MessageOut> resources = default(List<MessageOut>))
        {
            // to ensure "lastId" is required (not null)
            if (lastId == null)
            {
                throw new InvalidDataException("lastId is a required property for GetOutboundMessagesHistoryResponse and cannot be null");
            }
            else
            {
                this.LastId = lastId;
            }
            // to ensure "nextLastId" is required (not null)
            if (nextLastId == null)
            {
                throw new InvalidDataException("nextLastId is a required property for GetOutboundMessagesHistoryResponse and cannot be null");
            }
            else
            {
                this.NextLastId = nextLastId;
            }
            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for GetOutboundMessagesHistoryResponse and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new InvalidDataException("resources is a required property for GetOutboundMessagesHistoryResponse and cannot be null");
            }
            else
            {
                this.Resources = resources;
            }
        }
        
        /// <summary>
        /// Gets or Sets LastId
        /// </summary>
        [DataMember(Name="lastId", EmitDefaultValue=false)]
        public int? LastId { get; set; }

        /// <summary>
        /// Gets or Sets NextLastId
        /// </summary>
        [DataMember(Name="nextLastId", EmitDefaultValue=false)]
        public int? NextLastId { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<MessageOut> Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOutboundMessagesHistoryResponse {\n");
            sb.Append("  LastId: ").Append(LastId).Append("\n");
            sb.Append("  NextLastId: ").Append(NextLastId).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as GetOutboundMessagesHistoryResponse);
        }

        /// <summary>
        /// Returns true if GetOutboundMessagesHistoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOutboundMessagesHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOutboundMessagesHistoryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastId == input.LastId ||
                    (this.LastId != null &&
                    this.LastId.Equals(input.LastId))
                ) && 
                (
                    this.NextLastId == input.NextLastId ||
                    (this.NextLastId != null &&
                    this.NextLastId.Equals(input.NextLastId))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.LastId != null)
                    hashCode = hashCode * 59 + this.LastId.GetHashCode();
                if (this.NextLastId != null)
                    hashCode = hashCode * 59 + this.NextLastId.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
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
