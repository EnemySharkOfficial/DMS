
INSERT INTO manager (FIO, mail, passport_data) 
VALUES ('����� �.�.', 'popov@mai.tu', '1815'),
 ('�������� �.�.', 'asdsad@mai.tu', '324234'),
 ('������� �.�.', 'xcxcxcx@mai.tu', '18324215'),
 ('������� �.�.', '12345@mai.tu', '1232'),
 ('������ �.�.', 'bbbb@mai.tu', '44343'),
 ('���������� �.�.', 'nbvbv@mai.tu', 'erer'),
 ('������ �.�.', 'mamama@mai.tu', '5464353'),
 ('������ �.�.', 'bvvb@mai.tu', '1815'),
 ('������� �.�.', 'ffff@mai.tu', 'ghhgghhg'),
 ('��������.�.�.', 'dfdfdfd@mai.tu', '34343');

 select * from manager

 DELETE FROM manager
WHERE id_manager > 0;

DBCC CHECKIDENT ('manager', RESEED, 0)

INSERT INTO master (FIO, mail, passport_data, post, id_manager) 
VALUES ('����� �.�.', 'rtrtrrr@mai.tu', '444444','����������_2_���������',1),
('����� �.�.', '������@mai.tu', 'fdfd','����������_2_���������',1),
('����� �.�.', '324324rrr@mai.tu', '45345','����������_2_���������',1),
('����� �.�.', '���@mai.tu', 'drfee','������',4),
('����� �.�.', 'fgfg@mai.tu', 'dfdf','����������_1_���������',5),
('������ �.�.', 'fgf@mai.tu', 'e4rr4','����������_2_���������',6),
('���������� �.�.', '44443vvvv@mai.tu', 'recc','����������',7),
('�������� �.�.', 'rtrtr555rr@mai.tu', '56555','����������_1_���������',8),
('������� �.�.', '5555@mai.tu', 'sdfdsf','����������_1_���������',9),
('�������� �.�.', '324343@mai.tu', 'ffff','����������_2_���������',10);

 select * from master

 
INSERT INTO service (service_type, prise, description) 
VALUES ('��', '50000','����������� ������������'),
('��', '15000','��������� ������������'),
('�����������', '1000','����������� ��'),
('������ �����', '40000','������'),
('������ �������', '50000','������ � ����������� �������������� ��������'),
('����������� ������������', '10000','������������ �� ��������'),
('������ ���������', '1000','������ ���������'),
('�����������', '14000','������������'),
('��������', '500','��������'),
('������ �������', '50000','������ �������');

select * from service

INSERT INTO client(FIO, Phone_number, mail, passport_data) 
VALUES ('����� �.�.', '546546546', 'popov@mai.tu', '324324'),
('������ �.�.', '46765765', '344543@mai.tu', '23434'),
('����� �.�.', '34453445', '�4554@mai.tu', '34'),
('����� �.�.', '45434543', 'sfsg444@mai.tu', '34324324'),
('���� �.�.', '34534534', '443f34@mai.tu', '32d32d23'),
('����� �.�.', '354355', 'p43r4f4opov@mai.tu', '2342efdd'),
('������� �.�.', '65756756', '56yh66g6@mai.tu', '2e23d23d3'),
('������ �.�.', '35345353', '34f3f34@mai.tu', '32d32d3d3d'),
('������ �.�.', '2342434', '34434434@mai.tu', '23d32d23d'),
('������ �.�.', '546645', '22222@mai.tu', '18233d15');

select * from client

INSERT INTO car(brand, model, "year" ,equipment, price, image, description, characteristics, id_client, id_master) 
VALUES ('�����', 's1000','1999','1', 344300 ,'SFSFSDFF','������ ��� ������������','����������',1, 10),
('���', 's1000','1999','3+', 454500 ,'SFSFSDFF','������ ��� ������������','����������',2, 9),
('����', 'd44','2005','4', 454000,'SFSFSDFF','������ ��� ������������','����������',3, 9),
('�����', 'g45','2022','1', 45000 ,'SFSFSDFF','������ ��� ������������','����������',4, 8),
('���', 'sr','2020','2-', 55000 ,'SFSFSDFF','������ ��� ������������','����������',5, 7),
('��������', '1890','1999','super', 550000 ,'SFSFSDFF','������ ��� ������������','����������',6, 6),
('����', 'fre','1979','ff', 600000 ,'SFSFSDFF','������ ��� ������������','����������',7, 5),
('���', 'fff','2001','g1', 6000000 ,'SFSFSDFF','������ ��� ������������','����������',8, 4),
('����', '4444','2002','1', 560000 ,'SFSFSDFF','������ ��� ������������','����������',9, 1),
('�������', 'fff','2003','1', 700000 ,'SFSFSDFF','������ ��� ������������','����������',10, 1);

select * from car

INSERT INTO current_service(way_of_implementation, description, id_service, id_car) 
VALUES ('�������������� ������', '�������������� ������ ������ ������', 1, 1),
('������ +', '������ ������ ���������', 2, 2),
('����� ������', '����� ������� ������ ������', 3, 2),
('������ ������ �����', '������ ������ �����', 4, 2),
('������ �����', '������ 4� �����', 5, 3),
('������ ��������', '������ ���� �� ������ � ���������', 6, 6),
('������ �����������', '������ �����������', 7, 4),
('������ ������', '������ ������', 8, 9),
('�����������', '����������� �������� �����', 9, 10),
('������ ����', '������ �������� ���������', 10, 6);

select * from current_service

INSERT INTO current_servise_master(id_current_servise, id_master, description) 
VALUES (1, 1, '��������� ������'),
(2, 2, '��������� ������'),
(2, 3, '��������� ������'),
(4, 4, '��������� ������'),
(5, 4, '��������� ������'),
(6, 5, '��������� ������'),
(7, 5, '��������� ������'),
(8, 5, '��������� ������'),
(9, 6, '��������� ������'),
(10, 7, '��������� ������');


select * from current_servise_master










