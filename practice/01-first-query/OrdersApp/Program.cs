using Npgsql;

// Русские буквы в терминале Windows.
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Куда подключаться: компьютер, порт, база, пользователь и пароль.
const string connectionString =
    "Host=localhost;Port=5433;Database=orders;Username=student;Password=student";

// 1. Источник данных: хранит настройки подключения и выдаёт соединения.
await using var dataSource = NpgsqlDataSource.Create(connectionString);

// 2. Соединение: открытый канал между программой и PostgreSQL.
await using var connection = await dataSource.OpenConnectionAsync();

// 3. Команда: текст SQL-запроса, привязанный к соединению.
await using var command = new NpgsqlCommand(
    """
    SELECT o.id, c.full_name, o.total
    FROM orders o
    JOIN customers c ON c.id = o.customer_id
    WHERE o.status = 'new'
    ORDER BY o.id
    """, connection);

// 4. Читатель: получает ответ базы по одной строке.
await using var reader = await command.ExecuteReaderAsync();

int count = 0;
while (await reader.ReadAsync())
{
    int id = reader.GetInt32(0);
    string fullName = reader.GetString(1);
    decimal total = reader.GetDecimal(2);

    Console.WriteLine($"Заказ {id}: {fullName}, {total} руб.");
    count++;
}

Console.WriteLine($"Новых заказов: {count}");