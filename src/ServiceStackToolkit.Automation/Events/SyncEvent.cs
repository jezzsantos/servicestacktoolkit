using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime.Events;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;

namespace ServiceStackToolkit.Automation.Events
{
    /// <summary>
    /// The OnSyncEvent event.
    /// </summary>
    public interface IOnSyncEvent : IObservable<IEvent<EventArgs>>, IObservableEvent
    {
    }

    /// <summary>
    /// The SyncEvent event, that republishes the event for listening automation.
    /// </summary>
    [DisplayName(@"OnSyncEvent Custom Event")]
    [Category("ServiceStack Toolkit")]
    [Description(@"Raises the OnSyncEvent custom event.")]
    [Event(typeof(IOnSyncEvent))]
    [Export(typeof(IOnSyncEvent))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class OnSyncEvent : IOnSyncEvent
    {
        private static readonly ITracer tracer = Tracer.Get<OnSyncEvent>();
        private static IObservable<IEvent<EventArgs>> sourceEvent;

        /// <summary>
        /// Initializes a new instance of the <see cref="OnSyncEvent"/> class.
        /// </summary>
        static OnSyncEvent()
        {
            if (sourceEvent == null)
            {
                sourceEvent = WeakObservable.FromEvent<EventArgs>(
                    handler => SyncEvent += handler,
                    handler => SyncEvent -= handler);
            }
        }

        /// <summary>
        /// Defines the automation event.
        /// </summary>
        public static event EventHandler<EventArgs> SyncEvent = (sender, args) => { };

        /// <summary>
        /// Subscribes the specified observer.
        /// </summary>
        public IDisposable Subscribe(IObserver<IEvent<EventArgs>> observer)
        {
            return sourceEvent.Subscribe(observer);
        }

        /// <summary>
        /// Raises the event
        /// </summary>
        public static void Raise()
        {
            SyncEvent(null, EventArgs.Empty);
        }
    }
}
