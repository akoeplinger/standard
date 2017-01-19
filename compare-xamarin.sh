#!/usr/bin/env bash
# Usage on OSX: compare-xamarin.sh /Volumes/Users/Alexander/Desktop/dotnet-standard/bin/AnyOS.AnyCPU.Debug/netstandard

checkdir=$1
result=0

for dir in $checkdir/*/
do
	if [[ "$dir" == *net461* ]]; then continue; fi

	dir=${dir%*/}
	for file in $dir/*.dll
	do
		if [[ "$file" == *netstandard.dll* ]]; then continue; fi
		echo "Checking $file"

		case $file in
			*xamarin.android/Mono.Android.dll)
				frameworkpath=/Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/xbuild-frameworks/MonoAndroid/v2.3/
				;;
			*xamarin.android*)
				frameworkpath=/Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/xbuild-frameworks/MonoAndroid/v1.0/
				;;
			*xamarin.ios*)
				frameworkpath=/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.iOS/
				;;
			*xamarin.tvos*)
				frameworkpath=/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.TVOS/
				;;
			*xamarin.watchos*)
				frameworkpath=/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.WatchOS/
				;;
			*xamarin.mac*)
				frameworkpath=/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/Xamarin.Mac/
				;;
			*)
				echo "Framework path not found for: $file"
				exit 1
				;;
		esac

		if [ -e $frameworkpath/Facades/$(basename $file) ]; then
			frameworkFile=$frameworkpath/Facades/$(basename $file)
		else
			frameworkFile=$frameworkpath/$(basename $file)
		fi

		rm -f sna.txt snb.txt
		sn -q -Tp $file > sna.txt
		sn -q -Tp $frameworkFile > snb.txt
		if ! diff sna.txt snb.txt ; then echo "!!! Differences found in sn !!!"; result=1; fi

		rm -f ika.txt ikb.txt
		ikdasm --assembly $file | grep -v BlobPtr | grep -v Flags > ika.txt
		ikdasm --assembly $frameworkFile | grep -v BlobPtr | grep -v Flags > ikb.txt
		if ! diff ika.txt ikb.txt ; then echo "!!! Differences found in ikdasm !!!"; result=1; fi
	done
done

if [ $result != 0 ]; then echo "FAIL: Differences found, check output above"; fi

exit $result
