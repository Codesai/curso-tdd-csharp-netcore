# Tire Pressure Monitoring System Variation

[Requirements](https://gist.github.com/trikitrok/e0dccffff284511e736a53a59d853e31)

### Constraints.

Aside from its constructor this is the only public method of the `Alarm` class:

`void Check()`

`Alarm` cannot have any accessor methods to see its state, and all its fields must be private.

### Tools

[Use of test doubles with NSubstitute](https://gist.github.com/franreyes/575c81082ede41208784950d1a445cac)

##### Install dependencies and tools

`dotnet restore`

#### Run this command to execute coverage:

`dotnet msbuild -target:Coverlet`


##### Mutation testing

`dotnet stryker --open-report`
