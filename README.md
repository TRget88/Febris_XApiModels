This is the first part of the Febris OSS release. It is safe to call this version 4 of the Febris platform. 
Many aspects of Version 3 had to be stripped out (The central hub, marketplace, developer system, accreditation system, micro-credentialing,
CRM, LMS components that added centralized truth, and there may be a few parts that are now gone that previously existed that I cannot recall right this second)
and I used Claude to create and cut that seam. If there are lingering parts, 
I apologize and I will fix it as soon as I can. I feel like I stretched Claude's capabilities while working on this project. 
AI was not used on any of the other version of Febris so some of these cuts may seem a little ragged but the entire system was built by one person so, 
please cut me a little slack. 

Claude is far better at documenting code than I have ever been and I suspect between my naming conventions and Claude's documentation,
this release will be easy to follow. 


# Febris.XApi.Models

**The xAPI (Experience API) object model as plain C# types. `netstandard2.0`, one dependency, no
persistence, no HTTP client, no opinions about how you store or send anything.**

If you are building against xAPI in .NET and you want the shapes without a framework attached, this
is that. It is the contract the rest of the Febris platform compiles against, published separately
so consumers on very different runtimes can share one definition of a Statement.

```bash
dotnet add package Febris.XApi.Models
```

---

## What is in here

Sixteen model types and eighteen interfaces.

**Models** -- `Statement`, `Actor`, `Verb`, `Object`, `Result`, `Context`, `ContextActivities`,
`Definition`, `Attachments`, `Authority`, `Account`, `Extensions`, `Member`, `Score`,
`StatementReference`, `Version`.

**Interfaces** -- one per model, plus two that are not part of the xAPI specification. See
[Two interfaces that are not xAPI](#two-interfaces-that-are-not-xapi) before you use them.

That is the whole surface. There is no builder, no validator, no `HttpClient`, no LRS client, and no
serializer preference. The types carry `[Key]`, `[Required]` and `[Display]` from
`System.ComponentModel.Annotations`, which is the single package dependency.

---

## Why it targets `netstandard2.0`

Because the tiers that consume it do not agree on a runtime, and the contract has to be the thing
they agree on:

| Consumer | Runtime |
|---|---|
| Node (LMS server) | .NET 8 |
| PC client suite | .NET 8 Windows |
| Mobile suite | Xamarin / `netstandard2.1` |
| Simulation SDK | `netstandard2.0` |

A statement written by a simulation on one runtime is read by a server on another. If the model
lived in the server's assembly, every other tier would inherit the server's dependencies to speak
about a Statement. It does not, so they do not.

The heavy EF Core / Npgsql model library depends on **this** package, never the other way round.
That direction is the whole design, and it is why this package carries no data-access weight.

---

## Namespace does not match the package name

Deliberate, and worth knowing before your first `using`:

```csharp
using Febris.ModelLibrary.Models.XApiModels;              // the 16 models
using Febris.ModelLibrary.Interfaces.XApiModelInterfaces; // the 18 interfaces
```

The assembly and package are `Febris.XApi.Models`. The namespaces were left as they were when these
types were extracted, so that existing consumers kept their fully-qualified names across the split.
Assembly name and namespace are allowed to differ, and renaming the namespaces would have been a
breaking change for every tier at once for no functional gain.

---

## Two interfaces that are not xAPI

`ILocalStatement` and `IXApiResultExtras` are **not** part of the xAPI specification. They describe
how the Febris node persists a statement locally: surrogate keys, foreign-key ids, a stored
timestamp.

The two are not in the same state, and it is worth being exact about which is which.

- `IXApiResultExtras` is implemented by `XApiResultExtras` in the node's own model library, not here.
- `ILocalStatement` has **no implementation anywhere**, in this package or in the node. A
  `LocalStatement` class exists in the node's model library with a matching shape, but it does not
  declare the interface. It ships here as a contract for anyone persisting statements the way the
  node does, not as a description of code that runs today.

**If you are consuming this package to speak xAPI, you do not want either of them.** They are
shipped, documented, and inert for that use.

---

## Versioning

Pre-1.0. The public surface may change between minor versions while the platform's own tiers are
still converging on it. Once it stabilises this package will follow semantic versioning, and the
`1.0.0` release is the point at which the surface is committed to.

## Licence

Apache-2.0. See [LICENSE](LICENSE) and [NOTICE](NOTICE).

Apache-2.0 was chosen deliberately for this package while the rest of the platform is AGPL-3.0. A
shared data contract that other people can only use under a copyleft licence is not a shared data
contract. Depending on this package puts no licensing obligation on your code.

## Security

Report vulnerabilities privately through this repository's Security tab. See
[SECURITY.md](SECURITY.md). Please do not open a public issue for a security bug.

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md). Bug reports and spec-conformance corrections are welcome.
Because every Febris tier compiles against these types, additions to the public surface get more
scrutiny than they would in a leaf library.
