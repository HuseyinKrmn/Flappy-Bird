USE [FlappyBirdDb]
GO
/****** Object:  Table [dbo].[Kayit]    Script Date: 28.12.2021 12:04:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kayit](
	[KullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [varchar](50) NOT NULL,
	[Sifre] [varchar](50) NOT NULL,
	[Skor] [int] NULL,
 CONSTRAINT [PK_Kayit] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kayit] ON 

INSERT [dbo].[Kayit] ([KullaniciId], [KullaniciAd], [Sifre], [Skor]) VALUES (26, N'Hüseyin', N'1234', 7)
INSERT [dbo].[Kayit] ([KullaniciId], [KullaniciAd], [Sifre], [Skor]) VALUES (1005, N'Ada', N'1', 3)
INSERT [dbo].[Kayit] ([KullaniciId], [KullaniciAd], [Sifre], [Skor]) VALUES (1006, N'Aslı', N'123', 2)
SET IDENTITY_INSERT [dbo].[Kayit] OFF
GO
