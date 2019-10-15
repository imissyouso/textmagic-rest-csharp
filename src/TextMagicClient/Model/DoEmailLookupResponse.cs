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
    /// DoEmailLookupResponse
    /// </summary>
    [DataContract]
    public partial class DoEmailLookupResponse :  IEquatable<DoEmailLookupResponse>, IValidatableObject
    {
        /// <summary>
        /// The email is &#x60;valid&#x60; or &#x60;invalid&#x60;.
        /// </summary>
        /// <value>The email is &#x60;valid&#x60; or &#x60;invalid&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 1,
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 2
        }

        /// <summary>
        /// The email is &#x60;valid&#x60; or &#x60;invalid&#x60;.
        /// </summary>
        /// <value>The email is &#x60;valid&#x60; or &#x60;invalid&#x60;.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// The risk score of the email is&#x60;high&#x60;, &#x60;medium&#x60;, &#x60;low&#x60; or &#x60;null&#x60;.
        /// </summary>
        /// <value>The risk score of the email is&#x60;high&#x60;, &#x60;medium&#x60;, &#x60;low&#x60; or &#x60;null&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RiskEnum
        {
            
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,
            
            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 2,
            
            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 3,
            
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 4
        }

        /// <summary>
        /// The risk score of the email is&#x60;high&#x60;, &#x60;medium&#x60;, &#x60;low&#x60; or &#x60;null&#x60;.
        /// </summary>
        /// <value>The risk score of the email is&#x60;high&#x60;, &#x60;medium&#x60;, &#x60;low&#x60; or &#x60;null&#x60;.</value>
        [DataMember(Name="risk", EmitDefaultValue=false)]
        public RiskEnum Risk { get; set; }
        /// <summary>
        /// The email address type (domain) is &#x60;free&#x60; or &#x60;corporate&#x60;.
        /// </summary>
        /// <value>The email address type (domain) is &#x60;free&#x60; or &#x60;corporate&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddressTypeEnum
        {
            
            /// <summary>
            /// Enum Corporate for value: corporate
            /// </summary>
            [EnumMember(Value = "corporate")]
            Corporate = 1,
            
            /// <summary>
            /// Enum Free for value: free
            /// </summary>
            [EnumMember(Value = "free")]
            Free = 2
        }

        /// <summary>
        /// The email address type (domain) is &#x60;free&#x60; or &#x60;corporate&#x60;.
        /// </summary>
        /// <value>The email address type (domain) is &#x60;free&#x60; or &#x60;corporate&#x60;.</value>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public AddressTypeEnum AddressType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoEmailLookupResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DoEmailLookupResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoEmailLookupResponse" /> class.
        /// </summary>
        /// <param name="address">The email address passed to the call. (required).</param>
        /// <param name="status">The email is &#x60;valid&#x60; or &#x60;invalid&#x60;. (required).</param>
        /// <param name="deliverability">The delivery status of the email address is&#x60;deliverable&#x60;, &#x60;undeliverable&#x60;  or &#x60;unknown&#x60;. (required).</param>
        /// <param name="reason">The reason why the checked email is invalid/undeliverable. (required).</param>
        /// <param name="risk">The risk score of the email is&#x60;high&#x60;, &#x60;medium&#x60;, &#x60;low&#x60; or &#x60;null&#x60;. (required).</param>
        /// <param name="addressType">The email address type (domain) is &#x60;free&#x60; or &#x60;corporate&#x60;. (required).</param>
        /// <param name="isDisposableAddress">This is be &#x60;true&#x60; if the domain is in the list of disposable email addresses, otherwise returns as &#x60;false&#x60;. (required).</param>
        /// <param name="suggestion">Null if nothing is suggested, however, if there is a potential typo in the email address, the closest suggestion is provided. (required).</param>
        /// <param name="emailRole">Checks the mailbox part of the email whether it matches a specific role type (‘admin’, ‘sales’, ‘webmaster’) (required).</param>
        /// <param name="localPart">The local part of the email address. (required).</param>
        /// <param name="domainPart">The domain part of the email address. (required).</param>
        /// <param name="exchange">Email exchange server domain name (MX record value). (required).</param>
        /// <param name="preference">MX record preference. (required).</param>
        /// <param name="isInWhiteList">&#x60;true&#x60; if the email address exists in TextMagic whitelist.  (required).</param>
        /// <param name="isInBlackList">&#x60;true&#x60; if the email address exists in TextMagic blacklist.  (required).</param>
        /// <param name="hasMx">&#x60;true&#x60; if the email address domain has an MX record.  (required).</param>
        /// <param name="hasAa">&#x60;true&#x60; if the email address domain has an A record (IPv4).  (required).</param>
        /// <param name="hasAaaa">&#x60;true&#x60; if the email address domain has an AAAA record (IPv6).  (required).</param>
        public DoEmailLookupResponse(string address = default(string), StatusEnum status = default(StatusEnum), string deliverability = default(string), string reason = default(string), RiskEnum risk = default(RiskEnum), AddressTypeEnum addressType = default(AddressTypeEnum), bool? isDisposableAddress = default(bool?), string suggestion = default(string), string emailRole = default(string), string localPart = default(string), string domainPart = default(string), string exchange = default(string), int? preference = default(int?), bool? isInWhiteList = default(bool?), bool? isInBlackList = default(bool?), bool? hasMx = default(bool?), bool? hasAa = default(bool?), bool? hasAaaa = default(bool?))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "deliverability" is required (not null)
            if (deliverability == null)
            {
                throw new InvalidDataException("deliverability is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Deliverability = deliverability;
            }
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }
            // to ensure "risk" is required (not null)
            if (risk == null)
            {
                throw new InvalidDataException("risk is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Risk = risk;
            }
            // to ensure "addressType" is required (not null)
            if (addressType == null)
            {
                throw new InvalidDataException("addressType is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.AddressType = addressType;
            }
            // to ensure "isDisposableAddress" is required (not null)
            if (isDisposableAddress == null)
            {
                throw new InvalidDataException("isDisposableAddress is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.IsDisposableAddress = isDisposableAddress;
            }
            // to ensure "suggestion" is required (not null)
            if (suggestion == null)
            {
                throw new InvalidDataException("suggestion is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Suggestion = suggestion;
            }
            // to ensure "emailRole" is required (not null)
            if (emailRole == null)
            {
                throw new InvalidDataException("emailRole is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.EmailRole = emailRole;
            }
            // to ensure "localPart" is required (not null)
            if (localPart == null)
            {
                throw new InvalidDataException("localPart is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.LocalPart = localPart;
            }
            // to ensure "domainPart" is required (not null)
            if (domainPart == null)
            {
                throw new InvalidDataException("domainPart is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.DomainPart = domainPart;
            }
            // to ensure "exchange" is required (not null)
            if (exchange == null)
            {
                throw new InvalidDataException("exchange is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Exchange = exchange;
            }
            // to ensure "preference" is required (not null)
            if (preference == null)
            {
                throw new InvalidDataException("preference is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Preference = preference;
            }
            // to ensure "isInWhiteList" is required (not null)
            if (isInWhiteList == null)
            {
                throw new InvalidDataException("isInWhiteList is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.IsInWhiteList = isInWhiteList;
            }
            // to ensure "isInBlackList" is required (not null)
            if (isInBlackList == null)
            {
                throw new InvalidDataException("isInBlackList is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.IsInBlackList = isInBlackList;
            }
            // to ensure "hasMx" is required (not null)
            if (hasMx == null)
            {
                throw new InvalidDataException("hasMx is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.HasMx = hasMx;
            }
            // to ensure "hasAa" is required (not null)
            if (hasAa == null)
            {
                throw new InvalidDataException("hasAa is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.HasAa = hasAa;
            }
            // to ensure "hasAaaa" is required (not null)
            if (hasAaaa == null)
            {
                throw new InvalidDataException("hasAaaa is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.HasAaaa = hasAaaa;
            }
        }
        
        /// <summary>
        /// The email address passed to the call.
        /// </summary>
        /// <value>The email address passed to the call.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }


        /// <summary>
        /// The delivery status of the email address is&#x60;deliverable&#x60;, &#x60;undeliverable&#x60;  or &#x60;unknown&#x60;.
        /// </summary>
        /// <value>The delivery status of the email address is&#x60;deliverable&#x60;, &#x60;undeliverable&#x60;  or &#x60;unknown&#x60;.</value>
        [DataMember(Name="deliverability", EmitDefaultValue=false)]
        public string Deliverability { get; set; }

        /// <summary>
        /// The reason why the checked email is invalid/undeliverable.
        /// </summary>
        /// <value>The reason why the checked email is invalid/undeliverable.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }



        /// <summary>
        /// This is be &#x60;true&#x60; if the domain is in the list of disposable email addresses, otherwise returns as &#x60;false&#x60;.
        /// </summary>
        /// <value>This is be &#x60;true&#x60; if the domain is in the list of disposable email addresses, otherwise returns as &#x60;false&#x60;.</value>
        [DataMember(Name="isDisposableAddress", EmitDefaultValue=false)]
        public bool? IsDisposableAddress { get; set; }

        /// <summary>
        /// Null if nothing is suggested, however, if there is a potential typo in the email address, the closest suggestion is provided.
        /// </summary>
        /// <value>Null if nothing is suggested, however, if there is a potential typo in the email address, the closest suggestion is provided.</value>
        [DataMember(Name="suggestion", EmitDefaultValue=false)]
        public string Suggestion { get; set; }

        /// <summary>
        /// Checks the mailbox part of the email whether it matches a specific role type (‘admin’, ‘sales’, ‘webmaster’)
        /// </summary>
        /// <value>Checks the mailbox part of the email whether it matches a specific role type (‘admin’, ‘sales’, ‘webmaster’)</value>
        [DataMember(Name="emailRole", EmitDefaultValue=false)]
        public string EmailRole { get; set; }

        /// <summary>
        /// The local part of the email address.
        /// </summary>
        /// <value>The local part of the email address.</value>
        [DataMember(Name="localPart", EmitDefaultValue=false)]
        public string LocalPart { get; set; }

        /// <summary>
        /// The domain part of the email address.
        /// </summary>
        /// <value>The domain part of the email address.</value>
        [DataMember(Name="domainPart", EmitDefaultValue=false)]
        public string DomainPart { get; set; }

        /// <summary>
        /// Email exchange server domain name (MX record value).
        /// </summary>
        /// <value>Email exchange server domain name (MX record value).</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// MX record preference.
        /// </summary>
        /// <value>MX record preference.</value>
        [DataMember(Name="preference", EmitDefaultValue=false)]
        public int? Preference { get; set; }

        /// <summary>
        /// &#x60;true&#x60; if the email address exists in TextMagic whitelist. 
        /// </summary>
        /// <value>&#x60;true&#x60; if the email address exists in TextMagic whitelist. </value>
        [DataMember(Name="isInWhiteList", EmitDefaultValue=false)]
        public bool? IsInWhiteList { get; set; }

        /// <summary>
        /// &#x60;true&#x60; if the email address exists in TextMagic blacklist. 
        /// </summary>
        /// <value>&#x60;true&#x60; if the email address exists in TextMagic blacklist. </value>
        [DataMember(Name="isInBlackList", EmitDefaultValue=false)]
        public bool? IsInBlackList { get; set; }

        /// <summary>
        /// &#x60;true&#x60; if the email address domain has an MX record. 
        /// </summary>
        /// <value>&#x60;true&#x60; if the email address domain has an MX record. </value>
        [DataMember(Name="hasMx", EmitDefaultValue=false)]
        public bool? HasMx { get; set; }

        /// <summary>
        /// &#x60;true&#x60; if the email address domain has an A record (IPv4). 
        /// </summary>
        /// <value>&#x60;true&#x60; if the email address domain has an A record (IPv4). </value>
        [DataMember(Name="hasAa", EmitDefaultValue=false)]
        public bool? HasAa { get; set; }

        /// <summary>
        /// &#x60;true&#x60; if the email address domain has an AAAA record (IPv6). 
        /// </summary>
        /// <value>&#x60;true&#x60; if the email address domain has an AAAA record (IPv6). </value>
        [DataMember(Name="hasAaaa", EmitDefaultValue=false)]
        public bool? HasAaaa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DoEmailLookupResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Deliverability: ").Append(Deliverability).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  IsDisposableAddress: ").Append(IsDisposableAddress).Append("\n");
            sb.Append("  Suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  EmailRole: ").Append(EmailRole).Append("\n");
            sb.Append("  LocalPart: ").Append(LocalPart).Append("\n");
            sb.Append("  DomainPart: ").Append(DomainPart).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Preference: ").Append(Preference).Append("\n");
            sb.Append("  IsInWhiteList: ").Append(IsInWhiteList).Append("\n");
            sb.Append("  IsInBlackList: ").Append(IsInBlackList).Append("\n");
            sb.Append("  HasMx: ").Append(HasMx).Append("\n");
            sb.Append("  HasAa: ").Append(HasAa).Append("\n");
            sb.Append("  HasAaaa: ").Append(HasAaaa).Append("\n");
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
            return this.Equals(input as DoEmailLookupResponse);
        }

        /// <summary>
        /// Returns true if DoEmailLookupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DoEmailLookupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoEmailLookupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Deliverability == input.Deliverability ||
                    (this.Deliverability != null &&
                    this.Deliverability.Equals(input.Deliverability))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.IsDisposableAddress == input.IsDisposableAddress ||
                    (this.IsDisposableAddress != null &&
                    this.IsDisposableAddress.Equals(input.IsDisposableAddress))
                ) && 
                (
                    this.Suggestion == input.Suggestion ||
                    (this.Suggestion != null &&
                    this.Suggestion.Equals(input.Suggestion))
                ) && 
                (
                    this.EmailRole == input.EmailRole ||
                    (this.EmailRole != null &&
                    this.EmailRole.Equals(input.EmailRole))
                ) && 
                (
                    this.LocalPart == input.LocalPart ||
                    (this.LocalPart != null &&
                    this.LocalPart.Equals(input.LocalPart))
                ) && 
                (
                    this.DomainPart == input.DomainPart ||
                    (this.DomainPart != null &&
                    this.DomainPart.Equals(input.DomainPart))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.Preference == input.Preference ||
                    (this.Preference != null &&
                    this.Preference.Equals(input.Preference))
                ) && 
                (
                    this.IsInWhiteList == input.IsInWhiteList ||
                    (this.IsInWhiteList != null &&
                    this.IsInWhiteList.Equals(input.IsInWhiteList))
                ) && 
                (
                    this.IsInBlackList == input.IsInBlackList ||
                    (this.IsInBlackList != null &&
                    this.IsInBlackList.Equals(input.IsInBlackList))
                ) && 
                (
                    this.HasMx == input.HasMx ||
                    (this.HasMx != null &&
                    this.HasMx.Equals(input.HasMx))
                ) && 
                (
                    this.HasAa == input.HasAa ||
                    (this.HasAa != null &&
                    this.HasAa.Equals(input.HasAa))
                ) && 
                (
                    this.HasAaaa == input.HasAaaa ||
                    (this.HasAaaa != null &&
                    this.HasAaaa.Equals(input.HasAaaa))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Deliverability != null)
                    hashCode = hashCode * 59 + this.Deliverability.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Risk != null)
                    hashCode = hashCode * 59 + this.Risk.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.IsDisposableAddress != null)
                    hashCode = hashCode * 59 + this.IsDisposableAddress.GetHashCode();
                if (this.Suggestion != null)
                    hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.EmailRole != null)
                    hashCode = hashCode * 59 + this.EmailRole.GetHashCode();
                if (this.LocalPart != null)
                    hashCode = hashCode * 59 + this.LocalPart.GetHashCode();
                if (this.DomainPart != null)
                    hashCode = hashCode * 59 + this.DomainPart.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.Preference != null)
                    hashCode = hashCode * 59 + this.Preference.GetHashCode();
                if (this.IsInWhiteList != null)
                    hashCode = hashCode * 59 + this.IsInWhiteList.GetHashCode();
                if (this.IsInBlackList != null)
                    hashCode = hashCode * 59 + this.IsInBlackList.GetHashCode();
                if (this.HasMx != null)
                    hashCode = hashCode * 59 + this.HasMx.GetHashCode();
                if (this.HasAa != null)
                    hashCode = hashCode * 59 + this.HasAa.GetHashCode();
                if (this.HasAaaa != null)
                    hashCode = hashCode * 59 + this.HasAaaa.GetHashCode();
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
