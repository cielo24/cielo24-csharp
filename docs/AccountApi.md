# cielo24.Api.AccountApi

All URIs are relative to *https://api.cielo24.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSettings**](AccountApi.md#getsettings) | **GET** /account/get_settings | 
[**Login**](AccountApi.md#login) | **POST** /account/login | 
[**Logout**](AccountApi.md#logout) | **POST** /account/logout | 
[**VerifyKey**](AccountApi.md#verifykey) | **GET** /account/verify_key | 


<a name="getsettings"></a>
# **GetSettings**
> Object GetSettings (int v)



Get Account Settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new AccountApi(config);
            var v = 1;  // int |  (default to 1)

            try
            {
                Object result = apiInstance.GetSettings(v);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetSettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **v** | **int**|  | [default to 1]

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Test |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> LoginResponse Login (int v, LoginBody loginBody)



Login to the cielo24 API to obtain an API access token for use when calling other methods. Optional arguments may be passed either as HTTP headers or query string parameters. Required arguments must be passed as query string parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            var apiInstance = new AccountApi(config);
            var v = 1;  // int |  (default to 1)
            var loginBody = new LoginBody(); // LoginBody | 

            try
            {
                LoginResponse result = apiInstance.Login(v, loginBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.Login: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **v** | **int**|  | [default to 1]
 **loginBody** | [**LoginBody**](LoginBody.md)|  | 

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout (int v)



Logout of the current session, invalidating the API token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new AccountApi(config);
            var v = 1;  // int |  (default to 1)

            try
            {
                apiInstance.Logout(v);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.Logout: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **v** | **int**|  | [default to 1]

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifykey"></a>
# **VerifyKey**
> VerifyKeyResponse VerifyKey (int v)



Test Auth

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class VerifyKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new AccountApi(config);
            var v = 1;  // int |  (default to 1)

            try
            {
                VerifyKeyResponse result = apiInstance.VerifyKey(v);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.VerifyKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **v** | **int**|  | [default to 1]

### Return type

[**VerifyKeyResponse**](VerifyKeyResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Test |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

