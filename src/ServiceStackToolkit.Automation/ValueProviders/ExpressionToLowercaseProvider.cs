using System;
using System.ComponentModel;

namespace ServiceStackToolkit.Automation.ValueProviders
{
    /// <summary>
    /// A custom value provider that provides a value to other automation classes.
    /// </summary>
    [DisplayName(@"Convert Expression to Lowercase")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Converts the expression to lowercase.")]
    [CLSCompliant(false)]
    public class ExpressionToLowercaseProvider : ExpressionConverterProvider
    {
        /// <summary>
        /// Converts the evaluated expression value
        /// </summary>
        public override string ConvertExpressedValue(string value)
        {
            return value.ToLowerInvariant();
        }
    }
}
