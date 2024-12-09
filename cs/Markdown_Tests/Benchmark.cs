﻿using System.Diagnostics;

namespace Markdown_Tests;

internal class Benchmark
{
    public long MeasureMilliseconds(
        Action f,
        int repetitionsCount)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        f.Invoke();

        var stopWatch = new Stopwatch();
        stopWatch.Start();

        for (var i = 0; i < repetitionsCount; i++)
        {
            f.Invoke();
        }

        stopWatch.Stop();

        return stopWatch.ElapsedMilliseconds;
    }
}
