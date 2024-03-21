# Khmer Name Generator

Generate Khmer-sounding names in C# using pre-generated pools of syllables for high performance.

## Overview

This C# library provides a simple and efficient way to generate Khmer-sounding names. It pre-generates a pool of names
based on a set of Khmer syllables, allowing for quick retrieval of random names without the need for complex
computation.

## Features

- Pre-generates a pool of Khmer names for high performance.
- Generates random Khmer names on the fly.

## Usages

- Generate khmer name via `GenerateKhmerName` instance object
```csharp
using src.Generators;

// Creating an instance of GenerateKhmerName class
var khmerNameGenerator = new GenerateKhmerName();
string khmerName = khmerNameGenerator.Generate();
```
- Generate non khmer name via `GenerateKhmerName` instance object
```csharp
using src.Extensions;

// Creating an instance of GenerateKhmerName class and using the RealNameGenerator extension method
var nonKhmerName = new GenerateKhmerName().RealNameGenerator();
```
