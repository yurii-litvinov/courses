В этой и в следующей лекциях пойдёт речь о приложениях, работающих по сети (а таких нынче большинство). Начнём мы с проблем проектирования распределённых систем и их принципиальных отличий от систем, исполняемых на одном компьютере, затем рассмотрим, на какие вопросы надо ответить при проектировании распределённой системы, из каких видов сущностей и способов взаимодействия между ними она состоит. Рассмотрим типичные для таких систем архитектурные стили и способы организации взаимодействия:

- Remote Procedure Calls (RPC);
- Remote Method Invocation (RMI);
- Пример: gRPC;
- Веб-сервисы, WCF;
- Очереди сообщений, RabbotMQ, Kafka.