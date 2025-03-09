using System;
using System.Collections.Generic;

namespace Entidad
{
    public partial class SendMessage
    {
        public string message { get; set; }
        public string phone { get; set; }
        public List<string> pathtofiles { get; set; }
    }

    public partial class ResponseServer
    {
        public bool Err { get; set; }
        public string Status { get; set; }
        public List<string> StatusText { get; set; }
    }

    public partial class ResponseStatus
    {
        public bool Err { get; set; }
        public string Status { get; set; }
        public string StatusText { get; set; }
    }
}