///anticipar el siguiente select si es asociable

document.addEventListener("DOMContentLoaded", function () {
            const areaSelect = document.querySelector('select[name="Input.Area"]');
            const empresaSelect = document.querySelector('select[name="Input.Empresa"]');
            areaSelect.addEventListener("change", function () {
                const area = this.value;

                // Limpia la selección actual de empresa
                empresaSelect.value = "";

                // Asocia areas con sus emprsas 
                const mapa = {
                    "Petroliferos": "Pemex",
                    "Electricidad" :"CFE",
                    "Gas Licuado": "Privada 1",
                    "Gas Natural" : "Privada 2",
                    "Hidrocarburos":"Privada 3",
                };
                // Si existe relación selecciona la empresa k corresponde
                if (mapa[area]) {
                    empresaSelect.value = mapa[area];
                }
            });
        });

      ////script para validar y anticipar la seleccion del siguiente
      // select en base si se asocian

      document.addEventListener("DOMContentLoaded",function(){
        const ISOSelect = document.querySelector('select[name="Input.ISO"]');
        const NOMSelect = document.querySelector('select[name="Input.NOM"]');
        ISOSelect.addEventListener("change",function(){
            const ISO = this.value;
            NOMSelect.value ="";
            const map = {
                "ISO-90001":"NOM-2390-013",
                "ISO-90002":"NOM-3452-093",
                "ISO-90003":"NOM-3466-666",
                "ISO-90004":"NOM-8903-123",
                "ISO-90005":"NOM-7890-234"
            };
            if(map[ISO]){
                NOMSelect.value = map[ISO]
            }
        });
      });

      ///scripts para contrato y requerimiento
      document.addEventListener("DOMContentLoaded",function(){
        const contratoSelect= document.querySelector('select[name="Input.Contrato"]');
        const RequerimientoSelect = document.querySelector('select[name="Input.Requerimiento"]');
        contratoSelect.addEventListener("change",function(){

                const contrato = this.value;
                RequerimientoSelect.value="";

                map = {
                    "CNE-8905-2345":"Requerimiento 1",
                    "CNE-2839-2929":"Requerimiento 2",
                    "CNE-2929-2929":"Requerimiento 3",
                    "CNE-2929-2202":"Requerimiento 4",
                    "CNE-2812-1234":"Requerimiento 5"
                };

                if(map[contrato]){
                    RequerimientoSelect.value=map[contrato];
                }


        });
      });

      ///script oermiso-peticion
 
      document.addEventListener("DOMContentLoaded",function(){
        const permisoSelect = document.querySelector('select[name="Input.Permiso"]');
        const peticionSelect = document.querySelector('select[name="Input.Peticion"]');
        permisoSelect.addEventListener("change",function(){

            const permiso = this.value;
            peticionSelect.value="";

            map = {

                "CNE-P1234-333":"Peticion 299737",
                "CNE-12344-999":"Peticion 334578",
                "CNE-23399-666":"Peticion 383763",
                "CNE-36779-927":"Peticion 837633",
                "CNE-92776-983":"Peticion 235753"
            };

            if (map[permiso]){
                peticionSelect.value=map[permiso]
            }

        });
      });

/// script para modal archivoo
