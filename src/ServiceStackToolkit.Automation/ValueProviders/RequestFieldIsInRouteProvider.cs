using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime;
using NuPattern.Runtime.ToolkitInterface;
using ServiceStackToolkit.Automation.ValidationRules;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace ServiceStackToolkit.Automation.ValueProviders
{
    /// <summary>
    /// A custom value provider that provides a value to other automation classes.
    /// </summary>
    [DisplayName(@"RequestField IsInRoute Provider")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Determines if this RequestField is included in the Route property of the ancestor Verb.")]
    [CLSCompliant(false)]
    public class RequestFieldIsInRouteProvider : NuPattern.Runtime.ValueProvider
    {
        private static readonly ITracer tracer = Tracer.Get<RequestFieldIsInRouteProvider>();

        /// <summary>
        /// Gets or sets the current element.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IProductElement CurrentElement
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the provided result.
        /// </summary>
        /// <remarks></remarks>
        public override object Evaluate()
        {
            this.ValidateObject();

            tracer.Info(
                "Evaluating RequestFieldIsInRouteProvider on current element '{0}'", this.CurrentElement.InstanceName);

            var result = false;

            var requestField = this.CurrentElement.As<IRequestField>();
            var verb = requestField.Parent.Parent;
            var route = verb.Route;

            var matches = Regex.Match(route, VerbRouteValidator.RouteRegEx, RegexOptions.IgnoreCase);
            if (matches.Success)
            {
                var fieldNames = matches.Groups[VerbRouteValidator.RouteRegExFieldName].Captures.Cast<Capture>();
                return fieldNames.Any(fn => fn.Value.Trim(VerbRouteValidator.RouteRegExFieldDelimiters)
                    .Equals(requestField.InstanceName, StringComparison.InvariantCulture));
            }

            tracer.Info(
                "Evaluated RequestFieldIsInRouteProvider on current element '{0}', as '{1}'", this.CurrentElement.InstanceName, result);

            return result;
        }
    }
}
