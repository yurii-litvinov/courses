# Лекция 12: Проектирование распределённых приложений, часть первая: технические вопросы

В этой и в следующей лекциях пойдёт речь о приложениях, работающих по сети (а таких нынче большинство). Начнём мы с проблем проектирования распределённых систем и их принципиальных отличий от систем, исполняемых на одном компьютере, затем рассмотрим, на какие вопросы надо ответить при проектировании распределённой системы, из каких видов сущностей и способов взаимодействия между ними она состоит. Начнём мы с технических вопросов организации взаимодействия частей приложения и конкретных примеров технологий, которые это взаимодействие реализуют:

- Remote Procedure Calls (RPC), Remote Method Invocation (RMI);
- пример конкретной технологии: protobuf/gRPC.
- веб-сервисы:
  - SOAP-ориентированные сервисы и фреймворк WCF как пример;
  - REST-сервисы и ASP.NET Web APIs как пример;
- очереди сообщений и два примера: RabbitMQ и Apache Kafka.

---

- Слайды: https://github.com/yurii-litvinov/courses/blob/master/software-design-extended/12-distributed-applications-technologies/12-distributed-applications-technologies-slides.pdf
- Текст: https://github.com/yurii-litvinov/courses/blob/master/software-design-extended/12-distributed-applications-technologies/12-distributed-applications-technologies-text.pdf