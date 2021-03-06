# Changelog
All notable changes to the pre-compiled binaries of libvips will be documented in this file. The version number of these NuGet packages is in sync with libvips' version number.
The changes of libvips are documented [here](https://github.com/libvips/libvips/blob/master/ChangeLog).

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/) and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [8.9.1] - 2020-01-30
### Note
If you would like to see what's changed, please visit the the release notes of libvips:
https://github.com/libvips/libvips/releases/tag/v8.9.1

## [8.9.0] - 2020-01-30
### Note
If you would like to see what's changed, please visit the the release notes of libvips:
https://libvips.github.io/libvips/2019/12/11/What's-new-in-8.9.html

### Changed
- A statically linked libvips binary is build for Linux ([#51](https://github.com/kleisauke/net-vips/issues/51)).
- The NuGet packages now includes:
  - the latest third-party notices ([`THIRD-PARTY-NOTICES.md`](https://github.com/kleisauke/libvips-packaging/blob/master/THIRD-PARTY-NOTICES.md));
  - a JSON file containing the version numbers of libvips and its dependencies (`versions.json`).

## [8.8.4] - 2019-12-30
### Note
If you would like to see what's changed, please visit the the release notes of libvips:
https://github.com/libvips/libvips/releases/tag/v8.8.4

## [8.8.3] - 2019-10-14
### Note
If you would like to see what's changed, please visit the the release notes of libvips:
https://github.com/libvips/libvips/releases/tag/v8.8.3

## [8.8.2] - 2019-09-05
### Note
If you would like to see what's changed, please visit the the release notes of libvips:
https://github.com/libvips/libvips/releases/tag/v8.8.2

## [8.8.1] - 2019-07-29
### Note
If you would like to see what's changed, please visit the the release notes of libvips:
https://github.com/libvips/libvips/releases/tag/v8.8.1

## [8.8.0] - 2019-06-22
### Note
If you would like to see what's new, please visit the the release notes of libvips:
https://libvips.github.io/libvips/2019/04/22/What's-new-in-8.8.html

## [8.7.4] - 2019-04-10
### Added
- A [NetVips.Native](https://www.nuget.org/packages/NetVips.Native/) package which depends on the other [NetVips.Native.*](https://www.nuget.org/packages?q=id%3ANetVips.Native) packages. 

### Changed
- The OS X binaries are now distributed with [`jpeg-turbo`](https://github.com/libjpeg-turbo/libjpeg-turbo) instead than [`jpeg`](https://www.ijg.org/) ([lovell/package-libvips-darwin#3](https://github.com/lovell/package-libvips-darwin/pull/3)).

## [8.7.4-beta1] - 2019-02-25
### Added
- Pre-compiled libvips binaries for a few distros ([#21](https://github.com/kleisauke/net-vips/issues/21)):
  - [NetVips.Native.linux-x64](https://www.nuget.org/packages/NetVips.Native.linux-x64) - Linux x64 glibc (Ubuntu, Debian, etc).
  - [NetVips.Native.linux-musl-x64](https://www.nuget.org/packages/NetVips.Native.linux-musl-x64) - Linux x64 musl (Alpine, Gentoo Linux, etc).
  - [NetVips.Native.osx-x64](https://www.nuget.org/packages/NetVips.Native.osx-x64) - macOS x64.
  - [NetVips.Native.win-x64](https://www.nuget.org/packages/NetVips.Native.win-x64) - Windows 64-bit.
  - [NetVips.Native.win-x86](https://www.nuget.org/packages/NetVips.Native.win-x86) - Windows 32-bit.

### Changed
- A statically linked libvips binary is build for Windows. This reduces the number of DLLs from 37 to 3 ([libvips/build-win64#21](https://github.com/libvips/build-win64/issues/21#issuecomment-458112440)).

[8.9.1]: https://github.com/kleisauke/libvips-packaging/compare/v8.9.0...v8.9.1
[8.9.0]: https://github.com/kleisauke/libvips-packaging/compare/v8.8.4...v8.9.0
[8.8.4]: https://github.com/kleisauke/libvips-packaging/compare/v8.8.3...v8.8.4
[8.8.3]: https://github.com/kleisauke/libvips-packaging/compare/v8.8.2...v8.8.3
[8.8.2]: https://github.com/kleisauke/libvips-packaging/compare/v8.8.1...v8.8.2
[8.8.1]: https://github.com/kleisauke/libvips-packaging/compare/v8.8.0...v8.8.1
[8.8.0]: https://github.com/kleisauke/libvips-packaging/compare/v8.7.4...v8.8.0
[8.7.4]: https://github.com/kleisauke/libvips-packaging/compare/v8.7.4-beta1...v8.7.4
[8.7.4-beta1]: https://github.com/kleisauke/libvips-packaging/releases/tag/v8.7.4-beta1
