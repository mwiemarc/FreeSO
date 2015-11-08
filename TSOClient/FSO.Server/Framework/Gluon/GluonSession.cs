﻿using FSO.Server.Framework.Aries;
using Mina.Core.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Server.Framework.Gluon
{
    public class GluonSession : AriesSession, IGluonSession
    {
        public GluonSession(IoSession ioSession) : base(ioSession)
        {

        }
    }
}
