USE [ToDoDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10.09.2023 14:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ToDoApp]    Script Date: 10.09.2023 14:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToDoApp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
 CONSTRAINT [PK_ToDoApp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230910024306_initialCreate', N'7.0.10')
GO
SET IDENTITY_INSERT [dbo].[ToDoApp] ON 

INSERT [dbo].[ToDoApp] ([Id], [Name], [Category]) VALUES (2, N'her pazartesi pazara gitmek', N'haftalık')
INSERT [dbo].[ToDoApp] ([Id], [Name], [Category]) VALUES (3, N'her gün spor yapmak', N'günlük')
INSERT [dbo].[ToDoApp] ([Id], [Name], [Category]) VALUES (4, N'her yıl tatile gitmek', N'yıllık')
INSERT [dbo].[ToDoApp] ([Id], [Name], [Category]) VALUES (5, N'kitap okumak', N'günlük')
INSERT [dbo].[ToDoApp] ([Id], [Name], [Category]) VALUES (6, N'her cuma .core çalışmak ', N'haftalık')
SET IDENTITY_INSERT [dbo].[ToDoApp] OFF
GO
