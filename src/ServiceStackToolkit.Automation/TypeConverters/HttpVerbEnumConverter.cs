using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ServiceStackToolkit.Automation.TypeConverters
{
    /// <summary>
    /// A custom type converter for returning a list of System.String values.
    /// </summary>
    [DisplayName(@"HttpVerb Enum Converter")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Returns a list of HTTP verbs.")]
    [CLSCompliant(false)]
    public class HttpVerbEnumConverter : StringConverter
    {
        /// <summary>
        /// Determines whether this converter supports standard values.
        /// </summary>
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Determines whether this converter only allows selection of items returned by <see cref="GetStandardValues"/>.
        /// </summary>
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Returns the list of string values for the enumeration
        /// </summary>
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new List<string>
            {
                "GET",
                "POST",
                "PUT",
                "DELETE",
            });
        }
    }
}
