using System;

namespace E_Ticaret.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //asdasd
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
