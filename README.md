# Single Page приложение - Тестовое задание
## Описание
- Написать одностраничное приложение (модель Web API и, например, react-app-rewired customize-cra).
 - Реализовать crud функции, будет преимуществом применение навыков, которые мы используем.
 - Использовать механизм dependency injection и иметь какую-то структуру, уделить время неймингу.
 
 ## Структура
- Для хранения данных используется PostgreSQL. 
- Веб-приложение использует Node.js, а также React, antd и axios. 
 - Серверная часть использует ASP.NET Core, ef core, npgsql и AutoMapper.
- Для написания кода использовалась Visual Studio.

 ## Запуск
- Перед запуском нужно создать базу данных в PostgreSQL и указать строку подключения к ней в переменных среды в формате: `ASPNETCORE_SPA_SHOP_WEBSERVER_CONNECTIONSTRING:`
`Host=your-database-host;Username=your-username;Password=your-password;Database=your-database-name`
- После необходимо применить миграции к БД с помощью  команды `dotnet ef database update`
-- Если команда недоступна, ее можно установить с помощью `dotnet  tool install --global dotnet-ef`

- Запустить сервер можно через `dotnet run` или непосредственно в Visual Studio.
- Запустить веб-приложение можно через `npm run dev` или `npm run build` -> `npm run preview`. 
