# CSharp-Concepts Repository

This repository provides in-depth examples and explanations of advanced C# concepts. Each folder contains code examples and documentation to help understand different C# features and design patterns. Below is an overview of each concept covered in the repository.

## Table of Contents
1. [Mutable Data Class](#mutable-data-class)
2. [Primary Unnamed Constructor Initializer](#primary-unnamed-constructor-initializer)
3. [Singleton Classes](#singleton-classes)
4. [ThrowArgumentNullExceptionAttribute](#throwargumentnullexceptionattribute)
5. [Immutable Record Class](#immutable-record-class)

## Mutable Data Class

This section explores the concept of mutable data classes in C#. It demonstrates how to define classes with properties that can be changed after object creation. The provided examples compare a conceptual approach using a hypothetical `data` keyword with the current implementation in C#.

### Key Features
- Mutable Properties
- Data-Oriented Design

For more details, refer to the [readme](https://github.com/Mubarrat/CSharp-Concepts/tree/main/MutableDataClass).

## Primary Unnamed Constructor Initializer

This section delves into a hypothetical feature in C# called the Primary Unnamed Constructor Initializer, which could streamline object initialization. Although this feature is not part of current C#, the repository provides examples and discusses how similar behavior can be achieved with existing syntax.

### Key Features
- Concise Initialization Syntax
- Improved Readability

For more details, refer to the [readme](https://github.com/Mubarrat/CSharp-Concepts/tree/main/PrimaryUnnamedConstructorInitializer).

## Singleton Classes

This folder covers the Singleton design pattern, which ensures a class has only one instance and provides a global access point to it. It includes both conceptual and practical implementations, demonstrating the use of lazy initialization to achieve thread safety.

### Key Features
- Private Constructor
- Lazy Initialization

For more details, refer to the [readme](https://github.com/Mubarrat/CSharp-Concepts/tree/main/SingletonClasses).

## ThrowArgumentNullExceptionAttribute

This section examines the `ThrowArgumentNullExceptionAttribute`, a custom attribute used to automatically throw an `ArgumentNullException` if a method's argument is null. This attribute can simplify null-checking code and improve readability.

### Key Features
- Automatic ArgumentNullException
- Simplified Null-Checking

For more details, refer to the [readme](https://github.com/Mubarrat/CSharp-Concepts/tree/main/ThrowArgumentNullExceptionAttribute).

## Immutable Record Class

This section explores the concept of immutable record classes in C#. Record classes are a feature introduced in C# 9.0 that provide a concise way to define immutable data objects. This section highlights how to use record classes to create immutable objects with value-based equality.

### Key Features
- Immutable Properties
- Value-Based Equality
- Concise Syntax

For more details, refer to the [readme](https://github.com/Mubarrat/CSharp-Concepts/tree/main/ImmutableRecordClass).
