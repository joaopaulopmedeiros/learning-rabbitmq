using System;
using System.Collections.Generic;
using System.Text;
using Domain.Core.Events;

namespace Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
