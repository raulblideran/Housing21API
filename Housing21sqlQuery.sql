DROP table [users];

CREATE TABLE [users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](57) NOT NULL,
	[dob] [date] NOT NULL,
	[phonenumber] [nvarchar](15) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	PRIMARY KEY (id));

insert into [users] (name, dob, phonenumber, email) values ('Raul Blideran', '1998-08-15', '+44 07777777777', 'raul.blideran@email.com');
insert into [users] (name, dob, phonenumber, email) values ('John Smith', '1967-02-23', '+44 07239210404', 'jonh.smith@email.com');