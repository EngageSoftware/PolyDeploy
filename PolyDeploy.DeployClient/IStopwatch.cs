
namespace PolyDeploy.DeployClient
{
    using System;

    public interface IStopwatch
    {
        void Start();

        TimeSpan Elapsed { get; }

    }
}