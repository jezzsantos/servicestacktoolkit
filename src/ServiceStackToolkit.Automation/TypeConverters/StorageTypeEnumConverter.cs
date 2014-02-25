using NuPattern.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ServiceStackToolkit.Automation.TypeConverters
{
    /// <summary>
    /// A custom type converter for returning a list of System.String values.
    /// </summary>
    [DisplayName(@"StorageType Enum Converter")]
    [Category(@"ServiceStack Toolkit")]
    [Description("Returns the list of StorageType.")]
    [CLSCompliant(false)]
    public class StorageTypeEnumConverter : StringConverter
    {
        private static readonly ITracer tracer = Tracer.Get<StorageTypeEnumConverter>();

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
                StorageType.None.ToString(), 
                StorageType.AzureTable.ToString()
            });
        }
    }
}
