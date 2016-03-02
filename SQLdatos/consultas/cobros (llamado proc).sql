/*
	inserta en cobros el llamado del procedimiento cobro	
*/

INSERT cobros(carnet,concepto,mes,recibo,fecha_recibo,monto,generado,id_mat) EXECUTE cobro '2005','1','Mensualidad'