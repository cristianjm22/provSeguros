    
      
 delete [COMPROBANTES_PAGO_PROV_SEG]
 
 delete [DEUDAS]
 
 DBCC CHECKIDENT (COMPROBANTES_PAGO_PROV_SEG, RESEED,0)
 DBCC CHECKIDENT ([DEUDAS], RESEED,0)