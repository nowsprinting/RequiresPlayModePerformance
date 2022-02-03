// Copyright (c) 2022 Koji Hasegawa.
// This software is released under the MIT License.

using NUnit.Framework;
using UnityEngine.TestTools;

namespace RequiresPlayModePerformance.Tests.Editor
{
    public class EditModeTests
    {
        [Test]
        public void DummyEditModeTest_AlwaysPassed([Range(1, 50)] int i)
        {
            Assert.That(true, Is.True);
        }

        [Test]
        [RequiresPlayMode]
        public void DummyPlayModeTestInEditor_AlwaysPassed([Range(51, 100)] int i)
        {
            Assert.That(true, Is.True);
        }
    }
}
