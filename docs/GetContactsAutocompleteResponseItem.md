# TextMagicClient.Model.GetContactsAutocompleteResponseItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityId** | **int?** | Id of entity. 0 if object is a Reply | 
**EntityType** | **string** |  | 
**Value** | **string** | Id of contact/list if entityType is contact/list OR phone number if entityType is reply. | 
**Label** | **string** | Name of the contact/list if entityType is contact/list OR phone number if entityType is reply. | 
**SharedBy** | **string** | If contact or list was shared by another user then name if this user will be shown. | 
**Avatar** | **string** | Contact avatar URI. | 
**Favorited** | **bool?** | If contact has been marked as favorite. | 
**UserId** | **int?** | Owner id of the contact/list (if it was shared). | 
**CountryName** | **string** |  | 
**Qposition** | **int?** |  | 
**Rposition** | **int?** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

