using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailService.Data
{
    public class MailSendModel
    {
        public string[] Email { get; set; }
        public string Content { get; set; }
    }
}
