﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    [ServiceContract]
    public interface ISayHiService
    {
        [OperationContract]
        string SayHi(string name);
    }
}
