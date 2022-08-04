using System;

namespace PolyDeploy.DeployClient.Tests;
public class TestStopwatch : IStopwatch
{
    public TimeSpan Elapsed { get; set; }

    public bool IsStartNewCalled { get; private set; }

    public void StartNew()
    {
        this.IsStartNewCalled = true;
    }
}