using NuPattern.ComponentModel.Design;
using NuPattern.Runtime.Design;
using System;
using System.ComponentModel;

namespace ServiceStackToolkit.Automation.TypeEditors
{
    /// <summary>
    /// A custom UI editor for displaying types in the current solution filtered to specific base classes or interfaces.
    /// </summary>
    /// <remarks>Change the value of the <see cref="EditorBaseTypeAttribute"/>to apply a filter on the displayed types in the solution.</remarks>
    [DisplayName("Any DataType Picker")]
    [Category("ServiceStack Toolkit")]
    [Description("Edits the value with a type picker filtered for types found in the solution.")]
    [CLSCompliant(false)]
    [EditorBaseType(typeof(object))]
    public class AnyDataTypePicker : TypePicker
    {
    }
}