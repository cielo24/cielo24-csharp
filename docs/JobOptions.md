# cielo24.Model.JobOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerApprovalSteps** | **List&lt;string&gt;** | Requires your approval of a job at specified points in the workflow. When the job is ready for approval you will be emailed a link that will take you to a web based tool you can use to view, edit and approve the job. You may request approval at two points in the workflow: before translation and before the job is returned. | [optional] 
**CustomerApprovalTool** | **string** | Determines which web based tool to use for viewing, editing and approving jobs. | [optional] [default to CustomerApprovalToolEnum.CIELO24]
**CustomMetadata** | **Object** | A JSON dictionary of key value pairs. These will be used as substitution strings when building the callback URL and custom DFXP caption header. | [optional] 
**Notes** | **Object** | Allows you to provide text that will be displayed to the transcriber when the job is processed. An HTML included will be escaped. | [optional] 
**ReturnIwp** | [**List&lt;IWPEnum&gt;**](IWPEnum.md) | Allows you to receive additional callbacks when interim versions of the job are completed. If you specified a callback_url, then a callback will sent for FINAL regardless of the value of this option. | [optional] 
**GenerateMediaIntelligenceIwp** | [**List&lt;IWPEnum&gt;**](IWPEnum.md) | Requests that media intelligence be generated for the specified interim/final versions of the transcript. Media intelligence data is added to the ElementList and can be retrieve using the get_elementlist API call. See [ElementList](https://cielo24.readthedocs.io/en/latest/output_formats/elementlist.html#media-intelligence-label) for details. | [optional] 
**SpeakerId** | **string** | Requests that speaker names be identified. | [optional] [default to SpeakerIdEnum.False]
**AudioDescription** | **string** | Requests that all noises and sounds be identified. | [optional] [default to AudioDescriptionEnum.False]
**OnScreenText** | **string** | Requests that any text that appears in the media be added to the transcription. | [optional] [default to OnScreenTextEnum.False]
**MusicLyrics** | **string** | Requests that lyrics to songs be transcribed instead of labeled [MUSIC]. | [optional] [default to MusicLyricsEnum.False]
**CustomSpecialHandling** | **string** | Requests that transcribers follow submitted instruction set. | [optional] [default to CustomSpecialHandlingEnum.False]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

