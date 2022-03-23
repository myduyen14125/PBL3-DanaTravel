use DanaTravel;

INSERT INTO ACCOUNT(username, password, status)
VALUES	('daitoan2000@gmail.com', '123456', 1),
		('myduyen14125@gmail.com', '123456', 1),
		('thaovyxeo@gmail.com', '123456', 0),
		('ngochungle14331@gmail.com', '123456', 1);

INSERT INTO ROLE(name)
VALUES	('Director'),
		('Secretary'),
		('Manager'),
		('Employee'),
		('Accountant'),
		('Customer');

INSERT INTO ACCOUNT_ROLE(account_id, role_id)
VALUES	(1, 1),
		(2, 3),
		(3, 2),
		(4, 4);

INSERT INTO PERMISSION(name)
VALUES	('Create employee'),
		('View employee'),
		('Edit employee'),
		('Delete employee'),
		('Create customer'),
		('View customer'),
		('Edit customer'),
		('Delete customer'),
		('Create bill'),
		('View bill'),
		('Edit bill'),
		('Delete bill'),
		('Create service'),
		('View service'),
		('Edit service'),
		('Delete service'),
		('Statistical');
		

INSERT INTO ROLE_PERMISSION(role_id, permission_id)
VALUES	(1, 1), (1, 2), (1, 3), (1, 4), (1, 5), (1, 6), (1, 7), (1, 8), (1, 9), (1, 10), (1, 11), (1, 12), (1, 13), (1, 14), (1, 15), (1, 16), (1, 17),
		(2, 1), (2, 2), (2, 3), (2, 4), (2, 5), (2, 6), (2, 7), (2, 8), (2, 9), (2, 10), (2, 11), (2, 12), (2, 13), (2, 14), (2, 15), (2, 16), (2, 17),
		(3, 1), (3, 2), (3, 3), (3, 4), (3, 5), (3, 6), (3, 7), (3, 8), (3, 9), (3, 10), (3, 11), (3, 12), (3, 13), (3, 14), (3, 15), (3, 16),
		(4, 5), (4, 6), (4, 7), (4, 8), (4, 9), (4, 10), (4, 11), (4, 12), (4, 13), (4, 14), (4, 15), (4, 16),
		(5, 5), (5, 6), (5, 7), (5, 8), (5, 9), (5, 10), (5, 11), (5, 12), (5, 13), (5, 14), (5, 15), (5, 16), (5, 17);
		



