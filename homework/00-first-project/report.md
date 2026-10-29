# Отчёт по ДЗ 0. Первый проект на .NET

Замените каждый `___` выводом команды или ответом. Вывод копируйте из терминала VS Code целиком.

| | |
|---|---|
| Фамилия и имя | Солодовников Максим |
| Группа | 9/3-РПО-24/1 |
| Система на компьютере | Windows |

## 1. Установка

Вывод `dotnet --list-sdks`:

```text
PS C:\Users\\Documents\ado-net-start> dotnet --list-sdks
>> docker run hello-world
10.0.300 [C:\Program Files\dotnet\sdk]
10.0.403 [C:\Program Files\dotnet\sdk]

Hello from Docker!
This message shows that your installation appears to be working correctly.
```

Строка `Hello from Docker!` из вывода `docker run hello-world`:

```text
Hello from Docker!
This message shows that your installation appears to be working correctly.
```

## 2. HelloApp

Вывод первого запуска, до изменения `Program.cs`:

```text
Hello, World!
```

Вывод после замены программы:

```text
Привет! Меня зовут Солодовников Максим , группа 9/3-РПО-24/1.
```

## 3. База заказов и OrdersApp

Вывод `docker compose ps`:

```text
Заказ 1: shipped, 3380,00 руб.
Заказ 2: paid, 13990,00 руб.
Заказ 3: new, 3290,00 руб.
Заказ 4: cancelled, 890,00 руб.
Заказ 5: new, 5280,00 руб.
Заказ 6: shipped, 1670,00 руб.
Заказ 7: new, 2490,00 руб.
Заказ 8: paid, 5360,00 руб.
Заказ 9: shipped, 16780,00 руб.
Заказ 10: new, 1190,00 руб.
Заказ 11: paid, 2790,00 руб.
Заказ 12: cancelled, 3290,00 руб.
```

Первые три строки вывода OrdersApp:

```text
PS C:\Users\\Documents\ado-net-start> docker compose ps
NAME        IMAGE         COMMAND                  SERVICE   CREATED         STATUS         PORTS
orders-db   postgres:17   "docker-entrypoint.s…"   db        9 seconds ago   Up 9 seconds   0.0.0.0:5433->5432/tcp, [::]:5433->5432/tcp
```

Сколько заказов напечатала программа: 12

## 4. Ошибки

Какие ошибки появлялись во время установки или запуска и как вы их исправили.
Если ошибок не было, напишите «не было».

не было 
