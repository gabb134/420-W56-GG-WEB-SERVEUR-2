/* Ajouter une procédure pour l'ajout d'un employee*/
Create procedure spAddEmployee     
(    
    @FirstName VARCHAR(20), 
    @LastName VARCHAR(20),    
    @Gender VARCHAR(6),    
    @Department VARCHAR(20),    
    @City VARCHAR(20)    
)    
as     
Begin     
    Insert into tbEmployee (FirstName, LastName, Gender, Department, City)     
    Values (@FirstName, @LastName, @Gender,@Department, @City)     
End


