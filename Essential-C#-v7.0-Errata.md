# Essential C# 7.0 Errata Document

## Essential C# 7.0
by Mark Michaelis
ISBN-13: 978-1-5093-0358-8
IISBN-10: 1-5093-0358-8
Copyright © 2018 Pearson Education, Inc.
First printing, May 2018

The following corrections will be made in the second printing. (To determine which printing you have, turn to page IV of your book. The last line on that page contains the printing information.)

Found by           | Chapter | Page       | Correction                                                                                                                                                        |
------------------ | ------- | ---------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------- |
Rob Mantel         | 1       | 16         | Changed 'HelloWorld.exe' to 'dotnet run'                                                                                                                          |
Rob Mantel         | 1       | 29         | Change class name from 'Comment Samples' to CommentSamples
Pieter Le Roux     | 1       | 29         | Last Line: Table 1.2 shows four different C# comment types. The program in <s>Listing 1.18</s> Listing 1.19 includes two of these.
Rob Mantel         | 1       | 30         | Change Listing1.18 reference to Listing1.19                                                                                           
Pieter Le Roux     | 1       | 38         | Change "(lowercase) to refers to" -> "(lowercase) refers to" 
Pieter Le Roux     | 1       | 39         | Change "C# 5.0 compiler" -> "C# 6.0 compiler" 
Zhou Jing          | 2       | 75         | "The result is that the number variable is available from both the true and false consequence of the if statement ~~but not~~ and even outside the if statement.. |
Pieter Le Roux     | 3       | 93         | Change "Listing 3.6" -> "Listing 3.7" 
Pieter Le Roux     | 4       | 111        | Change "The subtraction example" -> "The division and remainder examples" 
Pieter Le Roux     | 4       | 116        | Change "16 bits of a float" -> "32 bits of a float"
Pieter Le Roux     | 4       | 122        | Change "In this example, notice that the increment operator" -> "In this example, notice that the decrement operator" 
Pieter Le Roux     | 4       | 132        | Change operator in first else if in 4.22: `else if(input<9)` -> `else if(input>9)` 
Pieter Le Roux     | 4       | 140        | Change "logical operators are of higher precedence than the relational" -> "relation operators are of higher precedence than the logical" 
Kyle Amonson       | 5       | 190        | Output 5.1 corrected Hello Inigo Montoya! Your initials are I. M.
Kyle Amonson       | 5       | 200        | “and the optional second argument is…” corrected to “and the second argument is”.  The second argument is not optional in the code example.
Pieter Le Roux     | 5       | 201        | Output 5.4: ERROR:  You must specify the URL <s>to be downloaded</s> and the file name **Usage:** Downloader.exe <URL> <TargetFileName> 
Cameron Osborn     | 5       | 236        | Listing 5.26 typo on Console.WriteLine "FormateException" changed to "FormatException"                                                                            |
Kyle Amonson       | 6       | 251        | “what you learned in Chapter 4” corrected to “what you learned in Chapter 5”.  Introduced in Listing 5.06                                                         |
Cameron Osborn     | 6       | 264 && 266 | Listing 6.18 && Listing 6.19 FirstName property gets and sets _LastName backing field
Pieter Le Roux     | 6       | 271        | Last Line in second paragraph: "DO use nameof for the paramName argument passed into exceptions like Argument<s>Null</s>Exception and ArgumentNullException that take such a parameter. For more information, see Chapter 18."
Pieter Le Roux     | 6       | 290        | Change "When another Employee class is created" -> "When another instance of the Employee class is created"                                                   
Rob Mantel         | 6       | 294 && 299 | Replace reference to Copy() to CopyTo() and update Listing Name                                                                                                 
Kyle Amonson       | 7       | 327        | “Overloading a member” corrected to “Overriding a member”   
Zhou Jing          | 7       | 329        | Listing 7.13: The `Run()` method should be public, `private void Run()`.                                                                                         
Rob Mantel         | 7       | 334        | Change 'therefore no overload' to 'therefore no override'   
Pieter Le Roux     | 7       | 340        | return <s>@</s>$"FirstName: { FirstName + NewLine }" + $"LastName: { LastName + NewLine }"+ $"Address: { Address + NewLine }";
Kyle Amonson       | 9       | 390        | “DO overload” corrected to “DO override”
Kyle Amonson       | 9       | 396        | “updates the `_Hours` value” corrected to “updates the `_Degrees` value”
Kyle Amonson       | 9       | 395        | “calls `MoveTo()` to change `Hours`” corrected: “calls `MoveTo()` to change `_Degrees`”
Pieter Le Roux     | 10      | 412        | Last paragraph: "so <s>overloading</s> overriding the method" "Consider <s>overloading</s>overriding the ToString() method "
Pieter Le Roux     | 10      | 446        | Change xml comment attribute in 10.17: `<data>January 1, 2000</date>` -> `<date>January 1, 2000</date>`
Pieter Le Roux     | 10      | 418        | Output 10.2: "serialNumber1 reference equals serialNumber2 **serialNumber1 equals serialNumber2** serialNumber1 equals serialNumber3"
Pieter Le Roux     | 10      | 420        | Note: "The implementation of object.Equals(), the default implementation on all objects before <s>overloading</s>overriding, relies on ReferenceEquals() alone."
Pieter Le Roux     | 10      | 425        | Second sentence: "To correct this flaw, it is important to <s>overload</s>override the equals (==) and not equals (!=) operators as well
Pieter Le Roux     | 11      | 466        | Listing 11.1: // Leveraging C# 2.0's <s>null coelesce operator</s>null-coalescing operator
Pieter Le Roux     | 11      | 467        | Last Sentence, first paragraph: <s>null propagation operator</s>null-conditional operator
Brian Bos          | 11      | 467        | 'ArgumentNullException' is listed twice 
Brian Bos          | 11      | 472        | 'ExeptionDispatchInfo.Throw' added missing c to Exception
Brian Bos          | 11      | 473        | C does not support exception throwing as described. Removed claim
Pieter Le Roux     | 12      | 496        | "you can see that the type parameter will be used for the <s>internal Items</s>InternalItems array, the type for the parameter to the"
Pieter Le Roux     | 12      | 501        | "constructor that takes the initial values for both <s>First and Second</s>first and second and assigns them to First and Second."
Pieter Le Roux     | 12      | 504        | "// Use System.ValueTup**l**e<string,Contact> prior to C# 7.0 "
Pieter Le Roux     | 12      | 522        | "The constraints are specified between the <s>argument</s>parameter list and the method body, as shown" 
Pieter Le Roux     | 12      | 530        | "Consider the **I**PairInitializer<in T> interface in Listing 12.45." 
Pieter Le Roux     | 12      | 530        | "  `// Let’s initia`**l**`ize our pair of fruits with an` " 
Pieter Le Roux     | 12      | 532        | Listing 12.47: .class <s>private</s>public auto ansi beforefieldinit Stack'1<([<s>mscorlib</s>System.Runtime]System.IComparable)** **T> extends [<s>mscorlib</s>System.Runtime]System.Object { ... } 
Benjamin Michaelis | 12      | 533        | Listing 12.48: .class public auto ansi beforefieldinit <s>'</s>Stack'1<s>'</s><([<s>mscorlib</s>System.Runtime]System.IComparable) T> extends [<s>mscorlib</s>System.Runtime]System.Object { .field private !<s>0</s>**T**[ ] **_I**<s>i</s>tems ... }
Pieter Le Roux     | 13      | 542        | "The Fun**c**<...> delegate in Listing 13.3, for example, is declared as"
Kevin Bost         | 13      | 544        | `Predicate<int T>` should be `Predicate<in T>`
Kyle Amonson       | 13      | 550        | "In Listings 13.7 and 13.10" changed to "In Listings 13.7 and 13.11"
Pieter Le Roux     | 13      | 552        | "the compiler can <s>see</s>infer that the lambda"
Benjamin Michaelis | 14      | 578        | `public Action<float>`**?** `OnTemperatureChange { get; set; }`
Pieter Le Roux     | 14      | 589        | Output 14.2: "<s>Enter temperature: 45 Heater: On Error in the application Cooler: Off</s> Enter temperature: 45 Heater: On Cooler: Off There were exceptions thrown by OnTemperatureChange Event subscribers. (Operation is not valid due to the current state of the object.)"
Pieter Le Roux     | 16      | 636        | tabs in Output 15.9 doesn't reflect Listing 15.21. Fixed by updating source code
Pieter Le Roux     | 16      | 651        | // ERROR: Cannot implicitly convert type // 'AnonymousType<s>#3</s>#1' to 'AnonymousType<s>#2</s>#3'
Benjamin Michaelis | 16      | 658        | Reorder keywords to alphabetical order in Listing 16.1, and add missing keywords ("when")
Pieter Le Roux     | 16      | 659        | "private static void Show<s>Contextual</s>Keywords1()"
Pieter Le Roux     | 16      | 664        | Output 16.3 is missing "when"
Pieter Le Roux     | 16      | 667        | "File.GetLastWriteTime(file**Name**)"
Pieter Le Roux     | 16      | 671        | Add "when" to Output 16.6 ("when*" was missing from source code)
Pieter Le Roux     | 16      | 673        | Add "when" to Output 16.7 ("when*" was missing from source code)
Pieter Le Roux     | 16      | 675        | "a,c,t,a,d,d,*,a,,<s> </s>,l,i,a, .... " (removing space)
Pieter Le Roux     | 16      | 677        | in Listing 16.16 and Listing 16.17, add "!" prior to "word. Contains('*')" to match Listing 16.01
Pieter Le Roux     | 17      | 685        | Saw List[6] could throw error. Changed to "{ List[<s>6</s>list.Count - 1] }
Pieter Le Roux     | 17      | 712        | "as you did in both CSharp<s>PrimitiveTypes</s>BuiltInTypes"
Pieter Le Roux     | 18      | 728        | errorMessage listed twice in listing 18.3
Pieter Le Roux     | 18      | 762        | two times in same bullet "<s>person</s>data.nonExistentMethodCallStillCompiles()" in accordance to listing 18.29
Pieter Le Roux     | 18      | 765        | "let's reexamine Listing <s>18.31</s>18.30. Notice the call to retrieve the "FirstName" element:"
Pieter Le Roux     | 19      | 791        | "The worker thread will write <s>periods</s>plus signs to the console
Pieter Le Roux     | 19      | 792        |  lambda expression prints out <s>dashes</s>hyphens to the console repeatedly.
Pieter Le Roux     | 19      | 807        | "<s>(c)</s>(3)"
