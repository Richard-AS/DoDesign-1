@echo Instalador de BDEComerce
osql -S. -E -i "DoDesign.sql"
osql -S. -E -i "DoDesignAlter.sql"
osql -S. -E -i "DoDesignDatos.sql"
@echo Base de Datos instalado correctamente
pause
