[![](https://img.shields.io/nuget/v/Fable.MaterialUI.Pickers.svg)](https://www.nuget.org/packages/Fable.MaterialUI.Pickers/) [![](https://img.shields.io/travis/com/Luiz-Monad/fable-material-ui-pickers.svg)](https://travis-ci.com/Luiz-Monad/fable-material-ui-pickers)

# Fable.MaterialUI.Pickers

Fable bindings for [Material-UI-Pickers](https://material-ui-pickers.dev/)

# Installation
<p class="description">Install Fable bindings for Material-UI-Pickers</p>

## Nuget
Fable Material-UI-Pickers is available as [Nuget package](https://www.nuget.org/packages/Fable.MaterialUI.Pickers/)
```sh
dotnet add package Fable.MaterialUI.Pickers
```
or
```sh
paket add Fable.MaterialUI.Pickers
```

## NPM
You also need to install [Material-UI-Pickers](https://material-ui-pickers.dev/getting-started/installation) npm package
```sh
npm install @material-ui/pickers
```
or
```sh
yarn add @material-ui/pickers
```

# Usage
<p class="description">How to use the bindings</p>

Simply open Fable.MaterialUI.Pickers Components and Props module
```fsharp
open Fable.MaterialUI.Pickers.Components
open Fable.MaterialUI.Pickers.Props
```

## Minimal example
```fsharp
module R = Fable.Helpers.React
module Pick = Fable.MaterialUI.Pickers
open Fable.MaterialUI.Pickers.Props

let view =
    Pick.datePicker [
        // todo
    ] [ R.str "Hello world!" ]
```
# Build

## Dependencies

To build the project you need Paket and FAKE installed as dotnet global tool:
```
dotnet tool install paket -g
dotnet tool install fake-cli -g
```

Then run:
```
paket restore
fake build
```