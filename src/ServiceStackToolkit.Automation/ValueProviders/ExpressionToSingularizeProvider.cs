using System;
using System.ComponentModel;

namespace ServiceStackToolkit.Automation.ValueProviders
{
    /// <summary>
    /// A custom value provider that provides a value to other automation classes.
    /// </summary>
    [DisplayName(@"Convert Expression to Singular Form")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Converts the expression to singular form.")]
    [CLSCompliant(false)]
    public class ExpressionToSingularizeProvider : ExpressionConverterProvider
    {
        /// <summary>
        /// Converts the evaluated expression value
        /// </summary>
        public override string ConvertExpressedValue(string value)
        {
            return TextFormatting.Singluarize(value);
        }
    }
}
