﻿using System;
using Cosmos.IL2CPU.Plugs;

namespace Cosmos.Core.Plugs.System {
  [Plug(Target=typeof(OutOfMemoryException))]
  public static class OutOfMemoryExceptionImpl {
    public static void Ctor(OutOfMemoryException aThis) {
      //
    }
  }
}
