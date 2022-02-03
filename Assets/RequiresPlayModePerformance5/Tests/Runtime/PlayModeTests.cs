// Copyright (c) 2022 Koji Hasegawa.
// This software is released under the MIT License.

using NUnit.Framework;
using UnityEngine.TestTools;

namespace RequiresPlayModePerformance.Tests.Runtime
{
    public class PlayModeTests
    {
        [Test]
        public void DummyPlayModeTest_AlwaysPassed([Range(1, 50)] int i)
        {
            Assert.That(true, Is.True);
        }

        [Test]
        [RequiresPlayMode(false)]
        public void DummyEditModeTestInPlayer_AlwaysPassed([Range(51, 100)] int i)
        {
            Assert.That(true, Is.True);
        }
    }
}
