/* 
 * TextMagic API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * 
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
    /// UpdatePasswordInputObject
    /// </summary>
    [DataContract]
    public partial class UpdatePasswordInputObject :  IEquatable<UpdatePasswordInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePasswordInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordInputObject" /> class.
        /// </summary>
        /// <param name="oldPassword">Current password (required).</param>
        /// <param name="newPassword">New password (required).</param>
        public UpdatePasswordInputObject(string oldPassword = default(string), string newPassword = default(string))
        {
            // to ensure "oldPassword" is required (not null)
            if (oldPassword == null)
            {
                throw new InvalidDataException("oldPassword is a required property for UpdatePasswordInputObject and cannot be null");
            }
            else
            {
                this.OldPassword = oldPassword;
            }
            // to ensure "newPassword" is required (not null)
            if (newPassword == null)
            {
                throw new InvalidDataException("newPassword is a required property for UpdatePasswordInputObject and cannot be null");
            }
            else
            {
                this.NewPassword = newPassword;
            }
        }
        
        /// <summary>
        /// Current password
        /// </summary>
        /// <value>Current password</value>
        [DataMember(Name="oldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// New password
        /// </summary>
        /// <value>New password</value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordInputObject {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return this.Equals(input as UpdatePasswordInputObject);
        }

        /// <summary>
        /// Returns true if UpdatePasswordInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePasswordInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePasswordInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
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
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
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
