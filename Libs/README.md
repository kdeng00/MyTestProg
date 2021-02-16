# Submodules

Folders in this directory represent a snapshot of a GitHub repo. This method enables one
to link dependencies to their project in a generic way. These days most modern
languages have some way of distributing modules or components. C# has nuget.
Rust has cargo. Python has pip. And it goes on.

Adding modules is easy

```BASH
git submoudle add https://github.com/username/repo.git
```

That command links a dependency to your repo. 

It's not official until it's added

```BASH
git add repo
```

