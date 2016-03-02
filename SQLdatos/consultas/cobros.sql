declare @anno varchar(4)
declare @mes int
declare @concepto integer
declare @v1 varchar
declare @v2 varchar


set @anno = '2006'
set @mes = 2

SELECT matricula.carnet,  @concepto as concepto, @mes as mes, @v1 as recibo , @v2 as fecha_recibo,
	 niveles.cobros - matricula.beca  AS monto,  getdate() as generado, matricula.id_mat
	FROM matricula INNER JOIN niveles ON matricula.nivel = niveles.nivel 
	WHERE (matricula.ano = @anno) and not (id_mat in (select id_mat from cobros where mes=@mes and year(generado)=@anno ))