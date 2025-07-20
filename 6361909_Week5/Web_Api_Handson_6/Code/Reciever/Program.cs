using System;
using Confluent.Kafka;

namespace KafkaChatConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "172.27.92.197:9092",
                GroupId = "chat-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
            {
                consumer.Subscribe("chat-topic");

                Console.WriteLine("Waiting for messages...");

                while (true)
                {
                    var cr = consumer.Consume();
                    Console.WriteLine("Received: " + cr.Message.Value);
                }
            }
        }
    }
}
