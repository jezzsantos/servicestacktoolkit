using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime;
using NuPattern.Runtime.References;
using NuPattern.VisualStudio.Solution;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ServiceStackToolkit.Automation.ValueProviders
{
    /// <summary>
    /// A custom value provider that provides a value to other automation classes.
    /// </summary>
    [DisplayName(@"Associated Project")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Gets the value of the associated project of the owning element.")]
    [CLSCompliant(false)]
    public class AssociatedProjectProvider : NuPattern.Runtime.ValueProvider
    {
        private static readonly ITracer tracer = Tracer.Get<AssociatedProjectProvider>();

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
        /// Gets or sets the current element.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IUriReferenceService UriService
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
                "Evaluating AssociatedProject on current element '{0}'", this.CurrentElement.InstanceName);

            var result = (string)null;

            // Get first artifactlink to a project
            var references = SolutionArtifactLinkReference.GetResolvedReferences(this.CurrentElement, this.UriService);
            var projectReference = references.FirstOrDefault(solutionItem => solutionItem is IProject);
            if (projectReference != null)
            {
                result = projectReference.Name;
            }

            tracer.Info(
                "Evaluated AssociatedProject on current element '{0}' as '{1}'", this.CurrentElement.InstanceName, result);

            return result;
        }
    }
}
