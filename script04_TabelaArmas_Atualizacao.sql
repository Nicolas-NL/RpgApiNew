BEGIN TRANSACTION;
GO

ALTER TABLE [Armas] ADD [PersonagemId] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [Armas] ADD [UsuarioId] int NULL;
GO

ALTER TABLE [Armas] ADD [armaId] int NULL;
GO

UPDATE [Armas] SET [PersonagemId] = 1, [UsuarioId] = NULL, [armaId] = NULL
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Armas] SET [PersonagemId] = 2, [UsuarioId] = NULL, [armaId] = NULL
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Armas] SET [PersonagemId] = 3, [UsuarioId] = NULL, [armaId] = NULL
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Armas] SET [PersonagemId] = 4, [UsuarioId] = NULL, [armaId] = NULL
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Armas] SET [PersonagemId] = 5, [UsuarioId] = NULL, [armaId] = NULL
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Armas] SET [PersonagemId] = 6, [UsuarioId] = NULL, [armaId] = NULL
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Armas] SET [PersonagemId] = 7, [UsuarioId] = NULL, [armaId] = NULL
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [Usuarios] SET [PasswordHash] = 0xF45F8DF604DFD9E1A02748D54D77EFD0688DD761C63B011518D132FAA9BF383C, [PasswordSalt] = 0xC2BAD13A75D6ABF341FF097395C334B53AD06E948DD26B210E3BFB0BF76A6920BE7AB86EF728B52AC5F8829C23611E72747E5366449EFA7A999A760C455831A0
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

CREATE INDEX [IX_Armas_armaId] ON [Armas] ([armaId]);
GO

CREATE INDEX [IX_Armas_PersonagemId] ON [Armas] ([PersonagemId]);
GO

CREATE INDEX [IX_Armas_UsuarioId] ON [Armas] ([UsuarioId]);
GO

ALTER TABLE [Armas] ADD CONSTRAINT [FK_Armas_Armas_armaId] FOREIGN KEY ([armaId]) REFERENCES [Armas] ([Id]);
GO

ALTER TABLE [Armas] ADD CONSTRAINT [FK_Armas_Personagens_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [Personagens] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Armas] ADD CONSTRAINT [FK_Armas_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230807110116_MigracaoUmParaUm', N'7.0.4');
GO

COMMIT;
GO

