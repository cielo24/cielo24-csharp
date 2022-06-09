# cielo24.Api.JobApi

All URIs are relative to *https://api.cielo24.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMediaFile**](JobApi.md#addmediafile) | **POST** /job/add_media | 
[**AddMediaUrl**](JobApi.md#addmediaurl) | **GET** /job/add_media | 
[**AuthorizeJob**](JobApi.md#authorizejob) | **POST** /job/authorize | 
[**GetCaption**](JobApi.md#getcaption) | **GET** /job/get_caption | 
[**JobInfo**](JobApi.md#jobinfo) | **GET** /job/info | 
[**NewJob**](JobApi.md#newjob) | **POST** /job/new | 
[**PerformTranscription**](JobApi.md#performtranscription) | **POST** /job/perform_transcription | 
[**PerformTranslation**](JobApi.md#performtranslation) | **POST** /job/perform_translation | 


<a name="addmediafile"></a>
# **AddMediaFile**
> AddMediaResponse AddMediaFile (int v, string jobId, int contentLength, System.IO.Stream body, string isDuplicate = null)



Add a piece of media to an existing job using a local file. No content-type should be included in the HTTP header. The media should be uploaded as raw binary, no encoding (base64, hex, etc) is required. Chunk-transfer encoding is NOT supported. File size is limited to 10 gb

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class AddMediaFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var jobId = 0fbd6015910e42dca25a863c4925d77c;  // string | 
            var contentLength = 56;  // int | 
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var isDuplicate = "true";  // string |  (optional)  (default to false)

            try
            {
                AddMediaResponse result = apiInstance.AddMediaFile(v, jobId, contentLength, body, isDuplicate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.AddMediaFile: " + e.Message );
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
 **jobId** | **string**|  | 
 **contentLength** | **int**|  | 
 **body** | **System.IO.Stream****System.IO.Stream**|  | 
 **isDuplicate** | **string**|  | [optional] [default to false]

### Return type

[**AddMediaResponse**](AddMediaResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: video/mp4
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmediaurl"></a>
# **AddMediaUrl**
> AddMediaResponse AddMediaUrl (int v, string jobId, string mediaUrl, string isDuplicate = null)



Add a piece of media to an existing job using a public media url. A job may only have a single piece of media associated with it, attempting to add additional media will return an error code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class AddMediaUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var jobId = 0fbd6015910e42dca25a863c4925d77c;  // string | 
            var mediaUrl = http://www.domain.com/video.mp4;  // string | 
            var isDuplicate = "true";  // string |  (optional)  (default to false)

            try
            {
                AddMediaResponse result = apiInstance.AddMediaUrl(v, jobId, mediaUrl, isDuplicate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.AddMediaUrl: " + e.Message );
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
 **jobId** | **string**|  | 
 **mediaUrl** | **string**|  | 
 **isDuplicate** | **string**|  | [optional] [default to false]

### Return type

[**AddMediaResponse**](AddMediaResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authorizejob"></a>
# **AuthorizeJob**
> void AuthorizeJob (int v, string jobId)



Authorize an existing job. If your account has the \"customer authorization\" feature enabled (it is not enabled by default) jobs you create will be held in the \"Authorizing\" state until you call this method. Calling this method on a job that is not the \"Authorizing\" state has no effect and will return success. Please contact support@cielo24.com to enable the \"customer authorization\" feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class AuthorizeJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var jobId = 0fbd6015910e42dca25a863c4925d77c;  // string | 

            try
            {
                apiInstance.AuthorizeJob(v, jobId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.AuthorizeJob: " + e.Message );
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
 **jobId** | **string**|  | 

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
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcaption"></a>
# **GetCaption**
> string GetCaption (int v, string jobId, string captionFormat, string buildUrl = null, int? captionWordsMin = null, string captionBySentence = null, int? charactersPerCaptionLine = null, string dfxpHeader = null, string disallowDangling = null, string displayEffectsSpeakerAs = null, string displaySpeakerId = null, string iwpName = null, string elementlistVersion = null, string emitSpeakerChangeTokensAs = null, string forceCase = null, string includeDfxpMetadata = null, int? layoutTargetCaptionLengthMs = null, string lineBreakOnSentence = null, string lineEndingFormat = null, int? linesPerCaption = null, string maskProfanity = null, int? maximumCaptionDuration = null, int? mergeGapInterval = null, int? minimumCaptionLengthMs = null, int? minimumGapBetweenCaptionsMs = null, string qtSeamless = null, string removeDisfluencies = null, List<string> removeSoundsList = null, string removeSoundReferences = null, string replaceSlang = null, int? silenceMaxMs = null, string singleSpeakerPerCaption = null, List<string> soundBoundaries = null, int? soundThreshold = null, string soundTokensByCaption = null, string soundTokensByLine = null, List<string> soundTokensByCaptionList = null, List<string> soundTokensByLineList = null, string speakerOnNewLine = null, string srtFormat = null, string stripSquareBrackets = null, string utf8Mark = null, string replaceEnglishSpelling = null)



Get the caption file for a job. The job must have completed transcription before a caption can be downloaded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class GetCaptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var jobId = 0fbd6015910e42dca25a863c4925d77c;  // string | 
            var captionFormat = SRT;  // string | 
            var buildUrl = false;  // string | Rather than returning the file, return a permanent URL to the file. (optional)  (default to false)
            var captionWordsMin = 3;  // int? | Minimum number of words allowed in a caption. (optional)  (default to 1)
            var captionBySentence = false;  // string | When true, puts each sentence into its own caption. When false, more than one sentence may appear in a single caption. (optional)  (default to true)
            var charactersPerCaptionLine = 30;  // int? | Maximum number of characters to be displayed on each caption line. (optional)  (default to 42)
            var dfxpHeader = <head></head>;  // string | Allows you to specify a custom header for your DFXP caption file. The header should be the entire contents of the header including the opening and closing tags. Ignored if caption_format does not equal DFXP. (optional)  (default to "")
            var disallowDangling = true;  // string | Will prevent captions from having the last word in a sentence start a new line. Last words will ALWAYS be kept on the same line, even if it breaks the characters_per_caption_line option. (optional)  (default to false)
            var displayEffectsSpeakerAs = Sounds;  // string | Determines what speaker name should used for sound effects. (optional)  (default to "Effects")
            var displaySpeakerId = number;  // string | Determines the way speakers are identified in the captions. Choose \"no\" to not display speaker identities at all: \">> example\" Choose \"number\" to display only the speaker number: \">> Speaker 1: example\" Choose \"name\" to display the speaker name: \">> John Doe: example\". If you choose \"name\", the speaker number will be displayed if the name is not available. (optional)  (default to name)
            var iwpName = MECHANICAL;  // string | The named version of element list to generate the transcript from. If not specified, the transcript will be generated from the latest version. (optional) 
            var elementlistVersion = 2014-07-31T12:35:52.324389;  // string | The version of element list to generate the captions from. If not specified, the caption will be generated from the latest version. (ISO 8601 Date String) (optional)  (default to "")
            var emitSpeakerChangeTokensAs = -->;  // string | Determine what characters to use to denote speaker changes. (optional)  (default to ">>")
            var forceCase = lower;  // string | Force the contents of the captions to be all UPPER or lower case. If blank, the case of the captions is not changed. (optional) 
            var includeDfxpMetadata = false;  // string | When true, and the caption format requested is DFXP, the jobs name, ID and language will be added to the DFXP metadata header. When false, these data are omitted from the header. Ignored if caption_format does not equal DFXP. (optional)  (default to true)
            var layoutTargetCaptionLengthMs = 4000;  // int? | Captions generated will, on average, be this duration. However, they may vary significantly based on other parameters you set. (optional)  (default to 5000)
            var lineBreakOnSentence = true;  // string | Inserts a line break in between sentences that are in the same caption. (optional)  (default to false)
            var lineEndingFormat = OSX;  // string | Determine the end of line (EOL) character to use for the captions. (optional)  (default to UNIX)
            var linesPerCaption = 3;  // int? | Number of lines to be displayed for each caption. (optional)  (default to 2)
            var maskProfanity = true;  // string | Replace profanity with asterisks. (optional)  (default to false)
            var maximumCaptionDuration = 10000;  // int? | No captions longer than this (in milliseconds) will be produced. If not specified, there is no maximum. (optional) 
            var mergeGapInterval = 1500;  // int? | Captions with a gap between them that is smaller than this (in milliseconds) will have their start and/or end times changed so there is no time gap between the captions. (optional)  (default to 1000)
            var minimumCaptionLengthMs = 1500;  // int? | Extends the duration of short captions to the this minimum length. Additional time is taken from later caption blocks to meet this minimum time. (optional) 
            var minimumGapBetweenCaptionsMs = 100;  // int? | Adds a minimum time between captions such as there will always be some time between captions where no text is displayed. When captions are very close together, time will be removed from the caption duration to make the gap. (optional) 
            var qtSeamless = true;  // string | Does not put time gaps of any kind between caption blocks. Ignored if caption_format does not equal QT. (optional)  (default to false)
            var removeDisfluencies = false;  // string | Remove verbal disfluencies from the generated transcript. Common disfluencies such as \"um\" and \"ah\" are removed while maintaining appropriate punctuation. (optional)  (default to true)
            var removeSoundsList = new List<string>(); // List<string> | A list of sounds to not show in the caption. This is a JSON style list, and should look like [\"MUSIC\", \"LAUGH\"]. Ignored if remove_sound_references is true. (optional) 
            var removeSoundReferences = false;  // string | Remove ALL non-verbal sound and noise references from the generated transcript. Sounds and unidentified noises are depicted in the caption as [SOUND], [COUGH] and [NOISE]. If this parameter is set, these identifiers are omitted from the caption. (optional)  (default to true)
            var replaceSlang = true;  // string | Replace common slang terms from the generated transcript. Common replacements are \"want to\" for \"wanna\", \"going to\" for \"gonna\", etc. (optional)  (default to false)
            var silenceMaxMs = 1000;  // int? | If there is a interval of silence in the middle of a sentence longer than this, then the caption will be split. (optional)  (default to 2000)
            var singleSpeakerPerCaption = false;  // string | When true, puts each speaker into its own caption. When false, more than one speaker may appear in a single caption. (optional)  (default to true)
            var soundBoundaries = new List<string>(); // List<string> | Specifies the characters to surround sound references with. The default will generate sound references that look like this: [MUSIC]. (optional) 
            var soundThreshold = 5000;  // int? | Sound references that are longer than this threshold will be made their own caption entirely, and will not have any text included with them. If not set, Sound references will be included back to back with text no matter the duration of the sound. (optional) 
            var soundTokensByCaption = true;  // string | If true, all sound references will always be in their own caption. If false, more than one sound reference may appear in a single caption. (optional)  (default to false)
            var soundTokensByLine = true;  // string | If true, all sound references will always be in their own line. If false, more than one sound reference may appear in a single line. (optional)  (default to false)
            var soundTokensByCaptionList = new List<string>(); // List<string> | If non-empty, the specified sound references will always be in their own caption. If empty, more than one sound reference may appear in a single caption. Ignored if sound_tokens_by_caption is true. (optional) 
            var soundTokensByLineList = new List<string>(); // List<string> | If non-empty, the specified sound references will always be in their own line. If empty, more than one sound reference may appear in a single line. Ignored if sound_tokens_by_line is true. (optional) 
            var speakerOnNewLine = false;  // string | If true, a speaker change will cause a new caption to be made. If false, multiple speakers may appear in a single caption. (optional)  (default to true)
            var srtFormat = {caption_number:d}\n{start_hour:02d}:{start_minute:02d}:{start_second:02d},{start_millisecond:03d} -->{end_hour:02d}:{end_minute:02d}:{end_second:02d},{end_millisecond:03d}\n{caption_text}\n\n;  // string | If the caption format is SRT, determines what the caption blocks will look like. The default, prints caption blocks that look like this:    1:   00:00:06,060 - -> 00:00:16,060   This is the caption text.  You can alter the caption block by re-arranging or removing the substitution string values, shown enclosed in braces \"{}\" in the default value below. Substitution strings may used more than once if desired. Any text that is not a substitution string will be displayed as written. To add new lines, include a \\n. Note, you may need to escape the \\n with an extra backslash when encoding the request.  (optional)  (default to "{caption_number:d}\n{start_hour:02d}:{start_minute:02d}:{start_second:02d},{start_millisecond:03d} -->{end_hour:02d}:{end_minute:02d}:{end_second:02d},{end_millisecond:03d}\n{caption_text}\n\n")
            var stripSquareBrackets = true;  // string | Removes all square brackets like '[' or ']' from captions. By default square brackets surround sound references like '[MUSIC]', but they may exist as part of the caption text as well. (optional)  (default to false)
            var utf8Mark = true;  // string | Adds a utf8 bytemark to the beginning of the caption. This should only be used if the system you are loading the caption files into needs a byte marker. The vast majority of systems do not. (optional)  (default to false)
            var replaceEnglishSpelling = B;  // string | Replaces English spelling with location accurate spelling. i.e. Color - -> Colour  A: American  B: British  Z: British ize  U: Australian  C: Canadian  (optional)  (default to A)

            try
            {
                string result = apiInstance.GetCaption(v, jobId, captionFormat, buildUrl, captionWordsMin, captionBySentence, charactersPerCaptionLine, dfxpHeader, disallowDangling, displayEffectsSpeakerAs, displaySpeakerId, iwpName, elementlistVersion, emitSpeakerChangeTokensAs, forceCase, includeDfxpMetadata, layoutTargetCaptionLengthMs, lineBreakOnSentence, lineEndingFormat, linesPerCaption, maskProfanity, maximumCaptionDuration, mergeGapInterval, minimumCaptionLengthMs, minimumGapBetweenCaptionsMs, qtSeamless, removeDisfluencies, removeSoundsList, removeSoundReferences, replaceSlang, silenceMaxMs, singleSpeakerPerCaption, soundBoundaries, soundThreshold, soundTokensByCaption, soundTokensByLine, soundTokensByCaptionList, soundTokensByLineList, speakerOnNewLine, srtFormat, stripSquareBrackets, utf8Mark, replaceEnglishSpelling);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.GetCaption: " + e.Message );
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
 **jobId** | **string**|  | 
 **captionFormat** | **string**|  | 
 **buildUrl** | **string**| Rather than returning the file, return a permanent URL to the file. | [optional] [default to false]
 **captionWordsMin** | **int?**| Minimum number of words allowed in a caption. | [optional] [default to 1]
 **captionBySentence** | **string**| When true, puts each sentence into its own caption. When false, more than one sentence may appear in a single caption. | [optional] [default to true]
 **charactersPerCaptionLine** | **int?**| Maximum number of characters to be displayed on each caption line. | [optional] [default to 42]
 **dfxpHeader** | **string**| Allows you to specify a custom header for your DFXP caption file. The header should be the entire contents of the header including the opening and closing tags. Ignored if caption_format does not equal DFXP. | [optional] [default to &quot;&quot;]
 **disallowDangling** | **string**| Will prevent captions from having the last word in a sentence start a new line. Last words will ALWAYS be kept on the same line, even if it breaks the characters_per_caption_line option. | [optional] [default to false]
 **displayEffectsSpeakerAs** | **string**| Determines what speaker name should used for sound effects. | [optional] [default to &quot;Effects&quot;]
 **displaySpeakerId** | **string**| Determines the way speakers are identified in the captions. Choose \&quot;no\&quot; to not display speaker identities at all: \&quot;&gt;&gt; example\&quot; Choose \&quot;number\&quot; to display only the speaker number: \&quot;&gt;&gt; Speaker 1: example\&quot; Choose \&quot;name\&quot; to display the speaker name: \&quot;&gt;&gt; John Doe: example\&quot;. If you choose \&quot;name\&quot;, the speaker number will be displayed if the name is not available. | [optional] [default to name]
 **iwpName** | **string**| The named version of element list to generate the transcript from. If not specified, the transcript will be generated from the latest version. | [optional] 
 **elementlistVersion** | **string**| The version of element list to generate the captions from. If not specified, the caption will be generated from the latest version. (ISO 8601 Date String) | [optional] [default to &quot;&quot;]
 **emitSpeakerChangeTokensAs** | **string**| Determine what characters to use to denote speaker changes. | [optional] [default to &quot;&gt;&gt;&quot;]
 **forceCase** | **string**| Force the contents of the captions to be all UPPER or lower case. If blank, the case of the captions is not changed. | [optional] 
 **includeDfxpMetadata** | **string**| When true, and the caption format requested is DFXP, the jobs name, ID and language will be added to the DFXP metadata header. When false, these data are omitted from the header. Ignored if caption_format does not equal DFXP. | [optional] [default to true]
 **layoutTargetCaptionLengthMs** | **int?**| Captions generated will, on average, be this duration. However, they may vary significantly based on other parameters you set. | [optional] [default to 5000]
 **lineBreakOnSentence** | **string**| Inserts a line break in between sentences that are in the same caption. | [optional] [default to false]
 **lineEndingFormat** | **string**| Determine the end of line (EOL) character to use for the captions. | [optional] [default to UNIX]
 **linesPerCaption** | **int?**| Number of lines to be displayed for each caption. | [optional] [default to 2]
 **maskProfanity** | **string**| Replace profanity with asterisks. | [optional] [default to false]
 **maximumCaptionDuration** | **int?**| No captions longer than this (in milliseconds) will be produced. If not specified, there is no maximum. | [optional] 
 **mergeGapInterval** | **int?**| Captions with a gap between them that is smaller than this (in milliseconds) will have their start and/or end times changed so there is no time gap between the captions. | [optional] [default to 1000]
 **minimumCaptionLengthMs** | **int?**| Extends the duration of short captions to the this minimum length. Additional time is taken from later caption blocks to meet this minimum time. | [optional] 
 **minimumGapBetweenCaptionsMs** | **int?**| Adds a minimum time between captions such as there will always be some time between captions where no text is displayed. When captions are very close together, time will be removed from the caption duration to make the gap. | [optional] 
 **qtSeamless** | **string**| Does not put time gaps of any kind between caption blocks. Ignored if caption_format does not equal QT. | [optional] [default to false]
 **removeDisfluencies** | **string**| Remove verbal disfluencies from the generated transcript. Common disfluencies such as \&quot;um\&quot; and \&quot;ah\&quot; are removed while maintaining appropriate punctuation. | [optional] [default to true]
 **removeSoundsList** | [**List&lt;string&gt;**](string.md)| A list of sounds to not show in the caption. This is a JSON style list, and should look like [\&quot;MUSIC\&quot;, \&quot;LAUGH\&quot;]. Ignored if remove_sound_references is true. | [optional] 
 **removeSoundReferences** | **string**| Remove ALL non-verbal sound and noise references from the generated transcript. Sounds and unidentified noises are depicted in the caption as [SOUND], [COUGH] and [NOISE]. If this parameter is set, these identifiers are omitted from the caption. | [optional] [default to true]
 **replaceSlang** | **string**| Replace common slang terms from the generated transcript. Common replacements are \&quot;want to\&quot; for \&quot;wanna\&quot;, \&quot;going to\&quot; for \&quot;gonna\&quot;, etc. | [optional] [default to false]
 **silenceMaxMs** | **int?**| If there is a interval of silence in the middle of a sentence longer than this, then the caption will be split. | [optional] [default to 2000]
 **singleSpeakerPerCaption** | **string**| When true, puts each speaker into its own caption. When false, more than one speaker may appear in a single caption. | [optional] [default to true]
 **soundBoundaries** | [**List&lt;string&gt;**](string.md)| Specifies the characters to surround sound references with. The default will generate sound references that look like this: [MUSIC]. | [optional] 
 **soundThreshold** | **int?**| Sound references that are longer than this threshold will be made their own caption entirely, and will not have any text included with them. If not set, Sound references will be included back to back with text no matter the duration of the sound. | [optional] 
 **soundTokensByCaption** | **string**| If true, all sound references will always be in their own caption. If false, more than one sound reference may appear in a single caption. | [optional] [default to false]
 **soundTokensByLine** | **string**| If true, all sound references will always be in their own line. If false, more than one sound reference may appear in a single line. | [optional] [default to false]
 **soundTokensByCaptionList** | [**List&lt;string&gt;**](string.md)| If non-empty, the specified sound references will always be in their own caption. If empty, more than one sound reference may appear in a single caption. Ignored if sound_tokens_by_caption is true. | [optional] 
 **soundTokensByLineList** | [**List&lt;string&gt;**](string.md)| If non-empty, the specified sound references will always be in their own line. If empty, more than one sound reference may appear in a single line. Ignored if sound_tokens_by_line is true. | [optional] 
 **speakerOnNewLine** | **string**| If true, a speaker change will cause a new caption to be made. If false, multiple speakers may appear in a single caption. | [optional] [default to true]
 **srtFormat** | **string**| If the caption format is SRT, determines what the caption blocks will look like. The default, prints caption blocks that look like this:    1:   00:00:06,060 - -&gt; 00:00:16,060   This is the caption text.  You can alter the caption block by re-arranging or removing the substitution string values, shown enclosed in braces \&quot;{}\&quot; in the default value below. Substitution strings may used more than once if desired. Any text that is not a substitution string will be displayed as written. To add new lines, include a \\n. Note, you may need to escape the \\n with an extra backslash when encoding the request.  | [optional] [default to &quot;{caption_number:d}\n{start_hour:02d}:{start_minute:02d}:{start_second:02d},{start_millisecond:03d} --&gt;{end_hour:02d}:{end_minute:02d}:{end_second:02d},{end_millisecond:03d}\n{caption_text}\n\n&quot;]
 **stripSquareBrackets** | **string**| Removes all square brackets like &#39;[&#39; or &#39;]&#39; from captions. By default square brackets surround sound references like &#39;[MUSIC]&#39;, but they may exist as part of the caption text as well. | [optional] [default to false]
 **utf8Mark** | **string**| Adds a utf8 bytemark to the beginning of the caption. This should only be used if the system you are loading the caption files into needs a byte marker. The vast majority of systems do not. | [optional] [default to false]
 **replaceEnglishSpelling** | **string**| Replaces English spelling with location accurate spelling. i.e. Color - -&gt; Colour  A: American  B: British  Z: British ize  U: Australian  C: Canadian  | [optional] [default to A]

### Return type

**string**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobinfo"></a>
# **JobInfo**
> JobInfoResponse JobInfo (int v, string jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class JobInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var jobId = 0fbd6015910e42dca25a863c4925d77c;  // string | 

            try
            {
                JobInfoResponse result = apiInstance.JobInfo(v, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.JobInfo: " + e.Message );
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
 **jobId** | **string**|  | 

### Return type

[**JobInfoResponse**](JobInfoResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newjob"></a>
# **NewJob**
> NewJobResponse NewJob (int v, NewJobBody newJobBody)



Create a new job. A job is a container into which you can upload media and request that transcription be performed. Creating a job is prerequisite for virtually all other methods.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class NewJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var newJobBody = new NewJobBody(); // NewJobBody | 

            try
            {
                NewJobResponse result = apiInstance.NewJob(v, newJobBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.NewJob: " + e.Message );
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
 **newJobBody** | [**NewJobBody**](NewJobBody.md)|  | 

### Return type

[**NewJobResponse**](NewJobResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performtranscription"></a>
# **PerformTranscription**
> PerformTranscriptionResponse PerformTranscription (int v, PerformTranscriptionBody performTranscriptionBody)



Request that transcription be performed on the specified job. A callback URL, if specified, will be called when the transcription is complete. See [callback documentation](https://cielo24.readthedocs.io/en/latest/basics.html#callbacks-label) for details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class PerformTranscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var performTranscriptionBody = new PerformTranscriptionBody(); // PerformTranscriptionBody | 

            try
            {
                PerformTranscriptionResponse result = apiInstance.PerformTranscription(v, performTranscriptionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.PerformTranscription: " + e.Message );
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
 **performTranscriptionBody** | [**PerformTranscriptionBody**](PerformTranscriptionBody.md)|  | 

### Return type

[**PerformTranscriptionResponse**](PerformTranscriptionResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performtranslation"></a>
# **PerformTranslation**
> PerformTranslationResponse PerformTranslation (int v, string jobId, string targetLanguages, string approveUplevel = null)



Request that orders a new Translation language for a video that has been previously Transcribed and/or Translated. The New Job ID and job target language will be returned upon completion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cielo24.Api;
using cielo24.Client;
using cielo24.Model;

namespace Example
{
    public class PerformTranslationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cielo24.com/api";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_token", "Bearer");

            var apiInstance = new JobApi(config);
            var v = 1;  // int |  (default to 1)
            var jobId = 0fbd6015910e42dca25a863c4925d77c;  // string | 
            var targetLanguages = fr,de;  // string | The language(s) being ordered (Any RFC 5646 language code) separated by comma (,)
            var approveUplevel = true;  // string |  (optional) 

            try
            {
                PerformTranslationResponse result = apiInstance.PerformTranslation(v, jobId, targetLanguages, approveUplevel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobApi.PerformTranslation: " + e.Message );
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
 **jobId** | **string**|  | 
 **targetLanguages** | **string**| The language(s) being ordered (Any RFC 5646 language code) separated by comma (,) | 
 **approveUplevel** | **string**|  | [optional] 

### Return type

[**PerformTranslationResponse**](PerformTranslationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

