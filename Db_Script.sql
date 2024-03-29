/****** Object:  Table [dbo].[ContactDetails]    Script Date: 18/01/2024 22:17:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContactDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](10) NULL,
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Middle_Initial] [varchar](20) NULL,
	[Home_Phone] [varchar](25) NULL,
	[Cell_Phone] [varchar](25) NULL,
	[Office_Extension] [varchar](25) NULL,
	[IRD_Number] [varchar](50) NULL,
	[Status] [int] NULL,
	[Staff_Type] [int] NULL,
	[ManagerId] [int] NULL,
 CONSTRAINT [PK_ContactDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ContactStaffType]    Script Date: 18/01/2024 22:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactStaffType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContactStaffType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type_Description] [varchar](50) NULL,
 CONSTRAINT [PK_ContactStaffType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ContactStatus]    Script Date: 18/01/2024 22:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContactStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status_Description] [varchar](30) NOT NULL,
 CONSTRAINT [PK_ContactStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ContactDetail_ManagerId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ContactDetails] ADD  CONSTRAINT [DF_ContactDetail_ManagerId]  DEFAULT ((0)) FOR [ManagerId]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContactDetails_ContactStaffType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactDetails]'))
ALTER TABLE [dbo].[ContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_ContactDetails_ContactStaffType] FOREIGN KEY([Staff_Type])
REFERENCES [dbo].[ContactStaffType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContactDetails_ContactStaffType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactDetails]'))
ALTER TABLE [dbo].[ContactDetails] CHECK CONSTRAINT [FK_ContactDetails_ContactStaffType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContactDetails_ContactStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactDetails]'))
ALTER TABLE [dbo].[ContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_ContactDetails_ContactStatus] FOREIGN KEY([Status])
REFERENCES [dbo].[ContactStatus] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContactDetails_ContactStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactDetails]'))
ALTER TABLE [dbo].[ContactDetails] CHECK CONSTRAINT [FK_ContactDetails_ContactStatus]
GO
