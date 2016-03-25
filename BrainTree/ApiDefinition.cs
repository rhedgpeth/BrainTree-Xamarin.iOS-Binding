using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using SafariServices;
using UIKit;

namespace BrainTree
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeCardVersionNumber;
		//[Field ("BraintreeCardVersionNumber", "__Internal")]
		//double BraintreeCardVersionNumber { get; }

		// extern const unsigned char [] BraintreeCardVersionString;
		//[Field ("BraintreeCardVersionString", "__Internal")]
		//IntPtr BraintreeCardVersionString { get; } //byte[]

		// extern double BraintreeCoreVersionNumber;
		//[Field ("BraintreeCoreVersionNumber", "__Internal")]
		//double BraintreeCoreVersionNumber { get; }

		// extern const unsigned char [] BraintreeCoreVersionString;
		//[Field ("BraintreeCoreVersionString", "__Internal")]
		//IntPtr BraintreeCoreVersionString { get; }

		// extern NSString *const _Nonnull BTJSONErrorDomain;
		[Field ("BTJSONErrorDomain", "__Internal")]
		NSString BTJSONErrorDomain { get; }

		// extern NSString *const _Nonnull BTAPIClientErrorDomain;
		[Field ("BTAPIClientErrorDomain", "__Internal")]
		NSString BTAPIClientErrorDomain { get; }

		// extern NSString *const _Nonnull BTAppSwitchWillSwitchNotification;
		[Field ("BTAppSwitchWillSwitchNotification", "__Internal")]
		NSString BTAppSwitchWillSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchDidSwitchNotification;
		[Field ("BTAppSwitchDidSwitchNotification", "__Internal")]
		NSString BTAppSwitchDidSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchWillProcessPaymentInfoNotification;
		[Field ("BTAppSwitchWillProcessPaymentInfoNotification", "__Internal")]
		NSString BTAppSwitchWillProcessPaymentInfoNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchNotificationTargetKey;
		[Field ("BTAppSwitchNotificationTargetKey", "__Internal")]
		NSString BTAppSwitchNotificationTargetKey { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyVersion;
		[Field ("BTClientTokenKeyVersion", "__Internal")]
		NSString BTClientTokenKeyVersion { get; }

		// extern NSString *const _Nonnull BTClientTokenErrorDomain;
		[Field ("BTClientTokenErrorDomain", "__Internal")]
		NSString BTClientTokenErrorDomain { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyAuthorizationFingerprint;
		[Field ("BTClientTokenKeyAuthorizationFingerprint", "__Internal")]
		NSString BTClientTokenKeyAuthorizationFingerprint { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyConfigURL;
		[Field ("BTClientTokenKeyConfigURL", "__Internal")]
		NSString BTClientTokenKeyConfigURL { get; }

		// extern NSString *const _Nonnull BTCustomerInputBraintreeValidationErrorsKey;
		[Field ("BTCustomerInputBraintreeValidationErrorsKey", "__Internal")]
		NSString BTCustomerInputBraintreeValidationErrorsKey { get; }

		// extern NSString *const BTHTTPErrorDomain;
		[Field ("BTHTTPErrorDomain", "__Internal")]
		NSString BTHTTPErrorDomain { get; }

		// extern NSString *const BTHTTPURLResponseKey;
		[Field ("BTHTTPURLResponseKey", "__Internal")]
		NSString BTHTTPURLResponseKey { get; }

		// extern NSString *const BTHTTPJSONResponseBodyKey;
		[Field ("BTHTTPJSONResponseBodyKey", "__Internal")]
		NSString BTHTTPJSONResponseBodyKey { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceErrorDomain;
		[Field ("BTTokenizationServiceErrorDomain", "__Internal")]
		NSString BTTokenizationServiceErrorDomain { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceViewPresentingDelegateOption;
		[Field ("BTTokenizationServiceViewPresentingDelegateOption", "__Internal")]
		NSString BTTokenizationServiceViewPresentingDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServicePayPalScopesOption;
		[Field ("BTTokenizationServicePayPalScopesOption", "__Internal")]
		NSString BTTokenizationServicePayPalScopesOption { get; }

		// extern NSString *const _Nonnull BTCardClientErrorDomain;
		[Field ("BTCardClientErrorDomain", "__Internal")]
		NSString BTCardClientErrorDomain { get; }

		// extern double BraintreePayPalVersionNumber;
		//[Field ("BraintreePayPalVersionNumber", "__Internal")]
		//double BraintreePayPalVersionNumber { get; }

		// extern const unsigned char [] BraintreePayPalVersionString;
		//[Field ("BraintreePayPalVersionString", "__Internal")]
		//IntPtr BraintreePayPalVersionString { get; } //byte[]

		// extern NSString *const _Nonnull BTPayPalDriverErrorDomain;
		[Field ("BTPayPalDriverErrorDomain", "__Internal")]
		NSString BTPayPalDriverErrorDomain { get; }

		// extern double BraintreeUIVersionNumber;
		//[Field ("BraintreeUIVersionNumber", "__Internal")]
		//double BraintreeUIVersionNumber { get; }

		// extern const unsigned char [] BraintreeUIVersionString;
		//[Field ("BraintreeUIVersionString", "__Internal")]
		//IntPtr BraintreeUIVersionString { get; } //byte[]

		// extern NSString *const PayPalEnvironmentProduction;
		[Field ("PayPalEnvironmentProduction", "__Internal")]
		NSString PayPalEnvironmentProduction { get; }

		// extern NSString *const PayPalEnvironmentSandbox;
		[Field ("PayPalEnvironmentSandbox", "__Internal")]
		NSString PayPalEnvironmentSandbox { get; }

		// extern NSString *const PayPalEnvironmentMock;
		[Field ("PayPalEnvironmentMock", "__Internal")]
		NSString PayPalEnvironmentMock { get; }
	}

	/*
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const PayPalEnvironmentProduction;
		[Field ("PayPalEnvironmentProduction", "__Internal")]
		NSString PayPalEnvironmentProduction { get; }

		// extern NSString *const PayPalEnvironmentSandbox;
		[Field ("PayPalEnvironmentSandbox", "__Internal")]
		NSString PayPalEnvironmentSandbox { get; }

		// extern NSString *const PayPalEnvironmentMock;
		[Field ("PayPalEnvironmentMock", "__Internal")]
		NSString PayPalEnvironmentMock { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeUIVersionNumber;
		[Field ("BraintreeUIVersionNumber", "__Internal")]
		double BraintreeUIVersionNumber { get; }

		// extern const unsigned char [] BraintreeUIVersionString;
		[Field ("BraintreeUIVersionString", "__Internal")]
		byte[] BraintreeUIVersionString { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTPayPalDriverErrorDomain;
		[Field ("BTPayPalDriverErrorDomain", "__Internal")]
		NSString BTPayPalDriverErrorDomain { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreePayPalVersionNumber;
		[Field ("BraintreePayPalVersionNumber", "__Internal")]
		double BraintreePayPalVersionNumber { get; }

		// extern const unsigned char [] BraintreePayPalVersionString;
		[Field ("BraintreePayPalVersionString", "__Internal")]
		byte[] BraintreePayPalVersionString { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTCardClientErrorDomain;
		[Field ("BTCardClientErrorDomain", "__Internal")]
		NSString BTCardClientErrorDomain { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTTokenizationServiceErrorDomain;
		[Field ("BTTokenizationServiceErrorDomain", "__Internal")]
		NSString BTTokenizationServiceErrorDomain { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceViewPresentingDelegateOption;
		[Field ("BTTokenizationServiceViewPresentingDelegateOption", "__Internal")]
		NSString BTTokenizationServiceViewPresentingDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServicePayPalScopesOption;
		[Field ("BTTokenizationServicePayPalScopesOption", "__Internal")]
		NSString BTTokenizationServicePayPalScopesOption { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTCustomerInputBraintreeValidationErrorsKey;
		[Field ("BTCustomerInputBraintreeValidationErrorsKey", "__Internal")]
		NSString BTCustomerInputBraintreeValidationErrorsKey { get; }

		// extern NSString *const BTHTTPErrorDomain;
		[Field ("BTHTTPErrorDomain", "__Internal")]
		NSString BTHTTPErrorDomain { get; }

		// extern NSString *const BTHTTPURLResponseKey;
		[Field ("BTHTTPURLResponseKey", "__Internal")]
		NSString BTHTTPURLResponseKey { get; }

		// extern NSString *const BTHTTPJSONResponseBodyKey;
		[Field ("BTHTTPJSONResponseBodyKey", "__Internal")]
		NSString BTHTTPJSONResponseBodyKey { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTClientTokenKeyVersion;
		[Field ("BTClientTokenKeyVersion", "__Internal")]
		NSString BTClientTokenKeyVersion { get; }

		// extern NSString *const _Nonnull BTClientTokenErrorDomain;
		[Field ("BTClientTokenErrorDomain", "__Internal")]
		NSString BTClientTokenErrorDomain { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyAuthorizationFingerprint;
		[Field ("BTClientTokenKeyAuthorizationFingerprint", "__Internal")]
		NSString BTClientTokenKeyAuthorizationFingerprint { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyConfigURL;
		[Field ("BTClientTokenKeyConfigURL", "__Internal")]
		NSString BTClientTokenKeyConfigURL { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAppSwitchWillSwitchNotification;
		[Field ("BTAppSwitchWillSwitchNotification", "__Internal")]
		NSString BTAppSwitchWillSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchDidSwitchNotification;
		[Field ("BTAppSwitchDidSwitchNotification", "__Internal")]
		NSString BTAppSwitchDidSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchWillProcessPaymentInfoNotification;
		[Field ("BTAppSwitchWillProcessPaymentInfoNotification", "__Internal")]
		NSString BTAppSwitchWillProcessPaymentInfoNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchNotificationTargetKey;
		[Field ("BTAppSwitchNotificationTargetKey", "__Internal")]
		NSString BTAppSwitchNotificationTargetKey { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTJSONErrorDomain;
		[Field ("BTJSONErrorDomain", "__Internal")]
		NSString BTJSONErrorDomain { get; }
	}*/

	// @interface BTClientMetadata : NSObject <NSCopying, NSMutableCopying>
	[BaseType (typeof(NSObject))]
	interface BTClientMetadata : INSCopying, INSMutableCopying
	{
		// @property (readonly, assign, nonatomic) BTClientMetadataIntegrationType integration;
		[Export ("integration", ArgumentSemantic.Assign)]
		BTClientMetadataIntegrationType Integration { get; }

		// @property (readonly, assign, nonatomic) BTClientMetadataSourceType source;
		[Export ("source", ArgumentSemantic.Assign)]
		BTClientMetadataSourceType Source { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sessionId;
		[Export ("sessionId")]
		string SessionId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull integrationString;
		[Export ("integrationString")]
		string IntegrationString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sourceString;
		[Export ("sourceString")]
		string SourceString { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nonnull parameters;
		[Export ("parameters", ArgumentSemantic.Strong)]
		NSDictionary Parameters { get; }
	}

	// @interface BTMutableClientMetadata : BTClientMetadata
	[BaseType (typeof(BTClientMetadata))]
	interface BTMutableClientMetadata
	{
		// -(void)setIntegration:(BTClientMetadataIntegrationType)integration;
		[Export ("setIntegration:")]
		void SetIntegration (BTClientMetadataIntegrationType integration);

		// -(void)setSource:(BTClientMetadataSourceType)source;
		[Export ("setSource:")]
		void SetSource (BTClientMetadataSourceType source);

		// -(void)setSessionId:(NSString * _Nonnull)sessionId;
		[Export ("setSessionId:")]
		void SetSessionId (string sessionId);
	}



	// @interface BTJSON : NSObject
	[BaseType (typeof(NSObject))]
	interface BTJSON
	{
		// -(instancetype _Nonnull)initWithValue:(id _Nonnull)value;
		[Export ("initWithValue:")]
		//[DesignatedInitializer]
		IntPtr Constructor (NSObject value);

		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		IntPtr Constructor (NSData data);

		// -(id _Nonnull)objectForKeyedSubscript:(NSString * _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		NSObject ObjectForKeyedSubscript (string key);

		// -(BTJSON * _Nonnull)objectAtIndexedSubscript:(NSUInteger)idx;
		[Export ("objectAtIndexedSubscript:")]
		BTJSON ObjectAtIndexedSubscript (uint idx);

		// @property (readonly, assign, nonatomic) BOOL isError;
		[Export ("isError")]
		bool IsError { get; }

		// -(NSError * _Nullable)asError;
		[NullAllowed, Export ("asError")]
		//[Verify (MethodToProperty)]
		NSError AsError { get; }

		// -(NSData * _Nullable)asJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("asJSONAndReturnError:")]
		[return: NullAllowed]
		NSData AsJSONAndReturnError ([NullAllowed] out NSError error);

		// -(NSString * _Nullable)asPrettyJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("asPrettyJSONAndReturnError:")]
		[return: NullAllowed]
		string AsPrettyJSONAndReturnError ([NullAllowed] out NSError error);

		// -(NSString * _Nullable)asString;
		[NullAllowed, Export ("asString")]
		//[Verify (MethodToProperty)]
		string AsString { get; }

		// -(NSArray<BTJSON *> * _Nullable)asArray;
		[NullAllowed, Export ("asArray")]
		//[Verify (MethodToProperty)]
		BTJSON[] AsArray { get; }

		// -(NSDecimalNumber * _Nullable)asNumber;
		[NullAllowed, Export ("asNumber")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber AsNumber { get; }

		// -(NSURL * _Nullable)asURL;
		[NullAllowed, Export ("asURL")]
		//[Verify (MethodToProperty)]
		NSUrl AsURL { get; }

		// -(NSArray<NSString *> * _Nullable)asStringArray;
		[NullAllowed, Export ("asStringArray")]
		//[Verify (MethodToProperty)]
		string[] AsStringArray { get; }

		// -(NSDictionary * _Nullable)asDictionary;
		[NullAllowed, Export ("asDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary AsDictionary { get; }

		// -(NSInteger)asIntegerOrZero;
		[Export ("asIntegerOrZero")]
		//[Verify (MethodToProperty)]
		nint AsIntegerOrZero { get; }

		// -(NSInteger)asEnum:(NSDictionary * _Nonnull)mapping orDefault:(NSInteger)defaultValue;
		[Export ("asEnum:orDefault:")]
		nint AsEnum (NSDictionary mapping, nint defaultValue);

		// @property (readonly, assign, nonatomic) BOOL isString;
		[Export ("isString")]
		bool IsString { get; }

		// @property (readonly, assign, nonatomic) BOOL isNumber;
		[Export ("isNumber")]
		bool IsNumber { get; }

		// @property (readonly, assign, nonatomic) BOOL isArray;
		[Export ("isArray")]
		bool IsArray { get; }

		// @property (readonly, assign, nonatomic) BOOL isObject;
		[Export ("isObject")]
		bool IsObject { get; }

		// @property (readonly, assign, nonatomic) BOOL isTrue;
		[Export ("isTrue")]
		bool IsTrue { get; }

		// @property (readonly, assign, nonatomic) BOOL isFalse;
		[Export ("isFalse")]
		bool IsFalse { get; }

		// @property (readonly, assign, nonatomic) BOOL isNull;
		[Export ("isNull")]
		bool IsNull { get; }
	}

	// @interface BTConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTConfiguration
	{
		// -(instancetype _Nonnull)initWithJSON:(BTJSON * _Nonnull)json __attribute__((objc_designated_initializer));
		[Export ("initWithJSON:")]
		IntPtr Constructor (BTJSON json);

		// @property (readonly, nonatomic, strong) BTJSON * _Nonnull json;
		[Export ("json", ArgumentSemantic.Strong)]
		BTJSON Json { get; }

		// +(BOOL)isBetaEnabledPaymentOption:(NSString * _Nonnull)paymentOption;
		[Static]
		[Export ("isBetaEnabledPaymentOption:")]
		bool IsBetaEnabledPaymentOption (string paymentOption);

		// +(void)setBetaPaymentOption:(NSString * _Nonnull)paymentOption isEnabled:(BOOL)isEnabled;
		[Static]
		[Export ("setBetaPaymentOption:isEnabled:")]
		void SetBetaPaymentOption (string paymentOption, bool isEnabled);
	}

	// @interface BTAPIClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTAPIClient
	{
		// -(instancetype _Nullable)initWithAuthorization:(NSString * _Nonnull)authorization;
		[Export ("initWithAuthorization:")]
		[DesignatedInitializer]
		IntPtr Constructor (string authorization);

		// -(instancetype _Nonnull)copyWithSource:(BTClientMetadataSourceType)source integration:(BTClientMetadataIntegrationType)integration;
		[Export ("copyWithSource:integration:")]
		BTAPIClient CopyWithSource (BTClientMetadataSourceType source, BTClientMetadataIntegrationType integration);

		// -(void)fetchOrReturnRemoteConfiguration:(void (^ _Nonnull)(BTConfiguration * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("fetchOrReturnRemoteConfiguration:")]
		void FetchOrReturnRemoteConfiguration (Action<BTConfiguration, NSError> completionBlock);

		// -(void)GET:(NSString * _Nonnull)path parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("GET:parameters:completion:")]
		void GET (string path, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)POST:(NSString * _Nonnull)path parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("POST:parameters:completion:")]
		void POST (string path, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// @property (copy, nonatomic) NSString * tokenizationKey;
		[Export ("tokenizationKey")]
		string TokenizationKey { get; set; }

		// @property (copy, nonatomic) NSString * clientJWT;
		[Export ("clientJWT")]
		string ClientJWT { get; set; }

		// @property (nonatomic, strong) BTClientToken * clientToken;
		[Export ("clientToken", ArgumentSemantic.Strong)]
		BTClientToken ClientToken { get; set; }

		// @property (nonatomic, strong) BTHTTP * http;
		[Export ("http", ArgumentSemantic.Strong)]
		BTHTTP Http { get; set; }

		// @property (readonly, nonatomic, strong) BTClientMetadata * metadata;
		[Export ("metadata", ArgumentSemantic.Strong)]
		BTClientMetadata Metadata { get; }

		// @property (nonatomic, strong) BTHTTP * analyticsHttp;
		[Export ("analyticsHttp", ArgumentSemantic.Strong)]
		BTHTTP AnalyticsHttp { get; set; }
	}

	// @protocol BTAppSwitchHandler
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTAppSwitchHandler
	{
		// @required +(BOOL)canHandleAppSwitchReturnURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nonnull)sourceApplication;
		//[Static, Abstract]
		[Abstract]
		[Export ("canHandleAppSwitchReturnURL:sourceApplication:")]
		bool CanHandleAppSwitchReturnURL (NSUrl url, string sourceApplication);

		// @required +(void)handleAppSwitchReturnURL:(NSURL * _Nonnull)url;
		//[Static, Abstract]
		[Abstract]
		[Export ("handleAppSwitchReturnURL:")]
		void HandleAppSwitchReturnURL (NSUrl url);

		// @optional -(BOOL)isiOSAppAvailableForAppSwitch;
		[Export ("isiOSAppAvailableForAppSwitch")]
		//[Verify (MethodToProperty)]
		bool IsiOSAppAvailableForAppSwitch { get; }
	}

	// @interface BTAppSwitch : NSObject
	[BaseType (typeof(NSObject))]
	interface BTAppSwitch
	{
		// @property (copy, nonatomic) NSString * _Nonnull returnURLScheme;
		[Export ("returnURLScheme")]
		string ReturnURLScheme { get; set; }

		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		BTAppSwitch SharedInstance ();

		// +(void)setReturnURLScheme:(NSString * _Nonnull)returnURLScheme;
		[Static]
		[Export ("setReturnURLScheme:")]
		void SetReturnURLScheme (string returnURLScheme);

		// +(BOOL)handleOpenURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication;
		[Static]
		[Export ("handleOpenURL:sourceApplication:")]
		bool HandleOpenURL (NSUrl url, [NullAllowed] string sourceApplication);

		// +(BOOL)handleOpenURL:(NSURL * _Nonnull)url options:(NSDictionary * _Nonnull)options;
		[Static]
		[Export ("handleOpenURL:options:")]
		bool HandleOpenURL (NSUrl url, NSDictionary options);

		//ISSUE
		// -(void)registerAppSwitchHandler:(Class<BTAppSwitchHandler> _Nonnull)handler;
		[Export ("registerAppSwitchHandler:")]
		void RegisterAppSwitchHandler (BTAppSwitchHandler handler);

		//ISSUE
		// -(void)unregisterAppSwitchHandler:(Class<BTAppSwitchHandler> _Nonnull)handler;
		[Export ("unregisterAppSwitchHandler:")]
		void UnregisterAppSwitchHandler (BTAppSwitchHandler handler);

		// -(BOOL)handleOpenURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nonnull)sourceApplication;
		//[Export ("handleOpenURL:sourceApplication:")]
		//bool HandleOpenURL (NSUrl url, string sourceApplication);
	}

	// @protocol BTAppSwitchDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTAppSwitchDelegate
	{
		// @required -(void)appSwitcherWillPerformAppSwitch:(id _Nonnull)appSwitcher;
		[Abstract]
		[Export ("appSwitcherWillPerformAppSwitch:")]
		void AppSwitcherWillPerformAppSwitch (NSObject appSwitcher);

		// @required -(void)appSwitcher:(id _Nonnull)appSwitcher didPerformSwitchToTarget:(BTAppSwitchTarget)target;
		[Abstract]
		[Export ("appSwitcher:didPerformSwitchToTarget:")]
		void AppSwitcher (NSObject appSwitcher, BTAppSwitchTarget target);

		// @required -(void)appSwitcherWillProcessPaymentInfo:(id _Nonnull)appSwitcher;
		[Abstract]
		[Export ("appSwitcherWillProcessPaymentInfo:")]
		void AppSwitcherWillProcessPaymentInfo (NSObject appSwitcher);
	}



	// @interface BTClientToken : NSObject <NSCoding, NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTClientToken : INSCoding, INSCopying
	{
		// @property (readonly, nonatomic, strong) BTJSON * _Nonnull json;
		[Export ("json", ArgumentSemantic.Strong)]
		BTJSON Json { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull authorizationFingerprint;
		[Export ("authorizationFingerprint")]
		string AuthorizationFingerprint { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nonnull configURL;
		[Export ("configURL", ArgumentSemantic.Strong)]
		NSUrl ConfigURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull originalValue;
		[Export ("originalValue")]
		string OriginalValue { get; }

		[Export ("decodeClientToken:error:")]
		IntPtr DecodeClientToken(string clientToken, [NullAllowed] out NSError error);


		// -(instancetype _Nullable)initWithClientToken:(NSString * _Nonnull)clientToken error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export ("initWithClientToken:error:")]
		[DesignatedInitializer]
		IntPtr Constructor (string clientToken, [NullAllowed] out NSError error);
	}
			
	// @interface BTLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface BTLogger
	{
		// +(instancetype)sharedLogger;
		[Static]
		[Export ("sharedLogger")]
		BTLogger SharedLogger ();

		// @property (assign, nonatomic) BTLogLevel level;
		[Export ("level", ArgumentSemantic.Assign)]
		BTLogLevel Level { get; set; }

		// @property (copy, nonatomic) void (^logBlock)(BTLogLevel, NSString *);
		[Export ("logBlock", ArgumentSemantic.Copy)]
		Action<BTLogLevel, NSString> LogBlock { get; set; }
	}

	// @interface BTPostalAddress : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface BTPostalAddress : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable recipientName;
		[NullAllowed, Export ("recipientName")]
		string RecipientName { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull streetAddress;
		[Export ("streetAddress")]
		string StreetAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable extendedAddress;
		[NullAllowed, Export ("extendedAddress")]
		string ExtendedAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull locality;
		[Export ("locality")]
		string Locality { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull countryCodeAlpha2;
		[Export ("countryCodeAlpha2")]
		string CountryCodeAlpha2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable region;
		[NullAllowed, Export ("region")]
		string Region { get; set; }
	}

	// @interface BTPaymentMethodNonce : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPaymentMethodNonce
	{
		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nullable)description type:(NSString * _Nonnull)type;
		[Export ("initWithNonce:localizedDescription:type:")]
		IntPtr Constructor (string nonce, [NullAllowed] string description, string type);

		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nullable)description;
		[Export ("initWithNonce:localizedDescription:")]
		IntPtr Constructor (string nonce, [NullAllowed] string description);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonce;
		[Export ("nonce")]
		string Nonce { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedDescription;
		[Export ("localizedDescription")]
		string LocalizedDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }
	}

	// @interface BTPaymentMethodNonceParser : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPaymentMethodNonceParser
	{
		// +(instancetype _Nonnull)sharedParser;
		[Static]
		[Export ("sharedParser")]
		BTPaymentMethodNonceParser SharedParser ();

		// @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nonnull allTypes;
		[Export ("allTypes", ArgumentSemantic.Strong)]
		string[] AllTypes { get; }

		// -(BOOL)isTypeAvailable:(NSString * _Nonnull)type;
		[Export ("isTypeAvailable:")]
		bool IsTypeAvailable (string type);

		// -(void)registerType:(NSString * _Nonnull)type withParsingBlock:(BTPaymentMethodNonce * _Nullable (^ _Nonnull)(BTJSON * _Nonnull))jsonParsingBlock;
		[Export ("registerType:withParsingBlock:")]
		void RegisterType (string type, Func<BTJSON, BTPaymentMethodNonce> jsonParsingBlock);

		// -(BTPaymentMethodNonce * _Nullable)parseJSON:(BTJSON * _Nonnull)json withParsingBlockForType:(NSString * _Nonnull)type;
		[Export ("parseJSON:withParsingBlockForType:")]
		[return: NullAllowed]
		BTPaymentMethodNonce ParseJSON (BTJSON json, string type);
	}

	delegate void MethodNonce (BTPaymentMethodNonce nonce, NSError error);

	// @interface BTTokenizationService : NSObject
	[BaseType (typeof(NSObject))]
	interface BTTokenizationService
	{
		// +(instancetype _Nonnull)sharedService;
		[Static]
		[Export ("sharedService")]
		BTTokenizationService SharedService ();

		//ISSUE
		// -(void)registerType:(NSString * _Nonnull)type withTokenizationBlock:(void (^ _Nonnull)(BTAPIClient * _Nonnull, NSDictionary * _Nullable, void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable)))tokenizationBlock;
		//[Export ("registerType:withTokenizationBlock:")]
		//void RegisterType (string type, Action<BTAPIClient, NSDictionary, Action<BTPaymentMethodNonce, NSError>> tokenizationBlock);

		[Export ("registerType:withTokenizationBlock:")]
		void RegisterType (string type, Action<BTAPIClient, NSDictionary, MethodNonce> tokenizationBlock);

		// -(BOOL)isTypeAvailable:(NSString * _Nonnull)type;
		[Export ("isTypeAvailable:")]
		bool IsTypeAvailable (string type);

		// -(void)tokenizeType:(NSString * _Nonnull)type withAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizeType:withAPIClient:completion:")]
		void TokenizeType (string type, BTAPIClient apiClient, Action<BTPaymentMethodNonce, NSError> completion);

		// -(void)tokenizeType:(NSString * _Nonnull)type options:(NSDictionary<NSString *,id> * _Nullable)options withAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizeType:options:withAPIClient:completion:")]
		void TokenizeType (string type, [NullAllowed] NSDictionary<NSString, NSObject> options, BTAPIClient apiClient, Action<BTPaymentMethodNonce, NSError> completion);

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull allTypes;
		[Export ("allTypes", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AllTypes { get; }
	}

	// @protocol BTViewControllerPresentingDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTViewControllerPresentingDelegate
	{
		// @required -(void)paymentDriver:(id _Nonnull)driver requestsPresentationOfViewController:(UIViewController * _Nonnull)viewController;
		[Abstract]
		[Export ("paymentDriver:requestsPresentationOfViewController:")]
		void RequestsPresentationOfViewController (NSObject driver, UIViewController viewController);

		// @required -(void)paymentDriver:(id _Nonnull)driver requestsDismissalOfViewController:(UIViewController * _Nonnull)viewController;
		[Abstract]
		[Export ("paymentDriver:requestsDismissalOfViewController:")]
		void RequestsDismissalOfViewController (NSObject driver, UIViewController viewController);
	}

	// @interface BTCard : NSObject
	[BaseType (typeof(NSObject))]
	interface BTCard
	{
		// -(instancetype _Nonnull)initWithNumber:(NSString * _Nonnull)number expirationMonth:(NSString * _Nonnull)expirationMonth expirationYear:(NSString * _Nonnull)expirationYear cvv:(NSString * _Nullable)cvv;
		[Export ("initWithNumber:expirationMonth:expirationYear:cvv:")]
		IntPtr Constructor (string number, string expirationMonth, string expirationYear, [NullAllowed] string cvv);

		// -(instancetype _Nonnull)initWithParameters:(NSDictionary * _Nonnull)parameters __attribute__((objc_designated_initializer));
		[Export ("initWithParameters:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDictionary parameters);

		// @property (copy, nonatomic) NSString * _Nullable number;
		[NullAllowed, Export ("number")]
		string Number { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable expirationMonth;
		[NullAllowed, Export ("expirationMonth")]
		string ExpirationMonth { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable expirationYear;
		[NullAllowed, Export ("expirationYear")]
		string ExpirationYear { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cvv;
		[NullAllowed, Export ("cvv")]
		string Cvv { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (assign, nonatomic) BOOL shouldValidate;
		[Export ("shouldValidate")]
		bool ShouldValidate { get; set; }
	}

	// @interface BTCardNonce : BTPaymentMethodNonce
	[BaseType (typeof(BTPaymentMethodNonce))]
	interface BTCardNonce
	{
		[Export ("initWithNonce:description:cardNetwork:lastTwo:")]
		//[DesignatedInitializer]
		IntPtr Constructor (string nonce, string description, BTCardNetwork cardNetwork, string lastTwo);

		// @property (readonly, assign, nonatomic) BTCardNetwork cardNetwork;
		[Export ("cardNetwork", ArgumentSemantic.Assign)]
		BTCardNetwork CardNetwork { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastTwo;
		[NullAllowed, Export ("lastTwo")]
		string LastTwo { get; }

		// +(instancetype _Nonnull)cardNonceWithJSON:(BTJSON * _Nonnull)cardJSON;
		[Static]
		[Export ("cardNonceWithJSON:")]
		BTCardNonce CardNonceWithJSON (BTJSON cardJSON);
	}

	// @interface BTCardClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTCardClient
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)tokenizeCard:(BTCard * _Nonnull)card completion:(void (^ _Nonnull)(BTCardNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("tokenizeCard:completion:")]
		void TokenizeCard (BTCard card, Action<BTCardNonce, NSError> completionBlock);

		// @property (readwrite, nonatomic, strong) BTAPIClient * apiClient;
		[Export ("apiClient", ArgumentSemantic.Strong)]
		BTAPIClient ApiClient { get; set; }
	}

	// @interface PayPal (BTConfiguration)
	[Category]
	[BaseType (typeof(BTConfiguration))]
	interface BTConfiguration_PayPal
	{
		// @property (readonly, assign, nonatomic) BOOL isPayPalEnabled;
		[Export ("isPayPalEnabled")]
		bool IsPayPalEnabled ();

		// @property (readonly, assign, nonatomic) BOOL isBillingAgreementsEnabled;
		[Export ("isBillingAgreementsEnabled")]
		bool IsBillingAgreementsEnabled ();
	}

	// @interface BTPayPalRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPayPalRequest
	{
		// -(instancetype _Nonnull)initWithAmount:(NSString * _Nonnull)amount;
		[Export ("initWithAmount:")]
		IntPtr Constructor (string amount);

		// @property (readonly, nonatomic, strong) NSString * _Nonnull amount;
		[Export ("amount", ArgumentSemantic.Strong)]
		string Amount { get; }

		// @property (getter = isShippingAddressRequired, nonatomic) BOOL shippingAddressRequired;
		[Export ("shippingAddressRequired")]
		bool ShippingAddressRequired { [Bind ("isShippingAddressRequired")] get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currencyCode;
		[NullAllowed, Export ("currencyCode")]
		string CurrencyCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable localeCode;
		[NullAllowed, Export ("localeCode")]
		string LocaleCode { get; set; }

		// @property (nonatomic, strong) BTPostalAddress * _Nullable shippingAddressOverride;
		[NullAllowed, Export ("shippingAddressOverride", ArgumentSemantic.Strong)]
		BTPostalAddress ShippingAddressOverride { get; set; }
	}
		
	// @interface BTPayPalAccountNonce : BTPaymentMethodNonce
	[BaseType (typeof(BTPaymentMethodNonce))]
	interface BTPayPalAccountNonce
	{
		[Export ("initWithNonce:description:email:firstName:lastName:phone:billingAddress:shippingAddress:clientMetadataId:payerId:")]
		IntPtr Constructor (string nonce, string description, string email, string firstName, string lastName, string phone, BTPostalAddress billingAddress, BTPostalAddress shippingAddress, string clientMetadataId, string payerId);

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName")]
		string FirstName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName")]
		string LastName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress BillingAddress { get; }

		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress ShippingAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable clientMetadataId;
		[NullAllowed, Export ("clientMetadataId")]
		string ClientMetadataId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable payerId;
		[NullAllowed, Export ("payerId")]
		string PayerId { get; }
	}

	// @interface BTPayPalDriver : NSObject <BTAppSwitchHandler>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTPayPalDriver : BTAppSwitchHandler
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)authorizeAccountWithCompletion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("authorizeAccountWithCompletion:")]
		void AuthorizeAccountWithCompletion (Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)authorizeAccountWithAdditionalScopes:(NSSet<NSString *> * _Nonnull)additionalScopes completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("authorizeAccountWithAdditionalScopes:completion:")]
		void AuthorizeAccountWithAdditionalScopes (NSSet<NSString> additionalScopes, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)requestOneTimePayment:(BTPayPalRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("requestOneTimePayment:completion:")]
		void RequestOneTimePayment (BTPayPalRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)requestBillingAgreement:(BTPayPalRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("requestBillingAgreement:completion:")]
		void RequestBillingAgreement (BTPayPalRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);

		[Wrap ("WeakAppSwitchDelegate")]
		[NullAllowed]
		BTAppSwitchDelegate AppSwitchDelegate { get; set; }

		// @property (nonatomic, weak) id<BTAppSwitchDelegate> _Nullable appSwitchDelegate;
		[NullAllowed, Export ("appSwitchDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppSwitchDelegate { get; set; }

		[Wrap ("WeakViewControllerPresentingDelegate")]
		[NullAllowed]
		BTViewControllerPresentingDelegate ViewControllerPresentingDelegate { get; set; }

		// @property (nonatomic, weak) id<BTViewControllerPresentingDelegate> _Nullable viewControllerPresentingDelegate;
		[NullAllowed, Export ("viewControllerPresentingDelegate", ArgumentSemantic.Weak)]
		NSObject WeakViewControllerPresentingDelegate { get; set; }

		// @property (nonatomic, strong) BTPayPalRequestFactory * _Nonnull requestFactory;
		[Export ("requestFactory", ArgumentSemantic.Strong)]
		BTPayPalRequestFactory RequestFactory { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull returnURLScheme;
		[Export ("returnURLScheme")]
		string ReturnURLScheme { get; set; }

		// @property (nonatomic, strong) BTAPIClient * _Nullable apiClient;
		[NullAllowed, Export ("apiClient", ArgumentSemantic.Strong)]
		BTAPIClient ApiClient { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull clientMetadataId;
		[Export ("clientMetadataId", ArgumentSemantic.Strong)]
		string ClientMetadataId { get; set; }

		// @property (nonatomic, strong) SFSafariViewController * _Nullable safariViewController;
		[NullAllowed, Export ("safariViewController", ArgumentSemantic.Strong)]
		SFSafariViewController SafariViewController { get; set; }
	}
		
	// @interface BTDropInViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface BTDropInViewController
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (BTAPIClient apiClient);

		// @property (nonatomic, strong) BTPaymentRequest * _Nullable paymentRequest;
		[NullAllowed, Export ("paymentRequest", ArgumentSemantic.Strong)]
		BTPaymentRequest PaymentRequest { get; set; }

		// @property (nonatomic, strong) NSArray * _Nonnull paymentMethodNonces;
		[Export ("paymentMethodNonces", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] PaymentMethodNonces { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BTDropInViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTDropInViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) BTUI * _Nullable theme;
		[NullAllowed, Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }

		// -(void)fetchPaymentMethodsOnCompletion:(void (^ _Nonnull)())completionBlock;
		[Export ("fetchPaymentMethodsOnCompletion:")]
		void FetchPaymentMethodsOnCompletion (Action completionBlock);

		// @property (nonatomic, strong) BTAPIClient * _Nonnull apiClient;
		[Export ("apiClient", ArgumentSemantic.Strong)]
		BTAPIClient ApiClient { get; set; }

		// @property (nonatomic, strong) BTDropInContentView * dropInContentView;
		[Export ("dropInContentView", ArgumentSemantic.Strong)]
		BTDropInContentView DropInContentView { get; set; }
	}

	// @protocol BTDropInViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTDropInViewControllerDelegate
	{
		// @required -(void)dropInViewController:(BTDropInViewController * _Nonnull)viewController didSucceedWithTokenization:(BTPaymentMethodNonce * _Nonnull)paymentMethodNonce;
		[Abstract]
		[Export ("dropInViewController:didSucceedWithTokenization:")]
		void DropInViewController (BTDropInViewController viewController, BTPaymentMethodNonce paymentMethodNonce);

		// @required -(void)dropInViewControllerDidCancel:(BTDropInViewController * _Nonnull)viewController;
		[Abstract]
		[Export ("dropInViewControllerDidCancel:")]
		void DropInViewControllerDidCancel (BTDropInViewController viewController);

		// @optional -(void)dropInViewControllerDidLoad:(BTDropInViewController * _Nonnull)viewController;
		[Export ("dropInViewControllerDidLoad:")]
		void DropInViewControllerDidLoad (BTDropInViewController viewController);

		// @optional -(void)dropInViewControllerWillComplete:(BTDropInViewController * _Nonnull)viewController;
		[Export ("dropInViewControllerWillComplete:")]
		void DropInViewControllerWillComplete (BTDropInViewController viewController);
	}

	// @interface BTPaymentRequest : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface BTPaymentRequest : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable summaryTitle;
		[NullAllowed, Export ("summaryTitle")]
		string SummaryTitle { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable summaryDescription;
		[NullAllowed, Export ("summaryDescription")]
		string SummaryDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull displayAmount;
		[Export ("displayAmount")]
		string DisplayAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull callToActionText;
		[Export ("callToActionText")]
		string CallToActionText { get; set; }

		// @property (assign, nonatomic) BOOL shouldHideCallToAction;
		[Export ("shouldHideCallToAction")]
		bool ShouldHideCallToAction { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable amount;
		[NullAllowed, Export ("amount")]
		string Amount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currencyCode;
		[NullAllowed, Export ("currencyCode")]
		string CurrencyCode { get; set; }

		// @property (assign, nonatomic) BOOL noShipping;
		[Export ("noShipping")]
		bool NoShipping { get; set; }

		// @property (nonatomic, strong) BTPostalAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress ShippingAddress { get; set; }

		// @property (nonatomic, strong) NSSet<NSString *> * _Nullable additionalPayPalScopes;
		[NullAllowed, Export ("additionalPayPalScopes", ArgumentSemantic.Strong)]
		NSSet<NSString> AdditionalPayPalScopes { get; set; }
	}

	// @interface BTUIVectorArtView : UIView
	[BaseType (typeof(UIView))]
	interface BTUIVectorArtView
	{
		// -(void)drawArt;
		[Export ("drawArt")]
		void DrawArt ();

		// @property (assign, nonatomic) CGSize artDimensions;
		[Export ("artDimensions", ArgumentSemantic.Assign)]
		CGSize ArtDimensions { get; set; }

		// -(UIImage *)imageOfSize:(CGSize)size;
		[Export ("imageOfSize:")]
		UIImage ImageOfSize (CGSize size);
	}

	// @interface BTUI : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUI
	{
		// +(BTUI *)braintreeTheme;
		[Static]
		[Export ("braintreeTheme")]
		//[Verify (MethodToProperty)]
		BTUI BraintreeTheme { get; }

		// -(UIColor *)idealGray;
		[Export ("idealGray")]
		//[Verify (MethodToProperty)]
		UIColor IdealGray { get; }

		// -(UIColor *)defaultTintColor;
		[Export ("defaultTintColor")]
		//[Verify (MethodToProperty)]
		UIColor DefaultTintColor { get; }

		// -(UIColor *)viewBackgroundColor;
		[Export ("viewBackgroundColor")]
		//[Verify (MethodToProperty)]
		UIColor ViewBackgroundColor { get; }

		// -(UIColor *)callToActionColor;
		[Export ("callToActionColor")]
		//[Verify (MethodToProperty)]
		UIColor CallToActionColor { get; }

		// -(UIColor *)callToActionColorHighlighted;
		[Export ("callToActionColorHighlighted")]
		//[Verify (MethodToProperty)]
		UIColor CallToActionColorHighlighted { get; }

		// -(UIColor *)disabledButtonColor;
		[Export ("disabledButtonColor")]
		//[Verify (MethodToProperty)]
		UIColor DisabledButtonColor { get; }

		// -(UIColor *)titleColor;
		[Export ("titleColor")]
		//[Verify (MethodToProperty)]
		UIColor TitleColor { get; }

		// -(UIColor *)detailColor;
		[Export ("detailColor")]
		//[Verify (MethodToProperty)]
		UIColor DetailColor { get; }

		// -(UIColor *)borderColor;
		[Export ("borderColor")]
		//[Verify (MethodToProperty)]
		UIColor BorderColor { get; }

		// -(UIColor *)textFieldTextColor;
		[Export ("textFieldTextColor")]
		//[Verify (MethodToProperty)]
		UIColor TextFieldTextColor { get; }

		// -(UIColor *)textFieldPlaceholderColor;
		[Export ("textFieldPlaceholderColor")]
		//[Verify (MethodToProperty)]
		UIColor TextFieldPlaceholderColor { get; }

		// -(UIColor *)sectionHeaderTextColor;
		[Export ("sectionHeaderTextColor")]
		//[Verify (MethodToProperty)]
		UIColor SectionHeaderTextColor { get; }

		// -(UIColor *)textFieldFloatLabelTextColor;
		[Export ("textFieldFloatLabelTextColor")]
		//[Verify (MethodToProperty)]
		UIColor TextFieldFloatLabelTextColor { get; }

		// -(UIColor *)cardHintBorderColor;
		[Export ("cardHintBorderColor")]
		//[Verify (MethodToProperty)]
		UIColor CardHintBorderColor { get; }

		// -(UIColor *)errorBackgroundColor;
		[Export ("errorBackgroundColor")]
		//[Verify (MethodToProperty)]
		UIColor ErrorBackgroundColor { get; }

		// -(UIColor *)errorForegroundColor;
		[Export ("errorForegroundColor")]
		//[Verify (MethodToProperty)]
		UIColor ErrorForegroundColor { get; }

		// -(CGFloat)highlightedBrightnessAdjustment;
		[Export ("highlightedBrightnessAdjustment")]
		//[Verify (MethodToProperty)]
		nfloat HighlightedBrightnessAdjustment { get; }

		// -(UIColor *)payBlue;
		[Export ("payBlue")]
		//[Verify (MethodToProperty)]
		UIColor PayBlue { get; }

		// -(UIColor *)palBlue;
		[Export ("palBlue")]
		//[Verify (MethodToProperty)]
		UIColor PalBlue { get; }

		// -(UIColor *)payPalButtonBlue;
		[Export ("payPalButtonBlue")]
		//[Verify (MethodToProperty)]
		UIColor PayPalButtonBlue { get; }

		// -(UIColor *)payPalButtonActiveBlue;
		[Export ("payPalButtonActiveBlue")]
		//[Verify (MethodToProperty)]
		UIColor PayPalButtonActiveBlue { get; }

		// -(UIColor *)venmoPrimaryBlue;
		[Export ("venmoPrimaryBlue")]
		//[Verify (MethodToProperty)]
		UIColor VenmoPrimaryBlue { get; }

		// -(UIColor *)coinbasePrimaryBlue;
		[Export ("coinbasePrimaryBlue")]
		//[Verify (MethodToProperty)]
		UIColor CoinbasePrimaryBlue { get; }

		// -(UIFont *)controlFont;
		[Export ("controlFont")]
		//[Verify (MethodToProperty)]
		UIFont ControlFont { get; }

		// -(UIFont *)controlTitleFont;
		[Export ("controlTitleFont")]
		//[Verify (MethodToProperty)]
		UIFont ControlTitleFont { get; }

		// -(UIFont *)controlDetailFont;
		[Export ("controlDetailFont")]
		//[Verify (MethodToProperty)]
		UIFont ControlDetailFont { get; }

		// -(UIFont *)textFieldFont;
		[Export ("textFieldFont")]
		//[Verify (MethodToProperty)]
		UIFont TextFieldFont { get; }

		// -(UIFont *)textFieldFloatLabelFont;
		[Export ("textFieldFloatLabelFont")]
		//[Verify (MethodToProperty)]
		UIFont TextFieldFloatLabelFont { get; }

		// -(UIFont *)sectionHeaderFont;
		[Export ("sectionHeaderFont")]
		//[Verify (MethodToProperty)]
		UIFont SectionHeaderFont { get; }

		// -(NSDictionary *)textFieldTextAttributes;
		[Export ("textFieldTextAttributes")]
		//[Verify (MethodToProperty)]
		NSDictionary TextFieldTextAttributes { get; }

		// -(NSDictionary *)textFieldPlaceholderAttributes;
		[Export ("textFieldPlaceholderAttributes")]
		//[Verify (MethodToProperty)]
		NSDictionary TextFieldPlaceholderAttributes { get; }

		// -(CGFloat)borderWidth;
		[Export ("borderWidth")]
		//[Verify (MethodToProperty)]
		nfloat BorderWidth { get; }

		// -(CGFloat)cornerRadius;
		[Export ("cornerRadius")]
		//[Verify (MethodToProperty)]
		nfloat CornerRadius { get; }

		// -(CGFloat)formattedEntryKerning;
		[Export ("formattedEntryKerning")]
		//[Verify (MethodToProperty)]
		nfloat FormattedEntryKerning { get; }

		// -(CGFloat)horizontalMargin;
		[Export ("horizontalMargin")]
		//[Verify (MethodToProperty)]
		nfloat HorizontalMargin { get; }

		// -(CGFloat)paymentButtonMinHeight;
		[Export ("paymentButtonMinHeight")]
		//[Verify (MethodToProperty)]
		nfloat PaymentButtonMinHeight { get; }

		// -(CGFloat)paymentButtonMaxHeight;
		[Export ("paymentButtonMaxHeight")]
		//[Verify (MethodToProperty)]
		nfloat PaymentButtonMaxHeight { get; }

		// -(CGFloat)paymentButtonWordMarkHeight __attribute__((deprecated("")));
		[Export ("paymentButtonWordMarkHeight")]
		//[Verify (MethodToProperty)]
		nfloat PaymentButtonWordMarkHeight { get; }

		// -(CGFloat)quickTransitionDuration;
		[Export ("quickTransitionDuration")]
		//[Verify (MethodToProperty)]
		nfloat QuickTransitionDuration { get; }

		// -(CGFloat)transitionDuration;
		[Export ("transitionDuration")]
		//[Verify (MethodToProperty)]
		nfloat TransitionDuration { get; }

		// -(CGFloat)minimumVisibilityTime;
		[Export ("minimumVisibilityTime")]
		//[Verify (MethodToProperty)]
		nfloat MinimumVisibilityTime { get; }

		// -(BTUIVectorArtView *)vectorArtViewForPaymentInfoType:(NSString *)typeString;
		[Export ("vectorArtViewForPaymentInfoType:")]
		BTUIVectorArtView VectorArtViewForPaymentInfoType (string typeString);

		// -(BTUIVectorArtView *)vectorArtViewForPaymentOptionType:(BTUIPaymentOptionType)type;
		[Export ("vectorArtViewForPaymentOptionType:")]
		BTUIVectorArtView VectorArtViewForPaymentOptionType (BTUIPaymentOptionType type);

		// +(BTUIPaymentOptionType)paymentOptionTypeForPaymentInfoType:(NSString *)typeString;
		[Static]
		[Export ("paymentOptionTypeForPaymentInfoType:")]
		BTUIPaymentOptionType PaymentOptionTypeForPaymentInfoType (string typeString);

		// +(UIActivityIndicatorViewStyle)activityIndicatorViewStyleForBarTintColor:(UIColor *)color;
		[Static]
		[Export ("activityIndicatorViewStyleForBarTintColor:")]
		UIActivityIndicatorViewStyle ActivityIndicatorViewStyleForBarTintColor (UIColor color);
	}

	// @interface BTUIThemedView : UIView
	[BaseType (typeof(UIView))]
	interface BTUIThemedView
	{
		// @property (nonatomic, strong) BTUI * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @interface BTPaymentButton : BTUIThemedView
	[BaseType (typeof(BTUIThemedView))]
	interface BTPaymentButton
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nonnull, NSError * _Nonnull))completion;
		[Export ("initWithAPIClient:completion:")]
		IntPtr Constructor (BTAPIClient apiClient, Action<BTPaymentMethodNonce, NSError> completion);

		// @property (nonatomic, strong) BTAPIClient * _Nonnull apiClient;
		[Export ("apiClient", ArgumentSemantic.Strong)]
		BTAPIClient ApiClient { get; set; }

		// @property (nonatomic, strong) BTPaymentRequest * _Nonnull paymentRequest;
		[Export ("paymentRequest", ArgumentSemantic.Strong)]
		BTPaymentRequest PaymentRequest { get; set; }

		// @property (copy, nonatomic) void (^ _Nonnull)(BTPaymentMethodNonce * _Nonnull, NSError * _Nonnull) completion;
		[Export ("completion", ArgumentSemantic.Copy)]
		Action<BTPaymentMethodNonce, NSError> Completion { get; set; }

		// @property (nonatomic, strong) NSOrderedSet * _Nonnull enabledPaymentOptions;
		[Export ("enabledPaymentOptions", ArgumentSemantic.Strong)]
		NSOrderedSet EnabledPaymentOptions { get; set; }

		// @property (nonatomic, strong) BTConfiguration * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		BTConfiguration Configuration { get; set; }

		[Wrap ("WeakAppSwitchDelegate")]
		[NullAllowed]
		BTAppSwitchDelegate AppSwitchDelegate { get; set; }

		// @property (nonatomic, weak) id<BTAppSwitchDelegate> _Nullable appSwitchDelegate;
		[NullAllowed, Export ("appSwitchDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppSwitchDelegate { get; set; }

		[Wrap ("WeakViewControllerPresentingDelegate")]
		[NullAllowed]
		BTViewControllerPresentingDelegate ViewControllerPresentingDelegate { get; set; }

		// @property (nonatomic, weak) id<BTViewControllerPresentingDelegate> _Nullable viewControllerPresentingDelegate;
		[NullAllowed, Export ("viewControllerPresentingDelegate", ArgumentSemantic.Weak)]
		NSObject WeakViewControllerPresentingDelegate { get; set; }

		// @property (readonly, nonatomic) BOOL hasAvailablePaymentMethod;
		[Export ("hasAvailablePaymentMethod")]
		bool HasAvailablePaymentMethod { get; }

		// @property (nonatomic, strong) id application;
		[Export ("application", ArgumentSemantic.Strong)]
		NSObject Application { get; set; }
	}

	// @interface BTUICardFormView : BTUIThemedView
	[BaseType (typeof(BTUIThemedView))]
	interface BTUICardFormView
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BTUICardFormViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTUICardFormViewDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, assign, nonatomic) BOOL valid;
		[Export ("valid")]
		bool Valid { get; }

		// @property (copy, nonatomic) NSString * number;
		[Export ("number")]
		string Number { get; set; }

		// @property (copy, nonatomic) NSString * cvv;
		[Export ("cvv")]
		string Cvv { get; set; }

		// @property (copy, nonatomic) NSString * postalCode;
		[Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (readonly, copy, nonatomic) NSString * expirationMonth;
		[Export ("expirationMonth")]
		string ExpirationMonth { get; }

		// @property (readonly, copy, nonatomic) NSString * expirationYear;
		[Export ("expirationYear")]
		string ExpirationYear { get; }

		// -(void)setExpirationDate:(NSDate *)expirationDate;
		[Export ("setExpirationDate:")]
		void SetExpirationDate (NSDate expirationDate);

		// -(void)showTopLevelError:(NSString *)message;
		[Export ("showTopLevelError:")]
		void ShowTopLevelError (string message);

		// -(void)showErrorForField:(BTUICardFormField)field;
		[Export ("showErrorForField:")]
		void ShowErrorForField (BTUICardFormField field);

		// @property (assign, nonatomic) BOOL alphaNumericPostalCode;
		[Export ("alphaNumericPostalCode")]
		bool AlphaNumericPostalCode { get; set; }

		// @property (assign, nonatomic) BTUICardFormOptionalFields optionalFields;
		[Export ("optionalFields", ArgumentSemantic.Assign)]
		BTUICardFormOptionalFields OptionalFields { get; set; }

		// @property (assign, nonatomic) BOOL vibrate;
		[Export ("vibrate")]
		bool Vibrate { get; set; }
	}

	// @protocol BTUICardFormViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUICardFormViewDelegate
	{
		// @required -(void)cardFormViewDidChange:(BTUICardFormView *)cardFormView;
		[Abstract]
		[Export ("cardFormViewDidChange:")]
		void CardFormViewDidChange (BTUICardFormView cardFormView);

		// @optional -(void)cardFormViewDidBeginEditing:(BTUICardFormView *)cardFormView;
		[Export ("cardFormViewDidBeginEditing:")]
		void CardFormViewDidBeginEditing (BTUICardFormView cardFormView);
	}

	// @interface BTUICardHint : BTUIThemedView
	[BaseType (typeof(BTUIThemedView))]
	interface BTUICardHint
	{
		// @property (assign, nonatomic) BTUIPaymentOptionType cardType;
		[Export ("cardType", ArgumentSemantic.Assign)]
		BTUIPaymentOptionType CardType { get; set; }

		// @property (assign, nonatomic) BTCardHintDisplayMode displayMode;
		[Export ("displayMode", ArgumentSemantic.Assign)]
		BTCardHintDisplayMode DisplayMode { get; set; }

		// @property (assign, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { get; set; }

		// -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		// -(void)setCardType:(BTUIPaymentOptionType)cardType animated:(BOOL)animated;
		[Export ("setCardType:animated:")]
		void SetCardType (BTUIPaymentOptionType cardType, bool animated);

		// -(void)setDisplayMode:(BTCardHintDisplayMode)displayMode animated:(BOOL)animated;
		[Export ("setDisplayMode:animated:")]
		void SetDisplayMode (BTCardHintDisplayMode displayMode, bool animated);
	}

	// @interface BTUICoinbaseButton : UIControl
	[BaseType (typeof(UIControl))]
	interface BTUICoinbaseButton
	{
		// @property (nonatomic, strong) BTUI * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @interface BTUICTAControl : UIControl
	[BaseType (typeof(UIControl))]
	interface BTUICTAControl
	{
		// @property (copy, nonatomic) NSString * _Nullable displayAmount;
		[NullAllowed, Export ("displayAmount")]
		string DisplayAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull callToAction;
		[Export ("callToAction")]
		string CallToAction { get; set; }

		// -(void)showLoadingState:(BOOL)loadingState;
		[Export ("showLoadingState:")]
		void ShowLoadingState (bool loadingState);

		// @property (nonatomic, strong) BTUI * _Nonnull theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @interface BTUIPaymentMethodView : BTUIThemedView
	[BaseType (typeof(BTUIThemedView))]
	interface BTUIPaymentMethodView
	{
		// @property (assign, nonatomic) BTUIPaymentOptionType type;
		[Export ("type", ArgumentSemantic.Assign)]
		BTUIPaymentOptionType Type { get; set; }

		// @property (copy, nonatomic) NSString * detailDescription;
		[Export ("detailDescription")]
		string DetailDescription { get; set; }

		// @property (getter = isProcessing, assign, nonatomic) BOOL processing;
		[Export ("processing")]
		bool Processing { [Bind ("isProcessing")] get; set; }
	}

	// @interface BTUIPayPalButton : UIControl
	[BaseType (typeof(UIControl))]
	interface BTUIPayPalButton
	{
		// @property (nonatomic, strong) BTUI * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @interface BTUISummaryView : BTUIThemedView
	[BaseType (typeof(BTUIThemedView))]
	interface BTUISummaryView
	{
		// @property (copy, nonatomic) NSString * slug;
		[Export ("slug")]
		string Slug { get; set; }

		// @property (copy, nonatomic) NSString * summary;
		[Export ("summary")]
		string Summary { get; set; }

		// @property (copy, nonatomic) NSString * amount;
		[Export ("amount")]
		string Amount { get; set; }
	}

	// @interface BTUIVenmoButton : UIControl
	[BaseType (typeof(UIControl))]
	interface BTUIVenmoButton
	{
		// @property (nonatomic, strong) BTUI * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @interface BTUI (UIColor)
	[Category]
	[BaseType (typeof(UIColor))]
	interface UIColor_BTUI
	{
		// +(instancetype)bt_colorWithBytesR:(NSInteger)r G:(NSInteger)g B:(NSInteger)b A:(NSInteger)a;
		[Static]
		[Export ("bt_colorWithBytesR:G:B:A:")]
		UIColor Bt_colorWithBytesR (nint r, nint g, nint b, nint a);

		// +(instancetype)bt_colorWithBytesR:(NSInteger)r G:(NSInteger)g B:(NSInteger)b;
		[Static]
		[Export ("bt_colorWithBytesR:G:B:")]
		UIColor Bt_colorWithBytesR (nint r, nint g, nint b);

		// +(instancetype)bt_colorFromHex:(NSString *)hex alpha:(CGFloat)alpha;
		[Static]
		[Export ("bt_colorFromHex:alpha:")]
		UIColor Bt_colorFromHex (string hex, nfloat alpha);

		// -(instancetype)bt_adjustedBrightness:(CGFloat)adjustment;
		[Export ("bt_adjustedBrightness:")]
		UIColor Bt_adjustedBrightness (nfloat adjustment);
	}

	// @interface BTAnalyticsMetadata : NSObject
	[BaseType (typeof(NSObject))]
	interface BTAnalyticsMetadata
	{
		// +(NSDictionary *)metadata;
		[Static]
		[Export ("metadata")]
		//[Verify (MethodToProperty)]
		NSDictionary Metadata { get; }
	}

	// @interface BTHTTP : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTHTTP : INSCopying
	{
		// @property (nonatomic, strong) NSArray<NSData *> * _Nullable pinnedCertificates;
		[NullAllowed, Export ("pinnedCertificates", ArgumentSemantic.Strong)]
		NSData[] PinnedCertificates { get; set; }

		// -(instancetype _Nonnull)initWithBaseURL:(NSURL * _Nonnull)URL authorizationFingerprint:(NSString * _Nonnull)authorizationFingerprint __attribute__((objc_designated_initializer));
		[Export ("initWithBaseURL:authorizationFingerprint:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUrl URL, string authorizationFingerprint);

		// -(instancetype _Nonnull)initWithClientToken:(BTClientToken * _Nonnull)clientToken;
		[Export ("initWithClientToken:")]
		IntPtr Constructor (BTClientToken clientToken);

		// @property (nonatomic, strong) NSURLSession * _Nonnull session;
		[Export ("session", ArgumentSemantic.Strong)]
		NSUrlSession Session { get; set; }

		// @property (readonly, nonatomic, strong) NSURL * _Nonnull baseURL;
		[Export ("baseURL", ArgumentSemantic.Strong)]
		NSUrl BaseURL { get; }

		// @property (nonatomic, strong) dispatch_queue_t _Nonnull dispatchQueue;
		[Export ("dispatchQueue", ArgumentSemantic.Strong)]
		DispatchQueue DispatchQueue { get; set; }

		// -(void)GET:(NSString * _Nonnull)endpoint completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("GET:completion:")]
		void GET (string endpoint, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)GET:(NSString * _Nonnull)endpoint parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("GET:parameters:completion:")]
		void GET (string endpoint, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)POST:(NSString * _Nonnull)endpoint completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("POST:completion:")]
		void POST (string endpoint, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)POST:(NSString * _Nonnull)endpoint parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("POST:parameters:completion:")]
		void POST (string endpoint, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)PUT:(NSString * _Nonnull)endpoint completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("PUT:completion:")]
		void PUT (string endpoint, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)PUT:(NSString * _Nonnull)endpoint parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("PUT:parameters:completion:")]
		void PUT (string endpoint, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)DELETE:(NSString * _Nonnull)endpoint completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("DELETE:completion:")]
		void DELETE (string endpoint, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)DELETE:(NSString * _Nonnull)endpoint parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("DELETE:parameters:completion:")]
		void DELETE (string endpoint, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);
	}
		
	// @interface  (BTAPIClient)
	[Category]
	[BaseType (typeof(BTAPIClient))]
	interface BTAPIClient_
	{
		// @property (copy, nonatomic) NSString * tokenizationKey;
		//[Export ("tokenizationKey")]
		//string TokenizationKey { get; set; }

		// @property (copy, nonatomic) NSString * clientJWT;
		//[Export ("clientJWT")]
		//string ClientJWT { get; set; }

		// @property (nonatomic, strong) BTClientToken * clientToken;
		//[Export ("clientToken")]
		//BTClientToken ClientToken { get; set; }

		// @property (nonatomic, strong) BTHTTP * http;
		//[Export ("http")]
		//BTHTTP Http { get; set; }

		// @property (readonly, nonatomic, strong) BTClientMetadata * metadata;
		[Export ("metadata")]
		BTClientMetadata Metadata ();

		// @property (nonatomic, strong) BTHTTP * analyticsHttp;
		//[Export ("analyticsHttp")]
		//BTHTTP AnalyticsHttp { get; set; }

		// -(void)sendAnalyticsEvent:(NSString *)eventName;
		[Export ("sendAnalyticsEvent:")]
		void SendAnalyticsEvent (string eventName);

		// -(void)sendAnalyticsEvent:(NSString *)eventName completion:(void (^)(NSError *))completionBlock;
		[Export ("sendAnalyticsEvent:completion:")]
		void SendAnalyticsEvent (string eventName, Action<NSError> completionBlock);
	}

	// @interface BTAPIPinnedCertificates : NSObject
	[BaseType (typeof(NSObject))]
	interface BTAPIPinnedCertificates
	{
		// +(NSArray *)trustedCertificates;
		[Static]
		[Export ("trustedCertificates")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] TrustedCertificates { get; }
	}

	// @interface  (BTCard)
	[Category]
	[BaseType (typeof(BTCard))]
	interface BTCard_
	{
		// -(NSDictionary *)parameters;
		[Export ("parameters")]
		//[Verify (MethodToProperty)]
		NSDictionary Parameters ();
	}

	// @interface  (BTCardClient)
	[Category]
	[BaseType (typeof(BTCardClient))]
	interface BTCardClient_
	{
		// @property (readwrite, nonatomic, strong) BTAPIClient * apiClient;
		//[Export ("apiClient")]
		//BTAPIClient ApiClient { get; set; }
	}
		
	// @interface  (BTCardNonce)
	[Category]
	[BaseType (typeof(BTCardNonce))]
	interface BTCardNonce_
	{
		// -(instancetype _Nonnull)initWithNonce:(NSString * _Nonnull)nonce description:(NSString * _Nullable)description cardNetwork:(BTCardNetwork)cardNetwork lastTwo:(NSString * _Nullable)lastTwo;
		//[Export ("initWithNonce:description:cardNetwork:lastTwo:")]
		//IntPtr Constructor (string nonce, [NullAllowed] string description, BTCardNetwork cardNetwork, [NullAllowed] string lastTwo);
	}

	// @interface BTDropInContentView : BTUIThemedView
	[BaseType (typeof(BTUIThemedView))]
	interface BTDropInContentView
	{
		// @property (nonatomic, strong) BTUISummaryView * summaryView;
		[Export ("summaryView", ArgumentSemantic.Strong)]
		BTUISummaryView SummaryView { get; set; }

		// @property (nonatomic, strong) BTUICTAControl * ctaControl;
		[Export ("ctaControl", ArgumentSemantic.Strong)]
		BTUICTAControl CtaControl { get; set; }

		// @property (nonatomic, strong) BTPaymentButton * paymentButton;
		[Export ("paymentButton", ArgumentSemantic.Strong)]
		BTPaymentButton PaymentButton { get; set; }

		// @property (nonatomic, strong) UILabel * cardFormSectionHeader;
		[Export ("cardFormSectionHeader", ArgumentSemantic.Strong)]
		UILabel CardFormSectionHeader { get; set; }

		// @property (nonatomic, strong) BTUICardFormView * cardForm;
		[Export ("cardForm", ArgumentSemantic.Strong)]
		BTUICardFormView CardForm { get; set; }

		// @property (nonatomic, strong) BTUIPaymentMethodView * selectedPaymentMethodView;
		[Export ("selectedPaymentMethodView", ArgumentSemantic.Strong)]
		BTUIPaymentMethodView SelectedPaymentMethodView { get; set; }

		// @property (nonatomic, strong) UIButton * changeSelectedPaymentMethodButton;
		[Export ("changeSelectedPaymentMethodButton", ArgumentSemantic.Strong)]
		UIButton ChangeSelectedPaymentMethodButton { get; set; }

		// @property (assign, nonatomic) BOOL hideCTA;
		[Export ("hideCTA")]
		bool HideCTA { get; set; }

		// @property (assign, nonatomic) BOOL hideSummary;
		[Export ("hideSummary")]
		bool HideSummary { get; set; }

		// @property (assign, nonatomic) BTDropInContentViewStateType state;
		[Export ("state", ArgumentSemantic.Assign)]
		BTDropInContentViewStateType State { get; set; }

		// @property (assign, nonatomic) BOOL hidePaymentButton;
		[Export ("hidePaymentButton")]
		bool HidePaymentButton { get; set; }

		// -(void)setState:(BTDropInContentViewStateType)newState animate:(BOOL)animate;
		[Export ("setState:animate:")]
		void SetState (BTDropInContentViewStateType newState, bool animate);
	}

	// @interface BTDropInErrorAlert : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTDropInErrorAlert
	{
		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable message;
		[NullAllowed, Export ("message")]
		string Message { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)() retryBlock;
		[NullAllowed, Export ("retryBlock", ArgumentSemantic.Copy)]
		Action RetryBlock { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)() cancelBlock;
		[NullAllowed, Export ("cancelBlock", ArgumentSemantic.Copy)]
		Action CancelBlock { get; set; }

		// @property (nonatomic, weak) UIViewController * _Nullable presentingViewController;
		[NullAllowed, Export ("presentingViewController", ArgumentSemantic.Weak)]
		UIViewController PresentingViewController { get; set; }

		// -(instancetype _Nonnull)initWithPresentingViewController:(UIViewController * _Nonnull)viewController __attribute__((objc_designated_initializer));
		[Export ("initWithPresentingViewController:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIViewController viewController);

		// -(void)show;
		[Export ("show")]
		void Show ();
	}

	// @interface BTDropInErrorState : NSObject
	[BaseType (typeof(NSObject))]
	interface BTDropInErrorState
	{
		// -(instancetype)initWithError:(NSError *)error;
		[Export ("initWithError:")]
		IntPtr Constructor (NSError error);

		// @property (readonly, copy, nonatomic) NSString * errorTitle;
		[Export ("errorTitle")]
		string ErrorTitle { get; }

		// @property (readonly, nonatomic, strong) NSSet * highlightedFields;
		[Export ("highlightedFields", ArgumentSemantic.Strong)]
		NSSet HighlightedFields { get; }
	}

	// @interface BTDropInLocalizedString : NSObject
	[BaseType (typeof(NSObject))]
	interface BTDropInLocalizedString
	{
		// +(NSString *)DROP_IN_CHANGE_PAYMENT_METHOD_BUTTON_TEXT;
		[Static]
		[Export ("DROP_IN_CHANGE_PAYMENT_METHOD_BUTTON_TEXT")]
		//[Verify (MethodToProperty)]
		string DROP_IN_CHANGE_PAYMENT_METHOD_BUTTON_TEXT { get; }

		// +(NSString *)ERROR_ALERT_OK_BUTTON_TEXT;
		[Static]
		[Export ("ERROR_ALERT_OK_BUTTON_TEXT")]
		//[Verify (MethodToProperty)]
		string ERROR_ALERT_OK_BUTTON_TEXT { get; }

		// +(NSString *)ERROR_ALERT_CANCEL_BUTTON_TEXT;
		[Static]
		[Export ("ERROR_ALERT_CANCEL_BUTTON_TEXT")]
		//[Verify (MethodToProperty)]
		string ERROR_ALERT_CANCEL_BUTTON_TEXT { get; }

		// +(NSString *)ERROR_ALERT_TRY_AGAIN_BUTTON_TEXT;
		[Static]
		[Export ("ERROR_ALERT_TRY_AGAIN_BUTTON_TEXT")]
		//[Verify (MethodToProperty)]
		string ERROR_ALERT_TRY_AGAIN_BUTTON_TEXT { get; }

		// +(NSString *)ERROR_ALERT_CONNECTION_ERROR;
		[Static]
		[Export ("ERROR_ALERT_CONNECTION_ERROR")]
		//[Verify (MethodToProperty)]
		string ERROR_ALERT_CONNECTION_ERROR { get; }

		// +(NSString *)DEFAULT_CALL_TO_ACTION;
		[Static]
		[Export ("DEFAULT_CALL_TO_ACTION")]
		//[Verify (MethodToProperty)]
		string DEFAULT_CALL_TO_ACTION { get; }

		// +(NSString *)CARD_FORM_SECTION_HEADER;
		[Static]
		[Export ("CARD_FORM_SECTION_HEADER")]
		//[Verify (MethodToProperty)]
		string CARD_FORM_SECTION_HEADER { get; }

		// +(NSString *)SELECT_PAYMENT_METHOD_TITLE;
		[Static]
		[Export ("SELECT_PAYMENT_METHOD_TITLE")]
		//[Verify (MethodToProperty)]
		string SELECT_PAYMENT_METHOD_TITLE { get; }

		// +(NSString *)ERROR_SAVING_CARD_ALERT_TITLE;
		[Static]
		[Export ("ERROR_SAVING_CARD_ALERT_TITLE")]
		//[Verify (MethodToProperty)]
		string ERROR_SAVING_CARD_ALERT_TITLE { get; }

		// +(NSString *)ERROR_SAVING_CARD_MESSAGE;
		[Static]
		[Export ("ERROR_SAVING_CARD_MESSAGE")]
		//[Verify (MethodToProperty)]
		string ERROR_SAVING_CARD_MESSAGE { get; }

		// +(NSString *)ERROR_SAVING_PAYMENT_METHOD_ALERT_TITLE;
		[Static]
		[Export ("ERROR_SAVING_PAYMENT_METHOD_ALERT_TITLE")]
		//[Verify (MethodToProperty)]
		string ERROR_SAVING_PAYMENT_METHOD_ALERT_TITLE { get; }

		// +(NSString *)ERROR_SAVING_PAYPAL_ACCOUNT_ALERT_MESSAGE;
		[Static]
		[Export ("ERROR_SAVING_PAYPAL_ACCOUNT_ALERT_MESSAGE")]
		//[Verify (MethodToProperty)]
		string ERROR_SAVING_PAYPAL_ACCOUNT_ALERT_MESSAGE { get; }

		// +(NSString *)ADD_PAYMENT_METHOD_VIEW_CONTROLLER_TITLE;
		[Static]
		[Export ("ADD_PAYMENT_METHOD_VIEW_CONTROLLER_TITLE")]
		//[Verify (MethodToProperty)]
		string ADD_PAYMENT_METHOD_VIEW_CONTROLLER_TITLE { get; }
	}

	// @interface BTDropInSelectPaymentMethodViewController : UITableViewController
	[BaseType (typeof(UITableViewController))]
	interface BTDropInSelectPaymentMethodViewController
	{
		// @property (nonatomic, strong) BTAPIClient * client;
		[Export ("client", ArgumentSemantic.Strong)]
		BTAPIClient Client { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BTDropInSelectPaymentMethodViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTDropInSelectPaymentMethodViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) NSArray * paymentMethodNonces;
		[Export ("paymentMethodNonces", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] PaymentMethodNonces { get; set; }

		// @property (assign, nonatomic) NSInteger selectedPaymentMethodIndex;
		[Export ("selectedPaymentMethodIndex")]
		nint SelectedPaymentMethodIndex { get; set; }

		// @property (nonatomic, strong) BTUI * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @protocol BTDropInSelectPaymentMethodViewControllerDelegate
	[Protocol, Model]
	//ISSUE (line below had to be added)
	[BaseType (typeof(NSObject))]
	interface BTDropInSelectPaymentMethodViewControllerDelegate
	{
		// @required -(void)selectPaymentMethodViewController:(BTDropInSelectPaymentMethodViewController *)viewController didSelectPaymentMethodAtIndex:(NSUInteger)index;
		[Abstract]
		[Export ("selectPaymentMethodViewController:didSelectPaymentMethodAtIndex:")]
		void SelectPaymentMethodViewController (BTDropInSelectPaymentMethodViewController viewController, uint index);

		// @required -(void)selectPaymentMethodViewControllerDidRequestNew:(BTDropInSelectPaymentMethodViewController *)viewController;
		[Abstract]
		[Export ("selectPaymentMethodViewControllerDidRequestNew:")]
		void SelectPaymentMethodViewControllerDiindRequestNew (BTDropInSelectPaymentMethodViewController viewController);
	}

	// @interface BTDropInUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface BTDropInUtil
	{
		// +(BTUIPaymentOptionType)uiForCardNetwork:(BTCardNetwork)cardNetwork;
		[Static]
		[Export ("uiForCardNetwork:")]
		BTUIPaymentOptionType UiForCardNetwork (BTCardNetwork cardNetwork);
	}

	// @interface  (BTDropInViewController)
	[Category]
	[BaseType (typeof(BTDropInViewController))]
	interface BTDropInViewController_
	{
		// @property (nonatomic, strong) BTDropInContentView * dropInContentView;
		//[Export ("dropInContentView")]
		//BTDropInContentView DropInContentView { get; set; }

		// -(BTDropInViewController *)addPaymentMethodDropInViewController;
		[Export ("addPaymentMethodDropInViewController")]
		//[Verify (MethodToProperty)]
		BTDropInViewController AddPaymentMethodDropInViewController ();
	}

	// @interface BTKeychain : NSObject
	[BaseType (typeof(NSObject))]
	interface BTKeychain
	{
		// +(BOOL)setString:(NSString *)string forKey:(NSString *)key;
		[Static]
		[Export ("setString:forKey:")]
		bool SetString (string @string, string key);

		// +(NSString *)stringForKey:(NSString *)key;
		[Static]
		[Export ("stringForKey:")]
		string StringForKey (string key);

		// +(BOOL)setData:(NSData *)data forKey:(NSString *)key;
		[Static]
		[Export ("setData:forKey:")]
		bool SetData (NSData data, string key);

		// +(NSData *)dataForKey:(NSString *)key;
		[Static]
		[Export ("dataForKey:")]
		NSData DataForKey (string key);
	}

	// @interface  (BTLogger)
	[Category]
	[BaseType (typeof(BTLogger))]
	interface BTLogger_
	{
		// -(void)log:(NSString *)format, ...;
		[Internal]
		[Export ("log:", IsVariadic = true)]
		void Log (string format, IntPtr varArgs);

		// -(void)critical:(NSString *)format, ...;
		[Internal]
		[Export ("critical:", IsVariadic = true)]
		void Critical (string format, IntPtr varArgs);

		// -(void)error:(NSString *)format, ...;
		[Internal]
		[Export ("error:", IsVariadic = true)]
		void Error (string format, IntPtr varArgs);

		// -(void)warning:(NSString *)format, ...;
		[Internal]
		[Export ("warning:", IsVariadic = true)]
		void Warning (string format, IntPtr varArgs);

		// -(void)info:(NSString *)format, ...;
		[Internal]
		[Export ("info:", IsVariadic = true)]
		void Info (string format, IntPtr varArgs);

		// -(void)debug:(NSString *)format, ...;
		[Internal]
		[Export ("debug:", IsVariadic = true)]
		void Debug (string format, IntPtr varArgs);

		// @property (copy, nonatomic) void (^logBlock)(BTLogLevel, NSString *);
		//[Export ("logBlock")]
		//Action<BTLogLevel, NSString> LogBlock { get; set; }
	}

	// @interface  (BTPaymentButton)
	[Category]
	[BaseType (typeof(BTPaymentButton))]
	interface BTPaymentButton_
	{
		// @property (nonatomic, strong) id application;
		//[Export ("application")]
		//NSObject Application { get; set; }

		// -(NSOrderedSet *)filteredEnabledPaymentOptions;
		[Export ("filteredEnabledPaymentOptions")]
		//[Verify (MethodToProperty)]
		NSOrderedSet FilteredEnabledPaymentOptions ();
	}


	// @interface  (BTPayPalAccountNonce)
	[Category]
	[BaseType (typeof(BTPayPalAccountNonce))]
	interface BTPayPalAccountNonce_
	{
		// -(instancetype)initWithNonce:(NSString *)nonce description:(NSString *)description email:(NSString *)email firstName:(NSString *)firstName lastName:(NSString *)lastName phone:(NSString *)phone billingAddress:(BTPostalAddress *)billingAddress shippingAddress:(BTPostalAddress *)shippingAddress clientMetadataId:(NSString *)clientMetadataId payerId:(NSString *)payerId;
		//[Export ("initWithNonce:description:email:firstName:lastName:phone:billingAddress:shippingAddress:clientMetadataId:payerId:")]
		//IntPtr Constructor (string nonce, string description, string email, string firstName, string lastName, string phone, BTPostalAddress billingAddress, BTPostalAddress shippingAddress, string clientMetadataId, string payerId);
	}

	// @interface BTPayPalRequestFactory : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPayPalRequestFactory
	{
		// -(id)checkoutRequestWithApprovalURL:(NSURL *)approvalURL clientID:(NSString *)clientID environment:(NSString *)environment callbackURLScheme:(NSString *)callbackURLScheme;
		[Export ("checkoutRequestWithApprovalURL:clientID:environment:callbackURLScheme:")]
		NSObject CheckoutRequestWithApprovalURL (NSUrl approvalURL, string clientID, string environment, string callbackURLScheme);

		// -(id)billingAgreementRequestWithApprovalURL:(NSURL *)approvalURL clientID:(NSString *)clientID environment:(NSString *)environment callbackURLScheme:(NSString *)callbackURLScheme;
		[Export ("billingAgreementRequestWithApprovalURL:clientID:environment:callbackURLScheme:")]
		NSObject BillingAgreementRequestWithApprovalURL (NSUrl approvalURL, string clientID, string environment, string callbackURLScheme);

		// -(id)requestWithScopeValues:(NSSet *)scopeValues privacyURL:(NSURL *)privacyURL agreementURL:(NSURL *)agreementURL clientID:(NSString *)clientID environment:(NSString *)environment callbackURLScheme:(NSString *)callbackURLScheme;
		[Export ("requestWithScopeValues:privacyURL:agreementURL:clientID:environment:callbackURLScheme:")]
		NSObject RequestWithScopeValues (NSSet scopeValues, NSUrl privacyURL, NSUrl agreementURL, string clientID, string environment, string callbackURLScheme);
	}

	// @interface  (BTPayPalDriver)
	[Category]
	[BaseType (typeof(BTPayPalDriver))]
	interface BTPayPalDriver_
	{
		// -(void)setExpressCheckoutAppSwitchReturnBlock:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("setExpressCheckoutAppSwitchReturnBlock:")]
		void SetExpressCheckoutAppSwitchReturnBlock (Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)setBillingAgreementAppSwitchReturnBlock:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("setBillingAgreementAppSwitchReturnBlock:")]
		void SetBillingAgreementAppSwitchReturnBlock (Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)setAuthorizationAppSwitchReturnBlock:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("setAuthorizationAppSwitchReturnBlock:")]
		void SetAuthorizationAppSwitchReturnBlock (Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)informDelegatePresentingViewControllerRequestPresent:(NSURL * _Nonnull)appSwitchURL;
		[Export ("informDelegatePresentingViewControllerRequestPresent:")]
		void InformDelegatePresentingViewControllerRequestPresent (NSUrl appSwitchURL);

		// -(void)informDelegatePresentingViewControllerNeedsDismissal;
		[Export ("informDelegatePresentingViewControllerNeedsDismissal")]
		void InformDelegatePresentingViewControllerNeedsDismissal ();

		// @property (nonatomic, strong) BTPayPalRequestFactory * _Nonnull requestFactory;
		//[Export ("requestFactory")]
		//BTPayPalRequestFactory RequestFactory { get; set; }

		// +(Class _Nonnull)payPalClass;
		// +(void)setPayPalClass:(Class _Nonnull)payPalClass;
		[Static]
		[Export ("payPalClass")]
		//[Verify (MethodToProperty)]
		Class PayPalClass { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull returnURLScheme;
		//[Export ("returnURLScheme")]
		//string ReturnURLScheme { get; set; }

		// @property (nonatomic, strong) BTAPIClient * _Nullable apiClient;
		//[NullAllowed, Export ("apiClient")]
		//BTAPIClient ApiClient { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull clientMetadataId;
		//[Export ("clientMetadataId")]
		//string ClientMetadataId { get; set; }

		// @property (nonatomic, strong) SFSafariViewController * _Nullable safariViewController;
		//[NullAllowed, Export ("safariViewController")]
		//SFSafariViewController SafariViewController { get; set; }
	}

	// @interface BTUICardVectorArtView : BTUIVectorArtView
	[BaseType (typeof(BTUIVectorArtView))]
	interface BTUICardVectorArtView
	{
		// @property (nonatomic, strong) UIColor * highlightColor;
		[Export ("highlightColor", ArgumentSemantic.Strong)]
		UIColor HighlightColor { get; set; }
	}

	// @interface BTUIAmExVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIAmExVectorArtView
	{
	}

	// @interface BTUICardCvvField
	interface BTUICardCvvField
	{
		// @property (nonatomic, strong) int * cardType;
		[Export ("cardType", ArgumentSemantic.Strong)]
		unsafe int* CardType { get; set; }

		// @property (copy, nonatomic) NSString * cvv;
		[Export ("cvv")]
		string Cvv { get; set; }
	}

	// @interface BTUICardExpirationValidator : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUICardExpirationValidator
	{
		// +(BOOL)month:(NSUInteger)month year:(NSUInteger)year validForDate:(NSDate *)date;
		[Static]
		[Export ("month:year:validForDate:")]
		bool Month (uint month, uint year, NSDate date);
	}

	// @interface BTUICardExpiryField
	interface BTUICardExpiryField
	{
		// @property (readonly, nonatomic, strong) NSString * expirationMonth;
		[Export ("expirationMonth", ArgumentSemantic.Strong)]
		string ExpirationMonth { get; }

		// @property (readonly, nonatomic, strong) NSString * expirationYear;
		[Export ("expirationYear", ArgumentSemantic.Strong)]
		string ExpirationYear { get; }

		// @property (copy, nonatomic) NSString * expirationDate;
		[Export ("expirationDate")]
		string ExpirationDate { get; set; }
	}

	// @interface BTUICardExpiryFormat : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUICardExpiryFormat
	{
		// @property (copy, nonatomic) NSString * value;
		[Export ("value")]
		string Value { get; set; }

		// @property (assign, nonatomic) NSUInteger cursorLocation;
		[Export ("cursorLocation")]
		uint CursorLocation { get; set; }

		// @property (assign, nonatomic) BOOL backspace;
		[Export ("backspace")]
		bool Backspace { get; set; }

		// -(void)formattedValue:(NSString **)value cursorLocation:(NSUInteger *)cursorLocation;
		[Export ("formattedValue:cursorLocation:")]
		unsafe void FormattedValue (out string value, NSObject[] cursorLocation);
	}

	// @interface BTUICardNumberField
	interface BTUICardNumberField
	{
		// @property (readonly, nonatomic, strong) int * cardType;
		[Export ("cardType", ArgumentSemantic.Strong)]
		unsafe int* CardType { get; }

		// @property (nonatomic, strong) NSString * number;
		[Export ("number", ArgumentSemantic.Strong)]
		string Number { get; set; }
	}

	// @interface BTUICardPostalCodeField
	interface BTUICardPostalCodeField
	{
		// @property (nonatomic, strong) NSString * postalCode;
		[Export ("postalCode", ArgumentSemantic.Strong)]
		string PostalCode { get; set; }

		// @property (assign, nonatomic) BOOL nonDigitsSupported;
		[Export ("nonDigitsSupported")]
		bool NonDigitsSupported { get; set; }
	}

	// @interface BTUICardType : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUICardType
	{
		// +(instancetype)cardTypeForBrand:(NSString *)brand;
		[Static]
		[Export ("cardTypeForBrand:")]
		BTUICardType CardTypeForBrand (string brand);

		// +(instancetype)cardTypeForNumber:(NSString *)number;
		[Static]
		[Export ("cardTypeForNumber:")]
		BTUICardType CardTypeForNumber (string number);

		// +(NSArray *)possibleCardTypesForNumber:(NSString *)number;
		[Static]
		[Export ("possibleCardTypesForNumber:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] PossibleCardTypesForNumber (string number);

		// -(BOOL)validNumber:(NSString *)number;
		[Export ("validNumber:")]
		bool ValidNumber (string number);

		// -(BOOL)completeNumber:(NSString *)number;
		[Export ("completeNumber:")]
		bool CompleteNumber (string number);

		// -(BOOL)validAndNecessarilyCompleteNumber:(NSString *)number;
		[Export ("validAndNecessarilyCompleteNumber:")]
		bool ValidAndNecessarilyCompleteNumber (string number);

		// -(BOOL)validCvv:(NSString *)cvv;
		[Export ("validCvv:")]
		bool ValidCvv (string cvv);

		// -(NSAttributedString *)formatNumber:(NSString *)input;
		[Export ("formatNumber:")]
		NSAttributedString FormatNumber (string input);

		// -(NSAttributedString *)formatNumber:(NSString *)input kerning:(CGFloat)kerning;
		[Export ("formatNumber:kerning:")]
		NSAttributedString FormatNumber (string input, nfloat kerning);

		// +(NSUInteger)maxNumberLength;
		[Static]
		[Export ("maxNumberLength")]
		//[Verify (MethodToProperty)]
		uint MaxNumberLength { get; }

		// @property (readonly, copy, nonatomic) NSString * brand;
		[Export ("brand")]
		string Brand { get; }

		// @property (readonly, nonatomic, strong) NSArray * validNumberPrefixes;
		[Export ("validNumberPrefixes", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ValidNumberPrefixes { get; }

		// @property (readonly, nonatomic, strong) NSIndexSet * validNumberLengths;
		[Export ("validNumberLengths", ArgumentSemantic.Strong)]
		NSIndexSet ValidNumberLengths { get; }

		// @property (readonly, assign, nonatomic) NSUInteger validCvvLength;
		[Export ("validCvvLength")]
		uint ValidCvvLength { get; }

		// @property (readonly, nonatomic, strong) NSArray * formatSpaces;
		[Export ("formatSpaces", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] FormatSpaces { get; }
	}

	// @interface BTUICoinbaseMonogramCardView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUICoinbaseMonogramCardView
	{
	}

	// @interface BTUICoinbaseWordmarkVectorArtView : BTUIVectorArtView
	[BaseType (typeof(BTUIVectorArtView))]
	interface BTUICoinbaseWordmarkVectorArtView
	{
		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }
	}

	// @interface BTUICVVBackVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUICVVBackVectorArtView
	{
	}

	// @interface BTUICVVFrontVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUICVVFrontVectorArtView
	{
	}

	// @interface BTUIDinersClubVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIDinersClubVectorArtView
	{
	}

	// @interface BTUIDiscoverVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIDiscoverVectorArtView
	{
	}

	// @interface BTUIFloatLabel : BTUIThemedView
	[BaseType (typeof(BTUIThemedView))]
	interface BTUIFloatLabel
	{
		// @property (readonly, nonatomic, strong) UILabel * label;
		[Export ("label", ArgumentSemantic.Strong)]
		UILabel Label { get; }

		// -(void)showWithAnimation:(BOOL)shouldAnimate;
		[Export ("showWithAnimation:")]
		void ShowWithAnimation (bool shouldAnimate);

		// -(void)hideWithAnimation:(BOOL)shouldAnimate;
		[Export ("hideWithAnimation:")]
		void HideWithAnimation (bool shouldAnimate);
	}

	// @interface BTUIFormField : BTUIThemedView <UITextFieldDelegate, UIKeyInput>
	[BaseType (typeof(BTUIThemedView))]
	interface BTUIFormField : IUITextFieldDelegate, IUIKeyInput
	{
		// -(void)updateAppearance;
		[Export ("updateAppearance")]
		void UpdateAppearance ();

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BTUIFormFieldDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTUIFormFieldDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL vibrateOnInvalidInput;
		[Export ("vibrateOnInvalidInput")]
		bool VibrateOnInvalidInput { get; set; }

		// @property (readonly, assign, nonatomic) BOOL valid;
		[Export ("valid")]
		bool Valid { get; }

		// @property (readonly, assign, nonatomic) BOOL entryComplete;
		[Export ("entryComplete")]
		bool EntryComplete { get; }

		// @property (assign, nonatomic) BOOL displayAsValid;
		[Export ("displayAsValid")]
		bool DisplayAsValid { get; set; }

		// @property (assign, nonatomic) BOOL bottomBorder;
		[Export ("bottomBorder")]
		bool BottomBorder { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL backspace;
		[Export ("backspace")]
		bool Backspace { get; set; }

		// @property (copy, nonatomic) NSString * text;
		[Export ("text")]
		string Text { get; set; }

		// @property (readonly, nonatomic, strong) BTUITextField * textField;
		[Export ("textField", ArgumentSemantic.Strong)]
		BTUITextField TextField { get; }

		// @property (nonatomic, strong) UIView * accessoryView;
		[Export ("accessoryView", ArgumentSemantic.Strong)]
		UIView AccessoryView { get; set; }
	}

	// @protocol BTUIFormFieldDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUIFormFieldDelegate
	{
		// @required -(void)formFieldDidChange:(BTUIFormField *)formField;
		[Abstract]
		[Export ("formFieldDidChange:")]
		void FormFieldDidChange (BTUIFormField formField);

		// @required -(void)formFieldDidDeleteWhileEmpty:(BTUIFormField *)formField;
		[Abstract]
		[Export ("formFieldDidDeleteWhileEmpty:")]
		void FormFieldDidDeleteWhileEmpty (BTUIFormField formField);

		// @optional -(BOOL)formFieldShouldReturn:(BTUIFormField *)formField;
		[Export ("formFieldShouldReturn:")]
		bool FormFieldShouldReturn (BTUIFormField formField);

		// @optional -(void)formFieldDidBeginEditing:(BTUIFormField *)formField;
		[Export ("formFieldDidBeginEditing:")]
		void FormFieldDidBeginEditing (BTUIFormField formField);
	}

	// @interface BTUITextField : UITextField
	[BaseType (typeof(UITextField))]
	interface BTUITextField
	{
		[Wrap ("WeakEditDelegate")]
		[NullAllowed]
		BTUITextFieldEditDelegate EditDelegate { get; set; }

		// @property (nonatomic, weak) id<BTUITextFieldEditDelegate> _Nullable editDelegate;
		[NullAllowed, Export ("editDelegate", ArgumentSemantic.Weak)]
		NSObject WeakEditDelegate { get; set; }
	}

	// @protocol BTUITextFieldEditDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUITextFieldEditDelegate
	{
		// @optional -(void)textFieldWillDeleteBackward:(BTUITextField *)textField;
		[Export ("textFieldWillDeleteBackward:")]
		void TextFieldWillDeleteBackward (BTUITextField textField);

		// @optional -(void)textFieldDidDeleteBackward:(BTUITextField *)textField originalText:(NSString *)originalText;
		[Export ("textFieldDidDeleteBackward:originalText:")]
		void TextFieldDidDeleteBackward (BTUITextField textField, string originalText);

		// @optional -(void)textField:(BTUITextField *)textField willInsertText:(NSString *)text;
		[Export ("textField:willInsertText:")]
		void TextField (BTUITextField textField, string text);

		// @optional -(void)textField:(BTUITextField *)textField didInsertText:(NSString *)text;
		//[Export ("textField:didInsertText:")]
		//void TextField (BTUITextField textField, string text);
	}

	// @interface  (BTUIFormField)
	[Category]
	[BaseType (typeof(BTUIFormField))]
	interface BTUIFormField_
	{
		// @property (readonly, nonatomic, strong) BTUITextField * textField;
		[Export ("textField")]
		BTUITextField TextField ();

		// @property (nonatomic, strong) UIView * accessoryView;
		//[Export ("accessoryView")]
		//UIView AccessoryView { get; set; }

		// -(void)fieldContentDidChange;
		[Export ("fieldContentDidChange")]
		void FieldContentDidChange ();

		// -(void)setThemedPlaceholder:(NSString *)placeholder;
		[Export ("setThemedPlaceholder:")]
		void SetThemedPlaceholder (string placeholder);

		// -(void)setThemedAttributedPlaceholder:(NSAttributedString *)placeholder;
		[Export ("setThemedAttributedPlaceholder:")]
		void SetThemedAttributedPlaceholder (NSAttributedString placeholder);
	}

	// @interface BTUIHorizontalButtonStackCollectionViewFlowLayout : UICollectionViewFlowLayout
	[BaseType (typeof(UICollectionViewFlowLayout))]
	interface BTUIHorizontalButtonStackCollectionViewFlowLayout
	{
	}

	// @interface BTUIHorizontalButtonStackSeparatorLineView : UICollectionReusableView
	[BaseType (typeof(UICollectionReusableView))]
	interface BTUIHorizontalButtonStackSeparatorLineView
	{
		// @property (nonatomic, strong) BTUI * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @interface BTUIJCBVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIJCBVectorArtView
	{
	}

	// @interface BTUILocalizedString : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUILocalizedString
	{
		// +(NSString *)CARD_NUMBER_PLACEHOLDER;
		[Static]
		[Export ("CARD_NUMBER_PLACEHOLDER")]
		//[Verify (MethodToProperty)]
		string CARD_NUMBER_PLACEHOLDER { get; }

		// +(NSString *)CVV_FIELD_PLACEHOLDER;
		[Static]
		[Export ("CVV_FIELD_PLACEHOLDER")]
		//[Verify (MethodToProperty)]
		string CVV_FIELD_PLACEHOLDER { get; }

		// +(NSString *)EXPIRY_PLACEHOLDER_FOUR_DIGIT_YEAR;
		[Static]
		[Export ("EXPIRY_PLACEHOLDER_FOUR_DIGIT_YEAR")]
		//[Verify (MethodToProperty)]
		string EXPIRY_PLACEHOLDER_FOUR_DIGIT_YEAR { get; }

		// +(NSString *)EXPIRY_PLACEHOLDER_TWO_DIGIT_YEAR;
		[Static]
		[Export ("EXPIRY_PLACEHOLDER_TWO_DIGIT_YEAR")]
		//[Verify (MethodToProperty)]
		string EXPIRY_PLACEHOLDER_TWO_DIGIT_YEAR { get; }

		// +(NSString *)PAYPAL_CARD_BRAND;
		[Static]
		[Export ("PAYPAL_CARD_BRAND")]
		//[Verify (MethodToProperty)]
		string PAYPAL_CARD_BRAND { get; }

		// +(NSString *)POSTAL_CODE_PLACEHOLDER;
		[Static]
		[Export ("POSTAL_CODE_PLACEHOLDER")]
		//[Verify (MethodToProperty)]
		string POSTAL_CODE_PLACEHOLDER { get; }

		// +(NSString *)TOP_LEVEL_ERROR_ALERT_VIEW_OK_BUTTON_TEXT;
		[Static]
		[Export ("TOP_LEVEL_ERROR_ALERT_VIEW_OK_BUTTON_TEXT")]
		//[Verify (MethodToProperty)]
		string TOP_LEVEL_ERROR_ALERT_VIEW_OK_BUTTON_TEXT { get; }

		// +(NSString *)CARD_TYPE_AMERICAN_EXPRESS;
		[Static]
		[Export ("CARD_TYPE_AMERICAN_EXPRESS")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_AMERICAN_EXPRESS { get; }

		// +(NSString *)CARD_TYPE_DISCOVER;
		[Static]
		[Export ("CARD_TYPE_DISCOVER")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_DISCOVER { get; }

		// +(NSString *)CARD_TYPE_DINERS_CLUB;
		[Static]
		[Export ("CARD_TYPE_DINERS_CLUB")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_DINERS_CLUB { get; }

		// +(NSString *)CARD_TYPE_MASTER_CARD;
		[Static]
		[Export ("CARD_TYPE_MASTER_CARD")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_MASTER_CARD { get; }

		// +(NSString *)CARD_TYPE_VISA;
		[Static]
		[Export ("CARD_TYPE_VISA")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_VISA { get; }

		// +(NSString *)CARD_TYPE_JCB;
		[Static]
		[Export ("CARD_TYPE_JCB")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_JCB { get; }

		// +(NSString *)CARD_TYPE_MAESTRO;
		[Static]
		[Export ("CARD_TYPE_MAESTRO")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_MAESTRO { get; }

		// +(NSString *)CARD_TYPE_UNION_PAY;
		[Static]
		[Export ("CARD_TYPE_UNION_PAY")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_UNION_PAY { get; }

		// +(NSString *)CARD_TYPE_SWITCH;
		[Static]
		[Export ("CARD_TYPE_SWITCH")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_SWITCH { get; }

		// +(NSString *)CARD_TYPE_SOLO;
		[Static]
		[Export ("CARD_TYPE_SOLO")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_SOLO { get; }

		// +(NSString *)CARD_TYPE_LASER;
		[Static]
		[Export ("CARD_TYPE_LASER")]
		//[Verify (MethodToProperty)]
		string CARD_TYPE_LASER { get; }

		// +(NSString *)PAYMENT_METHOD_TYPE_PAYPAL;
		[Static]
		[Export ("PAYMENT_METHOD_TYPE_PAYPAL")]
		//[Verify (MethodToProperty)]
		string PAYMENT_METHOD_TYPE_PAYPAL { get; }

		// +(NSString *)PAYMENT_METHOD_TYPE_COINBASE;
		[Static]
		[Export ("PAYMENT_METHOD_TYPE_COINBASE")]
		//[Verify (MethodToProperty)]
		string PAYMENT_METHOD_TYPE_COINBASE { get; }

		// +(NSString *)PAYMENT_METHOD_TYPE_VENMO;
		[Static]
		[Export ("PAYMENT_METHOD_TYPE_VENMO")]
		//[Verify (MethodToProperty)]
		string PAYMENT_METHOD_TYPE_VENMO { get; }
	}

	// @interface BTUIMaestroVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIMaestroVectorArtView
	{
	}

	// @interface BTUIMasterCardVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIMasterCardVectorArtView
	{
	}

	// @interface BTUIPaymentButtonCollectionViewCell : UICollectionViewCell
	[BaseType (typeof(UICollectionViewCell))]
	interface BTUIPaymentButtonCollectionViewCell
	{
		// @property (nonatomic, strong) UIControl * paymentButton;
		[Export ("paymentButton", ArgumentSemantic.Strong)]
		UIControl PaymentButton { get; set; }
	}

	// @interface BTUIPayPalMonogramCardView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIPayPalMonogramCardView
	{
	}

	// @interface BTUIPayPalWordmarkVectorArtView : BTUIVectorArtView
	[BaseType (typeof(BTUIVectorArtView))]
	interface BTUIPayPalWordmarkVectorArtView
	{
		// @property (nonatomic, strong) BTUI * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		BTUI Theme { get; set; }
	}

	// @interface BTUIScrollView : UIScrollView
	[BaseType (typeof(UIScrollView))]
	interface BTUIScrollView
	{
		[Wrap ("WeakScrollRectToVisibleDelegate")]
		[NullAllowed]
		BTUIScrollViewScrollRectToVisibleDelegate ScrollRectToVisibleDelegate { get; set; }

		// @property (nonatomic, weak) id<BTUIScrollViewScrollRectToVisibleDelegate> _Nullable scrollRectToVisibleDelegate;
		[NullAllowed, Export ("scrollRectToVisibleDelegate", ArgumentSemantic.Weak)]
		NSObject WeakScrollRectToVisibleDelegate { get; set; }

		// -(void)defaultScrollRectToVisible:(CGRect)rect animated:(BOOL)animated;
		[Export ("defaultScrollRectToVisible:animated:")]
		void DefaultScrollRectToVisible (CGRect rect, bool animated);
	}

	// @protocol BTUIScrollViewScrollRectToVisibleDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUIScrollViewScrollRectToVisibleDelegate
	{
		// @required -(void)scrollView:(BTUIScrollView *)scrollView requestsScrollRectToVisible:(CGRect)rect animated:(BOOL)animated;
		[Abstract]
		[Export ("scrollView:requestsScrollRectToVisible:animated:")]
		void RequestsScrollRectToVisible (BTUIScrollView scrollView, CGRect rect, bool animated);
	}

	// @interface BTUIUnknownCardVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIUnknownCardVectorArtView
	{
	}

	// @interface BTUIUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIUtil
	{
		// +(BOOL)luhnValid:(NSString *)cardNumber;
		[Static]
		[Export ("luhnValid:")]
		bool LuhnValid (string cardNumber);

		// +(NSString *)stripNonDigits:(NSString *)input;
		[Static]
		[Export ("stripNonDigits:")]
		string StripNonDigits (string input);

		// +(NSString *)stripNonExpiry:(NSString *)input;
		[Static]
		[Export ("stripNonExpiry:")]
		string StripNonExpiry (string input);
	}

	// @interface BTUIVenmoMonogramCardView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIVenmoMonogramCardView
	{
	}

	// @interface BTUIVenmoWordmarkVectorArtView : BTUIVectorArtView
	[BaseType (typeof(BTUIVectorArtView))]
	interface BTUIVenmoWordmarkVectorArtView
	{
		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }
	}

	// @interface BTUIViewUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIViewUtil
	{
		// +(BTUIPaymentOptionType)paymentMethodTypeForCardType:(BTUICardType *)cardType;
		[Static]
		[Export ("paymentMethodTypeForCardType:")]
		BTUIPaymentOptionType PaymentMethodTypeForCardType (BTUICardType cardType);

		// +(NSString *)nameForPaymentMethodType:(BTUIPaymentOptionType)paymentMethodType;
		[Static]
		[Export ("nameForPaymentMethodType:")]
		string NameForPaymentMethodType (BTUIPaymentOptionType paymentMethodType);

		// +(void)vibrate;
		[Static]
		[Export ("vibrate")]
		void Vibrate ();
	}

	// @interface BTUIVisaVectorArtView : BTUICardVectorArtView
	[BaseType (typeof(BTUICardVectorArtView))]
	interface BTUIVisaVectorArtView
	{
	}

	// @interface BTURLUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface BTURLUtils
	{
		// +(NSURL *)URLfromURL:(NSURL *)URL withAppendedQueryDictionary:(NSDictionary *)dictionary;
		[Static]
		[Export ("URLfromURL:withAppendedQueryDictionary:")]
		NSUrl URLfromURL (NSUrl URL, NSDictionary dictionary);

		// +(NSString *)queryStringWithDictionary:(NSDictionary *)dict;
		[Static]
		[Export ("queryStringWithDictionary:")]
		string QueryStringWithDictionary (NSDictionary dict);

		// +(NSDictionary *)dictionaryForQueryString:(NSString *)queryString;
		[Static]
		[Export ("dictionaryForQueryString:")]
		NSDictionary DictionaryForQueryString (string queryString);
	}

	// @interface PayPalOneTouchCoreResult : NSObject
	[BaseType (typeof(NSObject))]
	interface PayPalOneTouchCoreResult
	{
		// @property (readonly, assign, nonatomic) PayPalOneTouchResultType type;
		[Export ("type", ArgumentSemantic.Assign)]
		PayPalOneTouchResultType Type { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * response;
		[Export ("response", ArgumentSemantic.Copy)]
		NSDictionary Response { get; }

		// @property (readonly, copy, nonatomic) NSError * error;
		[Export ("error", ArgumentSemantic.Copy)]
		NSError Error { get; }

		// @property (readonly, assign, nonatomic) PayPalOneTouchRequestTarget target;
		[Export ("target", ArgumentSemantic.Assign)]
		PayPalOneTouchRequestTarget Target { get; }
	}

	// typedef void (^PayPalOneTouchCompletionBlock)(PayPalOneTouchCoreResult *);
	delegate void PayPalOneTouchCompletionBlock (PayPalOneTouchCoreResult arg0);

	// @interface PayPalOneTouchCore : NSObject
	[BaseType (typeof(NSObject))]
	interface PayPalOneTouchCore
	{
		// +(BOOL)doesApplicationSupportOneTouchCallbackURLScheme:(NSString *)callbackURLScheme;
		[Static]
		[Export ("doesApplicationSupportOneTouchCallbackURLScheme:")]
		bool DoesApplicationSupportOneTouchCallbackURLScheme (string callbackURLScheme);

		// +(BOOL)isWalletAppInstalled;
		[Static]
		[Export ("isWalletAppInstalled")]
		//[Verify (MethodToProperty)]
		bool IsWalletAppInstalled { get; }

		// +(BOOL)canParseURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication;
		[Static]
		[Export ("canParseURL:sourceApplication:")]
		bool CanParseURL (NSUrl url, string sourceApplication);

		// +(void)parseResponseURL:(NSURL *)url completionBlock:(PayPalOneTouchCompletionBlock)completionBlock;
		[Static]
		[Export ("parseResponseURL:completionBlock:")]
		void ParseResponseURL (NSUrl url, PayPalOneTouchCompletionBlock completionBlock);

		// +(NSString *)clientMetadataID;
		[Static]
		[Export ("clientMetadataID")]
		//[Verify (MethodToProperty)]
		string ClientMetadataID { get; }

		// +(void)redirectURLsForCallbackURLScheme:(NSString *)callbackURLScheme withReturnURL:(NSString **)returnURL withCancelURL:(NSString **)cancelURL;
		[Static]
		[Export ("redirectURLsForCallbackURLScheme:withReturnURL:withCancelURL:")]
		void RedirectURLsForCallbackURLScheme (string callbackURLScheme, out string returnURL, out string cancelURL);

		// +(NSString *)libraryVersion;
		[Static]
		[Export ("libraryVersion")]
		//[Verify (MethodToProperty)]
		string LibraryVersion { get; }
	}

	// typedef void (^PayPalOneTouchRequestPreflightCompletionBlock)(PayPalOneTouchRequestTarget);
	delegate void PayPalOneTouchRequestPreflightCompletionBlock (PayPalOneTouchRequestTarget arg0);

	// typedef void (^PayPalOneTouchRequestAdapterBlock)(BOOL, NSURL *, PayPalOneTouchRequestTarget, NSString *, NSError *);
	delegate void PayPalOneTouchRequestAdapterBlock (bool arg0, NSUrl arg1, PayPalOneTouchRequestTarget arg2, string arg3, NSError arg4);

	// @interface PayPalOneTouchRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface PayPalOneTouchRequest
	{
		// -(void)getTargetApp:(PayPalOneTouchRequestPreflightCompletionBlock)completionBlock;
		[Export ("getTargetApp:")]
		void GetTargetApp (PayPalOneTouchRequestPreflightCompletionBlock completionBlock);

		// -(void)performWithAdapterBlock:(PayPalOneTouchRequestAdapterBlock)adapterBlock;
		[Export ("performWithAdapterBlock:")]
		void PerformWithAdapterBlock (PayPalOneTouchRequestAdapterBlock adapterBlock);

		// +(NSString *)tokenFromApprovalURL:(NSURL *)approvalURL;
		[Static]
		[Export ("tokenFromApprovalURL:")]
		string TokenFromApprovalURL (NSUrl approvalURL);

		// @property (readonly, nonatomic) NSString * clientID;
		[Export ("clientID")]
		string ClientID { get; }

		// @property (readonly, nonatomic) NSString * environment;
		[Export ("environment")]
		string Environment { get; }

		// @property (readonly, nonatomic) NSString * callbackURLScheme;
		[Export ("callbackURLScheme")]
		string CallbackURLScheme { get; }

		// @property (nonatomic, strong) NSDictionary * additionalPayloadAttributes;
		[Export ("additionalPayloadAttributes", ArgumentSemantic.Strong)]
		NSDictionary AdditionalPayloadAttributes { get; set; }
	}

	// @interface PayPalOneTouchAuthorizationRequest : PayPalOneTouchRequest
	[BaseType (typeof(PayPalOneTouchRequest))]
	interface PayPalOneTouchAuthorizationRequest
	{
		// +(instancetype)requestWithScopeValues:(NSSet *)scopeValues privacyURL:(NSURL *)privacyURL agreementURL:(NSURL *)agreementURL clientID:(NSString *)clientID environment:(NSString *)environment callbackURLScheme:(NSString *)callbackURLScheme;
		[Static]
		[Export ("requestWithScopeValues:privacyURL:agreementURL:clientID:environment:callbackURLScheme:")]
		PayPalOneTouchAuthorizationRequest RequestWithScopeValues (NSSet scopeValues, NSUrl privacyURL, NSUrl agreementURL, string clientID, string environment, string callbackURLScheme);

		// @property (readonly, nonatomic) NSSet * scopeValues;
		[Export ("scopeValues")]
		NSSet ScopeValues { get; }

		// @property (readonly, nonatomic) NSURL * privacyURL;
		[Export ("privacyURL")]
		NSUrl PrivacyURL { get; }

		// @property (readonly, nonatomic) NSURL * agreementURL;
		[Export ("agreementURL")]
		NSUrl AgreementURL { get; }
	}

	// @interface PayPalOneTouchCheckoutRequest : PayPalOneTouchRequest
	[BaseType (typeof(PayPalOneTouchRequest))]
	interface PayPalOneTouchCheckoutRequest
	{
		// @property (nonatomic, strong) NSString * pairingId;
		[Export ("pairingId", ArgumentSemantic.Strong)]
		string PairingId { get; set; }

		// +(instancetype)requestWithApprovalURL:(NSURL *)approvalURL clientID:(NSString *)clientID environment:(NSString *)environment callbackURLScheme:(NSString *)callbackURLScheme;
		[Static]
		[Export ("requestWithApprovalURL:clientID:environment:callbackURLScheme:")]
		PayPalOneTouchCheckoutRequest RequestWithApprovalURL (NSUrl approvalURL, string clientID, string environment, string callbackURLScheme);

		// +(instancetype)requestWithApprovalURL:(NSURL *)approvalURL pairingId:(NSString *)pairingId clientID:(NSString *)clientID environment:(NSString *)environment callbackURLScheme:(NSString *)callbackURLScheme;
		[Static]
		[Export ("requestWithApprovalURL:pairingId:clientID:environment:callbackURLScheme:")]
		PayPalOneTouchCheckoutRequest RequestWithApprovalURL (NSUrl approvalURL, string pairingId, string clientID, string environment, string callbackURLScheme);

		// @property (readonly, nonatomic) NSURL * approvalURL;
		[Export ("approvalURL")]
		NSUrl ApprovalURL { get; }
	}

	// @interface PayPalOneTouchBillingAgreementRequest : PayPalOneTouchCheckoutRequest
	[BaseType (typeof(PayPalOneTouchCheckoutRequest))]
	interface PayPalOneTouchBillingAgreementRequest
	{
	}

	#region Instructions
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
	#endregion
}

