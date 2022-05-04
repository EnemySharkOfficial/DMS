CREATE TABLE [client] (
	id_client integer NOT NULL DEFAULT 'id_master',
	FIO varchar(255) NOT NULL,
	Phone_number varchar(255) NOT NULL,
	mail varchar(255) NOT NULL,
	passport_data varchar(255) NOT NULL,
  CONSTRAINT [PK_CLIENT] PRIMARY KEY CLUSTERED
  (
  [id_client] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [master] (
	id_master integer NOT NULL,
	FIO varchar(255) NOT NULL,
	mail varchar(255) NOT NULL,
	passport_data varchar(255) NOT NULL,
	post varchar(255) NOT NULL,
	id_manager integer NOT NULL,
  CONSTRAINT [PK_MASTER] PRIMARY KEY CLUSTERED
  (
  [id_master] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [car] (
	id_car integer NOT NULL,
	brand varchar(255) NOT NULL,
	model varchar(255) NOT NULL,
	year date NOT NULL,
	equipment varchar(255) NOT NULL,
	price integer NOT NULL,
	image varchar(255) NOT NULL,
	description varchar(255) NOT NULL,
	characteristics varchar(255) NOT NULL,
	id_client integer NOT NULL,
	id_master integer NOT NULL,
  CONSTRAINT [PK_CAR] PRIMARY KEY CLUSTERED
  (
  [id_car] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [service] (
	id_service integer NOT NULL,
	service_type varchar(255) NOT NULL,
	prise integer NOT NULL,
	description varchar(255) NOT NULL,
  CONSTRAINT [PK_SERVICE] PRIMARY KEY CLUSTERED
  (
  [id_service] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [manager] (
	id_manager integer NOT NULL,
	FIO varchar(255) NOT NULL,
	mail varchar(255) NOT NULL,
	passport_data varchar(255) NOT NULL,
  CONSTRAINT [PK_MANAGER] PRIMARY KEY CLUSTERED
  (
  [id_manager] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [current_service] (
	id_current_service integer NOT NULL,
	way_of_implementation varchar(255) NOT NULL,
	description varchar(255) NOT NULL,
	id_service integer NOT NULL,
	id_car integer NOT NULL,
  CONSTRAINT [PK_CURRENT_SERVICE] PRIMARY KEY CLUSTERED
  (
  [id_current_service] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [current_servise_master] (
	id_current_servise integer NOT NULL,
	id_master integer NOT NULL,
	description varchar(255) NOT NULL
)
GO

ALTER TABLE [master] WITH CHECK ADD CONSTRAINT [master_fk0] FOREIGN KEY ([id_manager]) REFERENCES [manager]([id_manager])
ON UPDATE CASCADE
GO
ALTER TABLE [master] CHECK CONSTRAINT [master_fk0]
GO

ALTER TABLE [car] WITH CHECK ADD CONSTRAINT [car_fk0] FOREIGN KEY ([id_client]) REFERENCES [client]([id_client])
ON UPDATE CASCADE
GO
ALTER TABLE [car] CHECK CONSTRAINT [car_fk0]
GO
ALTER TABLE [car] WITH CHECK ADD CONSTRAINT [car_fk1] FOREIGN KEY ([id_master]) REFERENCES [master]([id_master])
ON UPDATE CASCADE
GO
ALTER TABLE [car] CHECK CONSTRAINT [car_fk1]
GO



ALTER TABLE [current_service] WITH CHECK ADD CONSTRAINT [current_service_fk0] FOREIGN KEY ([id_service]) REFERENCES [service]([id_service])
ON UPDATE CASCADE
GO
ALTER TABLE [current_service] CHECK CONSTRAINT [current_service_fk0]
GO
ALTER TABLE [current_service] WITH CHECK ADD CONSTRAINT [current_service_fk1] FOREIGN KEY ([id_car]) REFERENCES [car]([id_car])
ON UPDATE CASCADE
GO
ALTER TABLE [current_service] CHECK CONSTRAINT [current_service_fk1]
GO

ALTER TABLE [current_servise_master] WITH CHECK ADD CONSTRAINT [current_servise_master_fk0] FOREIGN KEY ([id_current_servise]) REFERENCES [current_service]([id_current_service])
ON UPDATE CASCADE
GO
ALTER TABLE [current_servise_master] CHECK CONSTRAINT [current_servise_master_fk0]
GO
ALTER TABLE [current_servise_master] WITH CHECK ADD CONSTRAINT [current_servise_master_fk1] FOREIGN KEY ([id_master]) REFERENCES [master]([id_master])
ON UPDATE CASCADE
GO
ALTER TABLE [current_servise_master] CHECK CONSTRAINT [current_servise_master_fk1]
GO

