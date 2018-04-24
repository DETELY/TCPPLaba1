GO    
ALTER TABLE Client
ADD CONSTRAINT FK_Client_Holdings FOREIGN KEY (clientID)     
    REFERENCES Holdings (clientID)  
    ON DELETE CASCADE    
    ON UPDATE CASCADE    
;    
GO  