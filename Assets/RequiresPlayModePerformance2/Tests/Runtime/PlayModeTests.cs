// Copyright (c) 2022 Koji Hasegawa.
// This software is released under the MIT License.

using NUnit.Framework;

namespace RequiresPlayModePerformance.Tests.Runtime
{
    public class PlayModeTests
    {
        [Test]
        public void DummyPlayModeTest_AlwaysPassed([Range(1, 100)] int i)
        {
            Assert.That(true, Is.True);
        }
    }
}
