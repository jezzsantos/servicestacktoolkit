﻿using System;
using System.ComponentModel;

namespace ServiceStackToolkit.Automation.ValueProviders
{
    /// <summary>
    /// A custom value provider that provides a value to other automation classes.
    /// </summary>
    [DisplayName(@"Convert Expression to Plural Form")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Converts the expression to title case form.")]
    [CLSCompliant(false)]
    public class ExpressionToTitleCaseProvider : ExpressionConverterProvider
    {
        /// <summary>
        /// Converts the evaluated expression value
        /// </summary>
        public override string ConvertExpressedValue(string value)
        {
            return TextFormatting.Pluralize(value);
        }
    }
}
