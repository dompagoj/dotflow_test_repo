using DotFlowCI;

namespace Dotflow;

[DotFlowJob]
public class TestJob : Job
{
    public TestJob()
    {
        Name = "Test job";

        StartOn(opts =>
        {
            opts.GitPush(pushOpts => ValueTask.FromResult(pushOpts.Branch == "main"));
        });
    }
}
