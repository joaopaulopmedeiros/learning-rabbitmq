using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string Type { get; protected set; }

        protected Message() 
        {
            Type = GetType().Name;
        }
    }
}
