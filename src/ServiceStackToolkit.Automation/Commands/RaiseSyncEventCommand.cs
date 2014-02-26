using NuPattern;
using NuPattern.Diagnostics;
using ServiceStackToolkit.Automation.Events;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;

namespace ServiceStackToolkit.Automation.Commands
{
    /// <summary>
    /// A custom command that performs some automation.
    /// </summary>
    [DisplayName(@"Raises the SyncEvent")]
    [Category("ServiceStack Toolkit")]
    [Description("Raises the SyncEvent event.")]
    [CLSCompliant(false)]
    public class RaiseSyncEventCommand : NuPattern.Runtime.Command
    {
        private static readonly ITracer tracer = Tracer.Get<RaiseSyncEventCommand>();

        /// <summary>
        /// Gets or sets the sync event
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IOnSyncEvent Event
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
                "Executing RaiseSyncEventCommand");

            OnSyncEvent.Raise(this);
        }
    }
}
