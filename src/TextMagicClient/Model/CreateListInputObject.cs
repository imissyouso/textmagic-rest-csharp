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
    /// CreateListInputObject
    /// </summary>
    [DataContract]
    public partial class CreateListInputObject :  IEquatable<CreateListInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateListInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateListInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateListInputObject" /> class.
        /// </summary>
        /// <param name="name">List name (required).</param>
        /// <param name="shared">Should this list be shared with sub-accounts (required).</param>
        /// <param name="favorited">Is list favorited. Default is false (default to false).</param>
        /// <param name="isDefault">Is list default for new contacts (web only). (default to false).</param>
        public CreateListInputObject(string name = default(string), bool? shared = default(bool?), bool? favorited = false, bool? isDefault = false)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateListInputObject and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "shared" is required (not null)
            if (shared == null)
            {
                throw new InvalidDataException("shared is a required property for CreateListInputObject and cannot be null");
            }
            else
            {
                this.Shared = shared;
            }
            // use default value if no "favorited" provided
            if (favorited == null)
            {
                this.Favorited = false;
            }
            else
            {
                this.Favorited = favorited;
            }
            // use default value if no "isDefault" provided
            if (isDefault == null)
            {
                this.IsDefault = false;
            }
            else
            {
                this.IsDefault = isDefault;
            }
        }
        
        /// <summary>
        /// List name
        /// </summary>
        /// <value>List name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Should this list be shared with sub-accounts
        /// </summary>
        /// <value>Should this list be shared with sub-accounts</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public bool? Shared { get; set; }

        /// <summary>
        /// Is list favorited. Default is false
        /// </summary>
        /// <value>Is list favorited. Default is false</value>
        [DataMember(Name="favorited", EmitDefaultValue=false)]
        public bool? Favorited { get; set; }

        /// <summary>
        /// Is list default for new contacts (web only).
        /// </summary>
        /// <value>Is list default for new contacts (web only).</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListInputObject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Favorited: ").Append(Favorited).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
            return this.Equals(input as CreateListInputObject);
        }

        /// <summary>
        /// Returns true if CreateListInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateListInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateListInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Shared == input.Shared ||
                    (this.Shared != null &&
                    this.Shared.Equals(input.Shared))
                ) && 
                (
                    this.Favorited == input.Favorited ||
                    (this.Favorited != null &&
                    this.Favorited.Equals(input.Favorited))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Shared != null)
                    hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.Favorited != null)
                    hashCode = hashCode * 59 + this.Favorited.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
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
