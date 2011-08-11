﻿using Csla.Rules;

namespace ShortCircuitingRules.Rules
{
  public class StopIfIsNotNew : PropertyRule
  {
    public StopIfIsNotNew(Csla.Core.IPropertyInfo primaryProperty)
      : base(primaryProperty)
    { } 

    protected override void Execute(Csla.Rules.RuleContext context)
    {
      var target = (Csla.Core.ITrackStatus)context.Target;
      if (!target.IsNew)
      {
        context.AddSuccessResult(true);
      }
    }
  }
}