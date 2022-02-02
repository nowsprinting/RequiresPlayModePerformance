// Copyright (c) 2022 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

public class RunTestsPerformance : ICallbacks
{
    private static int s_enterPlayModeCount;
    private DateTime _runStartedTime;

    [InitializeOnLoadMethod]
    private static void SetupCallbacks()
    {
        var api = ScriptableObject.CreateInstance<TestRunnerApi>();
        api.RegisterCallbacks(new RunTestsPerformance());
    }

    [InitializeOnEnterPlayMode]
    private static void OnEnterPlayMode()
    {
        s_enterPlayModeCount++;
        Debug.Log(nameof(OnEnterPlayMode)); // RunStartedより前に呼ばれるのでカウントは無効。ログで判断
    }

    public void RunStarted(ITestAdaptor testsToRun)
    {
        s_enterPlayModeCount = 0;
        _runStartedTime = DateTime.Now;
        Debug.Log(nameof(RunStarted));
    }

    public void RunFinished(ITestResultAdaptor result)
    {
        var time = DateTime.Now.Subtract(_runStartedTime);
        Debug.Log($"RunFinished. Time={time.TotalMilliseconds}[ms], OnEnterPlayMode={s_enterPlayModeCount}");
    }

    public void TestStarted(ITestAdaptor test)
    {
        // nop
    }

    public void TestFinished(ITestResultAdaptor result)
    {
        // nop
    }
}
