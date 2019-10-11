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
    /// ImportContactsInputObject
    /// </summary>
    [DataContract]
    public partial class ImportContactsInputObject :  IEquatable<ImportContactsInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportContactsInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportContactsInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportContactsInputObject" /> class.
        /// </summary>
        /// <param name="column">Column values mapping (number column &#x3D;&gt; field), e.g. column[0] &#x3D; \&quot;phone\&quot;, column[1] &#x3D; \&quot;firstName\&quot; (required).</param>
        /// <param name="listName">List name. This list will be created during import. If such name is already taken, an ordinal (1, 2, ...) will be added to the end.</param>
        /// <param name="listId">List ID contacts will be imported to.</param>
        public ImportContactsInputObject(List<ImportColumnMappingItem> column = default(List<ImportColumnMappingItem>), string listName = default(string), string listId = default(string))
        {
            // to ensure "column" is required (not null)
            if (column == null)
            {
                throw new InvalidDataException("column is a required property for ImportContactsInputObject and cannot be null");
            }
            else
            {
                this.Column = column;
            }
            this.ListName = listName;
            this.ListId = listId;
        }
        
        /// <summary>
        /// Column values mapping (number column &#x3D;&gt; field), e.g. column[0] &#x3D; \&quot;phone\&quot;, column[1] &#x3D; \&quot;firstName\&quot;
        /// </summary>
        /// <value>Column values mapping (number column &#x3D;&gt; field), e.g. column[0] &#x3D; \&quot;phone\&quot;, column[1] &#x3D; \&quot;firstName\&quot;</value>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public List<ImportColumnMappingItem> Column { get; set; }

        /// <summary>
        /// List name. This list will be created during import. If such name is already taken, an ordinal (1, 2, ...) will be added to the end
        /// </summary>
        /// <value>List name. This list will be created during import. If such name is already taken, an ordinal (1, 2, ...) will be added to the end</value>
        [DataMember(Name="listName", EmitDefaultValue=false)]
        public string ListName { get; set; }

        /// <summary>
        /// List ID contacts will be imported to
        /// </summary>
        /// <value>List ID contacts will be imported to</value>
        [DataMember(Name="listId", EmitDefaultValue=false)]
        public string ListId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportContactsInputObject {\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  ListName: ").Append(ListName).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
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
            return this.Equals(input as ImportContactsInputObject);
        }

        /// <summary>
        /// Returns true if ImportContactsInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportContactsInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportContactsInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Column == input.Column ||
                    this.Column != null &&
                    this.Column.SequenceEqual(input.Column)
                ) && 
                (
                    this.ListName == input.ListName ||
                    (this.ListName != null &&
                    this.ListName.Equals(input.ListName))
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
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
                if (this.Column != null)
                    hashCode = hashCode * 59 + this.Column.GetHashCode();
                if (this.ListName != null)
                    hashCode = hashCode * 59 + this.ListName.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
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
