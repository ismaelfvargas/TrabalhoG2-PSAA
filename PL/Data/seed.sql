use SecondHand

SET IDENTITY_INSERT [dbo].[Alunos] ON
INSERT INTO [dbo].[Alunos] ([AlunoVagaId], [NomeAluno], [AulaPresencialId]) VALUES (1, N'teste teste', 2)
SET IDENTITY_INSERT [dbo].[Alunos] OFF

SET IDENTITY_INSERT [dbo].[Aulas] ON
INSERT INTO [dbo].[Aulas] ([AulaPresencialId], [CodCred], [Turma], [Data]) VALUES (9, 1234, N'Matemática Discreta', N'2021-07-14 00:00:00')
INSERT INTO [dbo].[Aulas] ([AulaPresencialId], [CodCred], [Turma], [Data]) VALUES (10, 6754, N'Curso React Native', N'2021-07-08 00:00:00')
INSERT INTO [dbo].[Aulas] ([AulaPresencialId], [CodCred], [Turma], [Data]) VALUES (11, 7652, N'Curso NodeJS', N'2021-07-08 00:00:00')
SET IDENTITY_INSERT [dbo].[Aulas] OFF