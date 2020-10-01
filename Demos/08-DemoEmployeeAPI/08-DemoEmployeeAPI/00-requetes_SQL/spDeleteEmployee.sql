/* Ajouter une procédure pour la suppression d'un employee*/
Create procedure spDeleteEmployee     
(      
   @EmpId int      
)      
as       
begin      
   Delete from tbEmployee where EmployeeId=@EmpId      
End

