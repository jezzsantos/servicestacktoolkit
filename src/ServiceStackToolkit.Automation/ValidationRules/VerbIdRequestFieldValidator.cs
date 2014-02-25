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
    /// A custom element validation rule that verifies instances of elements.
    /// </summary>
    [DisplayName(@"Resource Verb Has ID RequestField")]
    [Category("ServiceStack Toolkit")]
    [Description(@"Validates that the Verb (if GET, PUT, DELETE) has an Id request field.")]
    [CLSCompliant(false)]
    public class VerbIdRequestFieldValidator : ValidationRule
    {
        private const string IdFieldName = @"Id";
        private static readonly ITracer tracer = Tracer.Get<VerbIdRequestFieldValidator>();

        /// <summary>
        /// Gets or sets the current element to validate.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IProductElement CurrentElement
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
                "Validating VerbIdRequestFieldValidator on current element '{0}'", this.CurrentElement.InstanceName);

            var verb = this.CurrentElement.As<IVerb>();
            var hasIdRequestField = (verb.RequestContract != null)
                && verb.RequestContract.RequestFields.Any(rf => rf.InstanceName.Equals(IdFieldName, StringComparison.InvariantCulture)
                    && rf.DataType.Equals(typeof(string).FullName, StringComparison.OrdinalIgnoreCase));

            if (((verb.VerbType.Equals("GET") && !verb.HasMany)
                || (verb.VerbType.Equals("PUT")
                || verb.VerbType.Equals("DELETE"))) && !hasIdRequestField)
            {
                errors.Add(new ValidationResult(
                    string.Format(CultureInfo.CurrentCulture, Resources.VerbIdRequestFieldValidator_IdRequestFieldMissing,
                        this.CurrentElement.InstanceName, IdFieldName, typeof(string).FullName)));
            }

            tracer.Info(
                "Validated VerbIdRequestFieldValidator on current element '{0}', as '{1}'", this.CurrentElement.InstanceName, !errors.Any());

            return errors;
        }
    }
}
