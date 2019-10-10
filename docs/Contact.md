# TextMagicClient.Model.Contact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Contact ID. | 
**Favorited** | **bool?** | Is the Contact favourite? [Custom fields list](http://docs.textmagictesting.com/#operation/getFavourites). | 
**Blocked** | **bool?** | Is the Contact blocked? [Custom fields list](http://docs.textmagictesting.com/#operation/getBlockedContacts). | 
**FirstName** | **string** | Contact first name. | 
**LastName** | **string** | Contact last name. | 
**CompanyName** | **string** | Company name. | 
**Phone** | **string** | Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164). | 
**Email** | **string** | Contact email address. | 
**Country** | [**Country**](Country.md) | Contact country. | 
**CustomFields** | [**List&lt;ContactCustomField&gt;**](ContactCustomField.md) | See [Custom Fields](http://docs.textmagictesting.com/#tag/Custom-Fields) section. | 
**User** | [**User**](User.md) |  | 
**Lists** | **List&lt;List&gt;** |  | 
**PhoneType** | **string** |  | 
**Avatar** | [**ContactImage**](ContactImage.md) |  | 
**Notes** | [**List&lt;ContactNote&gt;**](ContactNote.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

