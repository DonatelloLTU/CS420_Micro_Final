using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostess.Interfaces
{
   // public class EventBusResponse<T>
    //{
        //public ulong deliveryTag;
        //public T data;
   // }
    public interface IEventBus
    {
        int PortNumber { get; set; }
        String HostName { get; set; }
        void PublishEvent<T>(String queueName, T e);
        string ConsumeEvent(String queueName);
        //EventBusResponse<T> ConsumeEvent<T>(String queueName);
        //void Acknowledge(ulong deliveryTag);
    }
}
