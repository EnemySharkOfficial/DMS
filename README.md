# 1. Описание предметной области
	Предметная область представляет собой сферу работы с машинами и их запчастями. 
	Непосредственно в работе рассматривается взаимодействие трех баз данных диллерского центра
		1) База данных отдела продаж (PostgreSQL)
		2) База данных сервисного отдела (SQLite)
		3) База данных поставщика автомобилей и запчастей (NoSQL - MongoDB)
# 2. Описание пользователей
	Работать с приложением будет два вида пользователей: менеджеры и клиенты диллерского центра
	1) Клиент - будет иметь более узкий функционал нежели менеджер, основная суть функционала будет
	состоять в ознакомлении с ассортиментом, возможность фильтрации контента и совершением заказов,
	в том числе его оплатой, связаться с менеджером.
	2) Менеджер - будет иметь широкий доступ ко всем базам данных. Имеет возможность редактировать данные
	базы данных отдела продаж и сервисного отдела. 
	К бд поставщика обращение допускается для получения данных о деталях и оставления заявок на поставку деталей
	или автомобилей.


# 3. Описание системы вцелом
	Система представляет собой 3 базы данных описанные в пункте 1. и 2 версии приложения для клиента и для менеджера.
	Для работы с каждой базой данных будет использоваться отдельное API, API не будут изменяться в зависимости от 
	пользователя. Доступ к API будет ограничен средствами приложения

# 4. Системные программы и функции
	Все функции будут делиться на два типа:
	1) Функции доступные клиенту:
		1 Ознакомление с ассортиментом и получение его списка и прочей сопуствующей информации
		2 Возможность фильтровать ассортимент и настраивать поиск
		3 Возможность оставлять заявки на заказ
		4 Возможность связи с менеджером
		5 Возможность оплаты услуги или товара
	2) Функции доступные менеджеру:
		1 Просмотр всех бд
		2 Регистрация заявок
		3 Реализация товаров или услуг
		4 Редактирование баз данных сервисного отдела и отдела продаж в случае нештатных ситуаций

# 5. Макеты предполагаемого интерфейса сайта
	Начальная страница пользовательского сайта
![Страница каталога](https://github.com/EnemySharkOfficial/DMS/blob/main/Lab%201/Site/Site%20layout/Catalog_page.png)

	Страница отдельного автомобиля
![Страница каталога](https://github.com/EnemySharkOfficial/DMS/blob/main/Lab%201/Site/Site%20layout/Car_page.png)

	Страница составления формы заявки
![Страница каталога](https://github.com/EnemySharkOfficial/DMS/blob/main/Lab%201/Site/Site%20layout/Form_page.png)
