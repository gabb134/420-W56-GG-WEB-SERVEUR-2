Create procedure spAddProduit
(
@Designation VARCHAR(20),
@Prix DECIMAL
)
as
Begin
 Insert into tbProduit(strDesignation, dblPrix)
 Values(@Designation, @Prix)
End



Create procedure spUpdateProduit
(
@IdProduit INTEGER,
@Designation VARCHAR(20),
@Prix DECIMAL
)
As
	begin
		Update tbProduit
		set strDesignatio=@Designation,
		dblPrix=@Prix
		where IdProduit=@IdProduit
End


Create procedure spDeleteProduit
(
@IdProduit INT
)
As
begin
	Delete from tbProduit where IdProduit=@IdProduit
End


Create procedure spGetAllProduits
as
Begin
	select * from tbProduit
End


select * from dbo.tbProduit

INSERT INTO tbProduit (strDesignation, dblPrix) values ('TestAjout',28)