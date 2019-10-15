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
    /// ImportColumnMappingItem
    /// </summary>
    [DataContract]
    public partial class ImportColumnMappingItem :  IEquatable<ImportColumnMappingItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportColumnMappingItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportColumnMappingItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportColumnMappingItem" /> class.
        /// </summary>
        /// <param name="columnPositionInFile">Column position in file (indexed from 0) (required).</param>
        /// <param name="fieldOrCustomFieldId">Field or custom field id (required).</param>
        public ImportColumnMappingItem(string columnPositionInFile = default(string), string fieldOrCustomFieldId = default(string))
        {
            // to ensure "columnPositionInFile" is required (not null)
            if (columnPositionInFile == null)
            {
                throw new InvalidDataException("columnPositionInFile is a required property for ImportColumnMappingItem and cannot be null");
            }
            else
            {
                this.ColumnPositionInFile = columnPositionInFile;
            }
            // to ensure "fieldOrCustomFieldId" is required (not null)
            if (fieldOrCustomFieldId == null)
            {
                throw new InvalidDataException("fieldOrCustomFieldId is a required property for ImportColumnMappingItem and cannot be null");
            }
            else
            {
                this.FieldOrCustomFieldId = fieldOrCustomFieldId;
            }
        }
        
        /// <summary>
        /// Column position in file (indexed from 0)
        /// </summary>
        /// <value>Column position in file (indexed from 0)</value>
        [DataMember(Name="columnPositionInFile", EmitDefaultValue=false)]
        public string ColumnPositionInFile { get; set; }

        /// <summary>
        /// Field or custom field id
        /// </summary>
        /// <value>Field or custom field id</value>
        [DataMember(Name="fieldOrCustomFieldId", EmitDefaultValue=false)]
        public string FieldOrCustomFieldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportColumnMappingItem {\n");
            sb.Append("  ColumnPositionInFile: ").Append(ColumnPositionInFile).Append("\n");
            sb.Append("  FieldOrCustomFieldId: ").Append(FieldOrCustomFieldId).Append("\n");
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
            return this.Equals(input as ImportColumnMappingItem);
        }

        /// <summary>
        /// Returns true if ImportColumnMappingItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportColumnMappingItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportColumnMappingItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnPositionInFile == input.ColumnPositionInFile ||
                    (this.ColumnPositionInFile != null &&
                    this.ColumnPositionInFile.Equals(input.ColumnPositionInFile))
                ) && 
                (
                    this.FieldOrCustomFieldId == input.FieldOrCustomFieldId ||
                    (this.FieldOrCustomFieldId != null &&
                    this.FieldOrCustomFieldId.Equals(input.FieldOrCustomFieldId))
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
                if (this.ColumnPositionInFile != null)
                    hashCode = hashCode * 59 + this.ColumnPositionInFile.GetHashCode();
                if (this.FieldOrCustomFieldId != null)
                    hashCode = hashCode * 59 + this.FieldOrCustomFieldId.GetHashCode();
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