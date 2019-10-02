# TextMagicClient.Model.MessageOut
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Message ID. | 
**Sender** | **string** | Message sender (phone number or alphanumeric Sender ID). | [optional] 
**Receiver** | **string** | Recipient phone number. | [optional] 
**Text** | **string** |  | 
**Status** | **string** | Delivery status of the message. TODO: Please see the table below to see different delivery statuses.  | 
**ContactId** | **int?** |  | 
**SessionId** | **int?** |  | 
**MessageTime** | **DateTime?** | Sending time. | 
**Avatar** | **string** |  | 
**Deleted** | **bool?** |  | [optional] 
**Charset** | **string** | Message charset. Could be: *   **ISO-8859-1** for plaintext SMS *   **UTF-16BE** for Unicode SMS  | 
**CharsetLabel** | **string** |  | 
**FirstName** | **string** | TODO: Contact first name. Could be substituted from your [Contacts](/docs/api/contacts/) (even if you submitted phone number instead of contact ID).  | 
**LastName** | **string** | Contact last name. | 
**Country** | **string** | Two-letter ISO country code of the recipient phone number.  | 
**Phone** | **string** |  | [optional] 
**Price** | **float?** |  | [optional] 
**PartsCount** | **int?** | Message parts (multiples of 160 characters) count. | 
**FromEmail** | **string** |  | [optional] 
**FromNumber** | **string** |  | [optional] 
**SmscId** | **string** |  | [optional] 
**Contact** | **string** |  | [optional] 
**Source** | **string** |  | [optional] 
**DeliveredCount** | **int?** |  | [optional] 
**NumbersCount** | **int?** |  | [optional] 
**UserId** | **int?** |  | [optional] 
**CreditsPrice** | **string** |  | [optional] 
**Chars** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

