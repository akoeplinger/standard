#!/usr/bin/env bash
# Usage on OSX: copy-xamarin.sh /Volumes/Users/Alexander/Desktop/dotnet-standard-misc/

target=$1

rm $target/xamandroid/*.dll
rm $target/xamios/*.dll
rm $target/xamtvos/*.dll
rm $target/xamwatchos/*.dll
rm $target/xammac/*.dll

cp /Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/xbuild-frameworks/MonoAndroid/v1.0/*.dll $target/xamandroid/
cp /Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/xbuild-frameworks/MonoAndroid/v2.3/*.dll $target/xamandroid/
cp /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.iOS/*.dll $target/xamios/
cp /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.TVOS/*.dll $target/xamtvos/
cp /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.WatchOS/*.dll $target/xamwatchos/
cp /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/Xamarin.Mac/*.dll $target/xammac/

