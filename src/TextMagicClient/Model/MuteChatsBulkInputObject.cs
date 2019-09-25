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
    /// MuteChatsBulkInputObject
    /// </summary>
    [DataContract]
    public partial class MuteChatsBulkInputObject :  IEquatable<MuteChatsBulkInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MuteChatsBulkInputObject" /> class.
        /// </summary>
        /// <param name="ids">Entity ID(s), separated by comma.</param>
        /// <param name="all">Entity ID(s), separated by comma.</param>
        /// <param name="_for">Mute for N hours.</param>
        public MuteChatsBulkInputObject(string ids = default(string), bool? all = default(bool?), int? _for = default(int?))
        {
            this.Ids = ids;
            this.All = all;
            this.For = _for;
        }
        
        /// <summary>
        /// Entity ID(s), separated by comma
        /// </summary>
        /// <value>Entity ID(s), separated by comma</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Entity ID(s), separated by comma
        /// </summary>
        /// <value>Entity ID(s), separated by comma</value>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public bool? All { get; set; }

        /// <summary>
        /// Mute for N hours
        /// </summary>
        /// <value>Mute for N hours</value>
        [DataMember(Name="for", EmitDefaultValue=false)]
        public int? For { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MuteChatsBulkInputObject {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  For: ").Append(For).Append("\n");
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
            return this.Equals(input as MuteChatsBulkInputObject);
        }

        /// <summary>
        /// Returns true if MuteChatsBulkInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MuteChatsBulkInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MuteChatsBulkInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ids == input.Ids ||
                    (this.Ids != null &&
                    this.Ids.Equals(input.Ids))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
                ) && 
                (
                    this.For == input.For ||
                    (this.For != null &&
                    this.For.Equals(input.For))
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.For != null)
                    hashCode = hashCode * 59 + this.For.GetHashCode();
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
