select cobros.carnet, cobros.mes, cobros.recibo, cobros.fecha_recibo, cobros.monto, cobros.generado, cobros.id_cobro
from            cobros left outer join
                         matricula on cobros.id_mat = matricula.id_mat
where        (cobros.recibo is null) and (cobros.carnet ='000000000')
order by cobros.mes