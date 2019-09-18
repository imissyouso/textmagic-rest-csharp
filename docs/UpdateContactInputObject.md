# TextMagicClient.Model.UpdateContactInputObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | Contact first name | [optional] 
**LastName** | **string** | Contact last name | [optional] 
**Phone** | **string** | Contact phone number in E.164 (international) format without leading + or zeroes | 
**Email** | **string** | Contact email | [optional] 
**CompanyName** | **string** | Contact company name | [optional] 
**Lists** | **string** | Array of list resources id contact will be assigned to | 
**Favorited** | **bool?** | Is contact favorited | [optional] 
**Blocked** | **bool?** | Is contact blocked for outgoing and incoming messaging | [optional] 
**Type** | **int?** | Force type of phone. Possible values: 0 - landline, 1 - mobile. Default is -1 (auto detection) | [optional] 
**CustomFieldValues** | **Object** |  | [optional] 
**Local** | **int?** | Treat phone number passed in request body as local | [optional] 
**Country** | **string** | 2-letter ISO country code for local phone numbers, used when local is  set to true. Default is account country | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

