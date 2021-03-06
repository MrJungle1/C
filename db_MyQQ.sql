USE [master]
GO
/****** Object:  Database [db_MyQQ]    Script Date: 2016/7/20 14:01:53 ******/
CREATE DATABASE [db_MyQQ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyQQ', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MR2014\MSSQL\DATA\db_MyQQ.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyQQ_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MR2014\MSSQL\DATA\db_MyQQ_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_MyQQ] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_MyQQ].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [db_MyQQ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_MyQQ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_MyQQ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_MyQQ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_MyQQ] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_MyQQ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_MyQQ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_MyQQ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_MyQQ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_MyQQ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_MyQQ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_MyQQ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_MyQQ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_MyQQ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_MyQQ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_MyQQ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_MyQQ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_MyQQ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_MyQQ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_MyQQ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_MyQQ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_MyQQ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_MyQQ] SET RECOVERY FULL 
GO
ALTER DATABASE [db_MyQQ] SET  MULTI_USER 
GO
ALTER DATABASE [db_MyQQ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_MyQQ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_MyQQ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_MyQQ] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_MyQQ] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_MyQQ', N'ON'
GO
USE [db_MyQQ]
GO
/****** Object:  Table [dbo].[tb_Friend]    Script Date: 2016/7/20 14:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Friend](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HostID] [int] NOT NULL,
	[FriendID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_FriendLimit]    Script Date: 2016/7/20 14:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_FriendLimit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FriendLimit] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_Message]    Script Date: 2016/7/20 14:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_Message](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FromUserID] [int] NOT NULL,
	[ToUserID] [int] NOT NULL,
	[Message] [varchar](100) NULL,
	[MessageTypeID] [int] NOT NULL,
	[MessageState] [int] NOT NULL,
	[MessageTime] [datetime] NOT NULL CONSTRAINT [DF_tb_Message_MessageTime]  DEFAULT (getdate())
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_MessageType]    Script Date: 2016/7/20 14:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_MessageType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MessageType] [nchar](6) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 2016/7/20 14:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Pwd] [varchar](50) NOT NULL,
	[FriendLimitID] [int] NULL CONSTRAINT [DF_tb_User_FriendLimitID]  DEFAULT ((1)),
	[NickName] [varchar](20) NOT NULL,
	[HeadID] [int] NULL CONSTRAINT [DF_tb_User_HeadID]  DEFAULT ((1)),
	[Sex] [nchar](1) NOT NULL,
	[Age] [int] NULL CONSTRAINT [DF_tb_User_Age]  DEFAULT ((100)),
	[Name] [varchar](20) NULL,
	[Star] [nchar](3) NULL,
	[BloodType] [nchar](3) NULL,
	[Remember] [int] NOT NULL CONSTRAINT [DF_tb_User_Remember]  DEFAULT ((0)),
	[AutoLogin] [int] NOT NULL CONSTRAINT [DF_tb_User_AutoLogin]  DEFAULT ((0)),
	[Sign] [nvarchar](20) NOT NULL CONSTRAINT [DF_tb_User_Sign]  DEFAULT (N'个性签名'),
	[Flag] [int] NOT NULL CONSTRAINT [DF_tb_User_Flag]  DEFAULT ((0)),
 CONSTRAINT [PK_tb_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[v_Message]    Script Date: 2016/7/20 14:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_Message]
AS
SELECT DISTINCT 
                dbo.tb_Message.ID, dbo.tb_Message.FromUserID, dbo.tb_Message.ToUserID, dbo.tb_Message.Message, 
                dbo.tb_Message.MessageTypeID, dbo.tb_Message.MessageState, dbo.tb_Message.MessageTime, 
                dbo.tb_User.NickName
FROM      dbo.tb_Message INNER JOIN
                dbo.tb_User ON dbo.tb_Message.FromUserID = dbo.tb_User.ID

GO
SET IDENTITY_INSERT [dbo].[tb_Friend] ON 

INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (10, 10000, 10002)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (14, 10002, 10000)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (16, 10002, 10009)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (18, 10010, 10009)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (24, 10013, 10000)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (25, 10013, 10011)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (27, 10000, 10013)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (28, 10014, 10015)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (29, 10000, 10010)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (30, 10016, 10000)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (31, 10011, 10013)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (32, 10019, 10014)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (35, 10019, 10000)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (37, 10020, 10019)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (38, 10019, 10020)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (39, 10008, 10001)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (40, 10008, 10002)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (42, 10001, 10008)
INSERT [dbo].[tb_Friend] ([ID], [HostID], [FriendID]) VALUES (43, 10002, 10001)
SET IDENTITY_INSERT [dbo].[tb_Friend] OFF
SET IDENTITY_INSERT [dbo].[tb_FriendLimit] ON 

INSERT [dbo].[tb_FriendLimit] ([ID], [FriendLimit]) VALUES (1, N'允许任何人加我为好友')
INSERT [dbo].[tb_FriendLimit] ([ID], [FriendLimit]) VALUES (2, N'需要身份验证才能加我为好友')
INSERT [dbo].[tb_FriendLimit] ([ID], [FriendLimit]) VALUES (3, N'不允许任何人加我为好友')
SET IDENTITY_INSERT [dbo].[tb_FriendLimit] OFF
SET IDENTITY_INSERT [dbo].[tb_Message] ON 

INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (2, 10008, 10001, N'你好', 1, 1, CAST(N'2016-07-08 16:32:07.107' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (3, 10008, 10001, N'法尔啊而发而发', 1, 1, CAST(N'2016-07-08 16:32:15.577' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (4, 10008, 10001, N'你好', 1, 1, CAST(N'2016-07-08 16:46:37.473' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (5, 10008, 10001, N'你好


', 1, 1, CAST(N'2016-07-08 17:12:37.890' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (6, 10008, 10001, N'在干哈呢', 1, 1, CAST(N'2016-07-08 17:12:47.810' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (7, 10008, 10001, N'我那知道', 1, 1, CAST(N'2016-07-08 17:12:54.200' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (8, 10008, 10001, N'哦了', 1, 1, CAST(N'2016-07-08 17:14:12.923' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (9, 10001, 10008, N'明白了
', 1, 1, CAST(N'2016-07-08 17:14:52.677' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (10, 10008, 10001, N'明白啥了，你明白', 1, 1, CAST(N'2016-07-09 08:26:54.777' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (11, 10001, 10008, N'怎么的，就是明白了
', 1, 1, CAST(N'2016-07-09 08:28:04.043' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (12, 10001, 10008, NULL, 2, 1, CAST(N'2016-07-09 09:29:18.437' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (13, 10001, 10008, NULL, 2, 1, CAST(N'2016-07-09 09:30:03.910' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (14, 10008, 10001, N'你干哈呢
', 1, 1, CAST(N'2016-07-09 09:30:59.050' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (15, 10001, 10008, N'没干哈啊', 1, 1, CAST(N'2016-07-09 09:31:18.650' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (16, 10008, 10003, N'哈哈哈', 1, 1, CAST(N'2016-07-09 09:58:54.307' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (22, 10008, 10001, N'你好', 1, 1, CAST(N'2016-07-09 13:30:13.420' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (24, 10001, 10008, N'我也看不到啊', 1, 1, CAST(N'2016-07-09 13:33:18.430' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (25, 10008, 10001, N'我去', 1, 1, CAST(N'2016-07-09 13:33:28.960' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (26, 10008, 10001, N'不会吧', 1, 1, CAST(N'2016-07-09 13:33:31.380' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (27, 10001, 10008, N'真的', 1, 1, CAST(N'2016-07-09 13:33:36.553' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (28, 10001, 10008, N'怕你干啥', 1, 1, CAST(N'2016-07-09 13:33:40.397' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (29, 10001, 10008, N'我可 不信', 1, 1, CAST(N'2016-07-09 13:34:22.120' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (30, 10001, 10008, N'干哈呢', 1, 1, CAST(N'2016-07-09 13:43:53.027' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (32, 10001, 10008, N'没干哈是干哈呢', 1, 1, CAST(N'2016-07-09 13:44:32.873' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (34, 10001, 10008, N'什么玩意', 1, 1, CAST(N'2016-07-09 13:44:57.850' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (36, 10001, 10008, N'我说你说的什么玩意', 1, 1, CAST(N'2016-07-09 13:45:10.600' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (38, 10001, 10008, N'崩溃', 1, 1, CAST(N'2016-07-09 13:45:21.970' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (41, 10008, 10001, N'没怎么的', 1, 1, CAST(N'2016-07-09 14:00:58.367' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (43, 10008, 10001, N'没怎么的就是没怎么的', 1, 1, CAST(N'2016-07-09 14:01:24.840' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (45, 10008, 10001, N'你为啥疯啊', 1, 1, CAST(N'2016-07-09 14:01:41.283' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (47, 10008, 10001, N'那你为啥疯', 1, 1, CAST(N'2016-07-09 14:01:52.517' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (49, 10008, 10001, N'行了', 1, 1, CAST(N'2016-07-09 14:02:08.823' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (17, 10008, 10003, N'你谁啊', 1, 1, CAST(N'2016-07-09 10:01:08.280' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (18, 10003, 10008, N'wo nazhidao
', 1, 1, CAST(N'2016-07-09 10:01:55.047' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (19, 10008, 10003, N'嘚瑟', 1, 1, CAST(N'2016-07-09 10:02:08.437' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (20, 10008, 10001, N'小王', 1, 1, CAST(N'2016-07-09 13:18:43.893' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (21, 10001, 10008, N'怎么的呢', 1, 1, CAST(N'2016-07-09 13:19:03.440' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (23, 10001, 10008, N'看不着消息啊', 1, 1, CAST(N'2016-07-09 13:30:48.370' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (31, 10008, 10001, N'没干哈呀', 1, 1, CAST(N'2016-07-09 13:44:12.547' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (33, 10008, 10001, N'  没干哈就是没干哈呗', 1, 1, CAST(N'2016-07-09 13:44:50.163' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (35, 10008, 10001, N'什么什么玩意', 1, 1, CAST(N'2016-07-09 13:45:03.400' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (37, 10008, 10001, N'我没说啥呢', 1, 1, CAST(N'2016-07-09 13:45:16.910' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (39, 10008, 10001, N'我还崩溃呢', 1, 1, CAST(N'2016-07-09 13:45:27.613' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (40, 10001, 10008, N'怎么的呢', 1, 1, CAST(N'2016-07-09 14:00:42.337' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (42, 10001, 10008, N'没怎么的是怎么的', 1, 1, CAST(N'2016-07-09 14:01:15.643' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (44, 10001, 10008, N'我要疯了', 1, 1, CAST(N'2016-07-09 14:01:34.220' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (46, 10001, 10008, N'我也不知道', 1, 1, CAST(N'2016-07-09 14:01:46.700' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (48, 10001, 10008, N'我就想疯，行了吧', 1, 1, CAST(N'2016-07-09 14:02:04.607' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (50, 10001, 10008, N'我去', 1, 1, CAST(N'2016-07-09 14:04:04.933' AS DateTime))
INSERT [dbo].[tb_Message] ([ID], [FromUserID], [ToUserID], [Message], [MessageTypeID], [MessageState], [MessageTime]) VALUES (51, 10002, 10001, N'你去哪', 1, 0, CAST(N'2016-07-09 14:04:58.873' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_Message] OFF
SET IDENTITY_INSERT [dbo].[tb_MessageType] ON 

INSERT [dbo].[tb_MessageType] ([ID], [MessageType]) VALUES (1, N'普通聊天消息')
INSERT [dbo].[tb_MessageType] ([ID], [MessageType]) VALUES (2, N'添加好友消息')
SET IDENTITY_INSERT [dbo].[tb_MessageType] OFF
SET IDENTITY_INSERT [dbo].[tb_User] ON 

INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10001, N'xiaoke', 1, N'小科', 1, N'男', 31, N'小科', N'双子座', N'AB型', 1, 1, N'个性签名', 0)
INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10002, N'wangzi', 1, N'王梓', 1, N'男', 4, N'王梓', N'处女座', N'A型 ', 0, 0, N'个性签名', 0)
INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10003, N'buzhidao', 1, N'不知道', 1, N'男', 30, N'不知道', N'白羊座', N'A型 ', 0, 0, N'个性签名', 0)
INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10004, N'test', 1, N'test', 1, N'女', 32, N'test', N'双子座', N'A型 ', 0, 0, N'个性签名', 0)
INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10005, N'test', 1, N'test', 1, N'女', 32, N'test', N'双子座', N'A型 ', 0, 0, N'个性签名', 0)
INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10006, N'hahaha', 1, N'哈哈哈', 1, N'男', 20, N'哈哈哈', N'白羊座', N'A型 ', 0, 0, N'个性签名', 0)
INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10007, N'chouren', 1, N'愁人', 1, N'男', 1, N'愁人', N'白羊座', N'A型 ', 0, 0, N'个性签名', 0)
INSERT [dbo].[tb_User] ([ID], [Pwd], [FriendLimitID], [NickName], [HeadID], [Sex], [Age], [Name], [Star], [BloodType], [Remember], [AutoLogin], [Sign], [Flag]) VALUES (10008, N'mrsoft', 2, N'明日', 20, N'女', 10, N'明日', N'   ', N'   ', 0, 0, N'个性签名', 0)
SET IDENTITY_INSERT [dbo].[tb_User] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tb_Message"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 221
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_User"
            Begin Extent = 
               Top = 6
               Left = 259
               Bottom = 146
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_Message'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_Message'
GO
USE [master]
GO
ALTER DATABASE [db_MyQQ] SET  READ_WRITE 
GO
