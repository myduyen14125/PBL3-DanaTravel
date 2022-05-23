use DanaTravel;
-- Data Permissions
insert into Permissions(name)
values	('Create Employee'), ('View Employee'), ('Edit Employee'), ('Delete Employee'),
		('Create Customer'), ('View Customer'), ('Edit Customer'), ('Delete Customer'),
		('Create Bill'), ('View Bill'), ('Edit Bill'), ('Delete Bill'),
		('Create Tour'), ('View Tour'), ('Edit Tour'), ('Delete Tour'),
		('Statistical');

-- Data division
insert into Divisions(name)
values	(N'Bộ phận quản trị'),
		(N'Bộ phận hành chính'),
		(N'Bộ phận kinh doanh'),
		(N'Bộ phận kế toán'),
		(N'Bộ phận kỹ thuật'),
		(N'Bộ phận marketing');

-- Data Position
insert into Positions(name)
values	(N'Giám đốc'),
		(N'Trợ lý giám đốc'),
		(N'Quản lý'),
		(N'Chuyên viên'),
		(N'Nhân viên'),
		(N'Hướng dẫn viên');

-- Data Education degree
insert into Education_degree(name)
values	(N'Phổ thông'),
		(N'Trung cấp'),
		(N'Đại học'),
		(N'Thạc sĩ'),
		(N'Tiến sĩ'),
		(N'Giáo sư');

-- Data CustomerTypes
insert into CustomerTypes(name)
values	('Standard'),
		('Silver'),
		('Gold'),
		('Platinum'),
		('Diamond');

-- Data Roles
insert into Roles(name) 
values	('Admin'), ('Customer'), ('Employee');

-- Create permission for role admin
insert into PermissionRoles(Role_id, Permission_id)
values	(1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8),
		(1,9), (1,10), (1,11), (1,12), (1,13), (1,14), (1,15), (1,16), (1,17);
		
-- Create permission for role employee
insert into PermissionRoles(Role_id, Permission_id)
values	(3, 2), (3, 5), (3,6), (3,7), (3,8), (3,9), (3,10), (3, 14);

-- Create account admin: Password: admin
insert into Accounts(username, password, status)
values	('daitoan2000@gmail.com', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1);
insert into RoleAccounts(Account_id, Role_id) values (1, 1);

-- Create account customer
-- Account: 102200035	Password: 123456
insert into Accounts (username, password, status) values ('102200035@sv1.dut.udn.vn', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1);
insert into RoleAccounts values (2, 2);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id, account_id) values ('Fear', '8/9/2021', 1, '858987786399', '927 972 8426', '60140 Arkansas Center', '102200035@sv1.dut.udn.vn', 2, 2);

-- Các khách hàng chỉ có thông tin, không có account login
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Chisolm', '10/9/1990', 1, '187185872305', '606 107 8940', '96989 Judy Parkway', 'schisolm1@admin.ch', 1);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Decourt', '6/14/1980', 1, '929182657806', '945 339 0859', '75 Pearson Park', 'ddecourt2@sciencedirect.com', 2);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Bythell', '11/8/1978', 1, '767999956432', '641 464 3117', '29 Sheridan Crossing', 'jbythell3@twitter.com', 1);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Ruit', '1/3/1989', 0, '793120071651', '848 125 4431', '93717 Miller Hill', 'truit4@macromedia.com', 4);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Fido', '9/27/2000', 1, '550050596371', '854 445 9164', '58 Walton Alley', 'bfido5@aboutads.info', 5);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Prantl', '3/8/1978', 1, '552330798215', '505 514 1710', '3 Dayton Place', 'sprantl6@sourceforge.net', 1);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Gadie', '4/27/1985', 0, '367085137620', '984 665 2183', '702 Stuart Road', 'tgadie7@mac.com', 1);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Eadmeads', '10/11/1976', 1, '617246818280', '621 553 0427', '36017 Bashford Pass', 'aeadmeads8@ed.gov', 3);
insert into Customers (name, birthday, gender, idCard, phone, address, email, customer_type_id) values ('Atcock', '12/15/1989', 1, '869647702077', '950 570 8324', '6 Kedzie Center', 'oatcock9@home.pl', 3);

