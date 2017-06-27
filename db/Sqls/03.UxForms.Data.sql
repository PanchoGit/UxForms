USE UxForms
GO

SET IDENTITY_INSERT app.FieldType ON
INSERT INTO app.FieldType ( Id, Name ) VALUES (1, 'Simple')
INSERT INTO app.FieldType ( Id, Name ) VALUES (2, 'Multiple')
SET IDENTITY_INSERT app.FieldType OFF

SET IDENTITY_INSERT app.Form ON
INSERT INTO app.Form ( Id, Name ) VALUES (1, 'Form1')
SET IDENTITY_INSERT app.Form OFF

SET IDENTITY_INSERT app.Field ON
INSERT INTO app.Field ( Id, FormId, Name ) VALUES (1, 1, 'Field1' )
INSERT INTO app.Field ( Id, FormId, Name ) VALUES (2, 1, 'Field2' )
INSERT INTO app.Field ( Id, FormId, Name ) VALUES (3, 1, 'Field3' )
SET IDENTITY_INSERT app.Field OFF
