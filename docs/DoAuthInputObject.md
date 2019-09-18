# TextMagicClient.Model.DoAuthInputObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | Account username or email | 
**Password** | **string** | Account password | 
**AppName** | **string** | Application name | [optional] 
**AppVersion** | **string** | Application version | [optional] 
**DeviceId** | **string** | Device ID for push notification service | [optional] 
**PushServiceType** | **string** | required when deviceId provided. Push notification service type: a for Apple Push Notifications, g for Google Cloud Messaging | [optional] 
**TfaCode** | **string** | required when 2FA enabled on account. 2FA challenge response (SMS code or security question answer) | [optional] 
**TfaId** | **string** | required when 2FA enabled on account. 2FA challenge response (SMS code or security question answer) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

