using System;
using System.Collections.Generic;

namespace CsStarter.Tester.Stages
{
    internal interface IStage
    {
        Type In { get; }
        Type Out { get; }

        string GetMessage(StageMessage messageKind);
        IStageOutput[] Process(object[] input);
    }
}
