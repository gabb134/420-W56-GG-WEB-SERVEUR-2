/* Ajouter une procédure pour la modification d'un employee*/

Create procedure spUpdateEmployee     
(      
   @EmpId INTEGER ,    
   @FirstName VARCHAR(20), 
   @LastName VARCHAR(20),         
   @City VARCHAR(20),    
   @Department VARCHAR(20),    
   @Gender VARCHAR(6)    
)      
as      
begin      
   Update tbEmployee       
   set FirstName=@FirstName,      
   LastName=@LastName,
   Gender=@Gender,      
   Department=@Department,    
   City=@City      
   where EmployeeId=@EmpId      
End

