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
    /// MessagesIcs
    /// </summary>
    [DataContract]
    public partial class MessagesIcs :  IEquatable<MessagesIcs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesIcs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagesIcs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesIcs" /> class.
        /// </summary>
        /// <param name="id">Schedule ID. (required).</param>
        /// <param name="nextSend">Next send date in [ISO 8601](https://en.wikipedia.org/?title&#x3D;ISO_8601) format.  (required).</param>
        /// <param name="rrule">[iCal RRULE](http://www.kanzaki.com/docs/ical/rrule.html) string.  (required).</param>
        /// <param name="session">session (required).</param>
        /// <param name="lastSent">Date and time when last message has been sent. (required).</param>
        /// <param name="contactName">contactName (required).</param>
        /// <param name="parameters">parameters (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="textParameters">textParameters (required).</param>
        /// <param name="firstOccurrence">firstOccurrence (required).</param>
        /// <param name="lastOccurrence">lastOccurrence (required).</param>
        /// <param name="recipientsCount">Amount of actual recipients. (required).</param>
        /// <param name="timezone">User-friendly timezone name (with spaces replaced by underscores). (required).</param>
        /// <param name="completed">Indicates that schedling has been completed. (required).</param>
        /// <param name="avatar">TODO (required).</param>
        /// <param name="createdAt">Scheduling creation time. (required).</param>
        public MessagesIcs(int? id = default(int?), DateTime? nextSend = default(DateTime?), string rrule = default(string), MessageSession session = default(MessageSession), DateTime? lastSent = default(DateTime?), string contactName = default(string), MessagesIcsParameters parameters = default(MessagesIcsParameters), string type = default(string), string summary = default(string), MessagesIcsTextParameters textParameters = default(MessagesIcsTextParameters), DateTime? firstOccurrence = default(DateTime?), DateTime? lastOccurrence = default(DateTime?), int? recipientsCount = default(int?), string timezone = default(string), bool? completed = default(bool?), string avatar = default(string), DateTime? createdAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "nextSend" is required (not null)
            if (nextSend == null)
            {
                throw new InvalidDataException("nextSend is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.NextSend = nextSend;
            }
            // to ensure "rrule" is required (not null)
            if (rrule == null)
            {
                throw new InvalidDataException("rrule is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Rrule = rrule;
            }
            // to ensure "session" is required (not null)
            if (session == null)
            {
                throw new InvalidDataException("session is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Session = session;
            }
            // to ensure "lastSent" is required (not null)
            if (lastSent == null)
            {
                throw new InvalidDataException("lastSent is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.LastSent = lastSent;
            }
            // to ensure "contactName" is required (not null)
            if (contactName == null)
            {
                throw new InvalidDataException("contactName is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.ContactName = contactName;
            }
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new InvalidDataException("parameters is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Parameters = parameters;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "summary" is required (not null)
            if (summary == null)
            {
                throw new InvalidDataException("summary is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Summary = summary;
            }
            // to ensure "textParameters" is required (not null)
            if (textParameters == null)
            {
                throw new InvalidDataException("textParameters is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.TextParameters = textParameters;
            }
            // to ensure "firstOccurrence" is required (not null)
            if (firstOccurrence == null)
            {
                throw new InvalidDataException("firstOccurrence is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.FirstOccurrence = firstOccurrence;
            }
            // to ensure "lastOccurrence" is required (not null)
            if (lastOccurrence == null)
            {
                throw new InvalidDataException("lastOccurrence is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.LastOccurrence = lastOccurrence;
            }
            // to ensure "recipientsCount" is required (not null)
            if (recipientsCount == null)
            {
                throw new InvalidDataException("recipientsCount is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.RecipientsCount = recipientsCount;
            }
            // to ensure "timezone" is required (not null)
            if (timezone == null)
            {
                throw new InvalidDataException("timezone is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Timezone = timezone;
            }
            // to ensure "completed" is required (not null)
            if (completed == null)
            {
                throw new InvalidDataException("completed is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Completed = completed;
            }
            // to ensure "avatar" is required (not null)
            if (avatar == null)
            {
                throw new InvalidDataException("avatar is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.Avatar = avatar;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for MessagesIcs and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
        }
        
        /// <summary>
        /// Schedule ID.
        /// </summary>
        /// <value>Schedule ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Next send date in [ISO 8601](https://en.wikipedia.org/?title&#x3D;ISO_8601) format. 
        /// </summary>
        /// <value>Next send date in [ISO 8601](https://en.wikipedia.org/?title&#x3D;ISO_8601) format. </value>
        [DataMember(Name="nextSend", EmitDefaultValue=false)]
        public DateTime? NextSend { get; set; }

        /// <summary>
        /// [iCal RRULE](http://www.kanzaki.com/docs/ical/rrule.html) string. 
        /// </summary>
        /// <value>[iCal RRULE](http://www.kanzaki.com/docs/ical/rrule.html) string. </value>
        [DataMember(Name="rrule", EmitDefaultValue=false)]
        public string Rrule { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public MessageSession Session { get; set; }

        /// <summary>
        /// Date and time when last message has been sent.
        /// </summary>
        /// <value>Date and time when last message has been sent.</value>
        [DataMember(Name="lastSent", EmitDefaultValue=false)]
        public DateTime? LastSent { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="contactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public MessagesIcsParameters Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets TextParameters
        /// </summary>
        [DataMember(Name="textParameters", EmitDefaultValue=false)]
        public MessagesIcsTextParameters TextParameters { get; set; }

        /// <summary>
        /// Gets or Sets FirstOccurrence
        /// </summary>
        [DataMember(Name="firstOccurrence", EmitDefaultValue=false)]
        public DateTime? FirstOccurrence { get; set; }

        /// <summary>
        /// Gets or Sets LastOccurrence
        /// </summary>
        [DataMember(Name="lastOccurrence", EmitDefaultValue=false)]
        public DateTime? LastOccurrence { get; set; }

        /// <summary>
        /// Amount of actual recipients.
        /// </summary>
        /// <value>Amount of actual recipients.</value>
        [DataMember(Name="recipientsCount", EmitDefaultValue=false)]
        public int? RecipientsCount { get; set; }

        /// <summary>
        /// User-friendly timezone name (with spaces replaced by underscores).
        /// </summary>
        /// <value>User-friendly timezone name (with spaces replaced by underscores).</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Indicates that schedling has been completed.
        /// </summary>
        /// <value>Indicates that schedling has been completed.</value>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public bool? Completed { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        /// <value>TODO</value>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Scheduling creation time.
        /// </summary>
        /// <value>Scheduling creation time.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagesIcs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NextSend: ").Append(NextSend).Append("\n");
            sb.Append("  Rrule: ").Append(Rrule).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  LastSent: ").Append(LastSent).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  TextParameters: ").Append(TextParameters).Append("\n");
            sb.Append("  FirstOccurrence: ").Append(FirstOccurrence).Append("\n");
            sb.Append("  LastOccurrence: ").Append(LastOccurrence).Append("\n");
            sb.Append("  RecipientsCount: ").Append(RecipientsCount).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as MessagesIcs);
        }

        /// <summary>
        /// Returns true if MessagesIcs instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagesIcs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagesIcs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NextSend == input.NextSend ||
                    (this.NextSend != null &&
                    this.NextSend.Equals(input.NextSend))
                ) && 
                (
                    this.Rrule == input.Rrule ||
                    (this.Rrule != null &&
                    this.Rrule.Equals(input.Rrule))
                ) && 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                ) && 
                (
                    this.LastSent == input.LastSent ||
                    (this.LastSent != null &&
                    this.LastSent.Equals(input.LastSent))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.TextParameters == input.TextParameters ||
                    (this.TextParameters != null &&
                    this.TextParameters.Equals(input.TextParameters))
                ) && 
                (
                    this.FirstOccurrence == input.FirstOccurrence ||
                    (this.FirstOccurrence != null &&
                    this.FirstOccurrence.Equals(input.FirstOccurrence))
                ) && 
                (
                    this.LastOccurrence == input.LastOccurrence ||
                    (this.LastOccurrence != null &&
                    this.LastOccurrence.Equals(input.LastOccurrence))
                ) && 
                (
                    this.RecipientsCount == input.RecipientsCount ||
                    (this.RecipientsCount != null &&
                    this.RecipientsCount.Equals(input.RecipientsCount))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NextSend != null)
                    hashCode = hashCode * 59 + this.NextSend.GetHashCode();
                if (this.Rrule != null)
                    hashCode = hashCode * 59 + this.Rrule.GetHashCode();
                if (this.Session != null)
                    hashCode = hashCode * 59 + this.Session.GetHashCode();
                if (this.LastSent != null)
                    hashCode = hashCode * 59 + this.LastSent.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.TextParameters != null)
                    hashCode = hashCode * 59 + this.TextParameters.GetHashCode();
                if (this.FirstOccurrence != null)
                    hashCode = hashCode * 59 + this.FirstOccurrence.GetHashCode();
                if (this.LastOccurrence != null)
                    hashCode = hashCode * 59 + this.LastOccurrence.GetHashCode();
                if (this.RecipientsCount != null)
                    hashCode = hashCode * 59 + this.RecipientsCount.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