-- Data account employee
insert into Accounts(username, password, status)
values	('jfrith0@newyorker.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('adethloff1@theatlantic.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('bsands2@pen.io', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('iscourgie3@livejournal.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('dzanazzi4@elegantthemes.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0),
		('kbenford5@purevolume.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0),
		('ehofler6@furl.net', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('mfetherston7@bloglines.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0),
		('adamp8@sun.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('vgrob9@scribd.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('kbalasina@toplist.cz', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('mgocherb@networkadvertising.org', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('msmewingsc@163.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0),
		('mcobbledd@usa.gov', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
		('cpennycocke@about.com', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1);
-- Data Account Role
insert into RoleAccounts(account_id, role_id)
values	(3, 3), (4, 3), (5, 3), (6, 3), (7, 3), (8, 3), (9, 3), (10, 3), (11, 3), (12, 3), (14, 3), (15,3), (16, 3);
-- Data demo Employee
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values (N'Nguyễn Phước Đại Toàn', '2002/10/10', 'daitoan2000@gmail.com', 1, '0967492536', N'Đà Nẵng', '123456789012', 1, 1, 2, 1, 8321);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Frith', '2021/01/10', 'jfrith0@newyorker.com', 1, '7288872559', 'Voskop', '799081577119', 3, 1, 2, 1, 8321);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Dethloff', '2021/01/27', 'adethloff1@theatlantic.com', 0, '2871122046', 'Copey', '642309833087', 8, 4, 5, 6, 9376);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Sands', '2020/11/04', 'bsands2@pen.io', 1, '4409600592', 'Fiditi', '959903172973', 5, 4, 4, 2, 1740);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Scourgie', '2022/03/26', 'iscourgie3@livejournal.com', 0, '8455272835', 'Xazgat', '856572875056', 6, 4, 3, 5, 1911);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Zanazzi', '2019/10/16', 'dzanazzi4@elegantthemes.com', 0, '3683782788', 'Maundai', '490921452486', 7, 3, 5, 5, 4874);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Benford', '2021/11/05', 'kbenford5@purevolume.com', 1, '7603238405', 'Khadir', '285305432212', 8, 3, 4, 6, 6384);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Hofler', '2020/02/29', 'ehofler6@furl.net', 1, '5022490622', 'Awash', '559247148280', 9, 3, 1, 1, 2961);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Fetherston', '2019/12/01', 'mfetherston7@bloglines.com', 0, '6097196310', 'Camalote', '418076657304', 10, 6, 1, 3, 4907);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Damp', '2022/03/15', 'adamp8@sun.com', 1, '8506544065', 'Oematnunu', '738113137716', 11, 5, 3, 3, 4270);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Grob', '2019/06/25', 'vgrob9@scribd.com', 0, '2105136707', 'Ferreiras', '266920784315', 12, 6, 2, 4, 5815);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Balasin', '2020/10/03', 'kbalasina@toplist.cz', 1, '9894900241', 'Ngurenrejo', '443421651732', 13, 5, 5, 2, 3658);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Gocher', '2021/11/11', 'mgocherb@networkadvertising.org', 0, '6139960645', 'Kvasy', '316162668866', 14, 6, 5, 5, 3121);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Smewings', '2020/06/13', 'msmewingsc@163.com', 1, '3921960133', 'Aguilar', '712860171928', 15, 3, 2, 4, 8192);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Cobbled', '2022/01/16', 'mcobbledd@usa.gov', 0, '9424300807', 'Suslonger', '150155608111', 16, 2, 5, 5, 3799);
insert into Employees (name, birthday, email, gender, phone, address, idCard, account_id, position_id, division_id, education_degree_id, salary) values ('Pennycock', '2020/01/17', 'cpennycocke@about.com', 0, '1048337489', 'Gaoxiang', '636073296585', 17, 4, 2, 6, 9781);

-- Data tour status
insert into TourStatus(name)
values	(N'Sắp bắt đầu'),
		(N'Đang diễn ra'),
		(N'Đã kết thúc'),
		(N'Đã hủy');
-- Data tour category
insert into TourCategories(name)
values	(N'Tour về gia đình'),
		(N'Tour về thám hiểm'),
		(N'Tour về tự nhiên'),
		(N'Tour về tôn giáo');
-- Data tour ticket status
insert into TourTicketStatus(name)
values	(N'Đang chờ xác nhận'), (N'Đã xác nhận'), (N'Đã hủy');