[Argent Rose Requirements Specification](https://gist.github.com/trikitrok/5443ec70424d567be8e7612fe71e014f)

No mutants

## Install dependencies and tools

`dotnet restore`

## Run this command to execute coverage:

`dotnet msbuild -target:Coverlet`

## Mutation testing

`dotnet stryker --open-report`
