[Argent Rose Requirements Specification](https://gist.github.com/trikitrok/5b235041aa1f42f0ed8c0f86baa34c68)

No mutants

## Install dependencies and tools

`dotnet restore`

## Coverage

`dotnet msbuild -target:Coverlet`

## Mutation testing

`dotnet stryker --open-report`
