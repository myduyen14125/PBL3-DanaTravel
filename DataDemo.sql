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

-- Data bill statuc
insert into BillStatus(name)
values	(N'Đang chờ thanh toán'), (N'Đã thanh toán'), (N'Đã hủy');

-- Data tour
/****** Script for SelectTopNRows command from SSMS  ******/
  SET IDENTITY_INSERT Tours ON;
  INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '1', 
  N'Du lịch Phú Quốc - Grand World - Checkin Dòng Sông Venice - Vinwonders từ Sài Gòn 2022', 
  N'Xe du lịch, máy bay',
  N'Khám phá Grand World Phú Quốc là một dự án siêu khủng tái hiện những công trình của thế giới như: kênh đào Venice lãng mạn, công trình tre khổng lồ, bảo tàng gấu Teddy… Ngoài ra nơi đây còn có hàng loạt tiện ích mới được nâng cấp cùng chuỗi hoạt động nghệ thuật độc đáo và những sự kiện âm nhạc đặc sắc, quy mô “khủng” mang đến không khí lễ hội bất tận suốt 365 ngày/năm.',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HCM – PHÚ QUỐC (ăn trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng: &nbsp;Quý khách có mặt 
tại ga quốc nội, sân bay Tân Sơn Nhất trước giờ bay ít nhất ba 
tiếng.</STRONG><BR style="BOX-SIZING: border-box">Đại diện công ty Du Lịch Việt 
đón và hỗ trợ Quý khách làm thủ tục đón chuyến bay đi Phú Quốc.&nbsp;<BR 
style="BOX-SIZING: border-box">Đến sân bay Phú Quốc, Hướng dẫn viên đón Quý 
khách Tham quan các làng nghề truyền thống nổi tiếng trên đảo.<BR 
style="BOX-SIZING: border-box">Hồ tiêu Phú Quốc: tìm hiểu về cách trồng tiêu tại 
vườn. Tiêu Phú Quốc nổi tiếng với hạt to, đen và cay thơm. Du khách có thể mua 
tiêu về làm quà tại nhà vườn.<BR style="BOX-SIZING: border-box">Rượu sim: loại 
rượu vang làm từ trái sim rừng chín.Gặp gỡ và trò chuyện với người đầu tiên chế 
biến ra rượu sim sơn tại cơ sở sản xuất rượu sim Bảy Gáo.</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa: Dùng cơm 
trưa.</STRONG></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khám 
phá thành phố không ngủ Grand World Phú Quốc – checkin dòng sông Venice<BR 
style="BOX-SIZING: border-box">(Chi phí tự túc, không bao gồm: vé tham quan)<BR 
style="BOX-SIZING: border-box">Khám Phá Phú Quốc UnitedCenter - Grandword ,Trung 
tâm mới sầm uất và đa tiện tích của Phú Quốc với hệ sinh thái dịch vụ trọn vẹn 
từ dân sinh đến giải trí, nay được hoàn thiện ngoạn mục bằng sự ra mắt của Grand 
World, Thiên đường giải trí - mua sắm - lễ hội độc đáo và đa dạng bậc nhất Đông 
Nam Á với chuỗi trải nghiệm xuyên suốt 24h.<BR 
style="BOX-SIZING: border-box">Quý Khách được Checkin sống ảo Miễn phí tại đây 
.&nbsp;<BR style="BOX-SIZING: border-box"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">SIÊU QUẦN THỂ NGHỈ DƯỠNG - KHÁM 
PHÁ - MUA SẮM - GIẢI TRÍ KHÔNG NGỦ HÀNG ĐẦU KHU VỰC - PHÚ QUỐC UNITED 
CENTER.</STRONG></DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Tối: Dùng cơm tối.</STRONG><BR 
style="BOX-SIZING: border-box">Nghỉ đêm tại Phú Quốc.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>PHÚ QUỐC – BÃI SAO – CÂU CÁ – SUNSET SANATO (Ăn sáng, 
trưa, tối)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng: Dùng bữa 
sáng.</STRONG></DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Xe 
đưa đoàn tiến về phía Nam, lên tàu câu cá.<BR 
style="BOX-SIZING: border-box">Ngọc trai cao cấp Phú Quốc: quý khách được trực 
tiếp tham quan quy trình nuôi trai lấy ngọc tại các cơ sở nuôi cấy ngọc trai 
chuyên nghiệp tại Phú Quốc.<BR style="BOX-SIZING: border-box">Trên tàu: Với đội 
ngủ thủy thủ đoàn &amp; HDV địa phương giàu kinh nghiệm, quý khách sẽ tận hưởng 
từng khoảnh khắc đáng nhớ khi chính tay mình buông câu bắt được những chú cá 
bồng mú phàm ăn trong các rạn san hô tại hòn Dừa, hòn Rỏi, ….</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa: Dùng cơm 
trưa.</STRONG><BR style="BOX-SIZING: border-box">Bãi Sao: quý khách tiếp tục 
dừng chân tại một trong những bãi biển đẹp nhất Phú Quốc với bãi cát dài thoang 
thoảng, trắng mịn. Đoàn tự do chụp hình lưu niệm.<BR 
style="BOX-SIZING: border-box">Nhà tù Phú Quốc: khu di tích lịch sử - nơi chứng 
kiến bao tội ác của thực dân Pháp và đế quốc Mỹ khi giam cầm hơn 32 ngàn tù binh 
chiến tranh (có lúc lên &nbsp; đến con số 40 ngàn tù binh) trong khoảng thời 
gian tồn tại chưa đầy 6 năm.<BR style="BOX-SIZING: border-box">Đoàn tham quan 
Sunset Sanato Beach Club, nơi được mệnh danh là “Điểm ngắm hoàng hôn đẹp nhất 
đảo Ngọc”. tọa lạc ngay trung tâm Bãi Trường. Không gian biển ở Sunset Sanato 
Beach Club rất thoáng tầm nhìn và được điểm tô bằng nhiều công trình kiến trúc 
cực độc đáo, mang dấu ấn khó phai. Và có lẽ chính những khối kiến trúc kì lạ và 
đầy sáng tạo ấy đã giúp cho Sunset Sanato Beach Club trở thành điểm check-in 
siêu độc mà ai đến Phú Quốc cũng phải "đỏm dáng" làm ngay vài kiểu.</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Tối: Dùng cơm tối.</STRONG><BR 
style="BOX-SIZING: border-box">Nghỉ đêm tại Phú Quốc.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>PHÚ QUỐC – TP.HCM (Ăn sáng) (Ăn trưa tự túc)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng: Dùng bữa sáng. 
&nbsp;</STRONG><BR style="BOX-SIZING: border-box">Quý khách có thể tự do tắm 
biển, nghỉ ngơi tại khách sạn hoặc Quý khách có thể chọn một trong các điểm tham 
quan tham khảo như sau:&nbsp;<BR style="BOX-SIZING: border-box"><EM 
style="BOX-SIZING: border-box"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">*Lựa chọn 1: Khám phá CÔNG VIÊN 
CHỦ ĐỀ VINWONDERS PHÚ QUỐC&nbsp;</STRONG></EM><BR 
style="BOX-SIZING: border-box">(Chi phí tự túc; không bao gồm: phương tiện vận 
chuyển, vé tham quan Vinwonders + 01 bữa ăn trưa)<BR 
style="BOX-SIZING: border-box">VinWonders Phú Quốc – Công viên với 06 chủ đề 
khác nhau, được kết nối bằng câu chuyện chủ đề xuyên suốt:&nbsp;<BR 
style="BOX-SIZING: border-box">- Khu lâu đài trung tâm – Châu Âu trung 
cổ&nbsp;<BR style="BOX-SIZING: border-box">- Khu Viking – Khu làng bí 
mật&nbsp;<BR style="BOX-SIZING: border-box">- Khu cảm giác mạnh – thế giới phiêu 
lưu&nbsp;<BR style="BOX-SIZING: border-box">- Khu công viên nước – thế giới lốc 
xoáy<BR style="BOX-SIZING: border-box">- Khu cổ tích – Thế giới diệu kỳ<BR 
style="BOX-SIZING: border-box">- Khu Thủy cung - Cung điện Hải Dương&nbsp;&nbsp; 
&nbsp;<BR style="BOX-SIZING: border-box"><EM 
style="BOX-SIZING: border-box"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">*Lựa chọn 2: Khám phá CÔNG VIÊN 
CHĂM SÓC &amp; BẢO TỒN ĐỘNG VẬT VINPEARL SAFARI</STRONG></EM><BR 
style="BOX-SIZING: border-box">(Chi phí tự túc; không bao gồm: phương tiện vận 
chuyển, vé tham quan Safari + 01 bữa ăn trưa)<BR 
style="BOX-SIZING: border-box">Công viên chăm sóc và bảo tồn động vật Vinpearl 
Safari – vườn thú mở lớn nhất Việt Nam hiện nay, sẽ chính thức mở cửa đón khách 
tham quan vào ngày 24/12/2015 tại đảo ngọc Phú Quốc.&nbsp;<BR 
style="BOX-SIZING: border-box">Công viên động vật bán hoang dã với Khu vườn thú 
mở:<BR style="BOX-SIZING: border-box">Nơi bảo tồn hơn 100 loài động vật quý hiếm 
từ khắp nơi trên thế giới. Tại đây, các loài được chăm sóc và phát triển khỏe 
mạnh trong không gian chuồng trại rộng lớn, thoáng đãng và hài hòa với môi 
trường tự nhiên. Trải nghiệm Rừng linh trưởng, Vương quốc sư tử, Khu động vật có 
vú, Khu rừng của voi, Thế giới bò sát, Đầm lầy hà mã, …<BR 
style="BOX-SIZING: border-box">Các hoạt động trải nghiệm đời sống hoang dã:<BR 
style="BOX-SIZING: border-box">+ Xem chương trình biểu diễn động vật:<BR 
style="BOX-SIZING: border-box">+ Chụp ảnh với động vật&nbsp;<BR 
style="BOX-SIZING: border-box">+ Cho động vật ăn<BR 
style="BOX-SIZING: border-box">Ngoài ra, còn hệ thống nhà hàng với phong cách ẩm 
thực đa dạng và phố mua sắm với những món quà lưu niệm đặc sắc.<BR 
style="BOX-SIZING: border-box">*Lựa chọn 3: Trải nghiệm Sun World Hon Thom 
Nature Park – Cáp treo ba dây vượt biển dài nhất Thế Giới.<BR 
style="BOX-SIZING: border-box">(Chi phí tự túc; không bao gồm: phương tiện vận 
chuyển, vé cáp treo + 01 bữa ăn trưa)<BR style="BOX-SIZING: border-box">Quý 
khách đến ga An Thới – Nhà ga đi Cáp treo Hòn Thơm. Quý khách trải nghiệm với 
cáp treo vượt biển dài nhất thế giớ với tổng chiều dài vượt biển 7.899,9m - cáp 
treo dài nhất thế giới được tổ chức Guinness chứng nhận. (chi phí cáp treo và 
các dịch vụ vui chơi giải trí tại Hòn Thơm quý khách vui lòng tự túc).<BR 
style="BOX-SIZING: border-box">Khám phá đảo Hòn Thơm với vẻ đẹp hoang sơ, trong 
lành; hòa mình vào làn nước biển xanh biếc tại một trong những hòn đảo đẹp nhất 
Việt Nam; hào hứng với hàng loạt trò chơi biển: dù kéo, lái cano, chèo thuyền 
Kayak,...; không thể bỏ lỡ trải nghiệm thưởng thức hải sản tươi ngon, đặc sản 
Phú Quốc tại các nhà chòi bên bờ biển thơ mộng…<BR 
style="BOX-SIZING: border-box">Đoàn tự do đi chợ mua sắm đặc sản về làm quà cho 
người thân: ghẹ, hải mã sống ngâm rượu, hải mã chiên giòn, quả dứa biển và trái 
mỏ quạ để ngâm rượu thuốc…. những đặc sản chỉ có ở Phú Quốc (chi phí tự túc).<BR 
style="BOX-SIZING: border-box">Nhà thùng nước mắm: Tìm hiểu cách ủ và chế biến 
nước mắm cá cơm rất nổi tiếng trong và ngoài nước theo cách làm truyền thống của 
người dân Phú Quốc với hàm lượng dinh dưỡng rất cao.<BR 
style="BOX-SIZING: border-box">Hướng dẫn viên tiễn đoàn ra sân bay Phú Quốc, đón 
chuyến bay về TP.HCM.<BR style="BOX-SIZING: border-box">Kết thúc chương trình 
tham quan, chia tay và hẹn gặp lại.<BR style="BOX-SIZING: border-box"><BR 
style="BOX-SIZING: border-box"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Lưu ý khi tham gia 
tour:&nbsp;</STRONG><BR style="BOX-SIZING: border-box">✓ Quý khách vui lòng giữ 
khoảng cách và đảm bảo nguyên tắc 5K, khử khuẩn trong suốt hành trình.<BR 
style="BOX-SIZING: border-box">✓ Vận chuyển không quá 50% số ghế, không quá 20 
khách/1 xe (bao gồm cả tài xế), tuân thủ ngồi giãn cách trên xe, các điểm tham 
quan, ăn uống… và đeo khẩu trang suốt quá trình di chuyển.<BR 
style="BOX-SIZING: border-box">✓ Thẻ xanh covid (khách đã tiêm vaccine ngừa 
covid đủ liều, thời gian hoàn tất mũi 2 trước 14 ngày và không quá 12 tháng), 
khách là FO đã khỏi bệnh (có giấy chứng nhận của Sở Y Tế và không quá 06 
tháng).<BR style="BOX-SIZING: border-box">✓ Xét nghiệm covid theo yêu cầu của 
từng tỉnh vào thời điểm đặt dịch vụ. Vui lòng liên hệ với nhân viên tư vấn để 
biết thêm chi tiết.</P></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-05-26 21:09:30.000'),
CONVERT(DATETIME, '2022-05-28 21:09:30.000'),
'5945478',
'297273',
'1',
'3'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '2', 
  N'Du lịch Miền Trung - Đà Nẵng - Hội An - Huế từ Sài Gòn giá tốt 2022', 
  N'Xe du lịch, máy bay',
  N'Được mệnh danh là ‘’thành phố đáng đến’’ với dòng sông Hàn thơ mộng với cây cầu Rồng biểu tượng của Thành phố biển du lịch Đà Nẵng - nơi mà quý khách có thể cảm nhận được sự pha trộn giữa khí hậu miền Bắc, miền Nam.Ngoài ra Đà Nẵng còn sở hữu nhiều danh lam thắng cảnh làm say lòng người như: Bà Nà Hills, Bán Đảo Sơn Trà, Ngũ Hành Sơn, Đà Nẵng, phố cổ Hội An',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 30px; MARGIN: 0px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HCM – ĐÀ NẴNG – HỘI AN (ăn trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
&nbsp; &nbsp;Quý khách có mặt tại ga quốc nội, sân bay Tân Sơn Nhất trước giờ 
bay ít nhất ba tiếng.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đại 
  diện công ty Du Lịch Việt đón và hỗ trợ Quý Khách làm thủ tục đón chuyến bay 
  đi Đà Nẵng.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đến 
  sân bay Đà Nẵng Hướng dẫn viên đón đoàn tham quan Ngũ Hành Sơn - được ví như 
  hòn non bộ khổng lồ giữa lòng thành phố Đà Nẵng với Động Huyền Không, Chùa 
  Linh Ứng, Chùa Tam Thai, Vọng Hải Đài,…mua sắm quà lưu niệm tại làng nghề điêu 
  khắc đá Non Nước.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
&nbsp; Dùng cơm trưa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành đến Hội An, tham quan Phố Cổ Hội An - di sản văn hoá thế giới với Chùa 
  Cầu Nhật Bản, Hội Quán Phúc Kiến, Nhà Cổ Phùng Hưng…</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Chiều: 
&nbsp;Dùng cơm chiều. Nghỉ đêm tại Đà Nẵng. &nbsp; &nbsp; &nbsp; 
&nbsp;&nbsp;</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách tự do dạo phố, ngắm các cây cầu nổi tiếng của thành phố Đà Nẵng: cầu 
  Rồng, cầu Sông Hàn, cầu Trần Thị Lý, cầu Thuận Phước...</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>ĐÀ NẴNG – VINPEARL NAM HỘI AN (ăn sáng, chiều) (ăn 
trưa tự túc)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; OUTLINE-STYLE: none; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; OUTLINE-COLOR: invert; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; MARGIN: 0px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; MARGIN: 0px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">Sáng: 
&nbsp; &nbsp;Dùng buffet sáng tại khách sạn.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành đến Vinpearl Nam Hội An, tham quan chụp hình tại:&nbsp;</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Bến 
  cảng giao thoa: với một bên là Hội An quá khứ và hiện tại với một bên là Đại 
  lộ giấc mơ thế giới bên ngoài…</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đảo 
  dân gian mang đậm bản sắc Việt, điểm khác biệt giữa Vinpearl Hội An với các 
  Vinpearl Land khác.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Du 
  khách lên thuyền trải nghiệm cám giác như lạc giữa rừng Amazon huyền bí với 
  River Safari với 39 loài thú hoang dã.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tương 
  tác các trò chơi trong nhà với hơn 95 trò chơi điện tử dành cho mọi đối tượng 
  khác nhau. Một số khu vực đặc biệt đưa ưa thích như: phim 5D, vườn cổ tích, 
  trò chơi Trampoline, Playoke,...</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
&nbsp; &nbsp;Quý khách vui lòng ăn trưa tự túc.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trải 
  nghiệm hơn 20 trò chơi cảm giác mạnh hàng đầu thế giới: tàu lượn, phi thuyền 
  gió lốc, cây dây văng, cơn lốc sa mạc…</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Công 
  viên nước với 10 trò chơi hiện đại nhất.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Chiều: 
&nbsp; Dùng cơm chiều tại nhà hàng. Nghỉ đêm tại Đà Nẵng.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>ĐÀ NẴNG - HUẾ – TP.HCM (ăn sáng, trưa)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
&nbsp; &nbsp;Dùng buffet sáng tại khách sạn.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan một vòng bán đảo Sơn Trà…viếng Linh Ứng Tự và thưởng ngoạn vẻ đẹp của 
  biển Mỹ Khê (được đánh giá là một trong những bãi biển quyến rũ nhất hành 
  tinh).</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  khởi hành đến Huế qua đường hầm Hải Vân-hầm đường bộ dài nhất Đông Nam 
Á.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
&nbsp; Dùng cơm trưa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan Huế với Đại Nội – Hoàng Thành của 13 vị vua triều Nguyễn, nơi có hơn 100 
  công trình kiến trúc đẹp: Ngọ Môn, Điện Thái Hòa, Tử Cấm Thành, Thế Miếu, Hiển 
  Lâm Các, Cửu Đỉnh,…</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan chùa Thiên Mụ – &nbsp;ngôi chùa cổ nhất Cố đô Huế.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Hướng 
  dẫn viên tiễn đoàn ra sân bay Phú Bài, đón chuyến bay về TP.HCM.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Kết 
  thúc chương trình tham quan, chia tay và hẹn gặp lại.</LI></UL><BR 
style="BOX-SIZING: border-box"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Lưu ý khi tham gia 
tour:&nbsp;</STRONG><BR style="BOX-SIZING: border-box">✓ Quý khách vui lòng giữ 
khoảng cách và đảm bảo nguyên tắc 5K, khử khuẩn trong suốt hành trình.<BR 
style="BOX-SIZING: border-box">✓ Vận chuyển không quá 50% số ghế, không quá 20 
khách/1 xe (bao gồm cả tài xế), tuân thủ ngồi giãn cách trên xe, các điểm tham 
quan, ăn uống… và đeo khẩu trang suốt quá trình di chuyển.<BR 
style="BOX-SIZING: border-box">✓ Thẻ xanh covid (khách đã tiêm vaccine ngừa 
covid đủ liều, thời gian hoàn tất mũi 2 trước 14 ngày và không quá 12 tháng), 
khách là FO đã khỏi bệnh (có giấy chứng nhận của Sở Y Tế và không quá 06 
tháng).<BR style="BOX-SIZING: border-box">✓ Xét nghiệm covid theo yêu cầu của 
từng tỉnh vào thời điểm đặt dịch vụ. Vui lòng liên hệ với nhân viên tư vấn để 
biết thêm chi tiết.</DIV></DIV></DIV></DIV></DIV><FONT 
size=4></FONT></BODY></HTML>',
CONVERT(DATETIME, '2022-05-24 21:16:29.000'),
CONVERT(DATETIME, '2022-05-24 21:16:29.000'),
'6684927',
'334246',
'1',
'1'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '3', 
  N'Du lịch Hè - Tour Du lịch Quy Nhơn - Phú Yên', 
  N'Xe du lịch, máy bay',
  N'Du lịch Phú Yên với một vẻ đẹp mặn mà tựa như một cô thông nữ mộc mạc đậm chất làng quê Việt Nam sẽ thu hút bất kỳ ai du lịch Phú Yên. Vẻ đẹp của Phú Yên đã từng được nhắc đến trong nhiều câu ca bài hát, trong những bộ phim... với những cảnh quan núi xanh, nước biếc, biển sông hồ. Hôm nay chúng ta hãy cùng nhau khám phá chuyến du lịch Phú Yên này nhé',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 30px; MARGIN: 0px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HCM – ĐÀ NẴNG – HỘI AN (ăn trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
&nbsp; &nbsp;Quý khách có mặt tại ga quốc nội, sân bay Tân Sơn Nhất trước giờ 
bay ít nhất ba tiếng.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đại 
  diện công ty Du Lịch Việt đón và hỗ trợ Quý Khách làm thủ tục đón chuyến bay 
  đi Đà Nẵng.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đến 
  sân bay Đà Nẵng Hướng dẫn viên đón đoàn tham quan Ngũ Hành Sơn - được ví như 
  hòn non bộ khổng lồ giữa lòng thành phố Đà Nẵng với Động Huyền Không, Chùa 
  Linh Ứng, Chùa Tam Thai, Vọng Hải Đài,…mua sắm quà lưu niệm tại làng nghề điêu 
  khắc đá Non Nước.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
&nbsp; Dùng cơm trưa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành đến Hội An, tham quan Phố Cổ Hội An - di sản văn hoá thế giới với Chùa 
  Cầu Nhật Bản, Hội Quán Phúc Kiến, Nhà Cổ Phùng Hưng…</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Chiều: 
&nbsp;Dùng cơm chiều. Nghỉ đêm tại Đà Nẵng. &nbsp; &nbsp; &nbsp; 
&nbsp;&nbsp;</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách tự do dạo phố, ngắm các cây cầu nổi tiếng của thành phố Đà Nẵng: cầu 
  Rồng, cầu Sông Hàn, cầu Trần Thị Lý, cầu Thuận Phước...</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>ĐÀ NẴNG – VINPEARL NAM HỘI AN (ăn sáng, chiều) (ăn 
trưa tự túc)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; OUTLINE-STYLE: none; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; OUTLINE-COLOR: invert; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; MARGIN: 0px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; OUTLINE-WIDTH: 0px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; OUTLINE-STYLE: none; PADDING-LEFT: 0px; MARGIN: 0px; OUTLINE-COLOR: invert; PADDING-RIGHT: 0px">Sáng: 
&nbsp; &nbsp;Dùng buffet sáng tại khách sạn.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành đến Vinpearl Nam Hội An, tham quan chụp hình tại:&nbsp;</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Bến 
  cảng giao thoa: với một bên là Hội An quá khứ và hiện tại với một bên là Đại 
  lộ giấc mơ thế giới bên ngoài…</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đảo 
  dân gian mang đậm bản sắc Việt, điểm khác biệt giữa Vinpearl Hội An với các 
  Vinpearl Land khác.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Du 
  khách lên thuyền trải nghiệm cám giác như lạc giữa rừng Amazon huyền bí với 
  River Safari với 39 loài thú hoang dã.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tương 
  tác các trò chơi trong nhà với hơn 95 trò chơi điện tử dành cho mọi đối tượng 
  khác nhau. Một số khu vực đặc biệt đưa ưa thích như: phim 5D, vườn cổ tích, 
  trò chơi Trampoline, Playoke,...</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
&nbsp; &nbsp;Quý khách vui lòng ăn trưa tự túc.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trải 
  nghiệm hơn 20 trò chơi cảm giác mạnh hàng đầu thế giới: tàu lượn, phi thuyền 
  gió lốc, cây dây văng, cơn lốc sa mạc…</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Công 
  viên nước với 10 trò chơi hiện đại nhất.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Chiều: 
&nbsp; Dùng cơm chiều tại nhà hàng. Nghỉ đêm tại Đà Nẵng.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>ĐÀ NẴNG - HUẾ – TP.HCM (ăn sáng, trưa)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
&nbsp; &nbsp;Dùng buffet sáng tại khách sạn.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan một vòng bán đảo Sơn Trà…viếng Linh Ứng Tự và thưởng ngoạn vẻ đẹp của 
  biển Mỹ Khê (được đánh giá là một trong những bãi biển quyến rũ nhất hành 
  tinh).</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  khởi hành đến Huế qua đường hầm Hải Vân-hầm đường bộ dài nhất Đông Nam 
Á.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
&nbsp; Dùng cơm trưa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan Huế với Đại Nội – Hoàng Thành của 13 vị vua triều Nguyễn, nơi có hơn 100 
  công trình kiến trúc đẹp: Ngọ Môn, Điện Thái Hòa, Tử Cấm Thành, Thế Miếu, Hiển 
  Lâm Các, Cửu Đỉnh,…</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan chùa Thiên Mụ – &nbsp;ngôi chùa cổ nhất Cố đô Huế.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Hướng 
  dẫn viên tiễn đoàn ra sân bay Phú Bài, đón chuyến bay về TP.HCM.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Kết 
  thúc chương trình tham quan, chia tay và hẹn gặp lại.</LI></UL><BR 
style="BOX-SIZING: border-box"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Lưu ý khi tham gia 
tour:&nbsp;</STRONG><BR style="BOX-SIZING: border-box">✓ Quý khách vui lòng giữ 
khoảng cách và đảm bảo nguyên tắc 5K, khử khuẩn trong suốt hành trình.<BR 
style="BOX-SIZING: border-box">✓ Vận chuyển không quá 50% số ghế, không quá 20 
khách/1 xe (bao gồm cả tài xế), tuân thủ ngồi giãn cách trên xe, các điểm tham 
quan, ăn uống… và đeo khẩu trang suốt quá trình di chuyển.<BR 
style="BOX-SIZING: border-box">✓ Thẻ xanh covid (khách đã tiêm vaccine ngừa 
covid đủ liều, thời gian hoàn tất mũi 2 trước 14 ngày và không quá 12 tháng), 
khách là FO đã khỏi bệnh (có giấy chứng nhận của Sở Y Tế và không quá 06 
tháng).<BR style="BOX-SIZING: border-box">✓ Xét nghiệm covid theo yêu cầu của 
từng tỉnh vào thời điểm đặt dịch vụ. Vui lòng liên hệ với nhân viên tư vấn để 
biết thêm chi tiết.</DIV></DIV></DIV></DIV></DIV><FONT 
size=4></FONT></BODY></HTML>
',
CONVERT(DATETIME, '2022-05-24 21:16:29.000'),
CONVERT(DATETIME, '2022-05-24 21:16:29.000'),
'6684927',
'334246',
'1',
'1'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '4', 
  N'Du lịch Nha Trang - Đà Lạt', 
  N'Xe du lịch, máy bay',
  N'Tour Du lịch Đà Lạt Không phải tự nhiên mà du lịch Đà Lạt đang là một từ khóa “Hot” và được nhiều du khách quan tâm tìm kiếm. Nơi đây đã được thiên nhiên ưu ái ban tặng cho khung cảnh hoang sơ, khí hậu mát mẻ cùng những bờ biển xanh trong khiến nhiều người thích thú',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP. HCM – CÔN ĐẢO (Ăn trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng: Quý khách có mặt tại ga 
quốc nội, sân bay Tân Sơn Nhất trước giờ bay ít nhất một tiếng ba mươi 
phút.</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đại 
  diện công ty Du Lịch Việt đón và hỗ trợ làm thủ tục. Đáp máy bay đi Côn 
  Đảo.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Xe 
  và hướng dẫn Côn Đảo Resort, đón quý khách tại sân bay Côn Sơn. Đưa về Resort, 
  trên đường về quý khách đi qua các địa danh: làng Cỏ Ống, Lò Vôi, nghĩa địa 
  Hàng Keo…. Đến Resort, dùng cơm trưa, làm thủ tục nhận phòng theo quy định của 
  Resort, nghỉ ngơi.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">14h00: Quý khách thăm quan: 
(Thuyết minh viên: Bảo tàng).</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Bảo 
  tàng Côn Đảo</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trại 
  tù Phú Hải</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan chuồng cọ p Pháp.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Chuồng 
  cọp Mỹ</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Viếng 
  nghĩa trang Hàng Dương thắp hương tại đài tưởng niệm chung cho gần</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">20h00 ngôi mộ của các chiến sỹ 
yêu nước.</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đồng 
  chí Lê Hồng Phong, Cụ Nguyễn An Ninh</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Thắp 
  hương tại mộ nữ anh hùng Võ Thị Sáu</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khu 
  biệt lập chuồng bò</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Viếng 
  miếu Bà Phi Yến – thứ phi vua Nguyễn Ánh.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">17h30: Trở về resort, nghỉ 
ngơi.</STRONG></DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">18h00: Quý khách dùng cơm 
chiều.</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách viếng mộ nữ anh hùng<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Võ Thị 
  Sáu</STRONG><SPAN>&nbsp;</SPAN>(chi phí tự túc)</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>KHÁM PHÁ CÔN ĐẢO ( Ăn sáng, trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng: Dùng bữa 
sáng.&nbsp;</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách tham quan bãi biển Đầm Trầu – một trong những bãi tắm hoang sơ và đẹp 
  nhất Côn Đảo. Từ đường chính, Quý khách đi bộ theo &nbsp;đường mòn khoảng 
  1,5km đến bãi tắm. Trên đường đi, quý khách dừng chân thắp nhang tại Miếu Cậu 
  - nơi thờ hoàng tử Cải, con trai của chúa Nguyễn Ánh và bà Hoàng Phi Yến. Đến 
  bãi Đầm Trầu, tắm biển, chụp hình, tham gia các trò chơi trên biển do Hướng 
  dẫn Côn Đảo Resort tổ chức.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trở 
  về Resort dùng cơm trưa.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">14h00: &nbsp;Khởi hành tham 
quan cảng Bến Đầm Cảng lớn nhất Côn Đảo&nbsp;</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Mũi 
  Cá Mập.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Bãi 
  Nhất.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Ngắm 
  đỉnh Tình Yêu, tìm hiểu tập quán của ngư dân Côn Đảo.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Mua 
  hải sản tại cảng Bến Đầm.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách thăm quan Chùa Núi Một, ngồi chùa duy nhất đã được xây dự ng lại mới, 
  với kiến trúc mang đậm phong cách phật giáo Phương Đông, nằm trên một ngọn 
  núi. Từ đây quý khách có thể quan sát toàn cảnh thị trấn Côn Đảo. Quý khách 
  tiếp tục thăm quan Chợ Côn Đảo, mua hải sản và quà lưu niệm tặng người 
  thân.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">17h00: Trở về Resort, tự do tắm 
biển,chèo thuyền Kajak,chơi golf hay tennis,…(chi phí tự túc)</STRONG><BR 
style="BOX-SIZING: border-box"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">18h00: Quý khách &nbsp;dùng cơm 
chiều.</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tối: 
  Quý khách tự do dạo phố biển, ngắm biển lúc về đêm.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>CÔN ĐẢO - TPHCM ( Ăn sáng)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">06h30: 
  Quý khách dùng bữa sáng.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">10h00: 
  Làm thủ tục trả phòng, xe đưa đoàn ra sân bay làm thủ tục hàng 
  không.&nbsp;</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành về TP.HCM chia tay và hẹn gặp 
lại.</LI></UL></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-06-02 22:27:53.000'),
CONVERT(DATETIME, '2022-06-04 22:27:53.000'),
'4644167',
'278650',
'1',
'3'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '5', 
  N'Du lịch Châu Đốc - Hà Tiên - Cần Thơ', 
  N'Xe du lịch, máy bay',
  N'Đến với hành trình du Lịch Miền Tây 4 ngày của Du Lịch Việt, du khách sẽ được khám phá nét thanh bình, yên ả của làng quê, chìm đắm trong nét văn hóa ẩm thực tinh tế đầy màu sắc đặc trưng của miền sông nước',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; BORDER-BOTTOM: 1px solid; FONT-WEIGHT: 700; PADDING-BOTTOM: 10px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 10px; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HCM –&nbsp;TIỀN GIANG – CHÂU ĐỐC ( ăn sáng, trưa, 
chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:</STRONG><SPAN>&nbsp;</SPAN>Xe 
và HDV Công Ty Du Lịch Việt đón Quý khách tại điểm hẹn.&nbsp;</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách dùng bữa sáng tại Trung Lương.&nbsp;</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đến 
  Mỹ Tho, Đoàn xuống bến đò 30/04, Quý khách xuống thuyền thưởng ngoạn cảnh sông 
  nước miền Tây Nam Bộ với 4 cù lao: Long, Lân , Quy, Phụng, thưởng thức hương 
  vị ngọt ngào của trái dừa xiêm.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Thuyền 
  đưa đoàn đi tham quan cù lao Thới Sơn, đi bộ trên đường làng, tham quan trại 
  nuôi ong mật, uống trà mật ong, thưởng thức các loại mứt đặc sản. Tham quan 
  vườn cây ăn trái, thưởng thức các loại trái cây tại vườn, nghe nhạc tài tử Nam 
  Bộ. Đi xuồng chèo trong rạch dừa nước thiên nhiên.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Thuyền 
  lớn đưa khách sang Bến Tre tham quan lò kẹo dừa nổi tiếng Bến Tre.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan Cồn Phụng ( Di tích Ông Đạo Dừa).</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:<SPAN>&nbsp;</SPAN></STRONG>Dùng 
cơm trưa.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Xe 
  tiếp tục đưa đoàn đếnĐồng Tháp, đoàn qua phà Vàm Cống, đến Long 
  Xuyên.&nbsp;</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đến 
  Châu Đốc nhận phòng nghỉ ngơi. Quý khách dùng cơm chiều tại nhà hàng.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Chiều:<SPAN>&nbsp;</SPAN></STRONG>Nghỉ 
đêm khách sạn tại Châu Đốc.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>MIẾU BÀ CHÚA XỨ – CHỢ CHÂU ĐỐC – KIÊN GIANG (Ăn sáng, 
trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:</STRONG><SPAN>&nbsp;</SPAN>Ăn 
sáng tại khách sạn</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Xe 
  đưa Đoàn viếng miếu Bà Chúa Xứ.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Mua 
  sắm chợ Châu Đốc với hơn 30 loại mắm: mắmThái, mắm sặt, mắm trê, mắm lóc, mắm 
  rô, mắm trèn, mắm cá linh, mắm phi lê, dưa mắm…tại chợ Châu Đốc.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:</STRONG><SPAN>&nbsp;</SPAN>Dùng 
cơm trưa.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  khởi hành tham quan Núi Cấm hay còn gọi là Thiên Cẩm Sơn có độ cao 705m so với 
  mặt nước biển, là ngọn núi cao nhất trong Thất Sơn. Núi có dáng vẻ hùng vĩ, 
  khí hậu mát mẻ, phong cảnh đẹp và cây cối luôn xanh tươi. Trên núi có các danh 
  lam và danh thắng như: Chùa Vạn Linh, chùa Phật Lớn, tượng Phật Di Lặc, hồ 
  Thủy Liêm.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  khởi hành đến Hà Tiên, ngắm hòn Phụ Tử - nơi có hai trụ đá cao nghiêng nghiêng 
  cùng một chiều tượng trưng cho hình hai cha con quấn quýt bên nhau trông ra 
  biển cả.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Tối:<SPAN>&nbsp;</SPAN></STRONG>Quý 
khách dùng bữa tối. Nghỉ đêm tại Hà Tiên.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>LĂNG MẠC CỬU – PHÙ DUNG CỔ TỰ – CẦN THƠ&nbsp;(Ăn 
sáng, trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:</STRONG><SPAN>&nbsp;</SPAN>Ăn 
sáng tại khách sạn</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  tiếp tục viếng Lăng Mạc Cửu, viếng Phù Dung Cổ Tự, nghe kể về gia phả họ Mạc, 
  có công khai trấn đất Hà Tiên vào thế kỷ XVIII.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Viếng 
  Chùa Tam Bảo (còn gọi là chùa Tiêu, Sắc Tứ Tam Bảo Tự) là một trong 10 cảnh 
  đẹp từng được Mạc Thiên Tứ ca ngợi qua bài vịnh Tiêu Tự Thần Chung</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:</STRONG><SPAN>&nbsp;</SPAN>Đoàn 
dùng cơm trưa. Đoàn khởi hành đến Cần Thơ.</P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Tối:<SPAN>&nbsp;</SPAN></STRONG>Dùng 
cơm tối. Nghỉ đêm Cần Thơ.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 4 
|</SPAN><SPAN>&nbsp;</SPAN>CẦN THƠ – CHỢ NỔI CÁI RĂNG – TP.HCM (Ăn sáng, 
trưa)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; FONT-FAMILY: Arial; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 5px; FONT-STYLE: normal; PADDING-TOP: 5px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(243,243,243); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"></P>
<DIV 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(243,243,243); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:</STRONG><SPAN>&nbsp;</SPAN>Du 
khách đến bến Ninh Kiều: Thuyền đưa du khách tham quan chợ nổi Cái Răng với cảnh 
nhộn nhịp buôn bán trên sông, một nét văn hóa rất đặc sắc ở vùng đồng bằng sông 
nước Cửu Long.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; FONT-SIZE: 15px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 10px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 0px 10px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(243,243,243); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Về 
  lại khách sạn, dùng bữa sáng.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Viếng 
  thăm Thiền Viện Trúc Lâm Phương Nam được xem là một trong những công trình 
  nghệ thuật độc đáo của đất Tây Đô - ngôi chùa rộng nhất khu vực Đồng bằng sông 
  Cửu Long, được xây dựng trên diện tích gần 4 ha, với kết cấu lợp ngói, khung 
  cột gỗ lim, chánh điện rộng cùng nhà tổ, nhiều tượng Phật được làm bằng gỗ Du 
  Sam.&nbsp;</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; FONT-FAMILY: Arial; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 5px; FONT-STYLE: normal; PADDING-TOP: 5px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(243,243,243); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"></P>
<P 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; FONT-FAMILY: Arial; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 5px; FONT-STYLE: normal; PADDING-TOP: 5px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(243,243,243); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"></P>
<DIV 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(243,243,243); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:<SPAN>&nbsp;</SPAN></STRONG>Dùng 
cơm trưa.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; FONT-SIZE: 15px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 10px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 0px 10px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(243,243,243); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành về TP.HCM trên dừng chân tham quan cầu treo Mỹ Thuận, tiếp tục lộ trình 
  về đến TP.HCM.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Kết 
  thúc hành trình tour, Chào tạm biệt và hẹn gặp lại.</LI></UL><BR 
class=Apple-interchange-newline></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-05-24 22:31:03.000'),
CONVERT(DATETIME, '2022-05-24 22:31:03.000'),
'3477078',
'173853',
'1',
'1'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '6', 
  N'Du lịch Quảng Ngãi - Đảo Lý Sơn - Đảo Bé - Vương Quốc Tỏi', 
  N'Xe du lịch, máy bay',
  N'Lý Sơn được mệnh danh là Vương Quốc Tỏi, là hòn ngọc giữa biển khơi, thiên đường của lữ khách. Ai đã một lần đến Lý Sơn đều vấn vương như nhớ một chuyện tình. Bạn đã từng một lần đến với đất đảo? Dù có hay chưa, huyện đảo tiền tiêu này cũng luôn ngóng chờ bạn khám phá.',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HCM – SÂN BAY CHU LAI - ĐẢO LÝ SƠN (Ăn trưa, 
chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:</STRONG><SPAN>&nbsp;</SPAN>Quý 
khách có mặt tại ga quốc nội, sân bay Tân Sơn Nhất trước giờ bay ít nhất ba 
tiếng.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đại 
  diện công ty Du Lịch Việt đón và hỗ trợ Quý Khách làm thủ tục đón chuyến bay 
  đi Lý Sơn. &nbsp;&nbsp; &nbsp;Đến sân bay Chu Lai, Hướng dẫn viên đón đoàn 
  khởi hành đến Cảng Sa Kỳ, hướng dẫn viên làm thủ tục cho đoàn lên tàu ra đảo 
  Lý Sơn.&nbsp;</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:</STRONG><SPAN>&nbsp;</SPAN>Dùng 
bữa trưa. Đoàn về nhận phòng nghỉ ngơi .</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  tiếp tục &nbsp;tham quan danh lam thắng cảnh đẹp bậc nhất tại đảo đó là: Chùa 
  Hang hay còn gọi là “Thiên khổng thạch tự “ nôm na là chùa nằm trong hang ,nó 
  được hình thành vô cùng độc đáo do quá trình phun trào núi lửa và quá trình 
  xâm thực nước biển năm xưa tạo thành, trước chùa là 1 khung cảnh đầy thơ mộng 
  với hàng cây Bàng Vuông cổ thụ hàng trăm năm, bãi biển là dãy cát san hô dài 
  trắng xóa nước trong như thạch .</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  tham quan Cột Cờ Chủ Quyền nằm trên đỉnh núi Thới Lới, ở đây chúng ta có thể 
  chiêm ngưỡng vẻ đẹp toàn cảnh của đảo Lý Sơn. &nbsp; &nbsp; &nbsp; &nbsp;</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Điểm 
  tham quan tiếp theo trên đào là &nbsp;Hang Câu, &nbsp;là một hang động to nằm 
  dưới vách núi của đỉnh Thới Lới, bên trên vách núi có đàn hải âu tung cách và 
  &nbsp;khi chiều về quý khách sẽ được chiêm ngưỡng ánh hoàng hôn tuyệt đẹp ,và 
  &nbsp;trước hang là bãi cát san hô dài với làn nước trong xanh, chúng kết hợp 
  với nhau tạo nên một khung cảnh thơ mộng và tuyệt đẹp. &nbsp; &nbsp;</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Chiều:</STRONG><SPAN>&nbsp;</SPAN>Dùng 
bữa chiều. Nghỉ đêm tại Lý Sơn</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tự 
  do khám phá đảo buổi tối.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>KHÁM PHÁ ĐẢO BÉ VÀ PHÍA TÂY ĐẢO LỚN (Ăn sáng, trưa, 
chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:</STRONG><SPAN>&nbsp;</SPAN>Dùng 
bữa sáng với món đặc sản trên đào&nbsp;</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Hướng 
  dẫn viên đưa quý khách đến với Đảo Bé, nơi đây được mệnh danh là Maldives của 
  Việt Nam tại đây quý khách có thể thoải mái tắm biển dưới làn nước trong xanh 
  và cùng nhau khám phá rạn san hô tuyệt đẹp của đảo, bãi cát trắng mịn kết hợp 
  với hàng dừa cao ngút tạo nên một vẻ đẹp hoang sơ vô cùng đẹp.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:</STRONG><SPAN>&nbsp;</SPAN>Dùng 
bữa trưa. Đoàn về nhận phòng nghỉ ngơi&nbsp;</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Hướng 
  dẫn viên tiếp tục đưa đoàn đi tham quan khám phá đảo Lý Sơn với các địa danh 
  sau: bắt đầu tham quan điểm đầu tiên đó là : nhà trưng bày Hải Đội Hoàng Sa 
  Bắc Hải, là nơi lưu giữ hơn hàng trăm hiện vật của những hùng binh năm xưa thể 
  hiện chủ quyền biển đảo với hai quần đảo Trường Sa và Hoàng Sa.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  tham quan ngôi chùa thứ hai đó là: Chùa Đục, là ngôi chùa vô cùng độc đáo của 
  đảo &nbsp;nằm trên đỉnh núi Giáng Tiền. Thạch Cổng Tò Vò, là nơi có cấu tạo 
  địa chất rất độc đáo, về chiều cảnh hoàng hôn buông xuống tạo nên một khung 
  cảnh đẹp như tranh vẻ, sẽ làm cho du khách vô cùng thích thú.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Chiều:</STRONG><SPAN>&nbsp;</SPAN>Dùng 
bữa chiều. Nghỉ đêm tại Lý Sơn</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tự 
  do khám phá đảo buổi tối.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>LÝ SƠN – CẢNG SA KỲ - CHU LAI – HỒ CHÍ MINH (Ăn sáng, 
trưa)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:</STRONG><SPAN>&nbsp;</SPAN>Dùng 
bữa sáng với món đặc sản trên đào</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách tự do nghỉ ngơi tại khách sạn hoặc mua sắm đặc sản địa phương về làm quà 
  cho gia đình, người thân.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:<SPAN>&nbsp;</SPAN></STRONG>Dùng 
bữa trưa.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  trả phòng lên tàu về lại cảng Sa Kỳ&nbsp;</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Hướng 
  dẫn viên tiễn đoàn ra sân bay Chu Lai &nbsp;đón chuyến bay về TP.HCM.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Kết 
  thúc chương trình tham quan, chia tay và hẹn gặp 
lại.</LI></UL></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-07-06 22:33:16.000'),
CONVERT(DATETIME, '2022-07-08 22:33:16.000'),
'6228327',
'4359821',
'1',
'2'
);


INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '7', 
  N'Du lịch Hè - Tour Du lịch Đà Nẵng - Huế - Thánh Địa La Vang - Động Thiên Đường', 
  N'Xe du lịch, máy bay',
  N'Tour Du lịch Đà Nẵng được thiên nhiên đặc biệt ưu đãi, mảnh đất miền Trung đẹp với nhiều dãy núi hùng vỹ xanh rì, những bờ biển cát trắng mịn thoai thoải và những dòng sông trong vắt thơ mộng.',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HCM – ĐÀ NẴNG – HỘI AN (ăn trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
&nbsp;Quý khách có mặt tại ga quốc nội, sân bay Tân Sơn Nhất trước giờ bay ít 
nhất ba tiếng.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đại 
  diện công ty Du Lịch Việt đón và hỗ trợ Quý Khách làm thủ tục đón chuyến bay 
  đi Đà Nẵng.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đến 
  sân bay Đà Nẵng, Hướng dẫn viên đón đoàn Tham quan Ngũ Hành Sơn - được ví như 
  hòn non bộ khổng lồ giữa lòng thành phố Đà Nẵng với Động Huyền Không, Chùa 
  Linh Ứng, Chùa Tam Thai, Vọng Hải Đài, … mua sắm quà lưu niệm tại làng nghề 
  điêu khắc đá Non Nước.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa: Dùng bữa trưa tại nhà 
hàng.</STRONG></P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan Phố Cổ Hội An - di sản văn hoá thế giới với Chùa Cầu Nhật Bản, Hội Quán 
  Phúc Kiến, Nhà Cổ Phùng Hưng, …</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Chiều: Dùng cơm chiều tại nhà 
hàng. Nghỉ đêm tại Đà Nẵng.</STRONG></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>BÀ NÀ – LĂNG KHẢI ĐỊNH – HUẾ (ăn sáng, chiều) (Ăn 
trưa tự túc)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng: &nbsp;Dùng buffet sáng 
tại khách sạn.</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành đến với cao nguyên Bà Nà nơi có khí hậu Châu Âu độc đáo và nổi tiếng với 
  tuyến cáp treo kỷ lục mới của thế giới - Ngắm toàn cảnh thành phố Đà Nẵng từ 
  trên cáp treo (chi phí cáp treo tự túc).</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách tự do tham quan, vui chơi giải trí tại Bà Nà với Công Viên Fantasy, Rạp 
  chiếu phim 3D Mega 360 độ với công nghệ hiện đại nhất và duy nhất có ở Viêt 
  Nam, Hai rạp chiếu phim 4D và 5Di, Xe Trượt Ống, Hầm rượu, Vườn hoa tình yêu, 
  Bảo Tàng Sáp.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa:&nbsp; &nbsp;Quý khách tự 
túc dùng bữa trưa.</STRONG></P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Du 
  khách có thể tìm thấy những biểu tượng mang tính tâm linh như chùa chiền, đền 
  đài hay tượng các đức Phật. Chắc hẳn sẽ là điểm dừng chân cho những ai mong 
  cầu bình an và sức khỏe cho gia đình: Chùa Linh Ứng, Đền Lĩnh Chúa Linh Từ, 
  Tháp Linh Phong Tự, Tượng Thích Ca Mâu Ni, Lầu Chuông, Nhà Bia, Miếu Bà, Trú 
  Vũ Trà Quán.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành đến Huế qua đường hầm Hải Vân - hầm đường bộ dài nhất Đông Nam Á.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan Lăng Khải Định (Ứng Lăng, lăng mộ của vua Khải Định, vị vua thứ 12 của 
  triều Nguyễn) với lối kiến trúc độc đáo bởi sự pha trộn kiến trúc Đông Tây Kim 
  Cổ lạ thường, với các tác phẩm nghệ thuật ghép tranh sành sứ độc đáo.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Chiều: &nbsp;Dùng cơm chiều tại 
nhà hàng. Nghỉ đêm tại Huế.</STRONG></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>HUẾ – QUẢNG BÌNH – THIÊN ĐƯỜNG (ăn sáng, trưa, 
chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Sáng:&nbsp;Dùng buffet sáng tại 
khách sạn.</STRONG></DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  khởi hành đến đến Quảng Bình nổi tiếng với Vườn quốc gia Phong Nha - Kẻ 
  &nbsp;Bàng được UNESCO công nhận là Di sản thiên nhiên thế giới.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa: Dùng bữa trưa tại nhà 
hàng.</STRONG></P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan Động Thiên Đường được mệnh danh là "hoàng cung trong lòng đất", một trong 
  những kỳ quan tráng lệ và huyền ảo bậc nhất thế giới, động nằm ẩn mình sâu 
  trong lòng Vườn quốc gia Phong Nha Kẻ Bàng – được hiệp hội Hang động Hoàng Gia 
  Anh khám phá từ năm 2005, hang có độ dài 31km đứng đầu trong bảng xếp hạng 
  hang động quốc tế về sự huyền bí, kỳ vĩ của kiến tạo tự nhiên.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Chiều: &nbsp;Dùng cơm chiều tại 
nhà hàng. Nghỉ đêm tại Quảng Bình.</STRONG></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 4 
|</SPAN><SPAN>&nbsp;</SPAN>HUẾ – ĐẠI NỘI – TP.HCM (ăn sáng, trưa)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng:&nbsp;&nbsp; 
&nbsp; &nbsp;Dùng buffet sáng tại khách sạn.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Khởi 
  hành về Huế, trên đường đi Quý khách có dịp ngắm nhìn Vĩ Tuyến 17 với Cầu Hiền 
  Lương và dòng sông Bến Hải.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  vào thăm Thánh Địa La Vang – Tiểu vương cung thánh đường.&nbsp;</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa: Dùng bữa trưa tại nhà 
hàng.</STRONG></P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan Đại Nội – Hoàng Thành của 13 vị vua triều Nguyễn, nơi có hơn 100 công 
  trình kiến trúc đẹp: Ngọ Môn, Điện Thái Hòa, Tử Cấm Thành, Thế Miếu, Hiển Lâm 
  Các, Cửu Đỉnh, …</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan chùa Thiên Mụ – &nbsp;ngôi chùa cổ nhất Cố đô Huế.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Hướng 
  dẫn viên tiễn đoàn ra sân bay Phú Bài đón chuyến bay về &nbsp;TP.HCM.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Kết 
  thúc chương trình tham quan, chia tay và hẹn gặp 
lại.</LI></UL></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-06-13 22:35:17.000'),
CONVERT(DATETIME, '2022-05-16 22:35:17.000'),
'6871155',
'5496921',
'1',
'3'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '8', 
  N'Du lịch Hè - Tour Du lịch Buôn Ma Thuột - Làng Cà Phê Trung Nguyên', 
  N'Xe du lịch, máy bay',
  N'Khám phá Buôn Ma Thuột, Cà phê Trung Nguyên',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HỒ CHÍ MINH – ĐẮK LẮK –&nbsp;BUÔN MA THUỘT (ăn 
sáng, trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
Xe và Hướng Dẫn Viên Du Lịch Việt đón Quý khách tại điểm hẹn khởi hành 
đi<SPAN>&nbsp;</SPAN><STRONG style="BOX-SIZING: border-box; FONT-WEIGHT: 700">du 
lịch hè Buôn Mê Thuột 2019</STRONG><SPAN>&nbsp;</SPAN>- Đắk Lắk.<BR 
style="BOX-SIZING: border-box">Trên đường, đoàn nghe thuyết minh về các địa danh 
nổi tiếng đi ngang qua như Đồng Xoài, Sóc Bom Bo, Bù Đăng và cảnh núi rừng hùng 
vĩ.</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
Dùng cơm trưa. Đoàn bắt đầu chuyến&nbsp;<STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">du lịch mùa hè Buôn Mê Thuột 
giá rẻ</STRONG>&nbsp;với hành trình&nbsp;&nbsp;tham quan thác Đray Nưr với vẻ 
đẹp thơ mộng và bí ẩn của ngọn thác hùng vĩ nhất Tây Nguyên.<BR 
style="BOX-SIZING: border-box">Đoàn tiếp tục hành 
trình<SPAN>&nbsp;</SPAN><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">tour mùa hè Buôn Mê 
Thuột</STRONG>.</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tối: 
Dùng cơm tối. Nghỉ đêm tại Buôn Ma Thuột. Quý khách tự do nghỉ ngơi tại khách 
sạn hoặc khám phá&nbsp;<STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">tour Buôn Mê Thuột mùa 
hè</STRONG><SPAN>&nbsp;</SPAN>với chương trình&nbsp;dạo phố núi, thưởng thức đặc 
sản “ly cà phê Ban Mê”, mua sắm tại chợ đêm.</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>BUÔN MA THUỘT– BUÔN AKÔ ĐHÔNG – BUÔN ĐÔN (ăn sáng, 
trưa, chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
Dùng bữa sáng. Đoàn tiếp tục&nbsp;<STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">tour Buôn Mê Thuột mùa hè giá 
rẻ 2019&nbsp;</STRONG>đến tham quan Làng cà phê Trung Nguyên, nơi trải nghiệm về 
cà phê và những giá trị của cà phê. Đến đây Quý khách có thể khám phá, tìm hiểu 
thêm về các loại cà phê, lịch sử phát triển của ngành chế biến cà phê và thưởng 
thức hương vị cà phê.<BR style="BOX-SIZING: border-box">Tham quan Buôn AKô Đhông 
là một buôn làng của người Ê Đê – buôn làng có lịch sử lâu đời nhất tại Buôn Ma 
Thuột. nổi tiếng giàu có với những nhà ngói khang trang, sang trọng. Dấu vết chế 
độ mẫu hệ ở nơi đây còn lưu lại qua chiếc thang gỗ bắt lên sàn nhà chạm 2 bầu 
vú. Điều đặc biệt là có hai thang để lên nhà, nam giới và khách đi thang trước, 
thang sau dành cho phụ nữ.</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
Đoàn khởi hành đi Buôn Đôn, dùng cơm trưa. Đoàn tham quan Buôn Ðôn, nơi chung 
sống của cộng đồng các sắc tộc: Ê Ðê, M’nông, Gia rai, Lào, Thái, Quý khách được 
dịp trải nghiệm cảnh sinh hoạt của buôn làng, thưởng thức những món ăn đặc sản 
của vùng Tây Nguyên trù phú (chi phí tự túc) và đặc biệt là được ngắm ngôi nhà 
dài hàng trăm mét của đồng bào Tây Nguyên.<BR style="BOX-SIZING: border-box">Quý 
khách trải nghiệm cảm giác thú vị với cái lắc lư nghiêng ngã của cầu treo Buôn 
Đôn, với chiếc cầu treo dài trên 100m bắc ngang lưng chừng những rặng si già 
vượt qua dòng sông dữ đến ốc đảo Ea Nô, với bãi tắm tiên, hệ thống nhà hàng, nhà 
nghỉ ...<BR style="BOX-SIZING: border-box">Tham quan nhà sàn cổ được xây dựng 
theo kiến trúc Lào đã tồn tại trên 120 năm, tham quan mộ Vua săn voi “KhunJuNốp” 
và nghe chuyện kể về Vua săn voi.</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tối: 
Đoàn trở về Buôn Ma Thuột, dùng cơm tối. Nghỉ đêm tại Buôn Ma 
Thuột.</P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>CHÙA SẮC TỨ KHẢI ĐOAN – BẢO TÀNG DÂN TỘC – TP.HCM (ăn 
sáng, trưa)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
Dùng bữa sáng.<BR style="BOX-SIZING: border-box">Viếng thăm chùa Chùa Khải Đoan 
(Sắc tứ Khải Đoan tự) - ngôi chùa lớn nhất thành phố Buôn Ma Thuột, Chùa do Đoan 
Huy hoàng thái hậu mẹ vua Bảo Đại cho xây dựng và Nam Phương Hoàng Hậu trực tiếp 
chịu trách nhiệm quản lý việc thi công. Là ngôi chùa cuối cùng tại Việt Nam được 
phong sắc tứ của chế độ phong kiến.<BR style="BOX-SIZING: border-box">Tham quan 
Bảo tàng văn hóa các dân tộc Đăk Lăk - xây dựng ngay trên phần đất Biệt điện Bảo 
Đại – một di tích lịch sử của Đăk Lăk, là một công trình kiến trúc văn hóa được 
xây dựng theo phong cách hiện đại kết hợp với truyền thống văn hóa dân tộc đặc 
trưng của đồng bào Tây Nguyên – Biệt điện vừa có dáng nhà rông, lại có dáng nhà 
sàn của người Êđê hơn nữa lại có dáng nhà trệt của người M’Nông.&nbsp;</DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
Dùng cơm trưa.&nbsp;<BR style="BOX-SIZING: border-box">Đoàn khởi hành về TP.HCM, 
kết thúc chuyến đi, chia tay đoàn và hẹn gặp lại Quý 
khách.</DIV></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-07-11 22:37:19.000'),
CONVERT(DATETIME, '2022-07-13 22:37:19.000'),
'2973218',
'1189280',
'1',
'2'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '9', 
  N'Tour Du lịch Sapa - Bản Cát Cát - Hàm Rồng - Fansipan', 
  N'Xe du lịch, máy bay',
  N'Sự lựa chọn hàng đầu của những du khách muốn khám phá xứ sở sương mù. Nơi đây còn được du khách gọi bằng cái tên thân quen "thiên đường du lịch Sapa". Sapa không chỉ thu hút du khách về mùa đông mà còn hấp dẫn du khách về mùa xuân.',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>TP.HCM – HÀ NỘI – LÀO CAI – HÀM RỒNG – SAPA (Ăn trưa, 
chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
Quý khách có mặt tại<SPAN>&nbsp;</SPAN><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">ga quốc nội, sân bay Tân Sơn 
Nhất</STRONG><SPAN>&nbsp;</SPAN>trước giờ bay ít nhất ba tiếng.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đại 
  diện công ty Du Lịch Việt đón và hỗ trợ Quý Khách làm thủ tục đón chuyến bay 
  đi<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Hà Nội</STRONG>. Đến sân bay 
  Nội Bài, Hướng dẫn viên đón đoàn khởi hành đến<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Lào 
  Cai</STRONG><SPAN>&nbsp;</SPAN>trên con đường cao tốc dài nhất Việt Nam - mạch 
  nối liền giữa Hà Nội và các tỉnh Tây Bắc.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
Dùng bữa trưa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  tiếp tục đến<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">thị trấn vùng cao 
  Sapa</STRONG>, tận hưởng cảnh sắc núi rừng như tranh vẽ và khám phá cuộc sống 
  của đồng bào dân tộc ít người miền Tây Bắc.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: center; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><IMG 
style="BOX-SIZING: border-box; MAX-WIDTH: 100%; BORDER-TOP: 0px; HEIGHT: 389px; BORDER-RIGHT: 0px; WIDTH: 700px; VERTICAL-ALIGN: middle; BORDER-BOTTOM: 0px; BORDER-LEFT: 0px" 
alt="" 
src="https://dulichviet.com.vn/images/bandidau/NOI-DIA/Sapa/du-lich-he-sapa-gia-tot-du-lich-viet-2022.jpg"><BR 
style="BOX-SIZING: border-box">&nbsp;</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tham 
  quan và chinh phục núi<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Hàm 
  Rồng</STRONG><SPAN>&nbsp;</SPAN>với vườn lan, vườn đào, rừng đá, sân mây, lên 
  đến<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Cổng trời</STRONG>, ngắm toàn 
  cảnh Sapa trong sương mờ.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">&nbsp;</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: center; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><IMG 
style="BOX-SIZING: border-box; MAX-WIDTH: 100%; BORDER-TOP: 0px; HEIGHT: 389px; BORDER-RIGHT: 0px; WIDTH: 700px; VERTICAL-ALIGN: middle; BORDER-BOTTOM: 0px; BORDER-LEFT: 0px" 
alt="" 
src="https://dulichviet.com.vn/images/bandidau/NOI-DIA/Sapa/tour-du-lich-sapa-du-lich-he-du-lich-viet-2022.jpg"></DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Chiều: 
Dùng bữa chiều. Nghỉ đêm tại Sapa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Tự 
  do dạo phố, tham quan nhà thờ đá Sapa, tham dự đêm chợ Tình (nếu đi vào tối 
  thứ 7).&nbsp;</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 2 
|</SPAN><SPAN>&nbsp;</SPAN>SAPA – FANSIPAN – BẢN CÁT CÁT (Ăn sáng, trưa, 
chiều)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
Dùng buffet sáng tại khách sạn.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  khởi hành tham quan chinh phục<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Fansipan</STRONG>, ngọn núi 
  cao nhất Việt Nam (3.143 m) thuộc dãy núi Hoàng Liên Sơn, cách thị trấn Sa Pa 
  khoảng 9 km về phía tây nam. Du khách chinh phục "Nóc nhà Đông Dương" với hệ 
  thống cáp treo Fansipan Sa Pa dài 6,2km đạt 2 kỷ lục Guinness thế giới: Cáp 
  treo ba dây có độ chênh giữa ga đi và ga đến lớn nhất thế giới: 1410m và Cáp 
  treo ba dây dài nhất thế giới: 6292.5m. Từ tuyến cáp treo, du khách có thể cảm 
  nhận được thiên nhiên hùng vĩ, chiêm ngưỡng khung cảnh thung lũng Mường Hoa và 
  rừng quốc gia Hoàng Liên từ trên cao. Ngoài ra, du khách còn có thể đến hành 
  hương tại<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Khu du lịch tâm linh – Chùa 
  Trình, Chùa Hạ</STRONG><SPAN>&nbsp;</SPAN>tại ga đến (chi phí cáp treo tự 
  túc).</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
Dùng bữa trưa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Thăm 
  bản<SPAN>&nbsp;</SPAN><STRONG 
  style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Cát Cát</STRONG>, tìm hiểu 
  nghề dệt nhuộm của dân tộc H’Mông và trạm thủy điện Cát Cát thời Pháp – nơi có 
  3 dòng nước hợp nhau thành dòng suối Mường Hoa.</LI></UL>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: center; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><IMG 
style="BOX-SIZING: border-box; MAX-WIDTH: 100%; BORDER-TOP: 0px; HEIGHT: 389px; BORDER-RIGHT: 0px; WIDTH: 700px; VERTICAL-ALIGN: middle; BORDER-BOTTOM: 0px; BORDER-LEFT: 0px" 
alt="" 
src="https://dulichviet.com.vn/images/bandidau/NOI-DIA/Sapa/kham-pha-ban-cat-cat-du-lich-viet.jpg"></DIV>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Chiều: 
Dùng bữa chiều. Nghỉ đêm tại Sapa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách có thể dạo phố đêm Sapa, thưởng thức đặc sản vùng cao như: thịt lợn cấp 
  nách nướng, trứng nướng, rượu táo mèo, giao lưu với người dân tộc vùng 
  cao.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P></DIV></DIV></DIV>
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 3 
|</SPAN><SPAN>&nbsp;</SPAN>SAPA – HÀ NỘI – TP.HCM (Ăn sáng, trưa)</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Sáng: 
Dùng buffet sáng tại khách sạn.</DIV>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Quý 
  khách tự do nghỉ ngơi tại khách sạn.</LI></UL>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Trưa: 
Dùng bữa trưa.</P>
<UL 
style="LIST-STYLE-TYPE: disc; BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 10px; MARGIN: 0px 0px 0px 10px; PADDING-RIGHT: 0px">
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Đoàn 
  khởi hành về Hà Nội.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Hướng 
  dẫn viên tiễn đoàn ra sân bay Nội Bài đón chuyến bay về &nbsp;TP.HCM.</LI>
  <LI 
  style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Kết 
  thúc chương trình tham quan, chia tay và hẹn gặp 
lại.</LI></UL></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-05-26 22:40:00.000'),
CONVERT(DATETIME, '2022-05-29 22:40:00.000'),
'6506478',
'3253230',
'1',
'4'
);

INSERT INTO Tours(id, name, transport, short_desc, detail_desc, departureDate, returnDate, price_adult_one_ticket, price_children_one_ticket, tour_status_id, tour_category_id) VALUES (
  '10', 
  N'Du lịch Hồ Chí Minh - Dinh Độc Lập - Bảo Tàng Lịch Sử', 
  N'Xe du lịch, máy bay',
  N'Nếu muốn tham quan hết những danh lam thắng cảnh và địa danh nổi tiếng ở Sài Gòn trong vòng 1 ngày thì city tour Sài Gòn sẽ là hành trình khám phá lý tưởng mà bạn đang tìm kiếm.',
  N'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML><HEAD>
<META content="text/html; charset=unicode" http-equiv=Content-Type>
<META name=GENERATOR content="MSHTML 11.00.10570.1001"></HEAD>
<BODY>
<DIV class=title 
style="BOX-SIZING: border-box; FONT-SIZE: 20px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; BORDER-BOTTOM: 1px solid; TEXT-TRANSFORM: none; FONT-WEIGHT: 700; COLOR: rgb(51,51,51); PADDING-BOTTOM: 10px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px 0px 10px; LETTER-SPACING: normal; LINE-HEIGHT: 30px; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial"><SPAN 
class=fa-map-o 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-LEFT: 30px">Lịch 
trình</SPAN></DIV>
<DIV class=content 
style="BOX-SIZING: border-box; FONT-SIZE: 14px; FONT-FAMILY: Muli, sans-serif; WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; FONT-WEIGHT: 400; COLOR: rgb(51,51,51); PADDING-BOTTOM: 0px; FONT-STYLE: normal; PADDING-TOP: 0px; PADDING-LEFT: 0px; ORPHANS: 2; WIDOWS: 2; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; font-variant-ligatures: normal; font-variant-caps: normal; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial">
<DIV class=listDay 
style="BOX-SIZING: border-box; POSITION: relative; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 30px; MARGIN: 0px; PADDING-RIGHT: 0px">
<DIV class="day active" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px 0px 15px; PADDING-RIGHT: 0px">
<DIV class=titDay 
style="BOX-SIZING: border-box; CURSOR: pointer; POSITION: relative; FONT-WEIGHT: 700; COLOR: rgb(255,255,255); PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(237,0,128); border-radius: 5px"><SPAN 
style="BOX-SIZING: border-box; FONT-SIZE: 18px; COLOR: rgb(255,255,255)">NGÀY 1 
|</SPAN><SPAN>&nbsp;</SPAN>Hồ Chí Minh - Dinh Độc Lập - Bảo Tàng Lịch Sử</DIV>
<DIV class=arrow-up 
style="BOX-SIZING: border-box; HEIGHT: 0px; BORDER-RIGHT: transparent 10px solid; WIDTH: 0px; BORDER-BOTTOM: rgb(243,243,243) 10px solid; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: transparent 10px solid; MARGIN: 2px 0px 0px 15px; PADDING-RIGHT: 0px"></DIV>
<DIV class=contDay 
style="BOX-SIZING: border-box; FONT-SIZE: 15px; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 10px; MARGIN: 0px; DISPLAY: block; PADDING-RIGHT: 10px; BACKGROUND-COLOR: rgb(243,243,243); border-radius: 5px">
<DIV class="the-content desc" 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">
<P 
style="BOX-SIZING: border-box; FONT-FAMILY: Arial; PADDING-BOTTOM: 5px; PADDING-TOP: 5px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"></P>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">Nếu 
muốn tham quan hết những danh lam thắng cảnh và địa danh nổi tiếng ở Sài Gòn 
trong vòng 1 ngày thì city tour Sài Gòn sẽ là hành trình khám phá lý tưởng mà 
bạn đang tìm kiếm. Đến với tour, du khách có cơ hội khám pBuổi Sáng: 08h00: Xe 
và HDV Du Lịch Việt đón Quý khách tại điểm hẹn. đưa quý khách tham quan &nbsp; 
Tp. HCM &nbsp;các điểm như sau .<BR style="BOX-SIZING: border-box">•&nbsp;&nbsp; 
&nbsp;<STRONG style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Bảo tàng chiến 
tích chiến tranh</STRONG>: Là nơi trưng bày những kỷ vật trong cuộc chiến đấu 
chống Mỹ cứu nước. Đến đây du khách sẽ được chiêm ngưỡng những cỗ máy chiến 
tranh thật hiện đại vào thời đó, như: xe tăng, máy bay chiến đấu, bom và súng 
đạn. Sau đó tham quan các gian nhà trưng bày hình ảnh như: “những sự thật lịch 
sử, bộ sưu tập ảnh phóng sự hoài nịêm, chứng tích tội ác và hậu quả chiến tranh 
xâm lược, chế độ lao tù trong chiến tranh xâm lược, nhân dân thế giới ủng hộ 
Việt Nam kháng chiến, tranh thiếu nhi “Chiến Tranh Và Hòa Bình”. Đặc biệt quý 
khách ghé thăm nơi được mệnh danh là Địa Ngục Trần Gian hay được gọi là “Chuồng 
Cọp”<BR style="BOX-SIZING: border-box"><BR 
style="BOX-SIZING: border-box">&nbsp;</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: center; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><IMG 
style="BOX-SIZING: border-box; MAX-WIDTH: 100%; BORDER-TOP: 0px; HEIGHT: 720px; BORDER-RIGHT: 0px; WIDTH: 1280px; VERTICAL-ALIGN: middle; BORDER-BOTTOM: 0px; BORDER-LEFT: 0px" 
alt="" 
src="https://dulichviet.com.vn/images/bandidau/images/bao-tang-chung-tich-chien-tranh-du-lich-viet.jpg"></DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><BR 
style="BOX-SIZING: border-box"><BR style="BOX-SIZING: border-box">•&nbsp;&nbsp; 
&nbsp;<STRONG style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Chùa Thiên 
Hậu</STRONG>: Hay còn được gọi là chùa Bà Chợ Lớn là một trong những ngôi chùa 
có lịch sử lâu đời nhất của người Hoa ở Thành phố Hồ Chí Minh. Bên cạnh giá trị 
về nghệ thuật kiến trúc, điêu khắc, hiện vật cổ, nơi đây còn có một giá trị 
khác, đó không chỉ là nơi đáp ứng nhu cầu tín ngưỡng mà còn là nơi qui tụ và 
tương trợ lẫn nhau của bà con người Việt gốc Hoa.<BR 
style="BOX-SIZING: border-box"><BR style="BOX-SIZING: border-box">&nbsp;</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: center; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><IMG 
style="BOX-SIZING: border-box; MAX-WIDTH: 100%; BORDER-TOP: 0px; HEIGHT: 444px; BORDER-RIGHT: 0px; WIDTH: 666px; VERTICAL-ALIGN: middle; BORDER-BOTTOM: 0px; BORDER-LEFT: 0px" 
alt="" 
src="https://dulichviet.com.vn/images/bandidau/images/du-lich-sai-gon-kham-pha-chua-ba-thien-mu-du-lich-viet.jpg"><BR 
style="BOX-SIZING: border-box">&nbsp;</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">&nbsp;</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Trưa Dùng cơm trưa.</STRONG><BR 
style="BOX-SIZING: border-box"><BR style="BOX-SIZING: border-box">•&nbsp;&nbsp; 
&nbsp;<STRONG style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Dinh Độc 
Lập</STRONG>: Nơi trước đây là tổng hành dinh của Mỹ đặt tại miền Nam Việt 
Nam.&nbsp;<BR style="BOX-SIZING: border-box">&nbsp;</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: center; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><IMG 
style="BOX-SIZING: border-box; MAX-WIDTH: 100%; BORDER-TOP: 0px; HEIGHT: 720px; BORDER-RIGHT: 0px; WIDTH: 1280px; VERTICAL-ALIGN: middle; BORDER-BOTTOM: 0px; BORDER-LEFT: 0px" 
alt="" 
src="https://dulichviet.com.vn/images/bandidau/images/dinh-doc-lap-du-lich-viet.jpg"><BR 
style="BOX-SIZING: border-box">&nbsp;</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px">•&nbsp;&nbsp; 
&nbsp;<STRONG style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Nhà thờ Đức 
Bà</STRONG>: Một tuyệt tác kiến trúc - một công trình tiêu biểu góp phần tạo nên 
diện mạo đô thị Sài Gòn - Thành phố Hồ Chí Minh. Công trình cũng ghi nhận sự du 
nhập, giao lưu và tiếp biến của văn hóa - kiến trúc Đông - Tây.</DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: center; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><IMG 
style="BOX-SIZING: border-box; MAX-WIDTH: 100%; BORDER-TOP: 0px; HEIGHT: 775px; BORDER-RIGHT: 0px; WIDTH: 620px; VERTICAL-ALIGN: middle; BORDER-BOTTOM: 0px; BORDER-LEFT: 0px" 
alt="" 
src="https://dulichviet.com.vn/images/bandidau/images/kham-pha-nha-tho-duc-ba-du-lich-viet(1).jpg"></DIV>
<DIV 
style="BOX-SIZING: border-box; PADDING-BOTTOM: 0px; TEXT-ALIGN: justify; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px"><BR 
style="BOX-SIZING: border-box">•&nbsp;&nbsp; &nbsp;<STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">Bưu điện Thành Phố</STRONG>: Là 
điểm đến tham quan không thể thiếu của du khách khi đến thành phố Hồ Chí Minh, 
một công trình kiến trúc cổ, có hơn 120 năm tuổi.<BR 
style="BOX-SIZING: border-box">•&nbsp;&nbsp; &nbsp;<STRONG 
style="BOX-SIZING: border-box; FONT-WEIGHT: 700">16h00</STRONG>: Xe đưa Quý 
khách về lại điểm đón ban đầu.</DIV></DIV></DIV></DIV></DIV></DIV></BODY></HTML>
',
CONVERT(DATETIME, '2022-06-22 22:42:34.000'),
CONVERT(DATETIME, '2022-06-24 22:42:34.000'),
'36005280',
'10801500',
'1',
'4'
);