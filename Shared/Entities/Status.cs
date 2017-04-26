﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    [DataContract]
    public class Status
    {
        [DataMember]
        public Guid StatusID { get; set; }

        [DataMember]
        public string Bezeichnung { get; set; }
    }
}
