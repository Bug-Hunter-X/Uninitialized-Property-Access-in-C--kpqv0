# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  The code compiles without errors but might result in unexpected behavior.

## The Problem

The `ExampleClass` has a property `MyProperty` of type `int`.  In the `MyMethod`, we attempt to print `MyProperty` without setting its value. In C#, properties have default values (0 for integers). However, explicitly initializing the property is good practice for clarity and avoiding potential confusion.

## The Solution

The improved code initializes the property either within the class declaration or in the constructor, guaranteeing that `MyProperty` has a well-defined value before being accessed.