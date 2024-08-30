Este é um pequeno projeto usado para explicar conceitos introdutórios sobre RabbitMQ

Você deverá subir a imagem que está no docker-compose.yml usando:

```
docker-compose up
```

Dentro do RabbitMQ Management faça os passos 1 e 2:

1. Crie a fila "q1"

2. Faça o bind entre o exchange pré-criado "amq.direct" e a fila "q1" recém criada, configurando a routing key "bk1"

Em seguinda execute o consumer na pasta:
```
dotnet run
```

E o producer na pasta usando argumentos:
```
dotnet run -- mensagem
```

A mensagem produzida no producer deverá aparecer no consumer.