# Binary String Analyser

This repository contains the `BinaryStringAnalyser` application, which includes functionality for validating binary strings. The application provides two implementations for checking if a binary string is "good": one using LINQ and the other using a for-loop. 

## Table of Contents

- [Introduction](#introduction)
- [Components](#components)
  - [IValidateBinaryString Interface](#ivalidatebinarystring-interface)
  - [LinqAnalyser Class](#linqanalyser-class)
  - [ForloopAnalyser Class](#forloopanalyser-class)
  - [BinaryStringEvaluator Class](#binarystringevaluator-class)

## Introduction

The `BinaryStringAnalyser` validates binary strings based on the following criteria:
- A binary string is considered "good" if it contains an equal number of `0`s and `1`s.
- The length of the binary string must be even and greater than zero.
- The string should only contain characters `0` and `1`.
 
## Components

### IValidateBinaryString Interface

The `IValidateBinaryString` interface defines the method for validating binary strings:


### ForloopAnalyser Interface

The `ForloopAnalyser` Implementation defines the method for validating binary strings using simple forloop
 
### LinqAnalyser Interface

The `LinqAnalyser` Implementation defines the method for validating binary strings using Linq Queries
 

# Binary String Analyser Tests

This repository contains unit tests for the `BinaryStringAnalyser` application, specifically focusing on the `LinqAnalyser` class. These tests evaluate the functionality of the `IsGoodBinaryString` method, which determines whether a given binary string is valid based on specific criteria.

## Table of Contents

- [Introduction](#introduction) 
- [Test Structure](#test-structure) 

## Introduction

The `LinqAnalyser` and `ForloopAnalyser` class contains tests that check various scenarios for binary string validation:

- Good binary strings
- Bad binary strings
- Binary strings with invalid characters
  
## Test Structure

The tests are organized into three main categories:

1. **GoodBinaryString**: Tests that validate the following binary strings as "good":
   - "01"
   - "0011"
   - "000111"

2. **BadBinaryString**: Tests that confirm the following binary strings are not valid:
   - ""
   - "1"
   - "0"
   - "010"
   - "011110"
   - "111111111111100000000"

3. **WrongCharactersBinaryString**: Tests that identify the following strings as containing invalid characters:
   - "1a"
   - "01b"
   - "011c"
   - "01x10"
   - "AABB"
 
