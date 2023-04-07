﻿// Decompiled with JetBrains decompiler
// Type: DistantWorlds.Types.RaceSummary
// Assembly: DistantWorlds.Types, Version=1.9.5.12, Culture=neutral, PublicKeyToken=null
// MVID: C87DBA0E-BD3A-46BA-A8F0-EE9F5E5721E2
// Assembly location: H:\7\DistantWorlds.Types.dll

using System;
using System.Collections.Generic;

namespace DistantWorlds.Types
{
  [Serializable]
  public class RaceSummary
  {
    public Race Race;
    public List<RaceSummarySection> Sections = new List<RaceSummarySection>();

    public RaceSummary(Race race) => this.Race = race;
  }
}
