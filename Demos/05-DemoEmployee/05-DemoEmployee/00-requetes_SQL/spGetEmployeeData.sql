/* Ajouter une procédure pour recupérer un employee */
Create procedure spGetEmployeeData
(
   @EmpId INTEGER 
)   
as    
Begin    
    select *    
    from tbEmployee  
    where EmployeeId=@EmpId  
End





