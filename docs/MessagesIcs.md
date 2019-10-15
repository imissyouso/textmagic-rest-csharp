# TextMagicClient.Model.MessagesIcs
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Schedule ID. | 
**NextSend** | **DateTime?** | Next send date in [ISO 8601](https://en.wikipedia.org/?title&#x3D;ISO_8601) format.  | 
**Rrule** | **string** | [iCal RRULE](http://www.kanzaki.com/docs/ical/rrule.html) string.  | 
**Session** | [**MessageSession**](MessageSession.md) |  | 
**LastSent** | **DateTime?** | Date and time when last message has been sent. | 
**ContactName** | **string** |  | 
**Parameters** | [**MessagesIcsParameters**](MessagesIcsParameters.md) |  | 
**Type** | **string** |  | 
**Summary** | **string** |  | 
**TextParameters** | [**MessagesIcsTextParameters**](MessagesIcsTextParameters.md) |  | 
**FirstOccurrence** | **DateTime?** |  | 
**LastOccurrence** | **DateTime?** |  | 
**RecipientsCount** | **int?** | Amount of actual recipients. | 
**Timezone** | **string** | User-friendly timezone name (with spaces replaced by underscores). | 
**Completed** | **bool?** | Indicates that schedling has been completed. | 
**Avatar** | **string** | TODO | 
**CreatedAt** | **DateTime?** | Scheduling creation time. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

