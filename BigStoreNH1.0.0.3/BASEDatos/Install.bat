@echo Instalador de BDEComerce
osql -S. -E -i "BDEcommerce.sql"
osql -S. -E -i "PA BDEcommerce.sql"
osql -S. -E -i "proc.sql"
osql -S. -E -i "PAClientePasarela.sql"
@echo Base de Datos instalado correctamente
pause
