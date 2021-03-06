﻿using Xunit;
using ZPLForge.Builders;
using ZPLForge.Common;

namespace ZPLForge.Tests.Builders
{
    public class LabelBuilderTests
    {
        [Fact]
        public void LabelBuildersBuildMethodReturnsLabel()
        {
            Assert.IsType<Label>(LabelBuilder.FromWebSensingMedia(1).Build());
        }

        [Fact]
        public void LabelBuildersResetMethodResetsLabel()
        {
            var sut = LabelBuilder.FromWebSensingMedia(1)
                .AddText(new TextElement());

            sut.Reset();

            var label = sut.Build();

            Assert.Empty(label.Content);
        }

        [Fact]
        public void LabelBuildersContextCanBeAccessedByAccessor()
        {
            var sut = LabelBuilder.FromWebSensingMedia(1);
            var accessor = Assert.IsAssignableFrom<IContextAccessor<Label>>(sut);
            
            Assert.NotNull(accessor.Context);
            Assert.IsType<Label>(accessor.Context);
        }
    }
}
