using System;
using System.Collections.Generic;
using Shouldly;

namespace PolyDeploy.DeployClient.Tests;
public class TestStopwatch : IStopwatch
{
    public TimeSpan Elapsed
    {
        get
        {
            this.IsStartNewCalled.ShouldBeTrue();
            return TimeSpans[0];
        }
    }
    public List<TimeSpan> TimeSpans { get; } = new List<TimeSpan>();

    public bool IsStartNewCalled { get; private set; }

    public void StartNew()
    {
        this.IsStartNewCalled = true;
    }
}