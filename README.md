# Todo

### Задачи
Сайт должен решать такие задачи как: 
1. Создание списка задач: Пользователь может добавлять задачи, которые ему нужно выполнить. 
2. Управление приоритетами: Пользователь может устанавливать приоритеты для задач, чтобы определить, какие задачи важнее выполнить. 
3. Установка сроков: Пользователь может назначать сроки выполнения задач, чтобы следить за своими обязательствами и сроками. 
4. Отметка выполненных задач: После выполнения задачи пользователь может отметить ее как выполненную. 
5. Фильтрация и сортировка задач: Пользователь может фильтровать и сортировать задачи по различным критериям, например, по приоритету или сроку выполнения. 
6. Уведомления и напоминания: Система может отправлять уведомления и напоминания о предстоящих задачах или просроченных сроках.  

-----------------------------------------------------------------------------------------
### Описание базы данных

Таблица comments  
Описание: Эта таблица хранит комментарии, которые пользователи оставляют к задачам.

Поля:  
1. id: Уникальный идентификатор комментария.
2. task_id: Внешний ключ, ссылающийся на таблицу tasks. Указывает, к какой задаче относится комментарий.
3. user_id: Внешний ключ, ссылающийся на таблицу users. Указывает, какой пользователь оставил комментарий.
4. content: Текст комментария.
5. created_at: Дата и время создания комментария.
6. updated_at: Дата и время последнего обновления комментария.

Взаимодействия:   
Один пользователь может оставлять много комментариев.  
Одна задача может иметь много комментариев.  
Связь между comments и tasks реализована через task_id.  
Связь между comments и users реализована через user_id.

-----------------------------------------------------------------------------------------

Таблица users  
Описание: Эта таблица хранит комментарии, которые пользователи оставляют к задачам.

Поля:  
1. id: Уникальный идентификатор комментария.
2. username: Имя пользователя.
3. full_name: Имя пользователя.
4. discription: Имя пользователя.
5. email: Почта пользователя.
6. password: Текст комментария.
7. created_at: Дата и время создания комментария.
8. updated_at: Дата и время последнего обновления комментария.

Взаимодействия:   
Один пользователь может оставлять много комментариев.  
Одна задача может иметь много комментариев.  
Связь между comments и tasks реализована через task_id.  
Связь между comments и users реализована через user_id.

-----------------------------------------------------------------------------------------

Таблица tasks  
Описание: Эта таблица хранит комментарии, которые пользователи оставляют к задачам.

Поля:  
1. id: Уникальный идентификатор комментария.
2. user_id: Внешний ключ, ссылающийся на таблицу users. Указывает, какой пользователь создал задачу.
4. discription: Текст описания.
5. created_at: Дата и время создания комментария.
6. updated_at: Дата и время последнего обновления комментария.

Взаимодействия:   
Один пользователь может создавать много задач.  
Одна задача может иметь одного пользователя.  
Связь между tasks и users реализована через user_id.

-----------------------------------------------------------------------------------------

Таблица priorities  
Описание: Эта таблица хранит возможные уровни приоритета задач.  

Поля:  
1. id: Уникальный идентификатор приоритета.
2. name: Название приоритета (например, "Высокий", "Средний", "Низкий").
3. level: Уровень приоритета (например, 1 для низкого, 2 для среднего, 3 для высокого).
4. created_at: Дата и время создания приоритета.
5. updated_at: Дата и время последнего обновления приоритета.

Взаимодействия:  
Приоритеты используются для классификации задач по важности.

-----------------------------------------------------------------------------------------
Таблица task_priorities  
Описание: Эта таблица связывает задачи и приоритеты.  

Поля:  
1. id: Уникальный идентификатор записи.
2. task_id: Внешний ключ, ссылающийся на таблицу tasks. Указывает, к какой задаче относится приоритет.
3. priority_id: Внешний ключ, ссылающийся на таблицу priorities. Указывает, какой приоритет установлен для задачи.
4. created_at: Дата и время создания записи.  

Взаимодействия:  
Одна задача может иметь один приоритет.   
Связь между task_priorities и tasks реализована через task_id.  
Связь между task_priorities и priorities реализована через priority_id.  

