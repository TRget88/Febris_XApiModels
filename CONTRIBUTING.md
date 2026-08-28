# Contributing

Thanks for looking. This is a small repository with an outsized blast radius: every Febris tier
compiles against these types, so the bar for changing the public surface is higher than the size of
the codebase suggests.

## Prerequisites

- **.NET 8 SDK.** A `global.json` pins the 8.0 feature band, so a machine with only .NET 9 or 10
  will be told so by name rather than silently building against a different toolchain.

That is the whole list. There is no database, no Docker, no platform requirement. This project is
`netstandard2.0` with a single `PackageReference`, and it builds on Linux, macOS and Windows.

## Build

```bash
dotnet restore
dotnet build -c Release
```

## There are no tests in this repository, and that is worth explaining

There is no test project here, and none was withheld. The types are data carriers with no behaviour
to assert: no methods, no invariants enforced in code, no serialization logic. A test suite over
them would assert that C# assigns properties.

What *is* worth testing lives in the consumers, where these shapes meet a serializer, a database or
a wire format, and that is where the platform's xAPI tests live.

If you contribute a change that adds behaviour rather than shape, it needs a test project, and that
is a fine thing to add in the same pull request.

## Changing the public surface

Because four independent tiers consume this package, treat the public surface as a contract:

- **Adding a property or type** is usually fine.
- **Renaming or removing anything public** is a breaking change to every tier at once. Open an issue
  first so the sequencing can be worked out.
- **Do not "fix" the namespaces.** `Febris.XApi.Models` is the assembly and package name, and
  `Febris.ModelLibrary.Models.XApiModels` is the namespace. The mismatch is deliberate and is
  explained in the README. Renaming would break every consumer's `using` for no functional gain.
- **`ILocalStatement` and `IXApiResultExtras` are not xAPI.** They describe the node's local
  persistence shape. Do not extend them with spec concepts, and do not add spec types that depend on
  them.

## Spec conformance

Corrections that bring a type closer to the
[xAPI specification](https://github.com/adlnet/xAPI-Spec) are welcome and are the most useful kind
of contribution here. Please cite the section of the spec in the pull request so the change can be
checked against it rather than against opinion.

## Pull requests

- One logical change per pull request.
- Say what a consumer would have to do differently, if anything. That is the part reviewers care
  about most.
- Keep the diff to the change. Unrelated reformatting makes a contract change hard to review.

## Reporting a security issue

Do not open a public issue. See [SECURITY.md](SECURITY.md) for the private reporting channel.

## Licence

By contributing you agree that your contributions are licensed under Apache-2.0, the same licence as
the project. See [LICENSE](LICENSE).
