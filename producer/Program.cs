using RabbitMQ.Client;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var argumentos = string.Join(" ", args);
        var factory = new ConnectionFactory() { HostName = "localhost"};
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            string message = argumentos;
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "amq.direct",
                                 routingKey: "bk1",
                                 basicProperties: null,
                                 body: body);

            Console.WriteLine(" [x] Enviada mensagem: {0}", message);
        }

    }
}
