# SharpThemes

SharpThemes is a wrapper for the 3DSThem.es website, to provide easy access for developers on a variety 
of platforms that allows them to avoid all of the intricacies of the website. This was created in lieu of
any documentation of any API available for the website, simply looking through the JS files to see how
everything worked.

The project has been designed to run on multiple platforms through the NET Framework, and is fully compatible
in the following environments:
 - Windows
 - Mac (via Mono)
 - Linux (via Mono)
 - Android (via Xamarin)
 - iOS (via Xamarin)
 - Web (ASP.NET and Silverlight apps)
 
## Documentation

There is documentation available on the project [wiki](https://github.com/kade-robertson/SharpThemes/wiki). The documentation is
only guaranteed to be accurate as of the latest official release.

## Usage

To include this library in your project, there are two super simple ways of doing it:
 - Download the [latest release package](https://github.com/kade-robertson/SharpThemes/releases/latest) straight from GitHub
 - Install via a NuGet package, either through the development environment of your choice or by manually obtaining the `.nupkg`
   file from [here](https://github.com/kade-robertson/SharpThemes/releases).
   
## Contributing

If you are interested in helping me develop SharpThemes, the best way to go about it is to clone the repository and work on it
through your favourite IDE (Visual Studio, ReSharper, etc). Note that to be able to develop fully, you will need to be able to
grab the dependencies for this library via NuGet.

Once you have made changes on your own fork of the repository, I will review and merge them.

## Issues

If you have discovered an issue with SharpThemes, let me know! You can use the GitHub issue tracker to make a formal request. 
Be sure to be as detailed as possible, including the operating system / environment, what particular feature has broken, and 
what steps I need to take to reproduce these issues. If you do not provide this information, I will close the issue until you 
have provided the info.

You can also make feature requests through the issue tracker, I will label everything accordingly.

## Dependencies

This library is dependant on `ModernHttpClient` and `Newtonsoft.Json`. The testing application is also dependant on `Costura.Fody` 
and `Fody`, however these packages can be removed and it will build as usual.
