﻿using System;
using Octopus.Client.Extensibility.Attributes;

namespace Octopus.Client.Model.Triggers
{
    [Obsolete("MachineFilterResource is obsolete, please use DeploymentTargetFilterResource instead")]
    public class MachineFilterResource : TriggerFilterResource
    {
        public override TriggerFilterType FilterType => TriggerFilterType.MachineFilter;

        [Writeable]
        public ReferenceCollection EnvironmentIds { get; set; } = new ReferenceCollection();
        [Writeable]
        public ReferenceCollection Roles { get; set; } = new ReferenceCollection();
        [Writeable]
        public ReferenceCollection EventGroups { get; set; } = new ReferenceCollection();
        [Writeable]
        public ReferenceCollection EventCategories { get; set; } = new ReferenceCollection();
    }
}