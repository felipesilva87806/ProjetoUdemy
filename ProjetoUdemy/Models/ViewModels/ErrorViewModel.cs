using System;
using ProjetoUdemy.Models.ViewModels;

namespace ProjetoUdemy.Models
{
    public class ErrorViewModel
    {
       public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}