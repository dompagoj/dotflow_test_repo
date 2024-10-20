﻿using Docker.DotNet;
using LibDotFlow;

namespace DotFlow;

[DotFlowJob]
public class TestJob : Job
{
    public TestJob()
    {
        Name = "Test job 123";
        new DockerClientConfiguration();

        Console.WriteLine("Log from console!");

        StartOn(opts =>
        {
            opts.GitPush(pushOpts => ValueTask.FromResult(pushOpts.Branch == "main"));
        });
    }
}
