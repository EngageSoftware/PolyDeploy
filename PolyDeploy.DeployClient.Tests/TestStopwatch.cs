using System;
using System.Collections.Generic;
using Shouldly;

namespace PolyDeploy.DeployClient.Tests;
public class TestStopwatch : IStopwatch
{
    public TestStopwatch(params TimeSpan[] timeSpans)
    {
        this.TimeSpans = timeSpans;
    }

    public TimeSpan Elapsed
    {
        get
        {
            this.IsStartNewCalled.ShouldBeTrue();
            return TimeSpans[0];
        }
    }
    public IReadOnlyList<TimeSpan> TimeSpans { get; }

    public bool IsStartNewCalled { get; private set; }

    public void StartNew()
    {
        this.IsStartNewCalled = true;
    }
}