-----------------------------------------------------------------------------------------
Таблица tags  
Описание: Эта таблица хранит этикетки, которые можно добавлять к задачам для их классификации и лучшей организации.  

Поля:
1. id: Уникальный идентификатор этикетки.  
2. name: Название этикетки.  
3. created_at: Дата и время создания этикетки.  
4. updated_at: Дата и время последнего обновления этикетки.

Взаимодействия:  
Этикетки используются для классификации задач по различным критериям.  

-----------------------------------------------------------------------------------------
Таблица task_tags  
Описание: Эта таблица связывает задачи и этикетки, реализуя связь многие-ко-многим между ними.  

Поля:
1. task_id: Внешний ключ, ссылающийся на таблицу tasks. Указывает, к какой задаче относится этикетка.
2. tag_id: Внешний ключ, ссылающийся на таблицу tags. Указывает, какая этикетка применена к задаче.

Взаимодействия:  
Одна задача может иметь много этикеток.  
Одна этикетка может быть применена ко многим задачам.  
Связь между task_tags и tasks реализована через task_id.  
Связь между task_tags и tags реализована через tag_id.  

-----------------------------------------------------------------------------------------
Таблица task_history  
Описание: Эта таблица хранит историю изменений задач, что позволяет отслеживать, кто и какие изменения вносил.  

Поля:
1. id: Уникальный идентификатор записи.
2. task_id: Внешний ключ, ссылающийся на таблицу tasks. Указывает, к какой задаче относится изменение.
3. user_id: Внешний ключ, ссылающийся на таблицу users. Указывает, какой пользователь внес изменение.
4. change: Описание изменения.
5. created_at: Дата и время создания записи об изменении.

Взаимодействия:  
Одна задача может иметь много записей в истории изменений.  
Связь между task_history и tasks реализована через task_id.  
Связь между task_history и users реализована через user_id.  

-----------------------------------------------------------------------------------------
Таблица attachments  
Описание: Эта таблица хранит информацию о файлах, прикрепленных к задачам.  

Поля:
1. id: Уникальный идентификатор вложения.
2. task_id: Внешний ключ, ссылающийся на таблицу tasks. Указывает, к какой задаче относится вложение.
3. file_path: Путь к файлу.
4. created_at: Дата и время добавления вложения.

Взаимодействия:  
Одна задача может иметь много вложений.  
Связь между attachments и tasks реализована через task_id.  

-----------------------------------------------------------------------------------------
Описание взаимодействий в целом  
Комментарии: Пользователь может оставлять комментарии к задачам, что позволяет взаимодействовать и обсуждать детали задачи.  
Приоритеты: Каждой задаче можно присвоить приоритет, что помогает пользователям управлять своими задачами в зависимости от их важности.  
Этикетки: Задачи можно классифицировать с помощью этикеток, что упрощает поиск и фильтрацию задач.  
История изменений: Записываются все изменения задач, что позволяет отслеживать, кто и какие изменения внес.  
Вложения: К задачам можно прикреплять файлы, что позволяет хранить дополнительную информацию, необходимую для выполнения задачи.  

-----------------------------------------------------------------------------------------

Для создания пет-проекта на React и .Net, предназначенного для взаимодействия с задачами (Todo-сайт), мне понадобились следующие компоненты:  
 
1. Frontend: 
- React.js: библиотека JavaScript для создания пользовательского интерфейса. 
- HTML/CSS: для верстки и стилей моего сайта. 
- Axios или Fetch API: для отправки запросов на ваш сервер. 
 
2. Backend: 
- ASP.NET Core: фреймворк для создания веб-приложений на платформе .NET. 
- Entity Framework Core: ORM (Object-Relational Mapping) для работы с базой данных. 
- RESTful API: для взаимодействия между фронтендом и бэкендом. 
- Postresql: для хранения задач и других данных. 
 
3. Дополнительно: 
- Visual Studio или Visual Studio Code: для разработки и отладки кода. 
- Postman или другой инструмент для тестирования API. 
- Git: для контроля версий моего кода. 
- npm или yarn: для управления зависимостями в вашем проекте. 
 
