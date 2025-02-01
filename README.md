# Accessing Disposed Object in C# 
This repository demonstrates a common error in C# where an object is accessed after it has been disposed of using a using statement.  The example shows how to reproduce the error and how to fix it.

## Bug
The `bug.cs` file contains code that attempts to access a DbContext after it has been disposed.  This leads to an `ObjectDisposedException`. 

## Solution
The `bugSolution.cs` file provides a corrected version of the code.  The solution demonstrates proper handling of the object's lifecycle, ensuring that the object is not accessed after disposal.