﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invite
{
    //define a method to deserialize objects from a stream and capture them
    //in a IEnumerable collection
    interface IObjectReader<T>
    {
        IEnumerable<T> FetchObjects();
    }
}
