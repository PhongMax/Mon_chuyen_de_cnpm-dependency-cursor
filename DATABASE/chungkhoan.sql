USE [CHUNGKHOAN]
GO
/****** Object:  Table [dbo].[BANG_GIA_TRUC_TUYEN]    Script Date: Sat 4 18 2020 12:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANG_GIA_TRUC_TUYEN](
	[MACP] [char](7) NOT NULL,
	[DM_GIA2] [float] NULL,
	[DM_KL2] [int] NULL,
	[DM_GIA1] [float] NULL,
	[DM_KL1] [int] NULL,
	[KL_GIA] [float] NULL,
	[KL_KL] [int] NULL,
	[DB_GIA1] [float] NULL,
	[DB_KL1] [int] NULL,
	[DB_GIA2] [float] NULL,
	[DB_KL2] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LENHDAT]    Script Date: Sat 4 18 2020 12:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LENHDAT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MACP] [char](7) NOT NULL,
	[NGAYDAT] [datetime] NOT NULL CONSTRAINT [DF__LENHDAT_NGAYDAT]  DEFAULT (getdate()),
	[LOAIGD] [nchar](1) NOT NULL,
	[LOAILENH] [nchar](10) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[GIADAT] [float] NOT NULL,
	[TRANGTHAILENH] [nvarchar](30) NULL,
 CONSTRAINT [PK_LENHDAT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LENHKHOP]    Script Date: Sat 4 18 2020 12:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LENHKHOP](
	[IDKHOP] [int] IDENTITY(1,1) NOT NULL,
	[NGAYKHOP] [datetime] NOT NULL,
	[SOLUONGKHOP] [int] NOT NULL,
	[GIAKHOP] [float] NOT NULL,
	[IDLENHDAT] [int] NULL,
 CONSTRAINT [PK__LENHKHOP__F336C59879AC3042] PRIMARY KEY CLUSTERED 
(
	[IDKHOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BANG_GIA_TRUC_TUYEN] ([MACP], [DM_GIA2], [DM_KL2], [DM_GIA1], [DM_KL1], [KL_GIA], [KL_KL], [DB_GIA1], [DB_KL1], [DB_GIA2], [DB_KL2]) VALUES (N'ACB    ', 110, 100, 120, 200, NULL, NULL, 50, 100, 51, 100)
SET IDENTITY_INSERT [dbo].[LENHDAT] ON 

INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (29, N'ACB    ', CAST(N'2020-04-17 13:32:19.223' AS DateTime), N'B', N'LO        ', 100, 100, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (30, N'ACB    ', CAST(N'2020-04-17 13:33:08.183' AS DateTime), N'B', N'LO        ', 100, 80, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (31, N'ACB    ', CAST(N'2020-04-17 13:33:30.087' AS DateTime), N'B', N'LO        ', 80, 40, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (32, N'ACB    ', CAST(N'2020-04-17 13:40:44.853' AS DateTime), N'M', N'LO        ', 100, 100, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (33, N'ACB    ', CAST(N'2020-04-17 13:41:18.013' AS DateTime), N'M', N'LO        ', 100, 120, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (34, N'ACB    ', CAST(N'2020-04-17 13:41:34.287' AS DateTime), N'M', N'LO        ', 100, 120, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (35, N'ACB    ', CAST(N'2020-04-17 13:41:53.363' AS DateTime), N'M', N'LO        ', 100, 110, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (36, N'ACB    ', CAST(N'2020-04-17 13:42:16.150' AS DateTime), N'B', N'LO        ', 100, 150, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (37, N'ACB    ', CAST(N'2020-04-17 13:42:42.733' AS DateTime), N'B', N'LO        ', 100, 70, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (38, N'ACB    ', CAST(N'2020-04-18 00:19:11.730' AS DateTime), N'B', N'LO        ', 100, 50, NULL)
INSERT [dbo].[LENHDAT] ([ID], [MACP], [NGAYDAT], [LOAIGD], [LOAILENH], [SOLUONG], [GIADAT], [TRANGTHAILENH]) VALUES (39, N'ACB    ', CAST(N'2020-04-18 00:21:34.303' AS DateTime), N'B', N'LO        ', 100, 51, NULL)
SET IDENTITY_INSERT [dbo].[LENHDAT] OFF
ALTER TABLE [dbo].[LENHKHOP]  WITH CHECK ADD  CONSTRAINT [FK_LENHKHOP_LENHDAT] FOREIGN KEY([IDLENHDAT])
REFERENCES [dbo].[LENHDAT] ([ID])
GO
ALTER TABLE [dbo].[LENHKHOP] CHECK CONSTRAINT [FK_LENHKHOP_LENHDAT]
GO
ALTER TABLE [dbo].[LENHDAT]  WITH CHECK ADD  CONSTRAINT [CK_LENHDAT_GIADAT] CHECK  (([GIADAT]>(0)))
GO
ALTER TABLE [dbo].[LENHDAT] CHECK CONSTRAINT [CK_LENHDAT_GIADAT]
GO
ALTER TABLE [dbo].[LENHDAT]  WITH CHECK ADD  CONSTRAINT [CK_LENHDAT_LOAIGD] CHECK  (([LOAIGD]='M' OR [LOAIGD]='B'))
GO
ALTER TABLE [dbo].[LENHDAT] CHECK CONSTRAINT [CK_LENHDAT_LOAIGD]
GO
ALTER TABLE [dbo].[LENHDAT]  WITH CHECK ADD  CONSTRAINT [CK_LENHDAT_LOAILENH] CHECK  (([LOAILENH]='LO' OR [LOAILENH]='ATO' OR [LOAILENH]='ATC'))
GO
ALTER TABLE [dbo].[LENHDAT] CHECK CONSTRAINT [CK_LENHDAT_LOAILENH]
GO
ALTER TABLE [dbo].[LENHDAT]  WITH CHECK ADD  CONSTRAINT [CK_LENHDAT_SOLUONG] CHECK  (([SOLUONG]>=(0)))
GO
ALTER TABLE [dbo].[LENHDAT] CHECK CONSTRAINT [CK_LENHDAT_SOLUONG]
GO
ALTER TABLE [dbo].[LENHDAT]  WITH CHECK ADD  CONSTRAINT [CK_LENHDAT_TRANGTHAILENH] CHECK  (([TRANGTHAILENH]=N'Chờ khớp' OR [TRANGTHAILENH]=N'Khớp lệnh 1 phần' OR [TRANGTHAILENH]=N'Khớp hết' OR [TRANGTHAILENH]=N'Đã hủy' OR [TRANGTHAILENH]=N'Chưa khớp'))
GO
ALTER TABLE [dbo].[LENHDAT] CHECK CONSTRAINT [CK_LENHDAT_TRANGTHAILENH]
GO
/****** Object:  StoredProcedure [dbo].[CursorLoaiGD]    Script Date: Sat 4 18 2020 12:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CursorLoaiGD]
  @OutCrsr CURSOR VARYING OUTPUT, 
  @macp NVARCHAR( 10), @Ngay NVARCHAR( 50),  @LoaiGD CHAR 
AS
SET DATEFORMAT DMY 
IF (@LoaiGD='M') 
  SET @OutCrsr=CURSOR KEYSET FOR 
  SELECT ID, NGAYDAT, SOLUONG, GIADAT FROM LENHDAT 
  WHERE MACP=@macp 
    AND DAY(NGAYDAT)=DAY(@Ngay)AND MONTH(NGAYDAT)= MONTH(@Ngay) AND YEAR(NGAYDAT)=YEAR(@Ngay)  
    AND LOAIGD=@LoaiGD AND SOLUONG >0  
    ORDER BY GIADAT DESC, NGAYDAT 
ELSE
  SET @OutCrsr=CURSOR KEYSET FOR 
  SELECT ID,NGAYDAT, SOLUONG, GIADAT FROM LENHDAT 
  WHERE MACP=@macp 
    AND DAY(NGAYDAT)=DAY(@Ngay)AND MONTH(NGAYDAT)= MONTH(@Ngay) AND YEAR(NGAYDAT)=YEAR(@Ngay)  
    AND LOAIGD=@LoaiGD AND SOLUONG >0  
    ORDER BY GIADAT, NGAYDAT 
OPEN @OutCrsr

GO
/****** Object:  StoredProcedure [dbo].[SP_BUILD_BGTT]    Script Date: Sat 4 18 2020 12:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery64.sql|7|0|C:\Users\phong\AppData\Local\Temp\~vs9095.sql
CREATE PROCEDURE [dbo].[SP_BUILD_BGTT] 
 @LoaiGD_InSerted NCHAR(1), 
    @MACP_Inserted CHAR(10),   @NGAYDAT_Inserted DATETIME ,    @GIADAT_Inserted FLOAT 
AS
   

        IF EXISTS ( SELECT  *
                    FROM    tempdb.sys.tables
                    WHERE   name like '#TEMP_BGLD%' )
            DROP TABLE #TEMP_BGLD

	     IF EXISTS ( SELECT  *
                    FROM    tempdb.sys.tables
                    WHERE   name like '#TEMP_BGLB_TOP2%' )
            DROP TABLE #TEMP_BGLB_TOP2

		 IF EXISTS ( SELECT  *
                    FROM    tempdb.sys.tables
                    WHERE   name like '#TEMP_BGLM_TOP2%' )
         DROP TABLE #TEMP_BGLM_TOP2


		


        SELECT  MACP ,
                GIADAT ,
                SUM(SOLUONG) AS KL
        INTO    #TEMP_BGLD
        FROM    dbo.LENHDAT
        WHERE   MACP = @MACP_Inserted
                AND DAY(NGAYDAT) = DAY(@NGAYDAT_Inserted)
                AND MONTH(NGAYDAT) = MONTH(@NGAYDAT_Inserted)
                AND YEAR(NGAYDAT) = YEAR(@NGAYDAT_Inserted)
                AND LOAIGD = @LoaiGD_InSerted
                AND SOLUONG > 0
        GROUP BY MACP ,  GIADAT


		
	
		 
	

        IF ( @LoaiGD_InSerted = 'M' )
            BEGIN
               
			    SELECT  *
                INTO    #TEMP_BGLM_TOP2
                FROM    ( SELECT    * ,
                                    ROW_NUMBER() OVER ( ORDER BY GIADAT DESC) AS Row_Number
                          FROM      #TEMP_BGLD
                        ) Temp
                WHERE   Row_Number <= 2




                IF EXISTS (SELECT * FROM #TEMP_BGLM_TOP2 WHERE Row_Number = 1)
                 BEGIN  -- merge operation
                        IF EXISTS ( SELECT  *
                                    FROM    dbo.BANG_GIA_TRUC_TUYEN
                                    WHERE   MACP = @MACP_Inserted )
                            BEGIN
                                UPDATE  dbo.BANG_GIA_TRUC_TUYEN
                                SET     DM_GIA1 = ( SELECT  GIADAT
                                                    FROM    #TEMP_BGLM_TOP2
                                                    WHERE   Row_Number = 1
                                                  ) ,
                                        DM_KL1 = ( SELECT   KL
                                                   FROM     #TEMP_BGLM_TOP2
                                                   WHERE     Row_Number = 1
                                                 )
                                WHERE   MACP = @MACP_Inserted

                            END
                        ELSE
                            BEGIN
                                INSERT  INTO dbo.BANG_GIA_TRUC_TUYEN
                                        ( MACP ,
                                          DM_GIA1 ,
                                          DM_KL1
                                        )
                                        SELECT  MACP ,
                                                GIADAT ,
                                                KL
                                        FROM    #TEMP_BGLM_TOP2
                                        WHERE   Row_Number = 1
                            END
                    END 
                IF EXISTS (SELECT * FROM #TEMP_BGLM_TOP2 WHERE Row_Number = 2)
                        BEGIN
						
								UPDATE  dbo.BANG_GIA_TRUC_TUYEN
                                SET     DM_GIA2 = ( SELECT  GIADAT
                                                    FROM    #TEMP_BGLM_TOP2
                                                    WHERE   Row_Number = 2
                                                  ) ,
                                        DM_KL2 = ( SELECT   KL
                                                   FROM     #TEMP_BGLM_TOP2
                                                   WHERE   Row_Number = 2
                                                 )
                                WHERE   MACP = @MACP_Inserted
						END
						
						
               END    
       
	ELSE 
	BEGIN
				 SELECT  *
                    INTO    #TEMP_BGLB_TOP2
                    FROM    ( SELECT    * , ROW_NUMBER() OVER ( ORDER BY GIADAT ASC) AS Row_Number
                              FROM      #TEMP_BGLD
                            ) Temp
                    WHERE   Row_Number <= 2

             
            
                 IF EXISTS (SELECT * FROM #TEMP_BGLB_TOP2 WHERE Row_Number = 1)
                    BEGIN  -- merge operation
                        IF EXISTS ( SELECT  *
                                    FROM    dbo.BANG_GIA_TRUC_TUYEN
                                    WHERE   MACP = @MACP_Inserted )
                            BEGIN
                                UPDATE  dbo.BANG_GIA_TRUC_TUYEN
                                SET     DB_GIA1 = ( SELECT  GIADAT
                                                    FROM    #TEMP_BGLB_TOP2
                                                   WHERE   Row_Number = 1
                                                  ) ,
                                        DB_KL1 = ( SELECT   KL
                                                   FROM     #TEMP_BGLB_TOP2
                                                   WHERE   Row_Number = 1
                                                 )
                                WHERE   MACP = @MACP_Inserted

                            END
                        ELSE
                            BEGIN
                                INSERT  INTO dbo.BANG_GIA_TRUC_TUYEN
                                        ( MACP ,
                                          DB_GIA1 ,
                                          DB_KL1
                                        )
                                        SELECT  MACP ,
                                                GIADAT ,
                                                KL
                                        FROM    #TEMP_BGLB_TOP2
                                        WHERE   Row_Number = 1
                            END
                    END 
             IF EXISTS (SELECT * FROM #TEMP_BGLB_TOP2 WHERE Row_Number = 2)
                        BEGIN
						
								UPDATE  dbo.BANG_GIA_TRUC_TUYEN
                                SET     DB_GIA2 = ( SELECT  GIADAT
                                                    FROM    #TEMP_BGLB_TOP2
                                                    WHERE  Row_Number = 2
                                                  ) ,
                                        DB_KL2 = ( SELECT   KL
                                                   FROM     #TEMP_BGLB_TOP2
                                                   WHERE  Row_Number = 2
                                                 )
                                WHERE   MACP = @MACP_Inserted
						END
			

	END
GO
/****** Object:  StoredProcedure [dbo].[SP_KHOPLENH_LO]    Script Date: Sat 4 18 2020 12:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_KHOPLENH_LO]
    @macp NVARCHAR(10) ,
    @Ngay NVARCHAR(50) ,
    @LoaiGD CHAR ,
    @soluongMB INT ,
    @giadatMB FLOAT
AS --Viết SP tính số lượng cổ phiếu khớp theo thuật toán khớp lệnh liên tục khi có 1 lệnh mua hoặc bán được gởi đến bảng LENHDAT
    SET DATEFORMAT DMY
    DECLARE @CrsrVar CURSOR ,
        @ngaydat NVARCHAR(50) ,
        @soluong INT ,
        @giadat FLOAT ,
        @soluongkhop INT ,
        @giakhop FLOAT ,
        @IDLENHDAT INT ,
        @soluongkhopALL INT

    SET @soluongkhopALL = 0
    IF ( @LoaiGD = 'B' )
        EXEC CursorLoaiGD @CrsrVar OUTPUT, @macp, @Ngay, 'M'
    ELSE
        EXEC CursorLoaiGD @CrsrVar OUTPUT, @macp, @Ngay, 'B'
  
    FETCH NEXT FROM @CrsrVar  INTO @IDLENHDAT, @ngaydat, @soluong, @giadat
 
    WHILE ( @@FETCH_STATUS <> -1
            AND @soluongMB > 0
          )
        BEGIN
    --  Trường hợp lệnh gởi vào là lệnh bán
            IF ( @LoaiGD = 'B' )
                IF ( @giadatMB <= @giadat )
                    BEGIN
                       IF @soluongMB > @soluong
                        BEGIN
                                SET @soluongkhop = @soluong
                                SET @giakhop = @giadat
                                SET @soluongMB = @soluongMB - @soluong

                                UPDATE  dbo.LENHDAT
                                SET     SOLUONG = 0, TRANGTHAILENH = N'Khớp hết'
                                WHERE CURRENT OF @CrsrVar
                            END
                        ELSE
                            BEGIN
                                SET @soluongkhop = @soluongMB
                                SET @giakhop = @giadat
       
                                UPDATE  dbo.LENHDAT
                                SET     SOLUONG = SOLUONG - @soluongMB , TRANGTHAILENH = N'Khớp lệnh 1 phần'
                                WHERE CURRENT OF @CrsrVar
                                SET @soluongMB = 0
                            END

	   		 -- cập nhật tổng số lượng khớp của lệnh gưi vào
                       SET @soluongkhopALL = @soluongkhopALL + @soluongkhop
                              
                       
			 -- Cập nhật table LENHKHOP
                        INSERT  INTO dbo.LENHKHOP
                                ( NGAYKHOP ,
                                  SOLUONGKHOP ,
                                  GIAKHOP ,
                                  IDLENHDAT
	                            )
                        VALUES  ( GETDATE() , -- NGAYKHOP - datetime   
                                  @soluongkhop , -- SOLUONGKHOP - int
                                  @giakhop , -- GIAKHOP - float
                                  @IDLENHDAT -- IDLENHDAT - int
	                            )
			-- Câp nhật thông tin vào 	[dbo].[BANG_GIA_TRUC_TUYEN]
						IF EXISTS(SELECT * FROM dbo.BANG_GIA_TRUC_TUYEN WHERE MACP = @macp)
						BEGIN
							UPDATE dbo.BANG_GIA_TRUC_TUYEN
							SET KL_GIA = @giakhop, KL_KL = @soluongkhop
							WHERE MACP = @macp
						END
						ELSE
                        BEGIN
                        	INSERT INTO dbo.BANG_GIA_TRUC_TUYEN( MACP ,  KL_GIA , KL_KL )
                        	VALUES  ( @macp, @giakhop, @soluongkhop )
                        	       
                        END


                    END
                ELSE
                    GOTO THOAT

    -- Còn Trường hợp lệnh gởi vào là lệnh mua
            IF ( @LoaiGD = 'M' )
                IF ( @giadatMB >= @giadat )
                    BEGIN
                        IF @soluongMB > @soluong
                            BEGIN
                                SET @soluongkhop = @soluong
                                SET @giakhop = @giadat
                                SET @soluongMB = @soluongMB - @soluong
                               
							    UPDATE  dbo.LENHDAT
                                SET     SOLUONG = 0, TRANGTHAILENH = N'Khớp hết'
                                WHERE CURRENT OF @CrsrVar
                            END
                        ELSE
                            BEGIN
                                SET @soluongkhop = @soluongMB

							  
                                SET @giakhop = @giadat
       
                                UPDATE  dbo.LENHDAT
                                SET     SOLUONG = SOLUONG - @soluongMB, TRANGTHAILENH = N'Khớp lệnh 1 phần'
                                WHERE CURRENT OF @CrsrVar
                                SET @soluongMB = 0
                            END
                      
					  -- cập nhật tổng số lượng khớp của lệnh gưi vào
                        SET @soluongkhopALL = @soluongkhopALL + @soluongkhop
                                
			 -- Cập nhật table LENHKHOP
                        INSERT  INTO dbo.LENHKHOP
                                ( NGAYKHOP ,
                                  SOLUONGKHOP ,
                                  GIAKHOP ,
                                  IDLENHDAT
	                            )
                        VALUES  ( GETDATE() , -- NGAYKHOP - datetime   
                                  @soluongkhop , -- SOLUONGKHOP - int
                                  @giakhop , -- GIAKHOP - float
                                  @IDLENHDAT -- IDLENHDAT - int
	                            )

		     	-- Câp nhật thông tin vào 	[dbo].[BANG_GIA_TRUC_TUYEN]
						IF EXISTS(SELECT * FROM dbo.BANG_GIA_TRUC_TUYEN WHERE MACP = @macp)
						BEGIN
							UPDATE dbo.BANG_GIA_TRUC_TUYEN
							SET KL_GIA = @giakhop, KL_KL = @soluongkhop
							WHERE MACP = @macp
						END
						ELSE
                        BEGIN
                        	INSERT INTO dbo.BANG_GIA_TRUC_TUYEN( MACP ,  KL_GIA , KL_KL )
                        	VALUES  ( @macp, @giakhop, @soluongkhop )
                        	       
                        END


    
                    END
                ELSE
                    GOTO THOAT
 



            FETCH NEXT FROM @CrsrVar INTO @IDLENHDAT, @ngaydat, @soluong,
                @giadat
            
        END
    THOAT:
    IF ( @soluongMB > 0  AND @soluongkhopALL > 0)
        BEGIN
            INSERT  INTO LENHDAT
                    ( MACP ,
                      NGAYDAT ,
                      LOAIGD ,
                      LOAILENH ,
                      SOLUONG ,
                      GIADAT ,
                      TRANGTHAILENH
                    )
            VALUES  ( @macp ,
                      @ngaydat ,
                      @LoaiGD ,
                      N'LO' ,
                      @soluongMB ,
                      @giadatMB ,
                      N'Khớp lệnh 1 phần'
                    )
        END
	ELSE IF ( @soluongMB > 0  AND @soluongkhopALL = 0)
		BEGIN
			 INSERT  INTO LENHDAT
                    ( MACP ,
                      NGAYDAT ,
                      LOAIGD ,
                      LOAILENH ,
                      SOLUONG ,
                      GIADAT ,
                      TRANGTHAILENH
                    )
            VALUES  ( @macp ,
                      @ngaydat ,
                      @LoaiGD ,
                      N'LO' ,
                      @soluongMB ,
                      @giadatMB ,
                      N'Chờ khớp'
                    )
		END
	-- in ra kết quả  số lượng cổ phiếu khớp theo thuật toán khớp lệnh liên tục khi có 1 lệnh mua hoặc bán được gởi đến bảng LENHDAT
    PRINT N'Số lương cổ phiếu khớp: ' + CAST(@soluongkhopALL AS NVARCHAR(10))
    CLOSE @CrsrVar
    DEALLOCATE @CrsrVar



GO
/****** Object:  StoredProcedure [dbo].[SqlQueryNotificationStoredProcedure-1b69c053-ad65-442d-bb2a-a3d35af2e103]    Script Date: Sat 4 18 2020 12:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SqlQueryNotificationStoredProcedure-1b69c053-ad65-442d-bb2a-a3d35af2e103] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-1b69c053-ad65-442d-bb2a-a3d35af2e103]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-1b69c053-ad65-442d-bb2a-a3d35af2e103] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-1b69c053-ad65-442d-bb2a-a3d35af2e103') > 0)   DROP SERVICE [SqlQueryNotificationService-1b69c053-ad65-442d-bb2a-a3d35af2e103]; if (OBJECT_ID('SqlQueryNotificationService-1b69c053-ad65-442d-bb2a-a3d35af2e103', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-1b69c053-ad65-442d-bb2a-a3d35af2e103]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-1b69c053-ad65-442d-bb2a-a3d35af2e103]; END COMMIT TRANSACTION; END
GO
