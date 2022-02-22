﻿using System;
using System.Collections.Generic;

namespace CSStarter.Tester.Stages
{
    internal interface IStage<in TIn, out TOut> : IStage
    {
        Type IStage.In => typeof(TIn);
        Type IStage.Out => typeof(TOut);

        IStageOutput<TOut>[] Process(TIn[] input);
    }
}
