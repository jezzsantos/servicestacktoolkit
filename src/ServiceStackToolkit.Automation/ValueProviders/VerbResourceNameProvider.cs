using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime;
using NuPattern.Runtime.ToolkitInterface;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;

namespace ServiceStackToolkit.Automation.ValueProviders
{
    /// <summary>
    /// A custom value provider that provides a value to other automation classes.
    /// </summary>
    [DisplayName(@"Verb Resource Name")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Provides the resource name for this verb.")]
    [CLSCompliant(false)]
    public class VerbResourceNameProvider : NuPattern.Runtime.ValueProvider
    {
        private static readonly ITracer tracer = Tracer.Get<VerbResourceNameProvider>();

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
                "Evaluating VerbResourceNameProvider on current element '{0}'", this.CurrentElement.InstanceName);

            var verb = this.CurrentElement.As<IVerb>();

            var result = (verb.HasMany)
                ? verb.Parent.ResourceNamePlural
                : verb.Parent.ResourceNameSingular;

            tracer.Info(
                "Evaluated VerbResourceNameProvider on current element '{0}', as '{1}'", this.CurrentElement.InstanceName, result);

            return result;
        }
    }
}
