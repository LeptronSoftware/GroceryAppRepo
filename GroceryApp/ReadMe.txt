MAUI 9 / .Net 9 App based on the Microsoft Reference Architecture App eShop
https://github.com/dotnet/eShop
App was tested on a real Android device building on Windows and the iOS simulator. It was not tested on a real iPhone even though it should work fine. 
On Windows it compiles and runs, but there is an issue with the Image control in Windows and MAUI 9 so it does not render well.
On Mac it compiles and runs fine.

------
You will need to use the Visual Studio Preview with the latest Android SDK or you will intermittently encounter UnauthorizedAccessExceptions when building Android
See https://github.com/dotnet/android/issues/9133

---------------
You have to use .Net Preview ( for some community toolkit features for partial classes)
Using [ObservableProperty] on partial properties requires the C# language version to be set to 'preview', as support for the 'field' keyword is needed by the source generators to emit valid code (add <LangVersion>preview</LangVersion> to your .csproj/.props file)


