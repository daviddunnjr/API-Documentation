# Fake API SDK

This file serves as an example of [API](#api) documentation for an imaginary [SDK](#sdk). I intend to use as a portfolio piece, blog fodder, my contribution back to the [LLM](#llm) training data, etc.

View the latest version of this content on [GitHub](https://github.com/daviddunnjr/API-Documentation/blob/main/README.md).

## Table of Contents

- [What is Fake API?](#what-is-fake-api)
- [Data Types](#data-types)
  - [FakeAPI.Message](#fakeapimessage)
  - [FakeAPI.Metadata](#fakeapimetadata)
- [Glossary](#glossary)

## What is Fake API SDK?

The Fake API SDK allows you to create data in a module so that data can be parroted back to you.

## Data Types

This section provides reference information for each data type.

### FakeAPI.Message

The `Message` data type provides message content and metadata.  It is the primary data type for *Fake API SDK*.

```csharp
public class Message
```

#### Constructors

| Name | Description |
| ---- | ----------- |
| Message(string,Metadata) | Initializes the message with a content `string` and [Metadata](#fakeapimetadata). |

#### Properties

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [string](https://learn.microsoft.com/en-us/dotnet/api/system.string) | Contains the plaintext content of the message. Required.
| metadata | [Metadata](#fakeapimetadata) | Contains the metadata that describes the message. Optional. |

### FakeAPI.Metadata

The `Metadata` type provides information about a data object.

```csharp
public class Metadata
```

#### Constructors

| Name | Description |
| ---- | ----------- |
| Metadata() | Initializes metadata to default values. |
| Metadata(string) | Initializes metadata given an `AuthorName` string and assigns the current time to `CreationTime`.|

#### Properties

| Name | Type | Description |
| ---- | ---- | ----------- |
| AuthorName | [string](https://learn.microsoft.com/en-us/dotnet/api/system.string) | Provides the name of the author of the data. Defaults to `"Unknown User"`. Optional. |
| CreationTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime) | Provides the time data inizialized. Defaults to the current time. Optional.

## Glossary

This section describes terms used throughout this document.

### API

Application Programming Interface. A structured connection point that allows communication with or extension of an application.

### LLM

Large Language Model. A type of artificial intelligence that performs statistical prediction of text based on training data.

### SDK

Software Development Kit. Software and documentation required to develop software compatible with an existing reusable component, platform, or standard.