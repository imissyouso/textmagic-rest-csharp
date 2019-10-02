# TextMagicClient.Model.MessageSession
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Session ID. | 
**StartTime** | **string** | Session creation time. | 
**Text** | **string** | Session text. If a template was used for the session text (see [Messages: Send](#tag/Outbound-Messages) for details), it may contain template tags.  | 
**Source** | **string** | *   **O** for TextMagic Online *   **A** for API *   **M** for TextMagic Messenger *   **E** for [Email to SMS](/docs/api/send-email-to-sms/) *   **X** for [Distribution lists](/docs/api/distribution-lists/)  | 
**ReferenceId** | **string** | Custom reference ID (see [Messages: Send](/docs/api/send-sms/) for details).  | 
**Price** | **decimal?** | Session cost (in account currency). | 
**NumbersCount** | **int?** | Session recipient count. | 
**Destination** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

