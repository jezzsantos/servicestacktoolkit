using NuGet.VisualStudio;
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

namespace ServiceStackToolkit.Automation.Commands
{
    /// <summary>
    /// A custom command that performs some automation.
    /// </summary>
    [DisplayName(@"Add NuGet Packages")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Adds the configured NuGet packages to the referenced project.")]
    [CLSCompliant(false)]
    public class AddNuGetPackagesCommand : NuPattern.Runtime.Command
    {
        private const string DefaultRepo = @"https://packages.nuget.org/api/v2";
        private const string PackageDelimiter = ";";
        private static readonly ITracer tracer = Tracer.Get<AddNuGetPackagesCommand>();

        /// <summary>
        /// Creates a new instance of the <see ref="AddNuGetPackagesCommand"/> class.
        /// </summary>
        public AddNuGetPackagesCommand()
        {
            this.Repository = DefaultRepo;
        }
        /// <summary>
        /// Gets or sets the NuGet packages to install.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [DisplayName(@"Nuget Packages")]
        [Description("A ';' delimited list of NuGet Packages to add to the referenced project.")]
        public string Packages
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a Tag to filter the project references.
        /// </summary>
        [DisplayName(@"Filter Tag")]
        [Description("An optional tag to filter the references on the current element.")]
        public string Tag
        {
            get;
            set;
        }

        [DisplayName(@"NuGet Repo")]
        [Description("The adress of the NuGet repo.")]
        public string Repository { get; set; }

        /// <summary>
        /// Gets or sets the reference service
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IUriReferenceService ReferenceService
        {
            get;
            set;
        }

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
        /// Gets or sets Nuget services
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IVsPackageInstallerServices NuGetServices
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Nuget services
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IVsPackageInstaller NuGetInstaller
        {
            get;
            set;
        }

        /// <summary>
        /// Executes this commmand.
        /// </summary>
        /// <remarks></remarks>
        public override void Execute()
        {
            this.ValidateObject();

            tracer.Info(
                "Executing AddNuGetPackagesCommand on current element '{0}' with NuGetPackages '{1}', on repo '{2}", this.CurrentElement.InstanceName, this.Packages, this.Repository);

            var tagFilter = new Func<IReference, bool>(r => true);
            if (!string.IsNullOrEmpty(this.Tag))
            {
                tagFilter = r => r.ContainsTag(this.Tag);
            }

            // Get the referenced project
            var reference = SolutionArtifactLinkReference.GetResolvedReferences(this.CurrentElement, this.ReferenceService, tagFilter)
                .FirstOrDefault() as IProject;
            if (reference == null)
            {
                tracer.Error(
                    "The current element '{0}' does not have any project reference to add Nuget packages to", this.CurrentElement.InstanceName);
                return;
            }

            var project = reference.As<EnvDTE.Project>();

            var packageIds = this.Packages.Split(new[] { PackageDelimiter }, StringSplitOptions.RemoveEmptyEntries);
            if (packageIds.Any())
            {
                packageIds.ToList().ForEach(pId =>
                {
                    if (!this.NuGetServices.IsPackageInstalled(project, pId))
                    {
                        this.NuGetInstaller.InstallPackage("All", project, pId, (Version)null, false);
                    }
                });
            }
        }
    }
}
