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
    /// MessagingStatItem
    /// </summary>
    [DataContract]
    public partial class MessagingStatItem :  IEquatable<MessagingStatItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingStatItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingStatItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingStatItem" /> class.
        /// </summary>
        /// <param name="replyRate">The number of incoming messages divided by the number of total messages. (required).</param>
        /// <param name="date">Time interval start, empty if the **by** parameter was set to **off**.  (required).</param>
        /// <param name="deliveryRate">Message delivery rate:the number of delivered messages divided by the number of total messages. (required).</param>
        /// <param name="costs">Cost for sent messages during this period. The costs are in the [Account](http://docs.textmagictesting.com/#tag/User) currency.  (required).</param>
        /// <param name="messagesReceived">Total received messages count. (required).</param>
        /// <param name="messagesSentDelivered">Delivered messages count. As messages are retried for up to 48 hours, this value could change. (required).</param>
        /// <param name="messagesSentAccepted">Messages accepted for delivery (in queue), but not yet delivered. (required).</param>
        /// <param name="messagesSentBuffered">Messages buffered by endpoint cell phone operators. (required).</param>
        /// <param name="messagesSentFailed">Messages that have failed for whatever reason, e.g. the destination phone was switched off for 48 hours or the recipient phone account is out of service. (required).</param>
        /// <param name="messagesSentRejected">Messages that were rejected: invalid Sender ID used (e.g. you cannot use the Sender ID or your own mobile number when sending to the United States and Canada.)  (required).</param>
        /// <param name="messagesSentParts">Total sent messages **parts** count. Note that this is not equal to the sent messages count, because one message could consist of 1 to 6 parts and users are charged per part, not per message. (required).</param>
        public MessagingStatItem(float? replyRate = default(float?), DateTime? date = default(DateTime?), float? deliveryRate = default(float?), float? costs = default(float?), int? messagesReceived = default(int?), int? messagesSentDelivered = default(int?), int? messagesSentAccepted = default(int?), int? messagesSentBuffered = default(int?), int? messagesSentFailed = default(int?), int? messagesSentRejected = default(int?), int? messagesSentParts = default(int?))
        {
            // to ensure "replyRate" is required (not null)
            if (replyRate == null)
            {
                throw new InvalidDataException("replyRate is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.ReplyRate = replyRate;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "deliveryRate" is required (not null)
            if (deliveryRate == null)
            {
                throw new InvalidDataException("deliveryRate is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.DeliveryRate = deliveryRate;
            }
            // to ensure "costs" is required (not null)
            if (costs == null)
            {
                throw new InvalidDataException("costs is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.Costs = costs;
            }
            // to ensure "messagesReceived" is required (not null)
            if (messagesReceived == null)
            {
                throw new InvalidDataException("messagesReceived is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.MessagesReceived = messagesReceived;
            }
            // to ensure "messagesSentDelivered" is required (not null)
            if (messagesSentDelivered == null)
            {
                throw new InvalidDataException("messagesSentDelivered is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.MessagesSentDelivered = messagesSentDelivered;
            }
            // to ensure "messagesSentAccepted" is required (not null)
            if (messagesSentAccepted == null)
            {
                throw new InvalidDataException("messagesSentAccepted is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.MessagesSentAccepted = messagesSentAccepted;
            }
            // to ensure "messagesSentBuffered" is required (not null)
            if (messagesSentBuffered == null)
            {
                throw new InvalidDataException("messagesSentBuffered is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.MessagesSentBuffered = messagesSentBuffered;
            }
            // to ensure "messagesSentFailed" is required (not null)
            if (messagesSentFailed == null)
            {
                throw new InvalidDataException("messagesSentFailed is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.MessagesSentFailed = messagesSentFailed;
            }
            // to ensure "messagesSentRejected" is required (not null)
            if (messagesSentRejected == null)
            {
                throw new InvalidDataException("messagesSentRejected is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.MessagesSentRejected = messagesSentRejected;
            }
            // to ensure "messagesSentParts" is required (not null)
            if (messagesSentParts == null)
            {
                throw new InvalidDataException("messagesSentParts is a required property for MessagingStatItem and cannot be null");
            }
            else
            {
                this.MessagesSentParts = messagesSentParts;
            }
        }
        
        /// <summary>
        /// The number of incoming messages divided by the number of total messages.
        /// </summary>
        /// <value>The number of incoming messages divided by the number of total messages.</value>
        [DataMember(Name="replyRate", EmitDefaultValue=false)]
        public float? ReplyRate { get; set; }

        /// <summary>
        /// Time interval start, empty if the **by** parameter was set to **off**. 
        /// </summary>
        /// <value>Time interval start, empty if the **by** parameter was set to **off**. </value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Message delivery rate:the number of delivered messages divided by the number of total messages.
        /// </summary>
        /// <value>Message delivery rate:the number of delivered messages divided by the number of total messages.</value>
        [DataMember(Name="deliveryRate", EmitDefaultValue=false)]
        public float? DeliveryRate { get; set; }

        /// <summary>
        /// Cost for sent messages during this period. The costs are in the [Account](http://docs.textmagictesting.com/#tag/User) currency. 
        /// </summary>
        /// <value>Cost for sent messages during this period. The costs are in the [Account](http://docs.textmagictesting.com/#tag/User) currency. </value>
        [DataMember(Name="costs", EmitDefaultValue=false)]
        public float? Costs { get; set; }

        /// <summary>
        /// Total received messages count.
        /// </summary>
        /// <value>Total received messages count.</value>
        [DataMember(Name="messagesReceived", EmitDefaultValue=false)]
        public int? MessagesReceived { get; set; }

        /// <summary>
        /// Delivered messages count. As messages are retried for up to 48 hours, this value could change.
        /// </summary>
        /// <value>Delivered messages count. As messages are retried for up to 48 hours, this value could change.</value>
        [DataMember(Name="messagesSentDelivered", EmitDefaultValue=false)]
        public int? MessagesSentDelivered { get; set; }

        /// <summary>
        /// Messages accepted for delivery (in queue), but not yet delivered.
        /// </summary>
        /// <value>Messages accepted for delivery (in queue), but not yet delivered.</value>
        [DataMember(Name="messagesSentAccepted", EmitDefaultValue=false)]
        public int? MessagesSentAccepted { get; set; }

        /// <summary>
        /// Messages buffered by endpoint cell phone operators.
        /// </summary>
        /// <value>Messages buffered by endpoint cell phone operators.</value>
        [DataMember(Name="messagesSentBuffered", EmitDefaultValue=false)]
        public int? MessagesSentBuffered { get; set; }

        /// <summary>
        /// Messages that have failed for whatever reason, e.g. the destination phone was switched off for 48 hours or the recipient phone account is out of service.
        /// </summary>
        /// <value>Messages that have failed for whatever reason, e.g. the destination phone was switched off for 48 hours or the recipient phone account is out of service.</value>
        [DataMember(Name="messagesSentFailed", EmitDefaultValue=false)]
        public int? MessagesSentFailed { get; set; }

        /// <summary>
        /// Messages that were rejected: invalid Sender ID used (e.g. you cannot use the Sender ID or your own mobile number when sending to the United States and Canada.) 
        /// </summary>
        /// <value>Messages that were rejected: invalid Sender ID used (e.g. you cannot use the Sender ID or your own mobile number when sending to the United States and Canada.) </value>
        [DataMember(Name="messagesSentRejected", EmitDefaultValue=false)]
        public int? MessagesSentRejected { get; set; }

        /// <summary>
        /// Total sent messages **parts** count. Note that this is not equal to the sent messages count, because one message could consist of 1 to 6 parts and users are charged per part, not per message.
        /// </summary>
        /// <value>Total sent messages **parts** count. Note that this is not equal to the sent messages count, because one message could consist of 1 to 6 parts and users are charged per part, not per message.</value>
        [DataMember(Name="messagesSentParts", EmitDefaultValue=false)]
        public int? MessagesSentParts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingStatItem {\n");
            sb.Append("  ReplyRate: ").Append(ReplyRate).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DeliveryRate: ").Append(DeliveryRate).Append("\n");
            sb.Append("  Costs: ").Append(Costs).Append("\n");
            sb.Append("  MessagesReceived: ").Append(MessagesReceived).Append("\n");
            sb.Append("  MessagesSentDelivered: ").Append(MessagesSentDelivered).Append("\n");
            sb.Append("  MessagesSentAccepted: ").Append(MessagesSentAccepted).Append("\n");
            sb.Append("  MessagesSentBuffered: ").Append(MessagesSentBuffered).Append("\n");
            sb.Append("  MessagesSentFailed: ").Append(MessagesSentFailed).Append("\n");
            sb.Append("  MessagesSentRejected: ").Append(MessagesSentRejected).Append("\n");
            sb.Append("  MessagesSentParts: ").Append(MessagesSentParts).Append("\n");
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
            return this.Equals(input as MessagingStatItem);
        }

        /// <summary>
        /// Returns true if MessagingStatItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagingStatItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingStatItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReplyRate == input.ReplyRate ||
                    (this.ReplyRate != null &&
                    this.ReplyRate.Equals(input.ReplyRate))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DeliveryRate == input.DeliveryRate ||
                    (this.DeliveryRate != null &&
                    this.DeliveryRate.Equals(input.DeliveryRate))
                ) && 
                (
                    this.Costs == input.Costs ||
                    (this.Costs != null &&
                    this.Costs.Equals(input.Costs))
                ) && 
                (
                    this.MessagesReceived == input.MessagesReceived ||
                    (this.MessagesReceived != null &&
                    this.MessagesReceived.Equals(input.MessagesReceived))
                ) && 
                (
                    this.MessagesSentDelivered == input.MessagesSentDelivered ||
                    (this.MessagesSentDelivered != null &&
                    this.MessagesSentDelivered.Equals(input.MessagesSentDelivered))
                ) && 
                (
                    this.MessagesSentAccepted == input.MessagesSentAccepted ||
                    (this.MessagesSentAccepted != null &&
                    this.MessagesSentAccepted.Equals(input.MessagesSentAccepted))
                ) && 
                (
                    this.MessagesSentBuffered == input.MessagesSentBuffered ||
                    (this.MessagesSentBuffered != null &&
                    this.MessagesSentBuffered.Equals(input.MessagesSentBuffered))
                ) && 
                (
                    this.MessagesSentFailed == input.MessagesSentFailed ||
                    (this.MessagesSentFailed != null &&
                    this.MessagesSentFailed.Equals(input.MessagesSentFailed))
                ) && 
                (
                    this.MessagesSentRejected == input.MessagesSentRejected ||
                    (this.MessagesSentRejected != null &&
                    this.MessagesSentRejected.Equals(input.MessagesSentRejected))
                ) && 
                (
                    this.MessagesSentParts == input.MessagesSentParts ||
                    (this.MessagesSentParts != null &&
                    this.MessagesSentParts.Equals(input.MessagesSentParts))
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
                if (this.ReplyRate != null)
                    hashCode = hashCode * 59 + this.ReplyRate.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DeliveryRate != null)
                    hashCode = hashCode * 59 + this.DeliveryRate.GetHashCode();
                if (this.Costs != null)
                    hashCode = hashCode * 59 + this.Costs.GetHashCode();
                if (this.MessagesReceived != null)
                    hashCode = hashCode * 59 + this.MessagesReceived.GetHashCode();
                if (this.MessagesSentDelivered != null)
                    hashCode = hashCode * 59 + this.MessagesSentDelivered.GetHashCode();
                if (this.MessagesSentAccepted != null)
                    hashCode = hashCode * 59 + this.MessagesSentAccepted.GetHashCode();
                if (this.MessagesSentBuffered != null)
                    hashCode = hashCode * 59 + this.MessagesSentBuffered.GetHashCode();
                if (this.MessagesSentFailed != null)
                    hashCode = hashCode * 59 + this.MessagesSentFailed.GetHashCode();
                if (this.MessagesSentRejected != null)
                    hashCode = hashCode * 59 + this.MessagesSentRejected.GetHashCode();
                if (this.MessagesSentParts != null)
                    hashCode = hashCode * 59 + this.MessagesSentParts.GetHashCode();
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
