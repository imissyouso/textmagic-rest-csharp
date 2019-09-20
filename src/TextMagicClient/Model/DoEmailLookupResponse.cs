/* 
 * TextMagic API Documentation
 *
 * # Overview ## Introduction <img style=\"float: right; margin-left: 10px; width: 100px;\" src=\"images/phone.png\"> TextMagic SMS API is a platform for building your own messaging app using our messaging infrastructure. It allows you to send and receive SMS text messages, query information about inbound and outbound messages, manage contacts, create templates (i.e. message formats and static texts) and schedule recurrent SMS messages as well as process bulk SMS messages. <button name=\"button\" onclick=\"http://www.google.com\" class=\"btn\">Try TextMagic API for Free</button>  ### Two Ways to Use TextMagic API * [REST API](https://www.textmagic.com/docs/api/start/) – get full access to TextMagic’s messaging gateway features * [Email to SMS API](https://www.textmagic.com/docs/api/send-email-to-sms/) – set up two-way SMS communication without the need to write any additional code  ### Code Libraries We have created a set of client libraries for the most popular programming languages (such as REST API Java and REST API PHP). These libraries allow you to integrate our API into your code in minutes. Just choose your preferred language to get started:  ## Getting started Get Started with the TextMagic REST API To start sending text messages using the TextMagic REST API, just follow these steps: 1. Generate the API credentials 1. Connect to our API endpoint This page provides all the information you need to get started. Here, we explain the following steps:  How to obtain the API credentials The API endpoint How the REST API works The next step How to obtain the API credentials  ### How to obtain the API credentials To start sending text messages, you need to create an API key. API keys are similar to an account password; the difference is that an API key only provides access to the API: you cannot log in to TextMagic Online using the API key.  Your program sends the login credentials with each API request as HTTP headers: `X-TM-Username` is your TextMagic username, while `X-TM-Key` is your API key.  How to obtain an API key:  1. Log in to TextMagic (or start a free trial if you haven’t registered yet). 1. Go to the API settings page. 1. Click the Add new API key button. 1. Enter an app name for this key. Note, it’s just a label, so pick any name. 1. Click Generate new key. 1. You should now see your new API key in the green notification banner above the table:  ![alt text](images/credentials.png)  > Note for API v1 users > V1 keys are not compatible with the V2 version of the TextMagic REST API, so you will need to generate a new API key to use the V2 endpoint.  ### The API endpoint The TextMagic REST API endpoint is: ``` https://rest.textmagic.com/api/v2 ``` All the URLs referenced in this documentation should use this base URL.  ### How the REST API works REST APIs use the HTTP protocol to send and receive messages. REST messages are usually encoded as JSON documents and are an improvement over older methods such as the XML based SOAP protocol. REST APIs use the same set of methods that web browsers use: POST, GET, PUT or DELETE. These correspond to the CRUD operations: create, read, update and delete. Often, REST URIs provide direct CRUD access to entities or collections of entities, for example: http://api.foo.com/people. In this instance, to delete a person’s endpoint, you might simply call the endpoint DELETE http://api.foo.com/people/{id}. REST makes these types of operations simple.  > Example > > Let’s take the entity most often used in messaging: contacts. Imagine you want to perform operations on your contacts list: well, it’s only a matter of calling the following endpoints: > * GET /api/v2/contacts (get all of your contacts) > * GET /api/v2/contacts/{id} (get a specific contact) > * POST /api/v2/contacts (create a new contact) > * PUT /api/v2/contacts/{id} (update an existing contact) > * DELETE /api/v2/contacts/{id} (delete an existing contact) It’s that simple! In fact, that’s all you need to do to manage the contacts in your TextMagic account!  ## Sandbox Sandbox is a tool to test TextMagic REST API requests without the need to install any applications or write any code. Here, we explain the following details about Sandbox: * The credentials area * Command documentation * How it works  <a href=\"\">Go to TextMagic Sandbox</a>  ### The credentials area To make requests using your TextMagic account, you need to enter your account username and your API key into the corresponding fields. You may also Save them in your browser or press Clear to erase them.  ![alt text](images/sandbox.png) 
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
    /// DoEmailLookupResponse
    /// </summary>
    [DataContract]
    public partial class DoEmailLookupResponse :  IEquatable<DoEmailLookupResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoEmailLookupResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DoEmailLookupResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoEmailLookupResponse" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="addressType">addressType (required).</param>
        /// <param name="emailRole">emailRole (required).</param>
        /// <param name="reason">reason (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="deliverability">deliverability (required).</param>
        /// <param name="isDisposableAddress">isDisposableAddress (required).</param>
        /// <param name="localPart">localPart (required).</param>
        /// <param name="domainPart">domainPart (required).</param>
        /// <param name="exchange">exchange (required).</param>
        /// <param name="isInWhiteList">isInWhiteList (required).</param>
        /// <param name="isInBlackList">isInBlackList (required).</param>
        /// <param name="hasMx">hasMx (required).</param>
        /// <param name="hasAa">hasAa (required).</param>
        /// <param name="hasAaaa">hasAaaa (required).</param>
        /// <param name="risk">risk (required).</param>
        /// <param name="preference">preference (required).</param>
        /// <param name="suggestion">suggestion (required).</param>
        public DoEmailLookupResponse(string address = default(string), string addressType = default(string), string emailRole = default(string), string reason = default(string), StatusEnum status = default(StatusEnum), string deliverability = default(string), bool? isDisposableAddress = default(bool?), string localPart = default(string), string domainPart = default(string), string exchange = default(string), bool? isInWhiteList = default(bool?), bool? isInBlackList = default(bool?), bool? hasMx = default(bool?), bool? hasAa = default(bool?), bool? hasAaaa = default(bool?), string risk = default(string), int? preference = default(int?), string suggestion = default(string))
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
            // to ensure "addressType" is required (not null)
            if (addressType == null)
            {
                throw new InvalidDataException("addressType is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.AddressType = addressType;
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
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Reason = reason;
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
            // to ensure "isDisposableAddress" is required (not null)
            if (isDisposableAddress == null)
            {
                throw new InvalidDataException("isDisposableAddress is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.IsDisposableAddress = isDisposableAddress;
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
            // to ensure "risk" is required (not null)
            if (risk == null)
            {
                throw new InvalidDataException("risk is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Risk = risk;
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
            // to ensure "suggestion" is required (not null)
            if (suggestion == null)
            {
                throw new InvalidDataException("suggestion is a required property for DoEmailLookupResponse and cannot be null");
            }
            else
            {
                this.Suggestion = suggestion;
            }
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or Sets EmailRole
        /// </summary>
        [DataMember(Name="emailRole", EmitDefaultValue=false)]
        public string EmailRole { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }


        /// <summary>
        /// Gets or Sets Deliverability
        /// </summary>
        [DataMember(Name="deliverability", EmitDefaultValue=false)]
        public string Deliverability { get; set; }

        /// <summary>
        /// Gets or Sets IsDisposableAddress
        /// </summary>
        [DataMember(Name="isDisposableAddress", EmitDefaultValue=false)]
        public bool? IsDisposableAddress { get; set; }

        /// <summary>
        /// Gets or Sets LocalPart
        /// </summary>
        [DataMember(Name="localPart", EmitDefaultValue=false)]
        public string LocalPart { get; set; }

        /// <summary>
        /// Gets or Sets DomainPart
        /// </summary>
        [DataMember(Name="domainPart", EmitDefaultValue=false)]
        public string DomainPart { get; set; }

        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// Gets or Sets IsInWhiteList
        /// </summary>
        [DataMember(Name="isInWhiteList", EmitDefaultValue=false)]
        public bool? IsInWhiteList { get; set; }

        /// <summary>
        /// Gets or Sets IsInBlackList
        /// </summary>
        [DataMember(Name="isInBlackList", EmitDefaultValue=false)]
        public bool? IsInBlackList { get; set; }

        /// <summary>
        /// Gets or Sets HasMx
        /// </summary>
        [DataMember(Name="hasMx", EmitDefaultValue=false)]
        public bool? HasMx { get; set; }

        /// <summary>
        /// Gets or Sets HasAa
        /// </summary>
        [DataMember(Name="hasAa", EmitDefaultValue=false)]
        public bool? HasAa { get; set; }

        /// <summary>
        /// Gets or Sets HasAaaa
        /// </summary>
        [DataMember(Name="hasAaaa", EmitDefaultValue=false)]
        public bool? HasAaaa { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name="risk", EmitDefaultValue=false)]
        public string Risk { get; set; }

        /// <summary>
        /// Gets or Sets Preference
        /// </summary>
        [DataMember(Name="preference", EmitDefaultValue=false)]
        public int? Preference { get; set; }

        /// <summary>
        /// Gets or Sets Suggestion
        /// </summary>
        [DataMember(Name="suggestion", EmitDefaultValue=false)]
        public string Suggestion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DoEmailLookupResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  EmailRole: ").Append(EmailRole).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Deliverability: ").Append(Deliverability).Append("\n");
            sb.Append("  IsDisposableAddress: ").Append(IsDisposableAddress).Append("\n");
            sb.Append("  LocalPart: ").Append(LocalPart).Append("\n");
            sb.Append("  DomainPart: ").Append(DomainPart).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  IsInWhiteList: ").Append(IsInWhiteList).Append("\n");
            sb.Append("  IsInBlackList: ").Append(IsInBlackList).Append("\n");
            sb.Append("  HasMx: ").Append(HasMx).Append("\n");
            sb.Append("  HasAa: ").Append(HasAa).Append("\n");
            sb.Append("  HasAaaa: ").Append(HasAaaa).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  Preference: ").Append(Preference).Append("\n");
            sb.Append("  Suggestion: ").Append(Suggestion).Append("\n");
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
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.EmailRole == input.EmailRole ||
                    (this.EmailRole != null &&
                    this.EmailRole.Equals(input.EmailRole))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                    this.IsDisposableAddress == input.IsDisposableAddress ||
                    (this.IsDisposableAddress != null &&
                    this.IsDisposableAddress.Equals(input.IsDisposableAddress))
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
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
                ) && 
                (
                    this.Preference == input.Preference ||
                    (this.Preference != null &&
                    this.Preference.Equals(input.Preference))
                ) && 
                (
                    this.Suggestion == input.Suggestion ||
                    (this.Suggestion != null &&
                    this.Suggestion.Equals(input.Suggestion))
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
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.EmailRole != null)
                    hashCode = hashCode * 59 + this.EmailRole.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Deliverability != null)
                    hashCode = hashCode * 59 + this.Deliverability.GetHashCode();
                if (this.IsDisposableAddress != null)
                    hashCode = hashCode * 59 + this.IsDisposableAddress.GetHashCode();
                if (this.LocalPart != null)
                    hashCode = hashCode * 59 + this.LocalPart.GetHashCode();
                if (this.DomainPart != null)
                    hashCode = hashCode * 59 + this.DomainPart.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
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
                if (this.Risk != null)
                    hashCode = hashCode * 59 + this.Risk.GetHashCode();
                if (this.Preference != null)
                    hashCode = hashCode * 59 + this.Preference.GetHashCode();
                if (this.Suggestion != null)
                    hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
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
