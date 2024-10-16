# Project
In this Coffee Machine Project, your task is to implement the logic (starting from a simple class) that translates orders from customers of the coffee machine to the drink maker. Your code will use the drink maker protocol to send commands to the drink maker.

## Example of using test doubles
[Use of test doubles with NSubstitute](https://gist.github.com/franreyes/575c81082ede41208784950d1a445cac)

## Constraint
### Public interface of CoffeeMachine

```csharp
void SelectCoffee()
void SelectTea()
void SelectChocolate()
void AddOneSpoonOfSugar()
void MakeDrink()
void AddMoney(decimal amount)
```

# First iteration - Making drinks
In this iteration, your task is to implement the logic (starting from a simple class) that translates orders from customers of the coffee machine to the drink maker. Your code will use the drink maker protocol (see below) to send commands to the drink maker.

The coffee machine can serves 3 type of drinks: tea, coffee, chocolate.

## Use cases
Your product owner has delivered the stories and here they are:
- The drink maker should receive the correct instructions for my coffee / tea / chocolate order.
- I want to be able to send instructions to the drink maker to add one or two sugars.
- When my order contains sugar the drink maker should add a stick (touillette) with it.

## Drink maker protocol
The drink maker receives string commands from your code to make the drinks. It can also deliver info messages to the customer if ordered so. The instructions it receives follow this format:

    "T:1:0" (Drink maker makes 1 tea with 1 sugar and a stick)
    "H::" (Drink maker makes 1 chocolate with no sugar and therefore no stick)
    "C:2:0" (Drink maker makes 1 coffee with 2 sugars and a stick)
    "M:message-content" (Drink maker forwards any message received onto the coffee machine interface for the customer to see)


# Mutation testing

## Install dependencies and tools

`dotnet restore`

## Mutation testing

`dotnet stryker --open-report`
