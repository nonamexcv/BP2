﻿ALTER TABLE [dbo].[IsOnMedia]
	ADD CONSTRAINT [IsOnMedia_FK]
	FOREIGN KEY (MediaID)
	REFERENCES [Media] (MediaID)
