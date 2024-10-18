using Docker.DotNet;
using LibDotFlow;

namespace DotFlow;

[DotFlowJob]
public class TestJob : Job
{
    public TestJob()
    {
        Name = "Test job 123";
        new DockerClientConfiguration();

        StartOn(opts =>
        {
            opts.GitPush(pushOpts => ValueTask.FromResult(pushOpts.Branch == "main"));
        });
    }
}
