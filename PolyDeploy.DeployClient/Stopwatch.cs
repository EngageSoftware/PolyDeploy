
namespace PolyDeploy.DeployClient
{
    using System;

    public class Stopwatch : IStopwatch
    {
        public Stopwatch()
        {
            this.stopwatch = new System.Diagnostics.Stopwatch();
        }

        public void Start()
        {
            this.stopwatch.Start();
        }

        public TimeSpan Elapsed { get { return this.stopwatch.Elapsed; } }

        private System.Diagnostics.Stopwatch stopwatch;

    }
}