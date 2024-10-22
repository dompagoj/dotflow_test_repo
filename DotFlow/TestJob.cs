using Docker.DotNet;
using LibDotFlow;

namespace DotFlow;

[DotFlowJob]
public class TestJob : Job
{
    public TestJob()
    {
        Name = "Test job 123";

        StartOn(opts =>
        {
            opts.GitPush(pushOpts => ValueTask.FromResult(pushOpts.Branch == "main"));
        });

        Step("test step one two three", s =>
        {
            s.Host(h =>
            {
                h.Shell("echo 123");
            });
        });
    }
}
