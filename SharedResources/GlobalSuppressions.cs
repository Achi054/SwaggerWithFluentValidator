// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "should not be")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = "should not be")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Not required")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Namespace", "CA1506:Collection properties should be read only", Justification = "Not required")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Readability", "RCS1191:Declare enum value as combination of names.", Justification = "Not required")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Readability", "SA1311:Static readonly fields should begin with upper-case letter.", Justification = "Not required")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S4457:Parameter validation in \"async\"/\"await\" methods should be wrapped", Justification = "Not required")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Unit test names should be defines as method_criteria_result")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("DocumentationRules", "SA1633:FileMustHaveHeader", Justification = "Private codebase, hence headers are not required.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("LayoutRules", "SA1503:BracesMustNotBeOmitted", Justification = "Single line condition statements can omit braces.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("NamingRules", "SA1309:FieldNamesMustNotBeginWithUnderscore", Justification = "Fields can contain unserscore if the field is injected.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("ReadabilityRules", "SA1101:PrefixLocalCallsWithThis", Justification = "Local property can be used within the context of the class or struct.")]