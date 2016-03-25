XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=Pods
PROJECT=$(PROJECT_ROOT)/Pods.xcodeproj
TARGET=Braintree
OUTPUT=BraintreeBindings

all: libBraintree.a

libBraintree-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv build/Release-iphonesimulator/lib$(TARGET).a $@

libBraintree-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv build/Release-iphoneos/lib$(TARGET).a $@

libBraintree-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv build/Release-iphoneos/lib$(TARGET).a $@

libBraintree-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv build/Release-iphoneos/lib$(TARGET).a $@

libBraintree.a: libBraintree-i386.a libBraintree-armv7.a libBraintree-armv7s.a libBraintree-arm64.a
	lipo -create -output $@ $^ 
	lipo -create -output lib$(TARGET).a lib$(TARGET)-i386.a lib$(TARGET)-armv7.a lib$(TARGET)-armv7s.a lib$(TARGET)-arm64.a

clean:
	-rm -f *.a *.dll
