using ObjCRuntime;

[assembly: LinkWith ("libBraintree.a", LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, WeakFrameworks="CoreFoundation UIKit SafariServices",
	Frameworks = "Foundation Security AudioToolbox SystemConfiguration CoreLocation MessageUI MobileCoreServices CoreMedia AVFoundation", IsCxx = true)]

// SmartLink = true, ForceLoad = false, LinkerFlags = "-lc++ -ObjC",
