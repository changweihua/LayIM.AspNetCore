﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayIM.AspNetCore.Core
{
    internal class JsonUtil
    {
        public static string ToJSON(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }

}
