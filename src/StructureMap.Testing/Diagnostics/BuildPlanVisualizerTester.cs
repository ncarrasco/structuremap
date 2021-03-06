﻿using Shouldly;
using StructureMap.Diagnostics;
using Xunit;

namespace StructureMap.Testing.Diagnostics
{
    public class BuildPlanVisualizerTester
    {
        [Fact]
        public void create_deep()
        {
            new BuildPlanVisualizer(PipelineGraph.BuildEmpty(), true)
                .MaxLevels.ShouldBe(int.MaxValue);
        }

        [Fact]
        public void create_default_is_0_levels()
        {
            new BuildPlanVisualizer(PipelineGraph.BuildEmpty())
                .MaxLevels.ShouldBe(0);
        }

        [Fact]
        public void create_with_explicit_levels()
        {
            new BuildPlanVisualizer(PipelineGraph.BuildEmpty(), levels: 2)
                .MaxLevels.ShouldBe(2);
        }
    }
}