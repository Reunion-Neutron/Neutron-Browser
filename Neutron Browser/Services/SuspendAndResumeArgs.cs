using System;

namespace Neutron_Browser.Services
{
    public class SuspendAndResumeArgs : EventArgs
    {
        public SuspensionState SuspensionState { get; set; }

        public Type Target { get; private set; }

        public SuspendAndResumeArgs(SuspensionState suspensionState, Type target)
        {
            SuspensionState = suspensionState;
            Target = target;
        }
    }
}
