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
    /// FavoriteContact
    /// </summary>
    [DataContract]
    public partial class FavoriteContact :  IEquatable<FavoriteContact>, IValidatableObject
    {
        /// <summary>
        /// Defines EntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityTypeEnum
        {
            
            /// <summary>
            /// Enum List for value: list
            /// </summary>
            [EnumMember(Value = "list")]
            List = 1,
            
            /// <summary>
            /// Enum Contact for value: contact
            /// </summary>
            [EnumMember(Value = "contact")]
            Contact = 2
        }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FavoriteContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteContact" /> class.
        /// </summary>
        /// <param name="entityId">entityId (required).</param>
        /// <param name="entityType">entityType (required).</param>
        /// <param name="primaryLabel">Contact first name/last name if entityType is \\&#39;contact\\&#39;, List name if entity type is \\&#39;list\\&#39; (required).</param>
        /// <param name="secondaryLabel">Phone number if entityType is \\&#39;contact\\&#39;, List contacts number if entity type is \\&#39;list\\&#39; (required).</param>
        /// <param name="tertiaryLabel">Contact country if entityType is \\&#39;contact\\&#39; else null (required).</param>
        /// <param name="avatar">avatar (required).</param>
        public FavoriteContact(int? entityId = default(int?), EntityTypeEnum entityType = default(EntityTypeEnum), string primaryLabel = default(string), string secondaryLabel = default(string), string tertiaryLabel = default(string), string avatar = default(string))
        {
            // to ensure "entityId" is required (not null)
            if (entityId == null)
            {
                throw new InvalidDataException("entityId is a required property for FavoriteContact and cannot be null");
            }
            else
            {
                this.EntityId = entityId;
            }
            // to ensure "entityType" is required (not null)
            if (entityType == null)
            {
                throw new InvalidDataException("entityType is a required property for FavoriteContact and cannot be null");
            }
            else
            {
                this.EntityType = entityType;
            }
            // to ensure "primaryLabel" is required (not null)
            if (primaryLabel == null)
            {
                throw new InvalidDataException("primaryLabel is a required property for FavoriteContact and cannot be null");
            }
            else
            {
                this.PrimaryLabel = primaryLabel;
            }
            // to ensure "secondaryLabel" is required (not null)
            if (secondaryLabel == null)
            {
                throw new InvalidDataException("secondaryLabel is a required property for FavoriteContact and cannot be null");
            }
            else
            {
                this.SecondaryLabel = secondaryLabel;
            }
            // to ensure "tertiaryLabel" is required (not null)
            if (tertiaryLabel == null)
            {
                throw new InvalidDataException("tertiaryLabel is a required property for FavoriteContact and cannot be null");
            }
            else
            {
                this.TertiaryLabel = tertiaryLabel;
            }
            // to ensure "avatar" is required (not null)
            if (avatar == null)
            {
                throw new InvalidDataException("avatar is a required property for FavoriteContact and cannot be null");
            }
            else
            {
                this.Avatar = avatar;
            }
        }
        
        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public int? EntityId { get; set; }


        /// <summary>
        /// Contact first name/last name if entityType is \\&#39;contact\\&#39;, List name if entity type is \\&#39;list\\&#39;
        /// </summary>
        /// <value>Contact first name/last name if entityType is \\&#39;contact\\&#39;, List name if entity type is \\&#39;list\\&#39;</value>
        [DataMember(Name="primaryLabel", EmitDefaultValue=false)]
        public string PrimaryLabel { get; set; }

        /// <summary>
        /// Phone number if entityType is \\&#39;contact\\&#39;, List contacts number if entity type is \\&#39;list\\&#39;
        /// </summary>
        /// <value>Phone number if entityType is \\&#39;contact\\&#39;, List contacts number if entity type is \\&#39;list\\&#39;</value>
        [DataMember(Name="secondaryLabel", EmitDefaultValue=false)]
        public string SecondaryLabel { get; set; }

        /// <summary>
        /// Contact country if entityType is \\&#39;contact\\&#39; else null
        /// </summary>
        /// <value>Contact country if entityType is \\&#39;contact\\&#39; else null</value>
        [DataMember(Name="tertiaryLabel", EmitDefaultValue=false)]
        public string TertiaryLabel { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavoriteContact {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  PrimaryLabel: ").Append(PrimaryLabel).Append("\n");
            sb.Append("  SecondaryLabel: ").Append(SecondaryLabel).Append("\n");
            sb.Append("  TertiaryLabel: ").Append(TertiaryLabel).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
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
            return this.Equals(input as FavoriteContact);
        }

        /// <summary>
        /// Returns true if FavoriteContact instances are equal
        /// </summary>
        /// <param name="input">Instance of FavoriteContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.PrimaryLabel == input.PrimaryLabel ||
                    (this.PrimaryLabel != null &&
                    this.PrimaryLabel.Equals(input.PrimaryLabel))
                ) && 
                (
                    this.SecondaryLabel == input.SecondaryLabel ||
                    (this.SecondaryLabel != null &&
                    this.SecondaryLabel.Equals(input.SecondaryLabel))
                ) && 
                (
                    this.TertiaryLabel == input.TertiaryLabel ||
                    (this.TertiaryLabel != null &&
                    this.TertiaryLabel.Equals(input.TertiaryLabel))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.PrimaryLabel != null)
                    hashCode = hashCode * 59 + this.PrimaryLabel.GetHashCode();
                if (this.SecondaryLabel != null)
                    hashCode = hashCode * 59 + this.SecondaryLabel.GetHashCode();
                if (this.TertiaryLabel != null)
                    hashCode = hashCode * 59 + this.TertiaryLabel.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
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
