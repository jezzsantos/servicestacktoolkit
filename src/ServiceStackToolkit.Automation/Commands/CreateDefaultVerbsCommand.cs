using NuPattern;
using NuPattern.Diagnostics;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ServiceStackToolkit.Automation.Commands
{
    /// <summary>
    /// A custom command that performs some automation.
    /// </summary>
    [DisplayName(@"Creates Default HTTP Verbs")]
    [Category(@"ServiceStack Toolkit")]
    [Description(@"Creates a default set of HTTP verbs.")]
    [CLSCompliant(false)]
    public class CreateDefaultVerbsCommand : NuPattern.Runtime.Command
    {
        private static readonly ITracer tracer = Tracer.Get<CreateDefaultVerbsCommand>();

        /// <summary>
        /// Gets or sets the current element.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IService CurrentElement
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

            tracer.Info("Executing CreateDefaultVerbs on current element '{0}'", this.CurrentElement.InstanceName);

            var service = this.CurrentElement;

            // Create the default GET Verb
            var getVerb = service.CreateVerb("Get", "GET", "/{0}/{{Id}}");
            getVerb.CreateRequestField("Id");
            getVerb.CreateResponseField(service.ResourceNameSingular, "DataContracts.{0}");

            // Create the default GET (all) Verb
            var listVerb = service.CreateVerb("List", "GET");
            listVerb.HasMany = true;
            listVerb.CreateResponseField(service.InstanceName, "IEnumerable<DataContracts.{0}>", service.ResourceNameSingular);

            // Create the default POST Verb
            var postVerb = service.CreateVerb("Create", "POST");
            postVerb.CreateResponseField(service.ResourceNameSingular, "DataContracts.{0}");

            // Create the default PUT verb
            var putVerb = service.CreateVerb("Update", "PUT", "/{0}/{{Id}}");
            putVerb.CreateRequestField("Id");
            putVerb.CreateResponseField(service.ResourceNameSingular, "DataContracts.{0}");

            // Create the default DELETE Verb
            var deleteVerb = service.CreateVerb("Delete", "DELETE", "/{0}/{{Id}}"); ;
            deleteVerb.CreateRequestField("Id");
        }
    }

    internal static class VerbExtensions
    {
        public static IVerb CreateVerb(this IService service, string name, string httpVerb, string routeFormat = null)
        {
            return service.CreateVerb(name, verb =>
            {
                //verb.InstanceOrder = ??;
                verb.VerbType = httpVerb;
                if (!string.IsNullOrEmpty(routeFormat))
                {
                    verb.Route = string.Format(CultureInfo.CurrentCulture, routeFormat, service.ResourceName.ToLower(CultureInfo.CurrentCulture));
                }
            });
        }

        public static void CreateRequestField(this IVerb verb, string fieldName)
        {
            verb.RequestContract.CreateRequestField(fieldName);
        }

        public static void CreateResponseField(this IVerb verb, string fieldName, string dataTypeFormat = "{0}", string fieldType = null)
        {
            verb.ResponseContract.CreateResponseField(fieldName,
                field =>
                {
                    field.DataType = string.Format(CultureInfo.InvariantCulture, dataTypeFormat,
                        (!string.IsNullOrEmpty(fieldType) ? fieldType : fieldName));
                });

        }
    }
}
