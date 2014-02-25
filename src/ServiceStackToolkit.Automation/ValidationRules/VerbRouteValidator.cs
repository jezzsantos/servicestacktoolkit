using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime;
using NuPattern.Runtime.Validation;
using ServiceStackToolkit.Automation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ServiceStackToolkit.Automation.ValidationRules
{
    /// <summary>
    /// A custom property validation rule that verifies attributes of a property.
    /// </summary>
    [DisplayName(@"Verb Route is Valid")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Validates that the Route is valid.")]
    [CLSCompliant(false)]
    public class VerbRouteValidator : ValidationRule
    {
        internal static readonly char[] RouteRegExFieldDelimiters = new[] { '}', '{' };
        internal const string RouteRegExFieldName = "field";
        internal const string RouteRegExResourceName = "resource";
        internal const string RouteRegEx = @"^([\/]{1}((?<" + RouteRegExResourceName + @">[\w]{1,})|(?<"
            + RouteRegExFieldName + @">\{{1}[\w]{1,}\}{1}))){1,}$";
        private static readonly ITracer tracer = Tracer.Get<VerbRouteValidator>();

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
                "Validating VerbRouteValidator on property '{0}' of element '{1}'", this.CurrentProperty.DefinitionName, this.CurrentProperty.Owner.InstanceName);

            var value = this.CurrentProperty.Value.ToString();

            if (!Regex.IsMatch(value, RouteRegEx, RegexOptions.IgnoreCase))
            {
                errors.Add(new ValidationResult(
                    string.Format(CultureInfo.CurrentCulture, Resources.VerbRouteValidator_InvalidFormat,
                    this.CurrentProperty.DefinitionName, this.CurrentProperty.Owner.InstanceName, value)));
            }

            tracer.Info(
                "Validated VerbRouteValidator on property '{0}' of element '{1}', as '{2}'", this.CurrentProperty.DefinitionName, this.CurrentProperty.Owner.InstanceName, !errors.Any());

            return errors;
        }
    }
}
