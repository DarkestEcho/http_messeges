using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageStore.Models
{
    public class Message
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
