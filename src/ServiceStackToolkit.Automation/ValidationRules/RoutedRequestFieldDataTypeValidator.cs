using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime;
using NuPattern.Runtime.ToolkitInterface;
using NuPattern.Runtime.Validation;
using ServiceStackToolkit.Automation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace ServiceStackToolkit.Automation.ValidationRules
{
    /// <summary>
    /// A custom property validation rule that verifies attributes of a property.
    /// </summary>
    [DisplayName(@"Routed Request Field Data Type is Valid")]
    [Category(@"ServiceStack Toolkit")]
    [Description("Validates that the request field, if in the route of the verb, is of the correct DataType.")]
    [CLSCompliant(false)]
    public class RoutedRequestFieldDataTypeValidator : ValidationRule
    {
        private static readonly ITracer tracer = Tracer.Get<RoutedRequestFieldDataTypeValidator>();

        /// <summary>
        /// Gets or sets the current property to validate.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IProperty CurrentProperty
        {
            get;
            set;
        }

        /// <summary>
        /// Evaluates the violations for the rule.
        /// </summary>
        /// <remarks></remarks>
        public override IEnumerable<ValidationResult> Validate()
        {
            var errors = new List<ValidationResult>();

            this.ValidateObject();

            tracer.Info(
                "Validating RoutedRequestFieldDataTypeValidator on property '{0}' of element '{1}'", this.CurrentProperty.DefinitionName, this.CurrentProperty.Owner.InstanceName);

            var field = this.CurrentProperty.Owner.As<IRequestField>();
            var isDataTypeInvalid = (field.IsInRoute && !field.DataType.Equals(typeof(string).FullName, StringComparison.OrdinalIgnoreCase));

            if (isDataTypeInvalid)
            {
                errors.Add(new ValidationResult(
                    string.Format(CultureInfo.CurrentCulture, Resources.RoutedRequestFieldDataTypeValidator_DataTypeInvalid,
                        this.CurrentProperty.Owner.InstanceName, typeof(string).FullName)));
            }

            tracer.Info(
                "Validated RoutedRequestFieldDataTypeValidator on property '{0}' of element '{1}', as '{2}'", this.CurrentProperty.DefinitionName, this.CurrentProperty.Owner.InstanceName, !errors.Any());

            return errors;
        }
    }
}
