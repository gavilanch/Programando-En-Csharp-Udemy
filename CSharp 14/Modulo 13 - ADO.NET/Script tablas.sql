
/****** Object:  Table [dbo].[Personas]    Script Date: 11-Aug-22 1:20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 11-Aug-22 1:20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio]) VALUES (1, N'Martillo', CAST(15.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio]) VALUES (2, N'Bicicleta', CAST(31.99 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
/****** Object:  StoredProcedure [dbo].[Personas_Insertar]    Script Date: 11-Aug-22 1:20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Personas_Insertar]
	@nombre nvarchar(200),
	@id int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   INSERT INTO Personas (Nombre)
   VALUES(@nombre)

   SELECT @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[Personas_Leer]    Script Date: 11-Aug-22 1:20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Personas_Leer]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Personas
	ORDER BY Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[Personas_Y_Productos]    Script Date: 11-Aug-22 1:20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Personas_Y_Productos]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Personas;

	SELECT *
	FROM Productos;
END
GO
