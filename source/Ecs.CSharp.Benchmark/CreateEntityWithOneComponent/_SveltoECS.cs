﻿using System;
using BenchmarkDotNet.Attributes;
using Svelto.ECS;
using Svelto.ECS.Schedulers;

namespace Ecs.CSharp.Benchmark
{
    public partial class CreateEntityWithOneComponent
    {
        private class SveltoECSContext : IDisposable
        {
#pragma warning disable CS0649
            public struct Component : IEntityComponent
            {
                public int Value;
            }

            public sealed class Entity : GenericEntityDescriptor<Component>
            { }

            public static ExclusiveGroup Group { get; } = new();

            public SimpleEntitiesSubmissionScheduler Scheduler { get; }
            public EnginesRoot Root { get; }
            public IEntityFactory Factory { get; }

            public SveltoECSContext()
            {
                Scheduler = new SimpleEntitiesSubmissionScheduler();
                Root = new EnginesRoot(Scheduler);
                Factory = Root.GenerateEntityFactory();
            }

            public void Dispose()
            {
                Root.Dispose();
                Scheduler.Dispose();
            }
        }

        private SveltoECSContext _sveltoECS;

        [Benchmark]
        public void SveltoECS()
        {
            for (int i = 0; i < EntityCount; ++i)
            {
                _sveltoECS.Factory.BuildEntity<SveltoECSContext.Entity>((uint)i, SveltoECSContext.Group);
            }

            _sveltoECS.Scheduler.SubmitEntities();
        }
    }
}
